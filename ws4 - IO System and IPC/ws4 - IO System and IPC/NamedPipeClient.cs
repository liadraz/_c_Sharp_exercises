using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;

#nullable enable
//#if RUN_CLIENT

namespace ws4___IO_System_and_IPC
{
    public class NamedPipeClient
    {
        static void Main()
        {
            const string pipePongName = "pipePong";      // Used for communication to Server. Sends Pong 
            const string pipePingName = "pipePing";     // Used for communication from Server. Reads the Ping

            Console.WriteLine("~ Starting Client ~");

            using (var pipePing = new NamedPipeClientStream(".", pipePingName, PipeDirection.In))
            using (var pipePong = new NamedPipeServerStream(pipePongName, PipeDirection.Out))
            {
                // Connect to Ping pipe
                pipePing.Connect();

                // Wait for server to connect
                pipePong.WaitForConnection();

                using (var reader = new StreamReader(pipePing))
                using (var writer = new StreamWriter(pipePong))
                {
                    // Automatically flush after write
                    writer.AutoFlush = true;

                    for (int i = 0; i < 5; i++)
                    {
                        // Receive message from Server
                        string? message = reader.ReadLine();
                        Console.WriteLine($"Client recieved '{message}'");


                        string response = $"Pong {i + 1}";
                        writer.WriteLine(response);
                        Console.WriteLine($"Client sent '{response}'");
                    }
                }
            }
                Console.WriteLine("Client exiting");
        }
    }
}

//#endif