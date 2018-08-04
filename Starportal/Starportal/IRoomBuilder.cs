using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder
{
    interface IRoomBuilder
    {
        string RoomDescription();
        string DoorExit();
        string DoorContinue();
        string RoomMobs();

    }
}
