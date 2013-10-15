using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Usuarios;

namespace VistaEscritorio
{
    public partial class AmistadSolicitud : Form
    {
        private AmistadesController controladoraAmistades = new AmistadesController();

        public AmistadSolicitud()
        {
            InitializeComponent();
        }

        private void Solicitud_Click(object sender, EventArgs e)
        {
            try {
                
                this.controladoraAmistades.solicitarAmistad(Session.IdUsuarioLogueado, SolicitarBox.Text);
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SolicitarBox.Text = "";
            }

        }
    }
}
