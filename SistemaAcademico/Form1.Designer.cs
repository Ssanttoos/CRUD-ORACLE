namespace SistemaAcademico
{
    partial class btndelete
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvalunos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "telefone:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(45, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(181, 9);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(331, 9);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(447, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "salvar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvalunos
            // 
            this.dgvalunos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalunos.Location = new System.Drawing.Point(12, 35);
            this.dgvalunos.Name = "dgvalunos";
            this.dgvalunos.Size = new System.Drawing.Size(458, 202);
            this.dgvalunos.TabIndex = 7;
            this.dgvalunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalunos_CellClick);
            this.dgvalunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalunos_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(528, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndelete
            // 
            this.ClientSize = new System.Drawing.Size(773, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvalunos);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "btndelete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvalunos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
    }
}

