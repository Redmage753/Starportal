using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBuilder
{
    class Dungeon : IRoomNavigation
    {
        public string Description { get; set; }
        public string Exit { get; set; }
        public string Progress { get; set; }

        public Dungeon(string description, string exit, string progress)
        {
            this.Description = description;
            this.Exit = exit;
            this.Progress = progress;
        }



    }

}