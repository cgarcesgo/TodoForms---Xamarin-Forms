using System;
using System.Collections.Generic;
using System.Linq;
using TodoForms.Clases;
using Xamarin.Forms;

namespace TodoForms
{
    public partial class ListaTareas : ContentPage
    {
        public ListaTareas()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RUTA_BD))
            {
                List<Tarea> listaTareas;

                try{
                    listaTareas = conexion.Table<Tarea>().ToList();
                }
                catch (Exception e){
                    listaTareas = new List<Tarea>();
                }

                listaTareasListView.ItemsSource = listaTareas;
            }
        }
    }
}
