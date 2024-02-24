

namespace CSh_Revesion.APPS
{
    internal class CAExtentionMethodApp
    {
        public static void Run(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, 5, 5, 6, 7 };

            nums.Print();

            Console.ReadKey();

        }

    }

    static class Extentions
    {
        public static void Print<T>(this T[] source)
        {
            Console.Write($"{nameof(source)} : ");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write($"{source[i]} ");
            }
            Console.WriteLine();
        }
    }
}