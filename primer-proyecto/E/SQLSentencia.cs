using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E
{
    public class SQLSentencia
    {
        private string SentenciaSQL;
        private ArrayList lstParametros;

        public SQLSentencia()
        {
            this.SentenciaSQL = String.Empty;
            this.lstParametros = new ArrayList();
        }

        public string SENTENCIASQL
        {
            set { this.SentenciaSQL = value; }
            get { return this.SentenciaSQL; }
        }

        public ArrayList LSTPARAMETROS
        {
            set { this.lstParametros = value; }
            get { return this.lstParametros; }
        }

    }
}
