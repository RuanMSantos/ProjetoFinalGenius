using Figgle;

namespace ProjetoFinalGenius
{
    class UI
    {
        public void ExibeTitulo()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Big.Render("Genius"));
        }
    
        public void ExibeGenius()
        {
            Console.WriteLine("                                    ::mmmmMMMM++++++@@@@@@MM                                        ");
            Console.WriteLine("                            ..++++++MM--::::::::::::++::++++++++@@@@                                ");
            Console.WriteLine("                        ::mm....++MMmm@@--::::::::::++++++++++++++++++####                          ");
            Console.WriteLine("                    ::::    ......MMMMMM##::::::::++++++++++++++++++++++++####                      ");
            Console.WriteLine("                  ----      ......--MM@@@@MM::::::++..++++++++++++++++++++++++####                  ");
            Console.WriteLine("              ----            ......--@@@@@@MMMMMMMMMMMMmm++++++++++++++++++++++++##                ");
            Console.WriteLine("            ..--        ............--##@@@@################@@::++++++++++++++++mm####              ");
            Console.WriteLine("          ..--        ........----++######MM##    ++..--########@@  ++++mmMM@@##########..          ");
            Console.WriteLine("          ----        ......----mm######  mm--++############  MM##########################          ");
            Console.WriteLine("        --::        ......----::####mmMMMM@@++mm######--##########@@##########MM..------####        ");
            Console.WriteLine("      --::::        ....------MM################        ##..      ######..............----####      ");
            Console.WriteLine("      ::++::        ........--####mm######::      ++MM            ..@@##................--####      ");
            Console.WriteLine("      ++++      ..........----##########      @@        ........    --##++................--####    ");
            Console.WriteLine("    --++mm      ............--########  --            ....            ##MM........--......--####    ");
            Console.WriteLine("  @@mmmmmm      ............--@@@@##        --..--    ++    mm--##    ##--....------......--####mm  ");
            Console.WriteLine("  ++mmmmmm    ........  ++######@@##      --        ##mm##          ####....--------......--######  ");
            Console.WriteLine("  ::mmMMMM..........################@@      ##  mm      ++mm..  --  ##--..................--######  ");
            Console.WriteLine("  ++::MMmm##  --####@@@@@@##@@      ####    ::##      mm++++    ####mm..................----######@@");
            Console.WriteLine("  mm::MMMMMM@@@@@@@@@@@@              ######                ######......................----########");
            Console.WriteLine("  ##++MMMM@@@@@@@@@@                      ..######################  ....................--######mm##");
            Console.WriteLine("  mm++mmMM@@@@@@                                            ########--..............--..--######@@##");
            Console.WriteLine("    mmmmMM@@@@@@                                            ########::................--########MM  ");
            Console.WriteLine("    ##mmmmMM@@@@@@                                            ########  ............--::######@@MM  ");
            Console.WriteLine("    ##MMmmmmMM@@MM@@                                            ########..........--::########@@##  ");
            Console.WriteLine("      ##MM@@MM@@@@@@@@                                          ########--........++############    ");
            Console.WriteLine("      MM##MM@@MMMM@@@@##--                                        ########....--@@##############    ");
            Console.WriteLine("        ##@@MM@@@@MM@@@@@@##..                                    ########MM++################..    ");
            Console.WriteLine("          ##@@@@####@@@@########::                                  ##########################      ");
            Console.WriteLine("            ##########################mm..                      --::########@@##############        ");
            Console.WriteLine("              ##################################################@@@@##@@################@@          ");
            Console.WriteLine("                ############################################@@##@@@@@@##@@##############            ");
            Console.WriteLine("                  MM######################################@@@@@@@@####################              ");
            Console.WriteLine("                      ############################################################                  ");
            Console.WriteLine("                        ++################################################@@##++                    ");
            Console.WriteLine("                            MM@@##################################@@MM####--                        ");
            Console.WriteLine("                                  MM++##############################mm                              ");
            Console.WriteLine("                                          MMmmmmmmmmmmMMMMMMMM                                      ");
            Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    
        public void ExibeDificuldades()
        {
            Thread.Sleep(500);
            Console.WriteLine("--- Selecione o nível de dificuldade ---\n");
            Console.WriteLine("Dificuldade 1 ->  8 jogadas");
            Console.WriteLine("Dificuldade 2 -> 14 jogadas");
            Console.WriteLine("Dificuldade 3 -> 20 jogadas");
            Console.WriteLine("Dificuldade 4 -> 31 jogadas");

        }
    
        public void ExibeDificuldadeEscolhida(int dificuldadeSelecionada)
        {
                Thread.Sleep(500);
                dificuldadeSelecionada = dificuldadeSelecionada;
                Console.Write($"\nDificuldade selecionada -> {dificuldadeSelecionada} ");
            
                switch (dificuldadeSelecionada)
                {
                case 1: 
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"- 8 rodadas - ");
                Console.ResetColor();
                break;
                case 2: 
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"- 14 rodadas - ");
                Console.ResetColor();
                break;
                case 3: 
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"- 20 rodadas - ");
                Console.ResetColor();
                break;
                case 4: 
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"- 31 rodadas - ");
                Console.ResetColor();
                break;
                default: 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nErro, dificuldade não encontrada");
                Console.ResetColor();
                break;
                }

            
            
        }

        public void ExibeCoresSelecionaveis()
        {
            Console.Write("\nAs cores selecionaveis são: ");
            Thread.Sleep(2000);
           

            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("vermelho[r], ");
            Console.Beep(132, 3000);
            Thread.Sleep(2000);
           
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("verde[g], ");
            Console.Beep(165, 1500);
            Thread.Sleep(2000);
           
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("azul[b] ");
            Console.Beep(198, 1500);
            Thread.Sleep(2000);
           
            Thread.Sleep(500);
            Console.ResetColor();
            Console.Write("e ");
           
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("amarelo[y].");
            Console.ResetColor();
            Console.Beep(247, 1500);
            Thread.Sleep(2000);
        }

        public void ExibePontoDePartida()
        {
            string prontidao1;
            do
            {
            Thread.Sleep(500);
            Console.WriteLine("\n                   ----");
            Console.Write("Está pronto(s/n)? |    | ");
            prontidao1 = Console.ReadLine()!.Trim().ToLower();
            Console.WriteLine("                   ----");
            }
            while(prontidao1 != "s");

            string prontidao2;
            do {
            Thread.Sleep(500);
            Console.Write("Tem certeza(s/n)? |    | ");
            prontidao2 = Console.ReadLine()!.Trim().ToLower();
            Console.WriteLine("                   ----");
            }
            while(prontidao2 != "s");

            Thread.Sleep(500);
            Console.WriteLine("Ok... Boa sorte!  |    |");
            Console.WriteLine("                   ----");
        }

        public void ExibeDerrota()
        {
            Console.WriteLine(" ##   ##   #####     ####   #######           ######   #######  ######   #####    #######  ##   ##");
            Console.WriteLine(" ##   ##  ##   ##   ##  ##   ##   #            ##  ##   ##   #   ##  ##   ## ##    ##   #  ##   ##");
            Console.WriteLine("  ## ##   ##   ##  ##        ## #              ##  ##   ## #     ##  ##   ##  ##   ## #    ##   ##");
            Console.WriteLine("  ## ##   ##   ##  ##        ####              #####    ####     #####    ##  ##   ####    ##   ##");
            Console.WriteLine("   ###    ##   ##  ##        ## #              ##       ## #     ## ##    ##  ##   ## #    ##   ##");
            Console.WriteLine("   ###    ##   ##   ##  ##   ##   #            ##       ##   #   ##  ##   ## ##    ##   #  ##   ##");
            Console.WriteLine("    #      #####     ####   #######           ####     #######  #### ##  #####    #######   ##### ");
        }

        public void ExibeVitória()
        {
            Console.WriteLine(" ##   ##   #####     ####   #######             ####     ##     ##   ##  ##   ##   #####   ##   ##");
            Console.WriteLine(" ##   ##  ##   ##   ##  ##   ##   #            ##  ##   ####    ###  ##  ##   ##  ##   ##  ##   ##");
            Console.WriteLine("  ## ##   ##   ##  ##        ## #             ##       ##  ##   #### ##  ##   ##  ##   ##  ##   ##");
            Console.WriteLine("  ## ##   ##   ##  ##        ####             ##       ##  ##   ## ####  #######  ##   ##  ##   ##");
            Console.WriteLine("   ###    ##   ##  ##        ## #             ##  ###  ######   ##  ###  ##   ##  ##   ##  ##   ##");
            Console.WriteLine("   ###    ##   ##   ##  ##   ##   #            ##  ##  ##  ##   ##   ##  ##   ##  ##   ##  ##   ##");
            Console.WriteLine("    #      #####     ####   #######             #####  ##  ##   ##   ##  ##   ##   #####    ##### ");
        }

        public void ExibeProximaRodada()
        {
            Console.WriteLine("######   ######    #####   ##  ##    ####    ##   ##    ##              ######    #####   #####      ##     #####      ##  ");
            Console.WriteLine(" ##  ##   ##  ##  ##   ##  ##  ##     ##     ### ###   ####              ##  ##  ##   ##   ## ##    ####     ## ##    #### ");
            Console.WriteLine(" ##  ##   ##  ##  ##   ##   ####      ##     #######  ##  ##             ##  ##  ##   ##   ##  ##  ##  ##    ##  ##  ##  ##");
            Console.WriteLine(" #####    #####   ##   ##    ##       ##     #######  ##  ##             #####   ##   ##   ##  ##  ##  ##    ##  ##  ##  ##");
            Console.WriteLine(" ##       ## ##   ##   ##   ####      ##     ## # ##  ######             ## ##   ##   ##   ##  ##  ######    ##  ##  ######");
            Console.WriteLine(" ##       ##  ##  ##   ##  ##  ##     ##     ##   ##  ##  ##             ##  ##  ##   ##   ## ##   ##  ##    ## ##   ##  ##");
            Console.WriteLine("####     #### ##   #####   ##  ##    ####    ##   ##  ##  ##            #### ##   #####   #####    ##  ##   #####    ##  ##");
        }
    }
}