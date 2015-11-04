using System.Collections.Generic;
using System.Drawing;

namespace Statistics.DistributionCheck
{
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
		/// Название закона распределения
		/// </summary>
		abstract public string Name { get; }

		/// <summary>
		/// Картинка с формулой закона распределения
		/// </summary>
		public virtual Bitmap Funtion { get; }

		/// <summary>
		/// Возвращает группированный ряд относительных частот (или простой ряд относительных частот)
		/// </summary>
		/// <returns></returns>
		abstract public Dictionary<double, double> StatisticsData { get; }

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
        abstract public int Count { get; }

		/// <summary>
		/// Расчитывает вероятности (pi и mi)
		/// на интервалах или для значений
		/// </summary>
		/// <returns></returns>
		abstract public List<PirsonProbability> CalcProbablities();
	}
}
