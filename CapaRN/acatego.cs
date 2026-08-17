using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class acatego {

		#region Campos
            private bool _caceestcat;
            private string _pacecodcat;
            private string _cacenomcat;
            private string _cacedescat;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool caceestcat
            { 
                get{ return this._caceestcat;}
                set{ this._caceestcat = value;}
            } 
		    public string pacecodcat
            { 
                get{ return this._pacecodcat;}
                set{ this._pacecodcat = value;}
            } 
		    public string cacenomcat
            { 
                get{ return this._cacenomcat;}
                set{ this._cacenomcat = value;}
            } 
		    public string cacedescat
            { 
                get{ return this._cacedescat;}
                set{ this._cacedescat = value;}
            } 
        #endregion

        #region Constructor
            public acatego()
            { 
		        this._caceestcat = true;
		        this._pacecodcat = "";
		        this._cacenomcat = "";
		        this._cacedescat = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "caceestcat," +
                                     "pacecodcat," +
                                     "cacenomcat," +
                                     "cacedescat " + 
                             "from acatego " +
                             "where "+
                                    "pacecodcat = @pacecodcat";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@pacecodcat",this._pacecodcat);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._caceestcat=ResultadoConsulta.GetBoolean(0);
                    this._pacecodcat=ResultadoConsulta.GetString(1);
                    this._cacenomcat=ResultadoConsulta.GetString(2);
                    this._cacedescat=ResultadoConsulta.GetString(3);
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
                                     "caceestcat," +
                                     "pacecodcat," +
                                     "cacenomcat," +
                                     "cacedescat " + 
                             "from acatego " +
                             "where " +
                                    "pacecodcat = @pacecodcat";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@pacecodcat",this._pacecodcat);

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
			        string sql = "insert into acatego (" +
                                                       "caceestcat," +
                                                       "pacecodcat," +
                                                       "cacenomcat," +
                                                       "cacedescat" +
                                                       ") " +
	                             "values (" + 
                                          "@caceestcat," +
                                          "@pacecodcat," +
                                          "@cacenomcat," +
                                          "@cacedescat" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@caceestcat",this._caceestcat);
                    this.Conexion.AsignarParametroCadena("@pacecodcat",this._pacecodcat);
                    this.Conexion.AsignarParametroCadena("@cacenomcat",this._cacenomcat);
                    this.Conexion.AsignarParametroCadena("@cacedescat",this._cacedescat);

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
			        string sql = "update acatego set " +
                                                     "caceestcat = @caceestcat, " +
                                                     "cacenomcat = @cacenomcat, " +
                                                     "cacedescat = @cacedescat" +
                                 " where " +
                                        "pacecodcat = @pacecodcat";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@caceestcat",this._caceestcat);
                    this.Conexion.AsignarParametroCadena("@pacecodcat",this._pacecodcat);
                    this.Conexion.AsignarParametroCadena("@cacenomcat",this._cacenomcat);
                    this.Conexion.AsignarParametroCadena("@cacedescat",this._cacedescat);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<acatego> Lista(string where)
            { 
                List<acatego> ListaResultado = new List<acatego>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "caceestcat," +
                                     "pacecodcat," +
                                     "cacenomcat," +
                                     "cacedescat " + 
                             "from acatego " ;
 
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
                          acatego Auxiliar = new acatego();
                          Auxiliar.caceestcat = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.pacecodcat = ResultadoConsulta.GetString(1);
                          Auxiliar.cacenomcat = ResultadoConsulta.GetString(2);
                          Auxiliar.cacedescat = ResultadoConsulta.GetString(3);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

