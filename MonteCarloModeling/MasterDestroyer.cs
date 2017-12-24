namespace MonteCarloModeling
{
	public class MasterDestroyer : ITarget
	{
		private readonly double _accuracy;
		public bool IsAlive { get; private set; }

		public MasterDestroyer(double accuracy)
		{
			_accuracy = accuracy;
			Reset();
		}

		public void AcceptDamage()
		{
			IsAlive = false;
		}

		public void Attack(ITarget target)
		{
			if (!IsAlive)
				return;

			if (Model.GetRandom() < _accuracy)
				target.AcceptDamage();
		}

		public void Reset()
		{
			IsAlive = true;
		}
	}
}