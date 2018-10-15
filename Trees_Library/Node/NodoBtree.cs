using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArbolAVL;

namespace Trees_Library.Node
{
  public  class NodoBtree: Nodo
    {
        public Nodo siguiente { get; set; }
        public Nodo Atras { get; set; }
    }
}
