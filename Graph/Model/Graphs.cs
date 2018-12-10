using System;
using System.Collections.Generic;
using Graph.Interfaces;

namespace Graph
{
	public class Graphs : IGraphs,IGraphFull
	{
		public List<Node> GNodes { get; set; }
		public List<Edge> GEdges { get; set; }

		public Graphs()
		{
			GNodes = new List<Node>();
			GEdges = new List<Edge>();
		}
		public Graphs(List<Node> gNodes, List<Edge> gEdges)
		{
			GNodes = gNodes;
			GEdges = gEdges;
		}

		
		public IGraphs CreateFullGraph(int nodeCount)
		{
			throw new NotImplementedException();
		}
	}
}