using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInExpo
	/// </summary>
	public class EaseInExpoTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// 获得在指定的时间刻度上应该处于的位置
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (pos == 0) ? 0 : Math.Pow(2, 10 * (pos - 1));
		}

		#endregion
	}
}