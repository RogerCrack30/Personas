#region Usos
using Forms.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Universitario :Estudiante
    {
       
         string universidad;
         string carrera;
         string materiasInscritas;
         int nota;
         string Cum;
       

        public Universitario()
        {
            Universidades = string.Empty;
            Carrera = string.Empty;
            MateriasInscritas = string.Empty;
            Nota = 0;
            CUM = string.Empty;

           

        }


       
        public string Universidades { get => universidad; set => universidad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string MateriasInscritas { get => materiasInscritas; set => materiasInscritas = value; }
        public int Nota { get => nota; set => nota = value; }
        public string CUM { get => Cum; set => Cum = value; }

       

        
      
    }
}