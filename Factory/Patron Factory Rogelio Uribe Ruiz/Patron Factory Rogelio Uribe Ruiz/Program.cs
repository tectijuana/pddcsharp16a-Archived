﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Patron_Factory_Rogelio_Uribe_Ruiz
{
    class Program
    {

        public abstract class Cliente
        {



public abstract class Pedido 

{ 

 protected double importe; 

 public Pedido(double importe) 

 { 

 this.importe = importe; 

 } 

 public abstract bool valida(); 

 public abstract void paga(); 

} 
 

public class PedidoContado : Pedido 

{ 

 public PedidoContado(double importe) : base(importe) { } 

 public override void paga() 

 { 

 Console.WriteLine( 

 "El pago del pedido por importe de: " + 

 importe + " se ha realizado."); 

 } 

 public override bool valida() 

 { 

 return true; 

 } 

} 


public class PedidoCredito : Pedido 

{ 

 public PedidoCredito(double importe) : base(importe) { } 

 public override void paga() 

 { 

 Console.WriteLine( 

 "El pago del pedido a crédito de: " + 

 importe + " se ha realizado."); 

 } 

 public override bool valida() 

 { 

 return (importe >= 1000.0) && (importe <= 5000.0); 

 } 

}

            protected IList<Pedido> pedidos =

            new List<Pedido>();

            protected abstract Pedido creaPedido(double importe);

            public void nuevoPedido(double importe)
            {

                Pedido pedido = this.creaPedido(importe);

                if (pedido.valida())
                {

                    pedido.paga();

                    pedidos.Add(pedido);

                }

            }

        }

        public class ClienteContado : Cliente
        {

            protected override Pedido creaPedido(double importe)
            {

                return new PedidoContado(importe);

            }

        }

        public class ClienteCredito : Cliente
        {

            protected override Pedido creaPedido(double importe)
            {

                return new PedidoCredito(importe);

            }

        }


        static void Main(string[] args)
        {
            Cliente cliente;

            cliente = new ClienteContado();

            cliente.nuevoPedido(2000.0);

            cliente.nuevoPedido(10000.0);

            cliente = new ClienteCredito();

            cliente.nuevoPedido(2000.0);

            cliente.nuevoPedido(10000.0);
            Console.ReadKey();
        }
    }
}
