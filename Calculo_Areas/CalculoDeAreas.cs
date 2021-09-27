using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculo_Areas
{
    public class CalculoDeAreas
    {
        /// <summary>
        /// Alumno: Freddy Esteban Balcazar Padilla
        /// Carrera: Licenciatura en sistemas computacionales
        /// Semestre : 9   Grupo: J
        /// Practica 3:Servicio web en .Net
        /// </summary>
        public int Base { get; set; }
        public int Altura { get; set; }
        public double Pi = 3.1416;
        double ElevadoAlCuadrado;
        public double Radio;

        public decimal A_cuadrado()//calculo de area de un cuadrado
        {
            return Base * Altura;
        }
        public decimal A_triangulo()//Calculo de are de un triangulo
        {
            return (Base * Altura) / 2;
        }

        public double A_circulo()//Calculo de area  un circulo
        {
            ElevadoAlCuadrado = Math.Pow(Radio, 2);
            return Pi * ElevadoAlCuadrado;
        }

    }
}