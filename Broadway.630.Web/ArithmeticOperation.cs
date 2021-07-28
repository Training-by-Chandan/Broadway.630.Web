using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway._630.Web
{
    public class ArithmeticOperation
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b)
        {
            if (b == 0)
            {
                throw new NumberZeroException();
            }
            else
            {
                return a * b;
            }
        }

        public int Divide(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }
    }

    [Serializable]
    public class NumberZeroException : Exception
    {
        public NumberZeroException()
        {
        }

        public NumberZeroException(string message) : base(message)
        {
        }

        public NumberZeroException(string message, Exception inner) : base(message, inner)
        {
        }

        protected NumberZeroException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}