using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    public class Cancion
    {

        public string nombre;
        public string artista;
        public string album;
        public string genero;

        public Cancion(string nombre, string artista, string album, string genero)
        {
            this.nombre = nombre;
            this.artista = artista;
            this.album = album;
            this.genero = genero;
        }
        public string Informacion()
        {

            return ("Nombre: "+ nombre + ", Artista: "+ artista + ", Album: "+ album + ", Genero: "+ genero);
            
        }
        
        
        
          
        
    }
}

