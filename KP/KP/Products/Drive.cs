namespace Products
{
    public enum DRIVEType
    {
        HDD,
        SSD,
        NVMe
    }

    public enum DriveInterface
    {
        SATA,
        mSATA,
        M2
    }

    public class Drive : Product
    {
        private uint driveCapacity;
        private uint driveRead;
        private uint driveWrite;

        public uint DriveCapacity { get => driveCapacity; set => driveCapacity = value; }
        public DRIVEType DRIVEType { get; set; }
        public DriveInterface DriveInterface { get; set; }
        public uint DriveRead { get => driveRead; set => driveRead = value; }
        public uint DriveWrite { get => driveWrite; set => driveWrite = value; }

        public Drive() : base()
        {
            DriveCapacity = 0;
            DRIVEType = DRIVEType.HDD;
            DriveInterface = DriveInterface.SATA;
            DriveRead = 0;
            DriveWrite = 0;
        }

        public Drive(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount, uint driveCapacity, DRIVEType driveType, DriveInterface driveInterface, uint driveRead, uint driveWrite) : base(productCaption, productManufacturer, productPrice, productDescription, productCount)
        {
            DriveCapacity = driveCapacity;
            DRIVEType = driveType;
            DriveInterface = driveInterface;
            DriveRead = driveRead;
            DriveWrite = driveWrite;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDriveCapacity: {DriveCapacity}\nDriveType: {DRIVEType}\nDriveInterface: {DriveInterface}\nDriveRead: {DriveRead}\nDriveWrite: {DriveWrite}";
        }
    }
}
