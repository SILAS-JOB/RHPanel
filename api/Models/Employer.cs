namespace api.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AdmissionDate { get; set; }
        public int Salary { get; set; }
        public bool IsWorking { get; set; }
        public int? DemissionDate { get; set; }
        public string? Observation { get; set; }
    }
}