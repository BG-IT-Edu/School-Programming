using System;
using System.Collections.Generic;
using System.Linq;

public class Graph
{
	private int verticesCount;
	private List<int>[] adjacentsList;
	private int shortestPath = int.MaxValue;

	public Graph(int vertices)
	{
		this.verticesCount = vertices;
		adjacentsList = new List<int>[verticesCount];

		for (int i = 0; i < verticesCount; i++)
		{
			adjacentsList[i] = new List<int>();
		}
	}

	public void AddEdge(int firstVertex, int secondVertex)
	{
		adjacentsList[firstVertex].Add(secondVertex);
		adjacentsList[secondVertex].Add(firstVertex);
	}

	public void FindShortestPath(int start, int end)
	{
		bool[] isVisited = new bool[verticesCount];
		List<int> pathList = new List<int>();

		pathList.Add(start);

		FindShortestPathUtil(start, end, isVisited, pathList);

		if(shortestPath != int.MaxValue)
        {
			Console.WriteLine("Path found. Length: " + shortestPath);
		}
		else
        {
            Console.WriteLine("No path exists");
        }
		
	}
	private void FindShortestPathUtil(int start, int end, bool[] isVisited, List<int> localPathList)
	{
		if (start == end)
		{
			if (shortestPath > localPathList.Count - 1)
			{
				shortestPath = localPathList.Count - 1;
			}
			return;
		}

		isVisited[start] = true;

		foreach (int adjacent in adjacentsList[start])
		{
			if (!isVisited[adjacent])
			{
				localPathList.Add(adjacent);
				FindShortestPathUtil(adjacent, end, isVisited,
								localPathList);
				localPathList.Remove(adjacent);
			}
		}

		isVisited[start] = false;
	}

	public static void Main()
	{
		var graph = ReadGraph();

		int startVertex = int.Parse(Console.ReadLine());
		int endVertex = int.Parse(Console.ReadLine());

		Console.WriteLine($"Shortest path length from {startVertex} to {endVertex}:");
		graph.FindShortestPath(startVertex, endVertex);
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
