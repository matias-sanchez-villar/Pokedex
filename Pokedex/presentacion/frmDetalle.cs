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
            frmDetalle FrmDetalle = new frmDetalle();
            FrmDetalle.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            try
            {
                /*
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.URLImagen = txtURLimgane.Text;
                pokemon.Numero = (int)numNumero.Value;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
                */
                pokemonNegocio.Agregar(pokemon);

                MessageBox.Show("Agregado sin problemas");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
