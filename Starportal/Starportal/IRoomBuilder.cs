using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBuilder
{
    interface IRoomNavigation
    {
        string RoomDescription();
        string DoorExit();
        string DoorContinue();

    }
}
