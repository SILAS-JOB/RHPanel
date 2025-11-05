//Sim eu sei que escrevi Employer (sentido de empregador) e o correto é employee pro contexto, eu fiz um erro e agora não quero ter que mudar até as migrations
namespace api.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly? AdmissionDate { get; set; }
        public int Salary { get; set; }
        public bool IsWorking { get; set; }
        public DateOnly? DemissionDate { get; set; }
        public string? Observation { get; set; }
    }
}