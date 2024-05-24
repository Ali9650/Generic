namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupManager groupManager = new GroupManager();

            groupManager.AddGroup("Group1");
            groupManager.AddGroup("Group2");
            groupManager.AddGroup("Group1"); 

          
        }
    }
}

