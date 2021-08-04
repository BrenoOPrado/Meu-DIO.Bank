using System;
using System.Collections.Generic;

namespace DIO.Bank
{
	class Program
	{
		static List<Conta> listContas = new List<Conta>();
	    static List<Item> listItem = new List<Item>();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContas();
						break;
					case "2":
						InserirConta();
						break;
					case "3":
						Comprar();
						break;
					case "4":
						Depositar();
						break;
					case "5":
						InserirItem();
						break;
					case "6":
					    ListarItens();
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}
				opcaoUsuario = ObterOpcaoUsuario();
			}
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

            private static void ListarItens()
        {
            Console.WriteLine("Listar Itens");

            if (listItem.Count == 0)
            {
                Console.WriteLine("Nenhum item cadastrado.");
                return;
            }

            for (int i = 0; i < listItem.Count; i++)
            {
                Item item = listItem[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(item);
            }
        }

        private static void InserirItem()
        {
            Console.WriteLine("Inserir novo Item");
			Console.WriteLine();
			Console.Write("Digite o Nome do Item: ");
			string entradaNomeItem = Console.ReadLine();

            Item novoItem = new Item(nomeitem: entradaNomeItem);
			listItem.Add(novoItem);

			Console.WriteLine();
			Console.WriteLine("Novo Item: {0} adicionado!", novoItem);
        }

        private static void Depositar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
		}

		private static void Comprar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome do item que deseja comprar: ");
			string NomeItem = Console.ReadLine();

			Console.Write("Digite o valor do item que deseja comprar: ");
			double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
		}

		private static void InserirConta()
		{
			Console.WriteLine("Inserir nova conta");

			Console.Write("Digite o Nome do Cliente: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double entradaCredito = double.Parse(Console.ReadLine());

			Conta novaConta = new Conta(saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);

			listContas.Add(novaConta);
		}

		private static void ListarContas()
		{
			Console.WriteLine("Listar contas");

			if (listContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Conta conta = listContas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(conta);
			}
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Bank");
			Console.WriteLine();
			Console.WriteLine("Como podemos ajudar?");
			Console.WriteLine();

			Console.WriteLine("1- Listar contas");
			Console.WriteLine("2- Inserir nova conta");
			Console.WriteLine("3- Comprar");
			Console.WriteLine("4- Vender");
			Console.WriteLine("5- Inserir novo Item");
			Console.WriteLine("6- Listar Itens");
            Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}