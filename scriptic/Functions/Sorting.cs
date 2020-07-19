using System;

namespace scriptic.Functions
{
    public static class Sorting
    {
        #region QuickSort

        public static void Quick_Sort<T>(IComparable<T>[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }
        private static int Partition<T>(IComparable<T>[] arr, int left, int right)
        {
            IComparable<T> pivot = arr[left];
            while (true)
            {

                while (arr[left].CompareTo((T)pivot) < 0) 
                {
                    left++;
                }

                while (arr[right].CompareTo((T)pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    T temp = (T)arr[left];
                    arr[left] = arr[right];
                    arr[right] = (IComparable<T>)temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }


    #endregion
}
