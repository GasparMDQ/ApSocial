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
            List<Usuario> lista = new List<Usuario>();
            Usuario usuario = new Usuario("garcia", "juan", "juang@gmail.com","mdp","123456",DateTime.Today,"sdsds");
            Usuario usuario1 = new Usuario("lopez", "cristian", "lcristian@gmail.com", "mdp", "123456", DateTime.Today, "sdsds");
            Usuario usuario2 = new Usuario("juarez", "juan", "juajuarezg@gmail.com", "mdp", "123456", DateTime.Today, "sdsds");
            lista.Add(usuario);
            lista.Add(usuario1);
            lista.Add(usuario2);
           //lista = controladoraAmistad.getAllFriendsFromUser(Session.IdUsuarioLogueado);
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
                    recuperarEtiquetados(listAmigos);
                    Fotos foto = controladoraPublicaciones.nuevaFoto(nombreTXT.Text, pathTXT.Text, recuperarEtiquetados(listAmigos));
                    /*this.IdFoto = foto.Id;
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

        private void etiquetarBTN_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection usuarios = new ListBox.SelectedObjectCollection(listAmigos);
            usuarios = listAmigos.SelectedItems;
            if (listAmigos.SelectedIndex != -1)
            {
                foreach (Usuario s in usuarios)
                {
                    listUsuariosEtiquetados.Items.Add(s);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un usuario");
        }
        
        public List<Usuario> recuperarEtiquetados(ListBox listAmigos) {
            List<Usuario> miLista = new List<Usuario>();
            ListBox.SelectedObjectCollection usuarios = new ListBox.SelectedObjectCollection(listAmigos);
            usuarios = listAmigos.SelectedItems;
            if (listAmigos.SelectedIndex != -1)
            {
                foreach (Usuario s in usuarios)
                {
                    miLista.Add(s);
                    MessageBox.Show("se agrego a  " + s.Nombre +s.Apellido);
                }
            } return miLista;
        
        }


    }
}
