using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using HelloWorldTest.Shared;

namespace HelloWorldTest
{
  public class PingServerImpl : PingServer.IPingServer
  {

    private Random _random = new Random();

    /// <summary>
    /// Server side handler of the HelloRandom RPC
    /// </summary>
    public Task<HelloReply> HelloRandom(HelloRequest req, ServerCallContext context)
    {
      // Set the return, mark it with deley number 
      HelloReply reply = new HelloReply();
      int rndom = _random.Next(1, 6);
      reply.Message = req.Message + ", random delay=" + rndom;
      // Random delay
      Thread.Sleep( rndom * 1000);
      // Done
      return Task.FromResult(reply);
    }

    /// <summary>
    /// Server side handler of the Hello RPC
    /// </summary>
    public Task<HelloReply> Hello(HelloRequest req, ServerCallContext context)
    {
      HelloReply reply = new HelloReply();
      reply.Message = Reverse(req.Message);
      return Task.FromResult( reply );
    }

    /// <summary>
    /// Reverses the string passed
    /// </summary>
    private static string Reverse(string s)
    {
      char[] charArray = s.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
    
  }
}
