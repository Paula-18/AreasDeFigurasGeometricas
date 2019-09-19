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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRec_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                double.Parse(txt1.Text);
            double numero2 =
                double.Parse(txt2.Text);

            double resultado1 =
                numero1 * numero2;
            resultadoR.Text = resultado1.ToString();
        }

        private void BtnTri_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                double.Parse(txt3.Text);
            double numero2 =
                double.Parse(txt4.Text);

            double resultado2 =
                (numero1 * numero2) / 2;
            resultadoT.Text = resultado2.ToString();
        }

        private void BtnCir_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                double.Parse(txt5.Text);

            double resultado3 =
                (Math.PI * (numero1 * numero1));
            resultadoC.Text = resultado3.ToString();
        }

        private void BtnTra_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                double.Parse(txt6.Text);
            double numero2 =
                double.Parse(txt7.Text);
            double numero3 =
                double.Parse(txt8.Text);
            double resultado4 =
                ((numero1 + numero2) * numero3) / 2;
            resultadoTr.Text = resultado4.ToString();
        }
    }
}
