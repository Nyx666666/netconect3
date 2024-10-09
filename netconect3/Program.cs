using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
//using System.Windows.Forms;




sockets t1;
new Thread(() => {
    t1 = new sockets(5200);
    while (true)
    {
        Console.WriteLine(t1.msgdetection(new CancellationTokenSource()));
    }
}).Start();


sockets t2;
new Thread(() => {
    
    t2 = new sockets(Dns.GetHostAddresses(Dns.GetHostName())[0], 5200);
    //while (true)
    //{
    Console.WriteLine(t2.msgdetection(new CancellationTokenSource()));
    //}
    while (true)
    {
        t2.sndmsg(Console.ReadLine());
    }
}).Start();


class sockets
{
    Socket openport;
    byte[] buffer;

    public sockets(IPAddress iptarg, UInt16 port)
    {
        IPEndPoint hostendpoint = new(Dns.GetHostAddresses(Dns.GetHostName())[0], port);
        openport = new Socket(hostendpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        Console.WriteLine("connetcting");

        


        long T = DateTime.Now.Ticks;
        while (true)
        {
            
            while (!openport.Connected)
            {
                openport.ConnectAsync(new IPEndPoint(iptarg, port));

                // Console.WriteLine((DateTime.Now.Ticks-T));


                //if (T < DateTime.Now.Ticks - 50000000)//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH REMOVE LATER
                //{
                    
                //    Console.WriteLine("time out connecting");
                //    return;

                //}

            }
            
            openport.Send(Encoding.UTF8.GetBytes("<CONSTART>"));
            buffer = new byte[1024];


            //byte[] awaitmsg = Encoding.UTF8.GetBytes("<ACK>");
            while (true)
            {
                if (Encoding.UTF8.GetString(buffer, 0 , openport.Receive(buffer, SocketFlags.None)) == "<ACK>")
                {
                    Console.WriteLine("<CONSTART> receved");
                    //exitpoint
                    Console.WriteLine("conected");
                    return;
                }
                if (T < DateTime.Now.Ticks - 50000000)//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH REMOVE LATER
                {
                    T = DateTime.Now.Ticks;
                    openport.Disconnect(false);
                    Console.WriteLine("time out connecting...retrying");
                    break;

                }
            }
        }
        
        //exitpoint:
        
    }
    public sockets(UInt16 port)//listen port
    {
        buffer = new byte[1024];

        IPEndPoint hostendpoint = new(Dns.GetHostAddresses(Dns.GetHostName())[0], port);
        openport = new Socket(hostendpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        try
        {


            openport.Bind(hostendpoint);
            openport.Listen(port);
        }
        catch(SocketException e)
        {
            Debug.WriteLine(e.ToString());
        }
        catch(Exception e)
        {
            Debug.WriteLine(e.ToString());
        }


        openport = openport.Accept();
        CancellationTokenSource cantok = new CancellationTokenSource();
        cantok.CancelAfter(5000);
        

        while (true)
        {
            if (msgdetection(cantok) == "<CONSTART>")
            {
                Console.WriteLine("<CONSTART> receved");
                openport.Send(Encoding.UTF8.GetBytes("<ACK>"));
                break;
            }
        }
    }

    public string msgdetection(CancellationTokenSource cans)
    {

        string recmsg;

        while (!cans.IsCancellationRequested)
        {
            recmsg = Encoding.UTF8.GetString(buffer, 0, openport.Receive(buffer, SocketFlags.None));
            if (recmsg != "<ACK>") { openport.Send(Encoding.UTF8.GetBytes("<ACK>")); }

            return recmsg;
        }

        return "<MSG_CANCELATION>";
    }
    public async void sndmsg(string msgtxt)
    {
        while (true)
        {
            openport.Send(Encoding.UTF8.GetBytes(msgtxt));
            //CancellationToken cans = new CancellationToken();
            CancellationTokenSource cans = new CancellationTokenSource();
            cans.CancelAfter(1000);
            if (msgdetection(cans) == "<ACK>")
            {
                return;
            }
        }
    }
}