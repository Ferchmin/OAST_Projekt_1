using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAST_Projekt_1
{
    class Edge
    {
        int id;
        Vertex begin;
        Vertex end;
        int capacity;

        public Edge(Vertex begin, Vertex end, int capacity)
        {
            this.id = id;
            this.begin = begin;
            this.end = end;
            this.capacity = capacity;
        }
    }
}
