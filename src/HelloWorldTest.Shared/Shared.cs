// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: shared.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HelloWorldTest.Shared {

  /// <summary>Holder for reflection information generated from shared.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class SharedReflection {

    #region Descriptor
    /// <summary>File descriptor for shared.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxzaGFyZWQucHJvdG8SFUhlbGxvV29ybGRUZXN0LlNoYXJlZCIfCgxIZWxs",
            "b1JlcXVlc3QSDwoHbWVzc2FnZRgBIAEoCSIdCgpIZWxsb1JlcGx5Eg8KB21l",
            "c3NhZ2UYASABKAkyuAEKClBpbmdTZXJ2ZXISUQoFSGVsbG8SIy5IZWxsb1dv",
            "cmxkVGVzdC5TaGFyZWQuSGVsbG9SZXF1ZXN0GiEuSGVsbG9Xb3JsZFRlc3Qu",
            "U2hhcmVkLkhlbGxvUmVwbHkiABJXCgtIZWxsb1JhbmRvbRIjLkhlbGxvV29y",
            "bGRUZXN0LlNoYXJlZC5IZWxsb1JlcXVlc3QaIS5IZWxsb1dvcmxkVGVzdC5T",
            "aGFyZWQuSGVsbG9SZXBseSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::HelloWorldTest.Shared.HelloRequest), global::HelloWorldTest.Shared.HelloRequest.Parser, new[]{ "Message" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::HelloWorldTest.Shared.HelloReply), global::HelloWorldTest.Shared.HelloReply.Parser, new[]{ "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  The request message
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class HelloRequest : pb::IMessage<HelloRequest> {
    private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
    public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::HelloWorldTest.Shared.SharedReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public HelloRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public HelloRequest(HelloRequest other) : this() {
      message_ = other.message_;
    }

    public HelloRequest Clone() {
      return new HelloRequest(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as HelloRequest);
    }

    public bool Equals(HelloRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(HelloRequest other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The response message 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class HelloReply : pb::IMessage<HelloReply> {
    private static readonly pb::MessageParser<HelloReply> _parser = new pb::MessageParser<HelloReply>(() => new HelloReply());
    public static pb::MessageParser<HelloReply> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::HelloWorldTest.Shared.SharedReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public HelloReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    public HelloReply(HelloReply other) : this() {
      message_ = other.message_;
    }

    public HelloReply Clone() {
      return new HelloReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as HelloReply);
    }

    public bool Equals(HelloReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(HelloReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code