using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace WindowsFormsApp1
{
    static class Program
    {

//██╗░░██╗░█████╗░░█████╗░██╗░░██╗  ██████╗░░█████╗░░██████╗░██████╗
//██║░░██║██╔══██╗██╔══██╗██║░██╔╝  ██╔══██╗██╔══██╗██╔════╝██╔════╝
//███████║███████║██║░░╚═╝█████═╝░  ██████╔╝███████║╚█████╗░╚█████╗░
//██╔══██║██╔══██║██║░░██╗██╔═██╗░  ██╔═══╝░██╔══██║░╚═══██╗░╚═══██╗
//██║░░██║██║░░██║╚█████╔╝██║░╚██╗  ██║░░░░░██║░░██║██████╔╝██████╔╝
//╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═════╝░

//░██████╗░███████╗███╗░░██╗███████╗██████╗░░█████╗░████████╗░█████╗░██████╗░
//██╔════╝░██╔════╝████╗░██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗
//██║░░██╗░█████╗░░██╔██╗██║█████╗░░██████╔╝███████║░░░██║░░░██║░░██║██████╔╝
//██║░░╚██╗██╔══╝░░██║╚████║██╔══╝░░██╔══██╗██╔══██║░░░██║░░░██║░░██║██╔══██╗
//╚██████╔╝███████╗██║░╚███║███████╗██║░░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║
//░╚═════╝░╚══════╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝




        
//░█████╗░██╗░░██╗░█████╗░███╗░░░███╗███████╗░░███╗░░░█████╗░░█████╗░░░███╗░░
//██╔══██╗██║░██╔╝██╔══██╗████╗░████║██╔════╝░████║░░██╔══██╗██╔══██╗░████║░░
//███████║█████═╝░███████║██╔████╔██║█████╗░░██╔██║░░╚██████║╚█████╔╝██╔██║░░
//██╔══██║██╔═██╗░██╔══██║██║╚██╔╝██║██╔══╝░░╚═╝██║░░░╚═══██║██╔══██╗╚═╝██║░░
//██║░░██║██║░╚██╗██║░░██║██║░╚═╝░██║███████╗███████╗░█████╔╝╚█████╔╝███████╗
//╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚══════╝░╚════╝░░╚════╝░╚══════╝



        
        [STAThread]
        static void Main()
        {
            Console.Title = "ULTIMATE PASSWORD GENERATOR BY AKAME1981";

            Console.WriteLine("██╗░░██╗░█████╗░░█████╗░██╗░░██╗  ██████╗░░█████╗░░██████╗░██████╗");
            Console.WriteLine("██║░░██║██╔══██╗██╔══██╗██║░██╔╝  ██╔══██╗██╔══██╗██╔════╝██╔════╝");
            Console.WriteLine("███████║███████║██║░░╚═╝█████═╝░  ██████╔╝███████║╚█████╗░╚█████╗░");
            Console.WriteLine("██╔══██║██╔══██║██║░░██╗██╔═██╗░  ██╔═══╝░██╔══██║░╚═══██╗░╚═══██╗");
            Console.WriteLine("██║░░██║██║░░██║╚█████╔╝██║░╚██╗  ██║░░░░░██║░░██║██████╔╝██████╔╝");
            Console.WriteLine("╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═════╝░");
            Console.WriteLine("░██████╗░███████╗███╗░░██╗███████╗██████╗░░█████╗░████████╗░█████╗░██████╗░");
            Console.WriteLine("██╔════╝░██╔════╝████╗░██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗");
            Console.WriteLine("██║░░██╗░█████╗░░██╔██╗██║█████╗░░██████╔╝███████║░░░██║░░░██║░░██║██████╔╝");
            Console.WriteLine("██║░░╚██╗██╔══╝░░██║╚████║██╔══╝░░██╔══██╗██╔══██║░░░██║░░░██║░░██║██╔══██╗");
            Console.WriteLine("╚██████╔╝███████╗██║░╚███║███████╗██║░░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║");
            Console.WriteLine("░╚═════╝░╚══════╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("░█████╗░██╗░░██╗░█████╗░███╗░░░███╗███████╗░░███╗░░░█████╗░░█████╗░░░███╗░░");
            Console.WriteLine("██╔══██╗██║░██╔╝██╔══██╗████╗░████║██╔════╝░████║░░██╔══██╗██╔══██╗░████║░░");
            Console.WriteLine("███████║█████═╝░███████║██╔████╔██║█████╗░░██╔██║░░╚██████║╚█████╔╝██╔██║░░");
            Console.WriteLine("██╔══██║██╔═██╗░██╔══██║██║╚██╔╝██║██╔══╝░░╚═╝██║░░░╚═══██║██╔══██╗╚═╝██║░░");
            Console.WriteLine("██║░░██║██║░╚██╗██║░░██║██║░╚═╝░██║███████╗███████╗░█████╔╝╚█████╔╝███████╗");
            Console.WriteLine("╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚══════╝░╚════╝░░╚════╝░╚══════╝");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");




            Console.WriteLine("█░█░█ █▀█ █▀█ █▀▄   █▀▀ █▀█ █░█ █▄░█ ▀█▀   ▀ ");
            Console.Write("▀▄▀▄▀ █▄█ █▀▄ █▄▀   █▄▄ █▄█ █▄█ █░▀█ ░█░   ▄ ");
            int totalchars = Convert.ToInt32(Console.ReadLine()); // total characters to include in one password
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("█▀█ ▄▀█ █▀ █▀ █░█░█ █▀█ █▀█ █▀▄   █▀▀ █▀█ █░█ █▄░█ ▀█▀   ▀");
            Console.Write("█▀▀ █▀█ ▄█ ▄█ ▀▄▀▄▀ █▄█ █▀▄ █▄▀   █▄▄ █▄█ █▄█ █░▀█ ░█░   ▀");
            int passcount = Convert.ToInt32(Console.ReadLine()); // total passwords to include in one password
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[totalchars];
            var random = new Random();
            int broi = 0; // Generated passwords count
            string time = DateTime.Now.ToString("hh-mm-ss"); 
            string date = DateTime.Now.ToString("dd-MM-yy"); 


            //File and path you want to create and write to
            string fileName = @"D:\Passlist.txt";





            for (int z = 0; z < passcount; z++){
                

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                broi = broi + 1;

                Console.WriteLine(broi + "  -  " + finalString);



                File.AppendAllText(fileName, finalString + Environment.NewLine);
                








            }





            Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}

