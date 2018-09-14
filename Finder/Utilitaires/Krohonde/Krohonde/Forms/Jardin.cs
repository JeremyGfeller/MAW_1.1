using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Krohonde.Model;

namespace Krohonde
{
    /// <summary>
    /// Classe représentant le jardin dans lequel les fourmis évoluent.
    /// Elle offre des méthodes publiques permettant au créatures d'interagir avec le jardin
    /// </summary>
    /// \author X. Carrel
    /// \version 3.3
    /// \date Janvier 2016
    /// \section Historique
    /// \subsection Version33 Version 3.3 (en cours)
    /// \li Nouvelle fonctionnalité: possibilité de filtrer les messages dans la fenêtre Log. Attention: il faut mettre à jour le formulaire Log en plus de Jardin.cs
    /// \li Modification: La reine mange comme toutes les autres fourmis. Mais cela ne lui est pas compté comme action
    /// 
    /// \subsection Version32 Version 3.2
    /// \li Incorporé un changement demandé par Tiffany Di-Domenico: l'image de l'araignée change en fonction de la direction de son déplacement
    /// <b>!!! Attention, cela requiert la présence des fichiers CAraignéeEst.bmp, CAraignéeOuest.bmp, CAraignéeNord.bmp et CAraignéeSud.bmp dans le dossier images !!!</b>
    /// \li Le jardin vérifie que chaque créature n'effectue qu'une seule action par cycle. Sont considérées comme actions: BougerCréature, Déjeuner, PicNiquer, Grignoter, RamasserRessource, PoserPhéromone, Construire, Frapper<b>!!! Attention, cela requiert une mise à jour de la classe CCréature</b>
    /// 
    /// \subsection Version31 Version 3.1
    /// \li Incorporé un changement proposé par Alec Berney: le choix d'un emplacement aléatoire dans la fourmilière pour pondre une larve
    /// \li Correction de bug: plantée de la méthode "RamasserRessource" quand l'ouvrière l'utilise
    /// \li Correction de bug: la Reine ne pouvait pas se déplacer dans la fourmilière
    /// \li Correction de bug: L'araignée n'était pas détectée par les méthodes Regarder
    /// 
    /// \subsection Version30 Version 3.0
    /// \li <b>!!! Refactorisation majeure qui dépasse le cadre de la classe CJardin !!!</b> La recherche de contrôles par nom pour les éléments visibles du jardin menaient parfois à une plantée.
    /// Pour y remédier, les contrôles ainsi que leurs coordonnées X.Y ont été déplacés dans la classe CChoseVisible, dont héritent CCréature, CRessource et CDécor (qui remplace CSol)
    /// <b>Conséquence: il faut supprimer la ligne d'initialisation de "NomContrôle" dans le constructeur des classes des fourmis</b>.
    /// 
    /// \subsection Version26 Version 2.6
    /// \li Correction de bug: Les soldats ne pouvaient pas se déplacer en diagonale
    /// 
    /// \subsection Version25 Version 2.5
    /// \li Modification: l'instance unique de l'araignée (Aragog) est rendue publique pour que Mère Nature puisse la faire vieillir
    /// \li Correction de bug: crash de la méthode MiseAJourRessource
    /// \li Modification: par défaut, le timer est arrêté, il faut cliquer le bouton pour démarrer
    /// 
    /// \subsection Version24 Version 2.4
    /// \li Correction de bug: Les phéromones Ouvrière et Soldat n'étaient pas posées correctement et restaient indétectables
    /// \li Modification: Les coordonnées du click de l'utilisateur sur le jardin sont remises à (-1,-1) à la fin de chaque cycle
    /// 
    /// \subsection Version23 Version 2.3
    /// \li Correction de bug: la méthode DétruireElément ne détruisait pas les soldats
    /// \li Amélioration: la méthode DétruireElément ne peut être appelée que par MèreNature
    /// 
    /// \subsection Version22 Version 2.2
    /// \li Correction de bug: les soldats étaient aveugles! Ils peuvent maintenant voir à 2 cases
    /// \li Correction de bug: le cycle de vie de l'araignée n'était pas appelé
    /// \li Ajout de fonctionnalité: le jardin permet de savoir si l'utilisateur a cliqué sur le jardin grâce à la méthode DernierClicSouris()
    /// \li Ajout de fonctionnalité: un bouton permet de mettre en pause/reprendre la vie du jardin
    /// \li Suppression de la méthode NiveauMatériau() qui est obsolète
    /// 
    /// \subsection Version21 Version 2.1
    /// \li Ajouté la méthode Grignoter qui permet à une fermière de manger la nourriture qui est dans son sac
    /// 
    /// \subsection Version20 Version 2.0
    /// Version basée sur la 1.4 de décembre 2011, qui était la dernière version générée par les FPA
    /// 
    /// Nouveautés:
    /// \li Il n'y a plus de dépôt: les matériaux seront stockés dans la fourmilière
    /// \li Il n'y a plus de phéromone fourmilière ou dépôt: les fourmis connaissent la position de la fourmilière
    /// \li Réintroduction des soldats et ouvriers
    /// \li Réintroduction du niveau de matériaux

    public partial class CJardin : Form
    {
        private const string KVersion = "3.1 - Projet C# 2ème année CFC 2015";

        // Enumérations publiques
        /// <summary>
        /// Directions dans lesquelles les fourmis peuvent se déplacer, sous forme de points cardinaux
        /// </summary>
        public enum Direction { Aucune, Nord, NordEst, Est, SudEst, Sud, SudOuest, Ouest, NordOuest }

        /// <summary>
        /// Les divers éléments qui peuvent se trouver dans le jardin: obstacle, nourriture, créatures
        /// </summary>
        public enum Elément
        {
            // Sol (0-3)
            Herbe, Rocher, Fourmilière, Dépôt,

            // Créatures (4-9)
            Araignée, Reine, Soldat, Fermière, Ouvrière, Scout, //Araignée et soldat RFU

            // Ressources (10-19)
            LarveFermière, LarveOuvrière, LarveScout, LarveSoldat,
            Nourriture,
            Matériau,
            PhéroSoldat, PhéroOuvrière, PhéroFermière, // Phéromones pour attirer les divers types de fourmis

            Inconnu
        }

        // Constantes publiques
        /// <summary>
        /// Nombre de colonnes du jardin
        /// </summary>
        const int JARDIN_TAILLE_X = 60;

        /// <summary>
        /// Nombre de lignes du jardin
        /// </summary>
        const int JARDIN_TAILLE_Y = 35;

        /// <summary>
        /// Dimension en pixel de la case (carrée) du jardin
        /// </summary>
        const int TAILLE_CASE = 16;

        // Attributs publics du jardin
        /// <summary>
        /// Instance unique de la Reine
        /// </summary>
        public CReine LaReine;
        /// <summary>
        ///  Instance unique de l'araignée
        /// </summary>
        public CAraignée Aragog = null;
        /// <summary>
        /// Liste des fourmis scouts vivantes du jardin
        /// </summary>
        public List<CScout> LesScouts = new List<CScout>();
        /// <summary>
        /// Liste des fourmis ouvrières vivantes du jardin
        /// </summary>
        public List<COuvrière> LesOuvrières = new List<COuvrière>();
        /// <summary>
        /// Liste des fourmis fermières vivantes du jardin
        /// </summary>
        public List<CFermière> LesFermières = new List<CFermière>();
        /// <summary>
        /// Liste des fourmis soldat vivantes du jardin
        /// </summary>
        public List<CSoldat> LesSoldats = new List<CSoldat>();
        /// <summary>
        /// Liste des phéromones de tout type qui sont actives dans le jardin
        /// </summary>
        public List<CRessource> LesPhéromones = new List<CRessource>();
        /// <summary>
        /// Liste des morceaux de nourriture du jardin
        /// </summary>
        public List<CRessource> LaNourriture = new List<CRessource>();
        /// <summary>
        /// Liste des morceaux de matériaux
        /// </summary>
        public List<CRessource> LesMatériaux = new List<CRessource>();
        /// <summary>
        /// Liste des larves qui sont dans la fourmilière
        /// </summary>
        public List<CRessource> LesLarves = new List<CRessource>();

        /// <summary>
        /// Numéro de séquence autoincrémenté utilisé pour différentier les contrôles de même nom ("Rocher12", "Rocher13")
        /// </summary>
        static public int IDContrôle = 0;

