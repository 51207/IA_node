using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Text;

namespace NoeudInfoDecisionnelle
{
    public class Station
    {
        public List<string> stationame = new List<string>();
        public void ADDstation()
        {
            stationame.Add("GDM");
            stationame.Add("Delacroix");
            stationame.Add("Lemmonier");
            stationame.Add("GC");
            stationame.Add("Ottignies");
            stationame.Add("Porte de hal");
            stationame.Add("Charleroi");
            stationame.Add("Chatelet");
            stationame.Add("Chalineau");
            stationame.Add("Namur");
            stationame.Add("Park");
            stationame.Add("ISIB");
            stationame.Add("Saint Josse");
            stationame.Add("Rogier");
            stationame.Add("Botanique");
            stationame.Add("Madou");
            stationame.Add("Presse bus");
            stationame.Add("Teurenberg bus");
            stationame.Add("GDN");
            stationame.Add("Haren");
            stationame.Add("Machelen");
            stationame.Add("Arenberg bus");
            stationame.Add("Debrouckere");
            stationame.Add("Bourse");
            stationame.Add("Saint Catherine");
            stationame.Add("Annessens");
            stationame.Add("Beekant");
            stationame.Add("GDO");
            stationame.Add("Clemenceau");
            stationame.Add("Etangs noir");
            stationame.Add("Porte d'anderlecht");
            stationame.Add("Arts et metiers");
            stationame.Add("Louvain");


        }
        public void Affichage()
        {
            string msg = "";
            for (int i = 0; i < stationame.Count; i++)
            {

                msg += stationame[i] + "-";
                // Console.WriteLine(stationame[i]);
            }
            Console.WriteLine(msg);
        }
     

        //permet d'ajouter chaque le route pour chaque noeud
        public void AddAllEdge(NodesAndEdges dfs)
        {

            //GDM 0->3,1,2,18,4,32,5
            dfs.addedgesINT(0, 3);
            dfs.addedgesINT(0, 1);
            dfs.addedgesINT(0, 2);
            dfs.addedgesINT(0, 18);
            dfs.addedgesINT(0, 4);
            dfs.addedgesINT(0, 32);
            dfs.addedgesINT(0, 5);

            //ottignies 4-> 0,6,32
            dfs.addedgesINT(4, 6);
            dfs.addedgesINT(4, 32);

            //charleroi 6->4,7
            dfs.addedgesINT(6, 7);
            //chatelet  7->6,8,16
            dfs.addedgesINT(7, 8);
            dfs.addedgesINT(7, 16);
            //chalineau 8-> 7,9
            dfs.addedgesINT(8, 9);
            //Namur 9->8,3,32,18
            dfs.addedgesINT(9, 3);
            dfs.addedgesINT(9, 32);
            dfs.addedgesINT(9, 18);
            //GC 3->0,9,10,18,22,21,20,
            dfs.addedgesINT(3, 10);
            dfs.addedgesINT(3, 18);
            dfs.addedgesINT(3, 22);
            dfs.addedgesINT(3, 13);
            dfs.addedgesINT(3, 21);
            dfs.addedgesINT(3, 20);
            //debrouckere 22->3,14,13,21,23,24
            dfs.addedgesINT(22, 14);
            dfs.addedgesINT(22, 13);
            dfs.addedgesINT(22, 21);
            dfs.addedgesINT(22, 23);
            dfs.addedgesINT(22, 24);
            //arenberg est deja fait21->3,22,31,24 
            dfs.addedgesINT(21, 31);
            //saint catherine 24->22,18,29,23
            dfs.addedgesINT(24, 18);
            dfs.addedgesINT(24, 29);
            dfs.addedgesINT(24, 23);
            //bourse 23->22,24,25
            dfs.addedgesINT(23, 25);
            //Annessens 25-> 23,28,2,31
            dfs.addedgesINT(25, 28);
            dfs.addedgesINT(25, 2);
            dfs.addedgesINT(25, 31);
            //lemmonier 2-> 0,25,30
            dfs.addedgesINT(2, 30);
            //porte d'anderlecht 30->21,2,31
            dfs.addedgesINT(30, 31);
            //arts et metiers est deja donc fait 31->21,25,30

            //clemenceau 28->25,1,27
            dfs.addedgesINT(28, 1);
            dfs.addedgesINT(28, 27);
            //delacroix 1->0,28,27
            dfs.addedgesINT(1, 27);
            //GDO 27->28,1,26,29
            dfs.addedgesINT(27, 26);
            dfs.addedgesINT(27, 29);
            //beekant 26->26,29
            dfs.addedgesINT(26, 29);
            //etangs noir est deja donc fait 29->24,27

            //louvain 32-> 0,4,9,20
            dfs.addedgesINT(32, 20);
            //machelen 20->3,32,19
            dfs.addedgesINT(20, 19);
            //haren 19->20,18,15
            dfs.addedgesINT(19, 18);
            dfs.addedgesINT(19, 15);
            //gdn 18->0,9,3,24,19,13
            dfs.addedgesINT(18, 13);
            dfs.addedgesINT(18, 16);
            //rogier 13-> 3,22,18,12,14,15
            dfs.addedgesINT(13, 12);
            dfs.addedgesINT(13, 14);
            dfs.addedgesINT(13, 15);
            //botanique 14->22,13,15,10
            dfs.addedgesINT(14, 15);
            dfs.addedgesINT(14, 10);
            //madou 15->19,13,14,16 
            dfs.addedgesINT(15, 16);
            //presse 16->7,18,15,17
            dfs.addedgesINT(16, 17);
            //treurenberg 17 ->16,10
            dfs.addedgesINT(17, 10);
            //park 10->3,14,17,11
            dfs.addedgesINT(10, 11);
            //isib 11->10,12
            dfs.addedgesINT(11, 12);
            //saint josse est deja donc fait 12->13,11


        }

