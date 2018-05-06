using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestWebinar.Part1.UnitTests
{
    class StubBlackListRepository : IBlackListRepository
    {
        public string[] GetAllNames()
        {
            return new[] {"Hasan", "Heydar"};
        }
    }
}
