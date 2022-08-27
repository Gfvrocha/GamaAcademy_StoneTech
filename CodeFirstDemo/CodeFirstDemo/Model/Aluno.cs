using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    public class Aluno
    {
        //ID, Nome, Sobrenome, DataMatricula
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataMatricula { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
