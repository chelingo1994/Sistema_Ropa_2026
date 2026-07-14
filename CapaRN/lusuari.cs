using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lusuari
    {
        #region Campos
        //datos usuario
        private bool _cauaestusu;
        private int _cauamashue;
        private int _cauanumhu1;
        private int _cauanumhu2;
        private int _cauanumhu3;
        private int _cauanumhu4;
        private string _cauacodhu2;
        private string _cauacodhu3;
        private string _cauacodhu4;
        private string _fauacodper;
        private string _pauacodusu;
        private string _cauanomlog;
        private string _cauaclausu;
        private bool _cauaactcla;
        private string _cauacodhu1;

        //datos persona
        private bool _capssexper;
        private bool _capsestper;
        private DateTime _capsfecnac;
        private string _capsdirper;
        private string _capsnumcid;
        private string _capscorele;
        private string _papscodper;
        private string _capsfotper;
        private string _capsnomper;
        private string _capsnumcel;
        private string _capsapemat;
        private string _capsapepat;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        //propiedades de usuario
        public bool cauaestusu
        {
            get { return this._cauaestusu; }
            set { this._cauaestusu = value; }
        }
        public int cauamashue
        {
            get { return this._cauamashue; }
            set { this._cauamashue = value; }
        }
        public int cauanumhu1
        {
            get { return this._cauanumhu1; }
            set { this._cauanumhu1 = value; }
        }
        public int cauanumhu2
        {
            get { return this._cauanumhu2; }
            set { this._cauanumhu2 = value; }
        }
        public int cauanumhu3
        {
            get { return this._cauanumhu3; }
            set { this._cauanumhu3 = value; }
        }
        public int cauanumhu4
        {
            get { return this._cauanumhu4; }
            set { this._cauanumhu4 = value; }
        }
        public string cauacodhu2
        {
            get { return this._cauacodhu2; }
            set { this._cauacodhu2 = value; }
        }
        public string cauacodhu3
        {
            get { return this._cauacodhu3; }
            set { this._cauacodhu3 = value; }
        }
        public string cauacodhu4
        {
            get { return this._cauacodhu4; }
            set { this._cauacodhu4 = value; }
        }
        public string fauacodper
        {
            get { return this._fauacodper; }
            set { this._fauacodper = value; }
        }
        public string pauacodusu
        {
            get { return this._pauacodusu; }
            set { this._pauacodusu = value; }
        }
        public string cauanomlog
        {
            get { return this._cauanomlog; }
            set { this._cauanomlog = value; }
        }
        public string cauaclausu
        {
            get { return this._cauaclausu; }
            set { this._cauaclausu = value; }
        }
        public bool cauaactcla
        {
            get { return this._cauaactcla; }
            set { this._cauaactcla = value; }
        }
        public string cauacodhu1
        {
            get { return this._cauacodhu1; }
            set { this._cauacodhu1 = value; }
        }

        //propiedades de persona
        public bool capssexper
        {
            get { return this._capssexper; }
            set { this._capssexper = value; }
        }
        public bool capsestper
        {
            get { return this._capsestper; }
            set { this._capsestper = value; }
        }
        public DateTime capsfecnac
        {
            get { return this._capsfecnac; }
            set { this._capsfecnac = value; }
        }
        public string capsdirper
        {
            get { return this._capsdirper; }
            set { this._capsdirper = value; }
        }
        public string capsnumcid
        {
            get { return this._capsnumcid; }
            set { this._capsnumcid = value; }
        }
        public string capscorele
        {
            get { return this._capscorele; }
            set { this._capscorele = value; }
        }
        public string papscodper
        {
            get { return this._papscodper; }
            set { this._papscodper = value; }
        }
        public string capsfotper
        {
            get { return this._capsfotper; }
            set { this._capsfotper = value; }
        }
        public string capsnomper
        {
            get { return this._capsnomper; }
            set { this._capsnomper = value; }
        }
        public string capsnumcel
        {
            get { return this._capsnumcel; }
            set { this._capsnumcel = value; }
        }
        public string capsapemat
        {
            get { return this._capsapemat; }
            set { this._capsapemat = value; }
        }
        public string capsapepat
        {
            get { return this._capsapepat; }
            set { this._capsapepat = value; }
        }
        #endregion

        #region Constructor
        public lusuari()
        {
            this._cauaestusu = true;
            this._cauamashue = 0;
            this._cauanumhu1 = 0;
            this._cauanumhu2 = 0;
            this._cauanumhu3 = 0;
            this._cauanumhu4 = 0;
            this._cauacodhu2 = "";
            this._cauacodhu3 = "";
            this._cauacodhu4 = "";
            this._fauacodper = "";
            this._pauacodusu = "";
            this._cauanomlog = "";
            this._cauaclausu = "";
            this._cauaactcla = true;
            this._cauacodhu1 = "";

            this._capssexper = true;
            this._capsestper = true;
            this._capsfecnac = DateTime.Now;
            this._capsdirper = "";
            this._capsnumcid = "";
            this._capscorele = "";
            this._papscodper = "";
            this._capsfotper = "";
            this._capsnomper = "";
            this._capsnumcel = "";
            this._capsapemat = "";
            this._capsapepat = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        public List<lusuari> Lista(string where)
        {
            List<lusuari> ListaResultado = new List<lusuari>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cauaestusu," +
                                 "cauamashue," +
                                 "cauanumhu1," +
                                 "cauanumhu2," +
                                 "cauanumhu3," +
                                 "cauanumhu4," +
                                 "cauacodhu2," +
                                 "cauacodhu3," +
                                 "cauacodhu4," +
                                 "fauacodper," +
                                 "pauacodusu," +
                                 "cauanomlog," +
                                 "cauaclausu," +
                                 "cauaactcla," +
                                 "cauacodhu1," +
                                 "capssexper," +
                                 "capsestper," +
                                 "capsfecnac," +
                                 "capsdirper," +
                                 "capsnumcid," +
                                 "capscorele," +
                                 "papscodper," +
                                 "capsfotper," +
                                 "capsnomper," +
                                 "capsnumcel," +
                                 "capsapemat," +
                                 "capsapepat " +
                         "from ausuari,aperson "+
                         "where papscodper=fauacodper ";

            if (where.Replace(" ", "") != "")
            {
                sql += "and " + where;
            }

          


            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    lusuari Auxiliar = new lusuari();
                    Auxiliar.cauaestusu = ResultadoConsulta.GetBoolean(0);
                    Auxiliar.cauamashue = ResultadoConsulta.GetInt32(1);
                    Auxiliar.cauanumhu1 = ResultadoConsulta.GetInt32(2);
                    Auxiliar.cauanumhu2 = ResultadoConsulta.GetInt32(3);
                    Auxiliar.cauanumhu3 = ResultadoConsulta.GetInt32(4);
                    Auxiliar.cauanumhu4 = ResultadoConsulta.GetInt32(5);
                    Auxiliar.cauacodhu2 = ResultadoConsulta.GetString(6);
                    Auxiliar.cauacodhu3 = ResultadoConsulta.GetString(7);
                    Auxiliar.cauacodhu4 = ResultadoConsulta.GetString(8);
                    Auxiliar.fauacodper = ResultadoConsulta.GetString(9);
                    Auxiliar.pauacodusu = ResultadoConsulta.GetString(10);
                    Auxiliar.cauanomlog = ResultadoConsulta.GetString(11);
                    Auxiliar.cauaclausu = ResultadoConsulta.GetString(12);
                    Auxiliar.cauaactcla = ResultadoConsulta.GetBoolean(13);
                    Auxiliar.cauacodhu1 = ResultadoConsulta.GetString(14);
                    Auxiliar.capssexper = ResultadoConsulta.GetBoolean(15);
                    Auxiliar.capsestper = ResultadoConsulta.GetBoolean(16);
                    Auxiliar.capsfecnac = ResultadoConsulta.GetDateTime(17);
                    Auxiliar.capsdirper = ResultadoConsulta.GetString(18);
                    Auxiliar.capsnumcid = ResultadoConsulta.GetString(19);
                    Auxiliar.capscorele = ResultadoConsulta.GetString(20);
                    Auxiliar.papscodper = ResultadoConsulta.GetString(21);
                    Auxiliar.capsfotper = ResultadoConsulta.GetString(22);
                    Auxiliar.capsnomper = ResultadoConsulta.GetString(23);
                    Auxiliar.capsnumcel = ResultadoConsulta.GetString(24);
                    Auxiliar.capsapemat = ResultadoConsulta.GetString(25);
                    Auxiliar.capsapepat = ResultadoConsulta.GetString(26);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }

    }
}
