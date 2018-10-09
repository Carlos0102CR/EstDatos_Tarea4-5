using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria
{
   public class HashNode
    {
        int key;
        string data;
        HashNode next;
        public HashNode(int key, string data)
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
        public void setNextNode(HashNode obj)
        {
            next = obj;
        }
        public HashNode getNextNode()
        {
            return this.next;
        }
    }
}

