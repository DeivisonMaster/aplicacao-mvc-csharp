using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilizandoRazor.Models
{
    public class Conta
    {
        public int idConta { get; set; }
        public int numeroConta { get; set; }
        public string tipoDeConta { get; set; }
        public string nomeCliente { get; set; }
        public double saldoAtual { get; set; }
        public double limiteChequeEspecial { get; set; }
        public DateTime dataEntrada { get; set; }
        public bool indicaAtivo { get; set; }
    }
}