using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxLibros.Models
{
    public class libro:System.ComponentModel.INotifyPropertyChanged
    {
        private String nombre;
        private String codigo;
        private String autor;
        private String genero;
        private int paginas;

        public String Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Nombre"));
                }
            }
        }
        public String Codigo
        {
            get { return codigo; }
            set
            {
                codigo = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Codigo"));
                }
            }
        }
        public String Autor
        {
            get { return autor; }
            set
            {
                autor = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Autor"));
                }
            }
        }
        public String Genero
        {
            get { return genero; }
            set
            {
                genero = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Genero"));
                }
            }
        }
        public int Paginas
        {
            get { return paginas; }
            set
            {
                paginas = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Paginas"));
                }
            }
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
