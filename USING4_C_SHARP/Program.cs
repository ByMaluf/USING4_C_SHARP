namespace USING4_C_SHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nesse caso temos a variável caminho do tipo String que recebe a string do arquivo1
            string caminho = @"c:\temp\arquivo1.txt";

            //Quando uma exceção é lançada, o CLR (Common Language Runtime - Máquina Virtual do C#) procura a instrução catch que trata essa exceção.
            //Se o método em execução no momento não contiver um bloco catch, o CLR procurará no método que chamou o método atual e assim por diante para cima na pilha de chamadas.
            //Se nenhum bloco catch for encontrado, o CLR exibirá uma mensagem de exceção sem tratamento para o usuário e interromperá a execução do programa.

            try
            {
                //Using fecha o objeto arquivo depois de seu uso
                using (FileStream arquivo = new FileStream(caminho, FileMode.Open))
                {
                    //Using fecha o objeto leitor depois do seu uso
                    using (StreamReader leitor = new StreamReader(arquivo))
                    {
                        string linhas = leitor.ReadToEnd(); // Lê todos os caracteres da posição atual até o final do fluxo.
                        Console.WriteLine(linhas); //Impressão Linhas
                    }
                }
            }
            catch (IOException e) // IOException - A exceção que é gerada quando ocorre um erro de E/S.
            //é a classe base para exceções geradas ao acessar informações usando fluxos, arquivos e diretórios.
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
                //Concede acesso às propriedades necessárias para definir uma mensagem de Enfileiramento de Mensagens.
            }
        }
    }
}