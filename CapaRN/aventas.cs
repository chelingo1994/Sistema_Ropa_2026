using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aventas {

		#region Campos
            private DateTime _cavtfechor;
            private decimal _cavtmontot;
            private bool _cavtestven;
            private DateTime _cavtfeccre;
            private DateTime _cavtfecmod;
            private string _favtcodcli;
            private string _cavtobserv;
            private string _pavtcodven;
            private string _favtcouscr;
            private string _favtcousmo;
            private string _mensajeError = "";
            //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public string mensajeError
        {
            get { return this._mensajeError; }
        }
        public DateTime cavtfechor
            { 
                get{ return this._cavtfechor;}
                set{ this._cavtfechor = value;}
            } 
		    public decimal cavtmontot
            { 
                get{ return this._cavtmontot;}
                set{ this._cavtmontot = value;}
            } 
		    public bool cavtestven
            { 
                get{ return this._cavtestven;}
                set{ this._cavtestven = value;}
            } 
		    public DateTime cavtfeccre
            { 
                get{ return this._cavtfeccre;}
                set{ this._cavtfeccre = value;}
            } 
		    public DateTime cavtfecmod
            { 
                get{ return this._cavtfecmod;}
                set{ this._cavtfecmod = value;}
            } 
		    public string favtcodcli
            { 
                get{ return this._favtcodcli;}
                set{ this._favtcodcli = value;}
            } 
		    public string cavtobserv
            { 
                get{ return this._cavtobserv;}
                set{ this._cavtobserv = value;}
            } 
		    public string pavtcodven
            { 
                get{ return this._pavtcodven;}
                set{ this._pavtcodven = value;}
            } 
		    public string favtcouscr
            { 
                get{ return this._favtcouscr;}
                set{ this._favtcouscr = value;}
            } 
		    public string favtcousmo
            { 
                get{ return this._favtcousmo;}
                set{ this._favtcousmo = value;}
            } 
        #endregion

        #region Constructor
            public aventas()
            { 
		        this._cavtfechor = DateTime.Now;
		        this._cavtmontot = 0;
		        this._cavtestven = true;
		        this._cavtfeccre = DateTime.Now;
		        this._cavtfecmod = DateTime.Now;
		        this._favtcodcli = "";
		        this._cavtobserv = "";
		        this._pavtcodven = "";
		        this._favtcouscr = "";
		        this._favtcousmo = "";
                this._mensajeError = "";
            this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "cavtfechor," +
                                     "cavtmontot," +
                                     "cavtestven," +
                                     "cavtfeccre," +
                                     "cavtfecmod," +
                                     "favtcodcli," +
                                     "cavtobserv," +
                                     "pavtcodven," +
                                     "favtcouscr," +
                                     "favtcousmo " + 
                             "from aventas " +
                             "where "+
                                    "pavtcodven = @pavtcodven";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@pavtcodven",this._pavtcodven);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._cavtfechor=ResultadoConsulta.GetDateTime(0);
                    this._cavtmontot=ResultadoConsulta.GetDecimal(1);
                    this._cavtestven=ResultadoConsulta.GetBoolean(2);
                    this._cavtfeccre=ResultadoConsulta.GetDateTime(3);
                    this._cavtfecmod=ResultadoConsulta.GetDateTime(4);
                    this._favtcodcli=ResultadoConsulta.GetString(5);
                    this._cavtobserv=ResultadoConsulta.GetString(6);
                    this._pavtcodven=ResultadoConsulta.GetString(7);
                    this._favtcouscr=ResultadoConsulta.GetString(8);
                    this._favtcousmo=ResultadoConsulta.GetString(9);
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
                                     "cavtfechor," +
                                     "cavtmontot," +
                                     "cavtestven," +
                                     "cavtfeccre," +
                                     "cavtfecmod," +
                                     "favtcodcli," +
                                     "cavtobserv," +
                                     "pavtcodven," +
                                     "favtcouscr," +
                                     "favtcousmo " + 
                             "from aventas " +
                             "where " +
                                    "pavtcodven = @pavtcodven";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@pavtcodven",this._pavtcodven);

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
			        string sql = "insert into aventas (" +
                                                       "cavtfechor," +
                                                       "cavtmontot," +
                                                       "cavtestven," +
                                                       "cavtfeccre," +
                                                       "cavtfecmod," +
                                                       "favtcodcli," +
                                                       "cavtobserv," +
                                                       "pavtcodven," +
                                                       "favtcouscr," +
                                                       "favtcousmo" +
                                                       ") " +
	                             "values (" + 
                                          "@cavtfechor," +
                                          "@cavtmontot," +
                                          "@cavtestven," +
                                          "@cavtfeccre," +
                                          "@cavtfecmod," +
                                          "@favtcodcli," +
                                          "@cavtobserv," +
                                          "@pavtcodven," +
                                          "@favtcouscr," +
                                          "@favtcousmo" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroFechaHora("@cavtfechor",this._cavtfechor);
                    this.Conexion.AsignarParametroDecimal("@cavtmontot",this._cavtmontot);
                    this.Conexion.AsignarParametroLogico("@cavtestven",this._cavtestven);
                    this.Conexion.AsignarParametroFechaHora("@cavtfeccre",this._cavtfeccre);
                    this.Conexion.AsignarParametroFechaHora("@cavtfecmod",this._cavtfecmod);
                    this.Conexion.AsignarParametroCadena("@favtcodcli",this._favtcodcli);
                    this.Conexion.AsignarParametroCadena("@cavtobserv",this._cavtobserv);
                    this.Conexion.AsignarParametroCadena("@pavtcodven",this._pavtcodven);
                    this.Conexion.AsignarParametroCadena("@favtcouscr",this._favtcouscr);
                    this.Conexion.AsignarParametroCadena("@favtcousmo",this._favtcousmo);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            }
        public bool Grabar(List<litemven> listaItems)
        {
            this._mensajeError = "";

            if (listaItems == null || listaItems.Count == 0)
            {
                this._mensajeError = "La venta no tiene productos.";
                return false;
            }

            if (this.VerificarExistencia())
            {
                this._mensajeError = "Ya existe una venta con el código " + this._pavtcodven;
                return false;
            }

            if (!this.Conexion.Conectar())
            {
                this._mensajeError = "No se pudo conectar a la base de datos.";
                return false;
            }

            this.Conexion.IniciarTransaccion();

            // ---------- 1. Cabecera de la venta ----------
            string sql = "insert into aventas (" +
                             "cavtfechor," +
                             "cavtmontot," +
                             "cavtestven," +
                             "cavtfeccre," +
                             "cavtfecmod," +
                             "favtcodcli," +
                             "cavtobserv," +
                             "pavtcodven," +
                             "favtcouscr," +
                             "favtcousmo" +
                         ") values (" +
                             "@cavtfechor," +
                             "@cavtmontot," +
                             "@cavtestven," +
                             "@cavtfeccre," +
                             "@cavtfecmod," +
                             "@favtcodcli," +
                             "@cavtobserv," +
                             "@pavtcodven," +
                             "@favtcouscr," +
                             "@favtcousmo" +
                         ")";

            this.Conexion.PrepararComando(sql);
            this.Conexion.AsignarParametroFechaHora("@cavtfechor", this._cavtfechor);
            this.Conexion.AsignarParametroDecimal("@cavtmontot", this._cavtmontot);
            this.Conexion.AsignarParametroLogico("@cavtestven", this._cavtestven);
            this.Conexion.AsignarParametroFechaHora("@cavtfeccre", this._cavtfeccre);
            this.Conexion.AsignarParametroFechaHora("@cavtfecmod", this._cavtfecmod);
            this.Conexion.AsignarParametroCadena("@favtcodcli", this._favtcodcli);
            this.Conexion.AsignarParametroCadena("@cavtobserv", this._cavtobserv);
            this.Conexion.AsignarParametroCadena("@pavtcodven", this._pavtcodven);
            this.Conexion.AsignarParametroCadena("@favtcouscr", this._favtcouscr);
            this.Conexion.AsignarParametroCadena("@favtcousmo", this._favtcousmo);

            if (!this.Conexion.EjecutarTransaccion())
            {
                this.Conexion.RevertirTransaccion();
                this.Conexion.Desconectar();
                this._mensajeError = "No se pudo guardar la venta. Revise ErrorLog.log";
                return false;
            }

            foreach (litemven item in listaItems)
            {
                // ---------- 2. Detalle de la venta ----------
                sql = "insert into adetvet (" +
                          "cdevpreuni," +
                          "cdevesdeve," +
                          "cdevcantid," +
                          "cdevsubtot," +
                          "fdevcodpro," +
                          "fdevcodven," +
                          "pdevcodeve" +
                      ") values (" +
                          "@cdevpreuni," +
                          "@cdevesdeve," +
                          "@cdevcantid," +
                          "@cdevsubtot," +
                          "@fdevcodpro," +
                          "@fdevcodven," +
                          "@pdevcodeve" +
                      ")";

                // Se prepara en cada vuelta porque los parámetros se reemplazan en el texto
                this.Conexion.PrepararComando(sql);
                this.Conexion.AsignarParametroDecimal("@cdevpreuni", item.cdevpreuni);
                this.Conexion.AsignarParametroLogico("@cdevesdeve", item.cdevesdeve);
                this.Conexion.AsignarParametroEntero("@cdevcantid", item.cdevcantid);
                this.Conexion.AsignarParametroDecimal("@cdevsubtot", item.cdevsubtot);
                this.Conexion.AsignarParametroCadena("@fdevcodpro", item.fdevcodpro);
                this.Conexion.AsignarParametroCadena("@fdevcodven", this._pavtcodven);
                this.Conexion.AsignarParametroCadena("@pdevcodeve", item.pdevcodeve);

                if (!this.Conexion.EjecutarTransaccion())
                {
                    // Falló un producto: se deshace TODO, incluida la cabecera
                    this.Conexion.RevertirTransaccion();
                    this.Conexion.Desconectar();
                    this._mensajeError = "No se pudo guardar el detalle del producto " + item.capdnompro + ". Revise ErrorLog.log";
                    return false;
                }

                // ---------- 3. Descontar stock ----------
                sql = "update aproduc set " +
                          "capdstopro = capdstopro - @descontar " +
                      "where papdcodpro = @papdcodpro " +
                          "and capdstopro >= @minimo";

                this.Conexion.PrepararComando(sql);
                this.Conexion.AsignarParametroEntero("@descontar", item.cdevcantid);
                this.Conexion.AsignarParametroCadena("@papdcodpro", item.fdevcodpro);
                this.Conexion.AsignarParametroEntero("@minimo", item.cdevcantid);

                int filas = this.Conexion.EjecutarTransaccionFilas();
                if (filas != 1)
                {
                    // 0 = stock insuficiente o producto inexistente, -1 = error
                    this.Conexion.RevertirTransaccion();
                    this.Conexion.Desconectar();
                    this._mensajeError = filas == 0
                        ? "Stock insuficiente para el producto " + item.capdnompro
                        : "Error al actualizar el stock. Revise ErrorLog.log";
                    return false;
                }
            }

            // ---------- 4. Todo salió bien: confirmar ----------
            this.Conexion.ConfirmarTransaccion();
            this.Conexion.Desconectar();
            return true;
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
			        string sql = "update aventas set " +
                                                     "cavtfechor = @cavtfechor, " +
                                                     "cavtmontot = @cavtmontot, " +
                                                     "cavtestven = @cavtestven, " +
                                                     "cavtfeccre = @cavtfeccre, " +
                                                     "cavtfecmod = @cavtfecmod, " +
                                                     "favtcodcli = @favtcodcli, " +
                                                     "cavtobserv = @cavtobserv, " +
                                                     "favtcouscr = @favtcouscr, " +
                                                     "favtcousmo = @favtcousmo" +
                                 " where " +
                                        "pavtcodven = @pavtcodven";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroFechaHora("@cavtfechor",this._cavtfechor);
                    this.Conexion.AsignarParametroDecimal("@cavtmontot",this._cavtmontot);
                    this.Conexion.AsignarParametroLogico("@cavtestven",this._cavtestven);
                    this.Conexion.AsignarParametroFechaHora("@cavtfeccre",this._cavtfeccre);
                    this.Conexion.AsignarParametroFechaHora("@cavtfecmod",this._cavtfecmod);
                    this.Conexion.AsignarParametroCadena("@favtcodcli",this._favtcodcli);
                    this.Conexion.AsignarParametroCadena("@cavtobserv",this._cavtobserv);
                    this.Conexion.AsignarParametroCadena("@pavtcodven",this._pavtcodven);
                    this.Conexion.AsignarParametroCadena("@favtcouscr",this._favtcouscr);
                    this.Conexion.AsignarParametroCadena("@favtcousmo",this._favtcousmo);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aventas> Lista(string where)
            { 
                List<aventas> ListaResultado = new List<aventas>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "cavtfechor," +
                                     "cavtmontot," +
                                     "cavtestven," +
                                     "cavtfeccre," +
                                     "cavtfecmod," +
                                     "favtcodcli," +
                                     "cavtobserv," +
                                     "pavtcodven," +
                                     "favtcouscr," +
                                     "favtcousmo " + 
                             "from aventas " ;
 
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
                          aventas Auxiliar = new aventas();
                          Auxiliar.cavtfechor = ResultadoConsulta.GetDateTime(0);
                          Auxiliar.cavtmontot = ResultadoConsulta.GetDecimal(1);
                          Auxiliar.cavtestven = ResultadoConsulta.GetBoolean(2);
                          Auxiliar.cavtfeccre = ResultadoConsulta.GetDateTime(3);
                          Auxiliar.cavtfecmod = ResultadoConsulta.GetDateTime(4);
                          Auxiliar.favtcodcli = ResultadoConsulta.GetString(5);
                          Auxiliar.cavtobserv = ResultadoConsulta.GetString(6);
                          Auxiliar.pavtcodven = ResultadoConsulta.GetString(7);
                          Auxiliar.favtcouscr = ResultadoConsulta.GetString(8);
                          Auxiliar.favtcousmo = ResultadoConsulta.GetString(9);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

