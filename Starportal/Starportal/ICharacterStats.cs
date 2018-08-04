using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder
{
    interface ICharacterStats
    {
        int CharacterStrength { get; set; }
        int CharacterWisdom { get; set; }
        int CharacterDexterity { get; set; }
        int CharacterIntelligence { get; set; }
        int CharacterConstitution { get; set; }
        int CharacterCharisma { get; set; }

    }
}
