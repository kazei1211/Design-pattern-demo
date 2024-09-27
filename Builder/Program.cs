using Builder;

int type = -1;
Console.WriteLine("Select type:");
Console.WriteLine("1. Director Builder");
Console.WriteLine("2. Fluent Builder");
Console.WriteLine("3. Director-less Builder");
Console.WriteLine("4. Immutable Builder");
Console.Write("Enter your type: ");

switch (type)
{
    case 1:
        int choice = -1;
        IComputerBuilder builder;
        ComputerDirector director = new ComputerDirector();
        
        while (true)
        {
            Console.WriteLine("Select computer type to build:");
            Console.WriteLine("1. Gaming Computer");
            Console.WriteLine("2. Office Computer");
            Console.WriteLine("3. Ultrabook");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 3.\n");
                continue;
            }

            switch (choice)
            {
                case 1:
                    builder = new GamingComputerBuilder();
                    break;
                case 2:
                    builder = new OfficeComputerBuilder();
                    break;
                case 3:
                    builder = new UltrabookBuilder();
                    break;
                case 0:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.\n");
                    continue;
            }

            director.Builder = builder;
            director.BuildComputer();
            Computer computer = builder.GetComputer();
            Console.WriteLine(computer.ListComponents());
        }

        break;

    case 2:
        FluentComputerBuilder fluentBuilder = new FluentComputerBuilder();

        Computer gamingComputer = fluentBuilder
            .AddCPU("Intel i9 CPU")
            .AddGPU("NVIDIA RTX 3080 GPU")
            .AddRAM("32GB DDR4 RAM")
            .AddStorage("1TB NVMe SSD")
            .Build();

        Console.WriteLine("Gaming Computer:");
        Console.WriteLine(gamingComputer.ListComponents());
        break;

    case 3:
        IComputerBuilder directorLessBuilder = new OfficeComputerBuilder();

        // Client directly controls the build process
        directorLessBuilder.AddCPU();
        directorLessBuilder.AddRAM();
        directorLessBuilder.AddStorage();
        Computer officeComputer = directorLessBuilder.GetComputer();

        Console.WriteLine("Office Computer:");
        Console.WriteLine(officeComputer.ListComponents());
        break;

    case 4:
        CarBuilder immutableBuilder = new CarBuilder();

        Car car = immutableBuilder
            .SetMake("Toyota")
            .SetModel("Camry")
            .SetYear(2022)
            .SetColor("Red")
            .Build();

        Console.WriteLine(car.ToString());
        break;
}



        