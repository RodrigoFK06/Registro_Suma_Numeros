using System.Data.SqlClient;
using System.Windows.Forms;

namespace Caso2_Registro_Suma_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnRegistrar_Sumar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=TONY; database=bdSumaNumeros; integrated security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    float num1 = Convert.ToSingle(txtNum1.Text);
                    float num2 = Convert.ToSingle(txtNum2.Text);
                    float suma = num1 + num2;

                    string query = "INSERT INTO numeros(num1, num2, suma) VALUES (@num1, @num2, @suma)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@num1", num1);
                        command.Parameters.AddWithValue("@num2", num2);
                        command.Parameters.AddWithValue("@suma", suma);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos registrados y sumados correctamente");
                    txtNum1.Text = "";
                    txtNum2.Text = "";

                   // MostrarDatosEnDataGridView(); // Actualiza la visualización
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=TONY; database=bdSumaNumeros; integrated security=true";
            string query = "SELECT CAST(num1 AS decimal(18, 2)) AS num1, CAST(num2 AS decimal(18, 2)) AS num2, CAST(suma AS decimal(18, 2)) AS suma FROM numeros";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                dataListado.DataSource = dataTable; // Asigna los datos al DataGridView
            }
        }
    }
}
