﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Usuarios;
using ApSocial.Controladora.Publicaciones;
using ApSocial.Entidades;

namespace VistaEscritorio
{
    public partial class ApSocial : Form
    {
        private UsuarioController controladora = new UsuarioController();
        private PublicacionController controladoraPublicaciones = new PublicacionController();
        public ApSocial()
        {
            InitializeComponent();
            reloadMenu();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn formularioIngreso = new LogIn();
            formularioIngreso.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm formularioIngreso = new UserForm(UserForm.ALTA);
            formularioIngreso.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm formularioIngreso = new UserForm(UserForm.MODIFICAR);
            formularioIngreso.ShowDialog();
        }

        private void bajaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm formularioIngreso = new UserForm(UserForm.BAJA);
            formularioIngreso.ShowDialog();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList listadoDeUsuarios = new UserList();
            listadoDeUsuarios.ShowDialog();
        }

        private void ApSocial_Activated(object sender, EventArgs e)
        {
            this.reloadMenu();
        }

        private void reloadMenu()
        {
            if(controladora.existeUsuario(Session.IdUsuarioLogueado)){
                amistadesToolStripMenuItem.Enabled = true;
                publicacionesToolStripMenuItem.Enabled = true;
                modificarUsuarioMenuItem.Enabled = true;
                bajaUsuarioMenuItem.Enabled = true;
            }
        }

        private void solictarNuevaAmistadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmistadSolicitud SolicitudDeAmistad = new AmistadSolicitud();
            SolicitudDeAmistad.ShowDialog();
        }

        private void verListaDeAmigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FriendList ListadoDeAmigos = new FriendList();
            ListadoDeAmigos.ShowDialog();
        }

        private void responderSolicitudesDeAmistadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitudesList SolicitudDeAmistad = new SolicitudesList();
            try {
                SolicitudDeAmistad.ShowDialog();
            } catch {
                //Do nothing
            }
        }

        private void verMuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muro miMuro = new Muro();
            miMuro.ShowDialog();
        }

        private void nuevoAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abAlbum unAlbum = new abAlbum();
            unAlbum.ShowDialog();
        }

        private void nuevoEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoEstado formNuevoEstado = new NuevoEstado();
            formNuevoEstado.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercaDe acercade = new acercaDe();
            acercade.ShowDialog();
        }
        public void deshabilitarMenu(MenuStrip m) {
            amistadesToolStripMenuItem.Enabled = false;
            publicacionesToolStripMenuItem.Enabled = false;
            modificarUsuarioMenuItem.Enabled = false;
            bajaUsuarioMenuItem.Enabled = false;
        }

        private void desloguearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.IdUsuarioLogueado=0;
            deshabilitarMenu(menuStrip);
        }


    }
}
