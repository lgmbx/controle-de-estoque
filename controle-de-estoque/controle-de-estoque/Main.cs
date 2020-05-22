using controle_de_estoque.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque {
    public partial class Main : Form {

        private Form activeForm;
        
        public Main() {
            InitializeComponent();
        }

        //methods
        private void openChildForm(Form childForm, object btn) {
            if(activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitle.Text = childForm.Text; 
            

        }

        private void BtnProdutos_Click(object sender, EventArgs e) {
            openChildForm(new Forms.FomProdutos(), sender);
        }

        private void BtnRelatorio_Click(object sender, EventArgs e) {
            openChildForm(new Forms.FormRelatorio(), sender);
        }
    }
}
