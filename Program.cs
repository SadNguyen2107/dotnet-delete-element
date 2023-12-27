namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] nums = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };
            Console.WriteLine("Before: ");
            PrintArray<Int32>(nums);

            // Delete Element at index 3
            deleteAtIndex<Int32>(nums, index_to_del: 3);
            
            Console.WriteLine("After: ");
            PrintArray<Int32>(nums);    
        }

        public static void deleteAtIndex<T>(T[] arr, UInt16 index_to_del)
        {
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