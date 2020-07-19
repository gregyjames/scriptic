using System;

namespace scriptic.Functions
{
    public static class Sorting
    {
        #region QuickSort

        public static void QuickSort<T>(T[] items, int left, int right) where T : IComparable
        {
            var i = left; var j = right;
            IComparable pivot = items[left];

            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                    Swap(ref items[i++], ref items[j--]);
            }
            if (left < j) QuickSort(items, left, j);
            if (i < right) QuickSort(items, i, right);
        }
        private static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }


        #endregion
    }
}
