using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyKeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    internal class MyDictionary<TKey, TValue>
    {
        private MyKeyValuePair<TKey, TValue>[] items;

        public MyDictionary()
        {
            items = new MyKeyValuePair<TKey, TValue>[0];
        }

        public void Add(TKey key, TValue value)
        {
            MyKeyValuePair<TKey, TValue>[] tempItems = items;

            items = new MyKeyValuePair<TKey, TValue>[items.Length + 1];

            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = new MyKeyValuePair<TKey, TValue>()
            {
                Key = key,
                Value = value
            };
        }

        public IEnumerator<MyKeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (MyKeyValuePair<TKey, TValue> item in items)
            {
                yield return item;
            }
        }
    }

}
