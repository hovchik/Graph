using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
	class Program
	{
		static void Main(string[] args)
		{
			Graphs g = new Graphs();
			for (int i = 1; i <= 4; i++)
			{
				g.GNodes.Add(new Node(i));
			}
			var edge = new Edge(g.GNodes[0], g.GNodes[1]);
			var edge2 = new Edge(g.GNodes[0], g.GNodes[3]);
			g.GEdges.Add(edge);
			g.GEdges.Add(edge2);
			Console.ReadLine();
		}
	}
}
