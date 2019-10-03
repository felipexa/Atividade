using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sistema_Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boolean continua = true;
            List<Pessoa> pessoaLista = new List<Pessoa>();

            int x;
            ControleG c = new ControleG();

            do
            {
                //contagem de quantos usuários tem cadastrados
                Console.WriteLine("Temos {0} usuários cadastrados.", Lista.pessoaLista.Count);


                Console.WriteLine("1 - Incluir \n" +
                    "2 - Pesquisar por CPF\n" +
                    "3 - Alterar CPF\n" +
                    "4 - Excluir\n" +
                    "5 - Listar todos\n" +
                    "6 - Gravar em TXT\n" +

                    "0 - Sair\n");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        c.IncluirPessoa();
                        break;

                    case 2:
                        c.Pesquisar();
                        break;

                    case 3:
                        c.Alterar();
                        break;

                    case 4:
                        c.Excluir();
                        break;

                    case 5:

                        string[] lines = System.IO.File.ReadAllLines(@"C:\temp\Teste.txt");

                        // Display the file contents by using a foreach loop.
                        System.Console.WriteLine("Contents of WriteLines2.txt = ");
                        foreach (string line in lines)
                        {
                            // Use a tab to indent each line of the file.
                            Console.WriteLine("\t" + line);
                        }

                        c.Listar();
                        break;
                    /************************
                     * 
                     * GRAVAR *
                     * EM *
                     * ARQUIVO *
                     * .txt *   
                     * 
                     * 
                     * *************************************/
                    case 6:
                        /*
                        string[] lines = System.IO.File.ReadAllLines(@"C:\temp\Teste.txt");

                        System.Console.WriteLine("Conteúdos TXT");
                        foreach (string line in lines)
                        {
                            Console.WriteLine("\t" + line);
                        }
                        */



                        //inserindo para a pasta destino
                        StreamWriter Inserindo = new StreamWriter(@"C:\temp\Teste.txt");
                        //Comparações
                        pessoaLista.Sort(delegate (Pessoa p1, Pessoa p2)
                        {
                            return p1.CPF.CompareTo(p2.CPF);
                        });

                        pessoaLista.ForEach(delegate (Pessoa p)
                        {
                            //vai pegar a listagem de CPF, nome, idade....
                            Inserindo.WriteLine(String.Format("#{0} | {1} | {2} | {3} | {4} ", p.CPF, p.Nome, p.Idade, p.Data, p.Peso));
                        });

                        Inserindo.Close();
                        break;

                    //opção 0 - Sair
                    case 0:
                        Console.WriteLine("Sair");
                        continua = false;
                        break;

                    default:
                        //caso o usuário digite um número que não exista nas opções:
                        Console.WriteLine("Opção não existente!");
                        break;
                }
            } while (continua);
        }
    }
}
