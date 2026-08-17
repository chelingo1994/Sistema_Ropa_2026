using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common;
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
    public class aproduc
    {

        #region Campos
        private DateTime _capdfemopr;
        private bool _capdestpro;
        private bool _capdgenpro;
        private int _capdstopro;
        private decimal _capdprvepr;
        private decimal _capdprmipr;
        private DateTime _capdfecrpr;
        private string _capdmatpro;
        private string _capdcolpro;
        private string _capdfotpro;
        private string _capdtalpro;
        private string _capddespro;
        private string _papdcodpro;
        private string _fapdcodcat;
        private string _capdcodbar;
        private string _capdmodpro;
        private string _capdnompro;
        private string _capdmarpro;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public DateTime capdfemopr
        {
            get { return this._capdfemopr; }
            set { this._capdfemopr = value; }
        }
        public bool capdestpro
        {
            get { return this._capdestpro; }
            set { this._capdestpro = value; }
        }
        public bool capdgenpro
        {
            get { return this._capdgenpro; }
            set { this._capdgenpro = value; }
        }
        public int capdstopro
        {
            get { return this._capdstopro; }
            set { this._capdstopro = value; }
        }
        public decimal capdprvepr
        {
            get { return this._capdprvepr; }
            set { this._capdprvepr = value; }
        }
        public decimal capdprmipr
        {
            get { return this._capdprmipr; }
            set { this._capdprmipr = value; }
        }
        public DateTime capdfecrpr
        {
            get { return this._capdfecrpr; }
            set { this._capdfecrpr = value; }
        }
        public string capdmatpro
        {
            get { return this._capdmatpro; }
            set { this._capdmatpro = value; }
        }
        public string capdcolpro
        {
            get { return this._capdcolpro; }
            set { this._capdcolpro = value; }
        }
        public string capdfotpro
        {
            get { return this._capdfotpro; }
            set { this._capdfotpro = value; }
        }
        public string capdtalpro
        {
            get { return this._capdtalpro; }
            set { this._capdtalpro = value; }
        }
        public string capddespro
        {
            get { return this._capddespro; }
            set { this._capddespro = value; }
        }
        public string papdcodpro
        {
            get { return this._papdcodpro; }
            set { this._papdcodpro = value; }
        }
        public string fapdcodcat
        {
            get { return this._fapdcodcat; }
            set { this._fapdcodcat = value; }
        }
        public string capdcodbar
        {
            get { return this._capdcodbar; }
            set { this._capdcodbar = value; }
        }
        public string capdmodpro
        {
            get { return this._capdmodpro; }
            set { this._capdmodpro = value; }
        }
        public string capdnompro
        {
            get { return this._capdnompro; }
            set { this._capdnompro = value; }
        }
        public string capdmarpro
        {
            get { return this._capdmarpro; }
            set { this._capdmarpro = value; }
        }
        #endregion

        #region Constructor
        public aproduc()
        {
            this._capdfemopr = DateTime.Now;
            this._capdestpro = true;
            this._capdgenpro = true;
            this._capdstopro = 0;
            this._capdprvepr = 0;
            this._capdprmipr = 0;
            this._capdfecrpr = DateTime.Now;
            this._capdmatpro = "";
            this._capdcolpro = "";
            this._capdfotpro = "";
            this._capdtalpro = "";
            this._capddespro = "";
            this._papdcodpro = "";
            this._fapdcodcat = "";
            this._capdcodbar = "";
            this._capdmodpro = "";
            this._capdnompro = "";
            this._capdmarpro = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        public bool ObtenerDatos()
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "capdfemopr," +
                                 "capdestpro," +
                                 "capdgenpro," +
                                 "capdstopro," +
                                 "capdprvepr," +
                                 "capdprmipr," +
                                 "capdfecrpr," +
                                 "capdmatpro," +
                                 "capdcolpro," +
                                 "capdfotpro," +
                                 "capdtalpro," +
                                 "capddespro," +
                                 "papdcodpro," +
                                 "fapdcodcat," +
                                 "capdcodbar," +
                                 "capdmodpro," +
                                 "capdnompro," +
                                 "capdmarpro " +
                         "from aproduc " +
                         "where " +
                                "papdcodpro = @papdcodpro";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@papdcodpro", this._papdcodpro);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._capdfemopr = ResultadoConsulta.GetDateTime(0);
                this._capdestpro = ResultadoConsulta.GetBoolean(1);
                this._capdgenpro = ResultadoConsulta.GetBoolean(2);
                this._capdstopro = ResultadoConsulta.GetInt32(3);
                this._capdprvepr = ResultadoConsulta.GetDecimal(4);
                this._capdprmipr = ResultadoConsulta.GetDecimal(5);
                this._capdfecrpr = ResultadoConsulta.GetDateTime(6);
                this._capdmatpro = ResultadoConsulta.GetString(7);
                this._capdcolpro = ResultadoConsulta.GetString(8);
                this._capdfotpro = ResultadoConsulta.GetString(9);
                this._capdtalpro = ResultadoConsulta.GetString(10);
                this._capddespro = ResultadoConsulta.GetString(11);
                this._papdcodpro = ResultadoConsulta.GetString(12);
                this._fapdcodcat = ResultadoConsulta.GetString(13);
                this._capdcodbar = ResultadoConsulta.GetString(14);
                this._capdmodpro = ResultadoConsulta.GetString(15);
                this._capdnompro = ResultadoConsulta.GetString(16);
                this._capdmarpro = ResultadoConsulta.GetString(17);
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
                                 "capdfemopr," +
                                 "capdestpro," +
                                 "capdgenpro," +
                                 "capdstopro," +
                                 "capdprvepr," +
                                 "capdprmipr," +
                                 "capdfecrpr," +
                                 "capdmatpro," +
                                 "capdcolpro," +
                                 "capdfotpro," +
                                 "capdtalpro," +
                                 "capddespro," +
                                 "papdcodpro," +
                                 "fapdcodcat," +
                                 "capdcodbar," +
                                 "capdmodpro," +
                                 "capdnompro," +
                                 "capdmarpro " +
                         "from aproduc " +
                         "where " +
                                "papdcodpro = @papdcodpro";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@papdcodpro", this._papdcodpro);

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
                string sql = "insert into aproduc (" +
                                                   "capdfemopr," +
                                                   "capdestpro," +
                                                   "capdgenpro," +
                                                   "capdstopro," +
                                                   "capdprvepr," +
                                                   "capdprmipr," +
                                                   "capdfecrpr," +
                                                   "capdmatpro," +
                                                   "capdcolpro," +
                                                   "capdfotpro," +
                                                   "capdtalpro," +
                                                   "capddespro," +
                                                   "papdcodpro," +
                                                   "fapdcodcat," +
                                                   "capdcodbar," +
                                                   "capdmodpro," +
                                                   "capdnompro," +
                                                   "capdmarpro" +
                                                   ") " +
                             "values (" +
                                      "@capdfemopr," +
                                      "@capdestpro," +
                                      "@capdgenpro," +
                                      "@capdstopro," +
                                      "@capdprvepr," +
                                      "@capdprmipr," +
                                      "@capdfecrpr," +
                                      "@capdmatpro," +
                                      "@capdcolpro," +
                                      "@capdfotpro," +
                                      "@capdtalpro," +
                                      "@capddespro," +
                                      "@papdcodpro," +
                                      "@fapdcodcat," +
                                      "@capdcodbar," +
                                      "@capdmodpro," +
                                      "@capdnompro," +
                                      "@capdmarpro" +
                                                   ")";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroFechaHora("@capdfemopr", this._capdfemopr);
                this.Conexion.AsignarParametroLogico("@capdestpro", this._capdestpro);
                this.Conexion.AsignarParametroLogico("@capdgenpro", this._capdgenpro);
                this.Conexion.AsignarParametroEntero("@capdstopro", this._capdstopro);
                this.Conexion.AsignarParametroDecimal("@capdprvepr", this._capdprvepr);
                this.Conexion.AsignarParametroDecimal("@capdprmipr", this._capdprmipr);
                this.Conexion.AsignarParametroFechaHora("@capdfecrpr", this._capdfecrpr);
                this.Conexion.AsignarParametroCadena("@capdmatpro", this._capdmatpro);
                this.Conexion.AsignarParametroCadena("@capdcolpro", this._capdcolpro);
                this.Conexion.AsignarParametroCadena("@capdfotpro", this._capdfotpro);
                this.Conexion.AsignarParametroCadena("@capdtalpro", this._capdtalpro);
                this.Conexion.AsignarParametroCadena("@capddespro", this._capddespro);
                this.Conexion.AsignarParametroCadena("@papdcodpro", this._papdcodpro);
                this.Conexion.AsignarParametroCadena("@fapdcodcat", this._fapdcodcat);
                this.Conexion.AsignarParametroCadena("@capdcodbar", this._capdcodbar);
                this.Conexion.AsignarParametroCadena("@capdmodpro", this._capdmodpro);
                this.Conexion.AsignarParametroCadena("@capdnompro", this._capdnompro);
                this.Conexion.AsignarParametroCadena("@capdmarpro", this._capdmarpro);

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
                string sql = "update aproduc set " +
                                                 "capdfemopr = @capdfemopr, " +
                                                 "capdestpro = @capdestpro, " +
                                                 "capdgenpro = @capdgenpro, " +
                                                 "capdstopro = @capdstopro, " +
                                                 "capdprvepr = @capdprvepr, " +
                                                 "capdprmipr = @capdprmipr, " +
                                                 "capdfecrpr = @capdfecrpr, " +
                                                 "capdmatpro = @capdmatpro, " +
                                                 "capdcolpro = @capdcolpro, " +
                                                 "capdfotpro = @capdfotpro, " +
                                                 "capdtalpro = @capdtalpro, " +
                                                 "capddespro = @capddespro, " +
                                                 "fapdcodcat = @fapdcodcat, " +
                                                 "capdcodbar = @capdcodbar, " +
                                                 "capdmodpro = @capdmodpro, " +
                                                 "capdnompro = @capdnompro, " +
                                                 "capdmarpro = @capdmarpro" +
                             " where " +
                                    "papdcodpro = @papdcodpro";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroFechaHora("@capdfemopr", this._capdfemopr);
                this.Conexion.AsignarParametroLogico("@capdestpro", this._capdestpro);
                this.Conexion.AsignarParametroLogico("@capdgenpro", this._capdgenpro);
                this.Conexion.AsignarParametroEntero("@capdstopro", this._capdstopro);
                this.Conexion.AsignarParametroDecimal("@capdprvepr", this._capdprvepr);
                this.Conexion.AsignarParametroDecimal("@capdprmipr", this._capdprmipr);
                this.Conexion.AsignarParametroFechaHora("@capdfecrpr", this._capdfecrpr);
                this.Conexion.AsignarParametroCadena("@capdmatpro", this._capdmatpro);
                this.Conexion.AsignarParametroCadena("@capdcolpro", this._capdcolpro);
                this.Conexion.AsignarParametroCadena("@capdfotpro", this._capdfotpro);
                this.Conexion.AsignarParametroCadena("@capdtalpro", this._capdtalpro);
                this.Conexion.AsignarParametroCadena("@capddespro", this._capddespro);
                this.Conexion.AsignarParametroCadena("@papdcodpro", this._papdcodpro);
                this.Conexion.AsignarParametroCadena("@fapdcodcat", this._fapdcodcat);
                this.Conexion.AsignarParametroCadena("@capdcodbar", this._capdcodbar);
                this.Conexion.AsignarParametroCadena("@capdmodpro", this._capdmodpro);
                this.Conexion.AsignarParametroCadena("@capdnompro", this._capdnompro);
                this.Conexion.AsignarParametroCadena("@capdmarpro", this._capdmarpro);

                this.Conexion.EjecutarTransaccion();
                this.Conexion.Desconectar();

                return true;
            }
        }
        public List<aproduc> Lista(string where)
        {
            List<aproduc> ListaResultado = new List<aproduc>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "capdfemopr," +
                                 "capdestpro," +
                                 "capdgenpro," +
                                 "capdstopro," +
                                 "capdprvepr," +
                                 "capdprmipr," +
                                 "capdfecrpr," +
                                 "capdmatpro," +
                                 "capdcolpro," +
                                 "capdfotpro," +
                                 "capdtalpro," +
                                 "capddespro," +
                                 "papdcodpro," +
                                 "fapdcodcat," +
                                 "capdcodbar," +
                                 "capdmodpro," +
                                 "capdnompro," +
                                 "capdmarpro " +
                         "from aproduc ";

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
                    aproduc Auxiliar = new aproduc();
                    Auxiliar.capdfemopr = ResultadoConsulta.GetDateTime(0);
                    Auxiliar.capdestpro = ResultadoConsulta.GetBoolean(1);
                    Auxiliar.capdgenpro = ResultadoConsulta.GetBoolean(2);
                    Auxiliar.capdstopro = ResultadoConsulta.GetInt32(3);
                    Auxiliar.capdprvepr = ResultadoConsulta.GetDecimal(4);
                    Auxiliar.capdprmipr = ResultadoConsulta.GetDecimal(5);
                    Auxiliar.capdfecrpr = ResultadoConsulta.GetDateTime(6);
                    Auxiliar.capdmatpro = ResultadoConsulta.GetString(7);
                    Auxiliar.capdcolpro = ResultadoConsulta.GetString(8);
                    Auxiliar.capdfotpro = ResultadoConsulta.GetString(9);
                    Auxiliar.capdtalpro = ResultadoConsulta.GetString(10);
                    Auxiliar.capddespro = ResultadoConsulta.GetString(11);
                    Auxiliar.papdcodpro = ResultadoConsulta.GetString(12);
                    Auxiliar.fapdcodcat = ResultadoConsulta.GetString(13);
                    Auxiliar.capdcodbar = ResultadoConsulta.GetString(14);
                    Auxiliar.capdmodpro = ResultadoConsulta.GetString(15);
                    Auxiliar.capdnompro = ResultadoConsulta.GetString(16);
                    Auxiliar.capdmarpro = ResultadoConsulta.GetString(17);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion

    }
}

