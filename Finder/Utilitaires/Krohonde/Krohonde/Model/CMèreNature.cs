using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Krohonde.Model; 


namespace Krohonde
{
    /// <summary>
    /// Classe qui gère la Mère-Nature.
    /// \author Kevin Gilgen
    /// \version V1.4
    /// \date 22.01.16
    /// </summary>
    public class CMèreNature
    {
        /// <summary>
        /// Compteur des Ressources. Utilise comme base la loi de la nature correspondante. 
        /// </summary>
        private short MatCycle = 0; 
        /// <summary>
        /// Compteur des Phéromones. Utilise comme base la loi de la nature correspondante. 
        /// </summary>
        private short PheCycle = 0;
        /// <summary>
        /// Gère la boucle While dans l'algorimthe de pose des Phéromones. 
        /// </summary>
        private short PheNum = 0; 
        /// <summary>
        /// Gère la boucle While dans l'algorimthe de pousse des Ressources. 
        /// </summary>
        private bool MatOK;
        /// <summary>
        /// Gère la boucle While dans l'algorimthe de pose des Fourmis. 
        /// </summary>
        private bool PheroOK;
		/// <summary>
        /// Stock la nature de la case dans la direction nord.
        /// </summary>
		private string CheckTypeNorth;
		/// <summary>
        /// Stock la nature de la case dans la direction sud. 
        /// </summary>
		private string CheckTypeSouth;
		/// <summary>
        /// Stock la nature de la case dans la direction est.
        /// </summary>
		private string CheckTypeEast;
		/// <summary>
        /// Stock la nature de la case dans la direction ouest.
        /// </summary>		
		private string CheckTypeWest; 
        /// <summary>
        /// Gère l'entête des messages de Mère-Nature dans le log.
        /// </summary>
        private const string Header = "Mère-Nature : ";
        /// <summary>
        /// Méthode principale qui donne l'impulsion aux sous-méthodes. 
        /// </summary>
        /// <param name="LeJardin"></param>
        public void CycleDeVie(CJardin LeJardin)
        {
            CycleFourmis(LeJardin);
            CyclePheromone(LeJardin);
            CycleRessource(LeJardin); 
        }
        /// <summary>
        /// Méthode qui gère la durée de vie des Fourmis.
        /// </summary>
        /// <param name="LeJardin"></param>
        private void CycleFourmis(CJardin LeJardin)
        {   
            for (int i = LeJardin.LesSoldats.Count() - 1; i >= 0; i--)
            {
                if (LeJardin.LesSoldats[i].NiveauDeVie >= 1)
                {
                    LeJardin.LesSoldats[i].NiveauDeVie--;
                }
                else
                {
                    LeJardin.DétruireElément(this, LeJardin.LesSoldats[i].X, LeJardin.LesSoldats[i].Y);
                }
            }

            for (int i = LeJardin.LesScouts.Count() - 1; i >= 0; i--)
            {
                if (LeJardin.LesScouts[i].NiveauDeVie >= 1)
                {
                    LeJardin.LesScouts[i].NiveauDeVie--;
                }
                else
                {
                    LeJardin.DétruireElément(this, LeJardin.LesScouts[i].X, LeJardin.LesScouts[i].Y);
                }
            }
 
            for (int i = LeJardin.LesOuvrières.Count() - 1; i >= 0; i--)
            {
                if (LeJardin.LesOuvrières[i].NiveauDeVie >= 1)
                {
                    LeJardin.LesOuvrières[i].NiveauDeVie--;
                }
                else
                {
                    LeJardin.DétruireElément(this, LeJardin.LesOuvrières[i].X, LeJardin.LesOuvrières[i].Y);; 
                }
            }

            for (int i = LeJardin.LesFermières.Count() - 1; i >= 0; i--)
            {
                if (LeJardin.LesFermières[i].NiveauDeVie >= 1)
                {
                    LeJardin.LesFermières[i].NiveauDeVie--;
                }
                else
                {
                    LeJardin.DétruireElément(this, LeJardin.LesFermières[i].X, LeJardin.LesFermières[i].Y);
                }
            }

            if (LeJardin.Aragog.NiveauDeVie >= 1)
            {
                LeJardin.Aragog.NiveauDeVie--;
            }
            else
            {
                LeJardin.DétruireElément(this, LeJardin.Aragog.X, LeJardin.Aragog.Y);
            }

            if(LeJardin.LaReine.NiveauDeVie >= 1)
            {
                LeJardin.LaReine.NiveauDeVie--;
            }
        }

