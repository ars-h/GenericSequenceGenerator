using System;

namespace GenericSequenceGenerator
{
    public class DoubleSequenceGenerator(double first, double second) : SequenceGenerator<double>(first, second)
    {
        protected override double GetNext()
        {
            return this.Current + (this.Previous / this.Current);
        }
    }
}
