using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private List<T> myList = new List<T>();
        int position = -1;
        internal void AddElement(T v)
        {
            myList.Add(v);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (position < myList.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public T this[int index]
        {
            get => myList[index];
        }

        public int NumberOfElements
        {
            get { return myList.Count; }
        }

        public T Current {
            get { return myList[position]; }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
}
