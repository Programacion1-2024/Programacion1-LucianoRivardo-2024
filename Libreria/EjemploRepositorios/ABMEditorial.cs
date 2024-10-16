using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
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
    public partial class ABMEditorial : Form
    {
        private IEditorialLogic _editorialLogic;
        public ABMEditorial(IEditorialLogic editorialLogic)
        {
            _editorialLogic = editorialLogic ?? throw new ArgumentNullException(nameof(editorialLogic));
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void ABMEditorial_Load(object sender, EventArgs e)
        {
        }

        private void CargarListadoEditorial()
        {
            dgv_editoriales.DataSource = null;
            // Carga el listado de editoriales a la DataGridView
            List<Editorial> editoriales = _editorialLogic.ObtenerEditorilesParaListado();

            if (editoriales == null || editoriales.Count == 0)
            {
                MessageBox.Show("No se encontraron editoriales.");
            }
            else
            {
                dgv_editoriales.DataSource = editoriales;
            }
        }
        private void ConfigureDataGridView()
        {
            dgv_editoriales.AutoGenerateColumns = false; // Desactiva la autogeneración de columnas

            dgv_editoriales.Columns.Clear(); // Limpiar las columnas previamente configuradas

            dgv_editoriales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdEditorial", // Debe coincidir con la propiedad de la entidad
                HeaderText = "ID Editorial",
                Name = "IdEditorial" // Asegúrate de establecer el nombre también
            });
            dgv_editoriales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            dgv_editoriales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Contacto",
                HeaderText = "Contacto"
            });
            dgv_editoriales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Dirección"
            });

            // Agregar botón de eliminar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_editoriales.Columns.Add(deleteButtonColumn);

            CargarListadoEditorial(); // Cargar los datos después de configurar las columnas

            DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
            modificarButtonColumn.Name = "btnModificarColumna";
            modificarButtonColumn.HeaderText = "";
            modificarButtonColumn.Text = "Modificar";
            modificarButtonColumn.UseColumnTextForButtonValue = true;
            dgv_editoriales.Columns.Add(modificarButtonColumn);
            CargarListadoEditorial();
            modificarButtonColumn.DisplayIndex = dgv_editoriales.Columns.Count - 1;

            dgv_editoriales.CellClick += dgv_editoriales_CellClick;
        }



        private void dgv_editoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la fila es válida
            {
                // Verifica si la columna clickeada es el botón de eliminar
                if (e.ColumnIndex == dgv_editoriales.Columns["btnEliminarColumna"].Index)
                {
                    // Verifica que la columna "IdEditorial" existe
                    if (dgv_editoriales.Columns.Contains("IdEditorial"))
                    {
                        string editorialId = dgv_editoriales.Rows[e.RowIndex].Cells["IdEditorial"].Value.ToString();
                        _editorialLogic.BajaEditorial(editorialId);
                        CargarListadoEditorial();
                    }
                }
                if (e.ColumnIndex == dgv_editoriales.Columns["btnModificarColumna"].Index)
                {
                    // Verifica que la columna "IdEditorial" existe
                    if (dgv_editoriales.Columns.Contains("IdEditorial"))
                    {
                        // Captura el IdEditorial
                        string editorialId = dgv_editoriales.Rows[e.RowIndex].Cells["IdEditorial"].Value.ToString();

                        // Carga los datos de la editorial seleccionada en los TextBox
                        CargarDatosParaModificar(editorialId);
                    }
                }

            }
            
        }
        private void CargarDatosParaModificar(string editorialId)
        {
            // Obtén la editorial utilizando la lógica
            var editorial = _editorialLogic.ObtenerEditorialPorId(editorialId); // Asegúrate de que este método exista en tu lógica

            if (editorial != null)
            {
                // Carga los datos en los TextBox
                txtId.Text = editorial.IdEditorial.ToString(); // Asegúrate de que esta propiedad exista
                txtNombre.Text = editorial.Nombre;
                txtContacto.Text = editorial.Contacto;
                txtDireccion.Text = editorial.Direccion;

                // Aquí podrías realizar la acción para mostrar la pestaña de modificación
                // Si tienes diferentes pestañas o controles de visualización
                // por ejemplo:
                tabControl1.SelectedTab = tabModificar; // Cambia 'tabModificar' al nombre de tu tab
            }
            else
            {
                MessageBox.Show("No se encontró la editorial.");
            }
        }

        private void bt_agregar_Click(object sender, EventArgs e)
            {
                // Captura los datos de los TextBox
                string nombre = txt_nombre.Text.Trim();
                string contacto = txt_contacto.Text.Trim();
                string direccion = txt_direccion.Text.Trim();

                try
                {
                    // Llama a la lógica para agregar una nueva editorial
                    _editorialLogic.AltaEditorial(nombre, contacto, direccion);
                    MessageBox.Show("La editorial se ha registrado con éxito.");

                    // Limpia los campos después de agregar
                    txt_contacto.Clear();
                    txt_direccion.Clear();
                    txt_nombre.Clear();
                CargarListadoEditorial();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btModificar_Click(object sender, EventArgs e)
            {
                // Captura los datos de los TextBox para modificar la editorial
                string id = txtId.Text;
                string nombre = txtNombre.Text;
                string contacto = txtContacto.Text;
                string direccion = txtDireccion.Text;

                try
                {
                    // Llama a la lógica para modificar la editorial
                    _editorialLogic.ModificarEditorial(id, nombre, contacto, direccion);
                    MessageBox.Show("La editorial se ha actualizado con éxito.");

                    // Limpia los campos después de la actualización
                    txtId.Clear();
                    txtNombre.Clear();
                    txtContacto.Clear();
                    txtDireccion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
//    public partial class ABMEditorial : Form
//    {
//        private IEditorialLogic _editorialLogic;
//        public ABMEditorial(IEditorialLogic editorialLogic)
//        {
//            _editorialLogic = editorialLogic;
//            InitializeComponent();
//        }
//        private void ABMAutor_Load(object sender, EventArgs e)
//        {
//            ConfigureDataGridView();
//        }
//        private void ConfigureDataGridView()
//        {
//            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
//            deleteButtonColumn.Name = "btnEliminarColumna";
//            deleteButtonColumn.HeaderText = "";
//            deleteButtonColumn.Text = "Eliminar";
//            deleteButtonColumn.UseColumnTextForButtonValue = true;
//            dgv_editoriales.Columns.Add(deleteButtonColumn);
//            CargarListadoEditorial();
//            deleteButtonColumn.DisplayIndex = dgv_editoriales.Columns.Count - 1;

//            dgv_editoriales.CellClick += dgv_editoriales_CellClick;
//        }

//        private void dgv_editoriales_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.ColumnIndex == dgv_editoriales.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
//            {
//                string editorialId = dgv_editoriales.Rows[e.RowIndex].Cells["IdEditorial"].Value.ToString();

//                _editorialLogic.BajaEditorial(editorialId);
//                CargarListadoEditorial();
//            }
//        }
//        private void CargarListadoEditorial()
//        {
//            List<dynamic> autors = _editorialLogic.ObtenerEditorilesParaListado();
//            dgv_editoriales.DataSource = autors;
//        }
//        private void bt_agregar_Click(object sender, EventArgs e)
//        {
//            string nombre = txt_nombre.Text.Trim();
//            string contacto = txt_contacto.Text.Trim();
//            string direccion = txt_direccion.Text.Trim();
//            try
//            {
//                _editorialLogic.AltaEditorial(nombre, contacto, direccion);
//                MessageBox.Show("El autor se ha registrado con éxito.");
//                txt_contacto.Clear();
//                txt_direccion.Clear();
//                txt_nombre.Clear();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }

//        private void btModificar_Click(object sender, EventArgs e)
//        {
//            string id = txtId.Text;
//            string nombre = txtNombre.Text;
//            string contacto = txtContacto.Text;
//            string direccion = txtDireccion.Text;


//            try
//            {
//                _editorialLogic.ModificarEditorial(id, nombre, contacto, direccion);
//                MessageBox.Show("El autor se ha actualizado con éxito.");

//                txtId.Clear();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void tabPage3_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
