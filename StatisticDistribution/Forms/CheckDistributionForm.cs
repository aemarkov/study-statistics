using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Statistics.DistributionCheck;
using Statistics.Distribution;

using ZedGraph;

namespace StatisticDistribution
{
	public partial class CheckDistributionForm : Form
	{
		AbstractDistribution distr;		//Распределение, для которого проверяется гипотеза

		/// <summary>
		/// Создает новый объект класса CheckDistributionForm с заданным распределением
		/// </summary>
		/// <param name="distr">Объект распределения</param>
		public CheckDistributionForm(AbstractDistribution distr)
		{
			InitializeComponent();

			//Сохраняем распределение. Отображаем его имя
			this.distr = distr;
			lblDistrType.Text = distr.Name;


			//Заголовки графиков
			graphEmp.GraphPane.Title.Text = "Полигон относительных частот";
			graphTheor.GraphPane.Title.Text = "Теоретическая функция распределения";

			//Отображает полигон относительных частот и график теоретического закона распределения
			draw_distribution(graphEmp, distr.StatisticsData);
			draw_distribution(graphTheor, distr.GetTheoreticalFreq());

			//Загружает значения уровней значимости в ComboBox
			cbAlpha.DataSource = CriticalPirsonCriterion.GetSignificanceLevel();

			//Отображаем формулу распределения
			pboxFunction.BackgroundImage = distr.Funtion;

			//Отображаем точечные оценки
			//Магия
			foreach (DataGridViewColumn col in gridPointValues.Columns)
				col.DataPropertyName = col.Name;

			var bs = new BindingSource();
			gridPointValues.RowTemplate.Height = 68;
			bs.DataSource = distr.PointValues.Select(x => new { ParamName = x.ParamName, Formula = x.Formula, Value=x.Value }).ToList();
			gridPointValues.DataSource = bs;
			gridPointValues.Columns["Value"].DefaultCellStyle.Format = "N2";


			//Настройка числа знаков после запятой для таблицы расчета
			gridCalcTable.Columns["Pi"].DefaultCellStyle.Format = "N2";
			gridCalcTable.Columns["ni"].DefaultCellStyle.Format = "N2";
			gridCalcTable.Columns["sums"].DefaultCellStyle.Format = "N2";

		}

		//Автоматический режим
		private void rbAuto_CheckedChanged(object sender, EventArgs e)
		{
			txtDegreesOfFreedom.Enabled = true;
			txtPirsonCrit.Enabled = true;
			cbAlpha.Enabled = true;
		}

		//РУчной режим
		private void rbManual_CheckedChanged(object sender, EventArgs e)
		{
			txtDegreesOfFreedom.Enabled = false;
			txtPirsonCrit.Enabled = false;
			cbAlpha.Enabled = false;

			txtDegreesOfFreedom.Text = "";
			txtPirsonCrit.Text = "";
			labelResult.Visible = false;
		}

		//Подтвердить гипотезу - дальнейшая проверка по критерию пирсона
		private void btnCorrect_Click(object sender, EventArgs e)
		{
			if (rbAuto.Checked)
				auto_check(distr);
			else
				manual_ceck(distr);
		}

		#region CALC_LOGIN
		/////////////////////////////////// РАСЧЕТЫ /////////////////////////////////////

		//Автоматическая проверка гипотезы
		//Считает критерий, степени свободы, критическое значение 
		//и сам сравнивает
		void auto_check(AbstractDistribution distr)
		{
			//Вычисляем значения
			double pirson_vis = calc_pirson(distr);
			int degrees_of_freedom = calc_degrees_of_freedom(distr);
			double pirson_crit = CriticalPirsonCriterion.GetCriticalValue((double)cbAlpha.SelectedItem, degrees_of_freedom);

			//Отображаем значения
			txtPirsonVis.Text = pirson_vis.ToString("N4");
			txtDegreesOfFreedom.Text = degrees_of_freedom.ToString();
			txtPirsonCrit.Text = pirson_crit.ToString("N4");

			//Пишемм вывод
			if(pirson_vis<pirson_crit)
			{
				labelResult.Text = "НЕ ОТВЕРГАЕМ ГИПОТЕЗУ";
				labelResult.ForeColor = Color.Green;
			}
			else
			{
				labelResult.Text = "ОТВЕРГАЕМ ГИПОТЕЗУ";
				labelResult.ForeColor = Color.Red;
			}
			labelResult.Visible = true;
		}

