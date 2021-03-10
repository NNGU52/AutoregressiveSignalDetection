using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обнаружение_гармонического_сигнала_м.а
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] GeneratingPoints_t(int number_points)  // функция генерации точек t
        {
            double[] t = new double[number_points];
            for(int i = 0; i < number_points; i++)
            {
                t[i] = i;
            }
            return t;
        }

        double[] GeneratingPoints_signal(int number_points, double n1, double n2, double f1, double f2, double f3, double A)  // функция генерации точек signal
        {
            double Phi = 2 * Math.PI * (f2 - f1) * n1;
            double Q = 2 * Math.PI * (f1 - f3) * n2 + Phi;
            double[] y = new double[number_points];
            for (int t = 0; t < number_points ; t++)
            {
                if(t < n1)
                    y[t] = A * Math.Sin(f2 * 2 * Math.PI * t);

                if (t >= n1 && t <= n2)
                    y[t] = A * Math.Sin(f1 * 2 * Math.PI * t + Phi);

                if (t > n2)
                    y[t] = A * Math.Sin(f3 * 2 * Math.PI * t + Q);
            }
            return y;
        }

        double[] YulaWalker(double f, int number_points)    // функция генерации параметров а
        {
            double[] a = new double[2];
            double dt = 0.01;                               // частота дискритизации

            a[1] = (1 - Math.Pow(Math.Cos((2 * Math.PI * f * dt)), 2)) / (Math.Pow(Math.Cos((2 * Math.PI * f * dt)), 2) - Math.Cos(2 * 2 * Math.PI * f * dt));
            a[0] = Math.Cos(2 * Math.PI * f * dt) * (-1 * a[1] - 1);

            return a;
        }

        double[] DeviationGraph(double[] a, double[] signal)                            // функция генерации точек отклонения
        {
            double[] deviation = new double[signal.Length];
            double signal_prediction = 0;
            for (int n = 2; n < deviation.Length; n++)
            {
                signal_prediction = -1 * a[0] * signal[n - 1] - a[1] * signal[n - 2];   // генерация точек предсказания
                deviation[n] = Math.Pow((signal[n] - signal_prediction), 2);
            }

            return deviation;
        }

        double[] Smooth(double[] input, int window)     // функция генерации точек сглаживания
        {
            if (window % 2 == 0)                        // проверка: размер окна четный или нет
                window += 1;

            int hw = (window - 1) / 2;                  // размах окна влево и вправо от текущей позиции
            int n = input.Length;
            double[] result = new double[n];

            for (int i = 0; i < n; i++)                 // организуем цкл по числу элементов
            {
                double init_sum = 0;
                int k1, k2, z;

                if (i <= hw)                            // если индекс меньше половины, мы находимся в начале массива
                {
                    k1 = 1;                             // в качестве начала окна мы берем первый элемент
                    k2 = window;                        // конец окна
                    z = window;                         // текущий размер окна
                }
                else
                {
                    if (i + hw > n)                     // если индекс + половина окна больше n, мы приближаемся к концу массива и размер окна также нужно уменьшать
                    {
                        result[i] = result[i - 1];
                        continue;
                    }
                    else                                // иначе мы в середине массива
                    {
                        k1 = i - hw;
                        k2 = i + hw;
                        z = window;
                    }
                }

                for (int j = k1; j < k2; j++)           // организуем цикл от начала до конца окна
                    init_sum += input[j];               // складываем все элементы

                result[i] = init_sum / z;               // и делим на текущий размер окна
            }

            return result;
        }

        double[] DetectSignal(double[] E_error, double[] smooth)  // функция нахождения начала и конца искомого эталонного сигнала  
        {
            double[] b = new double[E_error.Length];
            double[] detect = new double[2];
            double max = b[0];
            double min = b[0];
            for (int i = 0; i < E_error.Length; i++)
            {
                if (smooth[i] <= E_error[i])
                    b[i] = i;       
            }
            for (int j = 0; j < b.Length; j++)
            {
                if (max < b[j]) max = b[j];
                if ((min > b[j] && b[j] != 0) || min == 0) min = b[j];
            }
            detect[0] = min;
            detect[1] = max;

            return detect;
        }

        double [] GenerateNoise(double[] signal, double energy, bool b)  // функция генерации шума
        {
            Random rnd = new Random();
            int length = signal.Length;
            double[] noise = new double[length];                        // Массив случайных чисел.
            double Er = 0;

            for (int i = 0; i < length; i++)
            {
                for (int n = 0; n < 12; n++)
                {
                    noise[i] += Convert.ToDouble(rnd.Next(-100, 101)) / 100;
                }
                noise[i] /= 12;
                Er += noise[i] * noise[i];
            }

            double Es = 0;
           
            for (int i = 0; i < signal.Length; i++)
            {
                Es += Math.Pow(signal[i], 2);
            }
            double Enoise = Es * energy / 100; 

            for (int i = 0; i < length; i++)
            {
                if (b)
                    noise[i] = noise[i] * Math.Sqrt(Enoise / Er);
                else
                    noise[i] = 0;
            }

            return noise;
        }

        void DrawSignal(double[] t, double[] y)                 // функция рисования точек сигнала
        {
            chart1.Series[0].Points.DataBindXY(t, y);
        }

        void DrawDeviationGraph(double[] t, double[] deviation)  // функция рисования точек отклонения
        {
            chart2.Series[0].Points.DataBindXY(t, deviation);
        }

        void DrawStepError(double[] t, double[] E)              // функция рисования порога
        {
            chart2.Series[1].Points.DataBindXY(t, E);
        }

        void DrawSmooth(double[] t, double[] smooth)            // функция рисования точек сглаживания
        {
            chart2.Series[2].Points.DataBindXY(t, smooth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значений с интерфейса
            int n1 = Convert.ToInt32(numericUpDown_n1.Text);
            int n2 = Convert.ToInt32(numericUpDown_n2.Text);
            double f1 = Convert.ToDouble(numericUpDown_f1.Text);
            double f2 = Convert.ToDouble(numericUpDown_f2.Text);
            double f3 = Convert.ToDouble(numericUpDown_f3.Text);
            double E = Convert.ToDouble(numericUpDown_error.Text);
            int window = Convert.ToInt32(numericUpDown_points.Text);
            double A = 1;
            int number_points = n1 + n2;
            int MinT = 0;

            // Массив точек y
            double[] signal = GeneratingPoints_signal(number_points, n1, n2, f1, f2, f3, A);

            double[] noise = GenerateNoise(signal, Convert.ToDouble(numericUpDown_energy.Text), checkBox1.Checked);

            double[] sum = new double[number_points];
            for (int i = 0; i < number_points; i++)
            {
                sum[i] = noise[i] + signal[i];
            }
            
            // Массив точек t
            double[] t = GeneratingPoints_t(number_points);

            // Вызов функции рисования сигнала
            DrawSignal(t, sum);
            
            // Массив параметров для гармонического сигнала заданной частоты f1
            double[] a = YulaWalker(f1, number_points);

            // Массив точек - предсказанных отсчетов
            double[] prediction = DeviationGraph(a, sum);

            // Вызов функции рисования графика отклонения
            DrawDeviationGraph(t, prediction);

            // Массив точек, равных значению уровня ошибки
            double[] E_error = new double[number_points];
            for (int i = 0; i < E_error.Length; i++)
            {
                E_error[i] = E;
            }

            // Вызов функции рисования порога ошибки
            DrawStepError(t, E_error);

            double[] smooth = Smooth(prediction, window);

            DrawSmooth(t, smooth);

            // Установка начальных значений графиков
            chart1.ChartAreas[0].AxisX.Minimum = MinT;
            chart2.ChartAreas[0].AxisX.Minimum = MinT;

            double[] detect = DetectSignal(E_error, smooth);

            // Вывод начала и конца искомого эталонного сигнала
            textBox_n1.Text = Convert.ToString(detect[0]);
            textBox_n2.Text = Convert.ToString(detect[1]);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
