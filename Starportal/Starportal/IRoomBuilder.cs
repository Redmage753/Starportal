using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBuilder
{
    interface IRoomBuilder
    {
        string RoomDescription { get; set; }
        string DoorExit { get; set; }
        string DoorProgress { get; set; }

    }
}
