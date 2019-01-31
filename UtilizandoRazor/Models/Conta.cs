using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UtilizandoRazor.Models
{
    public class Conta
    {
        [Display(Name = "Id Conta")]
        [HiddenInput(DisplayValue = false)]
        public int idConta { get; set; }

        [Display(Name = "Numero da Conta")]
        public int numeroConta { get; set; }

        [Display(Name = "Tipo de Conta")]
        public string tipoDeConta { get; set; }

        [Display(Name = "Nome do Cliente")]
        public string nomeCliente { get; set; }

        [Display(Name = "Saldo Atual")]
        public double saldoAtual { get; set; }

        [Display(Name = "Limite cheque especial")]
        public double limiteChequeEspecial { get; set; }

        [Display(Name = "Data de Entrada")]
        [DataType(DataType.Date)]
        public DateTime dataEntrada { get; set; }
        public bool indicaAtivo { get; set; }

        [DataType(DataType.MultilineText)]
        public string observacao { get; set; }


        public List<Conta> listaTipoConta()
        {
            return new List<Conta>
            {
                new Conta {idConta = 1, tipoDeConta = "Corrente"},
                new Conta {idConta = 2, tipoDeConta = "Salário"},
                new Conta {idConta = 3, tipoDeConta = "Poupança" }
            };
        }
    }
}