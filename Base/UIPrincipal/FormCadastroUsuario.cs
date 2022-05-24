using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;
<<<<<<< HEAD
        private bool inserirndoNovo;
=======
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3

        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
<<<<<<< HEAD
            
        }

      
=======
        }
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
<<<<<<< HEAD

=======
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
<<<<<<< HEAD
                MessageBox.Show("Operação realizada com sucesso!");
=======
                MessageBox.Show("Cadastro realizado com sucesso!");
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
<<<<<<< HEAD
           
=======

>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
<<<<<<< HEAD
           
            if (inserindoNovo)
            usuarioBLL.Inserir(usuario);
            else
            usuarioBLL.Alterar(usuario);
=======

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
        }

        private void buttonSalvarECadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
<<<<<<< HEAD
            MessageBox.Show("Cadastro realizado com sucesso!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            inserirndoNovo = true;
            nomeUsuarioTextBox.Focus();

=======
            MessageBox.Show("Operação realizada com sucesso!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
            nomeUsuarioTextBox.Focus();
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
        }
    }
}