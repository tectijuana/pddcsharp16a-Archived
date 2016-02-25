using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enriquezazueta_state
{
    class Program
    {
        static void Main()
      {
       Context c = new Context(new ConcreteStateA());

       // Issue requests, which toggles state
        c.Request();
        c.Request();
        c.Request();
        c.Request();

       // Wait for user
        Console.ReadKey();
         }
        }

        /// <summary>
      abstract class State
      {
       public abstract void Handle(Context context);
       }

       /// <summary>
       class ConcreteStateA : State
        {
        public override void Handle(Context context)
         {
         context.State = new ConcreteStateB();
         }
        }

     /// <summary>
     class ConcreteStateB : State
     {
       public override void Handle(Context context)
        {
          context.State = new ConcreteStateA();
        }
     }

     /// <summary>
    class Context
   {
     private State _state;

     // Constructor
    public Context(State state)
    {
     this.State = state;
      }

    // Gets or sets the state
     public State State
      {
       get { return _state; }
       set
        {
          _state = value;
           Console.WriteLine("State: " +
             _state.GetType().Name);
          }
         }

        public void Request()
      {
         _state.Handle(this);
      }
      }
    }

