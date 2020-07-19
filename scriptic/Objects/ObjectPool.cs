using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace scriptic.Objects
{
    public class ObjectPool<T>
    {
        private readonly ConcurrentBag<T> _poolInternal;
        private readonly Func<T> generatorFunc;

        public ObjectPool (int Count, Func<T> generatorFunction)
        {
            generatorFunc = generatorFunction;
            _poolInternal = new ConcurrentBag<T>();
            for (int i = 0; i < Count; i++)
            {
                _poolInternal.Add(generatorFunction.Invoke());
            }
        }

        public T Get()
        {
            return _poolInternal.TryTake(out T item) ? item : generatorFunc();
        }

        public void Return(T item)
        {
            _poolInternal.Add(item);
        }
    }
}
