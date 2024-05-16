using System;
using System.Security.AccessControl;
using System.Text;

namespace Testing2
{
    class Program
    {
        static void Main(string[] args)
        {

            // *GUIDs*
            // var id = Guid.NewGuid();

            // id = new Guid("3a95cc87-5de3-4d00-8d5c-b4b01ab525bb");
            // Console.WriteLine(id.ToString().Substring(0, 8));
            // 3a95cc87

            // id = new Guid(); <<<<<<<<<<<<<
            // Console.WriteLine(id); 
            // 00000000-0000-0000-0000-000000000000

            // *Interpolação de Strings*
            // var price = 20.9;
            // caso 1
            // var discount = 5;
            // var text = "The price is " + (price - discount) + ".";

            // caso 2
            // var text = string.Format("The price is {0}", price);

            // caso 3
            // var text = $"The price is {price}";

            // Dica bônus: ao adicionar @, é possível quebrar uma string em duas linhas:
            // var text = $@"The price is 
            // {price}";

            // Console.WriteLine(text);

            // *Comparação de strings*
            // var text = "Testing";
            // Console.WriteLine(text.CompareTo("Testing")); // 0 
            // Console.WriteLine(text.CompareTo("Testing2")); // -1

            // Console.WriteLine(text.Contains("Test")); // True
            // Console.WriteLine(text.Contains("test")); // False
            // Console.WriteLine(text.Contains("test", StringComparison.OrdinalIgnoreCase)); // True

            // *StartsWith/EndsWith*
            //var text = "Este texto é um teste";
            // Console.WriteLine(text.StartsWith("Este")); // True
            // Console.WriteLine(text.StartsWith("este")); // False
            // Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // True
            // Console.WriteLine(text.StartsWith("texto")); // False

            // Console.WriteLine(text.EndsWith("teste")); // True

            // *Equals*
            // Console.WriteLine(text.Equals("Este texto é um teste")); // True
            // Console.WriteLine(text.Equals("este texto é um teste")); // False
            // Console.WriteLine(text.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase)); // True

            // *Índices*
            // Console.WriteLine(text.IndexOf("é")); // 11
            // Console.WriteLine(text.LastIndexOf("s")); // 18

            // *Métodos adicionais*
            // Console.WriteLine(text.ToLower()); // este texto é um teste
            // Console.WriteLine(text.ToUpper()); // ESTE TEXTO É UM TESTE
            // Console.WriteLine(text.Insert(5, "AQUI ")); // Este AQUI texto é um teste
            // Console.WriteLine(text.Remove(5, 6)); // Este é um teste
            // Console.WriteLine(text.Length); // 21

            // *Manipulando strings*
            // Console.WriteLine(text.Replace("e", "x")); // Estx txxto é um txstx

            // var divisao = text.Split(" ");
            // Console.WriteLine(divisao); // System.String[]
            // Console.WriteLine(divisao[0]); // Este
            // Console.WriteLine(divisao[1]); // texto
            // Console.WriteLine(divisao[2]); // é
            // Console.WriteLine(divisao[3]); // um
            // Console.WriteLine(divisao[4]); // teste


            // var resultado = text.Substring(5, text.LastIndexOf("o"));
            // Console.WriteLine(resultado); // texto é u

            // Console.WriteLine(text.Trim()); // Este texto é um teste (retira espaços do início e do fim)

            // *StringBuilder* (casos de strings grandes)
            // var text = new StringBuilder();
            // text.Append("Este texto é um teste.");
            // text.Append("Amo manga.");
            // text.Append("Tomo suco de laranja sem açúcar.");
            // text.Append("Tenho 4 gatos.");

            // Console.WriteLine(text.ToString()); // Este texto é um teste.Amo manga.Tomo suco de laranja sem açúcar.Tenho 4 gatos.


        }
    }
}