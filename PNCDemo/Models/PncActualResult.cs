namespace PNCDemo.Models
{
    public abstract class PncActualResult : PncSuccessResult
    {
        public override string ToString()
        {
            return $"PncActualResult: Msg = \"{Message}\"";
        }
    }
}