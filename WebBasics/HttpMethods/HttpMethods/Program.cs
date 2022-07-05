using System.Net;
using System.Net.Sockets;
using System.Text;

//await ReadData();

const string newLine = "\r\n";
TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 12345);
tcpListener.Start();


while (true)
{
    var client = tcpListener.AcceptTcpClient();
    using (var stream = client.GetStream())
    {
        var startBuffer = 0;
        var buffer = new byte[10000000];
        var lenght = stream.Read(buffer, startBuffer, buffer.Length);
        var requestString = Encoding.UTF8.GetString(buffer, startBuffer, lenght);
        Console.WriteLine(requestString);
        Console.WriteLine(new string('=', 100));
        var html = $"<h1>Hello from NikiServer 2022 {DateTime.Now}</h1>"+
                    $"<form method = Post ><input name=username /><input name=password />" +
                    $"<input type=submit /></form>";

        var response = "HTTP/1.1 200 OK" + newLine +
                       //"Location: https://www.google.com" + newLine +
                       "Server: NikiServe2022" + newLine +
                       "Content-Type: text/html; charser=utf-8" + newLine +
                       //"Content-Disposition: attachment; filename=niki.txt" + newLine +
                       "Content-Lenght:" + html.Length + newLine +
                       newLine +
                       html + newLine;
        byte[] responseBytes = Encoding.UTF8.GetBytes(response);
        stream.Write(responseBytes);
    }
   

 
}

static async Task ReadData()
{
    using (HttpClient client = new HttpClient())
    {
        Console.WriteLine(await client.GetStringAsync("https://softuni.bg/"));
    }
     
    
}
