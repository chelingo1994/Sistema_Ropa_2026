using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aprovee {

		#region Campos
            private bool _capvestpro;
            private int _capvnuidtr;
            private string _papvcodpro;
            private string _capvdirecc;
            private string _fapvcodper;
            private string _capvtelefo;
            private string _capvrazsoc;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool capvestpro
            { 
                get{ return this._capvestpro;}
                set{ this._capvestpro = value;}
            } 
		    public int capvnuidtr
            { 
                get{ return this._capvnuidtr;}
                set{ this._capvnuidtr = value;}
            } 
		    public string papvcodpro
            { 
                get{ return this._papvcodpro;}
                set{ this._papvcodpro = value;}
            } 
		    public string capvdirecc
            { 
                get{ return this._capvdirecc;}
                set{ this._capvdirecc = value;}
            } 
		    public string fapvcodper
            { 
                get{ return this._fapvcodper;}
                set{ this._fapvcodper = value;}
            } 
		    public string capvtelefo
            { 
                get{ return this._capvtelefo;}
                set{ this._capvtelefo = value;}
            } 
		    public string capvrazsoc
            { 
                get{ return this._capvrazsoc;}
                set{ this._capvrazsoc = value;}
            } 
        #endregion

        #region Constructor
            public aprovee()
            { 
		        this._capvestpro = true;
		        this._capvnuidtr = 0;
		        this._papvcodpro = "";
		        this._capvdirecc = "";
		        this._fapvcodper = "";
		        this._capvtelefo = "";
		        this._capvrazsoc = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capvestpro," +
                                     "capvnuidtr," +
                                     "papvcodpro," +
                                     "capvdirecc," +
                                     "fapvcodper," +
                                     "capvtelefo," +
                                     "capvrazsoc " + 
                             "from aprovee " +
                             "where "+
                                    "papvcodpro = @papvcodpro";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capvestpro=ResultadoConsulta.GetBoolean(0);
                    this._capvnuidtr=ResultadoConsulta.GetInt32(1);
                    this._papvcodpro=ResultadoConsulta.GetString(2);
                    this._capvdirecc=ResultadoConsulta.GetString(3);
                    this._fapvcodper=ResultadoConsulta.GetString(4);
                    this._capvtelefo=ResultadoConsulta.GetString(5);
                    this._capvrazsoc=ResultadoConsulta.GetString(6);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }
            public bool VerificarExistencia()
            { 
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capvestpro," +
                                     "capvnuidtr," +
                                     "papvcodpro," +
                                     "capvdirecc," +
                                     "fapvcodper," +
                                     "capvtelefo," +
                                     "capvrazsoc " + 
                             "from aprovee " +
                             "where " +
                                    "papvcodpro = @papvcodpro";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.HasRows)
                {
                this.Conexion.Desconectar();

                    return true;
                }
                else 
                { 

                this.Conexion.Desconectar();
                    return false;
                } 
            } 
            public bool Grabar()
            { 
                if (this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "insert into aprovee (" +
                                                       "capvestpro," +
                                                       "capvnuidtr," +
                                                       "papvcodpro," +
                                                       "capvdirecc," +
                                                       "fapvcodper," +
                                                       "capvtelefo," +
                                                       "capvrazsoc" +
                                                       ") " +
	                             "values (" + 
                                          "@capvestpro," +
                                          "@capvnuidtr," +
                                          "@papvcodpro," +
                                          "@capvdirecc," +
                                          "@fapvcodper," +
                                          "@capvtelefo," +
                                          "@capvrazsoc" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capvestpro",this._capvestpro);
                    this.Conexion.AsignarParametroEntero("@capvnuidtr",this._capvnuidtr);
                    this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);
                    this.Conexion.AsignarParametroCadena("@capvdirecc",this._capvdirecc);
                    this.Conexion.AsignarParametroCadena("@fapvcodper",this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvtelefo",this._capvtelefo);
                    this.Conexion.AsignarParametroCadena("@capvrazsoc",this._capvrazsoc);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            } 
            public bool Modificar()
            { 
                if (!this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "update aprovee set " +
                                                     "capvestpro = @capvestpro, " +
                                                     "capvnuidtr = @capvnuidtr, " +
                                                     "capvdirecc = @capvdirecc, " +
                                                     "fapvcodper = @fapvcodper, " +
                                                     "capvtelefo = @capvtelefo, " +
                                                     "capvrazsoc = @capvrazsoc" +
                                 " where " +
                                        "papvcodpro = @papvcodpro";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@capvestpro",this._capvestpro);
                    this.Conexion.AsignarParametroEntero("@capvnuidtr",this._capvnuidtr);
                    this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);
                    this.Conexion.AsignarParametroCadena("@capvdirecc",this._capvdirecc);
                    this.Conexion.AsignarParametroCadena("@fapvcodper",this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvtelefo",this._capvtelefo);
                    this.Conexion.AsignarParametroCadena("@capvrazsoc",this._capvrazsoc);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aprovee> Lista(string where)
            { 
                List<aprovee> ListaResultado = new List<aprovee>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capvestpro," +
                                     "capvnuidtr," +
                                     "papvcodpro," +
                                     "capvdirecc," +
                                     "fapvcodper," +
                                     "capvtelefo," +
                                     "capvrazsoc " + 
                             "from aprovee " ;
 
                if (where.Replace(" ", "") != "")
                {
                    sql+= "where " + where;
                }

 
                this.Conexion.PrepararComando(sql); 
                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta!=null)
                {
                    while (ResultadoConsulta.Read())
                    {
                          aprovee Auxiliar = new aprovee();
                          Auxiliar.capvestpro = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.capvnuidtr = ResultadoConsulta.GetInt32(1);
                          Auxiliar.papvcodpro = ResultadoConsulta.GetString(2);
                          Auxiliar.capvdirecc = ResultadoConsulta.GetString(3);
                          Auxiliar.fapvcodper = ResultadoConsulta.GetString(4);
                          Auxiliar.capvtelefo = ResultadoConsulta.GetString(5);
                          Auxiliar.capvrazsoc = ResultadoConsulta.GetString(6);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

