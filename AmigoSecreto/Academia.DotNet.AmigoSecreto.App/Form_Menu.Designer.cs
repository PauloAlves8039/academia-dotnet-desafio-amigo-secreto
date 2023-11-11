namespace Academia.DotNet.AmigoSecreto.App
{
    partial class Form_Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            menuStrip1 = new MenuStrip();
            amigoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_Msg = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgData = new ToolStripStatusLabel();
            toolStripStatusLabel_Data = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgHora = new ToolStripStatusLabel();
            toolStripStatusLabel_Hora = new ToolStripStatusLabel();
            Timer_Menu = new System.Windows.Forms.Timer(components);
            label_Menu = new Label();
            panel_GerarAmigoSecreto = new Panel();
            panel1 = new Panel();
            toolStripCadastrarAmigo = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnCancelar = new ToolStripButton();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            label_Nome = new Label();
            label_Email = new Label();
            label_ListaAmigosSecreto = new Label();
            label_ListaDeAmigos = new Label();
            toolStrip_GerarAmigosSecretos = new ToolStrip();
            btnGerarAmigoSecreto = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnLimparLista = new ToolStripButton();
            btnSair = new ToolStripButton();
            treeView1 = new TreeView();
            treeView_Amigos = new TreeView();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel_GerarAmigoSecreto.SuspendLayout();
            panel1.SuspendLayout();
            toolStripCadastrarAmigo.SuspendLayout();
            toolStrip_GerarAmigosSecretos.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { amigoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // amigoToolStripMenuItem
            // 
            amigoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            amigoToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            amigoToolStripMenuItem.ForeColor = Color.Black;
            amigoToolStripMenuItem.Name = "amigoToolStripMenuItem";
            amigoToolStripMenuItem.Size = new Size(55, 21);
            amigoToolStripMenuItem.Text = "Menu";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(111, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.DeepSkyBlue;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Msg, toolStripStatusLabel_MsgData, toolStripStatusLabel_Data, toolStripStatusLabel_MsgHora, toolStripStatusLabel_Hora });
            statusStrip1.Location = new Point(0, 639);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Msg
            // 
            toolStripStatusLabel_Msg.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_Msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Msg.Name = "toolStripStatusLabel_Msg";
            toolStripStatusLabel_Msg.Size = new Size(83, 17);
            toolStripStatusLabel_Msg.Text = "Bem-vindo(a)";
            // 
            // toolStripStatusLabel_MsgData
            // 
            toolStripStatusLabel_MsgData.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_MsgData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_MsgData.Name = "toolStripStatusLabel_MsgData";
            toolStripStatusLabel_MsgData.Size = new Size(33, 17);
            toolStripStatusLabel_MsgData.Text = "Data";
            // 
            // toolStripStatusLabel_Data
            // 
            toolStripStatusLabel_Data.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Data.Name = "toolStripStatusLabel_Data";
            toolStripStatusLabel_Data.Size = new Size(127, 17);
            toolStripStatusLabel_Data.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel_MsgHora
            // 
            toolStripStatusLabel_MsgHora.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_MsgHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_MsgHora.Name = "toolStripStatusLabel_MsgHora";
            toolStripStatusLabel_MsgHora.Size = new Size(34, 17);
            toolStripStatusLabel_MsgHora.Text = "Hora";
            // 
            // toolStripStatusLabel_Hora
            // 
            toolStripStatusLabel_Hora.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_Hora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Hora.Name = "toolStripStatusLabel_Hora";
            toolStripStatusLabel_Hora.Size = new Size(127, 17);
            toolStripStatusLabel_Hora.Text = "toolStripStatusLabel5";
            // 
            // Timer_Menu
            // 
            Timer_Menu.Enabled = true;
            Timer_Menu.Tick += Timer_Menu_Tick;
            // 
            // label_Menu
            // 
            label_Menu.AutoSize = true;
            label_Menu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_Menu.ForeColor = Color.White;
            label_Menu.Location = new Point(401, 34);
            label_Menu.Name = "label_Menu";
            label_Menu.Size = new Size(151, 28);
            label_Menu.TabIndex = 7;
            label_Menu.Text = "Amigo Secreto";
            // 
            // panel_GerarAmigoSecreto
            // 
            panel_GerarAmigoSecreto.Controls.Add(panel1);
            panel_GerarAmigoSecreto.Controls.Add(label_ListaAmigosSecreto);
            panel_GerarAmigoSecreto.Controls.Add(label_ListaDeAmigos);
            panel_GerarAmigoSecreto.Controls.Add(toolStrip_GerarAmigosSecretos);
            panel_GerarAmigoSecreto.Controls.Add(treeView1);
            panel_GerarAmigoSecreto.Controls.Add(treeView_Amigos);
            panel_GerarAmigoSecreto.Location = new Point(23, 65);
            panel_GerarAmigoSecreto.Name = "panel_GerarAmigoSecreto";
            panel_GerarAmigoSecreto.Size = new Size(940, 560);
            panel_GerarAmigoSecreto.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStripCadastrarAmigo);
            panel1.Controls.Add(textBox_Nome);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(label_Nome);
            panel1.Controls.Add(label_Email);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 116);
            panel1.TabIndex = 9;
            // 
            // toolStripCadastrarAmigo
            // 
            toolStripCadastrarAmigo.BackColor = Color.DeepSkyBlue;
            toolStripCadastrarAmigo.Dock = DockStyle.Bottom;
            toolStripCadastrarAmigo.ImageScalingSize = new Size(36, 36);
            toolStripCadastrarAmigo.Items.AddRange(new ToolStripItem[] { btnAdicionar, toolStripSeparator4, btnCancelar });
            toolStripCadastrarAmigo.Location = new Point(0, 77);
            toolStripCadastrarAmigo.Name = "toolStripCadastrarAmigo";
            toolStripCadastrarAmigo.Size = new Size(397, 39);
            toolStripCadastrarAmigo.TabIndex = 9;
            toolStripCadastrarAmigo.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = false;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.add2;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(36, 36);
            btnAdicionar.Text = "Adicionar Amigo";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCancelar.Image = Properties.Resources.brush3;
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(36, 36);
            btnCancelar.Text = "Limpar Campos";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(65, 7);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(330, 23);
            textBox_Nome.TabIndex = 6;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(65, 39);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(330, 23);
            textBox_Email.TabIndex = 8;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.ForeColor = Color.White;
            label_Nome.Location = new Point(3, 10);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(56, 20);
            label_Nome.TabIndex = 5;
            label_Nome.Text = "Nome:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Email.ForeColor = Color.White;
            label_Email.Location = new Point(3, 42);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(51, 20);
            label_Email.TabIndex = 7;
            label_Email.Text = "Email:";
            // 
            // label_ListaAmigosSecreto
            // 
            label_ListaAmigosSecreto.AutoSize = true;
            label_ListaAmigosSecreto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_ListaAmigosSecreto.ForeColor = Color.White;
            label_ListaAmigosSecreto.Location = new Point(614, 6);
            label_ListaAmigosSecreto.Name = "label_ListaAmigosSecreto";
            label_ListaAmigosSecreto.Size = new Size(184, 20);
            label_ListaAmigosSecreto.TabIndex = 4;
            label_ListaAmigosSecreto.Text = "Lista de Amigos Secretos";
            // 
            // label_ListaDeAmigos
            // 
            label_ListaDeAmigos.AutoSize = true;
            label_ListaDeAmigos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_ListaDeAmigos.ForeColor = Color.White;
            label_ListaDeAmigos.Location = new Point(133, 136);
            label_ListaDeAmigos.Name = "label_ListaDeAmigos";
            label_ListaDeAmigos.Size = new Size(121, 20);
            label_ListaDeAmigos.TabIndex = 3;
            label_ListaDeAmigos.Text = "Lista de Amigos";
            // 
            // toolStrip_GerarAmigosSecretos
            // 
            toolStrip_GerarAmigosSecretos.BackColor = Color.DeepSkyBlue;
            toolStrip_GerarAmigosSecretos.Dock = DockStyle.Bottom;
            toolStrip_GerarAmigosSecretos.ImageScalingSize = new Size(36, 36);
            toolStrip_GerarAmigosSecretos.Items.AddRange(new ToolStripItem[] { btnGerarAmigoSecreto, toolStripSeparator3, btnLimparLista, btnSair });
            toolStrip_GerarAmigosSecretos.Location = new Point(0, 521);
            toolStrip_GerarAmigosSecretos.Name = "toolStrip_GerarAmigosSecretos";
            toolStrip_GerarAmigosSecretos.Size = new Size(940, 39);
            toolStrip_GerarAmigosSecretos.TabIndex = 2;
            toolStrip_GerarAmigosSecretos.Text = "toolStrip1";
            // 
            // btnGerarAmigoSecreto
            // 
            btnGerarAmigoSecreto.AutoSize = false;
            btnGerarAmigoSecreto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGerarAmigoSecreto.Image = Properties.Resources.disk_blue;
            btnGerarAmigoSecreto.ImageTransparentColor = Color.Magenta;
            btnGerarAmigoSecreto.Name = "btnGerarAmigoSecreto";
            btnGerarAmigoSecreto.Size = new Size(36, 36);
            btnGerarAmigoSecreto.Text = "Gerar Amigos Secretos";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // btnLimparLista
            // 
            btnLimparLista.AutoSize = false;
            btnLimparLista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLimparLista.Image = Properties.Resources.delete2;
            btnLimparLista.ImageTransparentColor = Color.Magenta;
            btnLimparLista.Name = "btnLimparLista";
            btnLimparLista.Size = new Size(36, 36);
            btnLimparLista.Text = "Limpar Listas";
            // 
            // btnSair
            // 
            btnSair.Alignment = ToolStripItemAlignment.Right;
            btnSair.AutoSize = false;
            btnSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSair.Image = Properties.Resources.exit;
            btnSair.ImageTransparentColor = Color.Magenta;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(36, 36);
            btnSair.Text = "Sair";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(447, 32);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(500, 477);
            treeView1.TabIndex = 1;
            // 
            // treeView_Amigos
            // 
            treeView_Amigos.Location = new Point(0, 159);
            treeView_Amigos.Name = "treeView_Amigos";
            treeView_Amigos.Size = new Size(400, 350);
            treeView_Amigos.TabIndex = 0;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(984, 661);
            Controls.Add(panel_GerarAmigoSecreto);
            Controls.Add(label_Menu);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto";
            FormClosed += Form_AmigoSecreto_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel_GerarAmigoSecreto.ResumeLayout(false);
            panel_GerarAmigoSecreto.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStripCadastrarAmigo.ResumeLayout(false);
            toolStripCadastrarAmigo.PerformLayout();
            toolStrip_GerarAmigosSecretos.ResumeLayout(false);
            toolStrip_GerarAmigosSecretos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem amigoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel_Msg;
        private ToolStripStatusLabel toolStripStatusLabel_MsgData;
        private ToolStripStatusLabel toolStripStatusLabel_Data;
        private ToolStripStatusLabel toolStripStatusLabel_MsgHora;
        private ToolStripStatusLabel toolStripStatusLabel_Hora;
        private System.Windows.Forms.Timer Timer_Menu;
        private Label label_Menu;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel panel_GerarAmigoSecreto;
        private TreeView treeView1;
        private TreeView treeView_Amigos;
        private ToolStrip toolStrip_GerarAmigosSecretos;
        private ToolStripButton btnGerarAmigoSecreto;
        private ToolStripButton btnLimparLista;
        private ToolStripButton btnSair;
        private Label label_ListaDeAmigos;
        private Label label_ListaAmigosSecreto;
        private TextBox textBox_Email;
        private Label label_Email;
        private TextBox textBox_Nome;
        private Label label_Nome;
        private ToolStripSeparator toolStripSeparator3;
        private Panel panel1;
        private ToolStrip toolStripCadastrarAmigo;
        private ToolStripButton btnAdicionar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnCancelar;
    }
}