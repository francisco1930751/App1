using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using App1.Modelo;

namespace App1.Datos
  {
  public class Dcategorias
    {
    public ObservableCollection<Mcategorias> Mostrarcategorias()
      {
      return new ObservableCollection<Mcategorias>()
        {
        new Mcategorias()
          {
          categoria="Pierna",
          icono="https://cdn-icons-png.flaticon.com/512/30/30740.png",
          Textcolor="#2F394B",
          Color1="#ffffff",
           Color2="#ffffff",
           Select=false
          },
          new Mcategorias()
          {
          categoria="Pecho",
          icono="https://cdn-icons-png.flaticon.com/512/4760/4760544.png",
          Textcolor="#2F394B",
            Color1="#ffffff",
           Color2="#ffffff",
            Select=false
          },
           new Mcategorias()
          {
          categoria="Abdomen",
          icono="https://cdn-icons-png.flaticon.com/512/2309/2309082.png",
          Textcolor="#2F394B",
            Color1="#ffffff",
           Color2="#ffffff",
            Select=false
          },
        };
      }
    }
  }
