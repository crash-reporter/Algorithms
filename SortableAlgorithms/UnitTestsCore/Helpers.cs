namespace UnitTestsCore
{
    internal static class Helpers
    {
        public static bool Equals(int[] tableA, int[] tableB)
        {
            if (tableA.Length != tableB.Length)
            {
                return false;
            }
            for (var index = 0; index < tableA.Length; index++)
            {
                if (tableA[index] != tableB[index])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Equals(ComparableInt[] tableA, ComparableInt[] tableB)
        {
            if (tableA.Length != tableB.Length)
            {
                return false;
            }
            for (var index = 0; index < tableA.Length; index++)
            {
                if (tableA[index].Value != tableB[index].Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}