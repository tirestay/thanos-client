//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BSToGC.proto
namespace BSToGC
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AskGateAddressRet")]
  public partial class AskGateAddressRet : global::ProtoBuf.IExtensible
  {
    public AskGateAddressRet() {}
    
    private BSToGC.MsgID _mgsid = BSToGC.MsgID.eMsgToGCFromBS_AskGateAddressRet;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"mgsid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(BSToGC.MsgID.eMsgToGCFromBS_AskGateAddressRet)]
    public BSToGC.MsgID mgsid
    {
      get { return _mgsid; }
      set { _mgsid = value; }
    }
    private int _gateclient = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gateclient", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gateclient
    {
      get { return _gateclient; }
      set { _gateclient = value; }
    }
    private string _token = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private string _user_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"user_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_name
    {
      get { return _user_name; }
      set { _user_name = value; }
    }
    private int _port = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int port
    {
      get { return _port; }
      set { _port = value; }
    }
    private string _ip = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ip
    {
      get { return _ip; }
      set { _ip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClinetLoginCheckRet")]
  public partial class ClinetLoginCheckRet : global::ProtoBuf.IExtensible
  {
    public ClinetLoginCheckRet() {}
    
    private BSToGC.MsgID _mgsid = BSToGC.MsgID.eMsgToGCFromBS_OneClinetLoginCheckRet;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"mgsid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(BSToGC.MsgID.eMsgToGCFromBS_OneClinetLoginCheckRet)]
    public BSToGC.MsgID mgsid
    {
      get { return _mgsid; }
      set { _mgsid = value; }
    }
    private uint _login_success = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"login_success", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint login_success
    {
      get { return _login_success; }
      set { _login_success = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"MsgID")]
    public enum MsgID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"eMsgToGCFromBS_AskGateAddressRet", Value=203)]
      eMsgToGCFromBS_AskGateAddressRet = 203,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eMsgToGCFromBS_OneClinetLoginCheckRet", Value=204)]
      eMsgToGCFromBS_OneClinetLoginCheckRet = 204
    }
  
}