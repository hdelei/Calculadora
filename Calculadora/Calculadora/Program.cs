using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static decimal valor1 = 0;
        static decimal valor2 = 0;

        static void ImprimirMenu()
        {
            Console.WriteLine("------------MENU------------");
            Console.WriteLine(" 1 - SOMA");
            Console.WriteLine(" 2 - SUBTRAÇÃO");
            Console.WriteLine(" 3 - MULTIPLICAÇÃO");
            Console.WriteLine(" 4 - DIVISÃO");
            Console.WriteLine("99 - SAIR");
            Console.WriteLine("------------------------");
        }

        static decimal Operacoes(int operacao)
        {
            decimal resultado = 0;

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Opção Selecionada - SOMA");
                    LerDados();
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    Console.WriteLine("Opção Selecionada - SUBTRAÇÃO");
                    LerDados();
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    Console.WriteLine("Opção Selecionada - MULTIPLICAÇÃO");
                    LerDados();
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    Console.WriteLine("Opção Selecionada - DIVISÃO");
                    LerDados();
                    resultado = valor1 / valor2;
                    break;
                default:
                    break;
            }
            return resultado;
        }


        static void LerDados()
        {
            Console.WriteLine("Informe o primeiro valor");
            valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"O valor informado foi {valor1}");
            Console.WriteLine("Informe o segundo valor");
            valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"O valor informado foi {valor2}");
        }

        static void Main(string[] args)
        {
            int menu = 0;
            while (menu == 0)
            {
                try
                {
                    ImprimirMenu();
                    menu = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (menu)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            Console.WriteLine($"Resultado: {Operacoes(menu)}");
                            break;
                        case 99:
                            Console.WriteLine("Deseja realmente sair?");
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }

                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();

                    Console.WriteLine("Pressione 1 para retornar ao menu ou qualquer tecla para sair");
                    var opcao = Console.ReadLine();

                    if (opcao == "1")
                        menu = 0;
                    else
                        menu = 99;

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                finally
                {
                    Console.Clear();
                }
            }
        }
    }
}