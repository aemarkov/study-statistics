using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using ZedGraph;

namespace StatisticDistribution
{
	public partial class EmpiricFunction : Form
	{

		//Показать форму
		public static void ShowEmpiricFunction(Dictionary<double, double> data)
		{
			var frm =  new EmpiricFunction(data);
			frm.Show();
		}

		//Констрктор
		public EmpiricFunction(Dictionary<double, double> data)
		{
			InitializeComponent();

			var pane = graph.GraphPane;
			pane.YAxis.Title = "F*(x)";
			pane.XAxis.Title = "x";
			pane.Title = "График эмпирической функции распределения";

			calculateEmpiricalFunction(data);
		}

		// Расчет эмпирической функции распределения
		// F(x) = W(X < x)
		// * |in|  : statFreq
		private void calculateEmpiricalFunction(Dictionary<double, double> statFreq)
		{
			double start = statFreq.First().Key;        //Начало интервала
			double F = 0;                               //Значение функции
			double prevF = 0;                           //Значенеи функции на предыдушем шаге

			var pane = graph.GraphPane;                 //Для рисования графика

			int top = lblA0.Bottom;                     //Координата низа предыдущей записи
			int step = 10;                              //Расстояние между записями
			//int width = lblA0.Height;					//Ширина всех записей

			//Первый интервал
			//(-inf; a0] => 0

			//Рисуем график
			double interval = (statFreq.ElementAt(1).Key - statFreq.ElementAt(0).Key)*3;
			Debug.WriteLine("x <= " + start + ": 0");
			pane.AddCurve("", new double[] { start - interval, start }, new double[] { 0, 0 }, Color.Red, SymbolType.None);

			//Пишем функцию
			lblA0.Text = "0, x <= " + start;

			//Серединные интервалы
			//(a0; a1] - (a1; a2] - ... - (an-1; an];
			foreach (var x in statFreq)
			{
				prevF = F;
				F += x.Value;
				
				//Схлопываем интервалы 
				if ((x.Value !=0)&&(x.Key!=start))
				{
					Debug.WriteLine("(" + start + "; " + x.Key + "]: " + prevF);

					//Рисуем график
					//p нужен для рисования кружочков
					var p = pane.AddCurve("", new double[] { start }, new double[] { prevF }, Color.Red, SymbolType.Circle);
					p.Line.IsVisible = false;
					pane.AddCurve("", new double[] { start, x.Key }, new double[] { prevF, prevF }, Color.Red, SymbolType.None);

					//Добавляем пункты в функцию
					var lbl = new Label();
					lbl.Text=prevF.ToString("G6")+", "+start+" < x <= "+x.Key;
					lbl.Left = lblA0.Left;
					lbl.Top = top + step;
					top += lbl.Height;
					
					panelFunc.Controls.Add(lbl);

					start = x.Key;
				}
			}

			//Последний интервал
			//(an; +inf) => 1
			Debug.WriteLine("x > " + statFreq.Last().Key + ": " + F);

			//Рисуем график
			var pt = pane.AddCurve("", new double[] { statFreq.Last().Key }, new double[] { 1 }, Color.Red, SymbolType.Circle);
			pt.Line.IsVisible = false;
			pane.AddCurve("", new double[] { statFreq.Last().Key, statFreq.Last().Key + interval }, new double[] { 1, 1 }, Color.Red, SymbolType.None);

			//Функция
			var label = new Label();
			label.Text = "1, x > " + statFreq.Last().Key;
			label.Left = lblA0.Left;
			label.Top = top + step;
			top += label.Height;
			panelFunc.Controls.Add(label);

			//Масштабируем скобку функции
			imgBracket.Height = top - lblA0.Top+15;

			//Масштабируем график
			graph.AxisChange();
			graph.Invalidate();
		}
	}
}
