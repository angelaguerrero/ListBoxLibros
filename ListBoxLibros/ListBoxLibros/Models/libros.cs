using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxLibros.Models
{
    public class libros
    {
        ObservableCollection<libro> data;

        public ObservableCollection<libro> Data
        {
            get
            {
                if (data == null)
                {
                    data = new ObservableCollection<libro>();
                    libro libro1 = new libro() { Nombre = "Principito", Codigo = "1", Autor = "Anonimo", Genero = "Infantil", Paginas = 200 };
                    libro libro2 = new libro() { Nombre = "Juegos del Hambre", Codigo = "2", Autor = "Suzanne Collins", Genero = "Ficcion", Paginas = 200 };
                    libro libro3 = new libro() { Nombre = "El perfume", Codigo = "3", Autor = "Patrick", Genero = "Suspenso", Paginas = 200 };
                    data.Add(libro1);
                    data.Add(libro2);
                    data.Add(libro3);
                }
                return data;
            }
            set
            {
                data = value;
            }
        }

        public libro FindLibroByNombre(String nombre)
        {

            libro libroSeleccionado = new libro();
            int i;
            for (i = 0; i < 3; i++)
            {
                if (nombre.Equals(data.ElementAt(i).Nombre))
                {
                    libroSeleccionado = data.ElementAt(i);
                }
            }
            return libroSeleccionado;
        }
    }
}
