using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder
{
    interface ICharacterActions
    {
        double Eat(double food);
        double Rest(double rest);
    }
}
