﻿using System;
using System.Collections.Generic;
class DFS
{
    private int V;
    private List<int>[] adj;
    DFS(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }
    void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }
    void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        List<int> vList = adj[v];
        foreach (var n in vList)
        {
            if (!visited[n])
                DFSUtil(n, visited);
        }
    }
    void dfs(int v)
    {
        bool[] visited = new bool[V];
        DFSUtil(v, visited);
    }
    public static void Main(String[] args)
    {
        DFS g = new DFS(4);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        Console.WriteLine("Following is Depth First Traversal (starting from vertex 2)");

        g.dfs(2);
        Console.ReadKey();
    }
}