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
    public partial class DestinatarioWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            destinatarioIdTextBox.Text = "0";
            fechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Limpiar()
        {
            destinatarioIdTextBox.Text = "0";
            fechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            nombresTextBox.Text = "";
            cantCartasTextBox.Text = "0";
        }

        private Destinatario LlenaClase()
        {
            Destinatario destinatario = new Destinatario();
            destinatario.DestinatarioId = Utils.ToInt(destinatarioIdTextBox.Text);
            destinatario.Fecha = Utils.ToDateTime(fechaTextBox.Text);
            destinatario.Nombres = nombresTextBox.Text;
            destinatario.CantidadCartas = Utils.ToInt(cantCartasTextBox.Text);

            return destinatario;
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Destinatario> repositorio = new Repositorio<Destinatario>();
            int id = Utils.ToInt(destinatarioIdTextBox.Text);
            var destinatario = repositorio.Buscar(id);

            if (destinatario != null)
            {
                fechaTextBox.Text = destinatario.Fecha.ToString();
                nombresTextBox.Text = destinatario.Nombres;
                cantCartasTextBox.Text = destinatario.CantidadCartas.ToString();
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
            }
            else
                Utils.ShowToastr(this, "No existe", "Error", "error");
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void guadarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Destinatario> repositorio = new Repositorio<Destinatario>();
            Destinatario destinatario = new Destinatario();

            bool paso = false;
            destinatario = LlenaClase();

            int id = Utils.ToInt(destinatarioIdTextBox.Text);

            if (id == 0)
            {
                paso = repositorio.Guardar(destinatario);
                Utils.ShowToastr(this, "Guardado", "Exito", "success");
            }
            else
            {
                Repositorio<Destinatario> repository = new Repositorio<Destinatario>();
                int ids = Utils.ToInt(destinatarioIdTextBox.Text);
                destinatario = repository.Buscar(ids);
                if (destinatario != null)
                {
                    paso = repositorio.Modificar(LlenaClase());
                    Utils.ShowToastr(this, "Modificado", "Exito", "success");
                }
                else
                    Utils.ShowToastr(this, "No existe", "Error", "error");
            }

            if (paso)
            {
                Limpiar();
            }
            else
                Utils.ShowToastr(this, "No se pudo guardar", "Error", "error");
        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Destinatario> repositorio = new Repositorio<Destinatario>();
            int id = Utils.ToInt(destinatarioIdTextBox.Text);
            var destinatario = repositorio.Buscar(id);
            bool paso = false;

            if (destinatario != null)
            {
                paso = repositorio.Eliminar(id);
                if(paso)
                    Utils.ShowToastr(this, "Eliminado", "Exito", "success");
                else
                    Utils.ShowToastr(this, "No se pudo eliminar", "Error", "error");
            }
            else
                Utils.ShowToastr(this, "No existe", "Error", "error");
        }
    }
}