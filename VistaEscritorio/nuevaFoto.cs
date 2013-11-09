using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Entidades;
using ApSocial.Controladora.Publicaciones;
using ApSocial.Controladora.Amistades;

namespace VistaEscritorio
{
    public partial class nuevaFoto : Form
    {
        private int idFoto;
        PublicacionController controladoraPublicaciones = new PublicacionController();
        AmistadesController controladoraAmistad = new AmistadesController();


        public int IdFoto
        {
            get { return idFoto; }
            set { idFoto = value; }
        }

        public nuevaFoto()
        {
            InitializeComponent();
            cargarAmigos(listAmigos);
        }

        private void buscarArchivoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        public void cargarAmigos(ListBox listBox) {
            List<Usuario> lista = controladoraAmistad.getAllFriendsFromUser(Session.IdUsuarioLogueado);
            listBox.DataSource = lista;
        }

        public string verificarDatos() {
            string rta = "";
            if (nombreTXT.Text == "") {
                rta = rta + " -Debe ingresar nombre- ";
            }
            if (pathTXT.Text == "") {
                rta = rta + " - Debe seleccionar foto - ";
            }
            return rta;
        }



        private void aceptarBTN_Click(object sender, EventArgs e)
        {
            string verificacion;
            try{
                verificacion = verificarDatos();
                if (verificarDatos() == "")
                {
                   /* Fotos foto = controladoraPublicaciones.nuevaFoto(nombreTXT.Text, pathTXT.Text, cargarUsuariosEtiquetados());
                    this.IdFoto = foto.Id;
                    this.Close();*/
                }
                else {
                    MessageBox.Show(verificarDatos());
                }
            }catch (Exception ex){
                MessageBox.Show("no se ha podido cargar la foto "+ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pathTXT.Text = openFileDialog1.FileName;
        }


    }
}
