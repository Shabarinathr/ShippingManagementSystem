using System;

namespace ShippingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Shipping Order Entry System =====\n");

            string shipperName = "ABC Exports Ltd";
            Console.WriteLine($"Shipper Name: {shipperName}");

            int shipmentId = 1001;
            Console.WriteLine($"Shipment ID: {shipmentId}");

            double weightKg = 500.50;
            Console.WriteLine($"Weight: {weightKg} kg");

            double baseCost = 5000;
            Console.WriteLine($"Base Shipping Cost: ${baseCost}");

            bool isInternational = true;
            Console.WriteLine($"International Shipment: {isInternational}");
            
            double finalCost;
            if (isInternational)
            {
                finalCost = (baseCost + (weightKg * 10)) * 1.5;
                Console.WriteLine("International shipping : 50% surcharge applied");
            }
            else
            {
                finalCost = baseCost + (weightKg * 10);
            }
                Console.WriteLine($"Final Cost: ${finalCost}");

            string status = "Pending";
            Console.WriteLine($"Status: {status}");

            Console.WriteLine("\nPress any key to exit.......");

            Console.WriteLine("\n------ Second Shipment ------");
            string shipperName2 = "XYZ Imports Inc";
            int shipmentId2 = 1002;
            double weightKg2 = 1200;
            string destination2 = "Delhi";
            bool isInternational2 = true;
            string status2 = "In Transit";

            double baseCost2 = 5000;
            double finalCost2;
            if (isInternational2)
            {
                finalCost2 = (baseCost2 + (weightKg2 * 10)) * 1.5;
            }
            else
            {
                finalCost2 = baseCost2 + (weightKg2 * 10);
            }
            Console.WriteLine($"Shipper Name: {shipperName2}");
            Console.WriteLine($"Shipment ID : {shipmentId2}");
            Console.WriteLine($"weight: {weightKg2}");
            Console.WriteLine($"Destination: {destination2}");
            Console.WriteLine($"International Shipment: {isInternational2}");
            Console.WriteLine($"Final Cost: {finalCost2}");
            Console.WriteLine($"Status: {status2}");

            Console.ReadKey();

        }
    }
}