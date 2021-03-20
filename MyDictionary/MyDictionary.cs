using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKey,TValue>
    {
        TKey[] _Key;
        TValue[] _Value;
        public MyDictionary()
        {
            _Key = new TKey[0];
            _Value = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tempArrayKey = _Key;
            TValue[] temArrayValue = _Value;

            _Key = new TKey[_Key.Length + 1];
            _Value = new TValue[_Value.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                _Key[i] = tempArrayKey[i];
                _Value[i]= temArrayValue[i];
            }

            _Key[_Key.Length - 1] = key;
            _Value[_Value.Length - 1] = value;
        }

        public TValue[] value
        {
            get { return _Value; }
        }
    }
}