		//Ручная проверка
		//Только считает критерий
		void manual_ceck(AbstractDistribution distr)
		{
			txtPirsonVis.Text = calc_pirson(distr).ToString("N4");
			var frm = new PirsonTableForm();
			frm.Show();
		}

		//Расчитывает наблюдаемое значение критерия
		double calc_pirson(AbstractDistribution distr)
		{
			//Получаем значения теоретических вероятностей и частот
			var probs = distr.CalcProbablities();
			double pirson = 0;
			int n = distr.Count;

			//Очищаем таблицу
			gridCalcTable.Rows.Clear();
			
			//Расчитываем критерий пирсонаы
			foreach (var el in probs)
			{
				double slag = Math.Pow(el.Mi - n * el.Pi, 2) / (n * el.Pi);
				pirson += slag;

				//Заполняем таблицу расчетов
				var row_index = gridCalcTable.Rows.Add();
				var row = gridCalcTable.Rows[row_index];
			
				row.Cells["interval"].Value = el.XValue;
				row.Cells["Pi"].Value = el.Pi;
				row.Cells["ni"].Value = el.Mi;
				row.Cells["sums"].Value = slag;
			}

			return pirson;
		}

		//Расчитывает число степеней свободы
		int calc_degrees_of_freedom(AbstractDistribution distr)
		{
			return distr.StatisticsData.Count -   //Число элементов группированного ряда == число интервалов
				   distr.PointValues.Count -	  //число точечных значений - число элементов, которые мы оцениваем по выборке
				   1;
		}

		#endregion

		#region GRAPHICS
		///////////////////////////// ПОСТРОЙКА ГРАФИКОВ ////////////////////////////////

		//Строит график
		void draw_distribution(ZedGraphControl graph, Dictionary<double, double> distr)
		{
			setup_graph(graph);

			//Построение полигона
			var pane = graph.GraphPane;
			SymbolType type = SymbolType.Default;
			if (distr.Count > 20) type = SymbolType.None;

			var curve = pane.AddCurve("", dictionaryToList(distr), Color.FromArgb(255, 39, 174, 96),type);
			graph.AxisChange();
			graph.Invalidate();
		}

		//Преобразует словарь в набор точек
		PointPairList dictionaryToList(Dictionary<double, double> data)
		{
			var list = new PointPairList();
			foreach (var x in data) list.Add(x.Key, x.Value);
			return list;
		}

		//Настройки графика
		void setup_graph(ZedGraph.ZedGraphControl graph)
		{
			var pane = graph.GraphPane;
			pane.YAxis.Title.Text = "y";
			pane.X2Axis.Title.Text = "x";

			//Настраиваем пересечение осей
			pane.XAxis.Cross = 0.0;
			pane.YAxis.Cross = 0.0;
			pane.XAxis.Scale.IsSkipFirstLabel = true;
			pane.XAxis.Scale.IsSkipLastLabel = true;
			pane.XAxis.Scale.IsSkipCrossLabel = true;
			pane.YAxis.Scale.IsSkipFirstLabel = true;
			pane.YAxis.Scale.IsSkipLastLabel = true;
			pane.YAxis.Scale.IsSkipCrossLabel = true;

			//Убираем засечки сверху и снизу
			pane.XAxis.MinorTic.IsOpposite = false;
			pane.XAxis.MajorTic.IsOpposite = false;
			pane.YAxis.MinorTic.IsOpposite = false;
			pane.YAxis.MajorTic.IsOpposite = false;

			graph.AxisChange();
			graph.Invalidate();
		}
		#endregion
	}
}
