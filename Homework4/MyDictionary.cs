using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Homework4
{
    class MyDictionary <TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

             keys[keys.Length-1] =key ;
             values[values.Length - 1] = value ;
        }

        public int Length
        {
            get
            {
                return keys.Length;
            }
        }

        public TValue[] Values
        {
            get
            {
                return values;
            }
        }

        public void Write(int index)               
        {
            Console.WriteLine("Key : " + keys[index] + " Value : " + values[index]);
        }

        public void Write2(int index)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(index))
                {
                    Console.WriteLine(values[i]);
                  
                }
            }
            
        }
    }
}
