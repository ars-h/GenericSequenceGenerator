using System;

namespace GenericSequenceGenerator
{
    public class CharSequenceGenerator : SequenceGenerator<char>
    {
        public CharSequenceGenerator(char first, char second)
            : base(first, second)
        {
        }

        protected override char GetNext()
        {
            int nextCharValue = (((this.Previous - 'A') + (this.Current - 'A')) % 26) + 'A';
            return (char)nextCharValue;
        }
    }
}
