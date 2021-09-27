using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculo_Areas
{
    /// <summary>
    /// Descripción breve de CalculoAreasService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculoAreasService : System.Web.Services.WebService
    {

        CalculoDeAreas c = new CalculoDeAreas();

        [WebMethod(Description ="Calculo de area de un cuadrado")]
        public decimal A_cuadrado(int Base, int Altura)
        {
           
            c.Base = Base;
            c.Altura = Altura;
            return c.A_cuadrado();
        }

        [WebMethod(Description = "Calculo de area de un triangulo")]
        public decimal A_triangulo(int Base, int Altura)
        {
            c.Altura = Altura;
            c.Base = Base;
            return c.A_triangulo();
        }

        [WebMethod(Description = "Calculo de area de un circulo")]
        public double A_circulo(double Radio)
        {
            c.Radio = Radio;
            return c.A_circulo();
        }
    }
}
