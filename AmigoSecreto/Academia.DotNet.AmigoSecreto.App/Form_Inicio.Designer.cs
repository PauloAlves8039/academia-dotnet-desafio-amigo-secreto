﻿namespace Academia.DotNet.AmigoSecreto.App
{
    partial class Form_Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            Timer_Inicio = new System.Windows.Forms.Timer(components);
            progressBar_Inicio = new ProgressBar();
            pictureBox_Inicio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Inicio).BeginInit();
            SuspendLayout();
            // 
            // Timer_Inicio
            // 
            Timer_Inicio.Enabled = true;
            Timer_Inicio.Tick += Timer_Inicio_Tick;
            // 
            // progressBar_Inicio
            // 
            progressBar_Inicio.Dock = DockStyle.Bottom;
            progressBar_Inicio.Location = new Point(0, 238);
            progressBar_Inicio.Name = "progressBar_Inicio";
            progressBar_Inicio.Size = new Size(384, 23);
            progressBar_Inicio.TabIndex = 0;
            // 
            // pictureBox_Inicio
            // 
            pictureBox_Inicio.Dock = DockStyle.Fill;
            pictureBox_Inicio.Image = Properties.Resources.presente;
            pictureBox_Inicio.Location = new Point(0, 0);
            pictureBox_Inicio.Name = "pictureBox_Inicio";
            pictureBox_Inicio.Size = new Size(384, 238);
            pictureBox_Inicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Inicio.TabIndex = 1;
            pictureBox_Inicio.TabStop = false;
            // 
            // Form_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(384, 261);
            Controls.Add(pictureBox_Inicio);
            Controls.Add(progressBar_Inicio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Inicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer_Inicio;
        private ProgressBar progressBar_Inicio;
        private PictureBox pictureBox_Inicio;
    }
}