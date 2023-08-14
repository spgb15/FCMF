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
    public partial class FormGanadoraReina : Form
    {
        private CD_connection conn = new CD_connection();
        public FormGanadoraReina()
        {
            InitializeComponent();
        }

        private void MostrarResultadosReina()
        {
            try
            {
                conn.AbrirConexion();

 
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

                                label2.Text = nombreGanadoraReina;
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

