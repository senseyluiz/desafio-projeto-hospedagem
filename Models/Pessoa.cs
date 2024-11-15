using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        
        public Guid Id = Guid.NewGuid();
        public string Nome
        {
            get => _nome;
            set {
                if(value ==""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
                
            }
        }

        public string Sobrenome
        {
            get=> _sobrenome;
            set {
                if(value ==""){
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
                
            }
        }        

        public string NomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}