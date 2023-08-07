using System;
using System.IO;

public static class FindFile
{
    private static void TraverseDirDFS(DirectoryInfo dir, string fileName)
    {
        try
        {
            FileInfo[] files = dir.GetFiles();

            foreach (var file in files)
            {
                if (file.Name == fileName)
                {
                    Console.WriteLine($"{file.Name} is found in {dir.FullName}.");
                }
            }

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (DirectoryInfo child in children)
            {
                TraverseDirDFS(child, fileName);
            }
        }
        catch
        {
            Console.WriteLine($"No access to {dir}");
        }
    }

    public static void TraverseDirDFS(string directoryPath, string fileName)
    {
        TraverseDirDFS(new DirectoryInfo(directoryPath), fileName);
    }

    static void Main()
    {
        //TraverseDirDFS(@"E:\", "Trees-BFS-DFS-Exercises.docx");
    }
}