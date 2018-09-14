using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krohonde
{
    /// <summary>
    /// \author J. Alexandre
    /// \version 1.2
    /// \date Janvier 2016
    /// Formulaire qui permet de contrôler la reine, sert à la déplacer, faire pondre et poser une phéromone
    /// </summary>
    public partial class FormMenu : Form
    {
        public CReine LaReine;
        public FormMenu()
        {
            InitializeComponent();
        }

        // Les oeufs
        public void cmdFermière_Click(object sender, EventArgs e)
        {
            LaReine.PonteFermiere = true;
        }

        private void cmdScout_Click(object sender, EventArgs e)
        {
            LaReine.PonteScout = true;
        }

        private void cmdOuvrière_Click(object sender, EventArgs e)
        {
            LaReine.PonteOuvriere = true;
        }

        private void cmdSoldat_Click(object sender, EventArgs e)
        {
            LaReine.PonteSoldat = true;
        }




        //Déplacement reine
        private void cmdMoveN_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 1;
        }

        private void cmdMoveNW_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 2;
        }

        private void cmdMoveW_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 3;
        }

        private void cmdMoveSW_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 4;
        }

        private void mdMoveS_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 5;
        }

        private void cmdMoveSE_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 6;
        }

        private void cmdMoveE_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 7;
        }

        private void cmdMoveNE_Click(object sender, EventArgs e)
        {
            LaReine.DirectionMoveReine = 8;
        }




        //Poser phéromone
        private void CmdPheroN_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 1;
        }

        private void CmdPheroNW_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 2;
        }

        private void CmdPheroW_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 3;
        }

        private void CmdPheroSW_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 4;
        }

        private void CmdPheroS_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 5;
        }

        private void CmdPheroSE_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 6;
        }

        private void CmdPheroE_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 7;
        }

        private void CmdPheroNE_Click(object sender, EventArgs e)
        {
            LaReine.DirectionPheroReine = 8;
        }
    }
}
