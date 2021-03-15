# Conta.Bancaria

Projeto DIO conta bancária .NET

Nesse projeto de conta bancária introduzido no .NET, começamos a criaçao do projeto

Em seguida, criamos um classe chamada Conta onde inserimos os atributos de Saldo, Credito, Nome
e um Enum do TipodeConta(1= Pessoa Fisica) (2= Pessoa Juridica)

Logo Após criamos os métodos construtores para a Conta, Sacar, Depositar, Transferir e finalmente
um método sobrescrito (override) ToString, retornando uma string com o Tipo de conta, Saldo, nome e credito.
Assim, finalizando a classe Conta.

Após a classe conta ser finalizada, implementamos um metodo de Opcao do usuario
criando menu com uma estrutura condicional switch/case que ira percorrer os metodos :
ListarConta, InserirConta, Transferir, Sacar, Depositar, ou sair.

Agora criamos uma List<conta> simulando um banco de dados cadastrando as novas contas e seus atributos 
Nome, Saldo e Credito.
e após em cada método criado fazemos a indexacao e assim permintindo a simulação bancaria.


