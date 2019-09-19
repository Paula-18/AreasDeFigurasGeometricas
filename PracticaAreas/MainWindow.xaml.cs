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
            int numero1 =
                int.Parse(txt1.Text);
            int numero2 =
                int.Parse(txt2.Text);

            int resultado1 =
                numero1 * numero2;
            resultadoR.Text = resultado1.ToString();
        }

        private void BtnTri_Click(object sender, RoutedEventArgs e)
        {
            int numero1 =
                int.Parse(txt3.Text);
            int numero2 =
                int.Parse(txt4.Text);

            int resultado2 =
                (numero1 * numero2) / 2;
            resultadoT.Text = resultado2.ToString();
        }

        private void BtnCir_Click(object sender, RoutedEventArgs e)
        {
            int numero1 =
                int.Parse(txt5.Text);
        }
    }
}
