using Figgle;

namespace ProjetoFinalGenius
{
    class UI
    {
        public void ExibirTitulo()
        {
            Console.WriteLine(FiggleFonts.Big.Render("Genius"));
        }
    
        public void ExibirGenius()
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
        }
    
        public void ExibirDificuldades()
        {
            Console.WriteLine("--- Selecione o nível de dificuldade ---\n");
            Console.WriteLine("Dificuldade 1 ->  8 jogadas");
            Console.WriteLine("Dificuldade 2 -> 14 jogadas");
            Console.WriteLine("Dificuldade 3 -> 20 jogadas");
            Console.WriteLine("Dificuldade 4 -> 31 jogadas");

        }
    
        public void ExibirDificuldadeEscolhida(int dificuldadeSelecionada)
        {
            // int dificuldadeSelecionada = x;
            Console.Write($"Dificuldade selecionada -> {dificuldadeSelecionada}");
            // switch ()
            Console.WriteLine($"-  botões - ");
        }
    }
}