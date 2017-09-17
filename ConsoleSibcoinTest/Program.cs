using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SibcoinNet;
using System.Net;

namespace ConsoleSibcoinTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SibcoinClient bc = new SibcoinClient("http://127.0.0.1:8332");
            bc.Credentials = new NetworkCredential("alice", "password");
            var p = bc.GetBalance();
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
