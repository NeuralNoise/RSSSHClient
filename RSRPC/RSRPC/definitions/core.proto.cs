//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: core.proto
namespace rsctrl.core
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Status")]
  public partial class Status : global::ProtoBuf.IExtensible
  {
    public Status() {}
    
    private rsctrl.core.Status.StatusCode _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public rsctrl.core.Status.StatusCode code
    {
      get { return _code; }
      set { _code = value; }
    }

    private string _msg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"StatusCode")]
    public enum StatusCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FAILED", Value=0)]
      FAILED = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NO_IMPL_YET", Value=1)]
      NO_IMPL_YET = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INVALID_QUERY", Value=2)]
      INVALID_QUERY = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PARTIAL_SUCCESS", Value=3)]
      PARTIAL_SUCCESS = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUCCESS", Value=4)]
      SUCCESS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"READMSG", Value=5)]
      READMSG = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IpAddr")]
  public partial class IpAddr : global::ProtoBuf.IExtensible
  {
    public IpAddr() {}
    
    private string _addr;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"addr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string addr
    {
      get { return _addr; }
      set { _addr = value; }
    }
    private uint _port;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint port
    {
      get { return _port; }
      set { _port = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Location")]
  public partial class Location : global::ProtoBuf.IExtensible
  {
    public Location() {}
    
    private string _ssl_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ssl_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ssl_id
    {
      get { return _ssl_id; }
      set { _ssl_id = value; }
    }
    private string _location;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string location
    {
      get { return _location; }
      set { _location = value; }
    }
    private rsctrl.core.IpAddr _localaddr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"localaddr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public rsctrl.core.IpAddr localaddr
    {
      get { return _localaddr; }
      set { _localaddr = value; }
    }
    private rsctrl.core.IpAddr _extaddr;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"extaddr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public rsctrl.core.IpAddr extaddr
    {
      get { return _extaddr; }
      set { _extaddr = value; }
    }
    private uint _state;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"StateFlags")]
    public enum StateFlags
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ONLINE", Value=1)]
      ONLINE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONNECTED", Value=2)]
      CONNECTED = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNREACHABLE", Value=4)]
      UNREACHABLE = 4
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Person")]
  public partial class Person : global::ProtoBuf.IExtensible
  {
    public Person() {}
    
    private string _gpg_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gpg_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gpg_id
    {
      get { return _gpg_id; }
      set { _gpg_id = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private rsctrl.core.Person.Relationship _relation;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"relation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public rsctrl.core.Person.Relationship relation
    {
      get { return _relation; }
      set { _relation = value; }
    }
    private readonly global::System.Collections.Generic.List<rsctrl.core.Location> _locations = new global::System.Collections.Generic.List<rsctrl.core.Location>();
    [global::ProtoBuf.ProtoMember(4, Name=@"locations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<rsctrl.core.Location> locations
    {
      get { return _locations; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Relationship")]
    public enum Relationship
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"YOURSELF", Value=1)]
      YOURSELF = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FRIEND", Value=2)]
      FRIEND = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FRIEND_OF_MANY_FRIENDS", Value=3)]
      FRIEND_OF_MANY_FRIENDS = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FRIEND_OF_FRIENDS", Value=4)]
      FRIEND_OF_FRIENDS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNKNOWN", Value=5)]
      UNKNOWN = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"File")]
  public partial class File : global::ProtoBuf.IExtensible
  {
    public File() {}
    
    private string _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _hash;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"hash", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string hash
    {
      get { return _hash; }
      set { _hash = value; }
    }
    private ulong _size;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong size
    {
      get { return _size; }
      set { _size = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Dir")]
  public partial class Dir : global::ProtoBuf.IExtensible
  {
    public Dir() {}
    
    private string _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _path;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string path
    {
      get { return _path; }
      set { _path = value; }
    }
    private readonly global::System.Collections.Generic.List<rsctrl.core.Dir> _subdirs = new global::System.Collections.Generic.List<rsctrl.core.Dir>();
    [global::ProtoBuf.ProtoMember(3, Name=@"subdirs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<rsctrl.core.Dir> subdirs
    {
      get { return _subdirs; }
    }
  
    private readonly global::System.Collections.Generic.List<rsctrl.core.File> _files = new global::System.Collections.Generic.List<rsctrl.core.File>();
    [global::ProtoBuf.ProtoMember(4, Name=@"files", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<rsctrl.core.File> files
    {
      get { return _files; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Timestamp")]
  public partial class Timestamp : global::ProtoBuf.IExtensible
  {
    public Timestamp() {}
    
    private ulong _secs;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"secs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong secs
    {
      get { return _secs; }
      set { _secs = value; }
    }
    private uint _microsecs;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"microsecs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint microsecs
    {
      get { return _microsecs; }
      set { _microsecs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SystemStatus")]
  public partial class SystemStatus : global::ProtoBuf.IExtensible
  {
    public SystemStatus() {}
    
    private rsctrl.core.SystemStatus.NetCode _net_status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"net_status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public rsctrl.core.SystemStatus.NetCode net_status
    {
      get { return _net_status; }
      set { _net_status = value; }
    }

    private string _msg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"NetCode")]
    public enum NetCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BAD_UNKNOWN", Value=0)]
      BAD_UNKNOWN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BAD_OFFLINE", Value=1)]
      BAD_OFFLINE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BAD_NATSYM", Value=2)]
      BAD_NATSYM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BAD_NODHT_NAT", Value=3)]
      BAD_NODHT_NAT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WARNING_RESTART", Value=4)]
      WARNING_RESTART = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WARNING_NATTED", Value=5)]
      WARNING_NATTED = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WARNING_NODHT", Value=6)]
      WARNING_NODHT = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOOD", Value=7)]
      GOOD = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADV_FORWARD", Value=8)]
      ADV_FORWARD = 8
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Bandwidth")]
  public partial class Bandwidth : global::ProtoBuf.IExtensible
  {
    public Bandwidth() {}
    
    private float _up;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"up", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float up
    {
      get { return _up; }
      set { _up = value; }
    }
    private float _down;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"down", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float down
    {
      get { return _down; }
      set { _down = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BandwidthSet")]
  public partial class BandwidthSet : global::ProtoBuf.IExtensible
  {
    public BandwidthSet() {}
    
    private readonly global::System.Collections.Generic.List<rsctrl.core.Bandwidth> _bandwidths = new global::System.Collections.Generic.List<rsctrl.core.Bandwidth>();
    [global::ProtoBuf.ProtoMember(1, Name=@"bandwidths", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<rsctrl.core.Bandwidth> bandwidths
    {
      get { return _bandwidths; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ExtensionId")]
    public enum ExtensionId
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CORE", Value=0)]
      CORE = 0
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"PackageId")]
    public enum PackageId
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PEERS", Value=1)]
      PEERS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SYSTEM", Value=2)]
      SYSTEM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHAT", Value=3)]
      CHAT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SEARCH", Value=4)]
      SEARCH = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FILES", Value=5)]
      FILES = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STREAM", Value=6)]
      STREAM = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GXS", Value=1000)]
      GXS = 1000
    }
  
}