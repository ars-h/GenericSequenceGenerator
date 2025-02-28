using System;

namespace GenericSequenceGenerator
{
    public class DelegateSequenceGenerator<T>(T first, T second, Func<T, T, T> rule)
        : SequenceGenerator<T>(first, second)
    {
        private readonly Func<T, T, T> rule = rule ?? throw new ArgumentNullException(nameof(rule));

        protected override T GetNext()
        {
            return this.rule(this.Previous, this.Current);
        }
    }
}
