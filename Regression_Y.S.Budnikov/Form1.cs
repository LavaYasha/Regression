using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regression_Y.S.Budnikov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string FName = openFileDialog1.FileName;

            X_tb.Text = "";
            Y_tb.Text = "";

            int LengthF = System.IO.File.ReadAllLines(FName).Length;

            for (int i = 0; i < LengthF - 1; i++)
            {
                string temp = System.IO.File.ReadLines(FName).Skip(i).FirstOrDefault();
                temp = temp.Replace('.', ',');
                string[] temp1 = temp.Split(new char[] { ' ' });
                X_tb.Text += temp1[0] + ' ';
                Y_tb.Text += temp1[1] + ' ';
            }
            checkedListBox1.SetItemChecked(0, true);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void funcButton_Click(object sender, EventArgs e)
        {
            if (X_tb.Text.Length != 0 && Y_tb.Text.Length != 0)
            {
                checkedListBox1.SetItemChecked(0, true);
            }
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                checkedListBox1.SetItemChecked(1, true);
            }
            else
            {
                MessageBox.Show("Не выбран файл или не введены точки для проверки", "Info", MessageBoxButtons.OK);
                return;
            }
            checkedListBox1.SetItemChecked(2, false);
            sol.Clear();
            ClearGraph();
            double[] x = TextBoxToDouble(X_tb);
            double[] y = TextBoxToDouble(Y_tb);
            Sort(x, y);
            DrawingLine(x, y, 0);
            string temp = (sender as Button).Name;
            switch (temp)
            {
                case "Line_b":
                    {
                        double sumX = 0, sumY = 0, sumX2 = 0, sumY2 = 0, sumYX = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            sumX += x[i];
                            sumY += y[i];
                            sumX2 += x[i] * x[i];
                            sumY2 += y[i] * y[i];
                            sumYX += y[i] * x[i];
                        }
                        double a = (sumX * sumY - x.Length * sumYX) / (Math.Pow(sumX,2) - x.Length * sumX2);
                        double b = (sumX * sumYX - sumX2 * sumY) / (Math.Pow(sumX, 2) - x.Length * sumX2);
                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a * x[i] + b;
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(tempX, F_y, 1);
                        sol.Text 
                            += "сумма X = " + sumX + '\n'
                            + "сумма Y = " + sumY + '\n'
                            + "сумма квадратов X = " + sumX2 + '\n'
                            + "сумма квадратов Y = " + sumY2 + '\n'
                            + "сумма Y * X = " + sumYX + '\n'
                            + "a = " + a + '\n'
                            + "b = " + b;
                    }
                    break;
                case "Degree_b":
                    {
                        double Sum_LnX = 0, Sum_Ln2_X = 0, Sum_LnY = 0, Sum_LnX_LnY = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            Sum_LnX = Sum_LnX + Math.Log(x[i]);
                            Sum_Ln2_X = Sum_Ln2_X + Math.Log(x[i]) * Math.Log(x[i]);
                            Sum_LnY = Sum_LnY + Math.Log(y[i]);
                            Sum_LnX_LnY = Sum_LnX_LnY + Math.Log(x[i]) * Math.Log(y[i]);
                        }


                        double b = (x.Length * Sum_LnX_LnY - Sum_LnX * Sum_LnY)
                                 / (x.Length * Sum_Ln2_X - Sum_LnX * Sum_LnX);
                        double a = Math.Exp(1.0 / x.Length * Sum_LnY - b / x.Length * Sum_LnX);

                        

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a * Math.Pow(x[i], b);
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(tempX, F_y, 1);

                        sol.Text
                            += "сумма ln(x) = " + Sum_LnX + '\n'
                            + "сумма ln^2(x) = " + Sum_Ln2_X + '\n'
                            + "сумма ln(y) = " + Sum_LnY + '\n'
                            + "сумма ln(x) * ln(y) = " + Sum_LnX_LnY + '\n'
                            + "a = " + a + '\n'
                            + "b = " + b;
                    }
                    break;
                case "Cube_b":
                    {
                        double SumX = 0, SumX2 = 0,SumX3 = 0, SumX4 = 0, SumX5 = 0,SumX6 = 0, SumY = 0,SumXY = 0, SumX2_Y = 0, SumX3_Y = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            SumX = SumX + x[i];
                            SumX2 = SumX2 + Math.Pow(x[i], 2);
                            SumX3 = SumX3 + Math.Pow(x[i], 3);
                            SumX4 = SumX4 + Math.Pow(x[i], 4);
                            SumX5 = SumX5 + Math.Pow(x[i], 5);
                            SumX6 = SumX6 + Math.Pow(x[i], 6);
                            SumY = SumY + y[i];
                            SumXY = SumXY + x[i] * y[i];
                            SumX2_Y = SumX2_Y + Math.Pow(x[i], 2) * y[i];
                            SumX3_Y = SumX3_Y + Math.Pow(x[i], 3) * y[i];
                        }
                        

                        double z11 = SumX3, z12 = SumX2,z13 = SumX,  z14 = x.Length, d1 = SumY, z21 = SumX4,z22 = SumX3, z23 = SumX2, z24 = SumX;          
                        double d2 = SumXY,z31 = SumX5,z32 = SumX4,z33 = SumX3,z34 = SumX2,d3 = SumX2_Y,z41 = SumX6, z42 = SumX5, z43 = SumX4, z44 = SumX3,  d4 = SumX3_Y;
                        //Вычислим определитель матрицы 4х4
                        double opredelitel = z11 * z22 * z33 * z44 + z12 * z23 * z34 * z41 + z13 * z24 * z31 * z42 + z14 * z21 * z32 * z43
                                           - z14 * z23 * z32 * z41 - z13 * z22 * z31 * z44 - z12 * z21 * z34 * z43 - z11 * z24 * z33 * z42;
                        //меняем столбец z11,z21,z31,z41 на d1,d2,d3,d4
                        double a = (d1 * z22 * z33 * z44 + z12 * z23 * z34 * d4 + z13 * z24 * d3 * z42 + z14 * d2 * z32 * z43
                                 - z14 * z23 * z32 * d4 - z13 * z22 * d3 * z44 - z12 * d2 * z34 * z43 - d1 * z24 * z33 * z42) / opredelitel;
                        //меняем столбец z12,z22,z32,z42 на d1,d2,d3,d4
                        double b = (z11 * d2 * z33 * z44 + d1 * z23 * z34 * z41 + z13 * z24 * z31 * d4 + z14 * z21 * d3 * z43
                                  - z14 * z23 * d3 * z41 - z13 * d2 * z31 * z44 - d1 * z21 * z34 * z43 - z11 * z24 * z33 * d4) / opredelitel;
                        //меняем столбец z13,z23,z33,z43 на d1,d2,d3,d4
                        double c = (z11 * z22 * d3 * z44 + z12 * d2 * z34 * z41 + d1 * z24 * z31 * z42 + z14 * z21 * z32 * d4
                                   - z14 * d2 * z32 * z41 - d1 * z22 * z31 * z44 - z12 * z21 * z34 * d4 - z11 * z24 * d3 * z42) / opredelitel;
                        //меняем столбец z14,z24,z34,z44 на d1,d2,d3,d4
                        double d = (z11 * z22 * z33 * d4 + z12 * z23 * d3 * z41 + z13 * d2 * z31 * z42 + d1 * z21 * z32 * z43
                                   - d1 * z23 * z32 * z41 - z13 * z22 * z31 * d4 - z12 * z21 * d3 * z43 - z11 * d2 * z33 * z42) / opredelitel;

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a * Math.Pow(x[i], 3) + b * Math.Pow(x[i], 2) + c * x[i] + d;
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(tempX, F_y, 1);

                        sol.Text
                            += "сумма X = " + SumX + '\n'
                            + "сумма X^2 = " + SumX2 + '\n'
                            + "сумма X^3 = " + SumX3 + '\n'
                            + "сумма X^4 = " + SumX4 + '\n'
                            + "сумма X^5 = " + SumX5 + '\n'
                            + "сумма X^6 = " + SumX6 + '\n'
                            + "сумма Y = " + SumY + '\n'
                            + "сумма Y * X = " + SumXY + '\n'
                            + "сумма Y * X^2 = " + SumX2_Y + '\n'
                            + "сумма Y * X^3 = " + SumX3_Y + '\n'
                            + "a = " + a + '\n'
                            + "b = " + b + '\n'
                            + "d = " + d + '\n'
                            + "c = " + c;
                    }
                    break;
                case "Square_b":
                    {
                        double SumX = 0, SumX2 = 0, SumX3 = 0, SumX4 = 0, SumY = 0, SumXY = 0, SumX2_Y = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            SumX += x[i];
                            SumX2 += Math.Pow(x[i], 2);
                            SumX3 += Math.Pow(x[i], 3);
                            SumX4 += Math.Pow(x[i], 4);
                            SumY += y[i];
                            SumXY += x[i] * y[i];
                            SumX2_Y += Math.Pow(x[i], 2) * y[i];
                        }

                        /*решение системы уравнений методом крамера*/
                        double z11 = SumX2, z12 = SumX, z13 = x.Length, d1 = SumY, z21 = SumX3,z22 = SumX2, z23 = SumX, d2 = SumXY, z31 = SumX4, z32 = SumX3, z33 = SumX2, d3 = SumX2_Y;
                        //вычислим определитель матрицы 3х3
                        double opredelitel = z11 * z22 * z33 + z12 * z23 * z31 + z13 * z21 * z32 - (z13 * z22 * z31 + z12 * z21 * z33 + z11 * z23 * z32);
                        //меняем столбец z11,z21,z31 на d1,d2,d3
                        double a = (d1 * z22 * z33 + z12 * z23 * d3 + z13 * d2 * z32 - z13 * z22 * d3 - z12 * d2 * z33 - d1 * z23 * z32) / opredelitel;
                        //меняем столбец z12,z22,z32 на d1,d2,d3
                        double b = (z11 * d2 * z33 + d1 * z23 * z31 + z13 * z21 * d3 - z13 * d2 * z31 - d1 * z21 * z33 - z11 * z23 * d3) / opredelitel;
                        //меняем столбец z13,z23,z33 на d1,d2,d3
                        double c = (z11 * z22 * d3 + z12 * d2 * z31 + d1 * z21 * z32 - d1 * z22 * z31 - z12 * z21 * d3 - z11 * d2 * z32) / opredelitel;

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a * Math.Pow(x[i], 2) + b * x[i] + c;
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(tempX, F_y, 1);

                        sol.Text
                            += "сумма X = " + SumX + '\n'
                            + "сумма X^2 = " + SumX2 + '\n'
                            + "сумма X^3 = " + SumX3 + '\n'
                            + "сумма X^4 = " + SumX4 + '\n'
                            + "сумма Y = " + SumY + '\n'
                            + "сумма Y * X = " + SumXY + '\n'
                            + "сумма Y * X^2 = " + SumX2_Y + '\n'
                            + "a = " + a + '\n'
                            + "b = " + b + '\n'
                            + "c = " + c;
                    }
                    break;
                case "Indicative_b":
                    {
                        double SumX = 0, SumY = 0,SumX2 = 0, Sum_LnY = 0, Sum_X_Lny = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            SumX += x[i];
                            SumY += y[i];
                            SumX2 += Math.Pow(x[i], 2);
                            Sum_LnY += Math.Log(y[i]);
                            Sum_X_Lny += x[i] * Math.Log(y[i]);
                        }

                        double b = Math.Exp((x.Length * Sum_X_Lny - SumX * Sum_LnY) / (x.Length * SumX2 - SumX * SumX));
                        double a = Math.Exp((1.0 / x.Length * Sum_LnY) - (Math.Log(b) / x.Length) * SumX);

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a * Math.Pow(b, x[i]);
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(tempX, F_y, 1);

                        sol.Text
                           += "сумма X = " + SumX + '\n'
                           + "сумма Y = " + SumY + '\n'
                           + "сумма квадратов X = " + SumX2 + '\n'
                           + "сумма ln(y) = " + Sum_LnY + '\n'
                           + "сумма ln(y) * X = " + Sum_X_Lny + '\n'
                           + "a = " + a + '\n'
                           + "b = " + b;
                    }
                    break;
                case "Log_b":
                    {
                        double SumX = 0, SumY = 0, Sum_LnX = 0,Sum_Ln2_X = 0, Sum_Y_LnX = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            SumX += x[i];
                            SumY += y[i];
                            Sum_LnX += Math.Log(x[i]);
                            Sum_Ln2_X += Math.Log(x[i]) * Math.Log(x[i]);
                            Sum_Y_LnX += y[i] * Math.Log(x[i]);
                        }

                        double b = (x.Length * Sum_Y_LnX - Sum_LnX * SumY) / (x.Length * Sum_Ln2_X - Sum_LnX * Sum_LnX);
                        double a = (1.0 / x.Length * SumY) - (b / x.Length * Sum_LnX);

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a + b * Math.Log(x[i]);
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(x, F_y, 1);

                        sol.Text
                           += "сумма X = " + SumX + '\n'
                           + "сумма Y = " + SumY + '\n'
                           + "сумма ln(x) = " + Sum_LnX + '\n'
                           + "сумма ln^2(y) = " + Sum_Ln2_X + '\n'
                           + "сумма ln(x) * Y = " + Sum_Y_LnX + '\n'
                           + "a = " + a + '\n'
                           + "b = " + b;
                    }
                    break;
                case "Hyperbola_b":
                    {
                        double SumX = 0, SumY = 0, Sum_REVERSE_X = 0,Sum_REVERSE_X2 = 0, SUM_Y_DIVBY_X = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            SumX += x[i];
                            SumY += y[i];
                            Sum_REVERSE_X += 1.0 / x[i];
                            Sum_REVERSE_X2 += 1.0 / Math.Pow(x[i],2);
                            SUM_Y_DIVBY_X += y[i] / x[i];
                        }

                        double b = (x.Length * SUM_Y_DIVBY_X - Sum_REVERSE_X * SumY)
                                 / (x.Length * Sum_REVERSE_X2 - Sum_REVERSE_X * Sum_REVERSE_X);
                        double a = 1.0 / x.Length * SumY - b / x.Length * Sum_REVERSE_X;

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = a + b / x[i];
                        }
                        Sort(x, F_y);
                        DrawingLine(x, F_y, 1);

                        sol.Text
                           += "сумма X = " + SumX + '\n'
                           + "сумма Y = " + SumY + '\n'
                           + "сумма 1/x = " + Sum_REVERSE_X + '\n'
                           + "сумма 1/x^2 = " + Sum_REVERSE_X2 + '\n'
                           + "сумма y/x = " + SUM_Y_DIVBY_X + '\n'
                           + "a = " + a + '\n'
                           + "b = " + b;
                    }
                    break;
                case "Exp_b":
                    {
                        double SumX = 0, SumY = 0, SumX2 = 0, Sum_LnY = 0, Sum_X_LnY = 0;
                        for (int i = 0; i < x.Length; i++)
                        {
                            SumX += x[i];
                            SumY += y[i];
                            SumX2 += x[i] * x[i];
                            Sum_LnY += Math.Log(y[i]);
                            Sum_X_LnY += x[i] * Math.Log(y[i]);
                        }

                        double b = (x.Length * Sum_X_LnY - SumX * Sum_LnY) / (x.Length * SumX2 - SumX * SumX);
                        double a = (1.0 / x.Length * Sum_LnY) - (b / x.Length * SumX);

                        double[] F_y = new double[y.Length];
                        for (int i = 0; i < x.Length; i++)
                        {
                            F_y[i] = Math.Exp(a + x[i] * b);
                        }
                        double[] tempX = x;
                        Sort(x, F_y);
                        DrawingLine(x, F_y, 1);

                        sol.Text
                           += "сумма X = " + SumX + '\n'
                           + "сумма Y = " + SumY + '\n'
                           + "сумма X^2 = " + SumX2 + '\n'
                           + "сумма ln(y) = " + Sum_LnY + '\n'
                           + "сумма x * ln(y) = " + Sum_X_LnY + '\n'
                           + "a = " + a + '\n'
                           + "b = " + b;
                    }
                    break;
            }
           
        }

        private void DrawingLine(double[] x, double[] y, int PointOrLine)
        {
            for (int i = 0; i < x.Length; i++) {
                Graph.Series[PointOrLine].Points.AddXY(x[i], y[i]);
            }
        }

        private double[] TextBoxToDouble(TextBox o)
        {
            string[] temp = o.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] tempDouble = new double[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                tempDouble[i] = Convert.ToDouble(temp[i]);
            }
            return tempDouble;
        }

        private void X_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c == '.')
            {
                e.KeyChar = ',';
            }
            if (!(c >= '0' && c <= '9' || c == '-' || c == '\b' || c == ' ' || c == ',' || c == '.'))
            {
                e.Handled = true;
            }
        }

        private void Y_tb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ClearGraph()
        {
            Graph.Series.Clear();
            Graph.Series.Add("Точки");
            Graph.Series.Add("График");
            Graph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            Graph.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            Graph.Series[0].Color = Color.DarkBlue;
            Graph.Series[1].Color = Color.DarkCyan;
        }

        private void Sort(double[] arrX, double[] arrY)
        {
            double temp;
            for (int i = 0; i < arrX.Length; i++)
            {
                for (int j = i + 1; j < arrX.Length; j++)
                {
                    if (arrX[i] > arrX[j])
                    {
                        temp = arrX[i];
                        arrX[i] = arrX[j];
                        arrX[j] = temp;

                        temp = arrY[i];
                        arrY[i] = arrY[j];
                        arrY[j] = temp;
                    }
                }
            }
        }

        private void Check_b_Click(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(2, true);
        }

        private void спарвкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа составлена студентом группы ТВБО-02-16 Будниковым Яковом Сергеевичем", "ПОЛЕЗНАЯ ИНФОРМАЦИЯ", MessageBoxButtons.YesNo);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
