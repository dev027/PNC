using PNCDemo.Models.Actuals;

namespace PNCDemo.Models
{
    public class PncActualPersonResult : PncActualResult
    {
        public Person Person { get; set; }

        public override string ToString()
        {
            return $"PncActualPersonResult: Msg = \"{Message}\", Person = {Person}";
        }
    }
}