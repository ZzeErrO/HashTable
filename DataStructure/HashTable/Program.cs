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
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(' ');
            MyMapNode<string, string> hash = new MyMapNode<string, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash.Add(key.ToString(), word);
                key++;
            }

            Console.WriteLine("Index    Key     Value");
            for (int i = 0; i < para.Length; i++)
            {
                hash.Display(i.ToString());
            }

            Console.WriteLine("Index    Key     Value");
            hash.Remove("17");
            for (int i = 0; i < para.Length; i++)
            {
                hash.Display(i.ToString());
            }

            Console.ReadKey();
        }
    }
}
