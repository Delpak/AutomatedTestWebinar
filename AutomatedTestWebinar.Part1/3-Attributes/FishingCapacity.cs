using System;
using System.ComponentModel;

namespace AutomatedTestWebinar.Part1
{
    public class FishingCapacity
    {
        public int MaximumAllowedFishesThatCanCatch(FisherMan fisherMan)
        {
            if(fisherMan == null) throw new ArgumentNullException(nameof(fisherMan));

            if (fisherMan.Banned) return 0;

            if (fisherMan.Level == Level.Professional)
                return 100;

            if (fisherMan.Level == Level.Amateur)
                return 50;

            return 0;
        }
    }
}