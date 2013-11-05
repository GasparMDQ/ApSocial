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

namespace VistaEscritorio
{
    public partial class nuevaFoto : Form
    {
        private int idFoto;

        public int IdFoto
        {
            get { return idFoto; }
            set { idFoto = value; }
        }

        public nuevaFoto()
        {
            InitializeComponent();
        }
        PublicacionController controladoraPublicaciones=new PublicacionController();
        private void buscarArchivoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        public List<Usuario> cargarUsuarios() {
            List<Usuario> lista=new List<Usuario>();
            //falta cargar usuarios del list box 
            return lista;
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
                    Fotos foto = controladoraPublicaciones.nuevaFoto(nombreTXT.Text, pathTXT.Text, cargarUsuarios());
                    this.IdFoto = foto.Id;
                    this.Close();
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
