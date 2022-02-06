using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NoeudInfoDecisionnelle
{
    public class NodesAndEdges
    {

//definition of stack: the last thing we push in this stack  become the first element in stack
//stack is a sort of list 
        public int verticalmatrix;
        public List<int>[] Matrix;
        //c'est un tableau de type list , cvd à l'intérieur de chaque case du tableau on a une list qui va etre crée
        public List<float>[] Coord;
        public List<double>[] Cote;
        public List<double>[] Cout;
        public List<double>[] Times;
        //public List<double>[] TimesTrajet;
        public List<double>[] TimesTrajet;
        //*****convert name station in integer ******
        public int ConvertINT(string dep)
        {
            int x = 0;
            if (dep == "GDM")
            {
                x = 0;

            }
            else if (dep == "Delacroix")
            {
                x = 1;

            }
            else if (dep == "Lemmonier")
            {
                x = 2;

            }

            else if (dep == "GC")
            {
                x = 3;

            }
            else if (dep == "Ottignies")
            {
                x = 4;

            }
            else if (dep == "Porte de hal")
            {
                x = 5;

            }
            else if (dep == "Charleroi")
            {
                x = 6;

            }
            else if (dep == "Chatelet")
            {
                x = 7;

            }
            else if (dep == "Chalineau")
            {
                x = 8;


            }
            else if (dep == "Namur")
            {
                //  Console.WriteLine(dep);
                x = 9;


            }
            else if (dep == "Park")
            {
                x = 10;


            }
            else if (dep == "ISIB")
            {

                x = 11;


            }
            else if (dep == "Saint Josse")
            {

                x = 12;


            }
            else if (dep == "Rogier")
            {

                x = 13;


            }
            else if (dep == "Botanique")
            {
                x = 14;

            }
            else if (dep == "Madou")
            {
                x = 15;

            }
            else if (dep == "Presse bus")
            {
                x = 16;

            }
            else if (dep == "Teurenberg bus")
            {
                x = 17;
            }
            else if (dep == "GDN")
            {
                x = 18;
            }
            else if (dep == "Haren")
            {
                x = 19;
            }
            else if (dep == "Machelen")
            {
                x = 20;
            }
            else if (dep == "Arenberg bus")
            {
                x = 21;
            }
            else if (dep == "Debrouckere")
            {
                x = 22;
            }
            else if (dep == "Bourse")
            {
                x = 23;
            }
            else if (dep == "Saint Catherine")
            {
                x = 24;
            }

            else if (dep == "Annessens")
            {
                x = 25;
            }
            else if (dep == "Beekant")
            {
                x = 26;
            }
            else if (dep == "GDO")
            {
                x = 27;
            }
            else if (dep == "Clemenceau")
            {
                x = 28;
            }
            else if (dep == "Etangs noir")
            {
                x = 29;
            }
          
            else if (dep == "Porte d'anderlecht")
            {
                x = 30;
            }
            else if (dep == "Arts et metiers")
            {
                x = 31;
            }
            //cvd que le nom encodé n'est pas reconnu commee une gare , recommencer ..... }
            return x;
        }
        public string ConvertsTRING(int dep)
        {
            string x = "";
            if (dep == 0)
            {
                x = "GDM";

            }
            else if (dep == 1)
            {
                x = "Delacroix";

            }
            else if (dep == 2)
            {
                x = "Lemmonier";

            }

            else if (dep ==3)
            {
                x = "GC";

            }
            else if (dep == 4)
            {
                x = "Ottignies";

            }
            else if (dep == 5)
            {
                x = "Porte de hal";

            }
            else if (dep == 6)
            {
                x = "Charleroi";

            }
            else if (dep == 7)
            {
                x = "Chatelet";

            }
            else if (dep ==8)
            {
                x = "Chalineau";


            }
            else if (dep == 9)
            {
                //  Console.WriteLine(dep);
                x = "Namur";


            }
            else if (dep == 10)
            {
                x = "Park";


            }
            else if (dep == 11)
            {

                x = "ISIB";


            }
            else if (dep == 12)
            {

                x = "Saint Josse";


            }
            else if (dep == 13)
            {

                x = "Rogier";


            }
            else if (dep == 14)
            {
                x = "Botanique";

            }
            else if (dep == 15)
            {
                x = "Madou";

            }
            else if (dep == 16)
            {
                x = "Presse bus";

            }
            else if (dep == 17)
            {
                x = "Teurenberg bus";
            }
            else if (dep == 18)
            {
                x = "GDN";
            }
            else if (dep == 19)
            {
                x = "Haren";
            }
            else if (dep == 20)
            {
                x = "Machelen";
            }
            else if (dep ==21)
            {
                x = "Arenberg bus";
            }
            else if (dep ==22)
            {
                x = "Debrouckere";
            }
            else if (dep == 23)
            {
                x = "Bourse";
            }
            else if (dep == 24)
            {
                x = "Saint Catherine";
            }

            else if (dep == 25)
            {
                x = "Annessens";
            }
            else if (dep == 26)
            {
                x = "Beekant";
            }
            else if (dep == 27)
            {
                x = "GDO";
            }
            else if (dep == 28)
            {
                x = "Clemenceau";
            }
            else if (dep == 29)
            {
                x = "Etangs noir";
            }

            else if (dep == 30)
            {
                x = "Porte d'anderlecht";
            }
            else if (dep == 31)
            {
                x = "Arts et metiers";
            }
            else if (dep == 32)
            {

                x = "Louvain";
            }
            //cvd que le nom encodé n'est pas reconnu commee une gare , recommencer ..... }
            return x;
        }

        int x = 0;

        //permet de convertir la resultante x² +y² de chaque point , et faire conrrespondre au noeud qui le convient
        public int Convertinttotint(double dep)
        {
            //int x =0;
            if (dep ==1.414)
            {
                x = 0;

            }
            else if (dep ==2.236)
            {
                x = 1;

            }
            else if (dep ==2.828)
            {
                x = 2;

            }

            else if (dep ==10.198)
            {
                x = 3;

            }
            else if (dep ==5)
            {
                x = 4;

            }
            else if (dep ==1)
            {
                x = 5;

            }
            else if (dep ==7)
            {
                x = 6;

            }
            else if (dep ==10)
            {
                x = 7;

            }
            else if (dep ==10.032)
            {
                x = 8;


            }
            else if (dep == 10.084)
            {
                //  Console.WriteLine(dep);
                x = 9;


            }
            else if (dep == 12.166)
            {
                x = 10;


            }
            else if (dep == 15.133)
            {

                x = 11;


            }
            else if (dep == 13.202)
            {

                x = 12;


            }
            else if (dep == 13.544)
            {

                x = 13;


            }
            else if (dep == 11.236)
            {
                x = 14;

            }
            else if (dep == 15.524)
            {
                x = 15;

            }
            else if (dep == 20.195)
            {
                x = 16;

            }
            else if (dep == 16.164)
            {
                x = 17;
            }
            else if (dep == 15.241)
            {
                x = 18;
            }
            else if (dep == 12.258)
            {
                x =19;
            }
            else if (dep == 5.166)
            {
                x = 20;
            }
            else if (dep == 7.28)
            {
                x = 21;
            }
            else if (dep == 10.698)
            {
                x = 22;
            }
            else if (dep == 7.102)
            {
                x = 23;
            }
            else if (dep == 5.59)
            {
                x = 24;
            }

            else if (dep == 5.517)
            {
                x = 25;
            }
            else if (dep == 3.883)
            {
                x = 26;
            }
            else if (dep == 3.353)
            {
                x = 27;
            }
            else if (dep == 2.6)
            {
                x = 28;
            }
            else if (dep == 3.202)
            {
                x = 29;
            }

            else if (dep == 3.081)
            {
                x = 30;
            }
            else if (dep == 4.386)
            {
                x = 31;
            }
            else if (dep == 5.064)
            {

                x = 32;
            }
            //cvd que le nom encodé n'est pas reconnu commee une gare , recommencer ..... }
            return x;
        }
     


        //**** nodes *****
        public NodesAndEdges(int verticalmatrix)
        {
            this.verticalmatrix = verticalmatrix;
            //initialisation de la taille du tableau
            Matrix = new List<int>[verticalmatrix];
            Coord = new List<float>[verticalmatrix];
            Cote = new List<double>[verticalmatrix];
            Cout = new List<double>[verticalmatrix];
            Times = new List<double>[verticalmatrix];
            TimesTrajet = new List<double>[verticalmatrix];
            for (int i=0; i< verticalmatrix; i++)
            {
                //instanciation de la liste dans chaque case 
                Matrix[i] = new List<int>();
                Coord[i] = new List<float>();
                Cote[i] = new List<double>();
                Cout[i] = new List<double>();
                Times[i] = new List<double>();
                 TimesTrajet[i] = new List<double>();
                //TimesTrajet[i] = new List<double>();
            }
        }



        public void coordxy(int source,float x , float y)
        {//permet d'ajouter la position x et y de chaque noeud
            Coord[source].Add(x);
            Coord[source].Add(y);
        }

        //****add all edges**********
        public  void addedges(string srce , string destin)
        {
            int source = ConvertINT(srce);
            int destination = ConvertINT(destin);

            Matrix[source].Add(destination);
            Matrix[destination].Add(source);

        }
        public void addedgesINT(int source, int destination)
        {
            Matrix[source].Add(destination);
            Matrix[destination].Add(source);
           
        
        }
        public void addedgesTimesTrajet(int source, int destination, int timetrajet)
        {
            //ajouter la durée ( du trajet pour aller  d'un point a à un point b)
            TimesTrajet[source].Add(timetrajet);
            TimesTrajet[destination].Add(timetrajet);
        }

        public void addTimes(int source,int time,int destination)
        {//permet d'ajouter le temps pour arriver à un arret de tram ou de metro ou de bus
            //si pour la source on a un arret de metro et qu'à la destination aussi time=0 
            //si sur le meme arret on doit prendre par exple le bus  on augmente  time =2
            //chaque time correspond à chaque arret dans la liste des edges cad 
            // dfs.addedgesINT(0, 3);   pour aller de 0 à 3 on verifie si prend un metro ou pas 
            
            Times[source].Add(time);
            Times[destination].Add(time);
        }


        public double returnvalue = 0;
        public double Accesnoeud(NodesAndEdges coord, double response)
        {
            for (int i = 0; i < coord.verticalmatrix; i++)
            {
                if ( this.Cout[i][0]== response)
                {
                    returnvalue= this.Cout[i][1];
                    //dans   Cout : la case zero correpond au cout (entre le noeud et le noeud de destination) et le deuxième cout correspond au noeud en question 
                   //return la valeur du noeud on veut supprimer dans le greedy

                }
               

            }

            return returnvalue;
        }




        public double AccesnoeudAstar(NodesAndEdges coord, double response)
        {
            for (int i = 0; i < coord.Times.Length; i++)
            {
                for (int j = 0; j < coord.Times[i].Count; j++)
                {

                    if (this.Times[i][j] == response)
                    {
                        returnvalue = this.Times[i][this.Times[i].Count-1] ;//    this.Times[i][1];
                        //return la dernier element de la liste parcequ'on sait que dans cette liste le dernier element correspond à un noeud
                    }
                }

            }

            return returnvalue;
        }


        // cette methode permet de sommer toutes
        public double calculcouttotal(NodesAndEdges coord, int item,int nodestation , List<double> liscotes,double[] coutcumu)
        {//calcul du cout total 
         //le item correpsond à la destination
            double valueof_X = 0;
            for (int i = 0; i < coord.verticalmatrix; i++)
            {
                if (i == item)
                {// x = valeur de la fonction heuristique + durée du trajet entre la noeud precedent et le noeud suivant + la durée du changement de trajet
                    double x = this.Cout[i][0] + this.TimesTrajet[i][0] + Timestrajets(nodestation, i) + ChangementTrajet(nodestation, i)+coutcumu[nodestation];
                    //on stocke dans cette liste la valeur de la soustraction  mais aussi l'identité du noeud
                    //il ecrase chaque valeur qui se trouvait dans cette case avant de mettre une nouvelle
                    //coord.Times[i].Clear();

                    //cout muculatif
                   //coutcumu[i] = Timestrajets(nodestation,i);
                    coutcumu[i] = this.TimesTrajet[i][0];
                    // on insere la valeur du cout total et aussi le neud en question
                    coord.Times[i].Insert(0,x);
                    coord.Times[i].Add(i);
                    //x va dans la liste des cotes
                    liscotes.Add(x);
                    valueof_X = x;
                }

            }
            return valueof_X;
        }


        public double calculcouttotal_bis(NodesAndEdges coord, int item, int nodestation, List<double> liscotes, double[] coutcumu)
        {//calcul du cout total 
         //le item correpsond à la destination
            double valueof_X = 0;
            for (int i = 0; i < coord.verticalmatrix; i++)
            {
                if (i == item)
                {// x = valeur de la fonction heuristique + durée du trajet entre la noeud precedent et le noeud suivant + la durée du changement de trajet+la valeur du coup precedent 
                    double x = this.Cout[i][0] + this.TimesTrajet[i][0] + ChangementTrajet(nodestation, i)+coutcumu[nodestation];
                    //on stocke dans cette liste la valeur de la soustraction  mais aussi l'identité du noeud
                    //il ecrase chaque valeur qui se trouvait dans cette case avant de mettre une nouvelle
                    //coord.Times[i].Clear();

                    //cout muculatif correspond au temps de trajet qu'on effectue pour aller d'un pt A à un pt B
                    //cout muculatif va permettre à chaque fois de rajouter la durée qu'on a effectuer pour aller par exemple de 0->1 (au debut coutcumu[nodestation]=0
                    //ensuite on stocke la duree (le temps de trajet) dans la case i qui correspond à la destination (cvd 1 )
                    //ensuite si on rappelle la methode et qu'on fait coutcumu[nodestation] , cette valeur correspondra à la valeur qui a été stocké precedement dans la case i de coutcumu 
                    //(le cout cumulatif precedent)
                    // coutcumu[i] = Timestrajets(nodestation,i);
                     coutcumu[i] = this.TimesTrajet[i][0];
                    // on insere la valeur du cout total et aussi le neud en question
                    coord.Times[i].Insert(0, x);
                    coord.Times[i].Add(i);
                    //x va dans la liste des cotes
                  
                    valueof_X = x;
                }

            }
            return valueof_X;
        }


        //*****methods *******
        public int DFS(int nodestation, int goalnode)
        {

            int nombre_noeud_visited = 0;

            //dans ce tableau de booleen,toutes les cases sont mis à false
            bool[] nodevisited = new bool[this.verticalmatrix];
            //initialiseer le premier noedu à true
            nodevisited[nodestation] = true;


            //Stack est une sorte de liste, qui va me permettre de supprimer le premier element de la list nommée stack
            Stack<Int32> stack = new Stack<int>();
            stack.Push(nodestation);

            //stack2 permet l'affichage de données
            Stack<List<Int32>> stack2 = new Stack<List<int>>();
            List<int> stack2_list = new List<int>();
            stack2_list.Add(nodestation);
            stack2.Push(stack2_list);
            
            //condition pour s'arreter
            bool stopgoal =true ;
           
            

            while (stack.Count != 0  && stopgoal ==true)
            {
                //on retire le  premier element  qui se trouve dans la list stack
                nodestation = stack.Pop();

                //on retire la liste qui contient le nodestation 
                List<int> List_parcouru=  stack2.Pop();
             
               

                //condition pour s'arrêter
                if (goalnode == nodestation)
                {
                    stopgoal = false;
                    for(int i = 0; i < List_parcouru.Count; i++)
                    {
                       Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));
                        
                        nombre_noeud_visited = List_parcouru.Count;

                    }
                }

               
                
                foreach (int item in Matrix[nodestation]) {
                   
                    //on verifie si on est pas encore passer au niveau de cette station. (elle permet d'eviter de faire des boucles) 
                    if (nodevisited[item] ==false)
                    {
                        //copie list :cad=> je fais un clone de la list "List_parcouru" qui contient le noeud parent et tous les autres noeuds parent precedent
                        List<int> tmp = new List<int>(List_parcouru);


                        nodevisited[item] = true;
                        //exemple pour 1->2,3,4 , on met chaque element à true
                        //puis on ajoute 2 3 4 dans la stack
                        //le dernier element à etre push est le premier element dans la stack
                        stack.Push(item);
                       
                        //permet l'affichafe des données
                        tmp.Add(item);
                        stack2.Push(tmp);
                        
                    }
                        }

            }
            
            return nombre_noeud_visited -1;
        }

        public int GREEDY(int nodestation, int goalnode )       {
            
            int nodes_visited = 0;
            int nombre_noeud_visited = 0;

            //dans ce tableau de booleen,toutes les cases sont mis à false
            bool[] nodevisited = new bool[this.verticalmatrix];
            List<Int32> stack = new List<int>();
            //liscotes permet de stocker la valeur (le cout) de la fonction heuristique
            List<double> listcotes = new List<double>();
            
            //initialiseer le premier noeud à true
            nodevisited[nodestation] = true;
            stack.Add(nodestation);
            //on ajoute le cout qui correspond au noeud
            listcotes.Add(this.Cout[nodestation][0]);


            //stack2 permet l'affichage de données
            List<List<Int32>> stack2 = new List<List<int>>();
            List<int> stack2_list = new List<int>();
            stack2_list.Add(nodestation);
            stack2.Add(stack2_list);

            //condition pour s'arreter
            bool stopgoal = true;


            while (listcotes.Count != 0 && stopgoal == true)
            {
              
               

               //Cette methode acces retourne la valeur du noeud qui a été stocké dans list Cout dans lequel on peut trouver le valeur du noeud et la valeur du coup

                 double stat =Accesnoeud(this, listcotes[0]);
                // int valeur= Convertinttotint(stat);
                listcotes.Remove(listcotes[0]);
                // nodestation = stack[0];
                // nodestation = Convertinttotint(stat);

                

              
                nodestation = (int)stat;
                List<int> List_parcouru = new List<int>(); ;
                
               
                if ( stack.Contains(nodestation) == true)
                {
                    //on supprime le noeud en question dans le stack
                    //on retire le contenu du premier element  qui se trouve dans la list stack

                    stack.Remove(nodestation);


                    //on verifie que ce noeud existe dans une list qui se trouve dans stack2
                    for ( int i = 0; i< stack2.Count; i++)
                    {

                        if (stack2[i].Contains(nodestation) == true)
                        {//je supprime la liste qui contient cette valeur là
                            List_parcouru = stack2[i];
                            stack2.Remove(stack2[i]);
                        }
                    }
                   
                }
              
               
                nodes_visited++;

                //permet l'affichage de tous les noeuds  qui permettent d'atteindre le noeud goal
                if (goalnode == nodestation)
                {
                    stopgoal = false;
                    for (int i = 0; i < List_parcouru.Count; i++)
                    {
                        Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));
                        nombre_noeud_visited = List_parcouru.Count;

                    }
                }
               
                
                foreach (int item in Matrix[nodestation])
                {
                    
                    if (nodevisited[item] == false)
                    {
                        //copie list :cad=> je fais un clone de la list "List_parcouru" qui contient le noeud parent et tous les autres noeuds parent precedent
                        List<int> tmp = new List<int>(List_parcouru);


                        nodevisited[item] = true;
                        //exemple pour 1->2,3,4 , on met chaque element à true
                        //puis on ajoute 2 3 4 dans la stack
                        //le dernier element à etre push est le premier element dans la stack
                        stack.Insert(0,item);
                        //this.Cout[item][0] correspond au cout (entre ce noeud (item) et le noeud de destination )
                        listcotes.Add(this.Cout[item][0]);

                        tmp.Add(item);
                        stack2.Insert(0, tmp);

                       
                        
                    }
                }
                listcotes.Sort();
            }
            return nombre_noeud_visited-1;
        }

        public int BEAM(int nodestation, int goalnode )
        {
            // J'ai crée deux listes , une premiere qui permet d'ajouter à chaque fois les noeuds enfants et supprimer le noeud qui a le plus petit cout 

            int nombre_noeud_visited = 0;
            int nodes_visited =0;
            bool[] nodevisited = new bool[this.verticalmatrix];
            List<Int32> stack = new List<int>();
            List<double> listcotes = new List<double>();
            //initialiseer le premier noedu à true
            nodevisited[nodestation] = true;
            stack.Add(nodestation);
            listcotes.Add(this.Cout[nodestation][0]);
           


            List<List<Int32>> stack2 = new List<List<int>>();
            List<int> stack2_list = new List<int>();

            stack2_list.Add(nodestation);
            stack2.Add(stack2_list);

        
            
            bool stopgoal = true;
            while (stack.Count != 0 && stopgoal == true)
            {
                //les deux liste permettent l'affichage  du chemin
                List<int> List_parcouru = new List<int>(); ;
                List<int> List_parcouru2 = new List<int>();

                if (listcotes.Count == 1)
                {
                  //  listcotes.Sort();
                    //donne le numero du noeud
                    double stat1 = Accesnoeud(this, listcotes[0]);
                    nodestation = (int)stat1;

                    
                    //vider le contenu de la liste
                    stack.Clear();
                    listcotes.Clear();

                    nodes_visited++;
                    if (goalnode == nodestation)
                    {

                      

                        stopgoal = false;

                        for (int i = 0; i < List_parcouru.Count; i++)
                        {
                            Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));
                            nombre_noeud_visited = List_parcouru.Count;

                        }

                        
                    }

                    for (int i = 0; i < stack2.Count; i++)
                    {

                        if (stack2[i].Contains(nodestation) == true)
                        {//je supprime la liste qui contient cette valeur là
                            List_parcouru = stack2[i];
                            stack2.Clear();
                            break;
                        }
                    }


                    foreach (int item in Matrix[nodestation])
                    {//item correspond à la valeur qui se trouve dans la li
                        if (nodevisited[item] == false)
                        {
                            List<int> tmp = new List<int>(List_parcouru);

                            nodevisited[item] = true;
                            //exemple pour 1->2,3,4 , on met chaque element à true
                            //puis on ajoute 2 3 4 dans la stack
                            //le dernier element à etre push est le premier element dans la stack
                            
                            
                            stack.Add(item);
                            tmp.Add(item);
                            stack2.Add(tmp);

                            listcotes.Add(this.Cout[item][0]);

                        } 
                    }
                    listcotes.Sort();
                }



              else  if (listcotes.Count > 1)
                {
                   // listcotes.Sort();
                    //donne le numero du noeud
                    double stat = Accesnoeud(this, listcotes[0]);

                    double stat2 = Accesnoeud(this, listcotes[1]);

                    nodestation = (int)stat;

                    nodes_visited++;
                    nodes_visited++;


                
                    
                        for (int i = 0; i < stack2.Count; i++)
                    {

                        if (stack2[i].Contains(nodestation) == true )
                        {//je supprime la liste qui contient cette valeur là
                            List_parcouru = stack2[i];
                           
                            
                        }
                        if (stack2[i].Contains((int)stat2) == true)
                        {//je supprime la liste qui contient cette valeur là
                            List_parcouru2 = stack2[i];


                        }
                    }
               


                    stack.Clear();
                    listcotes.Clear();
                    stack2.Clear();
                    foreach (int item in Matrix[nodestation])
                    {//item correspond à la valeur qui se trouve dans la li
                        if (nodevisited[item] == false)
                        {
                            List<int> tmp = new List<int>(List_parcouru);

                            nodevisited[item] = true;
                            //exemple pour 1->2,3,4 , on met chaque element à true
                            //puis on ajoute 2 3 4 dans la stack
                            //le dernier element à etre push est le premier element dans la stack


                            stack.Add(item);
                            tmp.Add(item);
                            stack2.Add(tmp);

                            listcotes.Add(this.Cout[item][0]);

                        }
                    }
                    foreach (int item in Matrix[(int)stat2])
                    {//item correspond à la valeur qui se trouve dans la li
                        if (nodevisited[item] == false)
                        {
                            List<int> tmp = new List<int>(List_parcouru2);

                            nodevisited[item] = true;
                            //exemple pour 1->2,3,4 , on met chaque element à true
                            //puis on ajoute 2 3 4 dans la stack
                            //le dernier element à etre push est le premier element dans la stack
                            stack.Add(item);
                            tmp.Add(item);
                            stack2.Add(tmp);

                            listcotes.Add(this.Cout[item][0]);

                        }
                    }

                    listcotes.Sort();

                  
                    //vider le contenu de la liste
                    if (goalnode == nodestation || goalnode == (int)stat2)
                    {
                        stopgoal = false;

                        for (int i = 0; i < List_parcouru.Count; i++)
                        {
                            Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));
                            nombre_noeud_visited = List_parcouru.Count;

                        }
                    }
                
                }

            }
            return nombre_noeud_visited-1;
        }






        public int A(int nodestation, int goalnode)
        {
            int nodes_visited = 0;
            //je stocke dans cette list , tous les heuristique du noeud goal
            List<int> stockake_heuristik_node = new List<int>();

            bool[] nodevisited = new bool[this.verticalmatrix];
            
            //permet denregistrer le cout precedent
            double[] coutcumulatif= new double[this.verticalmatrix];

            List<int> aleatorlist = new List<int>();
            List<double> listcotes = new List<double>();
            aleatorlist.Add(nodestation);
            int nodeStart = nodestation;
            listcotes.Add(this.Cout[nodestation][0]);
            //initialiseer le premier noedu à true
            nodevisited[nodestation] = true;
            coutcumulatif[nodestation] = 0;
            bool stopgoal = true;


            //booleen qui permet de savoir si le noeud a été atteint ou pas
            bool noeudAtteint = false;

            //cout_du_goal = est le cout qu'on obtient après avoir atteint le atteint le goal une premiere fois
            //selon le principe de branch and bound:Enlever tous les chemins partiels qui ont un coût accumulé ≥ celui du chemin trouvé ((cout_du_goal))
            // et ensuite Continuer la recherche pour le chemin suivant
            double cout_du_goal = 0;
            
            int nodestart = nodestation;
            
            //ce boolean m'aide à savoir si c'est le premier goal qu'on a atteint
            bool checkfirstnodegoal = false;


            //permet l'affcihe du chemin pris
            List<List<Int32>> stack2 = new List<List<int>>();
            //stack3 stocke seulement la liste de ceux qui atteignent  le goal
            List<int> stack2_list = new List<int>();

           // List<List<int>> stack_stock = new List<List<int>>();
            stack2_list.Add(nodestation);


            stack2.Add(stack2_list);

           // int passage_sur_le_noeudgoal = 0;
            int nombre_noeud_visited = 0;

         

            Times[nodestation].Insert(0,listcotes[0]);
            Times[nodestation].Add(nodestation);
           
            while (aleatorlist.Count != 0 && stopgoal == true)
            {
                //on verifie a chaque noeud qui a le cout cumulatif parmis tous les noeuds qui se trouvent dans la queue.
                //on retire le contenu du premier element  qui se trouve dans la list stack


                //  listcotes.Sort();

                

                nodestation = (int)AccesnoeudAstar(this, listcotes[0]);

                List<int> List_parcouru = new List<int>(); ;
   

               


                for (int i = 0; i < stack2.Count; i++)
                {

                    if (stack2[i].Contains(nodestation) == true)
                    {//je supprime la liste qui contient cette valeur là
                        List_parcouru = stack2[i];
                        stack2.Remove(stack2[i]);
                        
                        break;
                    }
                }




                if (goalnode == nodestation)
                {
                    //ce boolean m'aide à savoir si c'est le premier goal qu'on a atteint
                    if (checkfirstnodegoal == false)
                    {

                        //j'affiche ducoup le resultat
                        for (int i = 0; i < List_parcouru.Count; i++)
                        {
                            Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));
                            nombre_noeud_visited = List_parcouru.Count;

                        }



                        //apres avoir atteint le goal, on ne s'arrête pas
                        //on fait en sorte que tous les noeuds qu'on a déjà visité et qui ont permis d'atteindre le premier goal soit à true
                        for (int k = 0; k < nodevisited.Length; k++)
                        {

                            if (List_parcouru.Contains(k))
                            {
                                nodevisited[k] = true;

                              
                            }else
                            {
                                nodevisited[k] = false;
                            }


                            

                        }



                        ///*****
                        ///reinitialisation  de tous on commence à 0 ,sauf des noeuds déjà visité  qui ont permis d'atteindre le goal

                        nodestation = nodestart;
                        noeudAtteint = true;
                        nodevisited[goalnode] = false;
                        nodevisited[nodeStart] = true;
                        listcotes.Clear();
                        aleatorlist.Clear();
                        stack2.Clear();
                        
                        List_parcouru.Clear();
                        listcotes.Add(this.Cout[nodestation][0]);
                        aleatorlist.Add(nodestation);
                        
                        stack2.Add(aleatorlist);
                        checkfirstnodegoal = true;


                        for (int i = 0; i < stack2.Count; i++)
                        {

                            if (stack2[i].Contains(nodestation) == true)
                            {//je supprime la liste qui contient cette valeur là
                                List_parcouru = stack2[i];
                                stack2.Remove(stack2[i]);

                                break;
                            }
                        }

                        ///*****
                       
                    }
                    else
                    {
                        //si on trouve un nouveau goal qui a un coup inférieur au cout_du_goal precedant , on l'affiche 
                        // et on arrête la boucle

                        stopgoal = false;
                        Console.WriteLine("=========autres solutions de trajets==========");
                        Console.WriteLine("next-> " + ConvertsTRING(nodestart));
                        for (int i = 0; i < List_parcouru.Count; i++)
                        {
                            Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));

                        }
                        nombre_noeud_visited += List_parcouru.Count;
                    }
                }

        
                
                    aleatorlist.Remove(nodestation);
                    //enlever le premier element de la liste
                    listcotes.Remove(listcotes[0]);


                // noeudAtteint pour savoir si le noeud goal est atteint ou pas
                if (noeudAtteint == false)
                {

                    foreach (int item in Matrix[nodestation])
                    {


                        if (nodevisited[item] == false)
                        {


                            nodevisited[item] = true;


                            //copie list :pour permettre à chaque item une nouvelle list qui contient le noeud parent et tous les autres noeuds parent precedent
                            List<int> tmp = new List<int>(List_parcouru);


                            aleatorlist.Add(item);
                            tmp.Add(item);


                            stack2.Add(tmp);

                            // listcotes.Add(this.Cout[item][0] + Timestrajets(nodestation, item) + ChangementTrajet(nodestation, item));

                            //on calcul le cout total par rapport à chaque noeud enfant   . le "item" correspnd à  
                            calculcouttotal(this, item, nodestation, listcotes, coutcumulatif);

                            //liscouts2.Add(this.Cout[item][0]);
                            //stack4.Add(nodevisited2);
                        }

                        if (aleatorlist.Count == 0)
                        {
                            Console.WriteLine("la liste est vide");
                        }

                        if (item == goalnode)
                        {
                            cout_du_goal = calculcouttotal(this, item, nodestation, listcotes, coutcumulatif);
                        }
                    }
                }
                else
                {
                    
                    foreach (int item in Matrix[nodestation])
                    {
                        //la difference entre calculcouttotal_bis et calculcouttotal est que calculcouttotal_bis  n'ajoute pas le cout dans liscotes
                        double search = calculcouttotal_bis(this, item, nodestation, listcotes, coutcumulatif);
                        if (nodevisited[item] == false)
                        {


                            nodevisited[item] = true;
                           
                            //on verifie la condition  branch and bound
                            if (search < cout_du_goal)
                            {

                                //copie list :pour permettre à chaque item une nouvelle list qui contient le noeud parent et tous les autres noeuds parent precedent
                                List<int> tmp = new List<int>(List_parcouru);


                                aleatorlist.Add(item);
                                tmp.Add(item);


                                stack2.Add(tmp);

                                listcotes.Add(search);

                             
                            }
                        }

                      
                    }
                    if (aleatorlist.Count == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("On n'a pas trouvé une meilleur solution");
                    }
                }
    



                listcotes.Sort();
            
            }

            return nombre_noeud_visited-1;
        }




        public int RND(int deleteelement, int goalnode)
        {
            int nodes_visited = 0;
            bool[] nodevisited = new bool[this.verticalmatrix];
          
            List<Int32> aleatorlist = new List<int>();
            aleatorlist.Add(deleteelement);
            //initialiseer le premier noedu à true
            nodevisited[deleteelement] = true;

            List<List<Int32>> stack2 = new List<List<int>>();
            List<int> stack2_list = new List<int>();

            stack2_list.Add(deleteelement);
            stack2.Add(stack2_list);

            int nombre_noeud_visited = 0;

            bool stopgoal = true;
            while (aleatorlist.Count != 0 && stopgoal == true)
            {
                //on retire le contenu du premier element  qui se trouve dans la list stack
              
              
                deleteelement = aleatorlist[0];
                aleatorlist.Remove(aleatorlist[0]);
                List<int> List_parcouru = stack2[0]; 
                
                stack2.Remove(stack2[0] );
                
                
                nodes_visited++;
                if (goalnode == deleteelement)
                {
                    stopgoal = false;
                    for (int i = 0; i < List_parcouru.Count; i++)
                    {
                        Console.WriteLine("next->" + ConvertsTRING(List_parcouru[i]));
                        nombre_noeud_visited = List_parcouru.Count;

                    }
                }
               
               // Console.WriteLine("next->" + ConvertsTRING(deleteelement));
                

                foreach (int item in Matrix[deleteelement])
                {
                    if (nodevisited[item] == false)
                    {
                        //copie list :pour permettre à chaque item une nouvelle list qui contient le noeud parent et tous les autres noeuds parent precedent
                        List<int> tmp = new List<int>(List_parcouru);

                        nodevisited[item] = true;
                        
                        //on ajoute de maniere aléatoire chaque élément dans cette list 
                        Random r = new Random();
                        int aleatoirvalue = r.Next(0, aleatorlist.Count);
                        aleatorlist.Insert(aleatoirvalue,item);
                        
                        tmp.Add( item);
                        stack2.Insert(aleatoirvalue,tmp);
                    }
                }

               
                
            }
            return nombre_noeud_visited-1 ;
        }


        public  void display()
        {
            for(int i = 0; i < verticalmatrix; i++)
            {
                if (Matrix[i].Count > 0)
                {
                    Console.WriteLine("Pour le noeud " + i + ":");
                    for (int j = 0; j < Matrix[i].Count; j++)
                    {
                        // [j] ce sont les elements de la liste
                        Console.WriteLine("=> " + Matrix[i][j] + " ");

                    }
                }
            }
        }

        public int s;
        public int Timestrajets(int source , int destination)
        {
            //-source---destination---timetrajet
            //GDM 0->3,1,2,18,4,32,5
           /* dfs.addedgesTimesTrajet(0, 3, 4);
            dfs.addedgesTimesTrajet(0, 1, 1);
            dfs.addedgesTimesTrajet(0, 2, 1);
            dfs.addedgesTimesTrajet(0, 18, 6);
            dfs.addedgesTimesTrajet(0, 4, 30);
            dfs.addedgesTimesTrajet(0, 32, 30);
            dfs.addedgesTimesTrajet(0, 5, 1);
           */

            if( (source ==0 && destination == 3)|| (source == 3 && destination == 0))
            {
                return s= 4;
            }
            if ((source == 0 && destination == 1) || (source == 1 && destination == 0))
            {
                return s=1;
            }
            if ((source == 0 && destination == 2) || (source == 2 && destination == 0))
            {
                return s=1;
            }
            if ((source == 0 && destination == 18) || (source == 18 && destination == 0))
            {
                return s=6;
            }
            if ((source == 0 && destination == 4) || (source == 4 && destination == 0))
            {
                return s=30;
            }
            if ((source == 0 && destination == 32) || (source == 32 && destination == 0))
            {
                return s=30;
            }
            if ((source == 0 && destination == 5) || (source == 5 && destination == 0))
            {
                return s=1;
            }



            //ottignies 4-> 0,6,32
           // dfs.addedgesTimesTrajet(4, 6, 30);
            //dfs.addedgesINT(4, 32, 15);

            if ((source == 4 && destination == 6) || (source == 6 && destination == 4))
            {
                return s=30;
            }
            if ((source == 4 && destination == 32) || (source == 32 && destination == 4))
            {
                return s=15;
            }



            //charleroi 6->4,7
           // dfs.addedgesINT(6, 7, 20);
            if ((source == 6 && destination == 7) || (source == 7 && destination == 6))
            {
                return s=20;
            }

            //chatelet  7->6,8,16
            //dfs.addedgesINT(7, 8, 30);
           // dfs.addedgesINT(7, 16, 40);

            if ((source == 7 && destination == 8) || (source == 8 && destination == 7))
            {
                return s=30;
            }
            if ((source == 7 && destination == 16) || (source ==16  && destination == 7))
            {
                return s=40;
            }

            //chalineau 8-> 7,9
            //dfs.addedgesINT(8, 9, 10);

            if ((source == 8 && destination == 9) || (source == 9 && destination == 8))
            {
                return s=10;
            }
            //Namur 9->8,3,32,18
            /*
            dfs.addedgesINT(9, 3, 36);
            dfs.addedgesINT(9, 32, 10);
            dfs.addedgesINT(9, 18, 20);
           */
            if ((source == 9 && destination == 3) || (source == 3 && destination == 9))
            {
                return s=36;
            }
            if ((source == 9 && destination == 32) || (source == 32 && destination == 9))
            {
                return s=10;
            }
            if ((source == 9 && destination == 18) || (source == 18 && destination == 9))
            {
                return s=20;
            }
          
            //GC 3->0,9,10,18,22,21,20,
          /*  dfs.addedgesINT(3, 10, 1);
            dfs.addedgesINT(3, 18, 10);
            dfs.addedgesINT(3, 22, 1);
            dfs.addedgesINT(3, 13, 5);
            dfs.addedgesINT(3, 21, 6);
            dfs.addedgesINT(3, 20, 15);
            */
            if ((source == 3 && destination == 10) || (source == 10 && destination == 3))
            {
                return s=1;
            }
            if ((source == 3 && destination == 18) || (source == 18 && destination == 3))
            {
                return s=10;
            }
            if ((source == 3 && destination == 22) || (source == 22 && destination == 3))
            {
                return s=1;
            }
            if ((source == 3 && destination == 13) || (source == 13 && destination == 3))
            {
                return s=5;
            }
            if ((source == 3 && destination == 21) || (source == 21 && destination == 3))
            {
                return s=6;
            }
            if ((source == 3 && destination == 20) || (source == 20 && destination == 3))
            {
                return s=15;
            }

            //debrouckere 22->3,14,13,21,23,24
           /* dfs.addedgesINT(22, 14, 1);
            dfs.addedgesINT(22, 13, 2);
            dfs.addedgesINT(22, 21, 4);
            dfs.addedgesINT(22, 23, 1);
            dfs.addedgesINT(22, 24, 2);
            */
            if ((source == 22 && destination == 14) || (source == 14 && destination == 22))
            {
                return s=1;
            }
            if ((source == 22 && destination == 13) || (source == 13 && destination == 22))
            {
                return s= 2;
            }
            if ((source == 22 && destination == 21) || (source == 21 && destination == 22))
            {
                return s=4;
            }
            if ((source == 22 && destination == 23) || (source == 23 && destination == 22))
            {
                return s=1;
            }
            if ((source == 22 && destination == 24) || (source == 24 && destination == 22))
            {
                return s=2;
            }


            //arenberg est deja fait21->3,22,31,24 
            //dfs.addedgesINT(21, 31, 3);
            if ((source == 21 && destination == 31) || (source == 31 && destination == 21))
            {
                return s=3;
            }
            //saint catherine 24->22,18,29,23
         /*   dfs.addedgesINT(24, 18, 12);
            dfs.addedgesINT(24, 29, 2);
            dfs.addedgesINT(24, 23, 6);
         */
            if ((source == 24 && destination == 18) || (source == 18 && destination == 24))
            {
                return s=12;
            }
            if ((source == 24 && destination == 29) || (source == 29 && destination == 24))
            {
                return s=2;
            }
            if ((source == 24 && destination == 23) || (source == 23 && destination == 24))
            {
                return s=6;
            }


            //bourse 23->22,24,25
            //dfs.addedgesINT(23, 25, 1);
            if ((source == 23 && destination == 25) || (source == 25 && destination == 23))
            {
                return s=1;
            }
            //Annessens 25-> 23,28,2,31
          /*  dfs.addedgesINT(25, 28, 4);
            dfs.addedgesINT(25, 2, 1);
            dfs.addedgesINT(25, 31, 5);
            */

            if ((source == 25 && destination == 28) || (source == 28 && destination == 25))
            {
                return s=4;
            }
            if ((source == 25 && destination == 2) || (source == 2 && destination == 25))
            {
                return s=1;
            }
            if ((source == 25 && destination == 31) || (source == 31 && destination == 25))
            {
                return s=5;
            }

            //lemmonier 2-> 0,25,30
           // dfs.addedgesINT(2, 30, 2);
            if ((source == 2 && destination == 30) || (source == 30 && destination == 2))
            {
                return s=2;
            }
            //porte d'anderlecht 30->21,2,31
            //dfs.addedgesINT(30, 31, 1);
            if ((source == 30 && destination == 31) || (source == 31 && destination == 30))
            {
                return s=1;
            }
            //arts et metiers est deja donc fait 31->21,25,30

            //clemenceau 28->25,1,27
  //          dfs.addedgesINT(28, 1, 1);
//            dfs.addedgesINT(28, 27, 2);

            if ((source == 28 && destination == 1) || (source == 1 && destination == 28))
            {
                return s=1;
            }
            if ((source == 28 && destination == 27) || (source == 27 && destination == 28))
            {
                return s=2;
            }

            //delacroix 1->0,28,27
         //   dfs.addedgesINT(1, 27, 1);
           
            if ((source == 1 && destination == 27) || (source == 27 && destination == 1))
            {
                return s=1;
            }
            //GDO 27->28,1,26,29
            
            //dfs.addedgesINT(27, 26, 5);
            //dfs.addedgesINT(27, 29, 2);

            if ((source == 27 && destination == 26) || (source == 26 && destination == 27))
            {
                return s=5;
            }
            if ((source == 27 && destination == 29) || (source == 29 && destination == 27))
            {
                return s=2;
            }

            //beekant 26->26,29
            //dfs.addedgesINT(26, 29, 4);
            if ((source == 26 && destination == 29) || (source == 29 && destination == 26))
            {
                return s= 4;
            }
            //etangs noir est deja donc fait 29->24,27

            //louvain 32-> 0,4,9,20
           // dfs.addedgesINT(32, 20, 10);
            if ((source == 32 && destination == 20) || (source == 20 && destination == 32))
            {
                return s=10;
            }

            //machelen 20->3,32,19
            //dfs.addedgesINT(20, 19, 9);
            if ((source == 20 && destination == 19) || (source == 19 && destination == 20))
            {
                return s=9;
            }

            //haren 19->20,18,15
  //          dfs.addedgesINT(19, 18, 10);
//            dfs.addedgesINT(19, 15, 5);

            if ((source == 19 && destination == 18) || (source == 18 && destination == 19))
            {
                return s=10;
            }
            if ((source == 19 && destination == 15) || (source == 15 && destination == 19))
            {
                return s=5;
            }
            //gdn 18->0,9,3,24,19,13
            //dfs.addedgesINT(18, 13, 1);
            //dfs.addedgesINT(18, 16, 8);

            if ((source == 18 && destination == 13) || (source == 13 && destination == 18))
            {
                return s=1;
            }
            if ((source == 18 && destination == 16) || (source == 16 && destination == 18))
            {
                return s=8;
            }

            //rogier 13-> 3,22,18,12,14,15
            //dfs.addedgesINT(13, 12, 5);
            //dfs.addedgesINT(13, 14, 1);
            //dfs.addedgesINT(13, 15, 5);

            if ((source == 13 && destination == 12) || (source == 12 && destination == 13))
            {
                return s=5;
            }
            if ((source == 13 && destination == 14) || (source == 14 && destination == 13))
            {
                return s=1;
            }
            if ((source == 13 && destination == 15) || (source == 15 && destination == 13))
            {
                return s=5;
            }

            //botanique 14->22,13,15,10
            //dfs.addedgesINT(14, 15, 1);
           // dfs.addedgesINT(14, 10, 2);

            if ((source == 14 && destination == 15) || (source == 15 && destination == 14))
            {
                return s=1;
            }
            if ((source == 14 && destination == 10) || (source == 10 && destination == 14))
            {
                return s=2;
            }

            //madou 15->19,13,14,16 
           // dfs.addedgesINT(15, 16, 4);

            if ((source == 15 && destination == 16) || (source == 16 && destination == 15))
            {
                return s=4;
            }
            //presse 16->7,18,15,17
            //dfs.addedgesINT(16, 17, 3);

            if ((source == 16 && destination == 17) || (source == 17 && destination == 16))
            {
                return s=3;
            }
            //treurenberg 17 ->16,10
            //dfs.addedgesINT(17, 10, 4);

            if ((source == 17 && destination == 10) || (source == 10 && destination == 17))
            {
                return s=4;
            }

            //park 10->3,14,17,11
            //dfs.addedgesINT(10, 11, 2);
            if ((source == 10 && destination == 11) || (source == 11 && destination == 10))
            {
                return s=2;
            }

            //isib 11->10,12
            //dfs.addedgesINT(11, 12, 4);
            if ((source == 11 && destination == 12) || (source == 12 && destination == 11))
            {
                return s=4;
            }
            //saint josse est deja donc fait 12->13,11


            return s;

        }


        public int q;


        public int ChangementTrajet(int source, int destination)
        {
            //**** temps pour changer de moyen de transport  ******

            //-source---destination---timetrajet
            //GDM 0->3,1,2,18,4,32,5
            /* dfs.addedgesTimesTrajet(0, 3, 4);
             d dfs.addTimes(0, 4,4);
            dfs.addTimes(0, 0, 0);
            dfs.addTimes(0, 2, 0);
            dfs.addTimes(0, 4, 4);
            dfs.addTimes(0, 4, 0);
            dfs.addTimes(0, 4, 0);
            dfs.addTimes(0, 0, 0);
            */

            //on prend le train 
            if ((source == 0 && destination == 3) || (source == 3 && destination == 0))
            {
                return q = 4;
            }
            //metro
            if ((source == 0 && destination == 1) || (source == 1 && destination == 0))
            {
                return q = 0;
            }
            //tram
            if ((source == 0 && destination == 2))
            {
                return q = 2;
            } else if ((source == 2 && destination == 0)) { return q = 0; }



            if ((source == 0 && destination == 18) || (source == 18 && destination == 0))
            {
                return q = 4;
            }
            if ((source == 0 && destination == 4))
            {
                return q = 4;
            } else if ((source == 4 && destination == 0))
            {
                return q = 0;
            }

            if ((source == 0 && destination == 32))
            {
                return q = 4;
            }
            else if ((source == 32 && destination == 0))
            {
                return q = 0;
            }

            if ((source == 0 && destination == 5) || (source == 5 && destination == 0))
            {
                return q = 0;
            }



            //ottignies 4-> 0,6,32
            // dfs.addTimes(4, 0, 0);
            // dfs.addTimes(4, 1, 1);

            if ((source == 4 && destination == 6) || (source == 6 && destination == 4))
            {
                return q = 0;
            }
            if ((source == 4 && destination == 32) || (source == 32 && destination == 4))
            {
                return q = 1;
            }



            //charleroi 6->4,7
            //  dfs.addTimes(6, 0, 0);
            if ((source == 6 && destination == 7) || (source == 7 && destination == 6))
            {
                return q = 0;
            }

            //chatelet  7->6,8,16
            //   dfs.addTimes(7, 0, 0);
            //  dfs.addTimes(7, 0, 0);

            if ((source == 7 && destination == 8) || (source == 8 && destination == 7))
            {
                return q = 0;
            }
            if ((source == 7 && destination == 16) || (source == 16 && destination == 7))
            {
                return q = 0;
            }

            //chalineau 8-> 7,9
            //  dfs.addTimes(8, 0, 0);

            if ((source == 8 && destination == 9) || (source == 9 && destination == 8))
            {
                return q = 8;
            }
            //Namur 9->8,3,32,18
            /*
           
            //dfs.addTimes(9, 0, 4);
           // dfs.addTimes(9, 2, 2);
          //  dfs.addTimes(9, 2, 2);
           */
            if ((source == 9 && destination == 3) )
            {
                return q = 0;
            } else if ((source == 3 && destination == 9)) {
                return q = 4;
            }
            if ((source == 9 && destination == 32) || (source == 32 && destination == 9))
            {
                return q = 2;
            }
            if ((source == 9 && destination == 18) || (source == 18 && destination == 9))
            {
                return q = 2;
            }

            //GC 3->0,9,10,18,22,21,20,
            /*    dfs.addTimes(3, 0, 0);
            dfs.addTimes(3, 4, 4);
            dfs.addTimes(3, 0, 0);
            dfs.addTimes(3, 3, 3);
            dfs.addTimes(3, 3, 3);
            dfs.addTimes(3, 4, 2);
              */
            if ((source == 3 && destination == 10) || (source == 10 && destination == 3))
            {
                return q = 0;
            }
            if ((source == 3 && destination == 18) || (source == 18 && destination == 3))
            {
                return q = 4;
            }
            if ((source == 3 && destination == 22) || (source == 22 && destination == 3))
            {
                return q = 1;
            }
            if ((source == 3 && destination == 13) || (source == 13 && destination == 3))
            {
                return q = 3;
            }
            if ((source == 3 && destination == 21) )
            {
                return q = 3;
            }else if((source == 21 && destination == 3))
            {
                return q = 0;
            }
            if ((source == 3 && destination == 20) || (source == 20 && destination == 3))
            {
                return q = 2;
            }

            //debrouckere 22->3,14,13,21,23,24
            /*  dfs.addTimes(22, 3, 3);
            dfs.addTimes(22, 2, 0);
            dfs.addTimes(22, 3, 0);
            dfs.addTimes(22, 2, 0);
            dfs.addTimes(22, 2, 0);

             */
            if ((source == 22 && destination == 13) )
            {
                return q = 2;
            }
            else if ((source == 13 && destination == 22))
            {
                return q = 0;
            }
            if ((source == 22 && destination == 14) || (source == 14 && destination == 22))
            {
                return q = 3;
            }
            if ((source == 22 && destination == 21) )
            {
                return q = 3;
            }else if((source == 21 && destination == 22))
            {
                return q = 0;
            }
            if ((source == 22 && destination == 23) )
            {
                return q = 2;
            }else if ((source == 23 && destination == 22)){
                return q = 0;
            }


            if ((source == 22 && destination == 24) )
            {
                return q = 2;
            }else if ((source == 24 && destination == 22))
            {
                return q = 0;
            }


            //arenberg est deja fait21->3,22,31,24 
            //  dfs.addTimes(21, 0, 3);
            if ((source == 21 && destination == 31) )
            {
                return q = 0;
            } else if ((source == 31 && destination == 21)) {
                return q = 3;
            }
            //saint catherine 24->22,18,29,23
            /*    dfs.addTimes(24, 3, 3);
            dfs.addTimes(24, 0, 0);
            dfs.addTimes(24, 3, 3);
            */
            if ((source == 24 && destination == 18) || (source == 18 && destination == 24))
            {
                return q = 3;
            }
            if ((source == 24 && destination == 29) || (source == 29 && destination == 24))
            {
                return q = 0;
            }
            if ((source == 24 && destination == 23) || (source == 23 && destination == 24))
            {
                return q = 3;
            }


            //bourse 23->22,24,25
            //    dfs.addTimes(23, 0, 0);
            if ((source == 23 && destination == 25) || (source == 25 && destination == 23))
            {
                return q = 0;
            }
            //Annessens 25-> 23,28,2,31
            /* 
            dfs.addTimes(25, 3, 3);
            dfs.addTimes(25, 2, 0);
            dfs.addTimes(25, 3, 3);
              */

            if ((source == 25 && destination == 28) || (source == 28 && destination == 25))
            {
                return q = 3;
            }
            if ((source == 25 && destination == 2) )
            {
                return q = 2;
            }else if ((source == 2 && destination == 25))
            {

                return q = 0;
            }
            if ((source == 25 && destination == 31) || (source == 31 && destination == 25))
            {
                return q = 3;
            }

            //lemmonier 2-> 0,25,30
            //  dfs.addTimes(2, 2, 2);
            if ((source == 2 && destination == 30) || (source == 30 && destination == 2))
            {
                return q = 2;
            }
            //porte d'anderlecht 30->21,2,31
            // dfs.addTimes(30, 0, 0);
            if ((source == 30 && destination == 31) || (source == 31 && destination == 30))
            {
                return q = 0;
            }
            //arts et metiers est deja donc fait 31->21,25,30

            //clemenceau 28->25,1,27
            //         dfs.addTimes(28, 0, 0);
           // dfs.addTimes(28, 1, 1);

            if ((source == 28 && destination == 1) || (source == 1 && destination == 28))
            {
                return q = 0;
            }
            if ((source == 28 && destination == 27) || (source == 27 && destination == 28))
            {
                return q = 1;
            }

            //delacroix 1->0,28,27
            //   dfs.addTimes(1, 1, 1);

            if ((source == 1 && destination == 27) || (source == 27 && destination == 1))
            {
                return q = 1;
            }
            //GDO 27->28,1,26,29

            //d   dfs.addTimes(27, 1, 0);
            //dfs.addTimes(27, 0, 0);

            if ((source == 27 && destination == 26) )
            {
                return q = 1;
            }else if((source == 26 && destination == 27))
            {
                return q = 0;

            }
            if ((source == 27 && destination == 29) || (source == 29 && destination == 27))
            {
                return q = 0;
            }

            //beekant 26->26,29
            //d   dfs.addTimes(26, 1, 0);
            if ((source == 26 && destination == 29) )
            {
                return q = 1;
            }else if((source == 29 && destination == 26))
            {
                return q = 0;
            }
            //etangs noir est deja donc fait 29->24,27

            //louvain 32-> 0,4,9,20
            //  dfs.addTimes(32, 1, 1);
            if ((source == 32 && destination == 20) || (source == 20 && destination == 32))
            {
                return q = 1;
            }

            //machelen 20->3,32,19
            //dfs.addedgesINT(20, 19, 9);
            if ((source == 20 && destination == 19) || (source == 19 && destination == 20))
            {
                return q = 0;
            }

            //haren 19->20,18,15
            //         dfs.addTimes(19, 0, 4);
           // dfs.addTimes(19, 3, 3);

            if ((source == 19 && destination == 18) || (source == 18 && destination == 19))
            {
                return q = 0;
            }else if ((source == 18 && destination == 19))
            {
                return q = 4;
            }
            if ((source == 19 && destination == 15) || (source == 15 && destination == 19))
            {
                return q = 3;
            }
            //gdn 18->0,9,3,24,19,13
            //  dfs.addTimes(18, 2, 2);
          //  dfs.addTimes(18, 3, 0);

            if ((source == 18 && destination == 13) || (source == 13 && destination == 18))
            {
                return q = 2;
            }
            if ((source == 18 && destination == 16) )
            {
                return q = 3;
            }else if((source == 16 && destination == 18))
            {
                return q = 0;

            }

            //rogier 13-> 3,22,18,12,14,15
            //  dfs.addTimes(13, 3, 0);
            //dfs.addTimes(13, 1, 0);
            //dfs.addTimes(13, 3, 3);

            if ((source == 13 && destination == 12) )
            {
                return q = 3;
            }else if ((source == 12 && destination == 13))
            {

                return q = 0;
            }
            if ((source == 13 && destination == 14) )
            {
                return q = 1;
            }else if((source == 14 && destination == 13))
            {
                return q = 0;
            }
            if ((source == 13 && destination == 15) || (source == 15 && destination == 13))
            {
                return q = 3;
            }

            //botanique 14->22,13,15,10
            //  
           /* dfs.addTimes(14, 0, 0);
            dfs.addTimes(14, 2, 2);
           */
            if ((source == 14 && destination == 15) || (source == 15 && destination == 14))
            {
                return q = 0;
            }
            if ((source == 14 && destination == 10) || (source == 10 && destination == 14))
            {
                return q = 2;
            }

            //madou 15->19,13,14,16 
            // ddfs.addTimes(15, 3, 3);

            if ((source == 15 && destination == 16) || (source == 16 && destination == 15))
            {
                return q = 3;
            }
            //presse 16->7,18,15,17
            // 
          //  dfs.addTimes(16, 2, 0);

            if ((source == 16 && destination == 17) )
            {
                return q = 2;
            }else if((source == 17 && destination == 16))
            {
                return q = 0;
            }
            //treurenberg 17 ->16,10
            //dfs.addedgesINT(17, 10, 4);

            if ((source == 17 && destination == 10) )
            {
                return q = 0;
            }else if ((source == 10 && destination == 17))
            {
                return q = 2;
            }

            //park 10->3,14,17,11
            //dfs.addedgesINT(10, 11, 2);
            if ((source == 10 && destination == 11) )
            {
                return q = 2;
            }
            else if((source == 11 && destination == 10))
            {
                return q = 0;
            }
            //isib 11->10,12
            //dfs.addedgesINT(11, 12, 4);
            if ((source == 11 && destination == 12) )
            {
                return q = 0;
            }else if((source == 12 && destination == 11))
            {
                return q = 2;
            }
            //saint josse est deja donc fait 12->13,11


            return q;

        }



    }
}
