using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva(int diasResrvados)
        {
            DiasReservados = diasResrvados;
        }         

        private int _diasResrvados;
        public Guid Id = Guid.NewGuid();
        private readonly List<Pessoa> Hospedes = [];
        private Suite Suite;
        public int DiasReservados
        {
            get => _diasResrvados;
            set{
                if(value < 0)
                {
                    throw new ArgumentException("Dias reservados não pode ser menor que 0");
                }                
                _diasResrvados = value;
            }
        }

        public void CadastrarHospedes(Pessoa hospede)
        {
            if (Hospedes.Count < Suite.Capacidade)
            {
                Hospedes.Add(hospede);
            }else{
                System.Console.WriteLine("Capacidade máxima atingida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            decimal desconto = valorTotal * 0.1M;
            if(DiasReservados >= 10)
            {
                valorTotal -= desconto;
            }
            return valorTotal;
        }        
    }
}