        // Lois de la Nature
        private const int ChampDeVisionScout = 3;       // La distance en nombre de cases jusqu’où un Scout peut voir
        private const int ChampDeVisionFermière = 1;    // La distance en nombre de cases jusqu’où une Fermière peut voir
        private const int ChampDeVisionOuvrière = 1;    // La distance en nombre de cases jusqu’où une Ouvrière peut voir
        private const int ChampDeVisionSoldat = 2;      // La distance en nombre de cases jusqu’où un soldat peut voir
        private const int DuréePhéromone = 15;          // Durée en nombre de cycles de vie d'un niveau de phéromone
        private const int EnergiePhéromone = 20;        // L’énergie (en nombre de points de vie) que coûte la pose d’une phéromone
        private const int MaxPointsVieFourmi = 500;     // Le nombre maximum de points de vie d’une fourmi à la naissance.
        private const int MaxPointsVieAraignée = 500;   // Le nombre maximum de points de vie de l'araignée.
        private const int DégâtsInfligés = 8;           // Donne le nombre de points de dégâts maximum qu’une fourmi peut infliger lors d’un combat. Cette valeur est exprimée en pourcentage de ses points de vie.
        private const int PointsDeFatigue = 1;          // Le nombre de points que chaque fourmi perd à chaque cycle de vie
        private const int SensibilitéOdorat = 8;        // Le rapport entre la distance max fourmi-phéromone (détectée) et le niveau de la phéromone.
        // une phéromone de niveau 5 peut être détectée par une fourmi qui est à une distance de 40 (=8*5), mais pas plus
        private const int CoutDePonte = 10;             // Le coût en nourriture de la ponte d'une larve
        private const int Récupération = 5;             // Nombre de points de nourriture consommées et donc de vie récupérés quand une fourmi mange
        private const int PtsVieParNiveau = 5;          // Nombre de points de vie que contient un niveau d'intensité de nourriture
        private const int TailleSac = 50;               // Quantité de nourriture/matériau que peut transporter une fermière/ouvrière
        private const int CoutDeConstruction = 10;      // Quantité de matériau nécessaire à la construction d'un élément de fourmilière
        private const int RisqueCatastrophe = 200;      // Risque en pour mille qu'une catastrophe naturelle ait lieu
        private const int RythmeDeCroissance = 30;      // Le nombre de cycles de vie entre deux "poussées" de la nourriture et des matériaux
        private const int DégâtsInfligésAraignée = 5;   // Pourcentage de la vie de l'opposant que prend l'araignée en combat
        private const int DégâtsInfligésSoldat = 5;     // Pourcentage de la vie de l'opposant que prend le soldat en combat

        // Variables privées
        private object[,] LeJardin = new object[JARDIN_TAILLE_X, JARDIN_TAILLE_Y];
        private CMèreNature LaMèreNature = new CMèreNature();
        private int RéserveNourriture;  // La quantité de nourriture en réserve dans la fourmilière
        private int RéserveMatériau;  // La quantité de matériau en réserve dans la fourmilière
        private int FourmilièreX;
        private int FourmilièreY;
        private Random Rand = new Random();
        private Log TheLog = new Log();
        private bool Vivant = false; // indique si aumoins une fourmi est née. Mis à jour par mère nature
        private Coord LastMouseClick = new Coord(-1, -1); // Stocke le dernier clic de souris en coordonnées Jardin
        private int NbCycles = 0; // comptage des cycles pour pouvoir limiter l'agilité de l'araignée

        //===============================================================================
        // Méthodes d'information à l'usage des autres classes (Mère Nature et les créatures)
        //===============================================================================

        /// <summary>
        /// Permet à chaque créature de connaître la position du centre de la fourmilière
        /// </summary>
        /// <returns>Des coordonnées (X,Y)</returns>
        public Coord PositionFourmilière()
        {
            return new Coord(FourmilièreX, FourmilièreY);
        }

        // ..............................................................................

        /// <summary>
        /// Retourne la quantité de nourriture présente dans la fourmilière
        /// </summary>
        /// <returns></returns>
        public int NiveauRéserveNourriture()
        {
            return RéserveNourriture;
        }

        // ..............................................................................

        /// <summary>
        /// Retourne la phéromone du type voulu qui est la plus proche de la fourmi
        /// </summary>
        /// <param name="Fourmi">La fourmi qui demande</param>
        /// <param name="TypeDemandé">Le type de phéromone recherché</param>
        /// <returns>Un objet Ressource du type de phéromone demandé ou null si aucune phéromone n'a pu être détectée</returns>
        public CRessource DétecterPhéromone(object Fourmi, Elément TypeDemandé)
        {
            int Distance = 0;
            int DistanceMin = JARDIN_TAILLE_X;

            CRessource Res = new CRessource(0, 0, Elément.Inconnu);

            CCréature LaFourmi = Fourmi as CCréature;
            foreach (CRessource Phéro in LesPhéromones)
            {
                if (Phéro.TypeRessource == TypeDemandé) // c'est une phéro du type voulu
                {
                    Distance = Math.Max(Math.Abs(LaFourmi.X - Phéro.X), Math.Abs(LaFourmi.Y - Phéro.Y));
                    if (Distance <= Phéro.Niveau * SensibilitéOdorat) // On peut sentir la phéro
                        if (Distance < DistanceMin) // elle est la plus proche
                        {
                            DistanceMin = Distance;
                            Res.X = Phéro.X;
                            Res.Y = Phéro.Y;
                            Res.TypeRessource = TypeDemandé;
                        }
                }
            }
            if (Res.TypeRessource == Elément.Inconnu)
                return null;
            else
                return Res;
        }

        // ..............................................................................

        /// <summary>
        /// Permet de connaître les valeurs des lois de la nature
        /// </summary>
        /// <param name="NomDeLoi">Nom de la loi demandée</param>
        /// <returns>Valeur de la loi ou -1 si le nom de loi est inconnu</returns>
        public static int LoiDeLaNature(string NomDeLoi)
        {
            switch (NomDeLoi)
            {
                case "ChampDeVisionScout": return ChampDeVisionScout;
                case "ChampDeVisionFermière": return ChampDeVisionFermière;
                case "ChampDeVisionOuvrière": return ChampDeVisionOuvrière;
                case "DuréePhéromone": return DuréePhéromone;
                case "EnergiePhéromone": return EnergiePhéromone;
                case "MaxPointsVieFourmi": return MaxPointsVieFourmi;
                case "MaxPointsVieAraignée": return MaxPointsVieAraignée;
                case "DégâtsInfligés": return DégâtsInfligés;
                case "PointsDeFatigue": return PointsDeFatigue;
                case "SensibilitéOdorat": return SensibilitéOdorat;
                case "CoutDePonte": return CoutDePonte;
                case "Récupération": return Récupération;
                case "PtsVieParNiveau": return PtsVieParNiveau;
                case "TailleSac": return TailleSac;
                case "CoutDeConstruction": return CoutDeConstruction;
                case "RisqueCatastrophe": return RisqueCatastrophe;
                case "RythmeDeCroissance": return RythmeDeCroissance;
            }
            return -1;
        }

        // ..............................................................................

