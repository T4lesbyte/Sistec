using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept
{
    public class Chamado
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdProblema { get; set; }
        public int IdUsuarioAbertura { get; set; }
        public int IdStatus { get; set; }
        public double Prioridade { get; set; }
        public DateTime DataAbertura { get; set; }
    }
}
