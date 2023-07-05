using App1.Datos;
using App1.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.VistaModelo
{
    public class VMperfil:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mperfil> _perfil;

        #endregion
        #region CONSTRUCTOR
        public VMperfil(INavigation navigation)
        {
            Navigation = navigation;
            MuestraPerfil();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mperfil> Perfil
        {
            get { return _perfil; }
            set { SetValue(ref _perfil, value); }
        }
        #endregion
        #region PROCESOS
        public void MuestraPerfil()
        {
            var funcion = new Dperfil();
            Perfil=funcion.MuestraPerfil();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
