﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App1.Datos;
using App1.Modelo;
using App1.VistaModelo;
using App1.Vistas.Detalle;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace App1.VistaModelo
{
    public class VMprincipal:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mrutina> _listarutinas;
        ObservableCollection<Mcategorias> _listacategorias;
        #endregion
        #region CONSTRUCTOR
        public VMprincipal(INavigation navigation)
        {

            Navigation = navigation;
            Listarcategorias();
            ListarRutinas();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mrutina> Listarutinas
        {
            get { return _listarutinas; }
            set { SetValue(ref _listarutinas, value); }
        }
        public ObservableCollection<Mcategorias> Listacategorias
        {
            get { return _listacategorias; }
            set { SetValue(ref _listacategorias, value); }
        }
        #endregion
        #region PROCESOS
        public void ListarRutinas()
        {
            var funcion = new Drutina();
            Listarutinas = funcion.ListarRutinas();
        }
        public void Listarcategorias()
        {
            var funcion = new Dcategorias();
            Listacategorias = funcion.Mostrarcategorias();
        }
        private void Seleccionar(Mcategorias parametros)
        {
            var index = Listacategorias
                .ToList()
                .FindIndex(p => p.categoria == parametros.categoria);
            if (index>-1)
            {
                Deseleccionar();
                Listacategorias[index].Select = true;
                Listacategorias[index].Color1 = "#8664FF";
                Listacategorias[index].Color2 = "#BBA8FF";
                Listacategorias[index].Textcolor = "#ffffff";
            }
        }
        private void Deseleccionar()
        {
            Listacategorias.ForEach((item) =>
            {
                item.Select = false;
                item.Color1 = "#ffffff";
                item.Color2 = "#ffffff";
                item.Textcolor = "#2F394B";
            });
        }
        private async void SeleccionarRutina(Mrutina parametros)
        {
            await Navigation.PushAsync(new Detalleproduct(parametros));
        }

        #endregion
        #region COMANDOS
        public ICommand Seleccionarcommand => new Command<Mcategorias>(Seleccionar);
        public ICommand SeleccionarRutinacommand => new Command<Mrutina>(SeleccionarRutina);
        #endregion
    }
}
