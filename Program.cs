using System;

class PowerBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Power Bill Calculator!");

        // Get user input for power consumption
        double powerConsumption = GetUserInput("Enter power consumption in kWh: ");

        // Get user input for usage type (residential, commercial, or industrial)
        char usageType = GetUsageType();

        // Get tariff rate based on usage type
        double tariffRate = GetTariffRate(usageType);

        // Calculate power bill
        double totalBill = CalculatePowerBill(powerConsumption, tariffRate);

        // Display the monthly power bill amount
        DisplayBillDetails(powerConsumption, tariffRate, totalBill);

        Console.WriteLine("Thank you for using the Power Bill Calculator!");
    }

    static double GetUserInput(string prompt)
    {
        double userInput;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
            }
        }
    }

    static char GetUsageType()
    {
        char usageType;
        while (true)
        {
            Console.Write("Enter usage type (R for residential, C for commercial, I for industrial): ");
            if (char.TryParse(Console.ReadLine().ToUpper(), out usageType) && (usageType == 'R' || usageType == 'C' || usageType == 'I'))
            {
                return usageType;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'R' for residential, 'C' for commercial, or 'I' for industrial.");
            }
        }
    }

    static double GetTariffRate(char usageType)
    {
        // Tariff rates based on the provided information
        switch (usageType)
        {
            case 'R':
                return 12.50; // Residential tariff rate per kWh
            case 'C':
                return 15.75; // Commercial tariff rate per kWh
            case 'I':
                return 18.90; // Industrial tariff rate per kWh
            default:
                return 0.0;   // Default to 0 if the usage type is not recognized
        }
    }

    static double CalculatePowerBill(double powerConsumption, double tariffRate)
    {
        return powerConsumption * tariffRate;
    }

    static void DisplayBillDetails(double powerConsumption, double tariffRate, double totalBill)
    {
        Console.WriteLine("\nBill Details:");
        Console.WriteLine($"Power Consumption: {powerConsumption} kWh");
        Console.WriteLine($"Tariff Rate: KES {tariffRate:F2} per kWh");
        Console.WriteLine($"Total Bill: KES {totalBill:F2}");
    }
}

