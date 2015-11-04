using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


using StatisticDistribution.Properties;
namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class BinomialDistribution : AbstractDistribution
	{
		private double p;							//Вероятность благоприятного исхода (точечная оценка)
		private List<PointValue> point_values;		//Список точечных оценок

		//Конструктор
		public BinomialDistribution(Distribution.Distribution distr):base(distr)
		{
			//Создаем список с точечными оценками
			point_values = new List<PointValue>
			{
				new PointValue("Математическое ожидание", Resources.binomial_p, p),
			};
		}

		#region STATISTICS_INTERFACE
		///////////////////////////// ДАННЫЕ О СТАТИСТИЧЕСКОМ РЯДЕ ////////////////////////////////////////

		//Название распределения
		public override string Name { get { return "Биномиальное распределение"; } }

		public override Bitmap Funtion{ get { return Resources.binomial_function; }}

		//Возвращает ряд частот, для построения полигона
		public override Dictionary<double, double> StatisticsData {get { return distr.StatFreq; }}

		//Возвращает список точек для построения теоретической кривой
		public override Dictionary<double, double> GetTheoreticalFreq()
		{
			throw new NotImplementedException();
			//TODO: генерация теоретического ряда распределения
		}

		//Возвращает размер исходной выборки
		public override int Count{get { return distr.Count; }}

		//Возвращает точечные оценки
		public override List<PointValue> PointValues
		{
			get
			{
				//TODO: расчет точечных оценок
				throw new NotImplementedException();
			}
		}

		#endregion

		//Расчитывает теоретические вероятности
		public override List<PirsonProbability> CalcProbablities()
		{
			//TODO: расчет вероятностей для метода пирсона
			throw new NotImplementedException();
		}
	}
}
