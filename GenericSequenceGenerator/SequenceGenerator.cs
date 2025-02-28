using System;

namespace GenericSequenceGenerator
{
    public abstract class SequenceGenerator<T>(T first, T second) : ISequenceGenerator<T>
    {
        private T previous = first;
        private T current = second;

        public T Previous => this.previous;

        public T Current => this.current;

        public int Count { get; private set; } = 2;

        public T Next
        {
            get
            {
                var next = this.GetNext();
                this.previous = this.current;
                this.current = next;
                this.Count++;
                return next;
            }
        }

        protected abstract T GetNext();
    }
}
