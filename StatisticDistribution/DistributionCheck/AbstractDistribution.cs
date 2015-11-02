using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Statistics.Distribution;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Интерфейс для классов, предоставляющийх необходимые
	/// методы и данные для проверки гипотезы
	/// </summary>
	public abstract class AbstractDistribution
	{

		protected Distribution.Distribution distr;

		/// <summary>
		/// Название закона распределения
		/// </summary>
		abstract public string Name { get; }

		/// <summary>
		/// Картинка с формулой закона распределения
		/// </summary>
		public  Bitmap Formula { get; }

		public AbstractDistribution(Distribution.Distribution distr)
		{
			this.distr = distr;
		}

		/// <summary>
		/// Расчитывает вероятности (pi и mi)
		/// на интервалах или для значений
		/// </summary>
		/// <returns></returns>
		abstract public List<KeyValuePair<double, double>> CalcProbablities();

		/// <summary>
		/// Возвращает точетчные оценки
		/// </summary>
		/// <returns></returns>
		abstract public KeyValuePair<double, double> GetPointParams();

		/// <summary>
		/// Возвращает либо ряд частот, либо ряд относительных частот
		/// </summary>
		/// <returns></returns>
		abstract public Dictionary<double, double> StatisticsData { get; }
	}
}
