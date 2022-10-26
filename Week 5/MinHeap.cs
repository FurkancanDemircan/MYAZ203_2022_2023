namespace MYAZ203.Week_5
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var min = _heaps.First();
            _heaps.Remove(min);
            return min;
        }
    }
}
