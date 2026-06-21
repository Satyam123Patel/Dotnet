using System.Buffers;

namespace TestQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Array Length: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the Elements to add");
            for (int i=0;i<n;i++)
            {
                Console.Write("Enter number: "); 
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The Elements in Reverse Order are: ");

            for (int i=n-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }



        }
    }
}
