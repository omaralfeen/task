using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    public class Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        
        public Func<T, T, T> add { get; set; }
        public Func<T, T, T> subtract{ get; set; }
        public Func<T, T, T> multiply { get; set; }
        public Func<T, T, T> divide { get; set; }

        public Calculator()
        {
            add = (x, y) => (dynamic)x + y;
            subtract = (x, y) => (dynamic)x - y;
            multiply = (x, y) => (dynamic)x * y;
            divide = (x, y) => (dynamic)x / y;
        }
        public T Add(T a, T b)
        {
            return add(a, b);
        }
        public T Subtract(T a, T b)
        {
            return subtract(a, b);
        }
        public T Multiply(T a, T b)
        {
            return multiply(a, b);
        }
        public T Divide(T a, T b) 
        { 
             return divide(a, b);
        }
    }

}

