



using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

class sockets
{
    sockets(IPAddress iptarg, UInt16 port)
    {
        IPEndPoint hostendpoint = new(Dns.GetHostAddresses(Dns.GetHostName())[0], port);
        Socket conport = new Socket(hostendpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        long T = DateTime.Now.Ticks;
        while (!conport.Connected)
        {
            conport.ConnectAsync(new IPEndPoint(iptarg, port));


            if (T > DateTime.Now.Ticks + 5000)//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH REMOVE LATER
            {
                try
                {
                    new Exception("time out connecting");
                }
                catch(Exception e) { Debug.WriteLine(e.Message); }
            }
        }
    }
    sockets(UInt16 port)//listen port
    {
        try
        {
            IPEndPoint hostendpoint = new(Dns.GetHostAddresses(Dns.GetHostName())[0], port);
            Socket listen = new Socket(hostendpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            listen.Bind(hostendpoint);
            listen.Listen(port);
        }
        catch(SocketException e)
        {
            Debug.WriteLine(e.ToString());
        }
        catch(Exception e)
        {
            Debug.WriteLine(e.ToString());
        }
    }


}