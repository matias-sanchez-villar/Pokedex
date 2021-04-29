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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPokemo FrmPokemos = new frmPokemo();
            FrmPokemos.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalle FrmDetalle = new frmDetalle();
            FrmDetalle.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();
            PokemonNegocio pokemonNegocio = new PokemonNegocio();

            try
            {
                listaPokemons = pokemonNegocio.Listar();

                dgvPokemons.DataSource = listaPokemons;

                dgvPokemons.Columns["Numero"].Visible = false;
                dgvPokemons.Columns["Ficha"].Visible = false;
                dgvPokemons.Columns["URLImagen"].Visible = false;
                dgvPokemons.Columns["Evolucion"].Visible = false;


                CargarImg(listaPokemons[0].URLImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarImg(string img)
        {
            pbxPokemon.Load(img);
        }

        private void dgvPokemons_MouseClick(object sender, MouseEventArgs e)
        {
            // Explicacion de seleccion, no va a ir acá-
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            CargarImg(seleccionado.URLImagen);
        }
    }
}