        /// <summary>
        /// Méthode qui gère la durée de vie des Phéromones et l'éclosion des Larves.
        /// </summary>
        /// <param name="LeJardin"></param>
        private void CyclePheromone(CJardin LeJardin)
        {
           if(PheCycle == CJardin.LoiDeLaNature("DuréePhéromone"))
           {
               for (int i = LeJardin.LesLarves.Count() - 1; i >= 0; i--)
               {
                   if (LeJardin.LesLarves[i].Niveau < 8)
                   { 
                       LeJardin.LesLarves[i].Niveau++;
                       LeJardin.MettreAJourRessource(LeJardin.LesLarves[i].X, LeJardin.LesLarves[i].Y);
                   }
                   else
                   {
                       PheroOK = false; 

                       while(PheroOK == false)
                       {
						   CheckTypeNorth = LeJardin.Regarder(this, LeJardin.LaReine.X, LeJardin.LaReine.Y - PheNum).ToString();

                           if (CheckTypeNorth == "Herbe")
                           {
                               switch (LeJardin.LesLarves[i].TypeRessource.ToString())
                               {
                                   case "LarveSoldat": LeJardin.LesSoldats.Add(new CSoldat(LeJardin.LaReine.X, LeJardin.LaReine.Y - PheNum)); LeJardin.Poser(LeJardin.LesSoldats[LeJardin.LesSoldats.Count() - 1]); break;
                                   case "LarveScout": LeJardin.LesScouts.Add(new CScout(LeJardin.LaReine.X, LeJardin.LaReine.Y - PheNum)); LeJardin.Poser(LeJardin.LesScouts[LeJardin.LesScouts.Count() - 1]); break;
                                   case "LarveOuvrière": LeJardin.LesOuvrières.Add(new COuvrière(LeJardin.LaReine.X, LeJardin.LaReine.Y - PheNum)); LeJardin.Poser(LeJardin.LesOuvrières[LeJardin.LesOuvrières.Count() - 1]); break;
                                   case "LarveFermière": LeJardin.LesFermières.Add(new CFermière(LeJardin.LaReine.X, LeJardin.LaReine.Y - PheNum)); LeJardin.Poser(LeJardin.LesFermières[LeJardin.LesFermières.Count() - 1]); break;
                               }
                               PheroOK = true; 
                           }
                           PheNum++; 
                       }
                       LeJardin.Eclosion(LeJardin.LesLarves[i]);
                       PheNum = 0; 
                   }
               }

               for (int i = LeJardin.LesPhéromones.Count() - 1; i >= 0; i--)
               {
                   if (LeJardin.LesPhéromones[i].Niveau > 1)
                   {
                       LeJardin.LesPhéromones[i].Niveau--;
                       LeJardin.MettreAJourRessource(LeJardin.LesPhéromones[i].X, LeJardin.LesPhéromones[i].Y);
                   }
                   else
                   {
                       LeJardin.DétruireElément(this, LeJardin.LesPhéromones[i].X, LeJardin.LesPhéromones[i].Y); 
                   }
               }
               PheCycle = 0;
           }
           else
           {
               PheCycle++; 
           }
        }

        /// <summary>
        /// Méthode qui gère la pousse des Ressources et de la Nourriture.
        /// </summary>
        /// <param name="LeJardin"></param>
        private void CycleRessource(CJardin LeJardin)
        {
            if (MatCycle == CJardin.LoiDeLaNature("RythmeDeCroissance"))
            {
                LeJardin.LogMessage(Header + "Il y a " + LeJardin.LesMatériaux.Count.ToString() + " unité/s de matériel en jeu.");

                for (int i = LeJardin.LesMatériaux.Count() - 1; i >= 0; i--)
                {
                    LeJardin.LesMatériaux[i].Niveau++;
                    
                    if (LeJardin.LesMatériaux[i].Niveau <= 8)
                    {
                        LeJardin.MettreAJourRessource(LeJardin.LesMatériaux[i].X, LeJardin.LesMatériaux[i].Y);
                    }
                    else if (LeJardin.LesMatériaux[i].Niveau >= 8 || LeJardin.LesMatériaux[i].Niveau == 16)
                    {
                        CheckTypeNorth = LeJardin.Regarder(this, LeJardin.LesMatériaux[i].X, LeJardin.LesMatériaux[i].Y - 1).ToString();
                        CheckTypeSouth = LeJardin.Regarder(this, LeJardin.LesMatériaux[i].X, LeJardin.LesMatériaux[i].Y + 1).ToString();
                        CheckTypeWest = LeJardin.Regarder(this, LeJardin.LesMatériaux[i].X - 1, LeJardin.LesMatériaux[i].Y).ToString();
                        CheckTypeEast = LeJardin.Regarder(this, LeJardin.LesMatériaux[i].X + 1, LeJardin.LesMatériaux[i].Y).ToString();

                        if (CheckTypeNorth == "Herbe" || CheckTypeSouth == "Herbe" || CheckTypeWest == "Herbe" || CheckTypeEast == "Herbe")
                        {
                            while (MatOK == true && LeJardin.LesMatériaux.Count < 50) 
                            {
                                int rnd_number = new Random().Next(0, 4);

                                if (CheckTypeNorth == "Herbe" && rnd_number == 0)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LesMatériaux[i].X, LeJardin.LesMatériaux[i].Y - 1, CJardin.Elément.Matériau));
                                    MatOK = false; 
                                }

                                if (CheckTypeSouth == "Herbe" && rnd_number == 1)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LesMatériaux[i].X, LeJardin.LesMatériaux[i].Y + 1, CJardin.Elément.Matériau));
                                    MatOK = false;
                                }

