using Adapter;

int choice = -1;
AudioPlayer player = new AudioPlayer();

while (true)
{
    Console.WriteLine("Select audio type to play:");
    Console.WriteLine("1. MP3");
    Console.WriteLine("2. MP4");
    Console.WriteLine("3. VLC");
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

    if (choice == 0)
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    string audioType = "";
    switch (choice)
    {
        case 1:
            audioType = "mp3";
            break;
        case 2:
            audioType = "mp4";
            break;
        case 3:
            audioType = "vlc";
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.\n");
            continue;
    }

    Console.Write("Enter file name: ");
    string fileName = Console.ReadLine();

    player.Play(audioType, fileName);
    Console.WriteLine();
}
