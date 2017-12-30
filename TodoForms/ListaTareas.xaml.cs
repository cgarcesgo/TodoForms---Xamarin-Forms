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

            var botonNuevo = new ToolbarItem()
            {
                Text = "+"
            };

            botonNuevo.Clicked += BotonNuevo_Clicked;
            ToolbarItems.Add(botonNuevo);
        }

        async void BotonNuevo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevoItem());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RUTA_BD))
            {
                List<Tarea> listaTareas;

                try{
                    listaTareas = conexion.Table<Tarea>().Where(t => t.Completada == false).ToList();
                }
                catch (Exception e){
                    listaTareas = new List<Tarea>();
                }

                listaTareasListView.ItemsSource = listaTareas;
            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RUTA_BD))
            {
                var tareaCompletar = (sender as MenuItem).CommandParameter as Tarea;
                tareaCompletar.Completada = true;

                conexion.Update(tareaCompletar);

                List<Tarea> listaTareasFiltrada = conexion.Table<Tarea>().Where(t => t.Completada == false).ToList();

                listaTareasListView.ItemsSource = listaTareasFiltrada;

            }
        }
    }
}
