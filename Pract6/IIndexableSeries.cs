using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
  interface IIndexableSeries : IIndexable, ISeries
   {
        double this[int index] { get; }
        double GetCurrent();
        bool MoveNext();
        void Reset();
       
    }
}
 /*     double IIndexable.this[int index] => throw new NotImplementedException();

          public double GetCurrent()
          {
              throw new NotImplementedException();
          }

          public bool MoveNext()
          {
              throw new NotImplementedException();
          }

          public void Reset()
          {
              throw new NotImplementedException();
          }*/