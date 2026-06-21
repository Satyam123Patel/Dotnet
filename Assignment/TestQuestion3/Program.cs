namespace TestQuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //C:\Users\Yadnyesh Kolte\Desktop\prompt.txt
            Console.WriteLine("Welcome to File Handling");
            Console.Write("Enter the file Path: ");
            string path = Console.ReadLine();

            try {

                if (!File.Exists(path))
                {
                    throw new FileNotFoundException();
                }

                Console.WriteLine("Reading the file...");

                String data = File.ReadAllText(path);

                Console.WriteLine("File Content: ");
                Console.WriteLine(data);

            } catch (FileNotFoundException e) {
                Console.WriteLine("File not found. Please check the path and try again.");
            }

            
        }
    }
}
