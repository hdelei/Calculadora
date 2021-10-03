using Calculadora.Classes;
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

        static void Main(string[] args)
        {
            Mensagens mensagem = new Mensagens();            

            int menu = 0;
            while (menu == 0)
            {
                try
                {
                    mensagem.ImprimeMenu();
                    menu = int.Parse(Console.ReadLine());
                    Console.Clear();
                    mensagem.ImprimeOpcaoSelecionada(menu);                    

                    switch (menu)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            var resultado = Operacoes(menu, mensagem);
                            mensagem.ImprimeResultado(resultado);
                            break;
                        case 99:
                            mensagem.ImprimeSair();
                            break;                        
                    }

                    if (menu != 99)
                    {
                        mensagem.ImprimeContinuar();
                        Console.ReadKey();
                    }                    

                    mensagem.ImprimeRetornar();
                    var opcao = Console.ReadLine();

                    if (opcao == "1")
                        menu = 0;
                    else
                        menu = 99;

                }
                catch (DivideByZeroException e)
                {
                    ImprimeException(e.Message, out menu);                    
                }
                catch (FormatException e)
                {
                    ImprimeException(e.Message, out menu);                    
                }
                catch (Exception e)
                {
                    ImprimeException(e.Message, out menu);                    
                }
                finally
                {
                    Console.Clear();
                }
            }
        }

        static decimal Operacoes(int operacao, Mensagens mensagem)
        {   
            CalculoPadrao calculo = new CalculoPadrao();
            decimal resultado = 0;
            LerDados(mensagem);

            switch (operacao)
            {
                case 1:
                    resultado = calculo.Somar(valor1, valor2);
                    break;
                case 2:
                    resultado = calculo.Subtrair(valor1, valor2);
                    break;
                case 3:
                    resultado = calculo.Multiplicar(valor1, valor2);
                    break;
                case 4:
                    resultado = calculo.Dividir(valor1, valor2);
                    break;
                default:
                    break;
            }
            return resultado;
        }

        static void LerDados(Mensagens mensagem)
        {
            mensagem.ImprimePerguntaValor();
            valor1 = decimal.Parse(Console.ReadLine());
            mensagem.ImprimeValorInformado(valor1);

            mensagem.ImprimePerguntaValor();
            valor2 = decimal.Parse(Console.ReadLine());
            mensagem.ImprimeValorInformado(valor2);
        }

        public static void ImprimeException(string mensagem, out int menu)
        {
            Console.WriteLine($"Erro {mensagem}");
            menu = 0;
            Console.ReadKey();
        }
    }
}