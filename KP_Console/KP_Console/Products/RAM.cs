using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    enum RAMType
    {
        DDR3,
        DDR4,
        DDR5
    }

    internal class RAM : Product
    {
        private uint ramCapacity;
        private double ramFrequency;
        private uint ramCount;

        public uint RAMCapacity { get => ramCapacity; set => ramCapacity = value; }
        public double RAMFrequency { get => ramFrequency; set => ramFrequency = value; }
        public RAMType RAMType { get; set; }
        public uint RAMCount { get => ramCount; set => ramCount = value; }

        public RAM() : base()
        {
            RAMCapacity = 0;
            RAMFrequency = 0;
            RAMType = RAMType.DDR3;
        }

        public RAM(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, uint ramCapacity, double ramFrequency, RAMType ramType, uint ramCount) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            RAMCapacity = ramCapacity;
            RAMFrequency = ramFrequency;
            RAMType = ramType;
            RAMCount = ramCount;
        }

        public override string? ToString()
        {
            return base.ToString() + $"\nRAMCapacity: {RAMCapacity}\nRAMFrequency: {RAMFrequency}\nRAMType: {RAMType}\nRAMCount: {RAMCount}";
        }
    }
}
