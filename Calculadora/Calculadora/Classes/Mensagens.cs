using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    public class Mensagens
    {
        int ordemValor = 1;
        private string mensagemOpcao = "Opção Selecionada - ";
        readonly string mensagemMenu = "------------MENU------------\n" +
                                       " 1 - SOMA\n" +
                                       " 2 - SUBTRAÇÃO\n" +
                                       " 3 - MULTIPICAÇÃO\n" +
                                       " 4 - DIVISÃO\n" +
                                       "99 - SAIR\n" +
                                       "------------------------";

        public void ImprimeMenu()
        {
            Console.WriteLine(mensagemMenu);
        }

        public void ImprimeOpcaoSelecionada(int operacao)
        {
            var strOperacao = "";
            var operacaoValida = true;
            switch (operacao)
            {
                case 1:
                    strOperacao = "SOMA";
                    break;
                case 2:
                    strOperacao = "SUBTRAÇÃO";
                    break;
                case 3:
                    strOperacao = "MULTIPLICAÇÃO";
                    break;
                case 4:
                    strOperacao = "DIVISAO";
                    break;
                case 99:
                    strOperacao = "SAIR";
                    break;
                default:
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
                Console.WriteLine(mensagemOpcao + strOperacao);
            else
                Console.WriteLine("Operação inválida");           
        }                

        public void ImprimePerguntaValor()
        {
            if (ordemValor == 1)
            {
                Console.WriteLine("Informe o primeiro valor");
                ordemValor++;
            }
            else
            {
                Console.WriteLine("Informe o segundo valor");
                ordemValor = 1;
            }
        }

        public void ImprimeValorInformado(decimal valor)
        {
            Console.WriteLine($"O valor informado foi {valor}");
        }

        public void ImprimeResultado(decimal resultado)
        {
            Console.WriteLine($"Resultado: {resultado}");
        }

        public void ImprimeContinuar()
        {
            Console.WriteLine($"Pressione qualquer tecla para continuar");
        }

        public void ImprimeRetornar()
        {
            Console.WriteLine("Pressione 1 para retornar ao menu ou qualquer tecla para sair");            
        }
        public void ImprimeSair()
        {
            Console.WriteLine("deseja realmente sair?");
        }
    }
}
