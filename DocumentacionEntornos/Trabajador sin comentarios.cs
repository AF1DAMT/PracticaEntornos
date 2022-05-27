
namespace proyecto.documentacion
{
    /// <summary>
    /// Clase que almacena laa edad de jubilación del trabajador
    /// Su nombre y su edad
    /// </summary>
    ///<remarks>
    /// Utilzar esta clase para almacenaar datos de Trabajadores
    /// </remarks> 
    /// <param name="nombre">
    /// valor de tipo string que representa el nombre del trabajador
    /// </param>
    /// <param name="edad">
    /// valor de tipo entero que representa la edad del trabajador
    /// </param>
    /// <example>
    /// Como crear una instandia de dicho objeto
    ///     <code>
    ///      Trabajador trabajador = new Trabajador();
    ///     </code>
    /// </example>
    public class Trabajador
    {
        
        private const int EdadJubilacionDefecto = 67;
        
        private string nombre;        
        private int edad;
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }        
       
        public int Edad
        {
            get { return edad; }
            set 
            {
                if (value >= 1 && value <= 150)
                    edad = value;
            }
        }
       
        public int CalculoAnyosJubilacion()
        {
            return EdadJubilacionDefecto - edad;
        }
       
        public int CalculoAnyosJubilacion(int edadJubilacion)
        {
            if (edadJubilacion < EdadJubilacionDefecto && edadJubilacion >= edad)
                return edadJubilacion - edad;
            else
                return EdadJubilacionDefecto - edad;
        }

    }
}
