using System;

namespace GenericSequenceGenerator
{
    public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
    {
        private T previous;
        private T current;

        public T Previous => this.previous;

        public T Current => this.current;

        public int Count { get; private set; }

        protected SequenceGenerator(T first, T second)
        {
            this.previous = first;
            this.current = second;
            this.Count = 2;
        }

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
