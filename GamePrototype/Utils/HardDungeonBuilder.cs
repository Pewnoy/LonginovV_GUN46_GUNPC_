using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.Dungeon;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;

namespace GamePrototype.Utils
{
    public class HardDungeonBuilder : IDungeonBuilder
    {
        public DungeonRoom BuildDungeon()
        {
            var enter = new DungeonRoom("Enter");var monsterRoom = new DungeonRoom("Hard Monster",new HardUnitFactory().CreateGoblinEnemy());
            var firstLootRoom = new DungeonRoom("Hard Loot", new Weapon(15, 10, "Strong Sword"));
            var secondMonsterRoom = new DungeonRoom("Second Monster",new HardUnitFactory().CreateGoblinEnemy());
            var secondLootRoom = new DungeonRoom("Hard Loot 2",new Helmet(8, 10, "Strong Helmet"));
            var finalRoom = new DungeonRoom("Hard Final",new Grindstone("Strong Stone"));

            enter.TrySetDirection(Direction.Right, monsterRoom);
            monsterRoom.TrySetDirection(Direction.Forward, firstLootRoom);
            firstLootRoom.TrySetDirection(Direction.Forward, secondMonsterRoom);
            secondMonsterRoom.TrySetDirection(Direction.Forward, secondLootRoom);
            secondLootRoom.TrySetDirection(Direction.Forward, finalRoom);

            return enter;
        }
    }
}