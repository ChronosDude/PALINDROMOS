using Microsoft.AspNetCore.Mvc;
using palindromo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  Universidad Tecnologica Metropolitana
    Materia: Aplicaciones Web Orientadas a Servicios
    Maestro: Chuc Uc Joel Ivan
    Actividad 2, Ejercicio 2: Palíndromos
    Alumno: Ac Ku Jimmi Leonel
    Cuatrimestre: 4
    Grupo: A
    Primer Parcial
*/
namespace palindromo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
        public string Post (Frase fra)
        {


            string minus = fra.phrase.ToLower();
            string sinespa = minus.Trim();

            int palabras = 1;

            for (int i = 0; i< sinespa.Length; i++)
            {
                if(sinespa[i]== ' ')
                {
                    palabras++;
                }
            }

            string junto = sinespa.Replace(" ","").Replace(",","");
            
            char[] charArray = junto.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }

            string esono;

            if (junto==reverse)
            {
                esono="Si es un palindromo.";
            }
            else
            {
                esono="No es un palindromo.";
            }
    
            return ("Lo que mandaste "+ esono +" Y hay "+palabras+" palabras.");
        }
    }
}