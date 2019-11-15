using System;
using System.Collections.Generic;

namespace bigO
{
    public static class Extensions
    {
        public static IEnumerable<T> GetEnumerablePrePopulated<T>(this T value, long count) 
        {
            List<T> result = new List<T>();
            for (int i = 0; i < count; i++)
            {
                result.Add(value);
            }
            return result;
        }
    }
}