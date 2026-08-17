using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lproduc
    {
        #region Campos
        private bool _caceestcat;
        private string _pacecodcat;
        private string _cacenomcat;
        private string _cacedescat;

        private int _capdstopro;
        private decimal _capdprvepr;
        private decimal _capdprmipr;
        private bool _capdestpro;
        private DateTime _capdfecrpr;
        private DateTime _capdfemopr;
        private string _capdmatpro;
        private string _capdcolpro;
        private string _papdcodpro;
        private string _capdtalpro;
        private string _capddespro;
        private string _capdfotpro;
        private bool _capdgenpro;
        private string _fapdcodcat;
        private string _capdcodbar;
        private string _capdmodpro;
        private string _capdnompro;
        private string _capdmarpro;

        private CLConexionPGSQL Conexion;
        #endregion
        #region Propiedades
        public bool caceestcat
        {
            get { return this._caceestcat; }
            set { this._caceestcat = value; }
        }
        public string pacecodcat
        {
            get { return this._pacecodcat; }
            set { this._pacecodcat = value; }
        }
        public string cacenomcat
        {
            get { return this._cacenomcat; }
            set { this._cacenomcat = value; }
        }
        public string cacedescat
        {
            get { return this._cacedescat; }
            set { this._cacedescat = value; }
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
        public bool capdestpro
        {
            get { return this._capdestpro; }
            set { this._capdestpro = value; }
        }
        public DateTime capdfecrpr
        {
            get { return this._capdfecrpr; }
            set { this._capdfecrpr = value; }
        }
        public DateTime capdfemopr
        {
            get { return this._capdfemopr; }
            set { this._capdfemopr = value; }
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
        public string papdcodpro
        {
            get { return this._papdcodpro; }
            set { this._papdcodpro = value; }
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
        public string capdfotpro
        {
            get { return this._capdfotpro; }
            set { this._capdfotpro = value; }
        }
        public bool capdgenpro
        {
            get { return this._capdgenpro; }
            set { this._capdgenpro = value; }
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

        public lproduc()
        {
            this._caceestcat = true;
            this._pacecodcat = "";
            this._cacenomcat = "";
            this._cacedescat = "";

            this._caceestcat = true;
            this._pacecodcat = "";
            this._cacenomcat = "";
            this._cacedescat = "";
            this._capdstopro = 0;
            this._capdprvepr = 0;
            this._capdprmipr = 0;
            this._capdestpro = true;
            this._capdfecrpr = DateTime.Now;
            this._capdfemopr = DateTime.Now;
            this._capdmatpro = "";
            this._capdcolpro = "";
            this._papdcodpro = "";
            this._capdtalpro = "";
            this._capddespro = "";
            this._capdfotpro = "";
            this._capdgenpro = true;
            this._fapdcodcat = "";
            this._capdcodbar = "";
            this._capdmodpro = "";
            this._capdnompro = "";
            this._capdmarpro = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        public List<lproduc> Lista(string where)
        {
            List<lproduc> ListaResultado = new List<lproduc>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "caceestcat," +
                                 "pacecodcat," +
                                 "cacenomcat," +
                                 "cacedescat," +
                                 "capdstopro," +
                                 "capdprvepr," +
                                 "capdprmipr," +
                                 "capdestpro," +
                                 "capdfecrpr," +
                                 "capdfemopr," +
                                 "capdmatpro," +
                                 "capdcolpro," +
                                 "papdcodpro," +
                                 "capdtalpro," +
                                 "capddespro," +
                                 "capdfotpro," +
                                 "capdgenpro," +
                                 "fapdcodcat," +
                                 "capdcodbar," +
                                 "capdmodpro," +
                                 "capdnompro," +
                                 "capdmarpro " +
                          "from aproduc,acatego " +
                         "where pacecodcat=fapdcodcat ";

            if (where.Replace(" ", "") != "")
            {
                sql += "and " + where;
            }


            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta!=null)
            {
                while (ResultadoConsulta.Read())
                {
                    lproduc Auxiliar = new lproduc();
                    Auxiliar.caceestcat = ResultadoConsulta.GetBoolean(0);
                    Auxiliar.pacecodcat = ResultadoConsulta.GetString(1);
                    Auxiliar.cacenomcat = ResultadoConsulta.GetString(2);
                    Auxiliar.cacedescat = ResultadoConsulta.GetString(3);
                    Auxiliar.capdstopro = ResultadoConsulta.GetInt32(4);
                    Auxiliar.capdprvepr = ResultadoConsulta.GetDecimal(5);
                    Auxiliar.capdprmipr = ResultadoConsulta.GetDecimal(6);
                    Auxiliar.capdestpro = ResultadoConsulta.GetBoolean(7);
                    Auxiliar.capdfecrpr = ResultadoConsulta.GetDateTime(8);
                    Auxiliar.capdfemopr = ResultadoConsulta.GetDateTime(9);
                    Auxiliar.capdmatpro = ResultadoConsulta.GetString(10);
                    Auxiliar.capdcolpro = ResultadoConsulta.GetString(11);
                    Auxiliar.papdcodpro = ResultadoConsulta.GetString(12);
                    Auxiliar.capdtalpro = ResultadoConsulta.GetString(13);
                    Auxiliar.capddespro = ResultadoConsulta.GetString(14);
                    Auxiliar.capdfotpro = ResultadoConsulta.GetString(15);
                    Auxiliar.capdgenpro = ResultadoConsulta.GetBoolean(16);
                    Auxiliar.fapdcodcat = ResultadoConsulta.GetString(17);
                    Auxiliar.capdcodbar = ResultadoConsulta.GetString(18);
                    Auxiliar.capdmodpro = ResultadoConsulta.GetString(19);
                    Auxiliar.capdnompro = ResultadoConsulta.GetString(20);
                    Auxiliar.capdmarpro = ResultadoConsulta.GetString(21);
                    ListaResultado.Add(Auxiliar);
                }
                
                

                
            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }

        public List<lproduc> ListaCategorias()
        {
            List<lproduc> ListaResultado = new List<lproduc>();

            this.Conexion.Conectar();

            string sql = "SELECT " +
                         "caceestcat, " +
                         "pacecodcat, " +
                         "cacenomcat, " +
                         "cacedescat " +
                         "FROM acatego " +
                         "WHERE caceestcat = true " +
                         "ORDER BY cacenomcat";

            this.Conexion.PrepararComando(sql);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            while (ResultadoConsulta.Read())
            {
                lproduc Auxiliar = new lproduc();

                Auxiliar.caceestcat = ResultadoConsulta.GetBoolean(0);
                Auxiliar.pacecodcat = ResultadoConsulta.GetString(1);
                Auxiliar.cacenomcat = ResultadoConsulta.GetString(2);
                Auxiliar.cacedescat = ResultadoConsulta.GetString(3);

                ListaResultado.Add(Auxiliar);
            }

            this.Conexion.Desconectar();

            return ListaResultado;
        }
        #endregion
    }
}
