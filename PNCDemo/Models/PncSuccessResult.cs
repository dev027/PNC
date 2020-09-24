namespace PNCDemo.Models
{
    public abstract class PncSuccessResult : PncResult
    {
        public override string ToString()
        {
            return $"PncSuccessResult: Msg = \"{Message}\"";
        }
    }
}