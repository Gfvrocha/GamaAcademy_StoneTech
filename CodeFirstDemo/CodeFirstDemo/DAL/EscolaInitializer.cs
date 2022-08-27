using CodeFirstDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.DAL
{
    public class EscolaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EscolaContext>
    {
        protected override void Seed(EscolaContext context)
        {
            var Alunos = new List<Aluno>
            {
                new Aluno{Nome="Felipe",Sobrenome="Rocha",DataMatricula=DateTime.Parse("2005-11-24")},
                new Aluno{Nome="Dick",Sobrenome="Vigarista",DataMatricula=DateTime.Parse("2001-02-06")},
                new Aluno{Nome="Grace",Sobrenome="Rocha",DataMatricula=DateTime.Parse("2008-12-29")},
                new Aluno{Nome="Penelope",Sobrenome="Charmosa",DataMatricula=DateTime.Parse("2008-01-19")},
                new Aluno{Nome="Gustavo",Sobrenome="Rocha",DataMatricula=DateTime.Parse("2003-07-08")},
                new Aluno{Nome="Mew",Sobrenome="Two",DataMatricula=DateTime.Parse("2007-19-10")},
                new Aluno{Nome="Davi",Sobrenome="Rocha",DataMatricula=DateTime.Parse("2009-05-09")},
                new Aluno{Nome="Harry",Sobrenome="Potter",DataMatricula=DateTime.Parse("2000-03-15")},
               
            };

            Alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();

            var cursos = new List<Curso>
            {
                new Curso{CursoID=1050,Titulo="Química",Creditos=3,},
                new Curso{CursoID=4022,Titulo="Microeconomia",Creditos=3,},
                new Curso{CursoID=4041,Titulo="Macroeconomia",Creditos=2,},
                new Curso{CursoID=1045,Titulo="Cálculo",Creditos=4,},
                new Curso{CursoID=3141,Titulo="Trigonometria",Creditos=4,},
                new Curso{CursoID=2041,Titulo="Composição",Creditos=3,},
                new Curso{CursoID=2042,Titulo="Literatura",Creditos=4,},
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var matriculas = new List<Matricula>
            {
                new Matricula{AlunoID=1,CursoID=1050,Nota=Nota.A},
                new Matricula{AlunoID=1,CursoID=4022,Nota=Nota.C},
                new Matricula{AlunoID=1,CursoID=4041,Nota=Nota.B},
                new Matricula{AlunoID=2,CursoID=1045,Nota=Nota.B},
                new Matricula{AlunoID=2,CursoID=3141,Nota=Nota.F},
                new Matricula{AlunoID=2,CursoID=2021,Nota=Nota.F},
                new Matricula{AlunoID=3,CursoID=1050},
                new Matricula{AlunoID=4,CursoID=1050},
                new Matricula{AlunoID=4,CursoID=4022,Nota=Nota.F},
                new Matricula{AlunoID=5,CursoID=4041,Nota=Nota.C},
                new Matricula{AlunoID=6,CursoID=1045},
                new Matricula{AlunoID=7,CursoID=3141,Nota=Nota.A},
            };
            matriculas.ForEach(s => context.Matriculas.Add(s));
            context.SaveChanges();

        }
    }
}
