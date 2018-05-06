namespace AutomatedTestWebinar.Part1
{
    public class FisherMan
    {
        public string Name { get; set; }

        public Level Level { get; set; }

        public bool Banned { get; set; }
        
    }

    public enum Level
    {
        Amateur = 1,
        Professional = 2
    }
}
