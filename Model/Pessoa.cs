using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__Métodos_e_Construtores.Model
{
    public class Pessoa
    {

        public Pessoa(){

        }

        public Pessoa (string Nome, string Sobrenome){
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }


        private string nomeFormat;
        private int idadeFormat;
        public string Nome { 
            get => nomeFormat.ToUpper(); //Uso de Body Expression
             
        
            set {
                if (value == ""){
                    throw new ArgumentException("O campo Nome não pode ser vazio!");
                }
                nomeFormat = value;
            } 
            
            }

            public string Sobrenome { get; set; }

            public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Uso d Body Expression
        public int Idade { 
            get => idadeFormat;//Uso de Body Expression 
            set {
                if (value<0){
                    throw new ArgumentException("Idade não pode ser menor que zero!");
                }
                idadeFormat = value;
            } 
            
            }

        public void Apresentar(){
            Console.WriteLine($"O (a) {NomeCompleto} tem {Idade} anos");
        }
    }
}