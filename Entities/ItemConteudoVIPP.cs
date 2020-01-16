using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBling.Entities
{
    class ItemConteudoVIPP
    {
        #region Atributos
        public string DescricaoConteudoField { get; set; }

        public int QuantidadeField { get; set; }

        public string ValorField { get; set; }

        #endregion

        #region Construtores
        public ItemConteudoVIPP()
        {
            DescricaoConteudoField = string.Empty;
            QuantidadeField = int.MinValue;
            ValorField = string.Empty;
        }
        #endregion
    }
}
