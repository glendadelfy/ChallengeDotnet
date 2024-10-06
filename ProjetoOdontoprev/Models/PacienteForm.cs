namespace ProjetoOdontoprev.Models
{
    public class PacienteForm
    {
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public byte Idade { get; set; }
        public DateTime Nascimento { get; set; }
        public int DentistId { get; set; }
    }
}
