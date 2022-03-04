using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static int registros = 1000;
        static string opcao = "";
        static void Main(string[] args)
        {
            int[] idEquipamento = new int[registros];
            string[] nome = new string[registros];
            string[] numeroSerie = new string[registros];
            string[] fabricante = new string[registros];
            decimal[] precoAquiscao = new decimal[registros];
            DateTime[] dataFabricacao = new DateTime[registros];

            int[] idChamada = new int[registros];
            string[] tituloChamado = new string[registros];
            string[] descricao = new string[registros];
            string[] equipamento = new string[registros];
            string[] solicitanteChamada = new string[registros];
            string[] status = new string[registros];
            DateTime[] dataAbertura = new DateTime[registros];

            int[] idSolicitante = new int[registros];
            string[] solicitante = new string[registros];
            string[] email = new string[registros];
            string[] telefone = new string[registros];

            
            acaoDaOpcaoDoMenu(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao, ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura, ref solicitante, ref email, ref telefone, ref idChamada, ref idEquipamento, ref idSolicitante, ref solicitanteChamada, ref status);
        }

        #region Opção e menu
        static void acaoDaOpcaoDoMenu(ref string[] nome, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquiscao, ref DateTime[] dataFabricacao, ref string[] tituloChamado, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura, ref string[] solicitante, ref string[] email, ref string[] telefone, ref int[] idChamada, ref int[] idEquipamento, ref int[] idSolicitante, ref string[] solicitanteChamada, ref string[] status)
        {
            while (true)
            {
                Menu();

                if (opcao == "1")
                {
                    inserirEquipamentos(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao, ref idEquipamento);
                }
                else if (opcao == "2")
                {
                    visualizarEquipamnetos(nome, numeroSerie, fabricante, idEquipamento);
                }
                else if (opcao == "3")
                {
                    editarEquipamnetos(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao, ref idEquipamento);
                }
                else if (opcao == "4")
                {
                    excluirEquipamnetos(ref nome, ref numeroSerie, ref fabricante, ref precoAquiscao, ref dataFabricacao, equipamento, ref idEquipamento);
                }
                if (opcao == "5")
                {
                    inserirChamada(ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura, nome, ref idChamada, ref solicitanteChamada, solicitante, ref status);
                }
                else if (opcao == "6")
                {
                    visualizadorDeChamadas(tituloChamado, equipamento, dataAbertura, idChamada, solicitanteChamada, status);
                }
                else if (opcao == "7")
                {
                    editarChamadas(ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura, nome, ref idChamada, ref solicitanteChamada, solicitante, ref status);
                }
                else if (opcao == "8")
                {
                    excluirChamadas(ref tituloChamado, ref descricao, ref equipamento, ref dataAbertura, ref idChamada, ref solicitanteChamada, ref status);
                }
                else if (opcao == "9")
                {
                    inserirSolicitante(ref solicitante, ref email, ref telefone, ref idSolicitante);
                }
                else if (opcao == "10")
                {
                    visualizarSolicitante(solicitante, email, telefone, idSolicitante);
                }
                else if (opcao == "11")
                {
                    editarSolicitante(ref solicitante, ref email, ref telefone, ref idSolicitante);
                }
                else if (opcao == "12")
                {
                    excluirSolicitante(ref solicitante, ref email, ref telefone, ref idSolicitante);
                }
                else if (opcao == "0")
                {
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
            Console.WriteLine("========Solicitante========");
            Console.ResetColor();
            Console.WriteLine("9 - Inserir solicitante \n10 - Visualizar solicitantes \n11 - Editar solicitantes \n12 - Excluir solicitantes");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========Sair=========");
            Console.ResetColor();
            Console.WriteLine("0 - Sair");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=======================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            opcao = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }
        #endregion

        #region Solicitante
        static void excluirSolicitante(ref string[] solicitante, ref string[] email, ref string[] telefone, ref int[] idSolicitante)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==========Excluir=solicitante==========");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - Consultar solicitante \n2 - Selecionar solicitante para exclusão \n3 - Voltar para o menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoSolicitante = Console.ReadLine();
                Console.ResetColor();

                if (opcaoSolicitante == "1")
                {
                    visualizarSolicitante(solicitante, email, telefone, idSolicitante);
                }
                else if (opcaoSolicitante == "2")
                {
                    Console.WriteLine("Digite o ID do solicitante que deseja excluir:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string removerSolicitante = Console.ReadLine();
                    int removerSolicitanteId = Convert.ToInt32(removerSolicitante);
                    Console.ResetColor();

                    int[] novaSequenciaIDsolicitante = new int[idSolicitante.Length - 1];
                    string[] novaSequenciaNome = new string[solicitante.Length - 1];
                    string[] novaSequenciaEmail = new string[email.Length - 1];
                    string[] novaSequenciaTelefone = new string[telefone.Length - 1];
                    int j = 0;

                    for (int i = 0; i < idSolicitante.Length; i++)
                    {
                        if (idSolicitante[i] != removerSolicitanteId)
                        {
                            novaSequenciaIDsolicitante[j] = idSolicitante[i];
                            novaSequenciaNome[j] = solicitante[i];
                            novaSequenciaEmail[j] = email[i];
                            novaSequenciaTelefone[j] = telefone[i];
                            j++;
                        }
                    }

                    idSolicitante = novaSequenciaIDsolicitante;
                    solicitante = novaSequenciaNome;
                    email = novaSequenciaEmail;
                    telefone = novaSequenciaTelefone;
                }
                else if (opcaoSolicitante == "3")
                {
                    Menu();
                    break;
                }
            }
        }
        static void editarSolicitante(ref string[] solicitante, ref string[] email, ref string[] telefone, ref int[] idSolicitante)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==========Editar=Solicitante==========");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - Consultar soliciatantes \n2 - Selecionar solicitante para edisão \n3 - Voltar para o menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoSolicitante = Console.ReadLine();
                Console.ResetColor();

                if (opcaoSolicitante == "1")
                {
                    visualizarSolicitante(solicitante, email, telefone, idSolicitante);
                }
                else if (opcaoSolicitante == "2")
                {
                    Console.WriteLine("Digite o id do solicitante que deseja editar:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string editarSolicitante = Console.ReadLine();
                    int solicitanteId = Convert.ToInt32(editarSolicitante);
                    Console.ResetColor();

                    for (int i = 0; i < solicitante.Length; i++)
                    {
                        if (solicitanteId == idSolicitante[i] && idSolicitante != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine();
                            Console.WriteLine("Digite os novos dados do solicitante");
                            Console.ResetColor();
                            Console.WriteLine();

                            Console.Write("Nome do solicitante: ");
                            string strNome = Console.ReadLine();
                            solicitante[i] = strNome;

                            Console.Write("E-mail: ");
                            string strEmail = Console.ReadLine();
                            email[i] = strEmail;

                            Console.Write("Telefone: ");
                            string strTelefone = Console.ReadLine();
                            telefone[i] = strTelefone;

                            Console.ReadLine();

                        }
                    }
                }
                else if (opcaoSolicitante == "3")
                {
                    Console.Clear();
                    Menu();
                    break;
                }
            }
        }
        static void visualizarSolicitante(string[] solicitante, string[] email, string[] telefone, int[] idSolicitante)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========Solicitantes=cadastrados==========");
            Console.ResetColor();
            Console.WriteLine("");

            for (int i = 0; i < solicitante.Length; i++)
            {
                if (solicitante[i] != null)
                {
                    Console.Write("ID: " + idSolicitante[i] + ", Nome: " + solicitante[i] + ", E-mail: " + email[i] + ", Telefone: " + telefone[i]);
                    Console.WriteLine("");
                }
            }
        }
        static void inserirSolicitante(ref string[] solicitante, ref string[] email, ref string[] telefone, ref int[] idSolicitante)
        {
            for (int i = 0; i < email.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite: \n1 - para inserir \n2 - para voltar ao menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string opcaoSolicitante = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                if (opcaoSolicitante == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("==========Insira=as=informações=do=solicitante==========");
                    Console.ResetColor();

                    idSolicitante[i] = i+1;
                    Console.Write("Nome do solicitante: ");
                    string strNome = Console.ReadLine();
                    solicitante[i] = strNome;

                    Console.Write("E-mail: ");
                    string strEmail = Console.ReadLine();
                    email[i] = strEmail;

                    Console.Write("Telefone: ");
                    string strTelefone = Console.ReadLine();
                    telefone[i] = strTelefone;
                }
                else if (opcaoSolicitante == "2")
                {
                    Menu();
                    break;
                }
            }
        }
        #endregion

        #region Chamada
        static void excluirChamadas(ref string[] titulo, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura, ref int[] idChamada, ref string[] solicitanteChamada, ref string[] status)
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
                    visualizadorDeChamadas(titulo, equipamento, dataAbertura, idChamada, solicitanteChamada, status);
                }
                else if (opcaoChamadas == "2")
                {
                    Console.WriteLine("Digite o título da chamada que deseja excluir:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string removerChamada = Console.ReadLine();
                    int removerIdChamadas = Convert.ToInt32(removerChamada);
                    Console.ResetColor();

                    int[] novaSequenciaIDchamada= new int[idChamada.Length - 1];
                    string[] novaSequenciaTitulo = new string[titulo.Length - 1];
                    string[] novaSequenciaDescricao = new string[descricao.Length - 1];
                    string[] novaSequenciaEquipamento = new string[equipamento.Length - 1];
                    string[] novaSequenciaSolicitante = new string[solicitanteChamada.Length - 1];
                    string[] novaSequenciaStatus = new string[status.Length - 1];
                    DateTime[] novaSequenciaDataAbertura = new DateTime[dataAbertura.Length - 1];
                    int j = 0;

                    for (int i = 0; i < idChamada.Length; i++)
                    {
                        if (idChamada[i] != removerIdChamadas)
                        {
                            novaSequenciaIDchamada[j] = idChamada[i];
                            novaSequenciaTitulo[j] = titulo[i];
                            novaSequenciaDescricao[j] = descricao[i];
                            novaSequenciaEquipamento[j] = equipamento[i];
                            novaSequenciaSolicitante[j] = solicitanteChamada[i];
                            novaSequenciaStatus[j] = status[i];
                            novaSequenciaDataAbertura[j] = dataAbertura[i];
                            j++;
                        }
                    }

                    idChamada = novaSequenciaIDchamada;
                    titulo = novaSequenciaTitulo;
                    descricao = novaSequenciaDescricao;
                    equipamento = novaSequenciaEquipamento;
                    solicitanteChamada = novaSequenciaSolicitante;
                    status = novaSequenciaStatus;
                    dataAbertura = novaSequenciaDataAbertura;
                }
                else if (opcaoChamadas == "3")
                {
                    Menu();
                    break;
                }
            }
        }
        static void editarChamadas(ref string[] titulo, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura, string[] nomeEquipamento, ref int[] idChamada, ref string[] solicitanteChamada, string[] solicitante, ref string[] status)
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
                    visualizadorDeChamadas(titulo, equipamento, dataAbertura, idChamada, solicitanteChamada, status);
                }
                else if (opcaoChamadas == "2")
                {
                    Console.WriteLine("Digite o ID da chamada que deseja editar:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string editarChamada = Console.ReadLine();
                    int editarIdChamada = Convert.ToInt32(editarChamada);
                    Console.ResetColor();

                    for (int i = 0; i < idChamada.Length; i++)
                    {
                        if (editarIdChamada == idChamada[i] && idChamada != null)
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

                            while (true)
                            {
                                Console.Write("Equipamento: ");
                                string strEquipamento = Console.ReadLine();
                                equipamento[i] = strEquipamento;
                                if (equipamento[i] == nomeEquipamento[i])
                                {
                                    break;
                                }
                                else if (equipamento[i] != nomeEquipamento[i])
                                {
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("*ERRO* Este equipamento não existe");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                }
                            }
                            while (true)
                            {
                                Console.Write("Solicitante: ");
                                string strSolicitante = Console.ReadLine();
                                solicitanteChamada[i] = strSolicitante;
                                if (solicitanteChamada[i] == solicitante[i])
                                {
                                    break;
                                }
                                else if (solicitanteChamada[i] != solicitante[i])
                                {
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("*ERRO* Este solicitante não existe");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                }
                            }

                            Console.Write("Status(ABERTO/FECHADO): ");
                            string strStatus = Console.ReadLine();
                            status[i] = strStatus;

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
        static void visualizadorDeChamadas(string[] titulo, string[] equipamento, DateTime[] dataAbertura, int[] idChamada, string[] solicitanteChamada, string[] status)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========Chamadas=cadastradas==========");
            Console.ResetColor();
            Console.WriteLine("");

            for (int i = 0; i < titulo.Length; i++)
            {
                if (titulo[i] != null)
                {
                    TimeSpan diasChamadoAberto = DateTime.Today - dataAbertura[i];
                    double diasAberto = diasChamadoAberto.TotalDays;

                    if (status[i] == "ABERTO")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("====Chamados=abertos====");
                        Console.ResetColor();
                        Console.Write("ID: " + idChamada[i] + ", Título: " + titulo[i] + ", Equipamento: " + equipamento[i] + ", Solicitante: " + solicitanteChamada[i] + ", Data de abertura: " + dataAbertura[i] + ", Número de dias que está aberto: " + diasAberto);
                        Console.WriteLine("");
                    }
                    if(status[i] == "FECHADO")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("====Chamados=fechados====");
                        Console.ResetColor();
                        Console.Write("ID: " + idChamada[i] + ", Título: " + titulo[i] + ", Equipamento: " + equipamento[i] + ", Solicitante: " + solicitanteChamada[i] + ", Data de abertura: " + dataAbertura[i] + ", Número de dias que está aberto: " + diasAberto);
                        Console.WriteLine("");
                    }
                }
            }
        }
        static void inserirChamada(ref string[] titulo, ref string[] descricao, ref string[] equipamento, ref DateTime[] dataAbertura, string[] nomeEquipamento , ref int[] idChamada, ref string[] solicitanteChamada, string[] solicitante, ref string[] status)
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

                    idChamada[i] = i + 1;

                    Console.Write("Título da chamada: ");
                    string strTitulo = Console.ReadLine();
                    titulo[i] = strTitulo;

                    Console.Write("Descrição: ");
                    string strDescricao = Console.ReadLine();
                    descricao[i] = strDescricao;
                    while (true)
                    {
                        Console.Write("Equipamento: ");
                        string strEquipamento = Console.ReadLine();
                        equipamento[i] = strEquipamento;
                        if (equipamento[i] == nomeEquipamento[i])
                        {
                            break;
                        }
                        else if (equipamento[i] != nomeEquipamento[i])
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*ERRO* Este equipamento não existe");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    }
                    while (true)
                    {
                        int j = 0;
                        Console.Write("Solicitante: ");
                        string strSolicitante = Console.ReadLine();
                        solicitanteChamada[i] = strSolicitante;
                        if (solicitanteChamada[i] == solicitante[i])
                        {
                            break;
                        }
                        else if (solicitanteChamada[i] != solicitante[i])
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*ERRO* Este solicitante não existe");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    }

                    Console.Write("Status(ABERTO/FECHADO): ");
                    string strStatus = Console.ReadLine();
                    status[i] = strStatus;

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
        #endregion

        #region Equipamento
        static void excluirEquipamnetos(ref string[] nomeEquipamento, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquisicao, ref DateTime[] dataFabricacao, string[] equipamentoChamada, ref int[] idEquipamento)
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
                    visualizarEquipamnetos(nomeEquipamento, numeroSerie, fabricante, idEquipamento);
                }
                else if (opcaoEquipamento == "2")
                {
                    Console.WriteLine("Digite o equipamento que deseja excluir:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string removerEquipamento = Console.ReadLine();
                    int removerIdEquipamento = Convert.ToInt32(removerEquipamento);
                    Console.ResetColor();
                    int[] novaSequenciaIdEquipamento = new int[idEquipamento.Length - 1];
                    string[] novaSequenciaNomeEquipamento = new string[nomeEquipamento.Length - 1];
                    string[] novaSequenciaNumeroSerie = new string[numeroSerie.Length - 1];
                    string[] novaSequenciaFabricante = new string[fabricante.Length - 1];
                    decimal[] novaSequenciaPrecoAquisicao = new decimal[precoAquisicao.Length - 1];
                    DateTime[] novaSequenciaDataFabricacao = new DateTime[dataFabricacao.Length - 1];
                    int j = 0;
                    for (int i = 0; i < idEquipamento.Length; i++)
                    {
                        if (nomeEquipamento[i] != equipamentoChamada[i])
                        {
                            if (idEquipamento[i] != removerIdEquipamento)
                            {
                                novaSequenciaIdEquipamento[j] = idEquipamento[i];
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

                    idEquipamento = novaSequenciaIdEquipamento;
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
        static void editarEquipamnetos(ref string[] nomeEquipamento, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquisicao, ref DateTime[] dataFabricacao, ref int[] idEquipamento)
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
                    visualizarEquipamnetos(nomeEquipamento, numeroSerie, fabricante, idEquipamento);
                }
                else if (opcaoEquipamento == "2")
                {
                    Console.WriteLine("Digite o ID do equipamento que deseja editar:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string editarEquipamento = Console.ReadLine();
                    int editarIdEquipamneto = Convert.ToInt32(editarEquipamento);
                    Console.ResetColor();

                    for (int i = 0; i < idEquipamento.Length; i++)
                    {
                        if (editarIdEquipamneto == idEquipamento[i] && idEquipamento != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine();
                            Console.WriteLine("Digite os novos dados do equipamento");
                            Console.ResetColor();
                            Console.WriteLine();

                            while (true)
                            {
                                Console.Write("Nome do equipamento: ");
                                string strNome = Console.ReadLine();
                                nomeEquipamento[i] = strNome;
                                if (strNome.Length >= 6)
                                {
                                    break;
                                }
                                else if (strNome.Length < 6) 
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("*Erro* Digite um nome que tenha mais de 6 caracteres");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                }
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
        static void visualizarEquipamnetos(string[] nomeEquipamento, string[] numeroSerie, string[] fabricante, int[] idEquipamento)
        {
            Console.WriteLine("");
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("==========Equipamentos=Cadastrados==========");
            Console.ResetColor();
            Console.WriteLine("");

            for(int i = 0; i < idEquipamento.Length; i++)
            {
                if (nomeEquipamento[i] != null)
                {
                    Console.Write("ID: " + idEquipamento[i] + ", Nome: " + nomeEquipamento[i] + ", Número de série: " + numeroSerie[i] + ", Fabricante: " + fabricante[i]);
                    Console.WriteLine("");
                }
            }
        }
        static void inserirEquipamentos(ref string[] nomeEquipamento, ref string[] numeroSerie, ref string[] fabricante, ref decimal[] precoAquisicao, ref DateTime[] dataFabricacao, ref int[] idEquipamento)
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
                    while (true)
                    {
                        idEquipamento[i] = i+1;

                        Console.Write("Nome do equipamento: ");
                        string strNome = Console.ReadLine();
                        nomeEquipamento[i] = strNome;
                        if(strNome.Length >= 6)
                        {
                            break;
                        }
                        else if (strNome.Length < 6) 
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*Erro* Digite um nome que tenha mais de 6 caracteres");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
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
        #endregion
    }
}
