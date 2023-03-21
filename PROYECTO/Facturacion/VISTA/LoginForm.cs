using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CANCELAR_button_Click(object sender, EventArgs e)
        {
            Close();//NOS DA LA POSIBILIDAD DE CERRAR EL CUADRO DE DIALOGO
        }

        private void ACEPTARbutton_Click(object sender, EventArgs e)
        {
            if (USUARIOtextBox.Text== string.Empty)
            {
                errorProvider1.SetError(USUARIOtextBox, "INGRESE UN USUARIO");
                USUARIOtextBox.Focus();//DEVUELVE A LA CASILLA EL PALITO PARA ESCRIBIR DONDE ESTA EL ERROR
                return;
            }
            errorProvider1.Clear();//LIMPIANDO EL ERROR TIRADO
            if (string.IsNullOrEmpty(CONTRAtextBox.Text))//SI ES NULLO O VACIO TIRA EL ERROR
            {
                errorProvider1.SetError(CONTRAtextBox, "INGRESE UNA CONTRASEÑA");
                CONTRAtextBox.Focus();//DEVUELVE A LA CASILLA EL PALITO PARA ESCRIBIR DONDE ESTA EL ERROR
                return;

            }
            errorProvider1.Clear();//LIMPIANDO EL ERROR TIRADO

            //VALIDAMOS LA BASE DE DATOS
            Login loginOB = new Login(USUARIOtextBox.Text, CONTRAtextBox.Text);//DE LAS ENTIDADES
            Usuario usuario = new Usuario();//DE LAS ENTIDADES
            UsuarioDB usuarioDB = new UsuarioDB();

            usuario = usuarioDB.Autenticar(loginOB);//TODOS SON OBJETOS

            if (usuario != null)
            {
                if (usuario.EstadoActivo)
                {
                    //CLASE  GENERIC IDENTITY, NOS PERMITE GENERAR UNA AUTENTIFICACION
                    //El GenericIdentity se lo tenemos que pasar a un GenericPrincipal
                    System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(usuario.CodigoUsuario);//le pasamos el codigo del usuario para autentificarlo en factura
                    System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, new string[] {usuario.Rol});
                    //Una vez teniendo el GenericPrincipal, se lo pasamos al CurrentPrincipal(clase que almacena la sesion de autentificacion)
                    System.Threading.Thread.CurrentPrincipal = principal;
                    //MOSTRAMOS EL MENU
                    MenuForm menuFormulario = new MenuForm();//INSTANCIAMOS EL FORM MENU
                    Hide();//ESCONDEMOS EL LOGIN
                    menuFormulario.Show();//MOSTRAMOS EL FORMULARIO MENU
                }
                else
                {
                    MessageBox.Show("USUARIO INACTIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DATOS DE USUARIO INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //MOSTRAMOS Y OCULTAMOS LA CONTRASEÑA
        private void MostrarContra_button_Click(object sender, EventArgs e)
        {
            if(CONTRAtextBox.PasswordChar=='*'){
                CONTRAtextBox.PasswordChar = '\0';//VALOR NULLEABLE, SI SE DETECTA EL *, LO PASAREMOS NULO
            }
            else
            {
                CONTRAtextBox.PasswordChar = '*';// LUEGO LE PASAMOS EL ASTERISCO DE NUEVO, SI ENCUENTRA LAS CADENAS INGRESADAS EN CONTRASENA
            }
        }
    }
}
