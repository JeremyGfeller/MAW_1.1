using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde
{
    /// <summary>
    /// \author J. Alexandre
    /// \version 1.2
    /// \date Janvier 2016
    /// La reine est capable de pondre des oeufs, se déplacer dans l'intérieur de la fourmilière ou même poser une phéromone afin de construire une case de fourmilière, elle est dirigée par l'utilisateur a l'aide du formulaire.
    /// </summary>
    public class CReine : CCréature
    {
        FormMenu TheForm = new FormMenu();
        bool PremierCycle = true;   // Bool permetant d'éviter de faire la meme action plusieurs fois

        // Permet de dire quand est-ce qu'on peut poser une fermière (passe a true quand le boutton dans furmulaire est utilisé)
        public bool PonteFermiere = false;
        public bool PonteScout = false;
        public bool PonteOuvriere = false;
        public bool PonteSoldat = false;
        public int DirectionMoveReine = 0; // Permet de choisir la direction du déplacement de la reine
        public int DirectionPheroReine = 0; // Permet de choisir la direction de la pose de la phéromone

        public CReine(int x, int y)
            : base(x, y)
        {
            NiveauDeVie = CJardin.LoiDeLaNature("MaxPointsVieFourmi");
            MaxPointsDeVie = CJardin.LoiDeLaNature("MaxPointsVieFourmi"); // ****** XCL: ajouté, sinon la reine ne mange pas
        }

        /// <summary>
        /// Méthode qui fait "vivre" la reine un instant (un battement de coeur si on veut)
        /// </summary>
        /// <param name="LeJardin">Référence à l'objet jardin dans lequel la Reine se trouve</param>
        public void CycleDeVie(CJardin LeJardin)
        {
            LeJardin.Déjeuner(this); // Faut bien manger un peu
            LeJardin.LogMessage(string.Format("Sa Majesté a {0} points de vie", NiveauDeVie));// ****** XCL: ajouté pour vérification
            Premiercycle();
            PonteFourmi(LeJardin);
            PheroReine(LeJardin);
            DéplacerReine(LeJardin);
        }

        /// <summary>
        /// Méthode permetant de faire apparaitre le formulaire qu'une seule fois dès le début de la partie.
        /// </summary>
        public void Premiercycle()
        {
            if (PremierCycle)   // Evite de répeter une action, affiche le menu, met en relation avec le forumlaire puis le bool repasse a faux
            {
                TheForm.Show();
                TheForm.LaReine = this;
                PremierCycle = false;
            }
        }

        /// <summary>
        /// Méthode permetant de posé nimporte quelle type d'oeuf afin de rajouter des fourmis dans la fourmillière.
        /// </summary>
        /// <param name="LeJardin">Où pondre la larve.</param>
        public void PonteFourmi(CJardin LeJardin)
        {
            if (PonteFermiere) // Quand le bool passe a "vrai" un oeuf est posé et le bool repasse à faux
            {
                PonteFermiere = false;
                LeJardin.Pondre(CJardin.Elément.LarveFermière);
            }

            if (PonteScout) // Quand le bool passe a "vrai" un oeuf est posé et le bool repasse à faux
            {
                PonteScout = false;
                LeJardin.Pondre(CJardin.Elément.LarveScout);
            }

            if (PonteOuvriere) // Quand le bool passe a "vrai" un oeuf est posé et le bool repasse à faux
            {
                PonteOuvriere = false;
                LeJardin.Pondre(CJardin.Elément.LarveOuvrière);
            }

            if (PonteSoldat) // Quand le bool passe a "vrai" un oeuf est posé et le bool repasse à faux
            {
                PonteSoldat = false;
                LeJardin.Pondre(CJardin.Elément.LarveSoldat);
            }
        }

        /// <summary>
        /// Méthode permetant de pondre une phéromone qui servira a l'ouvrière d'étendre la fourmilière.
        /// </summary>
        /// <param name="LeJardin">Où pondre la phéromone.</param>
        public void PheroReine(CJardin LeJardin)
        {
            switch (DirectionPheroReine)
            {
                case 1:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.Nord, CJardin.Elément.PhéroOuvrière);
                    break;
                case 2:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.NordOuest, CJardin.Elément.PhéroOuvrière);
                    break;
                case 3:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.Ouest, CJardin.Elément.PhéroOuvrière);
                    break;
                case 4:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.SudOuest, CJardin.Elément.PhéroOuvrière);
                    break;
                case 5:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.Sud, CJardin.Elément.PhéroOuvrière);
                    break;
                case 6:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.SudEst, CJardin.Elément.PhéroOuvrière);
                    break;
                case 7:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.Est, CJardin.Elément.PhéroOuvrière);
                    break;
                case 8:
                    DirectionPheroReine = 0;
                    LeJardin.PoserPhéromone(this, CJardin.Direction.NordEst, CJardin.Elément.PhéroOuvrière);
                    break;
            }
        }
        

        /// <summary>
        /// Méthode permetant de déplacer la reine.
        /// </summary>
        /// <param name="LeJardin">Où la reine se déplace.</param>
        public void DéplacerReine(CJardin LeJardin)
        {
            switch(DirectionMoveReine)
            { 
                case 0:
                    DirectionMouvement = CJardin.Direction.Aucune;
                    break;
                case 1:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.Nord;
                    break;
                case 2:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.NordOuest;
                    break;
                case 3:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.Ouest;
                    break;
                case 4:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.SudOuest;
                    break;
                case 5:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.Sud;
                    break;
                case 6:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.SudEst;
                    break;
                case 7:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.Est;
                    break;
                case 8:
                    DirectionMoveReine = 0;
                    DirectionMouvement = CJardin.Direction.NordEst;
                    break;
            }
            LeJardin.BougerCréature(this);
        }  
    }
}
