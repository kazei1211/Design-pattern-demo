// Tạo các prototype
using Prototype;

Address address1 = new Address("New York");
Address address2 = new Address("Los Angeles");
Address address3 = new Address("Chicago");

ShallowCopyPrototype shallowPrototype = new ShallowCopyPrototype("Alice", address1);
DeepCopyPrototype deepPrototype = new DeepCopyPrototype("Bob", address2);
CopyConstructorPrototype copyConstructorPrototype = new CopyConstructorPrototype("Charlie", address3);
SerializationPrototype serializationPrototype = new SerializationPrototype("Diana", address1);
GenericPerson genericPerson = new GenericPerson("Eve", address2);

// Tạo registry và đăng ký các prototype
PrototypeRegistry registry = new PrototypeRegistry();
registry.RegisterPrototype("shallow", shallowPrototype);
registry.RegisterPrototype("deep", deepPrototype);
registry.RegisterPrototype("copyConstructor", copyConstructorPrototype);
registry.RegisterPrototype("serialization", serializationPrototype);
registry.RegisterPrototype("generic", genericPerson);

// Tạo AudioPlayer
AudioPlayer player = new AudioPlayer(registry);

while (true)
{
    Console.WriteLine("Choose a Prototype Pattern implementation to clone:");
    Console.WriteLine("1. Shallow Copy");
    Console.WriteLine("2. Deep Copy");
    Console.WriteLine("3. Copy Constructor");
    Console.WriteLine("4. Serialization");
    Console.WriteLine("5. Generic Cloning");
    Console.WriteLine("6. List Registered Prototypes");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");

    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 and 6.\n");
        continue;
    }

    if (choice == 0)
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    string key = "";
    switch (choice)
    {
        case 1:
            key = "shallow";
            break;
        case 2:
            key = "deep";
            break;
        case 3:
            key = "copyConstructor";
            break;
        case 4:
            key = "serialization";
            break;
        case 5:
            key = "generic";
            break;
        case 6:
            registry.ListPrototypes();
            Console.WriteLine();
            continue;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.\n");
            continue;
    }

    player.PlayPrototype(key);
    Console.WriteLine();

    // Tùy chọn: Hiển thị thông tin của đối tượng clone và thay đổi để thấy sự khác biệt
    Console.WriteLine("Do you want to modify the clone's city? (y/n): ");
    string modify = Console.ReadLine();
    if (modify.Equals("y", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("Enter new city: ");
        string newCity = Console.ReadLine();

        IPrototype clonedPrototype = registry.GetPrototype(key);
        if (clonedPrototype is ShallowCopyPrototype shallowClone)
        {
            shallowClone.Address.City = newCity;
            Console.WriteLine("After modification:");
            Console.WriteLine($"Original: {shallowPrototype}");
            Console.WriteLine($"Clone: {shallowClone}");
        }
        else if (clonedPrototype is DeepCopyPrototype deepClone)
        {
            deepClone.Address.City = newCity;
            Console.WriteLine("After modification:");
            Console.WriteLine($"Original: {deepPrototype}");
            Console.WriteLine($"Clone: {deepClone}");
        }
        else if (clonedPrototype is CopyConstructorPrototype copyConstructorClone)
        {
            copyConstructorClone.Address.City = newCity;
            Console.WriteLine("After modification:");
            Console.WriteLine($"Original: {copyConstructorPrototype}");
            Console.WriteLine($"Clone: {copyConstructorClone}");
        }
        else if (clonedPrototype is SerializationPrototype serializationClone)
        {
            serializationClone.Address.City = newCity;
            Console.WriteLine("After modification:");
            Console.WriteLine($"Original: {serializationPrototype}");
            Console.WriteLine($"Clone: {serializationClone}");
        }
        else if (clonedPrototype is GenericPerson genericClone)
        {
            genericClone.Address.City = newCity;
            Console.WriteLine("After modification:");
            Console.WriteLine($"Original: {genericPerson}");
            Console.WriteLine($"Clone: {genericClone}");
        }
    }

    Console.WriteLine();
}
