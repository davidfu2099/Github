using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAEntities
{
    public class CFAGarbage: CFACollection, ICFACollection
    {
        public CFAGarbage()
        {
            this.TotalScore = 0;
            this.GroupCount = 0;
        }
    }
}
