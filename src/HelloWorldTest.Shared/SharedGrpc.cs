// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: shared.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HelloWorldTest.Shared {
  public static class PingServer
  {
    static readonly string __ServiceName = "HelloWorldTest.Shared.PingServer";

    static readonly Marshaller<global::HelloWorldTest.Shared.HelloRequest> __Marshaller_HelloRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HelloWorldTest.Shared.HelloRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HelloWorldTest.Shared.HelloReply> __Marshaller_HelloReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HelloWorldTest.Shared.HelloReply.Parser.ParseFrom);

    static readonly Method<global::HelloWorldTest.Shared.HelloRequest, global::HelloWorldTest.Shared.HelloReply> __Method_Hello = new Method<global::HelloWorldTest.Shared.HelloRequest, global::HelloWorldTest.Shared.HelloReply>(
        MethodType.Unary,
        __ServiceName,
        "Hello",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    static readonly Method<global::HelloWorldTest.Shared.HelloRequest, global::HelloWorldTest.Shared.HelloReply> __Method_HelloRandom = new Method<global::HelloWorldTest.Shared.HelloRequest, global::HelloWorldTest.Shared.HelloReply>(
        MethodType.Unary,
        __ServiceName,
        "HelloRandom",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    // service descriptor
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HelloWorldTest.Shared.SharedReflection.Descriptor.Services[0]; }
    }

    // client interface
    public interface IPingServerClient
    {
      global::HelloWorldTest.Shared.HelloReply Hello(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::HelloWorldTest.Shared.HelloReply Hello(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options);
      AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloAsync(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloAsync(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options);
      global::HelloWorldTest.Shared.HelloReply HelloRandom(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::HelloWorldTest.Shared.HelloReply HelloRandom(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options);
      AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloRandomAsync(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloRandomAsync(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options);
    }

    // server-side interface
    public interface IPingServer
    {
      Task<global::HelloWorldTest.Shared.HelloReply> Hello(global::HelloWorldTest.Shared.HelloRequest request, ServerCallContext context);
      Task<global::HelloWorldTest.Shared.HelloReply> HelloRandom(global::HelloWorldTest.Shared.HelloRequest request, ServerCallContext context);
    }

    // client stub
    public class PingServerClient : ClientBase, IPingServerClient
    {
      public PingServerClient(Channel channel) : base(channel)
      {
      }
      public global::HelloWorldTest.Shared.HelloReply Hello(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Hello, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::HelloWorldTest.Shared.HelloReply Hello(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_Hello, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloAsync(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Hello, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloAsync(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_Hello, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public global::HelloWorldTest.Shared.HelloReply HelloRandom(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_HelloRandom, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::HelloWorldTest.Shared.HelloReply HelloRandom(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_HelloRandom, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloRandomAsync(global::HelloWorldTest.Shared.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_HelloRandom, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::HelloWorldTest.Shared.HelloReply> HelloRandomAsync(global::HelloWorldTest.Shared.HelloRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_HelloRandom, options);
        return Calls.AsyncUnaryCall(call, request);
      }
    }

    // creates service definition that can be registered with a server
    public static ServerServiceDefinition BindService(IPingServer serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_Hello, serviceImpl.Hello)
          .AddMethod(__Method_HelloRandom, serviceImpl.HelloRandom).Build();
    }

    // creates a new client
    public static PingServerClient NewClient(Channel channel)
    {
      return new PingServerClient(channel);
    }

  }
}
#endregion
