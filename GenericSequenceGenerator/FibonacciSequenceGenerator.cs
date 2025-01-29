using System;

namespace GenericSequenceGenerator
{
    public class FibonacciSequenceGenerator : SequenceGenerator<int>
    {
        public FibonacciSequenceGenerator(int first, int second)
            : base(first, second)
        {
        }

        protected override int GetNext()
        {
            return this.Previous + this.Current;
        }
    }
}
