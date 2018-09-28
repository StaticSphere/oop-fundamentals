using System.Collections.Generic;

namespace EncapsulationAfter
{
    // In this implementation, the stack definition is stand alone,
    // thus not opening up any API that we don't want it to have.
    // It encapsulates a List<T>, rather than deriving from it (or
    // an ArrayList), because, while the stack USES a list, it ISN'T
    // a list.
    public class MyStack<TItem>
    {
        private List<TItem> _list = new List<TItem>();
        public bool HasMoreItems => _list.Count > 0;
        public int Count => _list.Count;

        public void Push(TItem item)
        {
            _list.Add(item);
        }

        public TItem Pop()
        {
            var item = (TItem)_list[_list.Count - 1];
            _list.Remove(item);

            return item;
        }
    }
}