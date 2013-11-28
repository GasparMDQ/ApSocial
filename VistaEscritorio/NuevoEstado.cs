using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Estado;

namespace VistaEscritorio
{
    public partial class NuevoEstado : Form
    {
        EstadoController controladoraEstados = new EstadoController();
        string urlFoto = null;
        public NuevoEstado()
        {
            InitializeComponent();
        }


        private void guardarEstadoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (mensajeTXT.Text == "" && urlFoto == null)
                {
                    MessageBox.Show("estado sin datos ingrese foto o mensaje a compartir");
                }
                else
                {
                    controladoraEstados.nuevoEstado(Session.IdUsuarioLogueado, mensajeTXT.Text, urlFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo cargar el estado", ex.Message);
            }
        }
    }
}
