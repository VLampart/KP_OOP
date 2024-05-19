namespace Products
{
    public class PowerSupply : Product
    {
        private uint supplyPower;

        public uint SupplyPower { get => supplyPower; set => supplyPower = value; }

        public PowerSupply() : base()
        {
            supplyPower = 0;
        }

        public PowerSupply(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, uint supplyPower) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            SupplyPower = supplyPower;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSupplyPower: {SupplyPower}";
        }
    }
}
