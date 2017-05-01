using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindFileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drag and drop a file to get the size: ");
            string path = Console.ReadLine();
            FileInfo file = new FileInfo(path);
            var size = file.Length;
            Console.WriteLine("File size in Bytes: {0} bytes", size);
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
