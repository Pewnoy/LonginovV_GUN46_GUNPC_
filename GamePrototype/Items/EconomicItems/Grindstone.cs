namespace GamePrototype.Items.EconomicItems
{
    public sealed class Grindstone : EconomicItem
    {
        public override bool Stackable => false;

        public uint RepairAmount { get; }

        public Grindstone(string name, uint repairAmount) : base(name)
        {
            RepairAmount = repairAmount;
        }
    }
}