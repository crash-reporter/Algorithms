namespace SortableAlgorithms.BubbleSort
{
    public class SimpleBubbleSort
    {
        /// Simple
        //public void Sort(int[] table)
        //{
        //    for (int loop = 0; loop < table.Length - 1; ++loop)
        //    {
        //        for (int index = 0; index < table.Length - 1; ++index)
        //        {
        //            if (table[index] > table[index + 1])
        //            {
        //                int temp = table[index];
        //                table[index] = table[index + 1];
        //                table[index + 1] = temp;
        //            }
        //        }
        //    }
        //}

        /// With Flag
        public void Sort(int[] table)
        {
            bool swapped = false;
            for (int loop = 0; loop < table.Length - 1; ++loop)
            {
                for (int index = 0; index < table.Length - 1; ++index)
                {
                    if (table[index] > table[index + 1])
                    {
                        int temp = table[index];
                        table[index] = table[index + 1];
                        table[index + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }
    }
}