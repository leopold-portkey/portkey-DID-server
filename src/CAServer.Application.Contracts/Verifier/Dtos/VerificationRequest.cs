// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: verification_request.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from verification_request.proto</summary>
public static partial class VerificationRequestReflection {

  #region Descriptor
  /// <summary>File descriptor for verification_request.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static VerificationRequestReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chp2ZXJpZmljYXRpb25fcmVxdWVzdC5wcm90bxofZ29vZ2xlL3Byb3RvYnVm",
          "L3RpbWVzdGFtcC5wcm90byKMAQoTVmVyaWZpY2F0aW9uUmVxdWVzdBIMCgR0",
          "eXBlGAEgASgJEhsKE2d1YXJkaWFuX2lkZW50aWZpZXIYAiABKAkSGwoTdmVy",
          "aWZpZXJfc2Vzc2lvbl9pZBgDIAEoCRItCgl0aW1lc3RhbXAYBCABKAsyGi5n",
          "b29nbGUucHJvdG9idWYuVGltZXN0YW1wYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VerificationRequest), global::VerificationRequest.Parser, new[]{ "Type", "GuardianIdentifier", "VerifierSessionId", "Timestamp" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class VerificationRequest : pb::IMessage<VerificationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VerificationRequest> _parser = new pb::MessageParser<VerificationRequest>(() => new VerificationRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<VerificationRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::VerificationRequestReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VerificationRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VerificationRequest(VerificationRequest other) : this() {
    type_ = other.type_;
    guardianIdentifier_ = other.guardianIdentifier_;
    verifierSessionId_ = other.verifierSessionId_;
    timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VerificationRequest Clone() {
    return new VerificationRequest(this);
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 1;
  private string type_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Type {
    get { return type_; }
    set {
      type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "guardian_identifier" field.</summary>
  public const int GuardianIdentifierFieldNumber = 2;
  private string guardianIdentifier_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string GuardianIdentifier {
    get { return guardianIdentifier_; }
    set {
      guardianIdentifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "verifier_session_id" field.</summary>
  public const int VerifierSessionIdFieldNumber = 3;
  private string verifierSessionId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string VerifierSessionId {
    get { return verifierSessionId_; }
    set {
      verifierSessionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "timestamp" field.</summary>
  public const int TimestampFieldNumber = 4;
  private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
    get { return timestamp_; }
    set {
      timestamp_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as VerificationRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(VerificationRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Type != other.Type) return false;
    if (GuardianIdentifier != other.GuardianIdentifier) return false;
    if (VerifierSessionId != other.VerifierSessionId) return false;
    if (!object.Equals(Timestamp, other.Timestamp)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Type.Length != 0) hash ^= Type.GetHashCode();
    if (GuardianIdentifier.Length != 0) hash ^= GuardianIdentifier.GetHashCode();
    if (VerifierSessionId.Length != 0) hash ^= VerifierSessionId.GetHashCode();
    if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Type.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Type);
    }
    if (GuardianIdentifier.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(GuardianIdentifier);
    }
    if (VerifierSessionId.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(VerifierSessionId);
    }
    if (timestamp_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Timestamp);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Type.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Type);
    }
    if (GuardianIdentifier.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(GuardianIdentifier);
    }
    if (VerifierSessionId.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(VerifierSessionId);
    }
    if (timestamp_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Timestamp);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Type.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
    }
    if (GuardianIdentifier.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(GuardianIdentifier);
    }
    if (VerifierSessionId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(VerifierSessionId);
    }
    if (timestamp_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(VerificationRequest other) {
    if (other == null) {
      return;
    }
    if (other.Type.Length != 0) {
      Type = other.Type;
    }
    if (other.GuardianIdentifier.Length != 0) {
      GuardianIdentifier = other.GuardianIdentifier;
    }
    if (other.VerifierSessionId.Length != 0) {
      VerifierSessionId = other.VerifierSessionId;
    }
    if (other.timestamp_ != null) {
      if (timestamp_ == null) {
        Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
      }
      Timestamp.MergeFrom(other.Timestamp);
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Type = input.ReadString();
          break;
        }
        case 18: {
          GuardianIdentifier = input.ReadString();
          break;
        }
        case 26: {
          VerifierSessionId = input.ReadString();
          break;
        }
        case 34: {
          if (timestamp_ == null) {
            Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Timestamp);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Type = input.ReadString();
          break;
        }
        case 18: {
          GuardianIdentifier = input.ReadString();
          break;
        }
        case 26: {
          VerifierSessionId = input.ReadString();
          break;
        }
        case 34: {
          if (timestamp_ == null) {
            Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Timestamp);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code