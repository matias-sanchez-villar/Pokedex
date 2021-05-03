using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Pokemon pokemon = null;
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            if (pokemon != null)
            {
                lblNombre.Text += pokemon.Nombre;
                lblTipo.Text += pokemon.Tipo;
                lblDeblidad.Text += pokemon.Debilidad;
                txtDescripcion.Text = (string)pokemon.Descripcion;
                pbxImagen.Load ((string)pokemon.URLImagen);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (pokemon != null)
            {
                frmPokemo modificar = new frmPokemo(this.pokemon);
                modificar.ShowDialog();
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            try
            {
                pokemonNegocio.Eliminar(pokemon.ID);
                MessageBox.Show("Eliminado sin problemas");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
