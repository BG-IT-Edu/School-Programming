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
		adjacents[secondVertex].Add(firstVertex);
	}
	private bool isCyclicUtil(int vertex, bool[] visited, int parent)
	{
		visited[vertex] = true;

		foreach (int i in adjacents[vertex])
		{
			if (!visited[i])
			{
				if (isCyclicUtil(i, visited, vertex))
                {
					return true;
                }
			}
			else if (i != parent)
            {
				return true;
			}
				
		}
		return false;
	}

	private bool isCyclic()
	{
		bool[] visited = new bool[verticesCount];
		for (int i = 0; i < verticesCount; i++)
        {
			visited[i] = false;
        }

		for (int u = 0; u < verticesCount; u++)
        {
			if (!visited[u])
            {
				if (isCyclicUtil(u, visited, -1))
                {
					return true;
				}	
			}
		}
			
		return false;
	}

	public static void Main()
	{
		Graph graph = ReadGraph();
		if (graph.isCyclic())
			Console.WriteLine("Graph contains cycle");
		else
			Console.WriteLine("Graph doesn't contain cycle");
	}

	private static Graph ReadGraph()
	{
		int verticesCount = int.Parse(Console.ReadLine());
		Graph graph = new Graph(verticesCount);

		int edgesCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < edgesCount; i++)
		{
			int[] edgeArr = Console.ReadLine()
				.Split("-").Select(int.Parse).ToArray();
			graph.AddEdge(edgeArr[0], edgeArr[1]);
		}

		return graph;
	}
}
