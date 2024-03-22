
namespace Teste
{
    partial class Form1
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
            this.tb_Nota1 = new System.Windows.Forms.TextBox();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.tb_Nota2 = new System.Windows.Forms.TextBox();
            this.tb_Nota3 = new System.Windows.Forms.TextBox();
            this.tb_Nota4 = new System.Windows.Forms.TextBox();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Nota1
            // 
            this.tb_Nota1.Location = new System.Drawing.Point(42, 36);
            this.tb_Nota1.Name = "tb_Nota1";
            this.tb_Nota1.Size = new System.Drawing.Size(81, 20);
            this.tb_Nota1.TabIndex = 0;
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calcular.Location = new System.Drawing.Point(32, 239);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(91, 61);
            this.bt_Calcular.TabIndex = 1;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // tb_Nota2
            // 
            this.tb_Nota2.Location = new System.Drawing.Point(42, 86);
            this.tb_Nota2.Name = "tb_Nota2";
            this.tb_Nota2.Size = new System.Drawing.Size(81, 20);
            this.tb_Nota2.TabIndex = 2;
            // 
            // tb_Nota3
            // 
            this.tb_Nota3.Location = new System.Drawing.Point(42, 138);
            this.tb_Nota3.Name = "tb_Nota3";
            this.tb_Nota3.Size = new System.Drawing.Size(81, 20);
            this.tb_Nota3.TabIndex = 3;
            // 
            // tb_Nota4
            // 
            this.tb_Nota4.Location = new System.Drawing.Point(42, 188);
            this.tb_Nota4.Name = "tb_Nota4";
            this.tb_Nota4.Size = new System.Drawing.Size(81, 20);
            this.tb_Nota4.TabIndex = 4;
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Resultado.Location = new System.Drawing.Point(12, 336);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(20, 16);
            this.lb_Resultado.TabIndex = 5;
            this.lb_Resultado.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 381);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.tb_Nota4);
            this.Controls.Add(this.tb_Nota3);
            this.Controls.Add(this.tb_Nota2);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.tb_Nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Nota1;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.TextBox tb_Nota2;
        private System.Windows.Forms.TextBox tb_Nota3;
        private System.Windows.Forms.TextBox tb_Nota4;
        private System.Windows.Forms.Label lb_Resultado;
    }
}

