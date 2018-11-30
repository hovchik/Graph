namespace Graph
{
	public class Edge
	{
		public Node From { get; set; }
		public Node To { get; set; }
		public int Weight { get; set; }

		public Edge(Node _from, Node to, int weight = 1)
		{
			From = _from;
			To = to;
			Weight = weight;
		}
	}
}