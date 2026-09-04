using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common;
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
    public class aclient
    {

        #region Campos
        private bool _caceestcli;
        private int _cacenuidtr;
        private bool _cacetipcli;
        private string _pacecodcli;
        private string _facecodper;
        private string _cacedirecc;
        private string _cacerazsoc;
        private string _cacetelefo;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public bool caceestcli
        {
            get { return this._caceestcli; }
            set { this._caceestcli = value; }
        }
        public int cacenuidtr
        {
            get { return this._cacenuidtr; }
            set { this._cacenuidtr = value; }
        }
        public bool cacetipcli
        {
            get { return this._cacetipcli; }
            set { this._cacetipcli = value; }
        }
        public string pacecodcli
        {
            get { return this._pacecodcli; }
            set { this._pacecodcli = value; }
        }
        public string facecodper
        {
            get { return this._facecodper; }
            set { this._facecodper = value; }
        }
        public string cacedirecc
        {
            get { return this._cacedirecc; }
            set { this._cacedirecc = value; }
        }
        public string cacerazsoc
        {
            get { return this._cacerazsoc; }
            set { this._cacerazsoc = value; }
        }
        public string cacetelefo
        {
            get { return this._cacetelefo; }
            set { this._cacetelefo = value; }
        }
        #endregion

        #region Constructor
        public aclient()
        {
            this._caceestcli = true;
            this._cacenuidtr = 0;
            this._cacetipcli = true;
            this._pacecodcli = "";
            this._facecodper = "";
            this._cacedirecc = "";
            this._cacerazsoc = "";
            this._cacetelefo = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        public bool ObtenerDatos()
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "caceestcli," +
                                 "cacenuidtr," +
                                 "cacetipcli," +
                                 "pacecodcli," +
                                 "facecodper," +
                                 "cacedirecc," +
                                 "cacerazsoc," +
                                 "cacetelefo " +
                         "from aclient " +
                         "where " +
                                "pacecodcli = @pacecodcli";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@pacecodcli", this._pacecodcli);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._caceestcli = ResultadoConsulta.GetBoolean(0);
                this._cacenuidtr = ResultadoConsulta.GetInt32(1);
                this._cacetipcli = ResultadoConsulta.GetBoolean(2);
                this._pacecodcli = ResultadoConsulta.GetString(3);
                this._facecodper = ResultadoConsulta.GetString(4);
                this._cacedirecc = ResultadoConsulta.GetString(5);
                this._cacerazsoc = ResultadoConsulta.GetString(6);
                this._cacetelefo = ResultadoConsulta.GetString(7);
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
                                 "cacetipcli," +
                                 "pacecodcli," +
                                 "facecodper," +
                                 "cacedirecc," +
                                 "cacerazsoc," +
                                 "cacetelefo " +
                         "from aclient " +
                         "where " +
                                "pacecodcli = @pacecodcli";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@pacecodcli", this._pacecodcli);

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
                                                   "cacetipcli," +
                                                   "pacecodcli," +
                                                   "facecodper," +
                                                   "cacedirecc," +
                                                   "cacerazsoc," +
                                                   "cacetelefo" +
                                                   ") " +
                             "values (" +
                                      "@caceestcli," +
                                      "@cacenuidtr," +
                                      "@cacetipcli," +
                                      "@pacecodcli," +
                                      "@facecodper," +
                                      "@cacedirecc," +
                                      "@cacerazsoc," +
                                      "@cacetelefo" +
                                                   ")";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroLogico("@caceestcli", this._caceestcli);
                this.Conexion.AsignarParametroEntero("@cacenuidtr", this._cacenuidtr);
                this.Conexion.AsignarParametroLogico("@cacetipcli", this._cacetipcli);
                this.Conexion.AsignarParametroCadena("@pacecodcli", this._pacecodcli);
                this.Conexion.AsignarParametroCadena("@facecodper", this._facecodper);
                this.Conexion.AsignarParametroCadena("@cacedirecc", this._cacedirecc);
                this.Conexion.AsignarParametroCadena("@cacerazsoc", this._cacerazsoc);
                this.Conexion.AsignarParametroCadena("@cacetelefo", this._cacetelefo);

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
                                                 "cacetipcli = @cacetipcli, " +
                                                 "facecodper = @facecodper, " +
                                                 "cacedirecc = @cacedirecc, " +
                                                 "cacerazsoc = @cacerazsoc, " +
                                                 "cacetelefo = @cacetelefo" +
                             " where " +
                                    "pacecodcli = @pacecodcli";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroLogico("@caceestcli", this._caceestcli);
                this.Conexion.AsignarParametroEntero("@cacenuidtr", this._cacenuidtr);
                this.Conexion.AsignarParametroLogico("@cacetipcli", this._cacetipcli);
                this.Conexion.AsignarParametroCadena("@pacecodcli", this._pacecodcli);
                this.Conexion.AsignarParametroCadena("@facecodper", this._facecodper);
                this.Conexion.AsignarParametroCadena("@cacedirecc", this._cacedirecc);
                this.Conexion.AsignarParametroCadena("@cacerazsoc", this._cacerazsoc);
                this.Conexion.AsignarParametroCadena("@cacetelefo", this._cacetelefo);

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
                                 "cacetipcli," +
                                 "pacecodcli," +
                                 "facecodper," +
                                 "cacedirecc," +
                                 "cacerazsoc," +
                                 "cacetelefo " +
                         "from aclient ";

            if (where.Replace(" ", "") != "")
            {
                sql += "where " + where;
            }


            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    aclient Auxiliar = new aclient();
                    Auxiliar.caceestcli = ResultadoConsulta.GetBoolean(0);
                    Auxiliar.cacenuidtr = ResultadoConsulta.GetInt32(1);
                    Auxiliar.cacetipcli = ResultadoConsulta.GetBoolean(2);
                    Auxiliar.pacecodcli = ResultadoConsulta.GetString(3);
                    Auxiliar.facecodper = ResultadoConsulta.GetString(4);
                    Auxiliar.cacedirecc = ResultadoConsulta.GetString(5);
                    Auxiliar.cacerazsoc = ResultadoConsulta.GetString(6);
                    Auxiliar.cacetelefo = ResultadoConsulta.GetString(7);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }

        public bool ObtenerDatosCliente(bool modificar, string pacecodcliExcluir)
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "caceestcli," +
                                 "cacenuidtr," +
                                 "cacetipcli," +
                                 "pacecodcli," +
                                 "facecodper," +
                                 "cacedirecc," +
                                 "cacerazsoc," +
                                 "cacetelefo " +
                          "from aclient " +
                         "where " +
                                "cacenuidtr = @cacenuidtr";
            if (modificar)
            {
                sql += " and pacecodcli <> @pacecodcliExcluir";
            }

            this.Conexion.PrepararComando(sql);
            this.Conexion.AsignarParametroEntero("@cacenuidtr", this._cacenuidtr);
            if (modificar)
            {
                this.Conexion.AsignarParametroCadena("@pacecodcliExcluir", pacecodcliExcluir);
            }

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._caceestcli = ResultadoConsulta.GetBoolean(0);
                this._cacenuidtr = ResultadoConsulta.GetInt32(1);
                this._cacetipcli = ResultadoConsulta.GetBoolean(2);
                this._pacecodcli = ResultadoConsulta.GetString(3);
                this._facecodper = ResultadoConsulta.GetString(4);
                this._cacedirecc = ResultadoConsulta.GetString(5);
                this._cacerazsoc = ResultadoConsulta.GetString(6);
                this._cacetelefo = ResultadoConsulta.GetString(7);
                this.Conexion.Desconectar();
                return true;
            }
            else
            {
                this.Conexion.Desconectar();
                return false;
            }
        }
        #endregion

    }
}

