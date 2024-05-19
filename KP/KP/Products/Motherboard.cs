namespace Products
{
    public class Motherboard : Product
    {
        private string motherboardSocket;
        private string motherboardChipset;
        private uint motherboardRam;

        public string MotherboardSocket { get => motherboardSocket; set => motherboardSocket = value; }
        public string MotherboardChipset { get => motherboardChipset; set => motherboardChipset = value; }
        public uint MotherboardRam { get => motherboardRam; set => motherboardRam = value; }

        public Motherboard() : base()
        {
            MotherboardSocket = "";
            MotherboardChipset = "";
            MotherboardRam = 0;
        }

        public Motherboard(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, string motherboardSocket, string motherboardChipset, uint motherboardRam) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            MotherboardSocket = motherboardSocket;
            MotherboardChipset = motherboardChipset;
            MotherboardRam = motherboardRam;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMotherboardSocket: {MotherboardSocket}\nMotherboardChipset: {MotherboardChipset}\nMotherboardRam: {MotherboardRam}";
        }
    }
}
