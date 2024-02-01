using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ConstrainedExecution;


namespace Assignment_Car_rental_system_
{
    class car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }
        public bool IsAvailable { get; set; }

        public car(int id, string make, string model, decimal rentalprice, bool isAvailable)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.RentalPrice = rentalprice;
            this.IsAvailable = isAvailable;
        }
        public void Rent()
        {
            IsAvailable = false;
        }
        public void Return()
        {
            IsAvailable = true;
        }
        public override string ToString()
        {
            return Id + " . " + Make + " " + Model + " (Rental price: " + RentalPrice + "/day)";
        }
    }
    class Program
    {
        static void Main()
        {
            car[] cars =
            {
                new car(1,"Toyta","Corolla",50,true),
                new car(2,"Honda","Civic",60,true),
                new car(3,"Ford","Mustang",80,true)

            };

            Console.WriteLine("Welcome to the car rental system! \n");
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Rent a car");
                Console.WriteLine("2.Return a car");
                Console.WriteLine("3.View available cars");
                Console.WriteLine("Exist");

                Console.WriteLine("\nPlease enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("Rent a car:");
                    foreach (car car in cars)
                    {
                        if (car.IsAvailable)
                        {
                            Console.WriteLine(car + "-Available");
                        }
                        else
                        {
                            Console.WriteLine(car + "- Rented");
                        }
                    }
                    Console.Write("Please enter the ID of the car you want to rent: ");
                    int carIdToRent = int.Parse(Console.ReadLine());

                    car selectedCar = null;
                    foreach (car car in cars)
                    {
                        if (car.Id == carIdToRent && car.IsAvailable)
                        {
                            selectedCar = car;
                            break;
                        }

                    }
                    if (selectedCar == null)
                    {
                        Console.WriteLine("\nSorry, the selected car is not available for rent.\n");
                    }
                    else
                    {
                        selectedCar.Rent();
                        Console.WriteLine($"\nRented the {selectedCar.Make} {selectedCar.Model} for ${selectedCar.RentalPrice}/day.\n");


                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Return a Car:");
                    foreach (car car in cars)
                    {
                        if (car.IsAvailable)
                        {
                            Console.WriteLine(car + "-Available");

                        }
                        else
                        {
                            Console.WriteLine(car + "- Rented");
                        }
                    }


                    Console.Write("Please enter the ID of the car you want to return: ");
                    int carIdToReturn = int.Parse(Console.ReadLine());
                    car selectedcar = null;
                    foreach (car car in cars)
                    {
                        if (car.Id == carIdToReturn && !car.IsAvailable)
                        {
                            selectedcar = car;
                            break;
                        }
                    }
                    if (selectedcar == null)
                    {
                        Console.WriteLine("\nSorry, the selected car cannot be returned.\n");

                    }
                    else
                    {
                        selectedcar.Return();
                        Console.WriteLine($"\nReturned the {selectedcar.Make} {selectedcar.Model}.\n");
                    }
                }

                else if (choice == "3")
                {
                    Console.WriteLine("Available cars:");

                    bool allCarsRented = true;
                    foreach (car car in cars)
                    {
                        if (car.IsAvailable)
                        {
                            Console.WriteLine(car + " - Available");
                            allCarsRented = false;
                        }
                        else
                        {
                            Console.WriteLine(car + " - Rented");
                        }
                    }
                    if (allCarsRented)
                    {
                        Console.WriteLine("All cars are currently rented.\n");
                    }

                }
                else if(choice == "4")
                {
                    Console.WriteLine("Thank you for using the car rental system!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");

                }
           
            }
            Console.ReadKey();
        }
    }
}

