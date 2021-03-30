using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        public static string[] para;
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); //() []
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            para = paragraph.Split(' ');
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


            for (int i = 0; i < para.Length; i++)
            {

                try
                {
                    MyMapNode<string, string>.dict.Add(para[i], 0);
                    hash.Frequency(i.ToString(), para);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (KeyValuePair<string, int> x in MyMapNode<string, string>.dict)
            {
                Console.WriteLine(x.Key + " " + x.Value);
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
