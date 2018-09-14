using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeuRouge
{
    public partial class TrafficLight : Form
    {
        private enum TLState { ClignotementJaune, Rouge, Vert, RougeJaune, Jaune}

        private TLState EtatDeMonFeuRouge = TLState.ClignotementJaune;
        public TrafficLight()
        {
            InitializeComponent();
        }

        private void tmrBlink_Tick(object sender, EventArgs e)
        {
            pctYellowOn.Visible = !pctYellowOn.Visible;
        }

        private void ShowState()
        {
            switch(EtatDeMonFeuRouge)
            {
                case TLState.Rouge:
                    pctRedOn.Visible = true;
                    pctGreenOn.Visible = false;
                    pctYellowOn.Visible = false;
                    tmrBlink.Enabled = false;
                    break;

                case TLState.RougeJaune:
                    pctRedOn.Visible = true;
                    pctYellowOn.Visible = true;
                    pctGreenOn.Visible = false;
                    tmrBlink.Enabled = false;
                    break;

                case TLState.Vert:
                    pctGreenOn.Visible = true;
                    pctRedOn.Visible = false;
                    pctYellowOn.Visible = false;
                    tmrBlink.Enabled = false;
                    break;

                case TLState.Jaune:
                    pctYellowOn.Visible = true;
                    pctRedOn.Visible = false;
                    pctGreenOn.Visible = false;
                    tmrBlink.Enabled = false;
                    break;

                case TLState.ClignotementJaune:
                    tmrBlink.Enabled = true;
                    pctYellowOn.Visible = !pctYellowOn.Visible;
                    pctRedOn.Visible = false;
                    pctGreenOn.Visible = false;
                    break;
            }
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            switch(EtatDeMonFeuRouge)
            {
                case TLState.ClignotementJaune:
                    if (DateTime.Now.Hour >= int.Parse(txtDebut.Text))
                        EtatDeMonFeuRouge = TLState.Rouge;
                    else
                        EtatDeMonFeuRouge = TLState.ClignotementJaune;
                    break;

                case TLState.Jaune:
                    EtatDeMonFeuRouge = TLState.Rouge;
                    break;

                case TLState.Rouge:
                    if (DateTime.Now.Hour > int.Parse(txtFin.Text))
                        EtatDeMonFeuRouge = TLState.RougeJaune;
                    else
                        EtatDeMonFeuRouge = TLState.ClignotementJaune;
                    break;

                case TLState.RougeJaune:
                    EtatDeMonFeuRouge = TLState.Vert;
                    break;

                case TLState.Vert:
                    EtatDeMonFeuRouge = TLState.Jaune;
                    break;
            }
            ShowState();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            EtatDeMonFeuRouge = TLState.ClignotementJaune;
            ShowState();
        }
    }
}
