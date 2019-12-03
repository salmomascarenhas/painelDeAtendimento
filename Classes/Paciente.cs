using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painel_Pacientes.Classes
{
    public class Paciente
    {

        private string nome;
        private string atendente;
        private int status;
        private DateTime horaCriacao;

        public Paciente(string nome = "", string atendente = "Livre",int status = 0)
        {
            this.nome = nome;
            this.atendente = atendente;
            this.status = status;

            this.horaCriacao = DateTime.Now;
            
        }

        public string Nome { get; set; }
        public string Atendente { get; set; }
        public int Status { get; set; }
        public string HoraCriacao { get; }

        
    }
}
