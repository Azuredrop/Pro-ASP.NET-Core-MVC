using System;
using System.Collections.Generic;

namespace WorkingWithVisualStudio.Tests
{
    public class Comparer
    {
        public static MyComparer<U> Get<U>(Func<U, U, bool> func)
        {
            return new MyComparer<U>(func);
        }

        public class MyComparer<T> : Comparer, IEqualityComparer<T>
        {
            private Func<T, T, bool> comparisonFunction;

            public MyComparer(Func<T, T, bool> func)
            {
                comparisonFunction = func;
            }

            public bool Equals(T x, T y)
            {
                return comparisonFunction(x, y);
            }

            public int GetHashCode(T obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
