using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estatistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnC.Enabled = numericUpDown2.Enabled = numericUpDown6.Enabled = numericUpDown3.Enabled = numericUpDown4.Enabled = numericUpDown5.Enabled = numericUpDown7.Enabled = false;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "1")
            {
                numericUpDown7.Enabled = btnC.Enabled = true;
            }
            if (textBox1.Text == "2")
            {
                numericUpDown7.Enabled = btnC.Enabled = numericUpDown6.Enabled = true;
            }
            if (textBox1.Text == "3")
            {
                numericUpDown7.Enabled = btnC.Enabled = numericUpDown6.Enabled = numericUpDown5.Enabled = true;
            }
            if (textBox1.Text == "4")
            {
                numericUpDown7.Enabled = btnC.Enabled = numericUpDown6.Enabled = numericUpDown5.Enabled = numericUpDown4.Enabled = true;
            }
            if (textBox1.Text == "5")
            {
                numericUpDown7.Enabled = btnC.Enabled = numericUpDown6.Enabled = numericUpDown5.Enabled = numericUpDown4.Enabled = numericUpDown3.Enabled = true;
            }
            if (textBox1.Text == "6")
            {
                numericUpDown7.Enabled = btnC.Enabled = numericUpDown6.Enabled = numericUpDown5.Enabled = numericUpDown4.Enabled = numericUpDown3.Enabled = numericUpDown2.Enabled = true;
            }
            button1.Enabled = textBox1.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(numericUpDown7.Value);
            int i2 = Convert.ToInt32(numericUpDown6.Value);
            int i3 = Convert.ToInt32(numericUpDown5.Value);
            int i4 = Convert.ToInt32(numericUpDown4.Value);
            int i5 = Convert.ToInt32(numericUpDown3.Value);
            int i6 = Convert.ToInt32(numericUpDown2.Value);
            int N = Convert.ToInt32(textBox1.Text);
            /*>>>>>>>>>>>>>>>>>>>media<<<<<<<<<<<<<<<<<<<<*/
            var media = i + i2 + i3 + i4 + i5 + i6;
            double media2 = Convert.ToDouble(media) / Convert.ToDouble(N);

            richTextBox1.AppendText("Média = " + media2 + ".\n");
            /*>>>>>>>>>>>>>>>>>>>media<<<<<<<<<<<<<<<<<<<<*/
            /*>>>>>>>>>>>>>>>>>>>mediana<<<<<<<<<<<<<<<<<<<<*/

            if (textBox1.Text == "1")
            {
                int[] arr = new int[] { i };
                Array.Sort(arr);
                Array.Reverse(arr);
                richTextBox1.AppendText("Mediana:" + Convert.ToString(i) + $"\n");
            }
            if (textBox1.Text == "2")
            {
                int[] arr = new int[] { i, i2 };
                Array.Sort(arr);
                Array.Reverse(arr);
                richTextBox1.AppendText("Mediana:" + Convert.ToString((i + i2) / 2) + $"\n");
            }
            if (textBox1.Text == "3")
            {
                int[] arr = new int[] { i, i2, i3 };
                Array.Sort(arr);
                Array.Reverse(arr);
                richTextBox1.AppendText("Mediana:" + Convert.ToString(arr[1]) + $"\n");
            }
            if (textBox1.Text == "4")
            {
                int[] arr = new int[] { i, i2, i3, i4 };
                Array.Sort(arr);
                Array.Reverse(arr);
                richTextBox1.AppendText("Mediana:" + Convert.ToString((arr[1] + arr[2]) / 2) + $"\n");
            }
            if (textBox1.Text == "5")
            {
                int[] arr = new int[] { i, i2, i3, i4, i5 };
                Array.Sort(arr);
                Array.Reverse(arr);
                richTextBox1.AppendText("Mediana:" + Convert.ToString(arr[2]) + $"\n");
            }
            if (textBox1.Text == "6")
            {
                int[] arr = new int[] { i, i2, i3, i4, i5, i6 };
                Array.Sort(arr);
                Array.Reverse(arr);
                richTextBox1.AppendText("Mediana:" + Convert.ToString((arr[2] + arr[3]) / 2) + $"\n");
            }
            /*>>>>>>>>>>>>>>>>>>>mediana<<<<<<<<<<<<<<<<<<<<*/

            /*>>>>>>>>>>>>>>>>>>>variância amostral / desvio padrão / coe variação/ conjunto<<<<<<<<<<<<<<<<<<<<*/

            if (textBox1.Text == "1")
            {
                double v = 0;
                double[] arr2 = new double[] { i, i2 };
                v = (((arr2[N - 1] - media2) * (arr2[N - 1] - media2))) / (N - 1);
                richTextBox1.AppendText("Variância Amostral:" + Convert.ToString(v) + $"\n");
                double desvio = 0;
                desvio = Math.Sqrt(v);
                richTextBox1.AppendText("Desvio Padrão:" + Convert.ToString(desvio) + "\n");
                double cv = 0;
                cv = 100 * (desvio / media2);
                richTextBox1.AppendText("Coeficiente de Variação:" + Convert.ToString(String.Format("{0:0.000}", cv) + "%"));
                if (cv <= 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Homogêneo");
                }
                if (cv > 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Heterogêneo");
                }
            }
            if (textBox1.Text == "2")
            {
                double v = 0;
                double[] arr2 = new double[] { i, i2 };
                v = (((arr2[N - 1] - media2) * (arr2[N - 1] - media2)) + ((arr2[N - 2] - media2) * (arr2[N - 2] - media2))) / (N - 1);
                richTextBox1.AppendText("Variância Amostral:" + Convert.ToString(v) + $"\n");
                double desvio = 0;
                desvio = Math.Sqrt(v);
                richTextBox1.AppendText("Desvio Padrão:" + Convert.ToString(desvio) + "\n");
                double cv = 0;
                cv = 100 * (desvio / media2);
                richTextBox1.AppendText("Coeficiente de Variação:" + Convert.ToString(String.Format("{0:0.000}", cv) + "%"));
                if (cv <= 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Homogêneo");
                }
                if (cv > 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Heterogêneo");
                }
            }
            if (textBox1.Text == "3")
            {
                double v = 0;
                double[] arr2 = new double[] { i, i2, i3 };
                v = (((arr2[N - 1] - media2) * (arr2[N - 1] - media2)) + ((arr2[N - 2] - media2) * (arr2[N - 2] - media2)) + ((arr2[N - 3] - media2) * (arr2[N - 3] - media2))) / (N - 1);
                richTextBox1.AppendText("Variância Amostral:" + Convert.ToString(v) + $"\n");
                double desvio = 0;
                desvio = Math.Sqrt(v);
                richTextBox1.AppendText("Desvio Padrão:" + Convert.ToString(desvio) + "\n");
                double cv = 0;
                cv = 100 * (desvio / media2);
                richTextBox1.AppendText("Coeficiente de Variação:" + Convert.ToString(String.Format("{0:0.000}", cv) + "%"));
                if (cv <= 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Homogêneo");
                }
                if (cv > 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Heterogêneo");
                }
            }
            if (textBox1.Text == "4")
            {
                double v = 0;
                double[] arr2 = new double[] { i, i2, i3, i4 };
                v = (((arr2[N - 1] - media2) * (arr2[N - 1] - media2)) + ((arr2[N - 2] - media2) * (arr2[N - 2] - media2)) + ((arr2[N - 3] - media2) * (arr2[N - 3] - media2)) + ((arr2[N - 4] - media2) * (arr2[N - 4] - media2))) / (N - 1);
                richTextBox1.AppendText("Variância Amostral:" + Convert.ToString(v) + $"\n");
                double desvio = 0;
                desvio = Math.Sqrt(v);
                richTextBox1.AppendText("Desvio Padrão:" + Convert.ToString(desvio) + "\n");
                double cv = 0;
                cv = 100 * (desvio / media2);
                richTextBox1.AppendText("Coeficiente de Variação:" + Convert.ToString(String.Format("{0:0.000}", cv) + "%"));
                if (cv <= 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Homogêneo");
                }
                if (cv > 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Heterogêneo");
                }
            }
            if (textBox1.Text == "5")
            {
                double v = 0;
                double[] arr2 = new double[] { i, i2, i3, i4, i5 };
                v = (((arr2[N - 1] - media2) * (arr2[N - 1] - media2)) + ((arr2[N - 2] - media2) * (arr2[N - 2] - media2)) + ((arr2[N - 3] - media2) * (arr2[N - 3] - media2)) + ((arr2[N - 4] - media2) * (arr2[N - 4] - media2)) + ((arr2[N - 5] - media2) * (arr2[N - 5] - media2))) / (N - 1);
                richTextBox1.AppendText("Variância Amostral:" + Convert.ToString(v) + $"\n");
                double desvio = 0;
                desvio = Math.Sqrt(v);
                richTextBox1.AppendText("Desvio Padrão:" + Convert.ToString(desvio) + "\n");
                double cv = 0;
                cv = 100 * (desvio / media2);
                richTextBox1.AppendText("Coeficiente de Variação:" + Convert.ToString(String.Format("{0:0.000}", cv) + "%"));
                if (cv <= 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Homogêneo");
                }
                if (cv > 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Heterogêneo");
                }
            }
            if (textBox1.Text == "6")
            {
                double v = 0;
                double[] arr2 = new double[] { i, i2, i3, i4, i5, i6 };
                v = (((arr2[N - 1] - media2) * (arr2[N - 1] - media2)) + ((arr2[N - 2] - media2) * (arr2[N - 2] - media2)) + ((arr2[N - 3] - media2) * (arr2[N - 3] - media2)) + ((arr2[N - 4] - media2) * (arr2[N - 4] - media2)) + ((arr2[N - 5] - media2) * (arr2[N - 5] - media2)) + ((arr2[N - 6] - media2) * (arr2[N - 6] - media2))) / (N - 1);
                richTextBox1.AppendText("Variância Amostral:" + Convert.ToString(v) + $"\n");
                double desvio = 0;
                desvio = Math.Sqrt(v);
                richTextBox1.AppendText("Desvio Padrão:" + Convert.ToString(desvio) + "\n");
                double cv = 0;
                cv = 100 * (desvio / media2);
                richTextBox1.AppendText("Coeficiente de Variação:" + Convert.ToString(String.Format("{0:0.000}", cv) + "%"));
                if (cv <= 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Homogêneo");
                }
                if (cv > 0.3)
                {
                    richTextBox1.AppendText("\nConjunto de dados é Heterogêneo");
                }
            }

            /*>>>>>>>>>>>>>>>>>>>variância amostral / desvio padrão / coe variação/ conjunto<<<<<<<<<<<<<<<<<<<<*/
        }
    }
}
