using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MonteCarloModeling
{
	internal class AttackGroup : IEnumerable<ITarget>
	{
		private readonly MasterDestroyer _master;
		private readonly SlaveDestroyer[] _slaves;
		private readonly double _accuracyAll;
		private readonly double _accuracy_1_1;

		public AttackGroup(MasterDestroyer master, SlaveDestroyer[] slaves,
			double accuracy_all, double accuracy_1_1)
		{
			_master = master;
			_slaves = slaves;
			_accuracyAll = accuracy_all;
			_accuracy_1_1 = accuracy_1_1;
		}

		public void AttackMainTarget(ITarget target)
		{
			if (IsGroupMixed())
			{
				AttackMixed(target);
				return;
			}

			_master.Attack(target);

			foreach (var slaveDestroyer in _slaves)
				slaveDestroyer.Attack(target);
		}

		private void AttackMixed(ITarget target)
		{
			if (_slaves.All(s => s.IsAlive))
			{
				if(Model.GetRandom() < _accuracyAll)
					target.AcceptDamage();
				return;
			}

			if (Model.GetRandom() < _accuracy_1_1)
				target.AcceptDamage();
		}

		private bool IsGroupMixed()
		{
			return _slaves != null
				&& _slaves.Any(s => s.IsAlive)
				&& _master != null
				&& _master.IsAlive;
		}

		public IEnumerator<ITarget> GetEnumerator()
		{
			yield return _master;
			foreach (var slave in _slaves)
				yield return slave;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Reset()
		{
			_master.Reset();

			foreach (var slaveDestroyer in _slaves)
				slaveDestroyer.Reset();
		}
	}
}