       /*
        public void AddAllTimes(NodesAndEdges dfs)
        { //TEMPS POUR FAIRE UN CHANGEMENT DE TRANSPORT EN COMMUN

            //GDM 0->3,1,2,18,4,32,5
            dfs.addTimes(0, 4,4);
            dfs.addTimes(0, 0, 0);
            dfs.addTimes(0, 2, 0);
            dfs.addTimes(0, 4, 4);
            dfs.addTimes(0, 4, 0);
            dfs.addTimes(0, 4, 0);
            dfs.addTimes(0, 0, 0);

           

            //ottignies 4-> 0,6,32
            dfs.addTimes(4, 0, 0);
            dfs.addTimes(4, 1, 1);

            //charleroi 6->4,7
            dfs.addTimes(6, 0, 0);
            //chatelet  7->6,8,16
           
            dfs.addTimes(7, 0, 0);
            dfs.addTimes(7, 0, 0);
           
            //chalineau 8-> 7,9
            dfs.addTimes(8, 0, 0);
            
            
            //Namur 9->8,3,32,18
            

            dfs.addTimes(9, 0, 4);
            dfs.addTimes(9, 2, 2);
            dfs.addTimes(9, 2, 2);


            //GC 3->0,9,10,18,22,21,20,
           

            dfs.addTimes(3, 0, 0);
            dfs.addTimes(3, 4, 4);
            dfs.addTimes(3, 0, 0);
            dfs.addTimes(3, 3, 3);
            dfs.addTimes(3, 3, 3);
            dfs.addTimes(3, 4, 2);

            //debrouckere 22->3,14,13,21,23,24
           

            dfs.addTimes(22, 3, 3);
            dfs.addTimes(22, 2, 0);
            dfs.addTimes(22, 3, 0);
            dfs.addTimes(22, 2, 0);
            dfs.addTimes(22, 2, 0);


            //arenberg est deja fait21->3,22,31,24 
            
            dfs.addTimes(21, 0, 3);
            //saint catherine 24->22,18,29,23
          

            dfs.addTimes(24, 3, 3);
            dfs.addTimes(24, 0, 0);
            dfs.addTimes(24, 3, 3);

            //bourse 23->22,24,25
          
            dfs.addTimes(23, 0, 0);
          
            //Annessens 25-> 23,28,2,31
           

            dfs.addTimes(25, 3, 3);
            dfs.addTimes(25, 2, 0);
            dfs.addTimes(25, 3, 3);

            //lemmonier 2-> 0,25,30
          
            dfs.addTimes(2, 2, 2);
            //porte d'anderlecht 30->21,2,31
           
            dfs.addTimes(30, 0, 0);
            //arts et metiers est deja donc fait 31->21,25,30

            //clemenceau 28->25,1,27


            dfs.addTimes(28, 0, 0);
            dfs.addTimes(28, 1, 1);
            //delacroix 1->0,28,27
            
            dfs.addTimes(1, 1, 1);
            //GDO 27->28,1,26,29
            

            dfs.addTimes(27, 1, 0);
            dfs.addTimes(27, 0, 0);
            //beekant 26->26,29
          

            dfs.addTimes(26, 1, 0);
            //etangs noir est deja donc fait 29->24,27

            //louvain 32-> 0,4,9,20
            dfs.addTimes(32, 1, 1);
            
            //machelen 20->3,32,19
          
            dfs.addTimes(20, 0, 0);

            //haren 19->20,18,15
            

            dfs.addTimes(19, 0, 4);
            dfs.addTimes(19, 3, 3);
           
            //gdn 18->0,9,3,24,19,13
            

            dfs.addTimes(18, 2, 2);
            dfs.addTimes(18, 3, 0);
            //rogier 13-> 3,22,18,12,14,15
        


            dfs.addTimes(13, 3, 0);
            dfs.addTimes(13, 1, 0);
            dfs.addTimes(13, 3, 3);
            
            
            //botanique 14->22,13,15,10
           

           
            dfs.addTimes(14, 0, 0);
            dfs.addTimes(14, 2, 2);
            //madou 15->19,13,14,16 
            
            dfs.addTimes(15, 3, 3);
           
            //presse 16->7,18,15,17
           
            dfs.addTimes(16, 2, 0);
            //treurenberg 17 ->16,10
            dfs.addTimes(17, 0, 2);
           
            //park 10->3,14,17,11
            
            dfs.addTimes(10, 2, 0);
          
            
            //isib 11->10,12
          
            dfs.addTimes(11, 2, 0);
            //saint josse est deja donc fait 12->13,11


        }
        */

