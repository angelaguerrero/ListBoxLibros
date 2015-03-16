using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ListBoxLibros.Resources;
using ListBoxLibros.Models;

namespace ListBoxLibros
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void SeleccionListBox(object sender, SelectionChangedEventArgs e)
        {
            var libroSeleccionado = listaLibros.SelectedItem as libro;
            var lNombre = libroSeleccionado.Nombre;
            var lCodigo = libroSeleccionado.Codigo;
            var lAutor = libroSeleccionado.Autor;
            var lGenero = libroSeleccionado.Genero;
            var lPaginas = libroSeleccionado.Paginas;
            NavigationService.Navigate(new Uri("/InformacionLibro.xaml?nombre="+lNombre+"&codigo="+lCodigo+"&autor="+lAutor+"&genero="+lGenero+"&paginas=" + lPaginas +"", UriKind.Relative));
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}