using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraIMC.Controllers
{
    /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1, Ejercicio 2: Palíndromos
    Nombre del alumno: Sulub Flores Javier Alexander
    Cuatrimestre: 4
    Grupo: B
    Parcial: 1
    */
    [Route("api/[controller]")]
    [ApiController]
    public class Operacion : ControllerBase
    {
        [HttpGet]
        public IActionResult IMCResultado(double altura, double peso)
        {
            var R = new Persona();
            R.Peso = peso;
            R.Altura = altura / 100;
            var AFinal = R.Altura;
            var IMC = peso / (AFinal * AFinal);
            var Clasificacion = "";

            if (IMC < 18.5)
            {
                Clasificacion = "Más bajo de lo normal";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    Clasificacion = "Normal";
                }
                else
                {
                    if (IMC >= 25.0 && IMC <= 29.9)
                    {
                        Clasificacion = "Más alto de lo normal";
                    }
                    else
                    {
                        Clasificacion = "Obesidad";
                    }
                }
            }
            var Resultado = "Tu IMC es: " + Convert.ToString(IMC) + " Tu peso es:  " + Clasificacion;
            return Ok(Resultado);
        }
    }
}
