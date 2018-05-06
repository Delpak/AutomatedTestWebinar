namespace AutomatedTestWebinar.Part1
{
    public class BlackListRepository : IBlackListRepository
    {
        public string[] GetAllNames()
        {
            return System.IO.File.ReadAllLines(@"Blacklist.txt");
        }
    }
}