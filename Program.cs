namespace Assignment3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 1, 1, 9, 1, 1 };
            int target = 1;

            Console.Write("INPUT: ");
            PrintArray(numbers);
            FindConsecutiveMatchingInts(numbers, target);
            Console.Write("OUTPUT: ");
            PrintArray(numbers);
        }

        public static void FindConsecutiveMatchingInts(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target && (nums[i +1]) == target)
                {
                    nums[i] = 0;
                    nums[i + 1] = 0;
                    break;
                }
            }
        }

        public static void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
    }
}
