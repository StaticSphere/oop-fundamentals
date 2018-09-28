using System;
using System.Collections;

namespace EncapsulationBefore
{
    // Because this class derives from ArrayList, it takes on all of
    // ArrayList's public API, whose majority of methods have nothing
    // to do with a stack implementation. For instance, I can call the
    // ArrayList methods Remove, Add, Insert, etc., which are NOT stack
    // operations.
    // A stack violates the "is a" rule with respect to ArrayList; you
    // can't say "A stack 'is a' array."
    public class MyStack<TItem> : ArrayList
    {
        public void Push(TItem item)
        {
            this.Add(item);
        }

        public TItem Pop()
        {
            var item = (TItem)this[this.Count - 1];
            this.Remove(item);

            return item;
        }
    }
}