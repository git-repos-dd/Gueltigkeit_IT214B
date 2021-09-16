using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scope
{
    public partial class frm_scope : Form
    {
        // Deklaration der Variablen mit dem Namen Mx, dem Datentypen int, und dem Wert 0
        // private heißt, Variable ist klassenweit gültig - also in allen Methoden der Klasse
        private int Mx = 0;
        public frm_scope()
        {
            InitializeComponent();
        }

        private void btn_methode1_Click(object sender, EventArgs e)
        {
            // zum alten Wert von Mx wird eine 1 hinzuaddiert
            // beim ersten Durchlauf wäre das Mx = 0 + 1
            Mx = Mx + 1;

            lbl_methode1.Text = Mx.ToString();
        }

        private void btn_methode2_Click(object sender, EventArgs e)
        {

        }
    }
}
