namespace ProjetoMVCA12
{
    partial class FrmDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDados));
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_NomeMaeA12 = new System.Windows.Forms.TextBox();
            this.txt_nomeA12 = new System.Windows.Forms.TextBox();
            this.txt_CpfA12 = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(140, 214);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(161, 44);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_NomeMaeA12
            // 
            this.txt_NomeMaeA12.Location = new System.Drawing.Point(184, 136);
            this.txt_NomeMaeA12.Name = "txt_NomeMaeA12";
            this.txt_NomeMaeA12.Size = new System.Drawing.Size(238, 22);
            this.txt_NomeMaeA12.TabIndex = 2;
            // 
            // txt_nomeA12
            // 
            this.txt_nomeA12.Location = new System.Drawing.Point(184, 89);
            this.txt_nomeA12.Name = "txt_nomeA12";
            this.txt_nomeA12.Size = new System.Drawing.Size(238, 22);
            this.txt_nomeA12.TabIndex = 3;
            // 
            // txt_CpfA12
            // 
            this.txt_CpfA12.Location = new System.Drawing.Point(184, 42);
            this.txt_CpfA12.Name = "txt_CpfA12";
            this.txt_CpfA12.Size = new System.Drawing.Size(238, 22);
            this.txt_CpfA12.TabIndex = 4;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(36, 93);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(122, 18);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome Completo:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(36, 46);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(42, 18);
            this.lbl_cpf.TabIndex = 6;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mae.Location = new System.Drawing.Point(36, 140);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new System.Drawing.Size(106, 18);
            this.lbl_mae.TabIndex = 7;
            this.lbl_mae.Text = "Nome da Mãe:";
            // 
            // FrmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 286);
            this.Controls.Add(this.lbl_mae);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_CpfA12);
            this.Controls.Add(this.txt_nomeA12);
            this.Controls.Add(this.txt_NomeMaeA12);
            this.Controls.Add(this.btn_enviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_NomeMaeA12;
        private System.Windows.Forms.TextBox txt_nomeA12;
        private System.Windows.Forms.TextBox txt_CpfA12;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_mae;
    }
}