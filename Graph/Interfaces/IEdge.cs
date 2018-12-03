namespace Graph
{
	public interface IEdge
	{
		Node From { get; set; }
		Node To { get; set; }
		int Weight { get; set; }
	}
}