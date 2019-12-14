using Switch.Domain.Enums;

namespace Switch.Domain.Entities
{
    public class StatusRelacionamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool NaoEspecificado { get => Id == (int)StatusRelacionamentoEnum.NaoEspecificado; }
        public bool Solteiro { get => Id == (int)StatusRelacionamentoEnum.Solteiro; }
        public bool Casado { get => Id == (int)StatusRelacionamentoEnum.Casado; }
        public bool EmRelacionamento { get => Id == (int)StatusRelacionamentoEnum.EmRelacionamento; }
    }
}
