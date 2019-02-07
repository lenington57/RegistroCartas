using BLL;
using Entities;
using RegistroCartas.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroCartas.Registros
{
    public partial class CartaWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            if (!Page.IsPostBack)
            {
                LlenarCombo();
            }
        }

        private void LlenarCombo()
        {
            Repositorio<Destinatario> repositorio = new Repositorio<Destinatario>();
            destinatarioDropDownList.DataSource = repositorio.GetList(c => true);
            destinatarioDropDownList.DataValueField = "DestinatarioId";
            destinatarioDropDownList.DataTextField = "Nombres";
            destinatarioDropDownList.DataBind();
        }

        public Carta LlenarClase()
        {
            Carta carta = new Carta();

            carta.CartaId = Utils.ToInt(cartaIdTextBox.Text);
            carta.Fecha = Utils.ToDateTime(fechaTextBox.Text).Date;
            carta.DestinatarioId = Utils.ToInt(destinatarioDropDownList.SelectedValue);
            carta.Cuerpo = cuerpoTextBox.Text;

            return carta;
        }

        protected void Limpiar()
        {
            cartaIdTextBox.Text = "0";
            fechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            destinatarioDropDownList.SelectedIndex = 0;
            cuerpoTextBox.Text = "";
        }

        public void LlenarCampos(Carta carta)
        {
            Limpiar();
            cartaIdTextBox.Text = carta.CartaId.ToString();
            fechaTextBox.Text = carta.Fecha.ToString("yyyy-MM-dd");
            destinatarioDropDownList.SelectedIndex = carta.DestinatarioId;
            cuerpoTextBox.Text = carta.Cuerpo;
        }


        //No funcionables
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void guadarButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            
        }
        //No Funcionables


        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            RepositorioCarta repositorio = new RepositorioCarta();

            var carta = repositorio.Buscar(Utils.ToInt(cartaIdTextBox.Text));
            if (carta != null)
            {
                LlenarCampos(carta);
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
            }
            else
            {
                Limpiar();
                Utils.ShowToastr(this, "No Hay Resultado", "Error", "error");
            }
        }

        protected void nuevoButton_Click1(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void guadarButton_Click1(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioCarta repositorio = new RepositorioCarta();
            Carta carta = new Carta();

            carta = LlenarClase();

            if (cartaIdTextBox.Text == "0")
            {
                paso = repositorio.Guardar(carta);
                Utils.ShowToastr(this, "Guardado", "Exito", "success");
                Limpiar();
            }
            else
            {
                RepositorioCarta repository = new RepositorioCarta();
                int id = Utils.ToInt(cartaIdTextBox.Text);
                carta = repository.Buscar(id);

                if (carta != null)
                {
                    paso = repository.Modificar(LlenarClase());
                    Utils.ShowToastr(this, "Modificado", "Exito", "success");
                }
                else
                    Utils.ShowToastr(this, "Id no existe", "Error", "error");
            }

            if (paso)
            {
                Limpiar();
            }
            else
                Utils.ShowToastr(this, "No se pudo guardar", "Error", "error");
        }

        protected void eliminarButton_Click1(object sender, EventArgs e)
        {
            RepositorioCarta repositorio = new RepositorioCarta();
            int id = Utils.ToInt(cartaIdTextBox.Text);

            var deposito = repositorio.Buscar(id);

            if (deposito != null)
            {
                if (repositorio.Eliminar(id))
                {
                    Utils.ShowToastr(this, "Eliminado", "Exito", "success");
                    Limpiar();
                }
                else
                    Utils.ShowToastr(this, "No se pudo eliminar", "Error", "error");
            }
            else
                Utils.ShowToastr(this, "No existe", "Error", "error");
        }
    }
}