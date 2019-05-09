using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAEntities
{
    public interface ICFACollection
    {
        int TotalScore { get; set; }
        int GroupCount { get; set; }
    }
}
