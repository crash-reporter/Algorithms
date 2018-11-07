namespace UnitTestsCore
{
    internal static class SortData
    {
        public static int[] SimpleExample1Input = new int[] { 8, 1, 10, 12, 11, 2, 6, 4, 3 };
        public static int[] SimpleExample1Output = new int[] { 1, 2, 3, 4, 6, 8, 10, 11, 12 };

        public static int[] SimpleExample2Input = new int[] { -12, 8, 1, 10, 12, 11, 2, 6, 4, 3, 0, 5, -4, -8 };
        public static int[] SimpleExample2Output = new int[] { -12, -8, -4, 0, 1, 2, 3, 4, 5, 6, 8, 10, 11, 12 };

        public static ComparableInt[] Example1Input = new ComparableInt[]
        {
            new ComparableInt(-12), new ComparableInt(8), new ComparableInt(1),
            new ComparableInt(10), new ComparableInt(12), new ComparableInt(11),
            new ComparableInt(2), new ComparableInt(6), new ComparableInt(4),
            new ComparableInt(3), new ComparableInt(0), new ComparableInt(5),
            new ComparableInt(-4), new ComparableInt(-8), new ComparableInt(-24)
        };

        public static ComparableInt[] Example1Output = new ComparableInt[]
        {
            new ComparableInt(-24), new ComparableInt(-12), new ComparableInt(-8),
            new ComparableInt(-4), new ComparableInt(0), new ComparableInt(1),
            new ComparableInt(2), new ComparableInt(3), new ComparableInt(4),
            new ComparableInt(5), new ComparableInt(6), new ComparableInt(8),
            new ComparableInt(10), new ComparableInt(11), new ComparableInt(12)
        };

        public static string[] Example1StringsInput = new string[]
        {
            "Warszawa","Jelenia Góra","Wrocław","Kraków","Opole","Poznań","Gdańsk","Barczewo","Bobowa", "Bukowiec","Kostrzyca","Kowary"
        };

        public static string[] Example1StringsOutput = new string[]
        {
            "Barczewo","Bobowa", "Bukowiec","Gdańsk","Jelenia Góra","Kostrzyca","Kowary","Kraków","Opole","Poznań","Warszawa","Wrocław",
        };
    }
}