namespace MonteCarloModeling
{
	public class SlaveDestroyer : ITarget
	{
		private double _accuracy;
		public bool IsAlive { get; private set; }

		public SlaveDestroyer(double accuracy)
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

			if(Model.GetRandom() < _accuracy)
				target.AcceptDamage();
		}

		public void Reset()
		{
			IsAlive = true;
		}
	}
}