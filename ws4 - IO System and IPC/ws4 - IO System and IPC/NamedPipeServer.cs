using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;

#nullable enable
//#if RUN_SERVER

namespace ws4___IO_System_and_IPC
{
    // This class is a Server sends PING and get Responce PONG
    public class NamedPipeServer
    {
        static void Main()
        {
            const string pipePingName = "pipePing";     // Used for communication from Server to Client
            const string pipePongName = "pipePong";     // Used for communication from Client to Server
        
            Console.WriteLine("~ Starting Ping Process ~");

            using (var pipePing = new NamedPipeServerStream(pipePingName, PipeDirection.Out))
            // The first parameter in NamedPipeClientStream constractor is the server name.
            // '.' indicates that the pipe server is on the local machine
            // To connect to remote machine you would proivde its hostname or IP address 
            using (var pipePong = new NamedPipeClientStream(".", pipePongName, PipeDirection.In)) 
            {
                // Wait for client to connect
                pipePing.WaitForConnection();

                // Connect to client to get respoonce
                pipePong.Connect();

                Console.WriteLine("The Client process connected");

                using (var writer = new StreamWriter(pipePing))
                using (var reader = new StreamReader(pipePong))
                {
                    // Automatically flush after write
                    writer.AutoFlush = true;

                    for (int i = 0; i < 5; i++)
                    {
                        // Send Ping to Client
                        string message = $"Ping {i + 1}";
                        writer.WriteLine(message);
                        Console.WriteLine($"Server sent '{message}'");

                        // Recieve Pong from Client
                        string? response = reader.ReadLine();
                        Console.WriteLine($"Server recieved '{response}'");
                    }
                }

                Console.WriteLine("Server exiting");
            }
        }
    }
}

//#endif