using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the file manager!");

        while (true)
        {
            Console.WriteLine("\nSelect an action:");
            Console.WriteLine("1. Viewing the contents of a directory");
            Console.WriteLine("2. Create file/directory");
            Console.WriteLine("3. Delete file/directory");
            Console.WriteLine("4. Copy file/directory");
            Console.WriteLine("5. Moving file/directory");
            Console.WriteLine("6. Reading from a file");
            Console.WriteLine("7. Writing to a file");
            Console.WriteLine("0. Exit");

            int choice = GetUserChoice(0, 7);

            switch (choice)
            {
                case 1:
                    ViewDirectoryContents();
                    break;
                case 2:
                    CreateFileOrDirectory();
                    break;
                case 3:
                    DeleteFileOrDirectory();
                    break;
                case 4:
                    CopyFileOrDirectory();
                    break;
                case 5:
                    MoveFileOrDirectory();
                    break;
                case 6:
                    ReadFromFile();
                    break;
                case 7:
                    WriteToFile();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void ViewDirectoryContents()
    {
        string path = GetPathFromUser("Enter the path to the directory: ");

        if (Directory.Exists(path))
        {
            DisplayFileSystemEntries(path);
        }
        else
        {
            Console.WriteLine("Directory is not found.");
        }
    }

    static void CreateFileOrDirectory()
    {
        string path = GetPathFromUser("Enter the path to create the file/directory: ");
        char type = GetUserChoice("Enter (F - file, D - directory): ", new[] { 'F', 'D' });

        if (type == 'F')
        {
            CreateFile(path);
        }
        else if (type == 'D')
        {
            CreateDirectory(path);
        }
    }

    static void DeleteFileOrDirectory()
    {
        string path = GetPathFromUser("Enter the path to delete the file/directory: ");

        if (FileOrDirectoryExists(path))
        {
            DeleteFileOrDirectory(path);
        }
        else
        {
            Console.WriteLine("The file or directory does not exist.");
        }
    }

    static void CopyFileOrDirectory()
    {
        string sourcePath = GetPathFromUser("Enter the path to copy the file/directory: ");
        string destinationPath = GetPathFromUser("Enter the path to the new location: ");

        if (FileOrDirectoryExists(sourcePath))
        {
            CopyFileOrDirectory(sourcePath, destinationPath);
        }
        else
        {
            Console.WriteLine("The file or directory does not exist.");
        }
    }

    static void MoveFileOrDirectory()
    {
        string sourcePath = GetPathFromUser("Enter the path to move the file/directory: ");
        string destinationPath = GetPathFromUser("Enter the path to the new location: ");

        if (FileOrDirectoryExists(sourcePath))
        {
            MoveFileOrDirectory(sourcePath, destinationPath);
        }
        else
        {
            Console.WriteLine("The file or directory does not exist.");
        }
    }

    static void ReadFromFile()
    {
        string path = GetPathFromUser("Enter the path to read the file: ");

        if (File.Exists(path))
        {
            ReadAndDisplayFileContent(path);
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }

    static void WriteToFile()
    {
        string path = GetPathFromUser("Enter the path to the file to write to: ");
        string content = GetUserInput("Enter the text to write: ");

        WriteToFile(path, content);
    }

 

    static string GetPathFromUser(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static char GetUserChoice(string prompt, char[] validChoices)
    {
        char choice;
        do
        {
            Console.Write(prompt);
        } while (!char.TryParse(Console.ReadLine(), out choice) || !validChoices.Contains(choice));

        return choice;
    }

    static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static void DisplayFileSystemEntries(string path)
    {
        string[] files = Directory.GetFiles(path);
        string[] directories = Directory.GetDirectories(path);

        Console.WriteLine("\nFiles:");
        foreach (var file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        Console.WriteLine("\nDirectories:");
        foreach (var directory in directories)
        {
            Console.WriteLine(Path.GetFileName(directory));
        }
    }

    static void CreateFile(string path)
    {
        File.Create(path).Close();
        Console.WriteLine("File is created");
    }

    static void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
        Console.WriteLine("Directory is created.");
    }

    static bool FileOrDirectoryExists(string path)
    {
        return File.Exists(path) || Directory.Exists(path);
    }

    static void DeleteFileOrDirectory(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File is deleted.");
        }
        else if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
            Console.WriteLine("Directory is deleted.");
        }
    }

    static void CopyFileOrDirectory(string sourcePath, string destinationPath)
    {
        if (File.Exists(sourcePath))
        {
            File.Copy(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)), true);
            Console.WriteLine("File is copied.");
        }
        else if (Directory.Exists(sourcePath))
        {
            CopyDirectory(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
            Console.WriteLine("Directory is copied.");
        }
    }

    static void MoveFileOrDirectory(string sourcePath, string destinationPath)
    {
        if (File.Exists(sourcePath))
        {
            File.Move(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
            Console.WriteLine("The file was moved successfully.");
        }
        else if (Directory.Exists(sourcePath))
        {
            Directory.Move(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
            Console.WriteLine("The directory was moved successfully.");
        }
    }

    static void ReadAndDisplayFileContent(string path)
    {
        string content = File.ReadAllText(path);
        Console.WriteLine($"\nThe contents of the file:\n{content}");
    }

    static void WriteToFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine("The text has been successfully written to the file.");
    }

    static int GetUserChoice(int min, int max)
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
        {
            Console.WriteLine("Incorrect input. Please enter a number from " + min + " to " + max + ".");
        }
        return choice;
    }
}