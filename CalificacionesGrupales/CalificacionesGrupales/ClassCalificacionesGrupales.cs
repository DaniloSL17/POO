using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesGrupales
{
    class ClassCalificacionesGrupales
    {

        //Atributos de la clase
        public int CalifCapturada = 0, SumaCalif = 0;
        public double PromedioGrupal = 0;
        public int Reprobados = 0, Aprobados = 0;

        //metodos de la clase 
        public void ContarAprobados()
        {
            if (CalifCapturada < 70)
            {
                Reprobados++;
                SumaCalif += CalifCapturada;
            }
            else
            {
                Aprobados++;
                SumaCalif += CalifCapturada;
            }
            PromedioGrupal = SumaCalif / (Aprobados + Reprobados);
            
        }


    }


}

