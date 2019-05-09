using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAEntities
{
    public class CFACollection: ICFACollection
    {
        public virtual int GroupCount { get; set; }
        public virtual int TotalScore { get; set; }
    }
}
