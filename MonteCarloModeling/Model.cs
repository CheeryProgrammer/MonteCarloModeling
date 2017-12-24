using System;

namespace MonteCarloModeling
{
	class Model
	{
		private AttackGroup _attackGroup;
		private Defense _defense;
		private int N;
		private int _counter;
		private static readonly Random Rand = new Random();

		public double DestroyChance
		{
			get { return N == 0 ? 0 : 100.0 * _counter / N; }
			private set { }
		}

		public void Initialize(MasterDestroyer master, SlaveDestroyer[] slaves, Defense defense,
			double accuracy_all, double accuracy_1_1)
		{
			_attackGroup = new AttackGroup(master, slaves, accuracy_all, accuracy_1_1);
			_defense = defense;
		}

		public void Run(int count)
		{
			if(count < 0)
				throw new ArgumentOutOfRangeException(nameof(count), "Value can not be less than 0");

			N = count;
			_counter = 0;

			for (int i = 0; i < count; i++)
			{
				_attackGroup.Reset();
				RunExperiment();
			}
		}

		private void RunExperiment()
		{
			if(RunExperimentInternal())
				_counter++;
		}

		private bool RunExperimentInternal()
		{
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
