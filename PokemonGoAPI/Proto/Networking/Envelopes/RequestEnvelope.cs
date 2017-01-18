// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Envelopes/RequestEnvelope.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Envelopes {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Envelopes/RequestEnvelope.proto</summary>
  public static partial class RequestEnvelopeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Envelopes/RequestEnvelope.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestEnvelopeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVQT0dPUHJvdG9zL05ldHdvcmtpbmcvRW52ZWxvcGVzL1JlcXVlc3RFbnZl",
            "bG9wZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLkVudmVsb3Blcxos",
            "UE9HT1Byb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL1JlcXVlc3QucHJvdG8a",
            "MFBPR09Qcm90b3MvTmV0d29ya2luZy9FbnZlbG9wZXMvQXV0aFRpY2tldC5w",
            "cm90bxouUE9HT1Byb3Rvcy9OZXR3b3JraW5nL0VudmVsb3Blcy9Vbmtub3du",
            "Ni5wcm90byK0BAoPUmVxdWVzdEVudmVsb3BlEhMKC3N0YXR1c19jb2RlGAEg",
            "ASgFEhIKCnJlcXVlc3RfaWQYAyABKAQSOQoIcmVxdWVzdHMYBCADKAsyJy5Q",
            "T0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVxdWVzdHMuUmVxdWVzdBI7Cgh1bmtu",
            "b3duNhgGIAEoCzIpLlBPR09Qcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMu",
            "VW5rbm93bjYSEAoIbGF0aXR1ZGUYByABKAESEQoJbG9uZ2l0dWRlGAggASgB",
            "EhAKCGFjY3VyYWN5GAkgASgBEkwKCWF1dGhfaW5mbxgKIAEoCzI5LlBPR09Q",
            "cm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuUmVxdWVzdEVudmVsb3BlLkF1",
            "dGhJbmZvEkAKC2F1dGhfdGlja2V0GAsgASgLMisuUE9HT1Byb3Rvcy5OZXR3",
            "b3JraW5nLkVudmVsb3Blcy5BdXRoVGlja2V0EiEKGW1zX3NpbmNlX2xhc3Rf",
            "bG9jYXRpb25maXgYDCABKAMalQEKCEF1dGhJbmZvEhAKCHByb3ZpZGVyGAEg",
            "ASgJEkwKBXRva2VuGAIgASgLMj0uUE9HT1Byb3Rvcy5OZXR3b3JraW5nLkVu",
            "dmVsb3Blcy5SZXF1ZXN0RW52ZWxvcGUuQXV0aEluZm8uSldUGikKA0pXVBIQ",
            "Cghjb250ZW50cxgBIAEoCRIQCgh1bmtub3duMhgCIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Networking.Requests.RequestReflection.Descriptor, global::POGOProtos.Networking.Envelopes.AuthTicketReflection.Descriptor, global::POGOProtos.Networking.Envelopes.Unknown6Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Envelopes.RequestEnvelope), global::POGOProtos.Networking.Envelopes.RequestEnvelope.Parser, new[]{ "StatusCode", "RequestId", "Requests", "Unknown6", "Latitude", "Longitude", "Accuracy", "AuthInfo", "AuthTicket", "MsSinceLastLocationfix" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo), global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Parser, new[]{ "Provider", "Token" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT), global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT.Parser, new[]{ "Contents", "Unknown2" }, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RequestEnvelope : pb::IMessage<RequestEnvelope> {
    private static readonly pb::MessageParser<RequestEnvelope> _parser = new pb::MessageParser<RequestEnvelope>(() => new RequestEnvelope());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestEnvelope> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Envelopes.RequestEnvelopeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestEnvelope() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestEnvelope(RequestEnvelope other) : this() {
      statusCode_ = other.statusCode_;
      requestId_ = other.requestId_;
      requests_ = other.requests_.Clone();
      Unknown6 = other.unknown6_ != null ? other.Unknown6.Clone() : null;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      accuracy_ = other.accuracy_;
      AuthInfo = other.authInfo_ != null ? other.AuthInfo.Clone() : null;
      AuthTicket = other.authTicket_ != null ? other.AuthTicket.Clone() : null;
      msSinceLastLocationfix_ = other.msSinceLastLocationfix_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestEnvelope Clone() {
      return new RequestEnvelope(this);
    }

    /// <summary>Field number for the "status_code" field.</summary>
    public const int StatusCodeFieldNumber = 1;
    private int statusCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 3;
    private ulong requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "requests" field.</summary>
    public const int RequestsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Networking.Requests.Request> _repeated_requests_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Networking.Requests.Request.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Networking.Requests.Request> requests_ = new pbc::RepeatedField<global::POGOProtos.Networking.Requests.Request>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Networking.Requests.Request> Requests {
      get { return requests_; }
    }

    /// <summary>Field number for the "unknown6" field.</summary>
    public const int Unknown6FieldNumber = 6;
    private global::POGOProtos.Networking.Envelopes.Unknown6 unknown6_;
    /// <summary>
    ///  Unknown6 is required to get a response.
    ///  For an example check https://github.com/keyphact/pgoapi/blob/75eba6b5b630841ee4f7c2ea983f15874fb0862d/pgoapi/rpc_api.py#L192-L212
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Envelopes.Unknown6 Unknown6 {
      get { return unknown6_; }
      set {
        unknown6_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 7;
    private double latitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 8;
    private double longitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "accuracy" field.</summary>
    public const int AccuracyFieldNumber = 9;
    private double accuracy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Accuracy {
      get { return accuracy_; }
      set {
        accuracy_ = value;
      }
    }

    /// <summary>Field number for the "auth_info" field.</summary>
    public const int AuthInfoFieldNumber = 10;
    private global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo authInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo AuthInfo {
      get { return authInfo_; }
      set {
        authInfo_ = value;
      }
    }

    /// <summary>Field number for the "auth_ticket" field.</summary>
    public const int AuthTicketFieldNumber = 11;
    private global::POGOProtos.Networking.Envelopes.AuthTicket authTicket_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Envelopes.AuthTicket AuthTicket {
      get { return authTicket_; }
      set {
        authTicket_ = value;
      }
    }

    /// <summary>Field number for the "ms_since_last_locationfix" field.</summary>
    public const int MsSinceLastLocationfixFieldNumber = 12;
    private long msSinceLastLocationfix_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MsSinceLastLocationfix {
      get { return msSinceLastLocationfix_; }
      set {
        msSinceLastLocationfix_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestEnvelope);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestEnvelope other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusCode != other.StatusCode) return false;
      if (RequestId != other.RequestId) return false;
      if(!requests_.Equals(other.requests_)) return false;
      if (!object.Equals(Unknown6, other.Unknown6)) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      if (Accuracy != other.Accuracy) return false;
      if (!object.Equals(AuthInfo, other.AuthInfo)) return false;
      if (!object.Equals(AuthTicket, other.AuthTicket)) return false;
      if (MsSinceLastLocationfix != other.MsSinceLastLocationfix) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
      hash ^= requests_.GetHashCode();
      if (unknown6_ != null) hash ^= Unknown6.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      if (Accuracy != 0D) hash ^= Accuracy.GetHashCode();
      if (authInfo_ != null) hash ^= AuthInfo.GetHashCode();
      if (authTicket_ != null) hash ^= AuthTicket.GetHashCode();
      if (MsSinceLastLocationfix != 0L) hash ^= MsSinceLastLocationfix.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusCode);
      }
      if (RequestId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(RequestId);
      }
      requests_.WriteTo(output, _repeated_requests_codec);
      if (unknown6_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Unknown6);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Longitude);
      }
      if (Accuracy != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Accuracy);
      }
      if (authInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AuthInfo);
      }
      if (authTicket_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(AuthTicket);
      }
      if (MsSinceLastLocationfix != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(MsSinceLastLocationfix);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
      }
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      size += requests_.CalculateSize(_repeated_requests_codec);
      if (unknown6_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown6);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (Accuracy != 0D) {
        size += 1 + 8;
      }
      if (authInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthInfo);
      }
      if (authTicket_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthTicket);
      }
      if (MsSinceLastLocationfix != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MsSinceLastLocationfix);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestEnvelope other) {
      if (other == null) {
        return;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
      }
      requests_.Add(other.requests_);
      if (other.unknown6_ != null) {
        if (unknown6_ == null) {
          unknown6_ = new global::POGOProtos.Networking.Envelopes.Unknown6();
        }
        Unknown6.MergeFrom(other.Unknown6);
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.Accuracy != 0D) {
        Accuracy = other.Accuracy;
      }
      if (other.authInfo_ != null) {
        if (authInfo_ == null) {
          authInfo_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo();
        }
        AuthInfo.MergeFrom(other.AuthInfo);
      }
      if (other.authTicket_ != null) {
        if (authTicket_ == null) {
          authTicket_ = new global::POGOProtos.Networking.Envelopes.AuthTicket();
        }
        AuthTicket.MergeFrom(other.AuthTicket);
      }
      if (other.MsSinceLastLocationfix != 0L) {
        MsSinceLastLocationfix = other.MsSinceLastLocationfix;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 24: {
            RequestId = input.ReadUInt64();
            break;
          }
          case 34: {
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
            break;
          }
          case 50: {
            if (unknown6_ == null) {
              unknown6_ = new global::POGOProtos.Networking.Envelopes.Unknown6();
            }
            input.ReadMessage(unknown6_);
            break;
          }
          case 57: {
            Latitude = input.ReadDouble();
            break;
          }
          case 65: {
            Longitude = input.ReadDouble();
            break;
          }
          case 73: {
            Accuracy = input.ReadDouble();
            break;
          }
          case 82: {
            if (authInfo_ == null) {
              authInfo_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo();
            }
            input.ReadMessage(authInfo_);
            break;
          }
          case 90: {
            if (authTicket_ == null) {
              authTicket_ = new global::POGOProtos.Networking.Envelopes.AuthTicket();
            }
            input.ReadMessage(authTicket_);
            break;
          }
          case 96: {
            MsSinceLastLocationfix = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RequestEnvelope message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class AuthInfo : pb::IMessage<AuthInfo> {
        private static readonly pb::MessageParser<AuthInfo> _parser = new pb::MessageParser<AuthInfo>(() => new AuthInfo());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<AuthInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Envelopes.RequestEnvelope.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AuthInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AuthInfo(AuthInfo other) : this() {
          provider_ = other.provider_;
          Token = other.token_ != null ? other.Token.Clone() : null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AuthInfo Clone() {
          return new AuthInfo(this);
        }

        /// <summary>Field number for the "provider" field.</summary>
        public const int ProviderFieldNumber = 1;
        private string provider_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Provider {
          get { return provider_; }
          set {
            provider_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "token" field.</summary>
        public const int TokenFieldNumber = 2;
        private global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT token_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT Token {
          get { return token_; }
          set {
            token_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as AuthInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(AuthInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Provider != other.Provider) return false;
          if (!object.Equals(Token, other.Token)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Provider.Length != 0) hash ^= Provider.GetHashCode();
          if (token_ != null) hash ^= Token.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Provider.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Provider);
          }
          if (token_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Token);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Provider.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Provider);
          }
          if (token_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Token);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(AuthInfo other) {
          if (other == null) {
            return;
          }
          if (other.Provider.Length != 0) {
            Provider = other.Provider;
          }
          if (other.token_ != null) {
            if (token_ == null) {
              token_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT();
            }
            Token.MergeFrom(other.Token);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Provider = input.ReadString();
                break;
              }
              case 18: {
                if (token_ == null) {
                  token_ = new global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Types.JWT();
                }
                input.ReadMessage(token_);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the AuthInfo message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public sealed partial class JWT : pb::IMessage<JWT> {
            private static readonly pb::MessageParser<JWT> _parser = new pb::MessageParser<JWT>(() => new JWT());
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<JWT> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public JWT() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public JWT(JWT other) : this() {
              contents_ = other.contents_;
              unknown2_ = other.unknown2_;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public JWT Clone() {
              return new JWT(this);
            }

            /// <summary>Field number for the "contents" field.</summary>
            public const int ContentsFieldNumber = 1;
            private string contents_ = "";
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public string Contents {
              get { return contents_; }
              set {
                contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            /// <summary>Field number for the "unknown2" field.</summary>
            public const int Unknown2FieldNumber = 2;
            private int unknown2_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int Unknown2 {
              get { return unknown2_; }
              set {
                unknown2_ = value;
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as JWT);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(JWT other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Contents != other.Contents) return false;
              if (Unknown2 != other.Unknown2) return false;
              return true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
              if (Contents.Length != 0) hash ^= Contents.GetHashCode();
              if (Unknown2 != 0) hash ^= Unknown2.GetHashCode();
              return hash;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void WriteTo(pb::CodedOutputStream output) {
              if (Contents.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Contents);
              }
              if (Unknown2 != 0) {
                output.WriteRawTag(16);
                output.WriteInt32(Unknown2);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (Contents.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Contents);
              }
              if (Unknown2 != 0) {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown2);
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(JWT other) {
              if (other == null) {
                return;
              }
              if (other.Contents.Length != 0) {
                Contents = other.Contents;
              }
              if (other.Unknown2 != 0) {
                Unknown2 = other.Unknown2;
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(pb::CodedInputStream input) {
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    input.SkipLastField();
                    break;
                  case 10: {
                    Contents = input.ReadString();
                    break;
                  }
                  case 16: {
                    Unknown2 = input.ReadInt32();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
