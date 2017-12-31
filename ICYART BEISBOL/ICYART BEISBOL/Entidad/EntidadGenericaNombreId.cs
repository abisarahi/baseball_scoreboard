using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICYART_BEISBOL.Entidad
{
    class EntidadGenericaNombreId
    {
        private string id;
        private string nombreId;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreId
        {
            get { return nombreId; }
            set { nombreId = value; }
        }

        public EntidadGenericaNombreId(string pId, string pNombreId)
        {
            this.id = pId;
            this.nombreId = pNombreId;
        }

        public EntidadGenericaNombreId()
        {

        }
    }
}
