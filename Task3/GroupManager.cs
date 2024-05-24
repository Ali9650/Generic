

namespace Task3
{
    public class GroupManager
    {
        private List<Group> groups = new List<Group>();

        public void AddGroup(string name)
        {
            if (groups.Exists(g => g.Name == name))
            {
                Console.WriteLine($"A group with name '{name}' already exists. Cannot add duplicate groups.");
            }
            else
            {
                groups.Add(new Group(name));
                Console.WriteLine($"Group '{name}' added successfully.");
            }

        }
            
    }
}
