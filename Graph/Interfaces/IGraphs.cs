using System.Collections.Generic;

namespace Graph.Interfaces
{
	public interface IGraphs
	{
		List<Node> GNodes { get; set; }
		List<Edge> GEdges { get; set; }

		
	}
}