using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   abstract class Subject
    {
       private IList<Observer> observers=new List<Observer>();

       public void Attach(Observer observer){
           observers.Add(observer);
       }

       public void Dettach(Observer observer) {
           observers.Remove(observer);
       }

       public void Notify()
       {
           foreach (Observer o in observers)
               o.Update();
       }
    }
}
