using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.Dungeon;

namespace GamePrototype.Utils
{
    public interface IDungeonBuilder
    {
        DungeonRoom BuildDungeon();
    }
}