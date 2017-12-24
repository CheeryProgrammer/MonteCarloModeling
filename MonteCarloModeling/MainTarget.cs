namespace MonteCarloModeling
{
	internal class MainTarget : ITarget
	{
		public bool IsAlive { get; private set; }

		public MainTarget()
		{
			IsAlive = true;
		}

		public void AcceptDamage()
		{
			IsAlive = false;
		}
	}
}