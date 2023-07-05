using App1.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.Datos
{
   public class Drutina
    {
    public ObservableCollection<Mrutina> ListarRutinas()
        {
            return new ObservableCollection<Mrutina>()
            {
                new Mrutina()
                {
                    TipoEjercicio="Pierna",
                    ejercicio="Desplantes",
                    descripcion="1.Párate derecho con los pies separados al ancho de tus caderas y los brazos relajados a los costados." +
                    "Da un paso hacia adelante con el pie derecho. Mantén el pie plano en el suelo y asegúrate de que tu rodilla esté alineada con el tobillo." +
                    "Baja tu cuerpo hacia el suelo flexionando ambas rodillas. El objetivo es que ambas rodillas formen un ángulo de 90 grados." +
                    "Mantén el peso en el talón del pie delantero y el empeine del pie trasero." +
                    "Mantén la espalda recta, el abdomen contraído y la mirada al frente." +
                    "Empuja a través del talón del pie delantero y regresa a la posición inicial." +
                    "Repite el movimiento con el pie contrario, alternando entre pierna derecha e izquierda.",
                    icono="https://cdn-icons-png.flaticon.com/512/30/30740.png",
                    imagen="https://www.uic.mx/wp-content/uploads/2020/03/4-01.jpg"
                },
                 new Mrutina()
                {
                    TipoEjercicio="Abdomen",
                    ejercicio="Escalacion",
                    descripcion="Comienza en posición de plancha alta o posición de flexión de brazos, con las manos colocadas directamente debajo de los hombros y los brazos extendidos." +
                    "Asegúrate de que tu cuerpo esté alineado en una línea recta desde la cabeza hasta los pies. Mantén el abdomen contraído y los glúteos apretados." +
                    "Lleva una rodilla hacia el pecho, doblando la pierna y acercando la rodilla lo más posible al torso." +
                    "Luego, extiende la pierna y regresa a la posición inicial." +
                    "Repite el movimiento con la otra pierna, llevando la rodilla opuesta hacia el pecho y luego extendiéndola hacia atrás." +
                    "Continúa alternando rápidamente entre las dos piernas, realizando un movimiento de escalada o subiendo la montaña.",
                    icono="https://cdn-icons-png.flaticon.com/512/2309/2309082.png",
                    imagen="https://aprendeconreyhan.org/wp-content/uploads/2021/12/41-271x300.png"
                },
                  new Mrutina()
                {
                    TipoEjercicio="pecho",
                    ejercicio="Remo con mancuerna",
                    descripcion="1.Comienza de pie con las piernas separadas al ancho de los hombros y una mancuerna en cada mano." +
                                "2.Dobla ligeramente las rodillas y mantén la espalda recta." +
                                "3.Inclínate hacia adelante desde la cintura hasta que tu torso esté casi paralelo al suelo. Mantén una ligera flexión en las rodillas durante todo el ejercicio." +
                                "Extiende los brazos hacia abajo frente a ti, asegurándote de mantener los codos ligeramente flexionados." +
                                "Contrae los músculos de la espalda y tira de las mancuernas hacia arriba y hacia tu pecho. Mantén los codos cerca de tu cuerpo y los omóplatos juntos mientras haces el movimiento." +
                                "Mantén la contracción durante un segundo en la parte superior del movimiento, sintiendo la activación de los músculos de la espalda." +
                                "Luego, baja lentamente las mancuernas hacia abajo, extendiendo los brazos completamente." +
                                "Repite el movimiento para completar el número deseado de repeticiones.",
                    icono="https://cdn-icons-png.flaticon.com/512/4760/4760544.png",
                    imagen="https://www.entrenamientos.com/uploads/exercise/press-pectoral-con-mancuernas-en-banco-inclinado-init-pos-8206.png"
                },

            };
        }
    }
}
