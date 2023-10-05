
namespace OTRS.Interview.Entities
{
    public class Employer : IEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;
    }

}
