#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Ingenieria : Universitario
    {
         string nombreproyecto;
         int horatotal;
         int horacompletada;

        public Ingenieria()
        {
            NombreProyecto = string.Empty;
            HoraTotal = 0;
            HoraCompletada = 0;

        }


       
        public Ingenieria(string nombreapellido, int edad,string segs ,string carnet,string nivelacademico,string universidad, string carrera, string materiainscrita, int nota, string cum,string nombreproyecto, int horatotal, int horacompletada){

            this.Nombre_Y_apellido = nombreapellido;
            this.Edad = edad;
            this.Carnet = carnet;
            this.NivelAcademico = nivelacademico;
            this.Universidades = universidad;
            this.Carrera = carrera;
            this.MateriasInscritas = materiainscrita;
            this.Nota = nota;
            this.CUM = cum;
            this.NombreProyecto = nombreproyecto;
            this.HoraTotal = horatotal;
            this.HoraCompletada = horacompletada;
            this.Segs = segs;
        }
       

        public string NombreProyecto { get => nombreproyecto; set => nombreproyecto = value; }
        public int HoraTotal { get => horatotal; set => horatotal = value; }
        public int HoraCompletada { get => horacompletada; set => horacompletada = value; }
    }
}