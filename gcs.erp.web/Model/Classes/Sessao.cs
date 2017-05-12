using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gcs.erp.web.Model.Classes
{
    public class Sessao
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateTime Inicio { get; set; }
    }
}
