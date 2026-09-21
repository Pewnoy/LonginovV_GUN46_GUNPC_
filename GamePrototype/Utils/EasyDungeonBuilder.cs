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
    public class EasyDungeonBuilder : IDungeonBuilder
    {
        public DungeonRoom BuildDungeon()
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom = new DungeonRoom(
                "Monster",
                new EasyUnitFactory().CreateGoblinEnemy());

            var emptyRoom = new DungeonRoom("Empty");
            var lootRoom = new DungeonRoom("Loot1", new Gold());
            var lootStoneRoom = new DungeonRoom("Loot2", new Grindstone("Stone"));
            var finalRoom = new DungeonRoom("Final",new RangeWeapon(8, 15, "Bow"));

            enter.TrySetDirection(Direction.Right, monsterRoom);
            enter.TrySetDirection(Direction.Left, emptyRoom);
            monsterRoom.TrySetDirection(Direction.Forward, lootRoom);
            monsterRoom.TrySetDirection(Direction.Left, emptyRoom);
            emptyRoom.TrySetDirection(Direction.Forward, lootStoneRoom);
            lootRoom.TrySetDirection(Direction.Forward, finalRoom);
            lootStoneRoom.TrySetDirection(Direction.Forward, finalRoom);

            return enter;
        }
    }
}