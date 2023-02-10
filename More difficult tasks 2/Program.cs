using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_difficult_tasks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Trip Cost Calculator!");
            Console.WriteLine("Please enter your departure city:");
            string departureCity = Console.ReadLine();
            Console.WriteLine("Please enter up to 3 cities you would like to visit:");
            string[] citiesToVisit = new string[3];
            for (int i = 0; i < citiesToVisit.Length; i++)
            {
                citiesToVisit[i] = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(citiesToVisit[i]))
                {
                    break;
                }
            }
            Console.WriteLine("Please enter the cost of your trip:");
            double tripCost = Convert.ToDouble(Console.ReadLine());

            double totalCost = tripCost;
            bool isFromEU = !(departureCity == "Madrid" || departureCity == "Kishinev" || departureCity == "London");

            foreach (string city in citiesToVisit)
            {
                if (city == "Vatican")
                {
                    totalCost += tripCost * 0.5;
                }
                else if (city == "Berlin")
                {
                    totalCost += tripCost * 0.13;
                }
                else if (city == "Palermo")
                {
                    if (departureCity == "London")
                    {
                        totalCost += tripCost * 0.07;
                    }
                    else if (departureCity == "Kishinev")
                    {
                        totalCost += tripCost * 0.11;
                    }
                }
                else if (city == "Riga")
                {
                    if (departureCity == "Paris")
                    {
                        totalCost += tripCost * 0.09;
                    }
                }
                else if (!isFromEU)
                {
                    totalCost += tripCost * 0.04;
                }
            }

            Console.WriteLine("The total cost of your trip is: $" + totalCost);
        }
    }
}