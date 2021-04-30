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
    public partial class frmPokemo : Form
    {
        private Pokemon pokemon= null;
        public frmPokemo()
        {
            InitializeComponent();
        }

        public frmPokemo(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            try
            {
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.URLImagen = txtURLimgane.Text;
                pokemon.Numero = (int)numNumero.Value;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                pokemonNegocio.Agregar(pokemon);

                MessageBox.Show("Agregado sin problemas");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmPokemo_Load(object sender, EventArgs e)
        {
            if (pokemon != null)
            {
                txtNombre.Text += pokemon.Nombre;
                numNumero.Value = pokemon.Numero;
                txtDescripcion.Text = pokemon.Descripcion;
                txtURLimgane.Text = pokemon.URLImagen;
                cboTipo.Text += pokemon.Tipo;
                cboDebilidad.Text += pokemon.Debilidad;
            }

            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.Listar();
                cboDebilidad.DataSource = elementoNegocio.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
