using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public enum GPUMemoryType
    {
        GDDR5,
        GDDR6,
        GDDR7
    }

    public enum GPUInterface
    {
        PCIe3,
        PCIe4,
        PCIe5
    }

    public class GPU : Product
    {
        private uint gpuPower;
        private uint gpuMemoryCapacity;

        public uint GPUPower { get => gpuPower; set => gpuPower = value; }
        public GPUMemoryType GPUMemoryType { get; set; }
        public uint GPUMemoryCapacity { get => gpuMemoryCapacity; set => gpuMemoryCapacity = value; }
        public GPUInterface GPUInterface { get; set; }

        public GPU() : base()
        {
            GPUPower = 0;
            GPUMemoryCapacity = 0;
            GPUMemoryType = GPUMemoryType.GDDR5;
            GPUInterface = GPUInterface.PCIe3;
        }

        public GPU(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, uint gpuPower, GPUMemoryType gpuMemoryType, uint gpuMemoryCapacity, GPUInterface gpuInterface) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            GPUPower = gpuPower;
            GPUMemoryCapacity = gpuMemoryCapacity;
            GPUMemoryType = gpuMemoryType;
            GPUInterface = gpuInterface;
        }

        public override string? ToString()
        {
            return base.ToString() + $"\nGPUPower: {GPUPower}\nGPUMemoryCapacity: {GPUMemoryCapacity}\nGPUMemoryType: {GPUMemoryType}\nGPUInterface: {GPUInterface}";
        }
    }
}
