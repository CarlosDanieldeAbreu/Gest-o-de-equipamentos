using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static int registros = 1000;
        static string opcao = "";
        static void Main(string[] args)
        {
            string[] nome = new string[registros];
            string[] numeroSerie = new string[registros];
            string[] fabricante = new string[registros];
            decimal[] precoAquiscao = new decimal[registros];
            DateTime[] dataFabricacao = new DateTime[registros];

            string[] tituloChamado = new string[registros];
            string[] descricao = new string[registros];
            string[] equipamento = new string[registros];
            DateTime[] dataAbertura = new DateTime[registros];

            while (true)
            {
                Menu();

                if (opcao == "1")
                {
                    inserirEquipamentos(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao);
                }
                else if (opcao == "2")
                {
                    visualizarEquipamnetos(nome, numeroSerie, fabricante);
                }
                else if (opcao == "3")
                {
                    editarEquipamnetos(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao);
                }
                else if (opcao == "4")
                {
                    excluirEquipamnetos(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao, equipamento);
                }
                if (opcao == "5")
                {
                    inserirChamada(ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura);
                }
                else if (opcao == "6")
                {
                    visualizadorDeChamadas(tituloChamado, equipamento, dataAbertura);
                }
                else if (opcao == "7")
                {
                    editarChamadas(ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura);
                }
                else if (opcao == "8")
                {
                    excluirChamadas(ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura);
                }
                else if(opcao == "9")
                {
                    break;
                }
            }
        }

        private static void excluirChamadas(ref string[] titulo, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==========Excluir=Chamada==========");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - Consultar chamada \n2 - Selecionar chamada para exclusão \n3 - Voltar para o menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoChamadas = Console.ReadLine();
                Console.ResetColor();

                if (opcaoChamadas == "1")
                {
                    visualizadorDeChamadas(titulo, equipamento, dataAbertura);
                }
                else if (opcaoChamadas == "2")
                {
                    Console.WriteLine("Digite o título da chamada que deseja excluir:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string removerChamada = Console.ReadLine();
                    Console.ResetColor();

                    string[] novaSequenciaTitulo = new string[titulo.Length - 1];
                    string[] novaSequenciaDescricao = new string[descricao.Length - 1];
                    string[] novaSequenciaEquipamento = new string[equipamento.Length - 1];
                    DateTime[] novaSequenciaDataAbertura = new DateTime[dataAbertura.Length - 1];
                    int j = 0;

                    for (int i = 0; i < titulo.Length; i++)
                    {
                        if (titulo[i] != removerChamada)
                        {
                            novaSequenciaTitulo[j] = titulo[i];
                            novaSequenciaDescricao[j] = descricao[i];
                            novaSequenciaEquipamento[j] = equipamento[i];
                            novaSequenciaDataAbertura[j] = dataAbertura[i];
                            j++;
                        }
                    }

                    titulo = novaSequenciaTitulo;
                    descricao = novaSequenciaDescricao;
                    equipamento = novaSequenciaEquipamento;
                    dataAbertura = novaSequenciaDataAbertura;
                }
                else if (opcaoChamadas == "3")
                {
                    Menu();
                    break;
                }
            }
        }

        static void editarChamadas(ref string[] titulo, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==========Editar=Chamada==========");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - Consultar chamadas \n2 - Selecionar chamada para edisão \n3 - Voltar para o menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoChamadas = Console.ReadLine();
                Console.ResetColor();

                if (opcaoChamadas == "1")
                {
                    visualizadorDeChamadas(titulo, equipamento, dataAbertura);
                }
                else if (opcaoChamadas == "2")
                {
                    Console.WriteLine("Digite o título da chamda que deseja editar:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string editarChamada = Console.ReadLine();
                    Console.ResetColor();

                    for (int i = 0; i < titulo.Length; i++)
                    {
                        if (editarChamada == titulo[i] && titulo != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine();
                            Console.WriteLine("Digite os novos dados da chamada");
                            Console.ResetColor();
                            Console.WriteLine();

                            Console.Write("Título da chamada: ");
                            string strTitulo = Console.ReadLine();
                            titulo[i] = strTitulo;

                            Console.Write("Descrição: ");
                            string strDescricao = Console.ReadLine();
                            descricao[i] = strDescricao;

                            Console.Write("Equipamento: ");
                            string strEquipamento = Console.ReadLine();
                            equipamento[i] = strEquipamento;

                            Console.Write("Data de abertura séra colocada automaticamente de acordo com a data atual");
                            DateTime data = DateTime.Now;
                            dataAbertura[i] = data;
                            Console.WriteLine("");
                        }
                    }
                }
                else if (opcaoChamadas == "3")
                {
                    Console.Clear();
                    Menu();
                    break;
                }
            }
        }

        static void visualizadorDeChamadas(string[] titulo, string[] equipamento, DateTime[] dataAbertura)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========Chamadas=cadastradas==========");
            Console.ResetColor();
            Console.WriteLine("");

            for (int i = 0; i < titulo.Length; i++)
            {
                if(titulo[i] != null)
                {
                    TimeSpan diasChamadoAberto = DateTime.Today - dataAbertura[i];
                    double diasAberto = diasChamadoAberto.TotalDays;

                    Console.Write("Título: " + titulo[i] + ", Equipamento: " + equipamento[i] + ", Data de abertura: " + dataAbertura[i] + ", Número de dias que está aberto: " + diasAberto);
                    Console.WriteLine("");
                }
            }
        }

        static void inserirChamada(ref string[] titulo, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura)
        {
            for (int i = 0; i < dataAbertura.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - para inserir \n2 - para voltar ao menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoChamadas = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                if (opcaoChamadas == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("==========Insira=as=informações=da=chamada==========");
                    Console.ResetColor();
                    Console.Write("Título da chamada: ");
                    string strTitulo = Console.ReadLine();
                    titulo[i] = strTitulo;

                    Console.Write("Descrição: ");
                    string strDescricao = Console.ReadLine();
                    descricao[i] = strDescricao;

                    Console.Write("Equipamento: ");
                    string strEquipamento = Console.ReadLine();
                    equipamento[i] = strEquipamento;

                    Console.Write("Data de abertura séra colocada automaticamente de acordo com a data atual");
                    DateTime data = DateTime.Now;
                    dataAbertura[i] = data;
                    Console.WriteLine("");
                }
                else if (opcaoChamadas == "2")
                {
                    Menu();
                    break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("========MENU========");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Digite: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("======Equipamento======");
            Console.ResetColor();
            Console.WriteLine("1 - Inserir equipamentos \n2 - Visualizar equipamentos \n3 - Editar equipamentos \n4 - Excluir equipamentos");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========Chamada========");
            Console.ResetColor();
            Console.WriteLine("5 - Inserir chamadas \n6 - Visualizar chamadas \n7 - Editar chamadas \n8 - Excluir chamadas");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========Sair=========");
            Console.ResetColor();
            Console.WriteLine("9 - Sair");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=======================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            opcao = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        private static void excluirEquipamnetos(ref string[] nomeEquipamento, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquisicao, ref DateTime[] dataFabricacao, string[] equipamentoChamada)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==========Excluir=Equipamento==========");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - Consultar equipamentos \n2 - Selecionar item para exclusão \n3 - Voltar para o menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoEquipamento = Console.ReadLine();
                Console.ResetColor();

                if (opcaoEquipamento == "1")
                {
                    visualizarEquipamnetos(nomeEquipamento, numeroSerie, fabricante);
                }
                else if (opcaoEquipamento == "2")
                {
                    Console.WriteLine("Digite o equipamento que deseja excluir:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string removerEquipamento = Console.ReadLine();
                    Console.ResetColor();

                    string[] novaSequenciaNomeEquipamento = new string[nomeEquipamento.Length - 1];
                    string[] novaSequenciaNumeroSerie = new string[numeroSerie.Length - 1];
                    string[] novaSequenciaFabricante = new string[fabricante.Length - 1];
                    decimal[] novaSequenciaPrecoAquisicao = new decimal[precoAquisicao.Length - 1];
                    DateTime[] novaSequenciaDataFabricacao = new DateTime[dataFabricacao.Length - 1];
                    int j = 0;
                    for (int i = 0; i < nomeEquipamento.Length; i++)
                    {
                        if (nomeEquipamento[i] != equipamentoChamada[i])
                        {
                            if (nomeEquipamento[i] != removerEquipamento)
                            {
                                novaSequenciaNomeEquipamento[j] = nomeEquipamento[i];
                                novaSequenciaNumeroSerie[j] = numeroSerie[i];
                                novaSequenciaFabricante[j] = fabricante[i];
                                novaSequenciaPrecoAquisicao[j] = precoAquisicao[i];
                                novaSequenciaDataFabricacao[j] = dataFabricacao[i];
                                j++;
                            }
                        }
                        else if (nomeEquipamento[i] != equipamentoChamada[i])
                        {
                            Console.WriteLine("Você não pode excluir este equipamento, pois ele está ativo em uma chamada");
                            break;
                        }
                    }

                    nomeEquipamento = novaSequenciaNomeEquipamento;
                    numeroSerie = novaSequenciaNumeroSerie;
                    fabricante = novaSequenciaFabricante;
                    precoAquisicao = novaSequenciaPrecoAquisicao;
                    dataFabricacao = novaSequenciaDataFabricacao;
                }
                else if (opcaoEquipamento == "3")
                {
                    Menu();
                    break ;
                }
            }
        }

        static void editarEquipamnetos(ref string[] nomeEquipamento, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquisicao, ref DateTime[] dataFabricacao)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==========Editar=Equipamento==========");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - Consultar equipamentos \n2 - Selecionar item para edisão \n3 - Voltar para o menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoEquipamento = Console.ReadLine();
                Console.ResetColor();

                if (opcaoEquipamento == "1")
                {
                    visualizarEquipamnetos(nomeEquipamento, numeroSerie, fabricante);
                }
                else if (opcaoEquipamento == "2")
                {
                    Console.WriteLine("Digite o equipamento que deseja editar:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string editarEquipamento = Console.ReadLine();
                    Console.ResetColor();

                    for (int i = 0; i < nomeEquipamento.Length; i++)
                    {
                        if (editarEquipamento == nomeEquipamento[i] && nomeEquipamento != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine();
                            Console.WriteLine("Digite os novos dados do equipamento");
                            Console.ResetColor();
                            Console.WriteLine();

                            Console.Write("Nome do equipamento: ");
                            string strNome = Console.ReadLine();
                            nomeEquipamento[i] = strNome;

                            if (strNome.Length < 6) //validação do tamanho do nome do produto
                            {
                                Console.WriteLine();
                                Console.WriteLine("*Erro* Digite um nome que tenha mais de 6 caracteres");
                                Console.ReadLine();
                                break;
                            }

                            Console.Write("Número de série: ");
                            string strNumeroSerie = Console.ReadLine();
                            numeroSerie[i] = strNumeroSerie;

                            Console.Write("Data de frabicação(Digite desta forma dia/mês/ano): ");
                            string strDataFabricacao = Console.ReadLine();
                            DateTime data = DateTime.Parse(strDataFabricacao);
                            dataFabricacao[i] = data;

                            Console.Write("Preço de aquisição: ");
                            decimal preco = decimal.Parse(Console.ReadLine());
                            precoAquisicao[i] = preco;

                            Console.Write("Fabricante: ");
                            string strFabricante = Console.ReadLine();
                            fabricante[i] = strFabricante;

                            Console.ReadLine();

                        }
                    }
                }
                else if (opcaoEquipamento == "3")
                {
                    Console.Clear();
                    Menu();
                    break;
                }
            }
        }

        static void visualizarEquipamnetos(string[] nomeEquipamento, string[] numeroSerie, string[] fabricante)
        {
            Console.WriteLine("");
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("==========Equipamentos=Cadastrados==========");
            Console.ResetColor();
            Console.WriteLine("");

            for(int i = 0; i < nomeEquipamento.Length; i++)
            {
                if (nomeEquipamento[i] != null)
                {
                    Console.Write("Nome: " + nomeEquipamento[i] + ", Número de série: " + numeroSerie[i] + ", Fabricante: " + fabricante[i]);
                    Console.WriteLine("");
                }
            }
        }

        static void inserirEquipamentos(ref string[] nomeEquipamento, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquisicao, ref DateTime[] dataFabricacao)
        {
            for(int i = 0; i < fabricante.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - para inserir \n2 - para voltar ao menu");
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                string opcaoEquipamento = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                if(opcaoEquipamento == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("==========Insira=as=informações=do=equipamento==========");
                    Console.ResetColor();
                    Console.Write("Nome do equipamento: ");
                    string strNome = Console.ReadLine();
                    nomeEquipamento[i] = strNome;

                    if (strNome.Length < 6) //validação do tamanho do nome do produto
                    {
                        Console.WriteLine();
                        Console.WriteLine("*Erro* Digite um nome que tenha mais de 6 caracteres");
                        Console.ReadLine();
                        break;
                    }

                    Console.Write("Número de série: ");
                    string strNumeroSerie = Console.ReadLine();
                    numeroSerie[i] = strNumeroSerie;
                    
                    Console.Write("Data de frabicação(Digite desta forma dia/mês/ano): ");
                    string strDataFabricacao = Console.ReadLine();
                    DateTime data = DateTime.Parse(strDataFabricacao);
                    dataFabricacao[i] = data;

                    Console.Write("Preço de aquisição: ");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    precoAquisicao[i] = preco;

                    Console.Write("Fabricante: ");
                    string strFabricante = Console.ReadLine();
                    fabricante[i] = strFabricante;
                }
                else if(opcaoEquipamento == "2")
                {
                    Menu();
                    break;
                }
            }
        }
    }
}
