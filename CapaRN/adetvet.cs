using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class adetvet {

		#region Campos
            private decimal _cdevpreuni;
            private bool _cdevesdeve;
            private int _cdevcantid;
            private decimal _cdevsubtot;
            private string _fdevcodpro;
            private string _fdevcodven;
            private string _pdevcodeve;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public decimal cdevpreuni
            { 
                get{ return this._cdevpreuni;}
                set{ this._cdevpreuni = value;}
            } 
		    public bool cdevesdeve
            { 
                get{ return this._cdevesdeve;}
                set{ this._cdevesdeve = value;}
            } 
		    public int cdevcantid
            { 
                get{ return this._cdevcantid;}
                set{ this._cdevcantid = value;}
            } 
		    public decimal cdevsubtot
            { 
                get{ return this._cdevsubtot;}
                set{ this._cdevsubtot = value;}
            } 
		    public string fdevcodpro
            { 
                get{ return this._fdevcodpro;}
                set{ this._fdevcodpro = value;}
            } 
		    public string fdevcodven
            { 
                get{ return this._fdevcodven;}
                set{ this._fdevcodven = value;}
            } 
		    public string pdevcodeve
            { 
                get{ return this._pdevcodeve;}
                set{ this._pdevcodeve = value;}
            } 
        #endregion

        #region Constructor
            public adetvet()
            { 
		        this._cdevpreuni = 0;
		        this._cdevesdeve = true;
		        this._cdevcantid = 0;
		        this._cdevsubtot = 0;
		        this._fdevcodpro = "";
		        this._fdevcodven = "";
		        this._pdevcodeve = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "cdevpreuni," +
                                     "cdevesdeve," +
                                     "cdevcantid," +
                                     "cdevsubtot," +
                                     "fdevcodpro," +
                                     "fdevcodven," +
                                     "pdevcodeve " + 
                             "from adetvet " +
                             "where "+
                                    "pdevcodeve = @pdevcodeve";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@pdevcodeve",this._pdevcodeve);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._cdevpreuni=ResultadoConsulta.GetDecimal(0);
                    this._cdevesdeve=ResultadoConsulta.GetBoolean(1);
                    this._cdevcantid=ResultadoConsulta.GetInt32(2);
                    this._cdevsubtot=ResultadoConsulta.GetDecimal(3);
                    this._fdevcodpro=ResultadoConsulta.GetString(4);
                    this._fdevcodven=ResultadoConsulta.GetString(5);
                    this._pdevcodeve=ResultadoConsulta.GetString(6);
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
                                     "cdevpreuni," +
                                     "cdevesdeve," +
                                     "cdevcantid," +
                                     "cdevsubtot," +
                                     "fdevcodpro," +
                                     "fdevcodven," +
                                     "pdevcodeve " + 
                             "from adetvet " +
                             "where " +
                                    "pdevcodeve = @pdevcodeve";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@pdevcodeve",this._pdevcodeve);

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
			        string sql = "insert into adetvet (" +
                                                       "cdevpreuni," +
                                                       "cdevesdeve," +
                                                       "cdevcantid," +
                                                       "cdevsubtot," +
                                                       "fdevcodpro," +
                                                       "fdevcodven," +
                                                       "pdevcodeve" +
                                                       ") " +
	                             "values (" + 
                                          "@cdevpreuni," +
                                          "@cdevesdeve," +
                                          "@cdevcantid," +
                                          "@cdevsubtot," +
                                          "@fdevcodpro," +
                                          "@fdevcodven," +
                                          "@pdevcodeve" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroDecimal("@cdevpreuni",this._cdevpreuni);
                    this.Conexion.AsignarParametroLogico("@cdevesdeve",this._cdevesdeve);
                    this.Conexion.AsignarParametroEntero("@cdevcantid",this._cdevcantid);
                    this.Conexion.AsignarParametroDecimal("@cdevsubtot",this._cdevsubtot);
                    this.Conexion.AsignarParametroCadena("@fdevcodpro",this._fdevcodpro);
                    this.Conexion.AsignarParametroCadena("@fdevcodven",this._fdevcodven);
                    this.Conexion.AsignarParametroCadena("@pdevcodeve",this._pdevcodeve);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            }
        public bool Grabar(List<litemven> listaItems)
        {
            if (listaItems == null || listaItems.Count == 0)
                return false;

            if (!this.Conexion.Conectar())
                return false;

            foreach (litemven item in listaItems)
            {
                string sql = "insert into adetvet (" +
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
                this.Conexion.AsignarParametroCadena("@fdevcodven", item.fdevcodven);
                this.Conexion.AsignarParametroCadena("@pdevcodeve", item.pdevcodeve);

                this.Conexion.EjecutarTransaccion();
            }

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
			        string sql = "update adetvet set " +
                                                     "cdevpreuni = @cdevpreuni, " +
                                                     "cdevesdeve = @cdevesdeve, " +
                                                     "cdevcantid = @cdevcantid, " +
                                                     "cdevsubtot = @cdevsubtot, " +
                                                     "fdevcodpro = @fdevcodpro, " +
                                                     "fdevcodven = @fdevcodven" +
                                 " where " +
                                        "pdevcodeve = @pdevcodeve";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroDecimal("@cdevpreuni",this._cdevpreuni);
                    this.Conexion.AsignarParametroLogico("@cdevesdeve",this._cdevesdeve);
                    this.Conexion.AsignarParametroEntero("@cdevcantid",this._cdevcantid);
                    this.Conexion.AsignarParametroDecimal("@cdevsubtot",this._cdevsubtot);
                    this.Conexion.AsignarParametroCadena("@fdevcodpro",this._fdevcodpro);
                    this.Conexion.AsignarParametroCadena("@fdevcodven",this._fdevcodven);
                    this.Conexion.AsignarParametroCadena("@pdevcodeve",this._pdevcodeve);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<adetvet> Lista(string where)
            { 
                List<adetvet> ListaResultado = new List<adetvet>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "cdevpreuni," +
                                     "cdevesdeve," +
                                     "cdevcantid," +
                                     "cdevsubtot," +
                                     "fdevcodpro," +
                                     "fdevcodven," +
                                     "pdevcodeve " + 
                             "from adetvet " ;
 
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
                          adetvet Auxiliar = new adetvet();
                          Auxiliar.cdevpreuni = ResultadoConsulta.GetDecimal(0);
                          Auxiliar.cdevesdeve = ResultadoConsulta.GetBoolean(1);
                          Auxiliar.cdevcantid = ResultadoConsulta.GetInt32(2);
                          Auxiliar.cdevsubtot = ResultadoConsulta.GetDecimal(3);
                          Auxiliar.fdevcodpro = ResultadoConsulta.GetString(4);
                          Auxiliar.fdevcodven = ResultadoConsulta.GetString(5);
                          Auxiliar.pdevcodeve = ResultadoConsulta.GetString(6);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

