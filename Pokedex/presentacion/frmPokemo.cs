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
            Text = "Pokemon - Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.URLImagen = txtURLimgane.Text;
                pokemon.Numero = (int)numNumero.Value;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;


                if(pokemon.ID == 0)
                {
                    pokemonNegocio.Agregar(pokemon);
                    MessageBox.Show("Agregado sin problemas");
                }
                else
                {
                    pokemonNegocio.Modificar(pokemon);
                    MessageBox.Show("modificado sin problema");
                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmPokemo_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboDebilidad.DataSource = elementoNegocio.Listar();
                cboDebilidad.ValueMember = "ID";
                cboDebilidad.DisplayMember = "Nombre";

                cboTipo.DataSource = elementoNegocio.Listar();
                cboTipo.ValueMember = "ID";
                cboTipo.DisplayMember = "Nombre";


                if (pokemon != null)
                {
                    txtNombre.Text += pokemon.Nombre;
                    numNumero.Value = pokemon.Numero;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtURLimgane.Text = pokemon.URLImagen;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.ID;
                    cboTipo.SelectedValue = pokemon.Tipo.ID;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
