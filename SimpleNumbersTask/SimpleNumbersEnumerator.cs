using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbersTask
{
    class SimpleNumbersEnumerator : IEnumerator
    {
        private uint[] arr;
        private int pos = -1;

        public SimpleNumbersEnumerator(uint[] arr)
        {
            this.arr = arr;
        }

        public object Current
        {
            get
            {
                while (!isNumberSimple(arr[pos])) MoveNext();
                return arr[pos];
            }
        }

        public bool MoveNext()
        {
            if (pos < arr.Length - 1)
            {
                pos++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            pos = -1;
        }

        private bool isNumberSimple(uint n)
        {
            bool output = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    output = false;
                    break;
                }
            }
            return output;
        }
    }
}
