namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] nums = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };
            Console.WriteLine("Before: ");
            PrintArray<Int32>(nums);

            // Ask Number To delete
            Int32 num_to_del;
        askNumInput:
            Console.Write("Enter The Number to delete: ");
            bool isValid = Int32.TryParse(Console.ReadLine(), out num_to_del);
            if (!isValid)
            {
                Console.WriteLine("Invalid Format!");
                goto askNumInput;
            }

            // Delete Element at index 3
            int index_del = FindElement<Int32>(nums, num_to_del);
            DeleteAtIndex<Int32>(nums, index_to_del: index_del);

            Console.WriteLine("After: ");
            PrintArray<Int32>(nums);
        }

        public static int FindElement<T>(T[] arr, T element)
        {
            int index_del = -1;
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index].Equals(element))
                {
                    index_del = index;
                }
            }

            return index_del;
        }

        public static void DeleteAtIndex<T>(T[] arr, int index_to_del)
        {
            if (index_to_del == -1)
            {
                Console.WriteLine("Nothing To Delete");
                return;
            }

            // Delete At That Element
            // By Move Every Element Next To it By 1
            for (int index = index_to_del; index < arr.Length - 1; index++)
            {
                arr[index] = arr[index + 1];
            }
        }

        public static void PrintArray<T>(T[] arr)
        {
            Console.WriteLine("=========================================================================================");
            Console.Write("Value: ");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index] + "\t");
            }
            Console.WriteLine();

            Console.Write("Index: ");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(index + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=========================================================================================");
        }
    }
}