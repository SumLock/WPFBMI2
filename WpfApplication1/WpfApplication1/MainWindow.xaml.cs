using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.IsEnabled = false;
            result.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //定義變數
                double H, W;
                H = Convert.ToInt32(height.Text);
                W = Convert.ToInt32(weight.Text);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                double r = (W / (h * h));
                result.Text = r.ToString();
                height.Background = Brushes.GreenYellow;
                weight.Background = Brushes.GreenYellow;
                if ( r > 30)
                {
                    result.Background = Brushes.Red;
                }
                if (17 <= r && r <= 30)
                {
                    result.Background = Brushes.Green;
                }
                if (17 > r)
                {
                    result.Background = Brushes.Blue;
                }
            }
            //除錯,處理非數字例外情況
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clear1_Click(object sender, RoutedEventArgs e)
        {
            height.Text = "0";
            height.Background = Brushes.White;
        }

        private void clear2_Click(object sender, RoutedEventArgs e)
        {
            weight.Text = "0";
            weight.Background = Brushes.White;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                height.Text = slider1.Value.ToString();
                weight.Text = slider2.Value.ToString();
                //定義變數
                double H, W;
                H = Convert.ToInt32(slider1.Value);
                W = Convert.ToInt32(slider2.Value);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                double r = (W / (h * h));
                result.Text = r.ToString();
                height.Background = Brushes.GreenYellow;
                weight.Background = Brushes.GreenYellow;
                if (r > 30)
                {
                    result.Background = Brushes.Red;
                }
                if (17 <= r && r <= 30)
                {
                    result.Background = Brushes.Green;
                }
                if (17 > r)
                {
                    result.Background = Brushes.Blue;
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                weight.Text = slider2.Value.ToString();
                height.Text = slider1.Value.ToString();
                //定義變數
                double H, W;
                H = Convert.ToInt32(slider1.Value);
                W = Convert.ToInt32(slider2.Value);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                double r = (W / (h * h));
                result.Text = r.ToString();
                height.Background = Brushes.GreenYellow;
                weight.Background = Brushes.GreenYellow;
                if (r > 30)
                {
                    result.Background = Brushes.Red;
                }
                if (17 <= r && r <= 30)
                {
                    result.Background = Brushes.Green;
                }
                if (17 > r)
                {
                    result.Background = Brushes.Blue;
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }



        private void RB1_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            result.IsEnabled = true;
        }


    }
}
