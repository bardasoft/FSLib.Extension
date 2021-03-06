namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInOutBack
	/// </summary>
	public class EaseInOutBackTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// 获得在指定的时间刻度上应该处于的位置
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			var s = 1.70158;
			if ((pos /= 0.5) < 1)
				return 0.5 * (pos * pos * (((s *= (1.525)) + 1) * pos - s));
			return 0.5 * ((pos -= 2) * pos * (((s *= (1.525)) + 1) * pos + s) + 2);

		}

		#endregion
	}
}