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
    public class EasyUnitFactory : IUnitFactory
    {
        public Unit CreatePlayer(string name)
        {
            var player = new Player(name, 40, 40, 5);

            player.AddItemToInventory(new Weapon(8, 15, "Sword"));
            player.AddItemToInventory(new Armour(15, 15, "Armour"));
            player.AddItemToInventory(new RangeWeapon(6, 15, "Bow"));
            player.AddItemToInventory(new Helmet(5, 15, "Helmet"));
            player.AddItemToInventory(new HealthPotion("Potion"));

            return player;
        }

        public Unit CreateGoblinEnemy()
        {
            return new Goblin(GameConstants.Goblin, 15, 15, 2);
        }
    }
}