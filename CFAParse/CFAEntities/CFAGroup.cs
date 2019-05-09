using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAEntities
{
    public class CFAGroup:CFACollection, ICFACollection
    {
        public List<ICFACollection> cFACollections;
        public int Depth;
        public CFAGroup(int depth)
        {
            this.Depth = depth;
            this.GroupCount = 1;
            cFACollections = new List<ICFACollection>();
            this.TotalScore = 1;
        }

        public void AddCollection(ICFACollection cFACollection)
        {
            this.GroupCount += cFACollection.GroupCount;
            this.cFACollections.Add(cFACollection);
            this.TotalScore += cFACollection.TotalScore + cFACollection.GroupCount; 
        }

    }
}
