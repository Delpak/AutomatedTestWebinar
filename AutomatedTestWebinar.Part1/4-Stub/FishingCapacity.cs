using System;
using System.ComponentModel;
using System.Linq;

namespace AutomatedTestWebinar.Part1
{
    public class FishingCapacity
    {
        public IBlackListRepository BlakListRepository { private get; set; }

        public int MaximumAllowedFishesThatCanCatch(FisherMan fisherMan)
        {
            string[] blackListNames = BlakListRepository.GetAllNames();

            if (blackListNames.Contains(fisherMan.Name))
                return 0;

            if (fisherMan == null) throw new ArgumentNullException(nameof(fisherMan));

            if (fisherMan.Banned) return 0;

            if (fisherMan.Level == Level.Professional)
                return 100;

            if (fisherMan.Level == Level.Amateur)
                return 50;

            return 0;
        }
    }
}