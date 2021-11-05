using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class superheroe : INotifyPropertyChanged
    {
        private string nombre;
        private string imagen;

        public string Nombre
        {
            get { return this.nombre; }
            set { 
                this.nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }
        }

        

        public string Imagen
        {
            get { return imagen; }
            set {
                this.imagen = value;
                this.NotifyPropertyChanged("Imagen");
            }
        }

        public bool Vengador { get; set; }
        public bool Xmen { get; set; }
        public bool Heroe { get; set; }

        public superheroe()
        {
        }

        public superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        

        public static List<superheroe> GetSamples()
        {
            List<superheroe> ejemplos = new List<superheroe>();

            superheroe ironman = new superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            superheroe kingpin = new superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            superheroe spiderman = new superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(String propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




    }
}
