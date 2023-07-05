using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using App1.VistaModelo;
using App1.Modelo;

namespace App1.VistaModelo
{
    internal class VMdetalle:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public Mrutina ParametrosRecibe { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMdetalle(INavigation navigation,Mrutina parametrosTrae)
        {
            Navigation = navigation;
            ParametrosRecibe = parametrosTrae;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
