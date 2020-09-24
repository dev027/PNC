namespace PNCDemo.Models
{
    public abstract class PncResult
    {
        public string Message { get; set; }

        public override string ToString()
        {
            return $"PncResult: Msg = \"{Message}\"";
        }
    }
}