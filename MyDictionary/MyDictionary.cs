using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }



        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tKeys = keys;
            Tvalue[] tValues = values;

            keys = new Tkey[keys.Length+1];
            values = new Tvalue[values.Length+1];

            for (int i = 0; i < tKeys.Length; i++)
            {
                keys[i] = tKeys[i];
            }

            keys[keys.Length - 1] = key;

            for (int i = 0; i < tValues.Length; i++)
            {
                values[i] = tValues[i];
            }
            values[values.Length - 1] = value;


            

        }


    }
}
