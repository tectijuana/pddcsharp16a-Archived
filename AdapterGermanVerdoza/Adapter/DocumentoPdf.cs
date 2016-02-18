using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class DocumentoPdf:Documento
    {
        protected ComponentePdf hrrafdf = new ComponentePdf();
        public string contenido
        {
            set
            {
                hrrafdf.obtenerpdf(value);
            }
        }

        public void dibuja()
        {
            hrrafdf.prepararpfd();
            hrrafdf.actualizarpdf();
            hrrafdf.finalizarpdf();
        }

        public void imprime()
        {
            hrrafdf.imprimirpdf();
        }
    }
}
