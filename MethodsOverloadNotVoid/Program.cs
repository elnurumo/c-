namespace MethodsOverloadNotVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a) Method Task:
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Minimum eded: " + FindMinNum(array));

            Console.WriteLine("--------------------------");

            // b) Overload not void Tasks:
            Console.WriteLine("Çevrenin sahesi: " + Area(2d));
            Console.WriteLine("Düzbucaqlının sahesi: " + Area(2, 3));
            Console.WriteLine("Düzbucaqlı paralelpipedin tam sethinin sahesi: " + Area(3, 4, 5));
            Console.WriteLine("Üçbucaqlının daxiline çekilmiş çevrenin sahesi: " + Area(4, 5, 6, 7));
        }

        // a) Method Task:
        public static int FindMinNum(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        // b) Overload not void Tasks:
        public static double Area(double r, int p = 3)
        {
            double S;
            S = p * Math.Pow(r, 2);
            return S;
        }

        public static int Area(int a, int b)
        {
            int S;
            S = a * b;
            return S;
        }

        public static int Area(int a, int b, int c)
        {
            int S;
            S = 2 * (a * b + a * c + b * c);
            return S;
        }

        public static int Area(int a, int b, int c, int r)
        {
            int S;
            int p = (a + b + c) / 2;
            S = p * r;
            return S;
        }
    }
}