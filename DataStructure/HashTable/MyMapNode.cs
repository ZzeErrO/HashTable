using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);  // |-5| =5 |3|=3 |-3|=3
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        internal void Display(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    Console.WriteLine(position + "       " + item.Key + "        " + item.Value);
                }
            }

        }

        internal int Frequency(K key1, K key2)
        {
            int frequency = 0;
            int position1 = GetArrayPosition(key1);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position1);
            int position2 = GetArrayPosition(key2);
            LinkedList<KeyValue<K, V>> linkedList1 = GetLinkedList(position2);
            foreach (KeyValue<K, V> item in linkedList)
            {
                foreach (KeyValue<K, V> a in linkedList1)
                {
                    if (item.Value.Equals(a.Value))
                    {
                        frequency++;
                    }
                }

                if (frequency > 0)
                {
                    Console.WriteLine("Value = " + item.Value);
                }

            }

            return frequency;
        }


    }

    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }

}
