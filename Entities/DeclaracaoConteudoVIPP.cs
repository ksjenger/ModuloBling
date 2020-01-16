using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBling.Entities
{
    class DeclaracaoConteudoVIPP
    {
        #region Atributos
        public string DocumentoRemetenteField { get; set; }

        public string DocumentoDestinatarioField { get; set; }

        public int PesoTotalField { get; set; }

        public ItemConteudoVIPP[] ItemConteudoField { get; set; }
        #endregion

        #region Construtores
        public DeclaracaoConteudoVIPP()
        {
            DocumentoRemetenteField = string.Empty;
            DocumentoDestinatarioField = string.Empty;
            PesoTotalField = int.MinValue;
        }
        #endregion
    }
}
