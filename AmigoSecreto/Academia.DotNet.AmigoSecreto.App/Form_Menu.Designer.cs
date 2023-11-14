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
            SobreToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_Msg = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgData = new ToolStripStatusLabel();
            toolStripStatusLabel_Data = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgHora = new ToolStripStatusLabel();
            toolStripStatusLabel_Hora = new ToolStripStatusLabel();
            Timer_Menu = new System.Windows.Forms.Timer(components);
            label_Menu = new Label();
            panel_GerarAmigoSecreto = new Panel();
            listView_AmigosSecretos = new ListView();
            nome_amigo1 = new ColumnHeader();
            email_amigo1 = new ColumnHeader();
            nome_amigo2 = new ColumnHeader();
            email_amigo2 = new ColumnHeader();
            listView_Amigo = new ListView();
            nome = new ColumnHeader();
            email = new ColumnHeader();
            panel_AdicionarAmigo = new Panel();
            label_AdicionarAmigo = new Label();
            toolStripCadastrarAmigo = new ToolStrip();
            Btn_Adicionar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Btn_Cancelar = new ToolStripButton();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            label_Nome = new Label();
            label_Email = new Label();
            label_ListaAmigosSecreto = new Label();
            label_ListaDeAmigos = new Label();
            toolStrip_GerarAmigosSecretos = new ToolStrip();
            Btn_GerarAmigoSecreto = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Btn_LimparLista = new ToolStripButton();
            Btn_Sair = new ToolStripButton();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel_GerarAmigoSecreto.SuspendLayout();
            panel_AdicionarAmigo.SuspendLayout();
            toolStripCadastrarAmigo.SuspendLayout();
            toolStrip_GerarAmigosSecretos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { amigoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // amigoToolStripMenuItem
            // 
            amigoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SobreToolStripMenuItem });
            amigoToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            amigoToolStripMenuItem.ForeColor = Color.Black;
            amigoToolStripMenuItem.Name = "amigoToolStripMenuItem";
            amigoToolStripMenuItem.Size = new Size(55, 21);
            amigoToolStripMenuItem.Text = "Menu";
            // 
            // SobreToolStripMenuItem
            // 
            SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            SobreToolStripMenuItem.Size = new Size(111, 22);
            SobreToolStripMenuItem.Text = "Sobre";
            SobreToolStripMenuItem.Click += SobreToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.DeepSkyBlue;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Msg, toolStripStatusLabel_MsgData, toolStripStatusLabel_Data, toolStripStatusLabel_MsgHora, toolStripStatusLabel_Hora });
            statusStrip1.Location = new Point(0, 679);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1084, 22);
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
            label_Menu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_Menu.ForeColor = Color.White;
            label_Menu.Location = new Point(408, 37);
            label_Menu.Name = "label_Menu";
            label_Menu.Size = new Size(182, 32);
            label_Menu.TabIndex = 7;
            label_Menu.Text = "Amigo Secreto";
            // 
            // panel_GerarAmigoSecreto
            // 
            panel_GerarAmigoSecreto.Controls.Add(listView_AmigosSecretos);
            panel_GerarAmigoSecreto.Controls.Add(listView_Amigo);
            panel_GerarAmigoSecreto.Controls.Add(panel_AdicionarAmigo);
            panel_GerarAmigoSecreto.Controls.Add(label_ListaAmigosSecreto);
            panel_GerarAmigoSecreto.Controls.Add(label_ListaDeAmigos);
            panel_GerarAmigoSecreto.Controls.Add(toolStrip_GerarAmigosSecretos);
            panel_GerarAmigoSecreto.Location = new Point(12, 84);
            panel_GerarAmigoSecreto.Name = "panel_GerarAmigoSecreto";
            panel_GerarAmigoSecreto.Size = new Size(1060, 585);
            panel_GerarAmigoSecreto.TabIndex = 9;
            // 
            // listView_AmigosSecretos
            // 
            listView_AmigosSecretos.Columns.AddRange(new ColumnHeader[] { nome_amigo1, email_amigo1, nome_amigo2, email_amigo2 });
            listView_AmigosSecretos.Location = new Point(460, 61);
            listView_AmigosSecretos.Name = "listView_AmigosSecretos";
            listView_AmigosSecretos.Size = new Size(600, 465);
            listView_AmigosSecretos.TabIndex = 11;
            listView_AmigosSecretos.UseCompatibleStateImageBehavior = false;
            listView_AmigosSecretos.View = View.Details;
            // 
            // nome_amigo1
            // 
            nome_amigo1.Text = "Nome";
            nome_amigo1.Width = 128;
            // 
            // email_amigo1
            // 
            email_amigo1.Text = "Email";
            email_amigo1.Width = 170;
            // 
            // nome_amigo2
            // 
            nome_amigo2.Text = "Nome";
            nome_amigo2.Width = 128;
            // 
            // email_amigo2
            // 
            email_amigo2.Text = "Email";
            email_amigo2.Width = 170;
            // 
            // listView_Amigo
            // 
            listView_Amigo.Alignment = ListViewAlignment.Default;
            listView_Amigo.Columns.AddRange(new ColumnHeader[] { nome, email });
            listView_Amigo.Location = new Point(0, 226);
            listView_Amigo.Name = "listView_Amigo";
            listView_Amigo.Size = new Size(420, 300);
            listView_Amigo.TabIndex = 10;
            listView_Amigo.UseCompatibleStateImageBehavior = false;
            listView_Amigo.View = View.Details;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 207;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 209;
            // 
            // panel_AdicionarAmigo
            // 
            panel_AdicionarAmigo.Controls.Add(label_AdicionarAmigo);
            panel_AdicionarAmigo.Controls.Add(toolStripCadastrarAmigo);
            panel_AdicionarAmigo.Controls.Add(textBox_Nome);
            panel_AdicionarAmigo.Controls.Add(textBox_Email);
            panel_AdicionarAmigo.Controls.Add(label_Nome);
            panel_AdicionarAmigo.Controls.Add(label_Email);
            panel_AdicionarAmigo.Location = new Point(3, 15);
            panel_AdicionarAmigo.Name = "panel_AdicionarAmigo";
            panel_AdicionarAmigo.Size = new Size(420, 160);
            panel_AdicionarAmigo.TabIndex = 9;
            // 
            // label_AdicionarAmigo
            // 
            label_AdicionarAmigo.AutoSize = true;
            label_AdicionarAmigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_AdicionarAmigo.ForeColor = Color.White;
            label_AdicionarAmigo.Location = new Point(141, 12);
            label_AdicionarAmigo.Name = "label_AdicionarAmigo";
            label_AdicionarAmigo.Size = new Size(139, 21);
            label_AdicionarAmigo.TabIndex = 10;
            label_AdicionarAmigo.Text = "Adicionar Amigo";
            // 
            // toolStripCadastrarAmigo
            // 
            toolStripCadastrarAmigo.BackColor = Color.DeepSkyBlue;
            toolStripCadastrarAmigo.Dock = DockStyle.Bottom;
            toolStripCadastrarAmigo.ImageScalingSize = new Size(40, 40);
            toolStripCadastrarAmigo.Items.AddRange(new ToolStripItem[] { Btn_Adicionar, toolStripSeparator4, Btn_Cancelar });
            toolStripCadastrarAmigo.Location = new Point(0, 117);
            toolStripCadastrarAmigo.Name = "toolStripCadastrarAmigo";
            toolStripCadastrarAmigo.Size = new Size(420, 43);
            toolStripCadastrarAmigo.TabIndex = 9;
            toolStripCadastrarAmigo.Text = "toolStrip1";
            // 
            // Btn_Adicionar
            // 
            Btn_Adicionar.AutoSize = false;
            Btn_Adicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Adicionar.Image = (Image)resources.GetObject("Btn_Adicionar.Image");
            Btn_Adicionar.ImageTransparentColor = Color.Magenta;
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(40, 40);
            Btn_Adicionar.Text = "Adicionar Amigo";
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 43);
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.AutoSize = false;
            Btn_Cancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Cancelar.Image = (Image)resources.GetObject("Btn_Cancelar.Image");
            Btn_Cancelar.ImageTransparentColor = Color.Magenta;
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(40, 40);
            Btn_Cancelar.Text = "Limpar Campos";
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(65, 46);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(355, 23);
            textBox_Nome.TabIndex = 6;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(65, 78);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(355, 23);
            textBox_Email.TabIndex = 8;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.ForeColor = Color.White;
            label_Nome.Location = new Point(-1, 49);
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
            label_Email.Location = new Point(-1, 81);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(51, 20);
            label_Email.TabIndex = 7;
            label_Email.Text = "Email:";
            // 
            // label_ListaAmigosSecreto
            // 
            label_ListaAmigosSecreto.AutoSize = true;
            label_ListaAmigosSecreto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ListaAmigosSecreto.ForeColor = Color.White;
            label_ListaAmigosSecreto.Location = new Point(685, 27);
            label_ListaAmigosSecreto.Name = "label_ListaAmigosSecreto";
            label_ListaAmigosSecreto.Size = new Size(140, 21);
            label_ListaAmigosSecreto.TabIndex = 4;
            label_ListaAmigosSecreto.Text = "Pares  de Amigos";
            // 
            // label_ListaDeAmigos
            // 
            label_ListaDeAmigos.AutoSize = true;
            label_ListaDeAmigos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ListaDeAmigos.ForeColor = Color.White;
            label_ListaDeAmigos.Location = new Point(134, 188);
            label_ListaDeAmigos.Name = "label_ListaDeAmigos";
            label_ListaDeAmigos.Size = new Size(165, 21);
            label_ListaDeAmigos.TabIndex = 3;
            label_ListaDeAmigos.Text = "Amigos Cadastrados";
            // 
            // toolStrip_GerarAmigosSecretos
            // 
            toolStrip_GerarAmigosSecretos.BackColor = Color.DeepSkyBlue;
            toolStrip_GerarAmigosSecretos.Dock = DockStyle.Bottom;
            toolStrip_GerarAmigosSecretos.ImageScalingSize = new Size(40, 40);
            toolStrip_GerarAmigosSecretos.Items.AddRange(new ToolStripItem[] { Btn_GerarAmigoSecreto, toolStripSeparator3, Btn_LimparLista, Btn_Sair });
            toolStrip_GerarAmigosSecretos.Location = new Point(0, 542);
            toolStrip_GerarAmigosSecretos.Name = "toolStrip_GerarAmigosSecretos";
            toolStrip_GerarAmigosSecretos.Size = new Size(1060, 43);
            toolStrip_GerarAmigosSecretos.TabIndex = 2;
            toolStrip_GerarAmigosSecretos.Text = "toolStrip1";
            // 
            // Btn_GerarAmigoSecreto
            // 
            Btn_GerarAmigoSecreto.AutoSize = false;
            Btn_GerarAmigoSecreto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_GerarAmigoSecreto.Image = (Image)resources.GetObject("Btn_GerarAmigoSecreto.Image");
            Btn_GerarAmigoSecreto.ImageTransparentColor = Color.Magenta;
            Btn_GerarAmigoSecreto.Name = "Btn_GerarAmigoSecreto";
            Btn_GerarAmigoSecreto.Size = new Size(40, 40);
            Btn_GerarAmigoSecreto.Text = "Gerar Amigos Secretos";
            Btn_GerarAmigoSecreto.Click += Btn_GerarAmigoSecreto_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 43);
            // 
            // Btn_LimparLista
            // 
            Btn_LimparLista.AutoSize = false;
            Btn_LimparLista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_LimparLista.Image = (Image)resources.GetObject("Btn_LimparLista.Image");
            Btn_LimparLista.ImageTransparentColor = Color.Magenta;
            Btn_LimparLista.Name = "Btn_LimparLista";
            Btn_LimparLista.Size = new Size(40, 40);
            Btn_LimparLista.Text = "Limpar Listas";
            Btn_LimparLista.Click += Btn_LimparLista_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Alignment = ToolStripItemAlignment.Right;
            Btn_Sair.AutoSize = false;
            Btn_Sair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Sair.Image = (Image)resources.GetObject("Btn_Sair.Image");
            Btn_Sair.ImageTransparentColor = Color.Magenta;
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(40, 40);
            Btn_Sair.Text = "Sair";
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.amigos_secretos;
            pictureBox1.Location = new Point(587, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1084, 701);
            Controls.Add(pictureBox1);
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
            panel_AdicionarAmigo.ResumeLayout(false);
            panel_AdicionarAmigo.PerformLayout();
            toolStripCadastrarAmigo.ResumeLayout(false);
            toolStripCadastrarAmigo.PerformLayout();
            toolStrip_GerarAmigosSecretos.ResumeLayout(false);
            toolStrip_GerarAmigosSecretos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripMenuItem SobreToolStripMenuItem;
        private Panel panel_GerarAmigoSecreto;
        private ToolStrip toolStrip_GerarAmigosSecretos;
        private ToolStripButton Btn_GerarAmigoSecreto;
        private ToolStripButton Btn_LimparLista;
        private ToolStripButton Btn_Sair;
        private Label label_ListaDeAmigos;
        private Label label_ListaAmigosSecreto;
        private TextBox textBox_Email;
        private Label label_Email;
        private TextBox textBox_Nome;
        private Label label_Nome;
        private ToolStripSeparator toolStripSeparator3;
        private Panel panel_AdicionarAmigo;
        private ToolStrip toolStripCadastrarAmigo;
        private ToolStripButton Btn_Adicionar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton Btn_Cancelar;
        private ListView listView_Amigo;
        private ColumnHeader nome;
        private ColumnHeader email;
        private ListView listView_AmigosSecretos;
        private ColumnHeader nome_amigo1;
        private ColumnHeader email_amigo1;
        private ColumnHeader nome_amigo2;
        private ColumnHeader email_amigo2;
        private PictureBox pictureBox1;
        private Label label_AdicionarAmigo;
    }
}