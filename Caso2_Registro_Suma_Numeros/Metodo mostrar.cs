using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2_Registro_Suma_Numeros
{
    internal class Metodo_mostrar
    {
       /* private void btnMostrar_Click(object sender, EventArgs e)
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
        }*/
    }
}
