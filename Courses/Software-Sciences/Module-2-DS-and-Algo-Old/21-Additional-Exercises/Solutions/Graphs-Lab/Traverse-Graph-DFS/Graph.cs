using System;
using System.Collections.Generic;
using System.Linq;

class Graph
{
    private static int verticesCount;
    private static List<int>[] adjacents;

    public Graph(int _verticesCount)
    {
        adjacents = new List<int>[_verticesCount];
        for (int i = 0; i < adjacents.Length; i++)
        {
            adjacents[i] = new List<int>();
        }
        verticesCount = _verticesCount;
    }

    public void AddEdge(int firstVertex, int secondVertex)
    {
        adjacents[firstVertex].Add(secondVertex);
    }

    void DFSUtil(int vertex, bool[] visited)
    {
        visited[vertex] = true;
        Console.Write(vertex + " ");

        List<int> verticesList = adjacents[vertex];
        foreach (var v in verticesList)
        {
            if (!visited[v])
                DFSUtil(v, visited);
        }
    }

    void DFS(int vertex)
    {
        bool[] visited = new bool[verticesCount];

        DFSUtil(vertex, visited);
    }

    public static void Main()
    {
        var graph = ReadGraph();

        int startVertex = int.Parse(Console.ReadLine());

        Console.Write("Following is Depth First " +
                      "Traversal(starting from " +
                      $"vertex {startVertex})\n");
        graph.DFS(startVertex);

        /* This is the manual creation of graph (before task 3):
        Graph graph = new Graph(4);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 3);

        Console.WriteLine(
            "Following is Depth First Traversal "
            + "(starting from vertex 2)");

        graph.DFS(2); */
    }

    private static Graph ReadGraph()
    {
        int verticesCount = int.Parse(Console.ReadLine());
        Graph graph = new Graph(verticesCount);

        int edgesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < edgesCount; i++)
        {
            int[] edgeArr = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();
            graph.AddEdge(edgeArr[0], edgeArr[1]);
        }

        return graph;
    }
}
