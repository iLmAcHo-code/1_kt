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

namespace WpfApp_LR7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Lr_7";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Z=0;
            try
            {
                double n = Convert.ToDouble(N.Text);
                double k = Convert.ToDouble(K.Text);
                double i = Convert.ToDouble(I.Text);
                double j = Convert.ToDouble(J.Text);
                double p = Convert.ToDouble(P.Text);
                double x = Convert.ToDouble(X.Text);
                double y = Convert.ToDouble(Y.Text);
                double f = Convert.ToDouble(F.Text);

                for (int t = 0; t < n; t++)
                {
                    for (int m = 0; m < k; m++)
                    {
                        Z = (Math.Pow(p, i) * Math.Pow(x, 3) + Math.Pow(f, i) * Math.Pow(y, 2)) / (i * j);
                    }
                }
                this.Title = $" Ответ = {Z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
