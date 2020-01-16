using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBling.Entities
{
    class VolumeObjeto
    {
        #region Atributos
        public string pesoField { get; set; }

        public string alturaField { get; set; }

        public string larguraField { get; set; }

        public string comprimentoField { get; set; }

        public string contaLoteField { get; set; }

        public string chaveRoteamentoField { get; set; }

        public string codigoBarraVolumeField { get; set; }

        public string codigoBarraClienteField { get; set; }

        public string observacaoVisualField { get; set; }

        public string observacaoQuatroField { get; set; }

        public string observacaoCincoField { get; set; }

        public string posicaoVolumeField { get; set; }

        public string conteudoField { get; set; }

        public DeclaracaoConteudoVIPP declaracaoConteudoField { get; set; }

        public string valorDeclaradoField { get; set; }

        public string adicionaisVolumeField { get; set; }

        public string vlrACobrarField { get; set; }

        public string etiquetaField { get; set; }

        #endregion

        #region Atributos
        public VolumeObjeto()
        {
            pesoField = string.Empty;

            alturaField = string.Empty;

            larguraField = string.Empty;

            comprimentoField = string.Empty;

            contaLoteField = string.Empty;

            chaveRoteamentoField = string.Empty;

            codigoBarraVolumeField = string.Empty;

            codigoBarraClienteField = string.Empty;

            observacaoVisualField = string.Empty;

            observacaoQuatroField = string.Empty;

            observacaoCincoField = string.Empty;

            posicaoVolumeField = string.Empty;

            conteudoField = string.Empty;

            DeclaracaoConteudoVIPP declaracaoConteudoField = null;

            valorDeclaradoField = string.Empty;

            adicionaisVolumeField = string.Empty;

            vlrACobrarField = string.Empty;

            etiquetaField = string.Empty;

        }
        #endregion



    }
}
