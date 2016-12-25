using System;

namespace Lib2Geom
{
    public class D2<T>
    {
        private T[] _f = new T[2];

        public T this[int i] => _f[i];

        public D2(T a, T b)
        {
            _f[0] = a;
            _f[1] = b;
        }
    }
}
