using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{


        public abstract class Documentacion 
{ 
protected IList<string> contenido = 
new List<string>(); 
public abstract void agregaDocumento(string documento); 
public abstract void imprime(); 
} 
 
public class DocumentacionHtml : Documentacion 
{ 
public override void agregaDocumento(string documento) 
{ 
if (documento.StartsWith("<HTML>")) 
contenido.Add(documento); 
} 
public override void imprime() 
{ 
Console.WriteLine("Documentación HTML"); 
foreach (string s in contenido) 
Console.WriteLine(s); 
} 
} 

public class DocumentacionPdf : Documentacion 
{ 
    public override void agregaDocumento(string documento) 
    { 
        if (documento.StartsWith("<PDF>")) 
        contenido.Add(documento); 
    } 
    public override void imprime() 
    { 
        Console.WriteLine("Documentación PDF"); 
        foreach (string s in contenido) 
        Console.WriteLine(s); 
    } 
}

public abstract class ConstructorDocumentacionVehiculo 
    { 
        protected Documentacion documentacion; 
        public abstract void construyeSolicitudPedido(string 
        nombreCliente); 
        public abstract void construyeSolicitudMatriculacion 
        (string nombreSolicitante); 
        public Documentacion resultado() 
        { 
        return documentacion; 
        } 
    } 

public class ConstructorDocumentacionVehiculoHtml : ConstructorDocumentacionVehiculo 
    { 
    public ConstructorDocumentacionVehiculoHtml() 
        { 
        documentacion = new DocumentacionHtml(); 
    } 
    public override void construyeSolicitudPedido(string 
    nombreCliente) 
    { 
    string documento; 
    documento = "<HTML>Solicitud de pedido Cliente: " + 
    nombreCliente + "</HTML>"; 
    documentacion.agregaDocumento(documento); 
    } 
    public override void construyeSolicitudMatriculacion 
    (string nombreSolicitante) 
    { 
    string documento; 
    documento = 
    "<HTML>Solicitud de matriculación Solicitante: " + 
    nombreSolicitante + "</HTML>"; 
        documentacion.agregaDocumento(documento); 
    } 
    } 

    public class ConstructorDocumentacionVehiculoPdf : 
    ConstructorDocumentacionVehiculo 
    { 
    public ConstructorDocumentacionVehiculoPdf() 
    { 
    documentacion = new DocumentacionPdf(); 
    } 
    public override void construyeSolicitudPedido(string 
    nombreCliente) 
    { 
    string documento; 
    documento = "<PDF>Solicitud de pedido Cliente: " + 
    nombreCliente + "</PDF>"; 
    documentacion.agregaDocumento(documento); 
    } 
    public override void construyeSolicitudMatriculacion 
    (string nombreSolicitante) 
    { 
    string documento;
    documento ="<PDF>Solicitud de matriculación Solicitante: " +
    nombreSolicitante + "</PDF>";
        documentacion.agregaDocumento(documento);
        }
    }

    public class Vendedor
    {
        protected ConstructorDocumentacionVehiculo constructor;
        public Vendedor(ConstructorDocumentacionVehiculo constructor)
        {
            this.constructor = constructor;
        }
        public Documentacion construye(string nombreCliente)
        {
            constructor.construyeSolicitudPedido(nombreCliente);
            constructor.construyeSolicitudMatriculacion
                (nombreCliente);
            Documentacion documentacion = constructor.resultado();
            return documentacion;
        }
    }



    
    class Program
    {
       
    static void Main(string[] args) 
    { 
            ConstructorDocumentacionVehiculo constructor; 
            Console.WriteLine("Desea generar " + 
            "documentación HTML (1) o PDF (2):"); 
            string seleccion = Console.ReadLine(); 
            if (seleccion == "1") 
            { 
            constructor = new ConstructorDocumentacionVehiculoHtml(); 
            } 
            else 
            { 
            constructor = new ConstructorDocumentacionVehiculoPdf();
            } 
            Vendedor vendedor = new Vendedor(constructor); 
            Documentacion documentacion = vendedor.construye("Martín"); 
            documentacion.imprime();
            Console.ReadKey(); 
        } 
    }
    }

