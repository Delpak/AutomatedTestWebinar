namespace AutomatedTestWebinar.Part1
{
    public class FishingCapacity
    {
        public int MaximumAllowedFishesThatCanCatch(FisherMan fisherMan)
        {
            if (fisherMan.Level == Level.Professional)
                return 100;

            if (fisherMan.Level == Level.Amateur)
                return 50;

            return 0;
        }
    }
}