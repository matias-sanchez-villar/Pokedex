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
            CargarGrilla();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            frmDetalle FrmDetalle = new frmDetalle(seleccionado);
            FrmDetalle.ShowDialog();
            CargarGrilla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            frmPokemo modificar = new frmPokemo(seleccionado);
            modificar.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            PokemonNegocio Eliminar = new PokemonNegocio();

            try
            {
                Eliminar.Eliminar(seleccionado.ID);
                MessageBox.Show("Pokemon Eliminado");
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Eliminar.Eliminar(seleccionado.ID);
        }
    }
}
