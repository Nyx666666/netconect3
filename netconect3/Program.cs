using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
//using System.Windows.Forms;




sockets t1;

t1 = new sockets(5200);

sockets t2;

t2 = new sockets(Dns.GetHostAddresses(Dns.GetHostName())[0], 5200);
class sockets
{
    public sockets(IPAddress iptarg, UInt16 port)
    {
        IPEndPoint hostendpoint = new(Dns.GetHostAddresses(Dns.GetHostName())[0], port);
        Socket openport = new Socket(hostendpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        Console.WriteLine("connetcting");

        long T = DateTime.Now.Ticks;
        
        while (true)
        {
            while (!openport.Connected)
            {
                openport.ConnectAsync(new IPEndPoint(iptarg, port));

                // Console.WriteLine((DateTime.Now.Ticks-T));


                if (T < DateTime.Now.Ticks - 50000000)//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH REMOVE LATER
                {
                    Console.WriteLine("time out connecting");
                    return;

                }

            }
            
            openport.Send(Encoding.UTF8.GetBytes("<CONSTART>"));
            byte[] buffer = new byte[1024];


            byte[] awaitmsg = Encoding.UTF8.GetBytes("<CONSTART>");
            while (true)
            {
                if (openport.Receive(buffer, SocketFlags.None).ToString() == awaitmsg.ToString())
                {
                    Console.WriteLine("<CONSTART> receved");
                    openport.Send(Encoding.UTF8.GetBytes("<ACK>"));
                    break;
                }
                if (T < DateTime.Now.Ticks - 50000000)//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH REMOVE LATER
                {
                    Console.WriteLine("time out connecting");
                    return;

                }
            }
        }
        Console.WriteLine("conected");
    }
    public sockets(UInt16 port)//listen port
    {
        IPEndPoint hostendpoint = new(Dns.GetHostAddresses(Dns.GetHostName())[0], port);
        Socket listen = new Socket(hostendpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            

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
        while (!listen.Connected) { }
        byte[] buffer = new byte[1024];
        byte[] awaitmsg = Encoding.UTF8.GetBytes("<CONSTART>");
        while (true)
        {
            if (listen.Receive(buffer, SocketFlags.None).ToString() == awaitmsg.ToString())
            {
                Console.WriteLine("<CONSTART> receved");
                listen.Send(Encoding.UTF8.GetBytes("<ACK>"));
                break;
            }
        }
    }


}