using System;

namespace GenericSequenceGenerator
{
    public class DoubleSequenceGenerator : SequenceGenerator<double>
    {
        public DoubleSequenceGenerator(double first, double second)
            : base(first, second)
        {
        }

        protected override double GetNext()
        {
            return this.Current + (this.Previous / this.Current);
        }
    }
}
