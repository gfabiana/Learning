using System;
using System.Runtime.CompilerServices;

namespace Exceptions
{
    class Public
    {
        public static void Main(string[] args)
        {

            Console.Clear();
            var array = new int[3];

            try
            {
                // for (int i = 0; i < 10; i++)
                // {
                //     // System.IndexOutOfRangeException
                //     Console.WriteLine(array[i]);
                // }

                Cadastrar("");

            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Não encontrei o índice na lista.");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Falha ao cadastrar texto =(");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch (MinhaException ex)
            {

                Console.WriteLine("Exceção customizada");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ops, algo deu errado. =(");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }

            finally // *Sempre* é executado
            {
                Console.WriteLine("Chegou ao fim!");
                // Pode executar ações importantes, como, por exemplo, verificar se o arquivo está aberto e fechá-lo
                // Ou verificar se uma conexão com banco de dados está aberto e fechá-lo
            }

            static void Cadastrar(string texto)
            {
                if (string.IsNullOrEmpty(texto))
                {
                    // throw new Exception("O texto não pode ser nulo ou vazio.");
                    // throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
                    throw new MinhaException(DateTime.Now);
                }
            }
        }

        public class MinhaException : Exception
        {

            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }

        }

    }
}