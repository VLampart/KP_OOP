using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    enum DriveType
    {
        HDD,
        SSD,
        NVMe
    }

    enum DriveInterface
    {
        SATA,
        mSATA,
        M2
    }
    internal class Drive : Product
    {
        private uint driveCapacity;
        private uint driveRead;
        private uint driveWrite;

        public uint DriveCapacity { get => driveCapacity; set => driveCapacity = value; }
        public DriveType DriveType { get; set; }
        public DriveInterface DriveInterface { get; set; }
        public uint DriveRead { get => driveRead; set => driveRead = value; }
        public uint DriveWrite { get => driveWrite; set => driveWrite = value; }

        public Drive() : base()
        {
            DriveCapacity = 0;
            DriveType = DriveType.HDD;
            DriveInterface = DriveInterface.SATA;
            DriveRead = 0;
            DriveWrite = 0;
        }

        public Drive(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, uint driveCapacity, DriveType driveType, DriveInterface driveInterface, uint driveRead, uint driveWrite) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            DriveCapacity = driveCapacity;
            DriveType = driveType;
            DriveInterface = driveInterface;
            DriveRead = driveRead;
            DriveWrite = driveWrite;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
