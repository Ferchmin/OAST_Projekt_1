using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAST_Projekt_1
{
    class Vertex
    {
        int id;
        List<Edge> edges;

        public Vertex()
        {
            this.id = 0;
            this.edges = new List<Edge>();
        }

        public Vertex(int id)
        {
            this.id = id;
            this.edges = new List<Edge>();
        }

        public Vertex(int id, List<Edge> edges)
        {
            this.id = id;
            this.edges = edges;
        }

    }
}
