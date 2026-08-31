using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aclient {

		#region Campos
            private bool _caceestcli;
            private int _cacenuidtr;
            private string _pacecodcli;
            private string _cacedirecc;
            private string _facecodper;
            private string _cacetelefo;
            private string _cacerazsoc;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool caceestcli
            { 
                get{ return this._caceestcli;}
                set{ this._caceestcli = value;}
            } 
		    public int cacenuidtr
            { 
                get{ return this._cacenuidtr;}
                set{ this._cacenuidtr = value;}
            } 
		    public string pacecodcli
            { 
                get{ return this._pacecodcli;}
                set{ this._pacecodcli = value;}
            } 
		    public string cacedirecc
            { 
                get{ return this._cacedirecc;}
                set{ this._cacedirecc = value;}
            } 
		    public string facecodper
            { 
                get{ return this._facecodper;}
                set{ this._facecodper = value;}
            } 
		    public string cacetelefo
            { 
                get{ return this._cacetelefo;}
                set{ this._cacetelefo = value;}
            } 
		    public string cacerazsoc
            { 
                get{ return this._cacerazsoc;}
                set{ this._cacerazsoc = value;}
            } 
        #endregion

        #region Constructor
            public aclient()
            { 
		        this._caceestcli = true;
		        this._cacenuidtr = 0;
		        this._pacecodcli = "";
		        this._cacedirecc = "";
		        this._facecodper = "";
		        this._cacetelefo = "";
		        this._cacerazsoc = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "caceestcli," +
                                     "cacenuidtr," +
                                     "pacecodcli," +
                                     "cacedirecc," +
                                     "facecodper," +
                                     "cacetelefo," +
                                     "cacerazsoc " + 
                             "from aclient " +
                             "where "+
                                    "pacecodcli = @pacecodcli";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@pacecodcli",this._pacecodcli);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._caceestcli=ResultadoConsulta.GetBoolean(0);
                    this._cacenuidtr=ResultadoConsulta.GetInt32(1);
                    this._pacecodcli=ResultadoConsulta.GetString(2);
                    this._cacedirecc=ResultadoConsulta.GetString(3);
                    this._facecodper=ResultadoConsulta.GetString(4);
                    this._cacetelefo=ResultadoConsulta.GetString(5);
                    this._cacerazsoc=ResultadoConsulta.GetString(6);
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
                                     "caceestcli," +
                                     "cacenuidtr," +
                                     "pacecodcli," +
                                     "cacedirecc," +
                                     "facecodper," +
                                     "cacetelefo," +
                                     "cacerazsoc " + 
                             "from aclient " +
                             "where " +
                                    "pacecodcli = @pacecodcli";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@pacecodcli",this._pacecodcli);

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
			        string sql = "insert into aclient (" +
                                                       "caceestcli," +
                                                       "cacenuidtr," +
                                                       "pacecodcli," +
                                                       "cacedirecc," +
                                                       "facecodper," +
                                                       "cacetelefo," +
                                                       "cacerazsoc" +
                                                       ") " +
	                             "values (" + 
                                          "@caceestcli," +
                                          "@cacenuidtr," +
                                          "@pacecodcli," +
                                          "@cacedirecc," +
                                          "@facecodper," +
                                          "@cacetelefo," +
                                          "@cacerazsoc" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@caceestcli",this._caceestcli);
                    this.Conexion.AsignarParametroEntero("@cacenuidtr",this._cacenuidtr);
                    this.Conexion.AsignarParametroCadena("@pacecodcli",this._pacecodcli);
                    this.Conexion.AsignarParametroCadena("@cacedirecc",this._cacedirecc);
                    this.Conexion.AsignarParametroCadena("@facecodper",this._facecodper);
                    this.Conexion.AsignarParametroCadena("@cacetelefo",this._cacetelefo);
                    this.Conexion.AsignarParametroCadena("@cacerazsoc",this._cacerazsoc);

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
			        string sql = "update aclient set " +
                                                     "caceestcli = @caceestcli, " +
                                                     "cacenuidtr = @cacenuidtr, " +
                                                     "cacedirecc = @cacedirecc, " +
                                                     "facecodper = @facecodper, " +
                                                     "cacetelefo = @cacetelefo, " +
                                                     "cacerazsoc = @cacerazsoc" +
                                 " where " +
                                        "pacecodcli = @pacecodcli";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@caceestcli",this._caceestcli);
                    this.Conexion.AsignarParametroEntero("@cacenuidtr",this._cacenuidtr);
                    this.Conexion.AsignarParametroCadena("@pacecodcli",this._pacecodcli);
                    this.Conexion.AsignarParametroCadena("@cacedirecc",this._cacedirecc);
                    this.Conexion.AsignarParametroCadena("@facecodper",this._facecodper);
                    this.Conexion.AsignarParametroCadena("@cacetelefo",this._cacetelefo);
                    this.Conexion.AsignarParametroCadena("@cacerazsoc",this._cacerazsoc);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aclient> Lista(string where)
            { 
                List<aclient> ListaResultado = new List<aclient>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "caceestcli," +
                                     "cacenuidtr," +
                                     "pacecodcli," +
                                     "cacedirecc," +
                                     "facecodper," +
                                     "cacetelefo," +
                                     "cacerazsoc " + 
                             "from aclient " ;
 
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
                          aclient Auxiliar = new aclient();
                          Auxiliar.caceestcli = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.cacenuidtr = ResultadoConsulta.GetInt32(1);
                          Auxiliar.pacecodcli = ResultadoConsulta.GetString(2);
                          Auxiliar.cacedirecc = ResultadoConsulta.GetString(3);
                          Auxiliar.facecodper = ResultadoConsulta.GetString(4);
                          Auxiliar.cacetelefo = ResultadoConsulta.GetString(5);
                          Auxiliar.cacerazsoc = ResultadoConsulta.GetString(6);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

