using System.Net.NetworkInformation;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Ping pingsender = new Ping();
        PingOptions options = new PingOptions();
        
        options.DontFragment = true;
        string data = "Learn to code";
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        int timeout = 120;
        string addr = "8.8.8.8";
        PingReply reply = pingsender.Send(addr,timeout,buffer,options);
        if(reply.Status == IPStatus.Success){
            Console.WriteLine("Response: {0}", reply.Status.ToString());
            Console.WriteLine("RoundTrip: {0}", reply.RoundtripTime);
            Console.WriteLine("Time-To-Live: {0}", reply.Options.Ttl);
            Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
        
        
        }
    }
}