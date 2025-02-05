using System;
using System.IO;
using System.Runtime.InteropServices;

#nullable enable

namespace ws4___IO_System_and_IPC
{
    public class FileTextComparison
    {
        public static void Main(string[] args)
        {
            string file1 = args[0]; // @".\TextFiles\file1.txt"
            string file2 = args[1]; // @".\TextFiles\file2.txt"

            if (args.Length < 2)
            {
                Console.WriteLine("Usage: FileTextComparison <file1> <file2>");
                return;
            }

            if (!File.Exists(file1) || !File.Exists(file2))
            {
                Console.WriteLine("Error: One of the files does not exist");
                return;
            }

            using (TextReader tr1 = File.OpenText(file1))
            using (TextReader tr2 = File.OpenText(file2))
            {
                string? line1 = tr1.ReadLine();
                string? line2 = tr2.ReadLine();

                while (line1 != null || line2 != null)
                {
                    if (line1 == null)
                    {
                        Console.WriteLine($"File2 -> {line2}");
                        line2 = tr2.ReadLine();

                        continue;
                    }
                    else if (line2 == null)
                    {
                        Console.WriteLine($"File1 -> {line1}");
                        line1 = tr1.ReadLine();

                        continue;
                    }
                    else if (line1 != line2)
                    {
                        Console.WriteLine($"File1 -> {line1}");
                        Console.WriteLine($"File2 -> {line2}");
                    }

                    line1 = tr1.ReadLine();
                    line2 = tr2.ReadLine();
                }
            }
        }
    }
}
