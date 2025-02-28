using System;

namespace GenericSequenceGenerator
{
    public class IntegerSequenceGenerator(int first, int second) : SequenceGenerator<int>(first, second)
    {
        protected override int GetNext()
        {
            return (6 * this.Current) - (8 * this.Previous);
        }
    }
}
