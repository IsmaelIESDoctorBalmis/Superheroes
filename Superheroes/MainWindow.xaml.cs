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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<superheroe> personajes = superheroe.GetSamples();
        int contadorPersonaje = 0;

        public MainWindow()
        {
            InitializeComponent();
            gridPrincipal.DataContext = personajes[contadorPersonaje];


        }

        private void leftArroyImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int numeroPersonaje = int.Parse(numberPersonajeTextBlock.Text.ToString());
            Image flecha = (Image)sender;

                if (flecha.Tag.ToString() == "sumar" && contadorPersonaje < 2)
                {
                    contadorPersonaje = contadorPersonaje + 1;
                    numeroPersonaje++;
                }
                else if (flecha.Tag.ToString() == "restar" && contadorPersonaje > 0)
                {
                    contadorPersonaje = contadorPersonaje - 1;
                    numeroPersonaje--;
                }
                gridPrincipal.DataContext = personajes[contadorPersonaje];
            numberPersonajeTextBlock.Text = numeroPersonaje.ToString();



        }
    }
}
