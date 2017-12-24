using System;

namespace MonteCarloModeling
{
	class Model
	{
		private AttackGroup _attackGroup;
		private Defense _defense;
		private static readonly Random Rand = new Random();

		public void Initialize(MasterDestroyer master, SlaveDestroyer[] slaves, Defense defense,
			double accuracy_all, double accuracy_1_1)
		{
			_attackGroup = new AttackGroup(master, slaves, accuracy_all, accuracy_1_1);
			_defense = defense;
		}

		public bool Run()
		{
			_attackGroup.Reset();

			foreach (ITarget target in _attackGroup)
				_defense.Attack(target);

			var mainTarget = new MainTarget();
			_attackGroup.AttackMainTarget(mainTarget);

			return !mainTarget.IsAlive;
		}

		public static double GetRandom()
		{
			return Rand.NextDouble() * 100.0;
		}
	}
}
