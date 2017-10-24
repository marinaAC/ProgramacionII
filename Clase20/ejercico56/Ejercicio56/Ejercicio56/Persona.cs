using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio56
{
    [Serializable]
    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(){}

        public Persona(string nom, string apellido) 
        {
            this.apellido = apellido;
            this.nombre = nom;
        }

        public static void Guardar(Persona p)
        {
            FileStream fs = new FileStream("prueba.dat",FileMode.Create);
            BinaryFormatter ser = new BinaryFormatter();
            ser.Serialize(fs,p);
            fs.Close();
        }

        public Persona Leer() 
        {
            Persona aux = new Persona();
            FileStream fs = new FileStream("prueba.dat",FileMode.Open);
            BinaryFormatter ser = new BinaryFormatter();
            aux = (Persona)ser.Deserialize(fs);
            fs.Close();
            return aux;
        }

        public override string ToString()
        {
            string returnAux = string.Format("Nombre: {0}, Apellido:{1}", this.nombre, this.apellido);
            return returnAux;
        }
    }
}
