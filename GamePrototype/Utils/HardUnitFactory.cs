using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    public class HardUnitFactory : IUnitFactory
    {
        public Unit CreatePlayer(string name)
        {
            var player = new Player(name, 25, 25, 7);

            player.AddItemToInventory(new Weapon(12, 15, "Sword"));
            player.AddItemToInventory(new Armour(8, 15, "Armour"));
            player.AddItemToInventory(new RangeWeapon(10, 15, "Bow"));
            player.AddItemToInventory(new Helmet(3, 15, "Helmet"));
            player.AddItemToInventory(new HealthPotion("Potion"));

            return player;
        }

        public Unit CreateGoblinEnemy()
        {
            return new Goblin(GameConstants.Goblin, 25, 25, 4);
        }
    }
}