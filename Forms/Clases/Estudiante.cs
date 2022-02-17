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
    internal class Estudiante : Persona 
    {

         string carnet;
         string nivelAcademico;

        public Estudiante()
        {

            Carnet = string.Empty;
            NivelAcademico = string.Empty;
        }
       
        

        public string Carnet { get => carnet; set => carnet = value; }
        public string NivelAcademico { get => nivelAcademico; set => nivelAcademico = value; }

        
    }
}