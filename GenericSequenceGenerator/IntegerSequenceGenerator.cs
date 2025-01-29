using System;

namespace GenericSequenceGenerator
{
    public class IntegerSequenceGenerator : SequenceGenerator<int>
    {
        public IntegerSequenceGenerator(int first, int second)
            : base(first, second)
        {
        }

        protected override int GetNext()
        {
            return (6 * this.Current) - (8 * this.Previous);
        }
    }
}
