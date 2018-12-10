using Graph.Helpers;
using Graph.Interfaces;
using System;

namespace Graph
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Graphs g = new Graphs();
			for (int i = 1; i <= 4; i++)
			{
				g.GNodes.Add(new Node(i));
			}
			Edge edge = new Edge(g.GNodes[0], g.GNodes[1]);
			Edge edge2 = new Edge(g.GNodes[0], g.GNodes[3]);
			g.GEdges.Add(edge);
			g.GEdges.Add(edge2);

			IGraphs oG = g.GetCopy();
			g.DelegateCreation(Delegates);

			bool diff = ReferenceEquals(g, oG);
			Console.ReadLine();
		}

		private static void Delegates(IGraphs obj)
		{
			throw new NotImplementedException();
		}


	}
}
