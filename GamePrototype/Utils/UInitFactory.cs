using GamePrototype.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Utils
{
    public interface IUnitFactory
    {
        Unit CreatePlayer(string name);
        Unit CreateGoblinEnemy();
    }
}