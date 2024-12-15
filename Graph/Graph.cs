using Graph.ErrorBox;
using Graph.QuestionBox;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Graph
{
    public partial class Graph : Form
    {
        double Xmin, Xmax, Ymin, Ymax, Hx, Hy, H;

        /* Управление программой */

        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_SizeChanged(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    BorderlessForm.BorderRadius = 16;
                    BackgroundPanel.BorderRadius = 8;
                    break;
                case FormWindowState.Maximized:
                    BorderlessForm.BorderRadius = 0;
                    BackgroundPanel.BorderRadius = 0;
                    break;
            }
        }

        private void PlaySound(UnmanagedMemoryStream s)
        {
            using (SoundPlayer Sounder = new SoundPlayer(s))
            {
                Sounder.Play();
            }
            GC.Collect();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.minimize);
            Thread.Sleep(100);
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            switch(WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    break;
                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Function = functionBox.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        /* Построение графика */

        private void Graph_Load(object sender, EventArgs e)
        {
            //(x * x + 1) / Sin(3 * x) + (Sqrt(x / 2)) / Cos(3 * x)
            Xmin = -2 * 3.14; Xmax = 2 * 3.14; Ymin = -5; Ymax = 5;
            Hx = 4; Hy = 0.5; H = 0.01;
            functionBox.Text = Properties.Settings.Default.Function;
            xminBox.Text = Xmin.ToString();
            xmaxBox.Text = Xmax.ToString();
            yminBox.Text = Ymin.ToString();
            ymaxBox.Text = Ymax.ToString();
            xintervalBox.Text = Hx.ToString();
            yintervalBox.Text = Hy.ToString();
            hBox.Text = H.ToString();
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisY.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisY.Minimum = Ymin;
            chart1.ChartAreas[0].AxisY.Maximum = Ymax;
            chart1.ChartAreas[0].AxisX.Interval = Hx;
            chart1.ChartAreas[0].AxisY.Interval = Hy;
        }

        private void asexsButton_Click(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.click);
            try
            {
                Xmin = double.Parse(xminBox.Text);
                Xmax = double.Parse(xmaxBox.Text);
                Ymin = double.Parse(yminBox.Text);
                Ymax = double.Parse(ymaxBox.Text);
                Hx = double.Parse(xintervalBox.Text);
                Hy = double.Parse(yintervalBox.Text);
                H = double.Parse(hBox.Text);
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;
                chart1.ChartAreas[0].AxisY.Minimum = Ymin;
                chart1.ChartAreas[0].AxisY.Maximum = Ymax;
                chart1.ChartAreas[0].AxisX.Interval = Hx;
                chart1.ChartAreas[0].AxisY.Interval = Hy;
            }
            catch (FormatException)
            {
                PlaySound(Properties.Resources.error);
                ShowError.Show("Некорректный ввод в поле(я).");
            }
            finally { }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.click);
            chart1.Series[0].Points.Clear();
            try
            {
                createLabel.Visible = false;
                double x = Xmin;
                Argument a = new Argument("x");
                Expression y = new Expression(functionBox.Text,a);
                while (x <= Xmax)
                {
                    a.setArgumentValue(x);
                    chart1.Series[0].Points.AddXY(x, y.calculate());
                    x += H;
                }
                GC.Collect();

            }
            catch
            {
                PlaySound(Properties.Resources.error);
                ShowError.Show("Некорректный ввод в поле функции.");
            }
            finally { }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            createLabel.Visible = true;
            PlaySound(Properties.Resources.del);
        }

        /* Прочее */

        private void colorsButton_Click(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.click);
            colorPanel.Visible = true;
            colorPanel.Focus();
        }

        private void Color_Pick(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.succesful);
            chart1.Series[0].Color = ((Guna2Button)sender).FillColor;
            colorPanel.Visible = false;
        }

        private void colorPanel_Leave(object sender, EventArgs e)
        {
            colorPanel.Visible = false;
        }

        private void functionBox_Leave(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.leave);
            functionBox.Location = new Point(20, 80);
            functionBox.Width = 160;
        }

        private void functionBox_Enter(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.enter);
            functionBox.Location = new Point((int)(Width-450)/2, 9);
            functionBox.Width = 450;
        }

        private void functionBox_IconLeftClick(object sender, EventArgs e)
        {
            PlaySound(Properties.Resources.message);
            ShowQuestion.Show();
        }
    }

}
