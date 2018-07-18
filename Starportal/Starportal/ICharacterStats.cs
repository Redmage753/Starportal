using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starportal
{
    interface ICharacterStats
    {
        string Name { get; set; }
        double Attack { get; set; }
        double Defend { get; set; }
        double Health { get; set; }
        double currentHealth { get; set; }

        

    }
}
