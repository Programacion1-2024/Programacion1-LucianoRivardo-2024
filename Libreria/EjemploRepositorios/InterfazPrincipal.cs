using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using EjemploRepositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class InterfazPrincipal : Form
    {
        private IAutorLogic _autorLogic;
        private IEditorialLogic _editorialLogic;
        private ILibroLogic _librosLogic;// Asegúrate de que esta variable se inicializa en el constructor

        public InterfazPrincipal(IAutorLogic autorLogic, IEditorialLogic editorialLogic, ILibroLogic libroLogic)
        {
            _autorLogic = autorLogic ?? throw new ArgumentNullException(nameof(autorLogic));
            _editorialLogic = editorialLogic;
            _librosLogic = libroLogic;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_editoriales_Click(object sender, EventArgs e)
        {



        }

        private void bt_libros_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ABMAutor autores = new ABMAutor(_autorLogic);

            // Mostrar el formulario como diálogo modal
            this.Hide(); // Oculta el formulario actual
            autores.ShowDialog(); // Cambia a modal
            this.Show(); // Muestra el formulario principal nuevamente después de cerrar el diálogo
        }

        private void bt_editoriales_Click_1(object sender, EventArgs e)
        {
            ABMEditorial editorial = new ABMEditorial(_editorialLogic);

            // Mostrar el formulario como diálogo modal
            this.Hide(); // Oculta el formulario actual
            editorial.ShowDialog(); // Cambia a modal
            this.Show(); // Muestra el formulario principal nuevamente después de cerrar el diálogo
        }

        private void bt_libros_Click_1(object sender, EventArgs e)
        {
            ABMLibro libros = new ABMLibro(_librosLogic);

            this.Hide();
            libros.ShowDialog(); // Cambia a modal
            this.Show();
        }
    }
}
