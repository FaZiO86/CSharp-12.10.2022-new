using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_12._10._2022_new {
    internal class Program {
        static void Main(string[] args) {
            
            var BobTime = new EmployerTime();
            //BobTime.Print();
            try { BobTime[2] = int.Parse(args[0]); }
            catch (Exception e){ Console.WriteLine(e.ToString()); }
            BobTime.Print();
            
            Console.ReadKey();
        }
    }
}
