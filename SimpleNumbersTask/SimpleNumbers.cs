using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbersTask
{
    class SimpleNumbers : IEnumerable
    {
        private uint[] arr;

        public SimpleNumbers(uint[] arr)
        {
            this.arr = arr;
        }
        public IEnumerator GetEnumerator()
        {
            return new SimpleNumbersEnumerator(arr);
        }
    }
}
