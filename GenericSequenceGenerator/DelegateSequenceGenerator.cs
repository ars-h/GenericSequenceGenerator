using System;

namespace GenericSequenceGenerator
{
    public class DelegateSequenceGenerator<T> : SequenceGenerator<T>
    {
        private readonly Func<T, T, T> rule;

        public DelegateSequenceGenerator(T first, T second, Func<T, T, T> rule)
            : base(first, second)
        {
            this.rule = rule ?? throw new ArgumentNullException(nameof(rule));
        }

        protected override T GetNext()
        {
            return this.rule(this.Previous, this.Current);
        }
    }
}
