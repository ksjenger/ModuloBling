using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBling.Entities
{
    class NotasFiscaisVIPP
    {
        #region Atributos
        public string dtNotaFiscalField { get; set; }

        public string serieNotaFiscalField { get; set; }

        public string nrNotaFiscalField { get; set; }

        public string vlrTotalNotaField { get; set; }

        #endregion

        #region Construtores
        public NotasFiscaisVIPP()
        {
            dtNotaFiscalField = string.Empty;
            serieNotaFiscalField = string.Empty;
            nrNotaFiscalField = string.Empty;
            vlrTotalNotaField = string.Empty;
        }

        #endregion
    }
}
