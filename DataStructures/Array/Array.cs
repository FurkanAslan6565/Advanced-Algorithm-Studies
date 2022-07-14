using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T> , ICloneable 
    {
        private T[] InnerList;
        public int Count { get;  private set; }
        public int Capacity => InnerList.Length; // Koleksiyon kapasitesi dizinin uzunluğuna eşittir.

        public Array()
        {
            InnerList = new T[2];
            Count = 0; 
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public void Add(T item)  //Diziye bir eleman eklemek item üzerin de
        {
            if (InnerList.Length == Count) 
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++; // bir sonraki elemanı dizinin 1. gözüne yerleştirebilirsin
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length *2];
            for (int i = 0; i < InnerList.Length; i++)
            {
                temp[i] = InnerList[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
