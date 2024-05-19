namespace Products
{
    public class CPU : Product
    {
        private uint cpuCoresCount;
        private double cpuFrequency;
        private string cpuSocket;

        public uint CPUCoresCount { get => cpuCoresCount; set => cpuCoresCount = value; }
        public double CPUFrequency { get => cpuFrequency; set => cpuFrequency = value; }
        public string CPUSocket { get => cpuSocket; set => cpuSocket = value; }

        public CPU() : base()
        {
            CPUCoresCount = 0;
            CPUFrequency = 0;
            CPUSocket = "";
        }

        public CPU(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, uint cpuCoresCount, double cpuFrequency, string cpuSocket) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            CPUCoresCount = cpuCoresCount;
            CPUFrequency = cpuFrequency;
            CPUSocket = cpuSocket;
        }

        public override string? ToString()
        {
            return base.ToString() + $"\nCPUCores: {CPUCoresCount}\nCPUFrequency: {CPUFrequency}\nCPUSocket: {CPUSocket}";
        }
    }
}
