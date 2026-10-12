using CapaAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class litemven
    {

        #region Campos
        private decimal _cdevpreuni;
        private bool _cdevesdeve;
        private int _cdevcantid;
        private decimal _cdevsubtot;
        private string _fdevcodpro;
        private string _fdevcodven;
        private string _pdevcodeve;
        private string _capdmodpro;
        private string _capdnompro;
        private string _capddespro;
        private string _capdcodbar;
        private string _capdtalpro;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public decimal cdevpreuni
        {
            get { return this._cdevpreuni; }
            set { this._cdevpreuni = value; }
        }
        public bool cdevesdeve
        {
            get { return this._cdevesdeve; }
            set { this._cdevesdeve = value; }
        }
        public int cdevcantid
        {
            get { return this._cdevcantid; }
            set { this._cdevcantid = value; }
        }
        public decimal cdevsubtot
        {
            get { return this._cdevsubtot; }
            set { this._cdevsubtot = value; }
        }
        public string fdevcodpro
        {
            get { return this._fdevcodpro; }
            set { this._fdevcodpro = value; }
        }
        public string fdevcodven
        {
            get { return this._fdevcodven; }
            set { this._fdevcodven = value; }
        }
        public string pdevcodeve
        {
            get { return this._pdevcodeve; }
            set { this._pdevcodeve = value; }
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
        public string capddespro
        {
            get { return this._capddespro; }
            set { this._capddespro = value; }
        }
        public string capdcodbar
        {
            get { return this._capdcodbar; }
            set { this._capdcodbar = value; }
        }
        public string capdtalpro
        {
            get { return this._capdtalpro; }
            set { this._capdtalpro = value; }
        }
        #endregion

        #region Constructor
        public litemven()
        {
            this._cdevpreuni = 0;
            this._cdevesdeve = true;
            this._cdevcantid = 0;
            this._cdevsubtot = 0;
            this._fdevcodpro = "";
            this._fdevcodven = "";
            this._pdevcodeve = "";
            this._capdmodpro = "";
            this._capdnompro = "";
            this._capddespro = "";
            this._capdcodbar = "";
            this._capdtalpro = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion
    }
}
