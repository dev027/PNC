namespace PNCDemo.Models.Actuals
{
    public class Person : ActualBase
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"\"{FirstName} {Surname}\"";
        }
    }
}