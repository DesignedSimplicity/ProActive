using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProActive.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoUri = "";
            if (args != null && args.Length > 0)
            {
                videoUri = args[0];
            }

            while (!File.Exists(videoUri))
            {
                Console.Write("Invalid URI specified. Please enter a URI to a video file: ");
                videoUri = Console.ReadLine();
            }

            

        }
    }
}
