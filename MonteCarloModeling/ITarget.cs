namespace MonteCarloModeling
{
	public interface ITarget
	{
		bool IsAlive { get; }
		void AcceptDamage();
	}
}