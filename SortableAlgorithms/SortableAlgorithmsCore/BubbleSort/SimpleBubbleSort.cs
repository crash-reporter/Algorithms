namespace SortableAlgorithmsCore.BubbleSort
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
            var swapped = false;
            for (var loop = 0; loop < table.Length - 1; ++loop)
            {
                for (var index = 0; index < table.Length - 1; ++index)
                {
                    if (table[index] > table[index + 1])
                    {
                        var temp = table[index];
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