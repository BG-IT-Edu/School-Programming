using System;
using System.IO;

public static class DirectoryTraverserDFS
{
    private static void TraverseDirDFS(DirectoryInfo dir, string spaces)
    {
        Console.WriteLine(spaces + dir.FullName);

        DirectoryInfo[] children = dir.GetDirectories();

        foreach (DirectoryInfo child in children)
        {
            TraverseDirDFS(child, spaces + "  ");
        }
    }

    public static void TraverseDirDFS(string directoryPath)
    {
        TraverseDirDFS(new DirectoryInfo(directoryPath), string.Empty);
    }

    static void Main()
    {
        //TraverseDirDFS(@"C:\Windows\assembly");
    }
}