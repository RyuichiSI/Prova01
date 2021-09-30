
namespace Prova01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtAdição = new System.Windows.Forms.RadioButton();
            this.rbtSubtração = new System.Windows.Forms.RadioButton();
            this.rbtMult = new System.Windows.Forms.RadioButton();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(222, 67);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 29);
            this.txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(222, 124);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 29);
            this.txtN2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escolha a operação desejada : ";
            // 
            // rbtAdição
            // 
            this.rbtAdição.AutoSize = true;
            this.rbtAdição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAdição.Location = new System.Drawing.Point(290, 180);
            this.rbtAdição.Name = "rbtAdição";
            this.rbtAdição.Size = new System.Drawing.Size(76, 24);
            this.rbtAdição.TabIndex = 5;
            this.rbtAdição.TabStop = true;
            this.rbtAdição.Text = "Adição";
            this.rbtAdição.UseVisualStyleBackColor = true;
            this.rbtAdição.CheckedChanged += new System.EventHandler(this.rbtAdição_CheckedChanged);
            // 
            // rbtSubtração
            // 
            this.rbtSubtração.AutoSize = true;
            this.rbtSubtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSubtração.Location = new System.Drawing.Point(290, 201);
            this.rbtSubtração.Name = "rbtSubtração";
            this.rbtSubtração.Size = new System.Drawing.Size(101, 24);
            this.rbtSubtração.TabIndex = 6;
            this.rbtSubtração.TabStop = true;
            this.rbtSubtração.Text = "Subtração";
            this.rbtSubtração.UseVisualStyleBackColor = true;
            this.rbtSubtração.CheckedChanged += new System.EventHandler(this.rbtSubtração_CheckedChanged);
            // 
            // rbtMult
            // 
            this.rbtMult.AutoSize = true;
            this.rbtMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMult.Location = new System.Drawing.Point(290, 224);
            this.rbtMult.Name = "rbtMult";
            this.rbtMult.Size = new System.Drawing.Size(118, 24);
            this.rbtMult.TabIndex = 7;
            this.rbtMult.TabStop = true;
            this.rbtMult.Text = "Multiplicação";
            this.rbtMult.UseVisualStyleBackColor = true;
            this.rbtMult.CheckedChanged += new System.EventHandler(this.rbtMult_CheckedChanged);
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDiv.Location = new System.Drawing.Point(290, 247);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(78, 24);
            this.rbtDiv.TabIndex = 8;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "Divisão";
            this.rbtDiv.UseVisualStyleBackColor = true;
            this.rbtDiv.CheckedChanged += new System.EventHandler(this.rbtDiv_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado : ";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(199, 296);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 29);
            this.txtResultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtDiv);
            this.Controls.Add(this.rbtMult);
            this.Controls.Add(this.rbtSubtração);
            this.Controls.Add(this.rbtAdição);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtAdição;
        private System.Windows.Forms.RadioButton rbtSubtração;
        private System.Windows.Forms.RadioButton rbtMult;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

