using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); //() []
            int size1 = 6;
            MyMapNode<string, string> hash = new MyMapNode<string, string>(size1);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            Console.WriteLine("Index    Key     Value");

            for (int i = 0; i < size1; i++)
            {
                hash.Display(i.ToString());
            }

            Console.WriteLine("Frequency of Values");
            for (int i = 0; i < size1; i++)
            {
                int count = 0;
                for (int j = 0; j < size1; j++)
                {
                    count = hash.Frequency(i.ToString(),j.ToString());
                }
                Console.WriteLine("Frequency " + count  + "\n");
            }

            Console.ReadKey();
        }
    }
}
