using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cadastro
{
    class ControleG
    {
        //incluir pessoa
        public void IncluirPessoa()
        {
            //chamando da classe pessoa os dados (CPF, nome, idade....)
            Pessoa p = new Pessoa();
            Console.Write("Informe seu CPF: ");
            p.CPF = Console.ReadLine();
            Console.Write("Informe seu nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe sua data de nascimento: ");
            p.Data = Console.ReadLine();
            Console.Write("Informe seu peso: ");
            p.Peso = Convert.ToInt32(Console.ReadLine());
            //incluir dados na lista
            Lista.pessoaLista.Add(p);
        }
        //pesquisar por id (CPF)
        public void Pesquisar()
        {
            Console.Write("Informe o CPF que deseja pesquisar: ");
            string CPF = Console.ReadLine();
            //vai fazer a verificação com o find para ver se encontra o CPF que foi digitado com base no que foi cadastrado.
            Pessoa p = Lista.pessoaLista.Find(x => x.CPF.Equals(CPF));
            //se caso for diferente de nulo
            if (p != null)
            {
                //vai listar o CPF, nome, idade, data de nascimento e peso.
                Console.WriteLine("\n" +
                    "CPF:" + p.CPF + "\n" +
                    "Nome:" + p.Nome + "\n" +
                    "Idade:" + p.Idade + "\n" +
                    "Data de Nascimento:" + p.Data + "\n" +
                    "Peso:" + p.Peso);
            }
            else
            {
                //caso digite um CPF não cadastrado aparece a seguinte mensagem:
                Console.WriteLine("CPF não encontrado! Por favor, digite um CPF válido... ");
            }
        }
        //Alterar usuário cadastrado (CPF, nome, idade....)
        public void Alterar()
        {
            Console.Write("Informe o CPF que deseja alterar: ");
            string CPF = Console.ReadLine();
            //vai buscar na lista dos usuários cadastrados o CPF para realizar as alterações
            Pessoa p = Lista.pessoaLista.Find(x => x.CPF.Equals(CPF));

            if (p != null)
            {
                //Nessa parte o usuário vai alterar todos os dados da pessoa cadastrada
                Console.Write("Digite o novo CPF: ");
                p.CPF = Console.ReadLine();
                Console.Write("Digite o novo nome: ");
                p.Nome = Console.ReadLine();
                Console.Write("Digite a nova idade: ");
                p.Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o novo peso: ");
                p.Peso = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a nova data de nascimento: ");
                p.Data = Console.ReadLine();

                Console.WriteLine("Alterado com sucesso!");

            }
            else
            {
                //caso digitar um CPF que não esteja cadastrado, irá aparecer a seguinte mensagem:
                Console.WriteLine("CPF não encontrado! Por favor, digite um CPF válido...");
            }
        }

        //Excluir usuário cadastrado
        public void Excluir()
        {
            //Instância para verificar a condição V ou F
            Boolean y = true;
            do
            {
                Console.Write("Informe o CPF que deseja remover: ");
                string CPF = Console.ReadLine();
                //vai fazer a busca do CPF cadastrado para ser removido
                Pessoa p = Lista.pessoaLista.Find(x => x.CPF.Equals(CPF));

                if (p != null)
                {
                    //Confirmação de exclusão
                    Console.WriteLine("Tem certeza que deseja excluir?");
                    Console.WriteLine("1 - Sim\n" +
                        "2 - Não");
                    string SN = Console.ReadLine();

                    switch (SN)
                    {
                        //Opção 1 - Sim
                        case "1":
                            //Remove para remover o CPF da lista
                            Lista.pessoaLista.Remove(p);
                            Console.WriteLine("Removido com sucesso!\n" +
                                "Retornando ao início...");
                            y = false;
                            break;
                        //Opção 2 - Não
                        case "2":
                            Console.WriteLine("Retornando ao início...");
                            y = false;
                            break;
                    }
                }
                else
                {
                    //se caso digitar um CPF que não esteja cadastrado aparecerá a seguinte mensagem:
                    Console.WriteLine("CPF não encontrado! Por favor, digite um CPF válido...");
                }
            } while (y);
        }
        //Listar usuário cadastrado
        public void Listar()
        {
            //vai pegar a lista inteira que está armazenada com os dados de todos os usuários que foram cadastrados
            foreach (Pessoa x in Lista.pessoaLista)
            {
                //vai listar o CPF, nome, idade, data de nascimento e peso.
                Console.WriteLine("\n" +
                    "CPF:" + x.CPF + "\n" +
                    "Nome:" + x.Nome + "\n" +
                    "Idade:" + x.Idade + "\n" +
                    "Data de Nascimento:" + x.Data + "\n" +
                    "Peso:" + x.Peso);
            }
        }


    }
}
