namespace Graph.Interfaces
{
	public interface IEdge
	{
		Node From { get; set; }
		Node To { get; set; }
		int Weight { get; set; }
	}
}