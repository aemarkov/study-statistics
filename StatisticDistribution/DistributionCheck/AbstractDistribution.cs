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
		//public  Bitmap Formula { get {return Re }

		public AbstractDistribution(Distribution.Distribution distr)
		{
			this.distr = distr;
		}

		/// <summary>
		/// Расчитывает вероятности (pi и mi)
		/// на интервалах или для значений
		/// </summary>
		/// <returns></returns>
		abstract public List<PirsonProbability> CalcProbablities();

		/// <summary>
		/// Возвращает список точек для построения теоретической кривой
		/// </summary>
		/// <returns></returns>
		abstract public Dictionary<double, double> GetTheoreticalFreq();

		/// <summary>
		/// Точечные оценки
		/// </summary>
		abstract public List<PointValue> PointValues { get; }

		/// <summary>
		/// Возвращает группированный ряд относительных частот
		/// </summary>
		/// <returns></returns>
		abstract public Dictionary<double, double> StatisticsData { get; }

		/// <summary>
		/// Возвращает размер исходной выборки
		/// </summary>
        abstract public int Count { get; }
	}
}
