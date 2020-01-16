using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBling.Entities
{
    class PerfilVipp
    {
        #region Atributos

        public string usuarioField { get; set; }

        public string tokenField { get; set; }

        public string idPerfilField { get; set; }

        #endregion

        #region Construtores
        public PerfilVipp()
        {
            usuarioField = string.Empty;
            tokenField = string.Empty;
            idPerfilField = string.Empty;
        }
        #endregion

    }
}
