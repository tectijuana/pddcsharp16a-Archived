using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{

    public abstract class Documento 
{ 
protected string contenido = ""; 
public Documento duplica() 
{ 
Documento resultado; 
resultado = (Documento)this.MemberwiseClone(); 
return resultado; 
} 
public void rellena(string informacion) 
{ 
contenido = informacion; 
} 
public abstract void imprime(); 
public abstract void visualiza(); 
} 
 
public class OrdenDePedido : Documento 
{ 
public override void visualiza() 
{ 
Console.WriteLine("Muestra la orden de pedido: " + 
contenido); 
} 
public override void imprime() 
{ 
Console.WriteLine("Imprime la orden de pedido: " + 
contenido); 
} 
} 

public class SolicitudMatriculacion : Documento 
{ 
public override void visualiza() 
{ 
Console.WriteLine( 
"Muestra la solicitud de matriculación: " + contenido); 
} 
public override void imprime() 
{ 
Console.WriteLine( 
"Imprime la solicitud de matriculación: " + contenido); 
} 
}


    public class CertificadoCesion : Documento 
{ 
public override void visualiza() 
{ 
Console.WriteLine( 
"Muestra el certificado de cesión: " + contenido); 
} 
public override void imprime() 
{ 
Console.WriteLine( 
"Imprime el certificado de cesión: " + contenido); 
} 
}


    public abstract class Documentacion 
{ 
public IList<Documento> documentos { get; protected set; } 
}



    public class DocumentacionEnBlanco : Documentacion 
{ 
private static DocumentacionEnBlanco _instance = null; 
private DocumentacionEnBlanco() 
{ 
documentos = new List<Documento>(); 
} 
public static DocumentacionEnBlanco Instance() 
{ 
if (_instance == null) 
_instance = new DocumentacionEnBlanco(); 
return _instance; 
} 
public void incluye(Documento doc) 
{ 
documentos.Add(doc); 
} 
public void excluye(Documento doc) 
{ 
documentos.Remove(doc); 
} 
}public class DocumentacionCliente : Documentacion 
{ 
public DocumentacionCliente(string informacion) 
{ 
documentos = new List<Documento>(); 
DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance(); 
IList<Documento> documentosEnBlanco = 
documentacionEnBlanco.documentos; 
foreach (Documento documento in documentosEnBlanco) 
{ 
Documento copiaDocumento = documento.duplica(); 
copiaDocumento.rellena(informacion); 
documentos.Add(copiaDocumento); 
} 
} 
public void visualiza() 
{ 
foreach (Documento documento in documentos) 
documento.visualiza(); 
} 
public void imprime() 
{ 
foreach (Documento documento in documentos) 
documento.imprime(); 
} 
}


    class Program
    {
        static void Main(string[] args)
        {
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance(); 
            documentacionEnBlanco.incluye(new OrdenDePedido()); 
            documentacionEnBlanco.incluye(new CertificadoCesion()); 
            documentacionEnBlanco.incluye(new SolicitudMatriculacion()); 
            // creación de documentación nueva para dos clientes 
            DocumentacionCliente documentacionCliente1 = new DocumentacionCliente("Martín"); 
            DocumentacionCliente documentacionCliente2 = new DocumentacionCliente("Simón"); 
            documentacionCliente1.visualiza(); 
            documentacionCliente2.visualiza();
            Console.ReadKey();

        }
    }
}
