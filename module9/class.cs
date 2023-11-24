using System;
namespace module9
{
        public class Program
        {
            static void Main()
            {
                Storage[] devices = new Storage[]
                {
            new Flash("FlashDrive", "Model123", 3.0, 64),
            new DVD("DVD-RW", "LiteOn", 8.0, true),
            new HDD("ExternalHDD", "Seagate", 2.0, 2, 500)
                };
                double totalMemory = 0;
                foreach (var device in devices)
                {
                    totalMemory += device.GetMemory();
                }
                double dataSize = 565;
                foreach (var device in devices)
                {
                    device.CopyData(dataSize);
                }
                Console.WriteLine($"Total memory: {totalMemory} Gigabyte");
                double copySpeed = 5;
                double copyTime = dataSize / copySpeed;
                Console.WriteLine($"Time, to copy elements: {copyTime} sec");
                double totalDataSize = dataSize;
                foreach (var device in devices)
                {
                    double deviceMemory = device.GetMemory();
                    double devicesNeeded = Math.Ceiling(totalDataSize / deviceMemory);
                    Console.WriteLine($"To transfer data, you will need {devicesNeeded} type device {device.GetType().Name}");
                    Console.ReadKey();
                }
            }
        }
    }
