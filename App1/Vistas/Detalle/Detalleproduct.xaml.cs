using App1.Modelo;
using App1.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Vistas.Detalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalleproduct : ContentPage
    {
        public Detalleproduct(Mrutina parametros)
        {
            InitializeComponent();
            BindingContext = new VMdetalle(Navigation,parametros);    
                }
    }
}