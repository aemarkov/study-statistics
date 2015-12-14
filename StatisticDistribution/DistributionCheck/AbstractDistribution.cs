using System.Collections.Generic;
using System.Drawing;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Тип распределения
	/// </summary>
	public enum DistributionType { DISCRETE, CONTINUOUS };


	/// <summary>
	/// Интерфейс для классов, предоставляющийх необходимые
	/// методы и данные для проверки гипотезы.
	/// Класс, описывающий распределение обладает следующим:
	/// - название распределения
	/// - формула распределения (ИЗОБРАЖЕНИЕ)
	/// - Исходные статистические данные
	/// - Размер исходной выборки
	/// - Точечные оценки
	/// - Функция генерации теоретического графика распределения (используются точечные оценки)
	/// - Фукнция расчета вероятностей для метода пирсона
	/// </summary>
	public abstract class AbstractDistribution
	{

		protected Distribution.Distribution distr;

		public AbstractDistribution(Distribution.Distribution distr)
		{
			this.distr = distr;
		}

		/// <summary>
		/// Тип распределения - непрерывное или дискретное
		/// </summary>
		abstract public DistributionType DistributionType { get; }

		/// <summary>
		/// Название закона распределения
		/// </summary>
		abstract public string Name { get; }

		/// <summary>
		/// Картинка с формулой закона распределения
		/// </summary>
		public abstract Bitmap Funtion { get; }

		/// <summary>
		/// Возвращает группированный ряд относительных частот (или простой ряд относительных частот)
		/// </summary>
		/// <returns></returns>
		public Distribution.Distribution Distribution { get { return distr; } }

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
		/// Возвращает размер исходной выборки
		/// </summary>
        public int Count { get { return distr.Count; } }

		/// <summary>
		/// Расчитывает вероятности (pi и mi)
		/// на интервалах или для значений
		/// </summary>
		/// <returns></returns>
		abstract public List<PirsonProbability> CalcProbablities();
	}
}
