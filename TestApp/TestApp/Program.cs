using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cucumber.SayHello();
          
            Vsevolod vs = new Vsevolod();
            vs.Say("Git hub это круто, но непонятно");

            ForBackupTest.Test();

            Console.Write("Test");
            Console.Write("Test2");
        }

    }// Program
}
