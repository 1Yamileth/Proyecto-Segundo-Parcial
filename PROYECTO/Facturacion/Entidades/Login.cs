using System;
namespace Entidades
{
    public class Login//SIEMPRE PONERLAS PUBLICAS
    {
        //PROPIEDADES
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }
         
        
        //CONSTRUCTORES
        public Login()
        {
        }
        public Login(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
           
        }






    }
}
