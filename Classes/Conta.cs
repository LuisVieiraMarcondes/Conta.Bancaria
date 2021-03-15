using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Bancaria
{
    public class Conta                                  //Criada a classe conta
    {
        private TipoConta TipoConta { get; set; }

        private double Saldo { get; set; }              //Aqui estão os atributos que a conta vai classe Conta vai ter

        private double Credito { get; set; }

        private string Nome { get; set; }
        
        //metodo de construtor (É o método que é chamado no momento que o meu objeto é criado!) 

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;         //O COMANDO this é para verificar aquela instancia 
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;

        }
        public bool Sacar(double valorSaque)    //método criar para o Saque.
        {   
            //Validacao de saldo suficiente
            if(this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;       //Fazer a subtraçao do saque no valor do Saldo

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            //formatacao composta, o O{Nome} e 1{Saldo} são a localizacao do vetor criado.

            return true; //Comando de retorno se conseguir fazer o saque
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
           // this.Saldo = this.Saldo + valorDeposito (a linha de cima é a forma exemplificada da soma do valorDeposito na conta.
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

        }
        public void Transferir(double valorTransferencia, Conta contaDestino) // metodo transferir
        {   
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);

            }
        }

        public override string ToString() // metodo ToString 
        {
            string retorno = "";
            retorno += " TipoConta " + this.TipoConta + " | ";
            retorno += " Nome " + this.Nome + " | ";
            retorno += " Saldo " + this.Saldo + " | ";
            retorno += " Credito " + this.Credito;
            return retorno;

        }



    }

}
