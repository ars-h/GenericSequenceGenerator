using System;

namespace GenericSequenceGenerator
{
    public class FibonacciSequenceGenerator(int first, int second) : SequenceGenerator<int>(first, second)
    {
        protected override int GetNext()
        {
            return this.Previous + this.Current;
        }
    }
}
