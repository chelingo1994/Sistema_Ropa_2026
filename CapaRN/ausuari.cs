using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common;
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
    public class ausuari
    {

        #region Campos
        private bool _cauaactcla;
        private int _cauamashue;
        private int _cauanumhu1;
        private int _cauanumhu2;
        private int _cauanumhu3;
        private int _cauanumhu4;
        private bool _cauaestusu;
        private string _cauacodhu4;
        private string _fauacodper;
        private string _pauacodusu;
        private string _cauanomlog;
        private string _cauaclausu;
        private string _cauacodhu1;
        private string _cauacodhu2;
        private string _cauacodhu3;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public bool cauaactcla
        {
            get { return this._cauaactcla; }
            set { this._cauaactcla = value; }
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
        public bool cauaestusu
        {
            get { return this._cauaestusu; }
            set { this._cauaestusu = value; }
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
        public string cauacodhu1
        {
            get { return this._cauacodhu1; }
            set { this._cauacodhu1 = value; }
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
        #endregion

        #region Constructor
        public ausuari()
        {
            this._cauaactcla = true;
            this._cauamashue = 0;
            this._cauanumhu1 = 0;
            this._cauanumhu2 = 0;
            this._cauanumhu3 = 0;
            this._cauanumhu4 = 0;
            this._cauaestusu = true;
            this._cauacodhu4 = "";
            this._fauacodper = "";
            this._pauacodusu = "";
            this._cauanomlog = "";
            this._cauaclausu = "";
            this._cauacodhu1 = "";
            this._cauacodhu2 = "";
            this._cauacodhu3 = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        public bool ObtenerDatos()
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cauaactcla," +
                                 "cauamashue," +
                                 "cauanumhu1," +
                                 "cauanumhu2," +
                                 "cauanumhu3," +
                                 "cauanumhu4," +
                                 "cauaestusu," +
                                 "cauacodhu4," +
                                 "fauacodper," +
                                 "pauacodusu," +
                                 "cauanomlog," +
                                 "cauaclausu," +
                                 "cauacodhu1," +
                                 "cauacodhu2," +
                                 "cauacodhu3 " +
                         "from ausuari " +
                         "where " +
                                "pauacodusu = @pauacodusu";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@pauacodusu", this._pauacodusu);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._cauaactcla = ResultadoConsulta.GetBoolean(0);
                this._cauamashue = ResultadoConsulta.GetInt32(1);
                this._cauanumhu1 = ResultadoConsulta.GetInt32(2);
                this._cauanumhu2 = ResultadoConsulta.GetInt32(3);
                this._cauanumhu3 = ResultadoConsulta.GetInt32(4);
                this._cauanumhu4 = ResultadoConsulta.GetInt32(5);
                this._cauaestusu = ResultadoConsulta.GetBoolean(6);
                this._cauacodhu4 = ResultadoConsulta.GetString(7);
                this._fauacodper = ResultadoConsulta.GetString(8);
                this._pauacodusu = ResultadoConsulta.GetString(9);
                this._cauanomlog = ResultadoConsulta.GetString(10);
                this._cauaclausu = ResultadoConsulta.GetString(11);
                this._cauacodhu1 = ResultadoConsulta.GetString(12);
                this._cauacodhu2 = ResultadoConsulta.GetString(13);
                this._cauacodhu3 = ResultadoConsulta.GetString(14);
                this.Conexion.Desconectar();

                return true;
            }
            else
            {
                this.Conexion.Desconectar();
                return false;
            }
        }
        public bool ObtenerDatosLogin(bool modificar,String login)
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cauaactcla," +
                                 "cauamashue," +
                                 "cauanumhu1," +
                                 "cauanumhu2," +
                                 "cauanumhu3," +
                                 "cauanumhu4," +
                                 "cauaestusu," +
                                 "cauacodhu4," +
                                 "fauacodper," +
                                 "pauacodusu," +
                                 "cauanomlog," +
                                 "cauaclausu," +
                                 "cauacodhu1," +
                                 "cauacodhu2," +
                                 "cauacodhu3 " +
                         "from ausuari " +
                         "where " +
                                "cauanomlog = @cauanomlog";
            if (modificar)
            {
                sql += " and cauanomlog!='" + login + "'";
            }

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@cauanomlog", this._cauanomlog);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._cauaactcla = ResultadoConsulta.GetBoolean(0);
                this._cauamashue = ResultadoConsulta.GetInt32(1);
                this._cauanumhu1 = ResultadoConsulta.GetInt32(2);
                this._cauanumhu2 = ResultadoConsulta.GetInt32(3);
                this._cauanumhu3 = ResultadoConsulta.GetInt32(4);
                this._cauanumhu4 = ResultadoConsulta.GetInt32(5);
                this._cauaestusu = ResultadoConsulta.GetBoolean(6);
                this._cauacodhu4 = ResultadoConsulta.GetString(7);
                this._fauacodper = ResultadoConsulta.GetString(8);
                this._pauacodusu = ResultadoConsulta.GetString(9);
                this._cauanomlog = ResultadoConsulta.GetString(10);
                this._cauaclausu = ResultadoConsulta.GetString(11);
                this._cauacodhu1 = ResultadoConsulta.GetString(12);
                this._cauacodhu2 = ResultadoConsulta.GetString(13);
                this._cauacodhu3 = ResultadoConsulta.GetString(14);
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
                                 "cauaactcla," +
                                 "cauamashue," +
                                 "cauanumhu1," +
                                 "cauanumhu2," +
                                 "cauanumhu3," +
                                 "cauanumhu4," +
                                 "cauaestusu," +
                                 "cauacodhu4," +
                                 "fauacodper," +
                                 "pauacodusu," +
                                 "cauanomlog," +
                                 "cauaclausu," +
                                 "cauacodhu1," +
                                 "cauacodhu2," +
                                 "cauacodhu3 " +
                         "from ausuari " +
                         "where " +
                                "pauacodusu = @pauacodusu";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@pauacodusu", this._pauacodusu);

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
                string sql = "insert into ausuari (" +
                                                   "cauaactcla," +
                                                   "cauamashue," +
                                                   "cauanumhu1," +
                                                   "cauanumhu2," +
                                                   "cauanumhu3," +
                                                   "cauanumhu4," +
                                                   "cauaestusu," +
                                                   "cauacodhu4," +
                                                   "fauacodper," +
                                                   "pauacodusu," +
                                                   "cauanomlog," +
                                                   "cauaclausu," +
                                                   "cauacodhu1," +
                                                   "cauacodhu2," +
                                                   "cauacodhu3" +
                                                   ") " +
                             "values (" +
                                      "@cauaactcla," +
                                      "@cauamashue," +
                                      "@cauanumhu1," +
                                      "@cauanumhu2," +
                                      "@cauanumhu3," +
                                      "@cauanumhu4," +
                                      "@cauaestusu," +
                                      "@cauacodhu4," +
                                      "@fauacodper," +
                                      "@pauacodusu," +
                                      "@cauanomlog," +
                                      "@cauaclausu," +
                                      "@cauacodhu1," +
                                      "@cauacodhu2," +
                                      "@cauacodhu3" +
                                                   ")";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroLogico("@cauaactcla", this._cauaactcla);
                this.Conexion.AsignarParametroEntero("@cauamashue", this._cauamashue);
                this.Conexion.AsignarParametroEntero("@cauanumhu1", this._cauanumhu1);
                this.Conexion.AsignarParametroEntero("@cauanumhu2", this._cauanumhu2);
                this.Conexion.AsignarParametroEntero("@cauanumhu3", this._cauanumhu3);
                this.Conexion.AsignarParametroEntero("@cauanumhu4", this._cauanumhu4);
                this.Conexion.AsignarParametroLogico("@cauaestusu", this._cauaestusu);
                this.Conexion.AsignarParametroCadena("@cauacodhu4", this._cauacodhu4);
                this.Conexion.AsignarParametroCadena("@fauacodper", this._fauacodper);
                this.Conexion.AsignarParametroCadena("@pauacodusu", this._pauacodusu);
                this.Conexion.AsignarParametroCadena("@cauanomlog", this._cauanomlog);
                this.Conexion.AsignarParametroCadena("@cauaclausu", this._cauaclausu);
                this.Conexion.AsignarParametroCadena("@cauacodhu1", this._cauacodhu1);
                this.Conexion.AsignarParametroCadena("@cauacodhu2", this._cauacodhu2);
                this.Conexion.AsignarParametroCadena("@cauacodhu3", this._cauacodhu3);

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
                string sql = "update ausuari set " +
                                                 "cauaactcla = @cauaactcla, " +
                                                 "cauamashue = @cauamashue, " +
                                                 "cauanumhu1 = @cauanumhu1, " +
                                                 "cauanumhu2 = @cauanumhu2, " +
                                                 "cauanumhu3 = @cauanumhu3, " +
                                                 "cauanumhu4 = @cauanumhu4, " +
                                                 "cauaestusu = @cauaestusu, " +
                                                 "cauacodhu4 = @cauacodhu4, " +
                                                 "fauacodper = @fauacodper, " +
                                                 "cauanomlog = @cauanomlog, " +
                                                 "cauaclausu = @cauaclausu, " +
                                                 "cauacodhu1 = @cauacodhu1, " +
                                                 "cauacodhu2 = @cauacodhu2, " +
                                                 "cauacodhu3 = @cauacodhu3" +
                             " where " +
                                    "pauacodusu = @pauacodusu";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroLogico("@cauaactcla", this._cauaactcla);
                this.Conexion.AsignarParametroEntero("@cauamashue", this._cauamashue);
                this.Conexion.AsignarParametroEntero("@cauanumhu1", this._cauanumhu1);
                this.Conexion.AsignarParametroEntero("@cauanumhu2", this._cauanumhu2);
                this.Conexion.AsignarParametroEntero("@cauanumhu3", this._cauanumhu3);
                this.Conexion.AsignarParametroEntero("@cauanumhu4", this._cauanumhu4);
                this.Conexion.AsignarParametroLogico("@cauaestusu", this._cauaestusu);
                this.Conexion.AsignarParametroCadena("@cauacodhu4", this._cauacodhu4);
                this.Conexion.AsignarParametroCadena("@fauacodper", this._fauacodper);
                this.Conexion.AsignarParametroCadena("@pauacodusu", this._pauacodusu);
                this.Conexion.AsignarParametroCadena("@cauanomlog", this._cauanomlog);
                this.Conexion.AsignarParametroCadena("@cauaclausu", this._cauaclausu);
                this.Conexion.AsignarParametroCadena("@cauacodhu1", this._cauacodhu1);
                this.Conexion.AsignarParametroCadena("@cauacodhu2", this._cauacodhu2);
                this.Conexion.AsignarParametroCadena("@cauacodhu3", this._cauacodhu3);

                this.Conexion.EjecutarTransaccion();
                this.Conexion.Desconectar();

                return true;
            }
        }
        public List<ausuari> Lista(string where)
        {
            List<ausuari> ListaResultado = new List<ausuari>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cauaactcla," +
                                 "cauamashue," +
                                 "cauanumhu1," +
                                 "cauanumhu2," +
                                 "cauanumhu3," +
                                 "cauanumhu4," +
                                 "cauaestusu," +
                                 "cauacodhu4," +
                                 "fauacodper," +
                                 "pauacodusu," +
                                 "cauanomlog," +
                                 "cauaclausu," +
                                 "cauacodhu1," +
                                 "cauacodhu2," +
                                 "cauacodhu3 " +
                         "from ausuari ";

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
                    ausuari Auxiliar = new ausuari();
                    Auxiliar.cauaactcla = ResultadoConsulta.GetBoolean(0);
                    Auxiliar.cauamashue = ResultadoConsulta.GetInt32(1);
                    Auxiliar.cauanumhu1 = ResultadoConsulta.GetInt32(2);
                    Auxiliar.cauanumhu2 = ResultadoConsulta.GetInt32(3);
                    Auxiliar.cauanumhu3 = ResultadoConsulta.GetInt32(4);
                    Auxiliar.cauanumhu4 = ResultadoConsulta.GetInt32(5);
                    Auxiliar.cauaestusu = ResultadoConsulta.GetBoolean(6);
                    Auxiliar.cauacodhu4 = ResultadoConsulta.GetString(7);
                    Auxiliar.fauacodper = ResultadoConsulta.GetString(8);
                    Auxiliar.pauacodusu = ResultadoConsulta.GetString(9);
                    Auxiliar.cauanomlog = ResultadoConsulta.GetString(10);
                    Auxiliar.cauaclausu = ResultadoConsulta.GetString(11);
                    Auxiliar.cauacodhu1 = ResultadoConsulta.GetString(12);
                    Auxiliar.cauacodhu2 = ResultadoConsulta.GetString(13);
                    Auxiliar.cauacodhu3 = ResultadoConsulta.GetString(14);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion

    }
}