                                if (CheckTypeWest == "Herbe" && rnd_number == 2)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LesMatériaux[i].X - 1, LeJardin.LesMatériaux[i].Y, CJardin.Elément.Matériau));
                                    MatOK = false;
                                }

                                if (CheckTypeEast == "Herbe" && rnd_number == 3)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LesMatériaux[i].X + 1, LeJardin.LesMatériaux[i].Y, CJardin.Elément.Matériau));
                                    MatOK = false;
                                }
                            }
                        }
                        MatOK = true; 
                    }
                    
                    if(LeJardin.LesMatériaux[i].Niveau >= 16)
                    {
                        LeJardin.DétruireElément(this, LeJardin.LesMatériaux[i].X, LeJardin.LesMatériaux[i].Y);
                        LeJardin.LesMatériaux.RemoveAt(i);
                    }
                }

                LeJardin.LogMessage(Header + "Il y a " + LeJardin.LaNourriture.Count.ToString() + " unité/s de nourriture en jeu.");

                for (int i = LeJardin.LaNourriture.Count() - 1; i >= 0; i--)
                {
                    LeJardin.LaNourriture[i].Niveau++;

                    if (LeJardin.LaNourriture[i].Niveau <= 8)
                    {
                        LeJardin.MettreAJourRessource(LeJardin.LaNourriture[i].X, LeJardin.LaNourriture[i].Y);
                    }
                    else if (LeJardin.LaNourriture[i].Niveau >= 8 || LeJardin.LaNourriture[i].Niveau == 16)
                    {
                        CheckTypeNorth = LeJardin.Regarder(this, LeJardin.LaNourriture[i].X, LeJardin.LaNourriture[i].Y - 1).ToString();
                        CheckTypeSouth = LeJardin.Regarder(this, LeJardin.LaNourriture[i].X, LeJardin.LaNourriture[i].Y + 1).ToString();
                        CheckTypeWest = LeJardin.Regarder(this, LeJardin.LaNourriture[i].X - 1, LeJardin.LaNourriture[i].Y).ToString();
                        CheckTypeEast = LeJardin.Regarder(this, LeJardin.LaNourriture[i].X + 1, LeJardin.LaNourriture[i].Y).ToString();

                        if (CheckTypeNorth == "Herbe" || CheckTypeSouth == "Herbe" || CheckTypeWest == "Herbe" || CheckTypeEast == "Herbe")
                        {
                            while (MatOK == true && LeJardin.LaNourriture.Count < 50)
                            {
                                int rnd_number = new Random().Next(0, 4);

                                if (CheckTypeNorth == "Herbe" && rnd_number == 0)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LaNourriture[i].X, LeJardin.LaNourriture[i].Y - 1, CJardin.Elément.Nourriture));
                                    MatOK = false; 
                                }

                                if (CheckTypeSouth == "Herbe" && rnd_number == 1)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LaNourriture[i].X, LeJardin.LaNourriture[i].Y + 1, CJardin.Elément.Nourriture));
                                    MatOK = false; 
                                }

                                if (CheckTypeWest == "Herbe" && rnd_number == 2)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LaNourriture[i].X - 1, LeJardin.LaNourriture[i].Y, CJardin.Elément.Nourriture));
                                    MatOK = false; 
                                }

                                if (CheckTypeEast == "Herbe" && rnd_number == 3)
                                {
                                    LeJardin.Poser(new CRessource(LeJardin.LaNourriture[i].X + 1, LeJardin.LaNourriture[i].Y, CJardin.Elément.Nourriture));
                                    MatOK = false;
                                }
                            }
                        }
                        MatOK = true;
                    }
                    
                    if (LeJardin.LaNourriture[i].Niveau >= 16)
                    {
                        LeJardin.DétruireElément(this, LeJardin.LaNourriture[i].X, LeJardin.LaNourriture[i].Y);
                        LeJardin.LaNourriture.RemoveAt(i); 
                    }
                }

                MatCycle = 0; 
            }
            else
            {
                MatCycle++; 
            }
        }
    }
}
