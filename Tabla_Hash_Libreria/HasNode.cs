using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria
{
   public class HasNode
    {
        int key;
        string data;
        HasNode next;
        public HasNode(int key, string data)
        {
            this.key = key;
            this.data = data;
            next = null;
        }
        public int getkey()
        {
            return key;
        }
        public string getdata()
        {
            return data;
        }
        public void setNextNode(HasNode obj)
        {
            next = obj;
        }
        public HasNode getNextNode()
        {
            return this.next;
        }
    }
}

