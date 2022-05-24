namespace UIPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4Sair = new System.Windows.Forms.Button();
            this.button3Alterar = new System.Windows.Forms.Button();
            this.button2Excluir = new System.Windows.Forms.Button();
            this.button1Nome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1Buscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4Sair);
            this.panel1.Controls.Add(this.button3Alterar);
            this.panel1.Controls.Add(this.button2Excluir);
            this.panel1.Controls.Add(this.button1Nome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4Sair
            // 
            this.button4Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4Sair.Location = new System.Drawing.Point(1039, 3);
            this.button4Sair.Name = "button4Sair";
            this.button4Sair.Size = new System.Drawing.Size(91, 36);
            this.button4Sair.TabIndex = 3;
            this.button4Sair.Text = "&Sair";
            this.button4Sair.UseVisualStyleBackColor = true;
            this.button4Sair.Click += new System.EventHandler(this.button4Sair_Click);
            // 
            // button3Alterar
            // 
            this.button3Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3Alterar.Location = new System.Drawing.Point(103, 0);
            this.button3Alterar.Name = "button3Alterar";
            this.button3Alterar.Size = new System.Drawing.Size(84, 36);
            this.button3Alterar.TabIndex = 2;
            this.button3Alterar.Text = "&Alterar";
            this.button3Alterar.UseVisualStyleBackColor = true;
            this.button3Alterar.Click += new System.EventHandler(this.button3Alterar_Click);
            // 
            // button2Excluir
            // 
            this.button2Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2Excluir.Location = new System.Drawing.Point(208, 0);
            this.button2Excluir.Name = "button2Excluir";
            this.button2Excluir.Size = new System.Drawing.Size(82, 36);
            this.button2Excluir.TabIndex = 1;
            this.button2Excluir.Text = "&Excluir";
            this.button2Excluir.UseVisualStyleBackColor = true;
            this.button2Excluir.Click += new System.EventHandler(this.button2Excluir_Click);
            // 
            // button1Nome
            // 
            this.button1Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1Nome.Location = new System.Drawing.Point(12, 0);
            this.button1Nome.Name = "button1Nome";
            this.button1Nome.Size = new System.Drawing.Size(85, 36);
            this.button1Nome.TabIndex = 0;
            this.button1Nome.Text = "&Novo";
            this.button1Nome.UseVisualStyleBackColor = true;
            this.button1Nome.Click += new System.EventHandler(this.button1Nome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1Buscar);
            this.panel2.Controls.Add(this.textBoxBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 100);
            this.panel2.TabIndex = 1;
            // 
            // button1Buscar
            // 
            this.button1Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Buscar.Location = new System.Drawing.Point(1018, 74);
            this.button1Buscar.Name = "button1Buscar";
            this.button1Buscar.Size = new System.Drawing.Size(75, 23);
            this.button1Buscar.TabIndex = 2;
            this.button1Buscar.Text = "&Buscar";
            this.button1Buscar.UseVisualStyleBackColor = true;
            this.button1Buscar.Click += new System.EventHandler(this.button1Buscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(28, 77);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(984, 22);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(982, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1142, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(28, 106);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.Size = new System.Drawing.Size(1065, 437);
            this.usuarioDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Usuario";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 642);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1160, 689);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4Sair;
        private System.Windows.Forms.Button button3Alterar;
        private System.Windows.Forms.Button button2Excluir;
        private System.Windows.Forms.Button button1Nome;
        private System.Windows.Forms.Button button1Buscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}