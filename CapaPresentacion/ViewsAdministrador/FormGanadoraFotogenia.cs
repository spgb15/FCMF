using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsAdministrador
{
    public partial class FormGanadoraFotogenia : Form
    {
        private CD_connection conn = new CD_connection();
        public FormGanadoraFotogenia()
        {
            InitializeComponent();
        }

        private void MostrarResultadoFotogenia()
        {
            try
            {
                // Obtener los resultados de la votación de Fotogenia
                SqlCommand cmdFotogenia = new SqlCommand("ObtenerVotacionFotogenia");
                cmdFotogenia.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmdFotogenia.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Procesar los resultados y mostrarlos en la interfaz
                        while (reader.Read())
                        {
                            string nombreGanadoraFotogenia = reader["nombre"].ToString();
                            string rutaFotoGanadoraFotogenia = reader["ruta_foto"].ToString();

                            labelFotogenia.Text = nombreGanadoraFotogenia;
                            pictureBoxFotogenia.Image = Image.FromFile(rutaFotoGanadoraFotogenia);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
