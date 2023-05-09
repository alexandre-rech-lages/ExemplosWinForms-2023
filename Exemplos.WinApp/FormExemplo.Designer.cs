namespace Exemplos.WinApp
{
    partial class FormExemplo
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
            labelNome = new Label();
            txtNome = new TextBox();
            btnGravar = new Button();
            listAtividades = new ListBox();
            btnRemover = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.Location = new Point(26, 26);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(78, 26);
            labelNome.TabIndex = 0;
            labelNome.Text = "Atividades:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.LightYellow;
            txtNome.Location = new Point(26, 55);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 40);
            txtNome.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(346, 54);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // listAtividades
            // 
            listAtividades.FormattingEnabled = true;
            listAtividades.ItemHeight = 15;
            listAtividades.Location = new Point(28, 160);
            listAtividades.Name = "listAtividades";
            listAtividades.Size = new Size(393, 214);
            listAtividades.TabIndex = 3;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(29, 119);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // FormExemplo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 394);
            Controls.Add(btnRemover);
            Controls.Add(listAtividades);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormExemplo";
            ShowIcon = false;
            Text = "Cadastro de Atividades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox txtNome;
        private Button btnGravar;
        private ListBox listAtividades;
        private Button btnRemover;
    }
}