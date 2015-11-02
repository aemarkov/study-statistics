using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Diagnostics;
using ZedGraph;
using Statistics.Utils;

namespace StatisticDistribution
{
	public partial class EmpiricFunction : Form
	{

		// Построить на основе ряда относительных частот
		public static void ShowEmpiricFunction(Dictionary<double, double> data)
		{
			var frm =  new EmpiricFunction(data);
			frm.Show();
		}

		//Построить на основе интервального ряда относительных частот
		public static void ShowEmpiricFunction(Dictionary<Range, double> data)
		{
			var frm = new EmpiricFunction(data);
			frm.Show();
		}

		private EmpiricFunction(Dictionary<Range, double> data)
		{
			InitializeComponent();

			var newData = new Dictionary<Range, double>();
			double F = 0;
			double prevF = 0;
			foreach(var x in data)
			{
				prevF = F;
				F += x.Value;
				newData.Add(x.Key, prevF);
			}

			show(newData);
		}


		//Констрктор
		private EmpiricFunction(Dictionary<double, double> data)
		{
			InitializeComponent();
			show(calculateEmpiricalFunction(data));
		}

		//Отобрать функцию
		private void show(Dictionary<Range, double> data)
		{
			var pane = graph.GraphPane;
			pane.YAxis.Title.Text = "F*(x)";
			pane.XAxis.Title.Text = "x";
			pane.Title.Text = "График эмпирической функции распределения";

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


			int top = lblA0.Bottom;                     //Координата низа предыдущей записи
			int step = 10;                              //Расстояние между записями

			double prevF = 0;                           //Предущее значение функции, используется, чтобы не рисовать кружки
														//Если на двух отрезках одинаковые значения

			//Схема интервалов
			//(a0; a1] - (a1; a2] - ... - (an-1; an];

			//Первый интервал
			//(-inf; a1] => 0

			//Рисуем график
			double interval = data.First().Key.Length;

			//Определяем величину, чтобы она была чуть-больше 0, чтобы не сливалась с осью
			double first_val;
			if (data.Count >= 2)
				first_val = data.ElementAt(1).Value / 10;
			else if (data.First().Value != 0)
				first_val = data.First().Value / 10.0;
			else
				first_val = 0.1;

			pane.AddCurve("", new double[] { data.First().Key.Right-interval*100, data.First().Key.Right }, new double[] { first_val, first_val }, Color.Red, SymbolType.None);
			prevF = 0;

			//Пишем функцию
			lblA0.Text = "0; x <= " + data.First().Key.Right;

			//Серединные интервалы
			//(a0; a1] - (a1; a2] - ... - (an-1; an];

			bool fucking_spank = true;
			foreach (var x in data)
			{
				if (x.Value != prevF)
				{ 
					//Рисуем кружки
					var p = pane.AddCurve("", new double[] { x.Key.Left }, new double[] { x.Value }, Color.Red, SymbolType.Circle);
					p.Line.IsVisible = false;

					//Добавляем пункты в функцию
					var lbl = new System.Windows.Forms.Label();
					lbl.Text = x.Value.ToString("N4") + "; " + x.Key.Left + " < x <= " + x.Key.Right;
					lbl.Left = lblA0.Left;
					lbl.Top = top + step;
					lbl.Width=200;
					top += lbl.Height;
					panelFunc.Controls.Add(lbl);
				}

				if (!fucking_spank)
				{
					//Чтобы не рисовать первый интервал. Ведь интервал 
					//(a0;a1] входит в (-inf; a1]

					//Рисуем график
					pane.AddCurve("", new double[] { x.Key.Left, x.Key.Right }, new double[] { x.Value, x.Value }, Color.Red, SymbolType.None);
					prevF = x.Value;
				}
				fucking_spank = false;

			}

			//Последний интервал
			//(an; +inf) => 1

			//Рисуем график
			var pt = pane.AddCurve("", new double[] { data.Last().Key.Right }, new double[] { 1 }, Color.Red, SymbolType.Circle);
			pt.Line.IsVisible = false;
			pane.AddCurve("", new double[] { data.Last().Key.Right, data.Last().Key.Right + interval*100 }, new double[] { 1, 1 }, Color.Red, SymbolType.None);

			//Функция
			var label = new System.Windows.Forms.Label();
			label.Text = "1, x > " + data.Last().Key.Right;
			label.Left = lblA0.Left;
			label.Top = top + step;
			top += label.Height;
			panelFunc.Controls.Add(label);

			//Масштабируем скобку функции
			imgBracket.Height = top - lblA0.Top + 15;
			lblFX.Top = top / 2 - 9;

			//Масштабируем график

			//Вручную задаем масштаб по оси X, т.к у нас там большие "хвосты" при 0 и 1
			pane.XAxis.Scale.Min = data.First().Key.Left - interval;
			pane.XAxis.Scale.Max = data.Last().Key.Right + interval;

			graph.AxisChange();
			graph.Invalidate();
		}


		// Расчет эмпирической функции распределения
		// F(x) = W(X < x)
		// * |in|  : statFreq
		private Dictionary<Range, double> calculateEmpiricalFunction(Dictionary<double, double> statFreq)
		{
			var func = new Dictionary<Range, double>();

			double start = statFreq.First().Key;        //Начало интервала
			double F = 0;                               //Значение функции
			double prevF = 0;                           //Значенеи функции на предыдушем шаге

			//Серединные интервалы
			//(a0; a1] - (a1; a2] - ... - (an-1; an];
			foreach (var x in statFreq)
			{
				prevF = F;
				F += x.Value;
				
				//Схлопываем интервалы 
				if ((x.Value !=0)&&(x.Key!=start))
				{
					func.Add(new Range(start, x.Key), prevF);
					Debug.WriteLine("(" + start + "; " + x.Key + "]: " + prevF);
					start = x.Key;
				}
			}

			//Последний интервал
			//(an; +inf) => 1
			Debug.WriteLine("x > " + statFreq.Last().Key + ": " + F);

			return func;
		}
	}
}
