using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
public class Vehiculo : Sujeto
{
    protected string _descripcion;
    protected double _precio;

    public string descripcion
    {
        get { return _descripcion; }
        set
        {
            _descripcion = value;
            this.notifica();
        }
    }

    public double precio
    {
        get { return _precio; }

        set
        {
            _precio = value;
            this.notifica();
        }
    }
}