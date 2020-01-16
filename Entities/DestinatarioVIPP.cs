using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBling.Entities
{
    class DestinatarioVIPP
    {
        
        public partial class Destinatario
        {
            #region Atributos
            public string cnpjCpfField { get; set; }

            public string ieRgField { get; set; }

            public string segundaLinhaDestinatarioField { get; set; }

            public string enderecoField { get; set; }

            public string numeroField { get; set; }

            public string complementoField { get; set; }

            public string bairroField { get; set; }

            public string cidadeField { get; set; }

            public string ufField { get; set; }

            public string cepField { get; set; }

            public string telefoneField { get; set; }

            public string celularField { get; set; }

            public string emailField { get; set; }

            #endregion

            #region Construtores
            public Destinatario()
            {
                cnpjCpfField = string.Empty;
                ieRgField = string.Empty;
                segundaLinhaDestinatarioField = string.Empty;
                ieRgField = string.Empty;
                segundaLinhaDestinatarioField = string.Empty;
                enderecoField = string.Empty;
                numeroField = string.Empty;
                complementoField = string.Empty;
                bairroField = string.Empty;
                cidadeField = string.Empty;
                ufField = string.Empty;
                cepField = string.Empty;
                telefoneField = string.Empty;
                celularField = string.Empty;
                emailField = string.Empty;

            }
            #endregion
        }

    }
}
