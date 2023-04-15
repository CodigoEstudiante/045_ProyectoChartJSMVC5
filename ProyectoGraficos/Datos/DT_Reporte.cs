using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;


//************ IMPORTANTE AÑADIR ESTAS REFERENCIAS ******************************
using System.Data.SqlClient;
using System.Data;
using ProyectoGraficos.Models;


namespace ProyectoGraficos.Datos
{
    public class DT_Reporte
    {

        public List<ReporteVenta> RetornarVentas()
        {
            List<ReporteVenta> objLista = new List<ReporteVenta>();

            //Data Source=;Initial Catalog= ; User ID= ; Password=
            using (SqlConnection oconexion = new SqlConnection("Data Source=(local); Initial Catalog=AdventureWorks2014; Integrated Security=True"))
            {
                string query = "SP_RetornarVentas123";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteVenta() {
                            mes = dr["mes"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }


        public List<ReporteProducto> RetornarProductos()
        {
            List<ReporteProducto> objLista = new List<ReporteProducto>();

            //Data Source=;Initial Catalog= ; User ID= ; Password=
            using (SqlConnection oconexion = new SqlConnection("Data Source=(local); Initial Catalog=AdventureWorks2014; Integrated Security=True"))
            {
                string query = "SP_RetornarProductos123";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteProducto()
                        {
                            producto = dr["producto"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }

    }
}