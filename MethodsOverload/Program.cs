namespace MethodsOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a) Method Task:
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            FindMinNum(array);

            Console.WriteLine("--------------------------");

            // b) Overload Tasks:
            Area(2d);
            Area(2, 3);
            Area(3, 4, 5);
            Area(4, 5, 6, 7);
        }

        // a) Method Task:
        public static void FindMinNum(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Minimum eded: " + min);
        }

        // b) Overload Tasks:
        public static void Area(double r, int p = 3)
        {
            double S;
            S = p * Math.Pow(r, 2);
            Console.WriteLine("Çevrenin sahesi: " + S);
        }

        public static void Area(int a, int b)
        {
            int S;
            S = a * b;
            Console.WriteLine("Düzbucaqlının sahesi: " + S);
        }

        public static void Area(int a, int b, int c)
        {
            int S;
            S = 2 * (a * b + a * c + b * c);
            Console.WriteLine("Düzbucaqlı paralelpipedin tam sethinin sahesi: " + S);
        }

        public static void Area(int a, int b, int c, int r)
        {
            int S;
            int p = (a + b + c) / 2;
            S = p * r;
            Console.WriteLine("Üçbucaqlının daxiline çekilmiş çevrenin sahesi: " + S);
        }
    }
}