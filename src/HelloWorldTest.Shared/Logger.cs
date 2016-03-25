using System;
using System.Diagnostics;

namespace HelloWorldTest.Shared
{
  public class Logger
  {

    // Write out to the attached watchers
    public static void Log(string text)
    {
      DateTime time = DateTime.Now;
      string theTime = String.Format("{0:d/M/yyyy HH:mm:ss:fff}", time);
      Console.WriteLine("~~~ " + theTime + ", " + text );
      Trace.WriteLine("~~~ " + theTime + ", " + text );
      //Debug.WriteLine(text);
    }
  }
}
