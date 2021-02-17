using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keysArray;
        TValue[] valuesArray;

        public MyDictionary()
        {
            keysArray = new TKey[0];
            valuesArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keysArray;
            TValue[] tempValue = valuesArray;
            keysArray = new TKey[keysArray.Length + 1];
            valuesArray = new TValue[valuesArray.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keysArray[i] = tempKey[i];
                valuesArray[i] = tempValue[i];
            }

            keysArray[keysArray.Length - 1] = key;
            valuesArray[valuesArray.Length - 1] = value;
        }

        public int Count
        {
            get { return valuesArray.Length; }
        }
        public void List()
        {
            for (int i = 0; i < keysArray.Length; i++)
            {
                Console.WriteLine(keysArray[i].ToString() + valuesArray[i].ToString());

            }

        }



    }
}
