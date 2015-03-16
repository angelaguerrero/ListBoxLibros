using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ListBoxLibros.Models;
using System.Collections.ObjectModel;

namespace ListBoxLibros
{
    public partial class InformacionLibro : PhoneApplicationPage
    {
        public InformacionLibro()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("nombre"))
            {
                String nom= NavigationContext.QueryString["nombre"];
                nombre.Text = nom;
            }
            if (NavigationContext.QueryString.ContainsKey("autor"))
            {
                String aut = NavigationContext.QueryString["autor"];
                autor.Text = aut;
            }
            if (NavigationContext.QueryString.ContainsKey("codigo"))
            {
                String cod = NavigationContext.QueryString["codigo"];
                codigo.Text = cod;
            }
            if (NavigationContext.QueryString.ContainsKey("genero"))
            {
                String gen = NavigationContext.QueryString["genero"];
                genero.Text = gen;
            }
            if (NavigationContext.QueryString.ContainsKey("paginas"))
            {
                String pag = NavigationContext.QueryString["paginas"];
                paginas.Text = pag;
            }


        }

        private void regresarLista(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));
        }
    }
}