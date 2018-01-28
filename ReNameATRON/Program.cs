using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameATRON
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] filePaths = Directory.GetFiles(@"C:\Users\Thomas\Pictures\FreeVideoToJPGConverter\Potato (2-15-2017 10-07-56 AM)");

            int cnt = 1;
            foreach (var item in filePaths)
            {
                System.IO.File.Move(item, cnt + ".jpg");
                Console.WriteLine("renamed Image: " + cnt);
                cnt++;
            }

        }
    }
}
