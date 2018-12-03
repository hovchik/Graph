using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Helpers
{
	public static class GraphExtensions
	{
		public static IGraphs GetFullGraph(this IGraphs graph)
		{
			return new Graphs();
		}

		public static IGraphs GetCopy(this IGraphs copyGraph)
		{
			return new Graphs
			{
				GNodes = copyGraph.GNodes,
				GEdges = copyGraph.GEdges
			};
		}

		public static void DelegateCreation(this IGraphs g, Action<IGraphs> delegates)
		{
			 delegates(g);
		}
	}
}
