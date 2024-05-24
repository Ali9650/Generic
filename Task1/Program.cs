namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomList<int>numbers= new CustomList<int>();
            numbers.Add(3);
            numbers.Add(4);

            numbers.Remove(3);

            numbers.GetAll();
        }
    }
}
