using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class ProcurandoPor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool NaoEspecificado { get => Id == (int)ProcurandoPorEnum.NaoEspecificado;}
        public bool Amizade { get => Id == (int)ProcurandoPorEnum.Amizade; }
        public bool Namoro { get => Id == (int)ProcurandoPorEnum.Namoro; }
        public bool RelacionamentoSerio { get => Id == (int)ProcurandoPorEnum.RelacionamentoSerio; }
    }
}
