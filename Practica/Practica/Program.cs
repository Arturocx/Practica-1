using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno _alumno = new Alumno();
            Maestro _maestro = new Maestro();

            _alumno.Edad = 17;
            _alumno.Nombre = "Arturo";
            _alumno.NoControl = 14302060;
            _maestro.Edad = 23;
            _maestro.Nombre = "Christopher";
            _maestro.Sueldo = 5000;

            Console.WriteLine("La Edad Del Alumno Es: {0} su nombre es: {1} y NoControl: {2}", _alumno.Edad,_alumno.Nombre, _alumno.NoControl);
            Console.WriteLine("La Edad Del Maestro Es: {0} su nombre es: {1} y Su Sueldo: {2}", _maestro.Edad, _maestro.Nombre, _maestro.Sueldo);
            Console.ReadKey();
        }
    }
}
