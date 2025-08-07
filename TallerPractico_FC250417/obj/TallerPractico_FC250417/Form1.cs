namespace TallerPractico_FC250417
{
    public partial class Estudiantes : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private int edit_indice = -1;
        

        private void actualizarGrid()
        {
            dgbestudiantes.DataSource = null;
            dgbestudiantes.DataSource = estudiantes;
        }

        private void limpiar()
        {
            txtnombape.Clear();
            txtcarrera.Clear();
            txtmateria.Clear();
            txtnota.Clear();
        }
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

        }

        private void txtcarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void dgbestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow seleccion = dgbestudiantes.SelectedRows[0];
                int not = dgbestudiantes.Rows.IndexOf(seleccion);
                edit_indice = not;

                Estudiante est = estudiantes[not];

                txtnombape.Text = est.NomApe;
                txtcarrera.Text = est.Carrera;
                txtmateria.Text = est.Materia;
                txtnota.Text = est.Promedio;             
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            est.NomApe = txtnombape.Text;
            est.Carrera = txtcarrera.Text;
            est.Materia = txtmateria.Text;
            est.Promedio = txtnota.Text;
            


            if (edit_indice > -1)
            {
                estudiantes[edit_indice] = est;
                edit_indice = -1;
            }
            else
            {
                estudiantes.Add(est);
            }
            actualizarGrid();
            limpiar();
        
        }
    }
}