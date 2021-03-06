// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/api.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Api {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static Api() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "Chlnb29nbGUvcHJvdG9idWYvYXBpLnByb3RvEg9nb29nbGUucHJvdG9idWYa", 
              "JGdvb2dsZS9wcm90b2J1Zi9zb3VyY2VfY29udGV4dC5wcm90bxoaZ29vZ2xl", 
              "L3Byb3RvYnVmL3R5cGUucHJvdG8isAEKA0FwaRIMCgRuYW1lGAEgASgJEigK", 
              "B21ldGhvZHMYAiADKAsyFy5nb29nbGUucHJvdG9idWYuTWV0aG9kEigKB29w", 
              "dGlvbnMYAyADKAsyFy5nb29nbGUucHJvdG9idWYuT3B0aW9uEg8KB3ZlcnNp", 
              "b24YBCABKAkSNgoOc291cmNlX2NvbnRleHQYBSABKAsyHi5nb29nbGUucHJv", 
              "dG9idWYuU291cmNlQ29udGV4dCKsAQoGTWV0aG9kEgwKBG5hbWUYASABKAkS", 
              "GAoQcmVxdWVzdF90eXBlX3VybBgCIAEoCRIZChFyZXF1ZXN0X3N0cmVhbWlu", 
              "ZxgDIAEoCBIZChFyZXNwb25zZV90eXBlX3VybBgEIAEoCRIaChJyZXNwb25z", 
              "ZV9zdHJlYW1pbmcYBSABKAgSKAoHb3B0aW9ucxgGIAMoCzIXLmdvb2dsZS5w", 
              "cm90b2J1Zi5PcHRpb25CSAoTY29tLmdvb2dsZS5wcm90b2J1ZkIIQXBpUHJv", 
              "dG9QAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IG", 
              "cHJvdG8z"));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.Proto.SourceContext.Descriptor, global::Google.Protobuf.WellKnownTypes.Proto.Type.Descriptor, },
            new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
              new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Api), new[]{ "Name", "Methods", "Options", "Version", "SourceContext" }, null, null, null),
              new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Method), new[]{ "Name", "RequestTypeUrl", "RequestStreaming", "ResponseTypeUrl", "ResponseStreaming", "Options" }, null, null, null)
            }));
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Api : pb::IMessage<Api> {
    private static readonly pb::MessageParser<Api> _parser = new pb::MessageParser<Api>(() => new Api());
    public static pb::MessageParser<Api> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Proto.Api.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Api() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Api(Api other) : this() {
      name_ = other.name_;
      methods_ = other.methods_.Clone();
      options_ = other.options_.Clone();
      version_ = other.version_;
      SourceContext = other.sourceContext_ != null ? other.SourceContext.Clone() : null;
    }

    public Api Clone() {
      return new Api(this);
    }

    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int MethodsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Method.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Method> methods_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Method>();
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Method> Methods {
      get { return methods_; }
    }

    public const int OptionsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Protobuf.WellKnownTypes.Option.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> options_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option>();
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> Options {
      get { return options_; }
    }

    public const int VersionFieldNumber = 4;
    private string version_ = "";
    public string Version {
      get { return version_; }
      set {
        version_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int SourceContextFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
    public global::Google.Protobuf.WellKnownTypes.SourceContext SourceContext {
      get { return sourceContext_; }
      set {
        sourceContext_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Api);
    }

    public bool Equals(Api other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!methods_.Equals(other.methods_)) return false;
      if(!options_.Equals(other.options_)) return false;
      if (Version != other.Version) return false;
      if (!object.Equals(SourceContext, other.SourceContext)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= methods_.GetHashCode();
      hash ^= options_.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (sourceContext_ != null) hash ^= SourceContext.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      methods_.WriteTo(output, _repeated_methods_codec);
      options_.WriteTo(output, _repeated_options_codec);
      if (Version.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Version);
      }
      if (sourceContext_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SourceContext);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += methods_.CalculateSize(_repeated_methods_codec);
      size += options_.CalculateSize(_repeated_options_codec);
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (sourceContext_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourceContext);
      }
      return size;
    }

    public void MergeFrom(Api other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      methods_.Add(other.methods_);
      options_.Add(other.options_);
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.sourceContext_ != null) {
        if (sourceContext_ == null) {
          sourceContext_ = new global::Google.Protobuf.WellKnownTypes.SourceContext();
        }
        SourceContext.MergeFrom(other.SourceContext);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while (input.ReadTag(out tag)) {
        switch(tag) {
          case 0:
            throw pb::InvalidProtocolBufferException.InvalidTag();
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            methods_.AddEntriesFrom(input, _repeated_methods_codec);
            break;
          }
          case 26: {
            options_.AddEntriesFrom(input, _repeated_options_codec);
            break;
          }
          case 34: {
            Version = input.ReadString();
            break;
          }
          case 42: {
            if (sourceContext_ == null) {
              sourceContext_ = new global::Google.Protobuf.WellKnownTypes.SourceContext();
            }
            input.ReadMessage(sourceContext_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Method : pb::IMessage<Method> {
    private static readonly pb::MessageParser<Method> _parser = new pb::MessageParser<Method>(() => new Method());
    public static pb::MessageParser<Method> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Proto.Api.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Method() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Method(Method other) : this() {
      name_ = other.name_;
      requestTypeUrl_ = other.requestTypeUrl_;
      requestStreaming_ = other.requestStreaming_;
      responseTypeUrl_ = other.responseTypeUrl_;
      responseStreaming_ = other.responseStreaming_;
      options_ = other.options_.Clone();
    }

    public Method Clone() {
      return new Method(this);
    }

    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int RequestTypeUrlFieldNumber = 2;
    private string requestTypeUrl_ = "";
    public string RequestTypeUrl {
      get { return requestTypeUrl_; }
      set {
        requestTypeUrl_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int RequestStreamingFieldNumber = 3;
    private bool requestStreaming_;
    public bool RequestStreaming {
      get { return requestStreaming_; }
      set {
        requestStreaming_ = value;
      }
    }

    public const int ResponseTypeUrlFieldNumber = 4;
    private string responseTypeUrl_ = "";
    public string ResponseTypeUrl {
      get { return responseTypeUrl_; }
      set {
        responseTypeUrl_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int ResponseStreamingFieldNumber = 5;
    private bool responseStreaming_;
    public bool ResponseStreaming {
      get { return responseStreaming_; }
      set {
        responseStreaming_ = value;
      }
    }

    public const int OptionsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Protobuf.WellKnownTypes.Option.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> options_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option>();
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> Options {
      get { return options_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Method);
    }

    public bool Equals(Method other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (RequestTypeUrl != other.RequestTypeUrl) return false;
      if (RequestStreaming != other.RequestStreaming) return false;
      if (ResponseTypeUrl != other.ResponseTypeUrl) return false;
      if (ResponseStreaming != other.ResponseStreaming) return false;
      if(!options_.Equals(other.options_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (RequestTypeUrl.Length != 0) hash ^= RequestTypeUrl.GetHashCode();
      if (RequestStreaming != false) hash ^= RequestStreaming.GetHashCode();
      if (ResponseTypeUrl.Length != 0) hash ^= ResponseTypeUrl.GetHashCode();
      if (ResponseStreaming != false) hash ^= ResponseStreaming.GetHashCode();
      hash ^= options_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (RequestTypeUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RequestTypeUrl);
      }
      if (RequestStreaming != false) {
        output.WriteRawTag(24);
        output.WriteBool(RequestStreaming);
      }
      if (ResponseTypeUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResponseTypeUrl);
      }
      if (ResponseStreaming != false) {
        output.WriteRawTag(40);
        output.WriteBool(ResponseStreaming);
      }
      options_.WriteTo(output, _repeated_options_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (RequestTypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestTypeUrl);
      }
      if (RequestStreaming != false) {
        size += 1 + 1;
      }
      if (ResponseTypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResponseTypeUrl);
      }
      if (ResponseStreaming != false) {
        size += 1 + 1;
      }
      size += options_.CalculateSize(_repeated_options_codec);
      return size;
    }

    public void MergeFrom(Method other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.RequestTypeUrl.Length != 0) {
        RequestTypeUrl = other.RequestTypeUrl;
      }
      if (other.RequestStreaming != false) {
        RequestStreaming = other.RequestStreaming;
      }
      if (other.ResponseTypeUrl.Length != 0) {
        ResponseTypeUrl = other.ResponseTypeUrl;
      }
      if (other.ResponseStreaming != false) {
        ResponseStreaming = other.ResponseStreaming;
      }
      options_.Add(other.options_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while (input.ReadTag(out tag)) {
        switch(tag) {
          case 0:
            throw pb::InvalidProtocolBufferException.InvalidTag();
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            RequestTypeUrl = input.ReadString();
            break;
          }
          case 24: {
            RequestStreaming = input.ReadBool();
            break;
          }
          case 34: {
            ResponseTypeUrl = input.ReadString();
            break;
          }
          case 40: {
            ResponseStreaming = input.ReadBool();
            break;
          }
          case 50: {
            options_.AddEntriesFrom(input, _repeated_options_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
