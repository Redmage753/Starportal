using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBuilder
{
    class Dungeon : IRoomBuilder
    {
        public string RoomDescription { get; set; } = "Null Description";
        public string DoorExit { get; set; } = "South";
        public string DoorProgress { get; set; } = "North";

        public Dungeon(string description, string exit, string progress)
        {
            this.RoomDescription = description;
            this.DoorExit = exit;
            this.DoorProgress = progress;
        }



    }

}