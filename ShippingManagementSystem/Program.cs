using System;

namespace ShippingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Shipping Cost Calculator with Business Logic =====");

            string shipperName = "ABC Exports Ltd";
            int shipmentId = 1001;
            double weightKg = 1200;
            string destination = "Mumbai";
            bool isInternational = false;

            Console.WriteLine($"Shipper Name: {shipperName}");
            Console.WriteLine($"Shipment ID: {shipmentId}");
            Console.WriteLine($"Weight (kg): {weightKg}");
            Console.WriteLine($"Destination: {destination}");


            double baseCostPerKg = 10;
            double shippingCost = weightKg * baseCostPerKg;

            Console.WriteLine($"\n Initial Cost: ${shippingCost}");

            if (weightKg > 1000)
            {
                double discount = shippingCost * 0.10;
                shippingCost = shippingCost - discount;
                Console.WriteLine($" Bulk Discount Applied(10%): -${discount}");
                Console.WriteLine($"Cost after discount: ${shippingCost}");
            }
            else
            {
                Console.WriteLine("No bulk discount (weight< 1000 kg)");
            }
            if (isInternational)
            {
                double surcharge = shippingCost * 0.50;
                shippingCost = shippingCost + surcharge;
                Console.WriteLine($" Internatinal Surcharge (50%): +${surcharge}");
            }
            else
            {
                Console.WriteLine(" Domestic shipment - no Surcharge");
            }

            double taxRate = 0;
            string taxLocation = "";

            switch (destination)
            {
                case "Mumbai":
                    taxRate = 0.05;
                    taxLocation = "Mumbai GST";
                    break;
                case "Delhi":
                    taxRate = 0.08;
                    taxLocation = "Delhi GST";
                    break;
                case "Default":
                    taxRate = 0.07;
                    taxLocation = "Standard GST";
                    break;
            }
            double tax = shippingCost * taxRate;
            shippingCost = shippingCost + tax;

            Console.WriteLine($"\n{taxLocation} ({taxRate * 100}%): +${tax}");

            Console.WriteLine($"\n--- Final Shipping Cost: ${shippingCost} ---");

            Console.WriteLine("\n Press any key to exit ...");
            Console.ReadKey();
        }
    }
}