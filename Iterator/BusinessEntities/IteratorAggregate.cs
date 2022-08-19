using System.Collections;

namespace Iterator.BusinessEntities
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate for the implementing object.
        // ICollection may have been a better name for it but, alas, it's occupied.
        public abstract IEnumerator GetEnumerator();
    }
}
