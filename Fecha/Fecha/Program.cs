using System;


namespace Fecha
{
    class Program
    {
        private static void EsBisiesto(Fecha fecha)
        {
            Console.WriteLine("Fecha 1: " + fecha.ToString());
            if (fecha.EsBisiesto())
                Console.WriteLine("El año " + fecha.Año + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha.Año + " no es bisiesto");
        }

        static void Main(string[] args)
        {
            //Fecha correcta, año bisiesto
            Fecha fecha1 = new Fecha(12, 2012, 4, false);
            EsBisiesto(fecha1);

            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha(10, 2013, 4, false);
            EsBisiesto(fecha2);

            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha(13, -4, 4, false);
            Console.WriteLine("Fecha 3: " + fecha3.ToString());

            //Fecha con asignación incorrecta de valores erroneos
            Fecha fecha4 = new Fecha();
            fecha4.Dia = 67;
            fecha4.Mes = 80;
            fecha4.Año = 3678;
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
            //MAL!!
        }

        
    }
}