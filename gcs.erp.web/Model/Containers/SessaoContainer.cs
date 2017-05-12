using gcs.erp.web.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gcs.erp.web.Model.Containers
{
    public class SessaoContainer
    {
        private static Sessao _sessao = null;

        public static Sessao Login()
        {
            _sessao = new Sessao();
            return _sessao;
        }

        public static bool Conectado()
        {
            return _sessao != null;
        }
    }
}
