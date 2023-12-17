using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__Métodos_e_Construtores.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos {get;set;}

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAlunos(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            for (int count = 0; count < Alunos.Count; count++)
            {   
                //Abaixo ambas as formas vão gerar o mesmo resultado,porem o recomendado é a Interpolação.
                //string textoConcatenado = "Nº"+ count + " - "+ Alunos[count].NomeCompleto;
                string textoInterpolado = $"Nº{count +1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(textoInterpolado);
            }
        }
    }
}