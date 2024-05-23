using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    private List<Node> nodes = new List<Node>();

    public Graph()
    {
        nodes = new List<Node>();
    }

    public Graph(ref List<Node> listNodes)
    {
        nodes = listNodes;
    }

    public void AddNode(Node newNode)
    {
        nodes.Add(newNode);
    }

    public List<Node> GetNodes()
    {
        return nodes;
    }

     //BFS!
    //public void BFS(Node n)
    //{
    //    List<Node> nodesToVisit = new List<Node>();
    //    n.SetVisited(true);
    //    nodesToVisit = GetsNodesToVisit(n);

    //    while(nodesToVisit.Count > 0)
    //    {
    //        if (nodesToVisit[0].GetVisited())
    //        {
    //            nodesToVisit.RemoveAt(0);
    //        }
    //        else
    //        {
    //            nodesToVisit[0].SetVisited(true);
    //            nodesToVisit.AddRange(GetsNodesToVisit(nodesToVisit[0]));
    //        }
    //        nodesToVisit[0].SetVisited(true);
    //    }

    //}

    //public List<Node> GetsNodesToVisit(Node n)
    //{
    //    List<Node > nodesToVisit = new List<Node>();    
    //    foreach(Edge edge in n.GetEdges())
    //    {
    //        if(edge.Node1() == n)
    //        {
    //            nodesToVisit.Add(edge.Node2());
    //        }
    //        else
    //        {
    //            nodesToVisit.Add(edge.Node1());
    //        }
    //    }
    //    return nodesToVisit;
    //}

    //DFS
    //recursividad
    //public void DFS(Node n)
    //{
    //    if(!n.GetVisited())
    //    {
    //        n.SetVisited(true);

    //        if (n.GetEdges()[0].Node1()==n)
    //            {
    //                DFS(n.GetEdges()[0].Node2());
    //            }
    //            else
    //            {
    //                DFS(n.GetEdges()[0].Node1());
    //             }
    //    }
    //}

    //no recursividad
    //public void DFS2(Node n)
    //{

    //    if(!n.GetVisited())
    //    {
    //        List<Node> nodesToVisit = new List<Node>();
    //        n.SetVisited(true);

    //        while (nodesToVisit.Count > 0)
    //        {
    //            if (nodesToVisit[0].GetVisited())
    //            {
    //                nodesToVisit.RemoveAt(0);
    //            }
    //            else
    //            {
    //                nodesToVisit[0].SetVisited(true);
    //                if (nodesToVisit[0].GetEdges()[0].Node1() == nodesToVisit[0])
    //                {
    //                    nodesToVisit.Add(nodesToVisit[0].GetEdges()[0].Node2());
    //                }
    //                else
    //                {
    //                    nodesToVisit.Add(nodesToVisit[0].GetEdges()[0].Node1());
    //                }
    //            }
    //        }
    //    }
    //}
}
