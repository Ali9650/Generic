namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine($" num1 = {num1}, num2 = {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");


            string str1 = "Salam";
            string str2 = "Necesen";
            Console.WriteLine($" str1 = {str1}, str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"str1 = {str1}, str2 = {str2}");
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
