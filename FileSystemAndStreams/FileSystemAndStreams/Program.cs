using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemAndStreams
{
    class Program
    {
        static void MainMenu()
        {
            Console.Write("Enter a number: ", System.Text.Encoding.UTF8);
            string inputString = Console.ReadLine();
            int intResult;
            int.TryParse(inputString, out intResult);
            Console.WriteLine("Entered number: {0}", intResult);
            if (intResult == 0)
            {
                return;
            }
            MainMenu();
        }
        static void Main(string[] args)
        {

            MainMenu();
            //DriveInfo[] driveInfo = DriveInfo.GetDrives();

            //foreach (var item in driveInfo)
            //{
            //    Console.WriteLine($"Name: {item.Name}");
            //    Console.WriteLine($"DriveType: {item.DriveType}");
            //    if (item.IsReady)
            //    {
            //        Console.WriteLine($"Drives are ready: {item.IsReady}");
            //        Console.WriteLine($"Total Free space: {item.TotalFreeSpace}");
            //    }
            //}
            Console.Read();
        }
    }
}
