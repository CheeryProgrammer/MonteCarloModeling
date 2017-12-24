namespace MonteCarloModeling
{
	public class Defense
	{
		private double _accuracy;

		public Defense(double accuracy)
		{
			_accuracy = accuracy;
		}

		public void Attack(ITarget target)
		{
			if(TryShot())
				target.AcceptDamage();
		}

		private bool TryShot()
		{
			return Model.GetRandom() < _accuracy;
		}
	}
}