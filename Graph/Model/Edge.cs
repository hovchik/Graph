using Graph.Interfaces;

namespace Graph
{
	public class Edge:IEdge
	{
		public Node From { get; set; }
		public Node To { get; set; }
		public int Weight { get; set; }

		public Edge(Node _from, Node _to, int weight = 1)
		{
			From = _from;
			To = _to;
			Weight = weight;
		}
	}
}