        /// <summary>
        /// Permet à une créature d'inspecter le contenu d'une case précise du jardin. Cette méthode prend en compte les restrictions qui s'appliquent aux divers types de fourmi.
        /// Syntaxe à utiliser: Regarder (this, x, y)
        /// </summary>
        /// <param name="Bébête">La créature qui regarde</param>
        /// <param name="XCase">Position X de la case que la créature veut inspecter</param>
        /// <param name="YCase">Position Y de la case que la créature veut inspecter</param>
        /// <returns>Retourne l'élément du jardin qui se trouve dans la case de position (XCase, YCase). La valeur est "Inconnu" si la case demandée hors du champ de vision du type de fourmi</returns>
        public Elément Regarder(object Bébête, int XCase, int YCase)
        {
            int Distance = 0;

            if ((XCase < 0) || (XCase >= JARDIN_TAILLE_X) || (YCase < 0) || (YCase >= JARDIN_TAILLE_Y)) return Elément.Inconnu;

            // Déterminer le type de fourmi
            string TBébête = Bébête.GetType().ToString();
            TBébête = TBébête.Substring(TBébête.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace

            switch (TBébête)
            {
                case "CScout":
                    CScout Scout = Bébête as CScout;
                    Distance = Math.Max(Math.Abs(Scout.X - XCase), Math.Abs(Scout.Y - YCase));
                    if (Distance > ChampDeVisionScout) return Elément.Inconnu;
                    break;
                case "CFermière":
                    CFermière Fermière = Bébête as CFermière;
                    Distance = Math.Max(Math.Abs(Fermière.X - XCase), Math.Abs(Fermière.Y - YCase));
                    if (Distance > ChampDeVisionFermière) return Elément.Inconnu;
                    break;
                case "COuvrière":
                    COuvrière Ouvrière = Bébête as COuvrière;
                    Distance = Math.Max(Math.Abs(Ouvrière.X - XCase), Math.Abs(Ouvrière.Y - YCase));
                    if (Distance > ChampDeVisionOuvrière) return Elément.Inconnu;
                    break;
                case "CSoldat":
                    CSoldat Soldat = Bébête as CSoldat;
                    Distance = Math.Max(Math.Abs(Soldat.X - XCase), Math.Abs(Soldat.Y - YCase));
                    if (Distance > ChampDeVisionSoldat) return Elément.Inconnu;
                    break;
                case "CMèreNature":
                case "CReine":
                    break;
                default: return Elément.Inconnu;
            }
            // Si on arrive ici, c'est OK de retourner la valeur
            if (LeJardin[XCase, YCase] == null) return Elément.Herbe;

            // Déterminer le type de contenu de la case demandée
            string TCase = LeJardin[XCase, YCase].GetType().ToString();
            TCase = TCase.Substring(TCase.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace

            switch (TCase)
            {
                case "CRessource": return (LeJardin[XCase, YCase] as CRessource).TypeRessource;
                case "CDécor": return (LeJardin[XCase, YCase] as CDécor).TypeElément;
                case "CFermière": return Elément.Fermière;
                case "COuvrière": return Elément.Ouvrière;
                case "CScout": return Elément.Scout;
                case "CReine": return Elément.Reine;
                case "CAraignée": return Elément.Araignée;
            }
            return Elément.Inconnu;
        }

        // ..............................................................................

        /// <summary>
        /// Permet à une créature d'inspecter le contenu d'une case du jardin autour d'elle.
        /// Syntaxe à utiliser: Regarder (this, Direction.Nord)
        /// </summary>
        /// <param name="Bébête">La créature qui regarde</param>
        /// <param name="Dir">La direction dans laquelle elle regarde</param>
        /// <returns>L'élément du jardin qui se trouve dans la case</returns>
        public Elément Regarder(CCréature Bébête, Direction Dir)
        {
            // Déterminer le type de fourmi
            string TBébête = Bébête.GetType().ToString();
            TBébête = TBébête.Substring(TBébête.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace

            Coord CaseVisée = new Coord(0, 0); // La case à inspecter

            switch (Dir)
            {
                case Direction.Nord: CaseVisée.X = Bébête.X; CaseVisée.Y = Bébête.Y - 1; break;
                case Direction.NordEst: CaseVisée.X = Bébête.X + 1; CaseVisée.Y = Bébête.Y - 1; break;
                case Direction.Est: CaseVisée.X = Bébête.X + 1; CaseVisée.Y = Bébête.Y; break;
                case Direction.SudEst: CaseVisée.X = Bébête.X + 1; CaseVisée.Y = Bébête.Y + 1; break;
                case Direction.Sud: CaseVisée.X = Bébête.X; CaseVisée.Y = Bébête.Y + 1; break;
                case Direction.SudOuest: CaseVisée.X = Bébête.X - 1; CaseVisée.Y = Bébête.Y + 1; break;
                case Direction.Ouest: CaseVisée.X = Bébête.X - 1; CaseVisée.Y = Bébête.Y; break;
                case Direction.NordOuest: CaseVisée.X = Bébête.X - 1; CaseVisée.Y = Bébête.Y - 1; break;
                case Direction.Aucune: CaseVisée.X = Bébête.X; CaseVisée.Y = Bébête.Y; break;
            }
            // Si on arrive ici, c'est OK de retourner la valeur
            if (LeJardin[CaseVisée.X, CaseVisée.Y] == null) return Elément.Herbe;

            // Déterminer le type de contenu de la case demandée
            string TCase = LeJardin[CaseVisée.X, CaseVisée.Y].GetType().ToString();
            TCase = TCase.Substring(TCase.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace

            switch (TCase)
            {
                case "CRessource": return (LeJardin[CaseVisée.X, CaseVisée.Y] as CRessource).TypeRessource;
                case "CDécor": return (LeJardin[CaseVisée.X, CaseVisée.Y] as CDécor).TypeElément;
                case "CFermière": return Elément.Fermière;
                case "COuvrière": return Elément.Ouvrière;
                case "CScout": return Elément.Scout;
                case "CReine": return Elément.Reine;
                case "CAraignée": return Elément.Araignée;
            }
            return Elément.Inconnu;
        }

        // ..............................................................................

        /// <summary>
        /// Permet à une fourmi de savoir si elle se trouve à côté de la fourmilière.
        /// Syntaxe à utiliser: if (ContactFourmilière(this, Elément.Fourmilière)) ...
        /// </summary>
        /// <param name="Bébête">La fourmi qui s'interroge</param>
        /// <returns>true si la fourmi touche la fourmilière</returns>
        public bool ContactFourmilière(object Bébête)
        {
            CCréature F = Bébête as CCréature;
            if (F == null) return false;

            // Parcourir les cases environnantes
            for (int x = F.X - 1; x <= F.X + 1; x++)
                for (int y = F.Y - 1; y <= F.Y + 1; y++)
                    if (LeJardin[x, y] != null)
                    {
                        string TContenu = LeJardin[x, y].GetType().ToString();
                        TContenu = TContenu.Substring(TContenu.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace
                        if (TContenu == "CRessource") // Une larve fait partie de la fourmilière
                            if (((LeJardin[x, y] as CRessource).TypeRessource >= Elément.LarveFermière) && ((LeJardin[x, y] as CRessource).TypeRessource <= Elément.LarveSoldat))
                                return true;
                        if (TContenu == "CDécor")
                            if ((LeJardin[x, y] as CDécor).TypeElément == Elément.Fourmilière)
                                return true;
                    }
            return false;
        }

        // ..............................................................................

        /// <summary>
        /// Procédure qui permet d'enregistrer un message qui sera inscrit dans la fenêtre "Log"
        /// </summary>
        /// <param name="s">Le message à enregistrer</param>
        public void LogMessage(string s)
        {
            if (s.StartsWith(TheLog.filter)) TheLog.Logger(s);
        }

        //===============================================================================
        //  Méthodes permettant aux autres classes d'effectuer des actions sur le jardin
        //===============================================================================

        /// <summary>
        /// Dépose un élément dans le jardin
        /// Crée le contrôle correspondant (pour la représentation graphique). L'objet "Chose" peut être de classe CDécor, CCréature (fourmi, reine, araignée) ou CRessource (Phéromone, Nourriture, Matériau)
        /// </summary>
        /// <param name="Chose">L'objet à poser. Il est mis à jour dans l'opération</param>
        /// <returns>true si l'opération a été réussie</returns>
        public bool Poser(CChoseVisible Chose)
        {
            int X, Y; // Là où on veut poser l'élément

            // Déterminer le type d'objet
            string TypeObj = Chose.GetType().ToString();
            TypeObj = TypeObj.Substring(TypeObj.LastIndexOf('.') + 1); // La classe est préfixée par le namespace
            string NomFichierImage = TypeObj;
            switch (TypeObj)
            {
                case "CReine":
                    CReine reine = Chose as CReine;
                    X = reine.X; Y = reine.Y;
                    break;
                case "CAraignée":
                    CAraignée ara = Chose as CAraignée;
                    X = ara.X; Y = ara.Y;
                    break;
                case "CFermière":
                    CFermière fourmif = Chose as CFermière;
                    X = fourmif.X; Y = fourmif.Y;
                    NomFichierImage += "Nord";
                    LesFermières.Add(fourmif);
                    break;
                case "COuvrière":
                    COuvrière fourmio = Chose as COuvrière;
                    X = fourmio.X; Y = fourmio.Y;
                    NomFichierImage += "Nord";
                    LesOuvrières.Add(fourmio);
                    break;
                case "CScout":
                    CScout fourmisc = Chose as CScout;
                    X = fourmisc.X; Y = fourmisc.Y;
                    NomFichierImage += "Nord";
                    LesScouts.Add(fourmisc);
                    break;
                case "CSoldat":
                    CSoldat fourmiso = Chose as CSoldat;
                    X = fourmiso.X; Y = fourmiso.Y;
                    NomFichierImage += "Nord";
                    LesSoldats.Add(fourmiso);
                    break;
                case "CDécor":
                    CDécor cs = Chose as CDécor;
                    X = cs.X; Y = cs.Y;
                    NomFichierImage = cs.TypeElément.ToString();
                    break;
                case "CRessource":
                    CRessource Ress = Chose as CRessource;
                    X = Ress.X; Y = Ress.Y;
                    NomFichierImage = Ress.TypeRessource.ToString() + Ress.Niveau.ToString();
                    // Ajouter la ressource à la bonne liste
                    switch (Ress.TypeRessource)
                    {
                        case Elément.LarveFermière:
                        case Elément.LarveOuvrière:
                        case Elément.LarveScout:
                        case Elément.LarveSoldat:
                            LesLarves.Add(Ress);
                            break;
                        case Elément.Matériau:
                            LesMatériaux.Add(Ress);
                            break;
                        case Elément.Nourriture:
                            LaNourriture.Add(Ress);
                            break;
                        case Elément.PhéroFermière:
                        case Elément.PhéroOuvrière:
                        case Elément.PhéroSoldat:
                            LesPhéromones.Add(Ress);
                            break;
                    }
                    break;
                default: return false;
            }

            if (LeJardin[X, Y] != null) return false; // Il y a déjà quelquechose à cet endroit

            // Création du contrôle
            Chose.controle = new PictureBox();
            Chose.controle.SetBounds(X * TAILLE_CASE, Y * TAILLE_CASE, TAILLE_CASE, TAILLE_CASE);
            Chose.controle.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + NomFichierImage + ".bmp");
            Chose.controle.MouseClick += Jardin_MouseClick;
            Chose.controle.Name = TypeObj + IDContrôle++.ToString();
            this.Controls.Add(Chose.controle);
            Chose.controle.BringToFront();
            LeJardin[X, Y] = Chose;
            return true;
        }

        // ..............................................................................

        /// <summary>
        /// Détruit un élément du jardin. Graphiquement, la case redevient verte.
        /// Les éléments "destructibles" sont les fourmis, les ressources et la fourmilière
        /// Seule mère nature est autorisée à le faire
        /// </summary>
        /// <param name="x">La position X de la case à détruire</param>
        /// <param name="y">La position Y de la case à détruire</param>
        public void DétruireElément(object Bourreau, int x, int y)
        {
            if ((Bourreau != LaMèreNature) && (Bourreau != this))
            {
                LogMessage("Un petit malin essaye de casser des choses....");
                return;
            }
            if (LeJardin[x, y] == null) return;
            // Déterminer le type d'objet
            CChoseVisible it = LeJardin[x, y] as CChoseVisible;
            if (it == null) return; // erreur
            string TypeObj = it.GetType().ToString();
            TypeObj = TypeObj.Substring(TypeObj.LastIndexOf('.') + 1); // La classe est préfixée par le namespace

            switch (TypeObj)
            {
                case "CFermière":
                    LesFermières.Remove(LeJardin[x, y] as CFermière);
                    break;
                case "COuvrière":
                    LesOuvrières.Remove(LeJardin[x, y] as COuvrière);
                    break;
                case "CScout":
                    LesScouts.Remove(LeJardin[x, y] as CScout);
                    break;
                case "CSoldat":
                    LesSoldats.Remove(LeJardin[x, y] as CSoldat);
                    break;
                case "CRessource":
                    CRessource ress = it as CRessource;
                    switch (ress.TypeRessource)
                    {
                        case Elément.LarveFermière:
                        case Elément.LarveOuvrière:
                        case Elément.LarveScout:
                        case Elément.LarveSoldat:
                            LesLarves.Remove(ress);
                            break;
                        case Elément.Matériau:
                            LesMatériaux.Remove(ress);
                            break;
                        case Elément.Nourriture:
                            LaNourriture.Remove(ress);
                            break;
                        case Elément.PhéroFermière:
                        case Elément.PhéroOuvrière:
                        case Elément.PhéroSoldat:
                            LesPhéromones.Remove(ress);
                            break;
                    }
                    break;
                case "CDécor":
                    break;
                default: return;
            }
            // Détruire le contrôle
            it.controle.Dispose();
            // Libérer la place
            LeJardin[x, y] = null;
        }

        // ..............................................................................

        /// <summary>
        /// Fait éclore la larve passée, d'un point de vue graphique uniquement (l'objet reste dans la liste LesLarves)
        /// </summary>
        /// <param name="Larve">La larve en question</param>
        /// <returns>true en cas de succès. False si la ressource passée n'est pas une larve ou si la larve n'est pas prête à éclore (niveau < 8)</returns>
        public bool Eclosion(CRessource Larve)
        {
            if ((Larve.TypeRessource < Elément.LarveFermière) || (Larve.TypeRessource > Elément.LarveSoldat)) return false; // La ressource n'est pas une larve
            if (Larve.Niveau < 8) return false; // La larve n'est pas prête à éclore
            // Détruire la larve
            DétruireElément(this, Larve.X, Larve.Y);
            // Remettre de la fourmilière
            CDécor Décor = new CDécor(Larve.X, Larve.Y, Elément.Fourmilière);
            Poser(Décor);
            return true;
        }
        // ..............................................................................

        /// <summary>
        /// Bouge la créature passée (Reine, Araignée ou Fourmi) dans la direction qui est la sienne
        /// </summary>
        /// <param name="Bébête">La créature à déplacer</param>
        /// <returns>Retourne false si le mouvement était bloqué par un élément du jardin ou que le mouvement est interdit par une loi de la nature</returns>
        public bool BougerCréature(CCréature Bébête)
        {
            int DestX = 0, DestY = 0; // Destination visée
            if (Bébête.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (BougerCréature)", Bébête.controle.Name));
                return false;
            }
            Bébête.AJoué = true;

            // Déterminer le type de bête
            string TypeBête = Bébête.GetType().ToString();
            TypeBête = TypeBête.Substring(TypeBête.LastIndexOf('.') + 1); // La classe est préfixée par le namespace

            bool MvtDiagoOK = ((TypeBête == "CScout") || (TypeBête == "CSoldat") || (TypeBête == "CReine")); // Seules les Scouts, les Soldats et la Reine peuvent se déplacer en diagonale

            switch (Bébête.DirectionMouvement)
            {
                case Direction.Nord:
                    DestX = Bébête.X; DestY = Bébête.Y - 1; break;
                case Direction.NordEst:
                    if (MvtDiagoOK)
                    {
                        DestX = Bébête.X + 1;
                        DestY = Bébête.Y - 1;
                    }
                    else
                        return false;
                    break;
                case Direction.Est:
                    DestX = Bébête.X + 1; DestY = Bébête.Y; break;
                case Direction.SudEst:
                    if (MvtDiagoOK)
                    {
                        DestX = Bébête.X + 1;
                        DestY = Bébête.Y + 1;
                    }
                    else
                        return false;
                    break;
                case Direction.Sud:
                    DestX = Bébête.X; DestY = Bébête.Y + 1; break;
                case Direction.SudOuest:
                    if (MvtDiagoOK)
                    {
                        DestX = Bébête.X - 1;
                        DestY = Bébête.Y + 1;
                    }
                    else
                        return false;
                    break;
                case Direction.Ouest:
                    DestX = Bébête.X - 1; DestY = Bébête.Y; break;
                case Direction.NordOuest:
                    if (MvtDiagoOK)
                    {
                        DestX = Bébête.X - 1;
                        DestY = Bébête.Y - 1;
                    }
                    else
                        return false;
                    break;
                case Direction.Aucune:
                    DestX = Bébête.X; DestY = Bébête.Y; break;
            }

            CChoseVisible target = LeJardin[DestX, DestY] as CChoseVisible;
            if (TypeBête.Equals("CReine")) // la reine peut se déplacer dans la fourmilière
                if (Regarder(Bébête, DestX, DestY) == Elément.Fourmilière) // Déplacement OK
                    DétruireElément(this, DestX, DestY); // Faire la place
                else
                    return false; // Interdiction de sortir
            else
                if (target != null) // La destination est occupée
                    return false; // les autres créatures sont bloquées

            // Ajuster l'image en fonction de la direction
            string picname = TypeBête;
            switch (TypeBête)
            {
                case "CReine":
                    picname = TypeBête + ".bmp"; // La Reine n'a qu'une image
                    break;
                default: // c'est forcément une fourmi ou l'araignée
                    picname = TypeBête + Bébête.DirectionMouvement.ToString() + ".bmp";
                    break;
            }

            Bébête.controle.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + picname);
            Bébête.controle.SetBounds(DestX * TAILLE_CASE, DestY * TAILLE_CASE, TAILLE_CASE, TAILLE_CASE); // bouger le contrôle

            LeJardin[Bébête.X, Bébête.Y] = null; // Mise à jour du jardin
            LeJardin[DestX, DestY] = Bébête;
            if (TypeBête.Equals("CReine")) // Reconstruire la fourmilière derrière la reine
            {
                CDécor Décor = new CDécor(Bébête.X, Bébête.Y, Elément.Fourmilière);
                Poser(Décor);
            }
            Bébête.X = DestX; // Mise à jour de la bébête
            Bébête.Y = DestY;
            return true;
        }

        // ..............................................................................

        /// <summary>
        /// Prélève de la nourriture dans la fourmilière et la transforme en points de vie.
        /// </summary>
        /// <param name="Fourmi"></param>
        /// <returns>false si rien n'a pu être mangé, soit parce qu' il n'y a plus de réserve dans la fourmilière, soit parce que la fourmi ne touche pas la fourmilière</returns>
        public bool Déjeuner(object Fourmi)
        {
            CCréature F = Fourmi as CCréature;

            if (RéserveNourriture <= 0) return false; // Il n'y a rien à manger

            if (!ContactFourmilière(F)) return false; // La fourmi n'est pas au contact de la fourmilière

            if (F.NiveauDeVie >= F.MaxPointsDeVie) return false; // déjà repue

            if (F.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (Déjeuner)", F.controle.Name));
                return false;
            }

            int Bouchée = LoiDeLaNature("Récupération"); // Nombre de points de vie gagnés à chaque action "Déjeuner"

            // Déterminer le type de bête
            string TypeBête = Fourmi.GetType().ToString();
            TypeBête = TypeBête.Substring(TypeBête.LastIndexOf('.') + 1); // La classe est préfixée par le namespace
            if (!TypeBête.Equals("CReine")) // Pour la reine, l'action de manger ne compte pas. C'est la reine, quand même!
                F.AJoué = true;

            if (RéserveNourriture < Bouchée) // Manger tout ce qui reste
            {
                F.NiveauDeVie += RéserveNourriture;
                RéserveNourriture = 0;
            }
            else
            {
                if (Bouchée <= (F.MaxPointsDeVie - F.NiveauDeVie)) // Elle a de la place dans l'estomac pour une pleine bouchée
                {
                    F.NiveauDeVie += Bouchée;
                    RéserveNourriture -= Bouchée;
                }
                else // Bouchée partielle
                {
                    RéserveNourriture -= (F.MaxPointsDeVie - F.NiveauDeVie);
                    F.NiveauDeVie = F.MaxPointsDeVie;
                }
            }

            return true;
        }

        // ..............................................................................

        /// <summary>
        /// Prélève de la nourriture dans la nature.La nourriture est mangée et donc transformée en points de vie.
        /// </summary>
        /// <param name="Fourmi"></param>
        /// <returns>false si rien n'a pu être mangé parce qu'il n'y a pas de  nourriture à portée</returns>
        public bool PicNiquer(object Fourmi)
        {
            CCréature F = Fourmi as CCréature;
            int x, y; // Pour regarder alentours
            CRessource Bouffe;

            if (F.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (PicNiquer)", F.controle.Name));
                return false;
            }
            F.AJoué = true;

            int Bouchée = LoiDeLaNature("Récupération"); // Nombre de points de vie gagnés à chaque action "Déjeuner"

            // Parcourir les cases environnantes
            for (x = F.X - 1; x <= F.X + 1; x++)
                for (y = F.Y - 1; y <= F.Y + 1; y++)
                    if (LeJardin[x, y] != null)
                    {
                        string TContenu = LeJardin[x, y].GetType().ToString();
                        TContenu = TContenu.Substring(TContenu.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace
                        // Test si c'est de la nourriture
                        if (TContenu == "CRessource")
                        {
                            Bouffe = LeJardin[x, y] as CRessource;
                            if (Bouffe.TypeRessource == Elément.Nourriture) // Picnic time !!
                            {
                                // Prélever
                                Bouffe.Niveau--;
                                if (Bouffe.Niveau == 0) // Dernière tranche
                                    DétruireElément(LaMèreNature, x, y);
                                else
                                    MettreAJourRessource(x, y);
                                F.NiveauDeVie += PtsVieParNiveau;
                                // Ne pas dépasser le maximum permis en fonction de l'âge
                                F.NiveauDeVie = Math.Min(F.NiveauDeVie, LoiDeLaNature("MaxPointsVieFourmi") - F.Age);
                                return true; // on a mangé
                            }
                        }
                    }
            return false;
        }

        // ..............................................................................

        /// <summary>
        /// Prélève de la nourriture dans le sac. La nourriture est mangée et donc transformée en points de vie.
        /// </summary>
        /// <param name="Fourmi">La fourmi qui veut grignoter. Elle doit être une fermièrecar elle est la seule à transporter de la nourriture</param>
        /// <returns>false si rien n'a pu être mangé parce qu'elle n'est pas une fermière ou qu'il n'y a pas assez de nourriture dans le sac</returns>
        public bool Grignoter(object Fourmi)
        {
            CFermière F = Fourmi as CFermière;
            if (F == null) return false; // pas une fermière

            if (F.NiveauSacNourriture <= 0) return false; // sac vide

            if (F.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (Grignoter)", F.controle.Name));
                return false;
            }
            F.AJoué = true;

            int Bouchée = LoiDeLaNature("Récupération"); // Nombre de points de vie gagnés à chaque action "Déjeuner"

            if (F.NiveauSacNourriture < Bouchée) // Manger tout ce qui reste
            {
                F.NiveauDeVie += F.NiveauSacNourriture;
                F.NiveauSacNourriture = 0;
            }
            else
            {
                if (Bouchée <= (F.MaxPointsDeVie - F.NiveauDeVie)) // Elle a de la place dans l'estomac pour une pleine bouchée
                {
                    F.NiveauDeVie += Bouchée;
                    F.NiveauSacNourriture -= Bouchée;
                }
                else // Bouchée partielle
                {
                    F.NiveauSacNourriture -= (F.MaxPointsDeVie - F.NiveauDeVie);
                    F.NiveauDeVie = F.MaxPointsDeVie;
                }
            }

            return false;
        }

        // ..............................................................................

        /// <summary>
        /// Prélève des ressources dans la nature.
        /// </summary>
        /// <param name="Fourmi">La fourmi qui ramasse</param>
        /// <param name="TypeRess">Indique s'il s'agit de nourriture ou de matériau que l'on tente de ramasser</param>
        /// <returns>false si rien n'a pu être ramassé parce qu'il n'y a pas de ressource du type demandé à portée</returns>
        public bool RamasserRessource(Object Fourmi, Elément TypeRess)
        {
            int x, y; // Pour regarder alentours
            CRessource Ress;

            if ((TypeRess != Elément.Nourriture) && (TypeRess != Elément.Matériau)) return false;
            if ((Fourmi as CFermière == null) && (Fourmi as COuvrière == null)) return false;

            CCréature Crea = Fourmi as CCréature;
            if (Crea.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (RamasserRessource)", Crea.controle.Name));
                return false;
            }
            Crea.AJoué = true;

            // Parcourir les cases environnantes
            for (x = Crea.X - 1; x <= Crea.X + 1; x++)
                for (y = Crea.Y - 1; y <= Crea.Y + 1; y++)
                    if (LeJardin[x, y] != null)
                    {
                        string TContenu = LeJardin[x, y].GetType().ToString();
                        TContenu = TContenu.Substring(TContenu.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace
                        // Test si c'est une ressource
                        if (TContenu == "CRessource")
                        {
                            Ress = LeJardin[x, y] as CRessource;
                            if (Ress.TypeRessource == TypeRess) // C'est ce qu'on cherche
                            {
                                // Prélever
                                Ress.Niveau--;
                                if (Ress.Niveau == 0) // Dernière tranche
                                    DétruireElément(LaMèreNature, x, y);
                                else
                                    MettreAJourRessource(x, y);
                                // Charger le bon sac
                                if (TypeRess == Elément.Nourriture)
                                    (Fourmi as CFermière).NiveauSacNourriture += PtsVieParNiveau;
                                else
                                {
                                    string TFourmi = Fourmi.GetType().ToString();
                                    TFourmi = TFourmi.Substring(TFourmi.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace
                                    if (TFourmi == "COuvrière")
                                        (Fourmi as COuvrière).NiveauSacMatériau += PtsVieParNiveau;
                                    else
                                        (Fourmi as CFermière).NiveauSacMatériau += PtsVieParNiveau;
                                }
                            }
                        }
                    }
            return false;
        }
        // ..............................................................................

        /// <summary>
        /// Vide les deux sacs (nourriture et matériaux) de la fermière
        /// </summary>
        /// <param name="Fourmi">La fourmi qui veut vider son sac</param>
        /// <returns>false si la fourmi n'est pas un fermière ou si elle n'est pas au contact de la fourmilière</returns>
        public bool ViderSac(Object Fourmi)
        {
            int x, y; // Pour regarder alentours
            CFermière ff = Fourmi as CFermière;
            if (ff == null) return false;

            // Parcourir les cases environnantes
            for (x = ff.X - 1; x <= ff.X + 1; x++)
                for (y = ff.Y - 1; y <= ff.Y + 1; y++)
                    if (LeJardin[x, y] != null)
                    {
                        CDécor Bat = LeJardin[x, y] as CDécor;
                        if (Bat != null)
                        {
                            if (Bat.TypeElément == Elément.Fourmilière) // vider les sacs
                            {
                                RéserveNourriture += ff.NiveauSacNourriture * 10;
                                lblRéserveNourriture.Text = RéserveNourriture.ToString();
                                ff.NiveauSacNourriture = 0;
                                RéserveMatériau += ff.NiveauSacMatériau;
                                lblRéserveMatériau.Text = RéserveMatériau.ToString();
                                ff.NiveauSacMatériau = 0;
                                return true;
                            }
                        }
                    }
            return false;
        }

        // ..............................................................................

        /// <summary>
        /// Met l'apparence de la ressource qui se trouve en (x,y) en correspondance avec son niveau
        /// </summary>
        /// <param name="x">Position X de l'élément</param>
        /// <param name="y">Position Y de l'élément</param>
        public void MettreAJourRessource(int x, int y)
        {
            CRessource R = LeJardin[x, y] as CRessource;
            if (R == null) return;
            if (R.Niveau > 8)
            {
                LogMessage("ERREUR: ressource de niveau 9 !!!!");
                return;
            }
            string NomFichierImage = R.TypeRessource.ToString() + R.Niveau.ToString();
            R.controle.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + NomFichierImage + ".bmp");
        }

        // ..............................................................................

        /// <summary>
        /// Pond une larve du type donné.
        /// </summary>
        /// <param name="TypeLarve">Le type de larve à générer</param>
        /// <returns>false s'il n'y pas assez de place ou pas assez de nourriture dans la fourmilière</returns>
        public bool Pondre(Elément TypeLarve)
        {
            //ajouté par alec
            //initialise un tableau et i
            int i = 0;
            int posx = -1, posy = -1;
            int[] positionbonnex;
            positionbonnex = new int[100];
            int[] positionbonney;
            positionbonney = new int[100];

            // Assez de bouffe?
            if (RéserveNourriture < CoutDePonte) return false;
            // Type de larve OK ?
            if ((TypeLarve < Elément.LarveFermière) || (TypeLarve > Elément.LarveSoldat)) return false;

            // Recherche de place. On balaye tout le jardin car la fourmilière a pu grandir de façon anarchique
            for (int x = 1; x < JARDIN_TAILLE_X; x++)
                for (int y = 1; y < JARDIN_TAILLE_Y; y++)
                {
                    CDécor ContenuCase = LeJardin[x, y] as CDécor;
                    if ((ContenuCase != null) && (ContenuCase.TypeElément == Elément.Fourmilière)) // on a trouvé!
                    {
                        //ajouté par alec
                        //met la position trouvée dans le tableau
                        i++;
                        positionbonnex[i] = x;
                        positionbonney[i] = y;
                    }
                }
            //ajouté par alec
            //si il y une position libre dans la fourmilière, pose une larve à une position trouvée random
            if (i > 0)
            {
                Random rand = new Random();
                int position = rand.Next(1, i);

                posx = positionbonnex[position];
                posy = positionbonney[position];

                // éliminer le bout de fourmilière
                DétruireElément(LaMèreNature, posx, posy);
                CRessource Larve = new CRessource(posx, posy, TypeLarve);
                RéserveNourriture -= CoutDePonte; // Prélever le cout de ponte
                // Poser la larve
                Poser(Larve);
                return true; // on a fini
            }
            else
            {
                MessageBox.Show("Il n'y a plus de place libre pour poser une larve! Agrandissez votre empire (fourmilière)!!", "Erreur plus de Place pour Larve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false; // on a pas trouvé d'endroit
        }

        // ..............................................................................

        /// <summary>
        /// La fourmi dépose une phéromone du type donné. La position de la phéromone est définie par "Dir" (par rapport à la position de la fourmi)
        /// </summary>
        /// <param name="Fourmi">La fourmi qui dépose</param>
        /// <param name="Dir">Indique quelle case adjacente est visée</param>
        /// <param name="TypePhéro">Type de phéromone</param>
        /// <returns>false si \li La fourmi est trop faible \li Le type de fourmi ne peut pas poser de phéromone \li Mauvais type d'élément\li Il y a déjà quelque chose à cet endroit</returns>
        public bool PoserPhéromone(object Fourmi, Direction Dir, Elément TypePhéro)
        {
            CCréature F = Fourmi as CCréature;
            int x = 1;
            int y = 1;

            if (F == null) return false;
            if ((TypePhéro < Elément.PhéroSoldat) || (TypePhéro > Elément.PhéroFermière)) return false;

            if (F.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (PoserPhéromone)", F.controle.Name));
                return false;
            }
            F.AJoué = true;

            // Déterminer le type d'objet
            string TypeF = Fourmi.GetType().ToString();
            TypeF = TypeF.Substring(TypeF.LastIndexOf('.') + 1); // La classe est préfixée par le namespace

            // Tester le niveau d'énergie
            switch (TypeF)
            {
                case "CReine":
                    if (RéserveNourriture < EnergiePhéromone) return false; // pas assez de nourriture dans la fourmilière
                    break;
                case "CScout":
                    if (F.NiveauDeVie < EnergiePhéromone) return false; // fourmi trop faible
                    break;
                default: return false; // ce type de fourmi ne peut pas
            }

            // Déterminer la case
            switch (Dir)
            {
                case Direction.Nord: x = F.X; y = F.Y - 1; break;
                case Direction.Sud: x = F.X; y = F.Y + 1; break;
                case Direction.Est: x = F.X + 1; y = F.Y; break;
                case Direction.Ouest: x = F.X - 1; y = F.Y; break;
                case Direction.NordEst: x = F.X + 1; y = F.Y - 1; break;
                case Direction.NordOuest: x = F.X - 1; y = F.Y - 1; break;
                case Direction.SudEst: x = F.X + 1; y = F.Y + 1; break;
                case Direction.SudOuest: x = F.X - 1; y = F.Y + 1; break;
            }
            if (LeJardin[x, y] != null) return false; // Il y a déjà qqch

            // Arrivé ici, on est prêt à poser
            CRessource P = new CRessource(x, y, TypePhéro);
            Poser(P);
            // Coût de la pose en énergie
            if (TypeF == "CReine")
                RéserveNourriture -= EnergiePhéromone;
            else
                F.NiveauDeVie -= EnergiePhéromone;
            return true;
        }

        // ..............................................................................

        /// <summary>
        /// Construit un élément de fourmilière. La case où il faut construire est déterminée par la direction Dir par rapport à l'ouvrière. La case visée doit contenir une phéromone d'extension. Elle doit toucher la fourmilière
        /// </summary>
        /// <param name="Fourmi">La fourmi qui cherche à construire</param>
        /// <param name="Dir">Indique quelle case adjacente est visée</param>
        /// <returns>true si l'opération a réussi. Causes possibles d'échec:\li Pas assez de matériau dans le sac\li Pas de phéromone de construction sur la case visée</returns>
        public bool Construire(COuvrière Fourmi, Direction Dir)
        {
            int x = 1;
            int y = 1;

            if (Fourmi.NiveauSacMatériau < CoutDeConstruction) return false; // pas assez de matos

            if (Fourmi.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (Construire)", Fourmi.controle.Name));
                return false;
            }
            Fourmi.AJoué = true;
            // Déterminer la case
            switch (Dir)
            {
                case Direction.Nord: x = Fourmi.X; y = Fourmi.Y - 1; break;
                case Direction.Sud: x = Fourmi.X; y = Fourmi.Y + 1; break;
                case Direction.Est: x = Fourmi.X + 1; y = Fourmi.Y; break;
                case Direction.Ouest: x = Fourmi.X - 1; y = Fourmi.Y; break;
                case Direction.NordEst: x = Fourmi.X + 1; y = Fourmi.Y - 1; break;
                case Direction.NordOuest: x = Fourmi.X - 1; y = Fourmi.Y - 1; break;
                case Direction.SudEst: x = Fourmi.X + 1; y = Fourmi.Y + 1; break;
                case Direction.SudOuest: x = Fourmi.X - 1; y = Fourmi.Y + 1; break;
            }
            CRessource Phéro = LeJardin[x, y] as CRessource;
            if ((Phéro == null) || (Phéro.TypeRessource != Elément.PhéroOuvrière)) return false; // pas de phéro

            // Vérifier le contact avec la fourmilière
            bool contact = false;
            for (int lx = x - 1; lx <= x + 1; lx++)
                for (int ly = y - 1; ly <= y + 1; ly++)
                    if (LeJardin[lx, ly] != null)
                    {
                        string TContenu = LeJardin[lx, ly].GetType().ToString();
                        TContenu = TContenu.Substring(TContenu.LastIndexOf('.') + 1); // le nom de la classe est préfixé par le namespace
                        if (TContenu == "CRessource") // Une larve fait partie de la fourmilière
                            if (((LeJardin[x, y] as CRessource).TypeRessource >= Elément.LarveFermière) && ((LeJardin[x, y] as CRessource).TypeRessource <= Elément.LarveSoldat))
                                contact = true;
                        if (TContenu == "CDécor")
                            if ((LeJardin[x, y] as CDécor).TypeElément == Elément.Fourmilière)
                                contact = true;
                    }
            if (!contact) return false;

            // Ok pour construire
            DétruireElément(LaMèreNature, x, y);
            CDécor Bloc = new CDécor(x, y, Elément.Fourmilière);
            if (Phéro.TypeRessource == Elément.PhéroOuvrière)
                Bloc.TypeElément = Elément.Dépôt;
            LeJardin[x, y] = Bloc;
            Poser(Bloc);
            return true;
        }

        // ..............................................................................

        /// <summary>
        /// La Bébête combat la créature situé à la direction Dir. Cette méthode se contente de retirer les points de vie à l'ennemi. C'est à Mère Nature de juger de la mort. Si la bête qui frappe était l'araignée et qu'elle a porté un coup fatal, ses points de vie sont augmentés du nombre de points de vie que son opposant avait au début du combat
        /// </summary>
        /// <param name="Bébête">Le combattant</param>
        /// <param name="Dir">La direction dans laquelle se trouve l'adversaire</param>
        /// <returns>false s'il n'y a pas d'ennemi dans la case indiquée</returns>
        public bool Frapper(CCréature Bébête, Direction Dir)
        {
            int x = 1;
            int y = 1;
            int Bonus = 0; // Pour l'araignée si elle tue son adversaire
            if (Bébête.AJoué)
            {
                LogMessage(string.Format("{0} a essayé de faire plus d'une action dans un même cycle (Frapper)", Bébête.controle.Name));
                return false;
            }
            Bébête.AJoué = true;
            LogMessage(Bébête.controle.Name + " frappe au " + Dir.ToString());
            // Déterminer la case
            switch (Dir)
            {
                case Direction.Nord: x = Bébête.X; y = Bébête.Y - 1; break;
                case Direction.Sud: x = Bébête.X; y = Bébête.Y + 1; break;
                case Direction.Est: x = Bébête.X + 1; y = Bébête.Y; break;
                case Direction.Ouest: x = Bébête.X - 1; y = Bébête.Y; break;
                case Direction.NordEst: x = Bébête.X + 1; y = Bébête.Y - 1; break;
                case Direction.NordOuest: x = Bébête.X - 1; y = Bébête.Y - 1; break;
                case Direction.SudEst: x = Bébête.X + 1; y = Bébête.Y + 1; break;
                case Direction.SudOuest: x = Bébête.X - 1; y = Bébête.Y + 1; break;
            }
            if (LeJardin[x, y] == null) return false; // rien à frapper

            // Déterminer le type de bébête et d'ennemi
            string TypeBête = Bébête.GetType().ToString();
            TypeBête = TypeBête.Substring(TypeBête.LastIndexOf('.') + 1); // La classe est préfixée par le namespace
            string TypeEnnemi = LeJardin[x, y].GetType().ToString();
            TypeEnnemi = TypeEnnemi.Substring(TypeEnnemi.LastIndexOf('.') + 1); // La classe est préfixée par le namespace

            CDécor Sol = LeJardin[x, y] as CDécor;

            // Test de la fin du monde
            if ((TypeBête == "CAraignée") && (Sol != null) && (Sol.TypeElément == Elément.Fourmilière)) // L'araignée a pu frapper la fourmilière: c'est la fin du monde
            {
                FinDuMonde();
                return true;
            }

            CCréature Ennemi = LeJardin[x, y] as CCréature;
            int Dégâts;
            if (Ennemi == null) return false; // Personne à combattre
            double Atténuation = 0.0; // Facteur aléatoire qui diminue la force du coup
            switch (TypeBête)
            {
                case "CAraignée":
                    Bonus = Ennemi.NiveauDeVie;
                    if (!((TypeEnnemi == "CFermière") || (TypeEnnemi == "COuvrière") || (TypeEnnemi == "CScout") || (TypeEnnemi == "CSoldat"))) return false; // Ce ne sont pas des ennemis
                    Atténuation = Rand.Next(80, 100) / 100.0;
                    Dégâts = (int)((double)Bébête.NiveauDeVie * ((double)DégâtsInfligésAraignée / 100.0) * Atténuation);
                    Ennemi.NiveauDeVie -= Dégâts;
                    LogMessage("Inflige " + Dégâts.ToString() + " dégâts à " + Ennemi.controle.Name);
                    if (Ennemi.NiveauDeVie <= 0) // le coup était fatal
                    {
                        Bébête.NiveauDeVie += Bonus;
                        LogMessage("La tue et gagne " + Bonus.ToString());
                    }
                    break;
                case "COuvrière":
                case "CFermière":
                case "CScout":
                    if (TypeEnnemi != "CAraignée") return false; // Ce ne sont pas des ennemis
                    Atténuation = Rand.Next(80, 100) / 100.0;
                    Dégâts = (int)((double)Bébête.NiveauDeVie * ((double)DégâtsInfligés / 100.0) * Atténuation);
                    Ennemi.NiveauDeVie -= Dégâts;
                    LogMessage("Inflige " + Dégâts.ToString() + " dégâts à " + Ennemi.controle.Name);
                    break;
                case "CSoldat":
                    if (TypeEnnemi != "CAraignée") return false; // Ce ne sont pas des ennemis
                    Atténuation = Rand.Next(80, 100) / 100.0;
                    Dégâts = (int)((double)Bébête.NiveauDeVie * ((double)DégâtsInfligésSoldat / 100.0) * Atténuation);
                    Ennemi.NiveauDeVie -= Dégâts;
                    LogMessage("Inflige " + Dégâts.ToString() + " dégâts à " + Ennemi.controle.Name);
                    break;
            }

            return true;
        }

        // ..............................................................................

        /// <summary>
        /// Retourne les coordonnées de la dernière case du jardin sur laquelle l'utilisateur a cliqué avec la souris
        /// </summary>
        /// <returns>Un objet System.Drawing.Point.  (-1,-1) s'il n'y a jamais eu de click</returns>
        public Coord DernierClicSouris()
        {
            return LastMouseClick;
        }

        //===============================================================================================================================
        // Méthodes internes
        //===============================================================================================================================

        public CJardin()
        {
            InitializeComponent();
        }

        private void FinDuMonde()
        {
            tmrPulse.Enabled = false;
            int x, y;
            for (x = 0; x < JARDIN_TAILLE_X; x++)
                for (y = 0; y < JARDIN_TAILLE_Y; y++)
                    DétruireElément(LaMèreNature, x, y);
            string[] GameOver = {"                       ooooo     ooo    oo   oo ooooooo                         ",
                                 "                      ooooooo    ooo    ooo ooo ooooooo                         ",
                                 "                      oo   oo   oo oo   ooooooo oo                              ",
                                 "                      oo        oo oo   ooooooo oooo                            ",
                                 "                      oo  ooo  ooooooo  oo o oo oooo                            ",
                                 "                      oo   oo  ooooooo  oo   oo oo                              ",
                                 "                      ooooooo oo     oo oo   oo ooooooo                         ",
                                 "                       ooooo  oo     oo oo   oo ooooooo                         ",
                                 "                                                                                ",
                                 "                                                                                ",
                                 "                       ooooo  oo     oo ooooooo oooooo                          ",
                                 "                      ooooooo oo     oo ooooooo ooooooo                         ",
                                 "                      oo   oo  oo   oo  oo      oo   oo                         ",
                                 "                      oo   oo  oo   oo  oooo    ooooooo                         ",
                                 "                      oo   oo   oo oo   oooo    oooooo                          ",
                                 "                      oo   oo   oo oo   oo      oo oo                           ",
                                 "                      ooooooo    ooo    ooooooo oo  oo                          ",
                                 "                       ooooo     ooo    ooooooo oo   oo                         ",
                                };
            for (x = 0; x < JARDIN_TAILLE_X; x++)
                for (y = 0; y < 18; y++)
                    if (GameOver[y][x] != ' ')
                    {
                        CDécor R = new CDécor(x, y + JARDIN_TAILLE_Y / 2 - 9, Elément.Rocher);
                        Poser(R);
                    }
        }

        private void PréparerTerrain()
        {
            string LocationFile = Application.StartupPath + "\\Jardin.txt";

            // Création d'une instance de StreamReader pour permettre la lecture de notre fichier 
            System.IO.StreamReader reader = new System.IO.StreamReader(LocationFile, System.Text.Encoding.UTF7);

            int x = 0;
            int y = 0;
            // Variables pour estimer le centre de la fourmilière

            int FXMax = 0;
            int FXMin = JARDIN_TAILLE_X;
            int FYMax = 0;
            int FYMin = JARDIN_TAILLE_Y;

            CDécor Décor;
            CRessource Ress;

            // Lecture de toutes les lignes
            for (y = 0; y < JARDIN_TAILLE_Y; y++)
            {
                string ligne = reader.ReadLine();
                for (x = 0; x < ligne.Length; x++)
                {
                    switch (ligne[x].ToString())
                    {

                        // Reine - Araignée - Fourmis -----------------------------------------------------------------------
                        case "Q": LaReine = new CReine(x, y); Poser(LaReine); break;
                        case "S": CScout S = new CScout(x, y); Poser(S); break;
                        case "O": COuvrière O = new COuvrière(x, y); Poser(O); break;
                        case "E": CFermière F = new CFermière(x, y); Poser(F); break;
                        case "L": CSoldat L = new CSoldat(x, y); Poser(L); break;
                        case "A": Aragog = new CAraignée(x, y); Poser(Aragog); break;
                        // -------------------------------------------------------------------------------------------------

                        // Décor - Dépot - Fourmillière --------------------------------------------------------------------
                        case "X": Décor = new CDécor(x, y, Elément.Rocher); Poser(Décor); break;
                        case "F":
                            Décor = new CDécor(x, y, Elément.Fourmilière); Poser(Décor);
                            if (x < FXMin) FXMin = x;
                            if (x > FXMax) FXMax = x;
                            if (y < FYMin) FYMin = y;
                            if (y > FYMax) FYMax = y;
                            break;
                        // -------------------------------------------------------------------------------------------------

                        // Nourriture --------------------------------------------------------------------------------------
                        case "a": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 1; Poser(Ress); break;
                        case "b": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 2; Poser(Ress); break;
                        case "c": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 3; Poser(Ress); break;
                        case "d": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 4; Poser(Ress); break;
                        case "e": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 5; Poser(Ress); break;
                        case "f": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 6; Poser(Ress); break;
                        case "g": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 7; Poser(Ress); break;
                        case "h": Ress = new CRessource(x, y, Elément.Nourriture); Ress.Niveau = 8; Poser(Ress); break;
                        // -------------------------------------------------------------------------------------------------

                        // Matériaux ---------------------------------------------------------------------------------------
                        case "1": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 1; Poser(Ress); break;
                        case "2": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 2; Poser(Ress); break;
                        case "3": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 3; Poser(Ress); break;
                        case "4": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 4; Poser(Ress); break;
                        case "5": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 5; Poser(Ress); break;
                        case "6": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 6; Poser(Ress); break;
                        case "7": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 7; Poser(Ress); break;
                        case "8": Ress = new CRessource(x, y, Elément.Matériau); Ress.Niveau = 8; Poser(Ress); break;
                        // -------------------------------------------------------------------------------------------------

                        // Phéromone --------------------------------------------------------------------------------------
                        // Phéromone de niveau 8:
                        case "n": Ress = new CRessource(x, y, Elément.PhéroOuvrière); Ress.Niveau = 8; Poser(Ress); break;
                        case "p": Ress = new CRessource(x, y, Elément.PhéroFermière); Ress.Niveau = 8; Poser(Ress); break;
                        case "q": Ress = new CRessource(x, y, Elément.PhéroSoldat); Ress.Niveau = 8; Poser(Ress); break;
                        // Phéromone de niveau 4:
                        case "r": Ress = new CRessource(x, y, Elément.PhéroOuvrière); Ress.Niveau = 4; Poser(Ress); break;
                        case "s": Ress = new CRessource(x, y, Elément.PhéroFermière); Ress.Niveau = 4; Poser(Ress); break;
                        case "t": Ress = new CRessource(x, y, Elément.PhéroSoldat); Ress.Niveau = 4; Poser(Ress); break;
                        //--------------------------------------------------------------------------------------------------
                    }
                }
            }

            if (!reader.EndOfStream) // Lire une ligne supplémentaire de ponte de larve
            {
                String pondre = reader.ReadLine();
                for (x = 0; x < pondre.Length; x++)
                {
                    switch (pondre[x].ToString())
                    {
                        // Larves -----------------------------------------------------------------------------------------
                        case "i": Pondre(Elément.LarveFermière); break;
                        case "j": Pondre(Elément.LarveOuvrière); break;
                        case "k": Pondre(Elément.LarveScout); break;
                        case "l": Pondre(Elément.LarveSoldat); break;
                    }
                }
            }

            // Fermeture du StreamReader
            reader.Close();

            FourmilièreX = (int)((FXMax - FXMin) / 2) + FXMin;
            FourmilièreY = (int)((FYMax - FYMin) / 2) + FYMin;
            LogMessage("Fourmilière: (" + FourmilièreX.ToString() + "," + FourmilièreY.ToString() + ")");
        }

        private void Jardin_Load(object sender, EventArgs e)
        {
            // Initialisation de valeurs
            RéserveNourriture = 10000;
            RéserveMatériau = 250;
            lblRéserveNourriture.Text = RéserveNourriture.ToString();
            lblRéserveMatériau.Text = RéserveMatériau.ToString();

            this.Text = "Krohonde v" + KVersion;
            this.SetBounds(0, 0, (JARDIN_TAILLE_X + 1) * TAILLE_CASE, JARDIN_TAILLE_Y * TAILLE_CASE + 100);
            PréparerTerrain();
            this.lblFond.SendToBack();
            TheLog.Show();
            // TheLog.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            TheLog.Logger("C'est parti...");
            cmdPause.Text = "Démarrer";
            tmrPulse.Enabled = false;
        }

        private void tmrPulse_Tick(object sender, EventArgs e)
        {
            NbCycles++;
            LaMèreNature.CycleDeVie(this);
            foreach (CScout Créature in LesScouts) Créature.AJoué = false;
            foreach (CSoldat Créature in LesSoldats) Créature.AJoué = false;
            foreach (CFermière Créature in LesFermières) Créature.AJoué = false;
            foreach (COuvrière Créature in LesOuvrières) Créature.AJoué = false;

            foreach (CScout Créature in LesScouts)
            {
                Créature.CycleDeVie(this);
                if (!Créature.AJoué) LogMessage(string.Format("{0} a choisi de ne rien faire", Créature.controle.Name));
            }
            foreach (CFermière Créature in LesFermières)
            {
                Créature.CycleDeVie(this);
                if (!Créature.AJoué) LogMessage(string.Format("{0} a choisi de ne rien faire", Créature.controle.Name));
            }
            foreach (COuvrière Créature in LesOuvrières)
            {
                Créature.CycleDeVie(this);
                if (!Créature.AJoué) LogMessage(string.Format("{0} a choisi de ne rien faire", Créature.controle.Name));
            }
            foreach (CSoldat Créature in LesSoldats)
            {
                Créature.CycleDeVie(this);
                if (!Créature.AJoué) LogMessage(string.Format("{0} a choisi de ne rien faire", Créature.controle.Name));
            }
            LaReine.AJoué = false;
            LaReine.CycleDeVie(this);
            if (!LaReine.AJoué) LogMessage(string.Format("{0} a choisi de ne rien faire", LaReine.controle.Name));
            if (((NbCycles % 5) == 0) && Aragog != null)
            {
                Aragog.AJoué = false;
                Aragog.CycleDeVie(this);
                if (!Aragog.AJoué) LogMessage(string.Format("{0} a choisi de ne rien faire", Aragog.controle.Name));
            }
            lblRéserveNourriture.Text = RéserveNourriture.ToString();
            lblRéserveMatériau.Text = RéserveMatériau.ToString();
            if ((LesFermières.Count + LesOuvrières.Count + LesScouts.Count == 0) && Vivant || (RéserveNourriture <= 0)) FinDuMonde();
            LastMouseClick.X = -1; // remise à zéro: chacun a eu l'occasion de lire les coordonnées du clic
            LastMouseClick.Y = -1;
            //LogMessage(string.Format("Cycle #{0}", NbCycles));
            //LogMessage(string.Format("Nombre ouvrières: {0}", LesOuvrières.Count));
            //LogMessage(string.Format("Nombre soldats: {0}", LesSoldats.Count));
        }

        /// <summary>
        /// Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jardin_MouseClick(object sender, MouseEventArgs e)
        {
            Point clic = this.PointToClient(Cursor.Position);
            LastMouseClick.X = clic.X / TAILLE_CASE;
            LastMouseClick.Y = clic.Y / TAILLE_CASE;
        }

        private void cmdPause_Click(object sender, EventArgs e)
        {
            if (tmrPulse.Enabled)
            {
                tmrPulse.Enabled = false;
                cmdPause.Text = "Reprendre";
            }
            else
            {
                tmrPulse.Enabled = true;
                cmdPause.Text = "Pause";
            }
        }

    }
}
