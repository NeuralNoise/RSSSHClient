﻿using System;
using System.Collections.Generic;

using rsctrl.core;
using rsctrl.peers;

using Sehraf.RSRPC;

namespace RetroShareSSHClient
{
    class PeerProcessor
    {
        Person _owner;
        List<Person> _friendList;
        Person _selectedFriend;

        Bridge _b;

        public PeerProcessor(Bridge bridge)
        {
            _b = bridge;

            _owner = new Person();
            _friendList = new List<Person>();
            _selectedFriend = new Person();
        }

        public void UpdatePeerList(ResponsePeerList msg)
        {
            int index1 = _b.GUI.lb_friends.SelectedIndex, index2 = _b.GUI.lb_locations.SelectedIndex;
            _b.GUI.lb_friends.Items.Clear();
            ClearPeerForm();
            _friendList.Clear();
            List<Location> locs = new List<rsctrl.core.Location>();
            _friendList = msg.peers;
            if (_owner.locations.Count > 0)
                _friendList.Add(_owner);
            _friendList.Sort(new PersonComparer());
            foreach (Person p in _friendList)
            {
                locs = p.locations;
                byte online = 0, total = 0;
                foreach (Location l in locs)
                {
                    total++;
                    switch (l.state)
                    {
                        case ((uint)rsctrl.core.Location.StateFlags.CONNECTED):
                        case ((uint)rsctrl.core.Location.StateFlags.ONLINE):
                        case ((uint)(rsctrl.core.Location.StateFlags.CONNECTED | rsctrl.core.Location.StateFlags.ONLINE)):
                            online++;
                            break;
                        default: // offline
                            break;
                    }
                }
                _b.GUI.lb_friends.Items.Add("(" + online + "/" + total + ") " + p.name);
            }
            _b.GUI.lb_friends.SelectedIndex = index1;
            _b.GUI.lb_locations.SelectedIndex = index2;
            //lb_locations_SelectedIndexChanged(null, null);
        }

        public void SetOwnID(ResponsePeerList msg)
        {
            _owner = msg.peers[0]; // i gues we just have one owner           
            _b.GUI.Text = "RetroShare SSH Client by sehraf - " + _owner.name + "(" + _owner.gpg_id + ") ";// +l.location + " (" + l.ssl_id + ")";

            if (_b.ChatProcessor.Nick == "" || _b.ChatProcessor.Nick == null)
            {
                string name = _owner.name.Trim();
                _b.ChatProcessor.SetNick(name + " (nogui/ssh)");
            }
        }

        private void ClearPeerForm()
        {
            _b.GUI.lb_locations.Items.Clear();
            _b.GUI.tb_peerName.Clear();
            _b.GUI.tb_peerID.Clear();
            _b.GUI.tb_peerLocation.Clear();
            _b.GUI.tb_peerLocationID.Clear();
            _b.GUI.tb_peerIPExt.Clear();
            _b.GUI.tb_peerIPInt.Clear();
            _b.GUI.nud_peerPortExt.Value = _b.GUI.nud_peerPortExt.Minimum;
            _b.GUI.nud_peerPortInt.Value = _b.GUI.nud_peerPortInt.Minimum;
        }

        private bool PortInRange(uint port)
        {
            return (port >= 1024 && port <= UInt16.MaxValue);
        }

        public void FriendsSelectedIndexChanged(int index)
        {
            ClearPeerForm();
            Person p = _friendList[index];
            _selectedFriend = p;
            foreach (Location l in p.locations)
            {
                string state = "";
                switch (l.state)
                {
                    case ((uint)rsctrl.core.Location.StateFlags.CONNECTED):
                        state = "connected";
                        break;
                    case ((uint)rsctrl.core.Location.StateFlags.ONLINE):
                        state = "online";
                        break;
                    case ((uint)(rsctrl.core.Location.StateFlags.CONNECTED | rsctrl.core.Location.StateFlags.ONLINE)):
                        state = "connected online";
                        break;
                    case ((uint)rsctrl.core.Location.StateFlags.UNREACHABLE):
                        state = "unreachable";
                        break;
                    default:
                        state = "offline";
                        break;
                }
                _b.GUI.lb_locations.Items.Add(l.location + " - " + state);
            }
            _b.GUI.tb_peerName.Text = p.name;
            _b.GUI.tb_peerID.Text = p.gpg_id;
        }

        public void LocationSelevtedIndexChanged(int index)
        {
            Location l = _selectedFriend.locations[index];
            _b.GUI.tb_peerLocation.Text = l.location;
            _b.GUI.tb_peerLocationID.Text = l.ssl_id;
            _b.GUI.tb_peerIPExt.Text = l.extaddr.addr;
            if (PortInRange(l.extaddr.port))
                _b.GUI.nud_peerPortExt.Value = l.extaddr.port;
            _b.GUI.tb_peerIPInt.Text = l.localaddr.addr;
            if (PortInRange(l.localaddr.port))
                _b.GUI.nud_peerPortInt.Value = l.localaddr.port;
            //_b.GUI.tb_dyndns.Text = "NOT IMPLEMENTED";
        }

        public void SavePeer(int locationIndex)
        {
            Person p = _selectedFriend;
            Location l = p.locations[locationIndex];
            l.extaddr.addr = _b.GUI.tb_peerIPExt.Text;
            l.extaddr.port = Convert.ToUInt16(_b.GUI.nud_peerPortExt.Value);
            l.localaddr.addr = _b.GUI.tb_peerIPInt.Text;
            l.localaddr.port = Convert.ToUInt16(_b.GUI.nud_peerPortInt.Value);
            //dyndns
            p.locations[locationIndex] = l;
            _selectedFriend = p;
            uint reqID = _b.RPC.PeersModifyPeer(p, RequestModifyPeer.ModCmd.ADDRESS);
            // save request ???
        }
    }
}
