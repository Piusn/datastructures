using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.Graph
{
    public class DisjointSet
    {
    }

    #region Disjoint Node

    public class DisjointNode
    {
        public int Rank { get; set; }
        public DisjointNode Parent { get; set; }
        public int Data { get; set; }
    }

    #endregion
}
