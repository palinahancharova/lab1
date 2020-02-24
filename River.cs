using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class River
    {
        public string name; 
        public double pool;
        public double length;

        public void GetInfo() //метод, // перед. нужное значение для параметров
        {
            Console.WriteLine("\nriver: {0}\narea of pool: {1}\nlength: {2}\n", name, pool, length);
        }
        public River()
        {
        }
        public River(double pool) : this("Dunai")
        {
            this.pool = pool;
            length = 3000;
        }

        public River(string name)
        {
            this.name = name;
            pool = 1334;
            length = 3000;
        }

        private string Name;

        public string NameOfRiver
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public override string ToString()
        {
            return ("river: " + name + "\npool: " + pool + "\nlength: " + length);
        }
    }
}