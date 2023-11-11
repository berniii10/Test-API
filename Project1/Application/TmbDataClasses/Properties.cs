using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.TmbDataClasses
{
    public class Properties
    {
        public int ID_LINIA { get; set; }
        public int CODI_LINIA { get; set; }
        public string NOM_LINIA { get; set; }
        public string DESC_LINIA { get; set; }
        public string ORIGEN_LINIA { get; set; }
        public string DESTI_LINIA { get; set; }
        public int NUM_PAQUETS { get; set; }
        public int ID_OPERADOR { get; set; }
        public string NOM_OPERADOR { get; set; }
        public string NOM_TIPUS_TRANSPORT { get; set; }
        public int CODI_FAMILIA { get; set; }
        public string NOM_FAMILIA { get; set; }
        public int ORDRE_FAMILIA { get; set; }
        public int ORDRE_LINIA { get; set; }
        public string CODI_TIPUS_CALENDARI { get; set; }
        public string NOM_TIPUS_CALENDARI { get; set; }
        public string DATA { get; set; }
        public string COLOR_LINIA { get; set; }
        public string COLOR_AUX_LINIA { get; set; }
        public string COLOR_TEXT_LINIA { get; set; }
        public string name { get; set; }
    }
}
