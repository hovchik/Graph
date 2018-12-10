using Graph.Interfaces;

namespace Graph
{
	public class Node:INode
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Node(int id, string name = "Simple")
		{
			Id = id;
			Name = name;
		}
	}
}