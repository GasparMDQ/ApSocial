﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Publicaciones;
using ApSocial.Entidades;

namespace VistaEscritorio
{
    public partial class albumForm : Form
    {
        PublicacionController controladoraPublicacion = new PublicacionController();
        List<Fotos> fotosDelAlbum = new List<Fotos>();
        
        public albumForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // ver que si cancelo tengo q borrar todas las fotos que habia cargado  
        }



        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            try
            {
                nuevaFoto newPic = new nuevaFoto();
                newPic.ShowDialog();
                int fotoId = newPic.IdFoto;
                listFotos.Items.Add(controladoraPublicacion.buscarFoto(fotoId).Nombre);
            }
            catch (Exception ex){
                MessageBox.Show("error al cargar la foto  " + ex.Message);
            }

        }

        private void btnGuardarAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe;
                existe = controladoraPublicacion.existePublicacion(albumNameTXT.Text);
                if (!existe)
                {
                    Album_fotos nuevoAlbum = new Album_fotos(DateTime.Today, albumNameTXT.Text, true, Session.IdUsuarioLogueado, null);
                }
                else {
                    MessageBox.Show("el album ya existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se guardar el album" + ex.Message);
            }

        }


    }
}
