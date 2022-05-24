using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form1 frm = new Form1())

            {
                frm.ShowDialog();

=======
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaUsuario frm = new FormConsultaUsuario())
            {
                frm.ShowDialog();
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
            }
        }
    }
}
