using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            River MRiver = new River(1000);
            MRiver.GetInfo();
            MRiver.name = "Neva";
            MRiver.pool = 1223;
            MRiver.length = 6535;
            MRiver.GetInfo();
            River Worker_new = new River(5663) { name = "Dvina", length = 1000 };
            Worker_new.GetInfo();
            Console.Write("Name of river: ");
            string n = Console.ReadLine();
            River River_name = new River(n);
            River_name.GetInfo();
            River River_Name = new River();
            River_Name.NameOfRiver = "Vileyka";
            string new_river = River_Name.NameOfRiver;
            Console.WriteLine("Name of river: {0}\n", new_river);
            River LastRiver = new River() { name = "YanZi", pool = 2566, length = 5575 };
            Console.WriteLine(LastRiver.ToString());

            Console.ReadLine();
        }
    }
}
