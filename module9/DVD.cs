using System;

namespace module9
{
    class DVD : Storage
    {
        private double readWriteSpeed;
        private bool isDoubleLayer;
        public DVD(string name, string model, double readWriteSpeed, bool isDoubleLayer)
        {
            Name = name;
            Model = model;
            this.readWriteSpeed = readWriteSpeed;
            this.isDoubleLayer = isDoubleLayer;
        }
        public override double GetMemory()
        {
            return isDoubleLayer ? 4.0 : 6.7;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Burn data to a DVD. Data Size: {dataSize} Gigabyte");
        }

        public override void GetFreeSpaceInfo()
        {
            Console.WriteLine($"Free space on DVD storage: {GetMemory()} Gigabyte");
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Information about DVD-disk: {Name}, {Model}, Read/write speed: {readWriteSpeed} Giga/sec");
        }
    }
}
