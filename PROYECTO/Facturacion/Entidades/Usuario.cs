using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        //PROPIEDADES
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo {get; set;}
        public string Rol { get; set; }//PARA VER SI ES ADMINISTRADOR O SI ES USUARIO NORMAL
        public Byte[] Foto { get; set; }
        public DateTime FechaCreacion { get; set; }//PARA SABER CUANDO SE CREO UN USUARIO
        public bool EstadoActivo { get; set; }//PARAA VER SI EL USUARIO ESTA ACTIVO O NO, O SEA, SI ESTA TRABAJANDO O NO


        //CONSTRUCTORES
        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contraseña, string correo, string rol, byte[] foto, DateTime fechaCreacion, bool estadoActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Correo = correo;
            Rol = rol;
            Foto = foto;
            FechaCreacion = fechaCreacion;
            EstadoActivo = estadoActivo;
        }
    }
}