        public void calculcote(NodesAndEdges coord)
        {
            for(int i =0; i< coord.verticalmatrix; i++)
            {   
                // Pour chaque noeud on calcule la resultante = x² + y² chaque noeud
                double result = Math.Sqrt((coord.Coord[i][0] * coord.Coord[i][0]) + (coord.Coord[i][1] * coord.Coord[i][1]));
               
                // on prend des valeurs qui ont 3 chiffre apres la virgule
                double sa = Math.Round(result, 3);
                Console.WriteLine(i + "->" + sa);
                coord.Cote[i].Add(sa);
            }
        }
        public void calculcout(NodesAndEdges coord,int noeudgoal)
        {   // Pour calculer le cout : on fait la difference entre le noeud goal et tous les autres noeuds(arrets qu'on connait)
            for (int i = 0; i < coord.verticalmatrix; i++)
            {
                if( i != noeudgoal)
                {   
                     
                   double x= Math.Abs(coord.Cote[i][0] - coord.Cote[noeudgoal][0]);
                    //on stocke dans cette liste la valeur de la soustraction  mais aussi l'identité du noeud
                    coord.Cout[i].Add(x);
                    coord.Cout[i].Add(i);
                }
                else if(i == noeudgoal)
                {
                    coord.Cout[i].Add(coord.Cote[noeudgoal][0]);
                    coord.Cout[i].Add(noeudgoal);
                }
               
            }
        }

        public void calcul_Times_trajets(NodesAndEdges coord, int noeudgoal)
        {   // Pour calculer le cout : on fait la difference entre le noeud goal et tous les autres noeuds(arrets qu'on connait)
            //on sait que x = v *t  t = x/v
            //on considere  que v = entre 30 et 40 km/h  
            Random random = new Random();
         
            for (int i = 0; i < coord.verticalmatrix; i++)
            {
                //pour chaque i on aura donc un speed different
                int speed = random.Next(30, 40);
                if (i != noeudgoal)
                {
                    double x = coord.Cout[i][0] / speed;
                    double result = Math.Round(x, 3);
                    //on stocke dans cette liste la valeur de la soustraction  mais aussi l'identité du noeud
                    coord.TimesTrajet[i].Add(result);
                    coord.TimesTrajet[i].Add(i);
                }
                else if (i == noeudgoal)
                {
                    coord.TimesTrajet[i].Add(0);
                    coord.TimesTrajet[i].Add(noeudgoal);
                }

            }
        }

        public void Addcoord(NodesAndEdges coord)
        {//les trois parametre correspond  (le numero du noeud, cordonnée en x , coordonné en y)
            //pdh
            coord.coordxy(5, 0, 1);
            //gdm
            coord.coordxy(0, 1, 1);
            //delacroix
            coord.coordxy(1, 1, 2);
            //GDO
            coord.coordxy(27, 1, 3.2f);
            //ottignies
            coord.coordxy(4, 5, 0);
            //charleroi
            coord.coordxy(6, 7, 0);
            //chatelet
            coord.coordxy(7, 10, 0);
            //Louvain
            coord.coordxy(32, 5, 0.8f);
            //chalineau
            coord.coordxy(8, 10, 0.8f);
            //machelen 
            coord.coordxy(20, 5, 1.3f);
            //namur
            coord.coordxy(9, 10, 1.3f);
            //porte anderlecht
            coord.coordxy(30, 2.5f, 1.8f);
            //Arts et metiers
            coord.coordxy(31, 4f, 1.8f);
            //lemmonier
            coord.coordxy(2, 2, 2);
            //Arenberg bus
            coord.coordxy(21, 7, 2);
            //GC
            coord.coordxy(3, 10, 2);
            //Park
            coord.coordxy(10, 12, 2);
            //ISIB
            coord.coordxy(11, 15, 2);
            //clemenceau
            coord.coordxy(28, 1, 2.4f);
            //Etang noirs
            coord.coordxy(29, 2, 2.5f);
            //saint catherine
            coord.coordxy(24, 5, 2.5f);
            //Haren
            coord.coordxy(19, 12, 2.5f);
            //GDN
            coord.coordxy(18, 15, 2.7f);
            //Treurenbeng bus
            coord.coordxy(17, 16, 2.3f);
            //Saint josse
            coord.coordxy(12, 13, 2.3f);
            //Presse bus
            coord.coordxy(16, 20, 2.8f);
            //Beekant
            coord.coordxy(26, 0.8f, 3.8f);
            //Annessens
            coord.coordxy(25, 4, 3.8f);
            //Bourse 
            coord.coordxy(23, 6, 3.8f);
            //Debrouckere
            coord.coordxy(22, 10, 3.8f);
            //Rogier
            coord.coordxy(13, 13, 3.8f);
            //Botanique
            coord.coordxy(14, 10.5f, 4);
            //Madou
            coord.coordxy(15, 15, 4 );

        }
    }
}
