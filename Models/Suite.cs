using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite()
        {

        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        public Guid Id = Guid.NewGuid();
        public string TipoSuite
        {
            get => _tipoSuite;
            set
            {
                if(value =="")
                {
                    throw new ArgumentException("O tipo de Suite não pode ser vazio");
                }
                _tipoSuite = value;
            }
        }

        public int Capacidade
        {
            get => _capacidade;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("A capacidade não pode ser menor que 1");
                }
                _capacidade = value;
            }
        }

        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor da diária não pode ser menor que 0");
                }
                _valorDiaria = value;
            }
        }

        public string ResumoSuite()
        {
            return $"Id: {Id} \n" +
                    $"Tipo: {TipoSuite}\n" +
                    $"Capacidade: {Capacidade}\n" +
                    $"Diaria: {ValorDiaria.ToString("C")}";
        }
    }
}