using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
	public class LibrosDAO
	{
		public bool InsertLibro(Libro librito)
		{
			//Conectarme
			if (Conexion.Conectar())
			{
				try
				{
					//Crear la sentencia a ejecutar (INSERT)
					String select = @"INSERT INTO Libros(ISBN, TITULO, NUM_EDICION, AÑO_PUBLICACION, AUTORES, 
                    PAIS_PUBLICACION, SINOPSIS, CARRERA, MATERIA) VALUES
                    (@ISBN, @TITULO, @NUM_EDICION, @AÑO_PUBLICACION, @AUTORES, @PAIS_PUBLICACION, @SINOPSIS, @CARRERA, @MATERIA);";
					SqlCommand sentencia = new SqlCommand();
					sentencia.CommandText = select;
					sentencia.Connection = Conexion.conexion;

					sentencia.Parameters.AddWithValue("@ISBN", librito.isbn);
					sentencia.Parameters.AddWithValue("@TITULO", librito.titulo);
					sentencia.Parameters.AddWithValue("@NUM_EDICION", librito.edicion);
					sentencia.Parameters.AddWithValue("@AÑO_PUBLICACION", librito.anio);
					sentencia.Parameters.AddWithValue("@AUTORES", librito.autores);
					sentencia.Parameters.AddWithValue("@PAIS_PUBLICACION", librito.pais);
					sentencia.Parameters.AddWithValue("@SINOPSIS", librito.sinopsis);
					sentencia.Parameters.AddWithValue("@CARRERA", librito.carrera);
					sentencia.Parameters.AddWithValue("@MATERIA", librito.materia);

					//Ejercutar el comando 
					sentencia.ExecuteNonQuery();
					return true;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
				finally
				{
					Conexion.Desconectar();
				}
			}
			else
			{
				//Devolvemos un cero indicando que no se insertó nada
				return false;

			}

		}
		public List<Libro> getAll()
		{
			List<Libro> libritos = new List<Libro>();
			//Conectarme
			if (Conexion.Conectar())
			{
				try
				{
					//Crear la sentencia a ejecutar (SELECT)
					String select = @"SELECT * FROM Libros";
					//Definir un datatable para que sea llenado
					DataTable dt = new DataTable();
					//Crear el dataadapter
					SqlCommand sentencia = new SqlCommand(select);
					//Asignar los parámetros
					sentencia.Connection = Conexion.conexion;

					SqlDataAdapter da = new SqlDataAdapter(sentencia);

					//Llenar el datatable
					da.Fill(dt);
					//Revisar si hubo resultados
					/*
						ISBN VARCHAR(20),
						TITULO VARCHAR(100),
						NUM_EDICION INT,
						AÑO_PUBLICACION INT,
						AUTORES VARCHAR(100),
						PAIS_PUBLICACION VARCHAR(50),
						SINOPSIS TEXT,
						CARRERA VARCHAR(50),
						MATERIA VARCHAR(50)*/
					/*for (int i = 0; i < dt.Rows.Count; i++)
					{
						DataRow fila = dt.Rows[i];
						libritos.Add(new Libro()
						{
							id = Convert.ToInt32(fila["ID"]),
							isbn = fila["ISBN"].ToString(),
							titulo = fila["TITULO"].ToString(),
							edicion = Convert.ToInt32(fila["NUM_EDICION"]),
							anio = Convert.ToInt32(fila["AÑO_PUBLICACION"]),
							autores = fila["AUTORES"].ToString(),
							pais = fila["PAIS_PUBLICACION"].ToString(),
							sinopsis = fila["SINOPSIS"].ToString(),
							carrera = fila["CARRERA"].ToString(),
							materia = fila["MATERIA"].ToString()
						});

					}*/
                    if (dt.Rows.Count > 0)
                    {

                        foreach (DataRow fila in dt.Rows)
                        {
                            Libro book = new Libro()
                            {

                                id = Convert.ToInt32(fila["ID"]),
                                isbn = fila["ISBN"].ToString(),
                                titulo = fila["TITULO"].ToString(),
                                edicion = Convert.ToInt32(fila["NUM_EDICION"]),
                                anio = Convert.ToInt32(fila["AÑO_PUBLICACION"]),
                                autores = fila["AUTORES"].ToString(),
                                pais = fila["PAIS_PUBLICACION"].ToString(),
                                sinopsis = fila["SINOPSIS"].ToString(),
                                carrera = fila["CARRERA"].ToString(),
                                materia = fila["MATERIA"].ToString()


                            };
                            libritos.Add(book);
                        }


                    }

                    return libritos;
				}
				finally
				{
					Conexion.Desconectar();
				}
			}
			else
			{
				return null;
			}

		}
	}
}
