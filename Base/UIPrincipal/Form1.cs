using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class Form1 : Form
    {
        private object frm;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button4Sair_Click(null, null);
            }
        }

        private void button1Nome_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            {

            }
        }

        private void button1Buscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);

        }

        private void button2Excluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente ecluir este registro ?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;
            
            
            UsuarioBLL usuariobll = new UsuarioBLL();
                
                int id;
            id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);

            usuariobll.Excluir(id);
            usuarioBindingSource.RemoveCurrent();
        }

        private void button3Alterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource.Current))
            {
                frm.ShowDialog();

            }
        }
    }
}
