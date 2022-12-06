using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Program
    {
        static void Main(string[] args)
        {

            bool fim = false;
            bool jornada = false;
            Random r = new Random();
            Garagem congonhas = new Garagem("Congonhas");
            Garagem guarulhos = new Garagem("Guarulhos");
            Garagens.adicionar(congonhas, guarulhos);


            for (int i = 0; i < 8; i++)
            {
                Veiculo v = new Veiculo(r.Next(15, 31));
                Veiculos.cadastrar(v);
            }

            while (!fim)
            {
                Console.WriteLine("Selecione:\n\n0. Finalizar\n1. Cadastrar Veículo\n2. Cadastrar Garagem\n3. Iniciar jornada\n4. Encerrar jornada\n" +
                    "5. Liberar viagem de uma determinada origem para um determinado destino\n" +
                    "6. Listar veículos em determinada garagem (informando a quantidade de veículos e seu potencial de transporte)\n" +
                    "7. Informar quantidade de viagens efetuadas de uma determinada origem para um determinado destino\n" +
                    "8. Listar viagens efetuadas de uma determinada origem para um determinado destino\n" +
                    "9. Informar quantidade de passageiros transportados de uma determinada origem para um determinado destino\n"
                    );

                String opcao = Console.ReadLine();
                Console.Clear();

                try
                {
                    switch (opcao)
                    {
                        case "0":
                            fim = true;
                            break;

                        case "1":
                            if (!jornada)
                            {
                                Veiculo v = new Veiculo();
                                Veiculos.cadastrar(v);
                                Console.WriteLine("\nVeículo cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("\nEncerre a jornada antes de tentar cadastrar um veículo.");
                            }
                            break;

                        case "2":
                            if (!jornada)
                            {
                                Garagem g = new Garagem();
                                Garagens.adicionar(g);
                                Console.WriteLine("\nGaragem cadastrada com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("\nEncerre a jornada antes de tentar cadastrar uma garagem.");
                            }
                            break;

                        case "3":
                            Jornada.iniciar();
                            jornada = true;
                            Console.WriteLine("Jornada iniciada!");
                            break;

                        case "4":
                            Jornada.finalizar();
                            jornada = false;
                            Console.WriteLine("Jornada finalizada!");
                            break;

                        case "5":
                            Viagem vj = new Viagem();
                            Viagens.iniciar(vj);
                            break;

                        case "6":
                            Console.WriteLine("Escolha a garagem: ");
                            Garagens.listar();
                            Garagem garagemSelecionada = Garagens.buscar(int.Parse(Console.ReadLine()));
                            garagemSelecionada.listarVeiculos();
                            break;

                        case "7":
                            Console.WriteLine("Escolha a origem: ");
                            Garagens.listar();
                            int origem = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Escolha o destino: ");
                            Garagens.listar();
                            int destino = int.Parse(Console.ReadLine());
                            Viagens.contador(origem, destino);
                            break;

                        case "8":
                            Console.WriteLine("Escolha a origem: ");
                            Garagens.listar();
                            origem = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Escolha o destino: ");
                            Garagens.listar();
                            destino = int.Parse(Console.ReadLine());
                            Viagens.historico(origem, destino);
                            break;

                        case "9":
                            Console.WriteLine("Escolha a origem: ");
                            Garagens.listar();
                            origem = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Escolha o destino: ");
                            Garagens.listar();
                            destino = int.Parse(Console.ReadLine());
                            Viagens.passageirosTotal(origem, destino);
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {

                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
