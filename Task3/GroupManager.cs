

namespace Task3
{
    public class GroupManager
    {
        private List<Group> groups = new List<Group>();

        public void AddGroup(string name)
        {
            if (groups.Exists(g => g.Name == name))
            {
                Console.WriteLine("Bu qrup artiq movcuddur");
            }
            else
            {
                groups.Add(new Group(name));
                Console.WriteLine("Group elave edildi");
            }

        }
            
    }
}
