using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aperson {

		#region Campos
            private bool _capsexo;
            private bool _capsestper;
            private DateTime _capsfecnac;
            private string _capsdirecc;
            private string _capsdni;
            private string _capsnumcel;
            private string _capsapemat;
            private string _capsfotogr;
            private string _capsnombre;
            private string _capsapepat;
            private string _fapscodper;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool capsexo
            { 
                get{ return this._capsexo;}
                set{ this._capsexo = value;}
            } 
		    public bool capsestper
            { 
                get{ return this._capsestper;}
                set{ this._capsestper = value;}
            } 
		    public DateTime capsfecnac
            { 
                get{ return this._capsfecnac;}
                set{ this._capsfecnac = value;}
            } 
		    public string capsdirecc
            { 
                get{ return this._capsdirecc;}
                set{ this._capsdirecc = value;}
            } 
		    public string capsdni
            { 
                get{ return this._capsdni;}
                set{ this._capsdni = value;}
            } 
		    public string capsnumcel
            { 
                get{ return this._capsnumcel;}
                set{ this._capsnumcel = value;}
            } 
		    public string capsapemat
            { 
                get{ return this._capsapemat;}
                set{ this._capsapemat = value;}
            } 
		    public string capsfotogr
            { 
                get{ return this._capsfotogr;}
                set{ this._capsfotogr = value;}
            } 
		    public string capsnombre
            { 
                get{ return this._capsnombre;}
                set{ this._capsnombre = value;}
            } 
		    public string capsapepat
            { 
                get{ return this._capsapepat;}
                set{ this._capsapepat = value;}
            } 
		    public string fapscodper
            { 
                get{ return this._fapscodper;}
                set{ this._fapscodper = value;}
            } 
        #endregion

        #region Constructor
            public aperson()
            { 
		        this._capsexo = true;
		        this._capsestper = true;
		        this._capsfecnac = DateTime.Now;
		        this._capsdirecc = "";
		        this._capsdni = "";
		        this._capsnumcel = "";
		        this._capsapemat = "";
		        this._capsfotogr = "";
		        this._capsnombre = "";
		        this._capsapepat = "";
		        this._fapscodper = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capsexo," +
                                     "capsestper," +
                                     "capsfecnac," +
                                     "capsdirecc," +
                                     "capsdni," +
                                     "capsnumcel," +
                                     "capsapemat," +
                                     "capsfotogr," +
                                     "capsnombre," +
                                     "capsapepat," +
                                     "fapscodper " + 
                             "from aperson " +
                             "";

                this.Conexion.PrepararComando(sql);


                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capsexo=ResultadoConsulta.GetBoolean(0);
                    this._capsestper=ResultadoConsulta.GetBoolean(1);
                    this._capsfecnac=ResultadoConsulta.GetDateTime(2);
                    this._capsdirecc=ResultadoConsulta.GetString(3);
                    this._capsdni=ResultadoConsulta.GetString(4);
                    this._capsnumcel=ResultadoConsulta.GetString(5);
                    this._capsapemat=ResultadoConsulta.GetString(6);
                    this._capsfotogr=ResultadoConsulta.GetString(7);
                    this._capsnombre=ResultadoConsulta.GetString(8);
                    this._capsapepat=ResultadoConsulta.GetString(9);
                    this._fapscodper=ResultadoConsulta.GetString(10);
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
                                     "capsexo," +
                                     "capsestper," +
                                     "capsfecnac," +
                                     "capsdirecc," +
                                     "capsdni," +
                                     "capsnumcel," +
                                     "capsapemat," +
                                     "capsfotogr," +
                                     "capsnombre," +
                                     "capsapepat," +
                                     "fapscodper " + 
                             "from aperson " +
                             "";
 
                this.Conexion.PrepararComando(sql); 


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
                                                       "capsexo," +
                                                       "capsestper," +
                                                       "capsfecnac," +
                                                       "capsdirecc," +
                                                       "capsdni," +
                                                       "capsnumcel," +
                                                       "capsapemat," +
                                                       "capsfotogr," +
                                                       "capsnombre," +
                                                       "capsapepat," +
                                                       "fapscodper" +
                                                       ") " +
	                             "values (" + 
                                          "@capsexo," +
                                          "@capsestper," +
                                          "@capsfecnac," +
                                          "@capsdirecc," +
                                          "@capsdni," +
                                          "@capsnumcel," +
                                          "@capsapemat," +
                                          "@capsfotogr," +
                                          "@capsnombre," +
                                          "@capsapepat," +
                                          "@fapscodper" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capsexo",this._capsexo);
                    this.Conexion.AsignarParametroLogico("@capsestper",this._capsestper);
                    this.Conexion.AsignarParametroFecha("@capsfecnac",this._capsfecnac);
                    this.Conexion.AsignarParametroCadena("@capsdirecc",this._capsdirecc);
                    this.Conexion.AsignarParametroCadena("@capsdni",this._capsdni);
                    this.Conexion.AsignarParametroCadena("@capsnumcel",this._capsnumcel);
                    this.Conexion.AsignarParametroCadena("@capsapemat",this._capsapemat);
                    this.Conexion.AsignarParametroCadena("@capsfotogr",this._capsfotogr);
                    this.Conexion.AsignarParametroCadena("@capsnombre",this._capsnombre);
                    this.Conexion.AsignarParametroCadena("@capsapepat",this._capsapepat);
                    this.Conexion.AsignarParametroCadena("@fapscodper",this._fapscodper);

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
                                                     "capsexo = @capsexo, " +
                                                     "capsestper = @capsestper, " +
                                                     "capsfecnac = @capsfecnac, " +
                                                     "capsdirecc = @capsdirecc, " +
                                                     "capsdni = @capsdni, " +
                                                     "capsnumcel = @capsnumcel, " +
                                                     "capsapemat = @capsapemat, " +
                                                     "capsfotogr = @capsfotogr, " +
                                                     "capsnombre = @capsnombre, " +
                                                     "capsapepat = @capsapepat, " +
                                                     "fapscodper = @fapscodper" +
                                 " ";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@capsexo",this._capsexo);
                    this.Conexion.AsignarParametroLogico("@capsestper",this._capsestper);
                    this.Conexion.AsignarParametroFecha("@capsfecnac",this._capsfecnac);
                    this.Conexion.AsignarParametroCadena("@capsdirecc",this._capsdirecc);
                    this.Conexion.AsignarParametroCadena("@capsdni",this._capsdni);
                    this.Conexion.AsignarParametroCadena("@capsnumcel",this._capsnumcel);
                    this.Conexion.AsignarParametroCadena("@capsapemat",this._capsapemat);
                    this.Conexion.AsignarParametroCadena("@capsfotogr",this._capsfotogr);
                    this.Conexion.AsignarParametroCadena("@capsnombre",this._capsnombre);
                    this.Conexion.AsignarParametroCadena("@capsapepat",this._capsapepat);
                    this.Conexion.AsignarParametroCadena("@fapscodper",this._fapscodper);

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
                                     "capsexo," +
                                     "capsestper," +
                                     "capsfecnac," +
                                     "capsdirecc," +
                                     "capsdni," +
                                     "capsnumcel," +
                                     "capsapemat," +
                                     "capsfotogr," +
                                     "capsnombre," +
                                     "capsapepat," +
                                     "fapscodper " + 
                             "from aperson " ;
 
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
                          aperson Auxiliar = new aperson();
                          Auxiliar.capsexo = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.capsestper = ResultadoConsulta.GetBoolean(1);
                          Auxiliar.capsfecnac = ResultadoConsulta.GetDateTime(2);
                          Auxiliar.capsdirecc = ResultadoConsulta.GetString(3);
                          Auxiliar.capsdni = ResultadoConsulta.GetString(4);
                          Auxiliar.capsnumcel = ResultadoConsulta.GetString(5);
                          Auxiliar.capsapemat = ResultadoConsulta.GetString(6);
                          Auxiliar.capsfotogr = ResultadoConsulta.GetString(7);
                          Auxiliar.capsnombre = ResultadoConsulta.GetString(8);
                          Auxiliar.capsapepat = ResultadoConsulta.GetString(9);
                          Auxiliar.fapscodper = ResultadoConsulta.GetString(10);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

