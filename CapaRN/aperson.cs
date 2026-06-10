using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common;
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
    public class aperson
    {

        #region Campos
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
        public aperson()
        {
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

        #region Metodos
        public bool ObtenerDatos()
        {
            this.Conexion.Conectar();
            string sql = "select " +
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
                         "from aperson " +
                         "where " +
                                "papscodper = @papscodper";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@papscodper", this._papscodper);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._capssexper = ResultadoConsulta.GetBoolean(0);
                this._capsestper = ResultadoConsulta.GetBoolean(1);
                this._capsfecnac = ResultadoConsulta.GetDateTime(2);
                this._capsdirper = ResultadoConsulta.GetString(3);
                this._capsnumcid = ResultadoConsulta.GetString(4);
                this._capscorele = ResultadoConsulta.GetString(5);
                this._papscodper = ResultadoConsulta.GetString(6);
                this._capsfotper = ResultadoConsulta.GetString(7);
                this._capsnomper = ResultadoConsulta.GetString(8);
                this._capsnumcel = ResultadoConsulta.GetString(9);
                this._capsapemat = ResultadoConsulta.GetString(10);
                this._capsapepat = ResultadoConsulta.GetString(11);
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
                         "from aperson " +
                         "where " +
                                "papscodper = @papscodper";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@papscodper", this._papscodper);

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
                string sql = "insert into aperson (" +
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
                                                   "capsapepat" +
                                                   ") " +
                             "values (" +
                                      "@capssexper," +
                                      "@capsestper," +
                                      "@capsfecnac," +
                                      "@capsdirper," +
                                      "@capsnumcid," +
                                      "@capscorele," +
                                      "@papscodper," +
                                      "@capsfotper," +
                                      "@capsnomper," +
                                      "@capsnumcel," +
                                      "@capsapemat," +
                                      "@capsapepat" +
                                                   ")";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroLogico("@capssexper", this._capssexper);
                this.Conexion.AsignarParametroLogico("@capsestper", this._capsestper);
                this.Conexion.AsignarParametroFecha("@capsfecnac", this._capsfecnac);
                this.Conexion.AsignarParametroCadena("@capsdirper", this._capsdirper);
                this.Conexion.AsignarParametroCadena("@capsnumcid", this._capsnumcid);
                this.Conexion.AsignarParametroCadena("@capscorele", this._capscorele);
                this.Conexion.AsignarParametroCadena("@papscodper", this._papscodper);
                this.Conexion.AsignarParametroCadena("@capsfotper", this._capsfotper);
                this.Conexion.AsignarParametroCadena("@capsnomper", this._capsnomper);
                this.Conexion.AsignarParametroCadena("@capsnumcel", this._capsnumcel);
                this.Conexion.AsignarParametroCadena("@capsapemat", this._capsapemat);
                this.Conexion.AsignarParametroCadena("@capsapepat", this._capsapepat);

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
                string sql = "update aperson set " +
                                                 "capssexper = @capssexper, " +
                                                 "capsestper = @capsestper, " +
                                                 "capsfecnac = @capsfecnac, " +
                                                 "capsdirper = @capsdirper, " +
                                                 "capsnumcid = @capsnumcid, " +
                                                 "capscorele = @capscorele, " +
                                                 "capsfotper = @capsfotper, " +
                                                 "capsnomper = @capsnomper, " +
                                                 "capsnumcel = @capsnumcel, " +
                                                 "capsapemat = @capsapemat, " +
                                                 "capsapepat = @capsapepat" +
                             " where " +
                                    "papscodper = @papscodper";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroLogico("@capssexper", this._capssexper);
                this.Conexion.AsignarParametroLogico("@capsestper", this._capsestper);
                this.Conexion.AsignarParametroFecha("@capsfecnac", this._capsfecnac);
                this.Conexion.AsignarParametroCadena("@capsdirper", this._capsdirper);
                this.Conexion.AsignarParametroCadena("@capsnumcid", this._capsnumcid);
                this.Conexion.AsignarParametroCadena("@capscorele", this._capscorele);
                this.Conexion.AsignarParametroCadena("@papscodper", this._papscodper);
                this.Conexion.AsignarParametroCadena("@capsfotper", this._capsfotper);
                this.Conexion.AsignarParametroCadena("@capsnomper", this._capsnomper);
                this.Conexion.AsignarParametroCadena("@capsnumcel", this._capsnumcel);
                this.Conexion.AsignarParametroCadena("@capsapemat", this._capsapemat);
                this.Conexion.AsignarParametroCadena("@capsapepat", this._capsapepat);

                this.Conexion.EjecutarTransaccion();
                this.Conexion.Desconectar();

                return true;
            }
        }
        public List<aperson> Lista(string where)
        {
            List<aperson> ListaResultado = new List<aperson>();
            this.Conexion.Conectar();
            string sql = "select " +
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
                         "from aperson ";

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
                    aperson Auxiliar = new aperson();
                    Auxiliar.capssexper = ResultadoConsulta.GetBoolean(0);
                    Auxiliar.capsestper = ResultadoConsulta.GetBoolean(1);
                    Auxiliar.capsfecnac = ResultadoConsulta.GetDateTime(2);
                    Auxiliar.capsdirper = ResultadoConsulta.GetString(3);
                    Auxiliar.capsnumcid = ResultadoConsulta.GetString(4);
                    Auxiliar.capscorele = ResultadoConsulta.GetString(5);
                    Auxiliar.papscodper = ResultadoConsulta.GetString(6);
                    Auxiliar.capsfotper = ResultadoConsulta.GetString(7);
                    Auxiliar.capsnomper = ResultadoConsulta.GetString(8);
                    Auxiliar.capsnumcel = ResultadoConsulta.GetString(9);
                    Auxiliar.capsapemat = ResultadoConsulta.GetString(10);
                    Auxiliar.capsapepat = ResultadoConsulta.GetString(11);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion

    }
}

