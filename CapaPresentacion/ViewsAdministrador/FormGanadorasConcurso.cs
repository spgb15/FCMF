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

namespace CapaPresentacion.ViewsEstudiante
{
    public partial class FormGanadorasConcurso : Form
    {
        private CD_connection conn = new CD_connection();
        public FormGanadorasConcurso()
        {
            InitializeComponent();
        }

        private void MostrarResultados()
        {
            try
            {
                conn.AbrirConexion();

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
                // Obtener los resultados de la votación de Reina de Facultad
                SqlCommand cmdReina = new SqlCommand("ObtenerVotacionReina");
                cmdReina.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmdReina.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Procesar los resultados y mostrarlos en la interfaz
                        while (reader.Read())
                        {
                            string nombreGanadoraReina = reader["nombre"].ToString();
                            string rutaFotoGanadoraReina = reader["ruta_foto"].ToString();

                            labelReina.Text = nombreGanadoraReina;
                            pictureBoxReina.Image = Image.FromFile(rutaFotoGanadoraReina);
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

