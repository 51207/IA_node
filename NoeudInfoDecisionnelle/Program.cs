using System;
using System.Diagnostics;

namespace NoeudInfoDecisionnelle
{
    class Program
    {

        public void Affichage_info(string methods, long timeselapes,int nombre_de_noeud, int noeud_visited,string start_station, string end_station )
        {
            Console.WriteLine($"\n Noeud de depart : { start_station}");
            Console.WriteLine($" Noeud d'arrivée : { end_station}");
            Console.WriteLine($" Algorithme : {methods}");
            Console.WriteLine($" Nombres de noeuds : {nombre_de_noeud}");
            Console.WriteLine($" Execution time : { timeselapes} ms");
            Console.WriteLine($" Noeuds visités : { noeud_visited}");
          
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Hello World!");
            Station station = new Station();
            //methode permettant d'ajouter dans une liste tous les noms des stations
            station.ADDstation();

            //c'est le constructeur qui me permet l'initialisation de toutes mes listes et tableaux
            NodesAndEdges nodesAndEdges = new NodesAndEdges(station.stationame.Count);
            
            //methode qui va me permettre d'ajouter toutes les directions possible pour chaque noeud (noeud enfant)
            station.AddAllEdge(nodesAndEdges);
            //station.AddAllTimes(nodesAndEdges);

            //permet d'ajouter les coordonnées xy de chaque noeud
            station.Addcoord(nodesAndEdges);

            //permet d'ajouter la list "cout" la resultante des coordonnées d'un noeud 
            station.calculcote(nodesAndEdges);
            
            //permet d'afficher les chemins pour chaque noeud (en int):
            nodesAndEdges.display();


            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("Tous les noms de station :");
            station.Affichage();
            Console.WriteLine("");
            Console.WriteLine("Entrez la station de depart:");
            string source = Console.ReadLine();
            Console.WriteLine("Entrez la station d'arrivée");
            string destination = Console.ReadLine();
            Console.WriteLine("methode utilisée");
            string methods = Console.ReadLine();

            if (methods == "DFS")
            {
                var watch = Stopwatch.StartNew();

                //fonction DFS
                int node_visited =nodesAndEdges.DFS(nodesAndEdges.ConvertINT(source), nodesAndEdges.ConvertINT(destination));
                watch.Stop();
                
                //affichage de données
                program.Affichage_info(methods, watch.ElapsedMilliseconds, station.stationame.Count, node_visited, source, destination);

               
              
            }
            else if (methods == "RND")
            {
                var watch = Stopwatch.StartNew();

                //fonction RND
                int node_visited = nodesAndEdges.RND(nodesAndEdges.ConvertINT(source), nodesAndEdges.ConvertINT(destination));
                watch.Stop();

                //affichage de données
                program.Affichage_info(methods, watch.ElapsedMilliseconds, station.stationame.Count, node_visited, source, destination);

               


            }
            else if (methods == "GREEDY")
            {

                //permet de caluler la fonction heuristique , cad la distance entre chaque noeud et le noeud goal,on ajoute cette valeur dans la liste [] "cout"
                station.calculcout(nodesAndEdges, nodesAndEdges.ConvertINT(destination));
               

                var watch = Stopwatch.StartNew();

                //fonction GREEDY
                int node_visited = nodesAndEdges.GREEDY(nodesAndEdges.ConvertINT(source), nodesAndEdges.ConvertINT(destination));
                watch.Stop();

                //affichage de données
                program.Affichage_info(methods, watch.ElapsedMilliseconds, station.stationame.Count, node_visited, source, destination);


                
               

            }
            else if (methods == "BEAM")
            {

                //permet de caluler la fonction heuristique , cad la distance entre chaque noeud et le noeud goal , on ajoute cette valeur dans la liste [] "cout"
                station.calculcout(nodesAndEdges, nodesAndEdges.ConvertINT(destination));
                var watch = Stopwatch.StartNew();

                //fonction BEAM
                int node_visited =   nodesAndEdges.BEAM(nodesAndEdges.ConvertINT(source), nodesAndEdges.ConvertINT(destination));
                watch.Stop();

                //affichage de données
                program.Affichage_info(methods, watch.ElapsedMilliseconds, station.stationame.Count, node_visited, source, destination);

              

            }
            else if (methods == "A")
            {

                //permet de caluler la fonction heuristique , cad la distance entre chaque noeud et le noeud goal , on ajoute cette valeur dans la liste [] "cout"
                station.calculcout(nodesAndEdges, nodesAndEdges.ConvertINT(destination));
                //permet de calculer le temps de ttrajet pour chaque noeud avent d'atteindre la destination
                station.calcul_Times_trajets(nodesAndEdges, nodesAndEdges.ConvertINT(destination));
                var watch = Stopwatch.StartNew();

                //fonction A*
                int node_visited = nodesAndEdges.A(nodesAndEdges.ConvertINT(source), nodesAndEdges.ConvertINT(destination));

                watch.Stop();
               
                //affichage de données
                program.Affichage_info(methods, watch.ElapsedMilliseconds, station.stationame.Count, node_visited, source, destination);

                
            }

        }
    }
}
