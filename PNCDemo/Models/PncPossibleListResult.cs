using System.Collections.Generic;
using PNCDemo.Models.Possibles;

namespace PNCDemo.Models
{
    public class PncPossibleListResult : PncSuccessResult
    {
        public IList<PncPossible> PncPossibleList { get; set; }
    }
}