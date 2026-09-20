using GamePrototype.Items.EconomicItems;
using GamePrototype.Utils;

namespace GamePrototype.Items.EquipItems
{
    public abstract class EquipItem : Item
    {
        private uint _durability;
        private readonly uint _maxDurability;

        public uint Durability
        {
            get => _durability;
            protected set => _durability = value;
        }

        public override bool Stackable => false;

        public abstract EquipSlot Slot { get; }

        protected EquipItem(uint maxDurability, string name)
            : base(name)
        {
            _maxDurability = maxDurability;
            _durability = maxDurability;
        }

        public void ReduceDurability(uint delta)
        {
            if (_durability >= delta)
            {
                _durability -= delta;
            }
            else
            {
                _durability = 0;
            }
        }

        public void Repair(uint delta)
        {
            if (_durability + delta > _maxDurability)
            {
                _durability = _maxDurability;
            }
            else
            {
                _durability += delta;
            }
        }
    }
}