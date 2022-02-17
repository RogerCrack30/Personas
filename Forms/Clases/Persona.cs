#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Persona
    {

    

         string nombreYapellido;
         int edad;
        string segs;


        
        public Persona()
        {
            Nombre_Y_apellido = string.Empty;
            Edad = 0;
            Segs = string.Empty;
            
        }

        public string Nombre_Y_apellido { get => nombreYapellido; set => nombreYapellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Segs { get => segs; set => segs = value; }
    }
}
