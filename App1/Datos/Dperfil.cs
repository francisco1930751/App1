using App1.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.Datos
{
    public class Dperfil
    {
        public ObservableCollection<Mperfil> MuestraPerfil()
        {
            return new ObservableCollection<Mperfil>()
            {
               new Mperfil()
               {
                   ImagenPerfil="https://pbs.twimg.com/profile_images/560241496570740736/96lcX5qh_400x400.jpeg",
                   Nombre="Rogelio Figueroa Gomez",
                   Descripcion="persona fitness, con ganas de seguir aprendiendo",
                   Email="Rogelio.FG@gmail.com"
               },
            };
        }
    }
}
