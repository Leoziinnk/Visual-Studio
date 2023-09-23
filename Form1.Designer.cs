namespace calculadora
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
            this.lbCALCULADORA = new System.Windows.Forms.Label();
            this.lbRetangulo = new System.Windows.Forms.Label();
            this.lbLadoA = new System.Windows.Forms.Label();
            this.lbLadoB = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbM2 = new System.Windows.Forms.Label();
            this.lbTamcor = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.ValorA = new System.Windows.Forms.TextBox();
            this.ValorB = new System.Windows.Forms.TextBox();
            this.rbPerímetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.btCalcula = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCALCULADORA
            // 
            this.lbCALCULADORA.AutoSize = true;
            this.lbCALCULADORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCALCULADORA.Location = new System.Drawing.Point(185, 9);
            this.lbCALCULADORA.Name = "lbCALCULADORA";
            this.lbCALCULADORA.Size = new System.Drawing.Size(269, 37);
            this.lbCALCULADORA.TabIndex = 0;
            this.lbCALCULADORA.Text = "CALCULADORA";
            // 
            // lbRetangulo
            // 
            this.lbRetangulo.AutoSize = true;
            this.lbRetangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetangulo.Location = new System.Drawing.Point(83, 93);
            this.lbRetangulo.Name = "lbRetangulo";
            this.lbRetangulo.Size = new System.Drawing.Size(75, 18);
            this.lbRetangulo.TabIndex = 1;
            this.lbRetangulo.Text = "Retângulo";
            this.lbRetangulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbLadoA
            // 
            this.lbLadoA.AutoSize = true;
            this.lbLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadoA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLadoA.Location = new System.Drawing.Point(440, 96);
            this.lbLadoA.Name = "lbLadoA";
            this.lbLadoA.Size = new System.Drawing.Size(62, 18);
            this.lbLadoA.TabIndex = 2;
            this.lbLadoA.Text = "Lado A :";
            this.lbLadoA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbLadoB
            // 
            this.lbLadoB.AutoSize = true;
            this.lbLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadoB.Location = new System.Drawing.Point(439, 127);
            this.lbLadoB.Name = "lbLadoB";
            this.lbLadoB.Size = new System.Drawing.Size(63, 18);
            this.lbLadoB.TabIndex = 3;
            this.lbLadoB.Text = "Lado B :";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.Location = new System.Drawing.Point(614, 104);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(18, 15);
            this.lbM.TabIndex = 4;
            this.lbM.Text = "m";
            // 
            // lbM2
            // 
            this.lbM2.AutoSize = true;
            this.lbM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM2.Location = new System.Drawing.Point(615, 135);
            this.lbM2.Name = "lbM2";
            this.lbM2.Size = new System.Drawing.Size(18, 15);
            this.lbM2.TabIndex = 5;
            this.lbM2.Text = "m";
            // 
            // lbTamcor
            // 
            this.lbTamcor.AutoSize = true;
            this.lbTamcor.Location = new System.Drawing.Point(290, 273);
            this.lbTamcor.Name = "lbTamcor";
            this.lbTamcor.Size = new System.Drawing.Size(25, 13);
            this.lbTamcor.TabIndex = 6;
            this.lbTamcor.Text = "???";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.Location = new System.Drawing.Point(284, 245);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(31, 16);
            this.lbArea.TabIndex = 7;
            this.lbArea.Text = "???";
            // 
            // ValorA
            // 
            this.ValorA.Location = new System.Drawing.Point(508, 97);
            this.ValorA.Name = "ValorA";
            this.ValorA.Size = new System.Drawing.Size(100, 20);
            this.ValorA.TabIndex = 8;
            // 
            // ValorB
            // 
            this.ValorB.Location = new System.Drawing.Point(508, 128);
            this.ValorB.Name = "ValorB";
            this.ValorB.Size = new System.Drawing.Size(100, 20);
            this.ValorB.TabIndex = 9;
            // 
            // rbPerímetro
            // 
            this.rbPerímetro.AutoSize = true;
            this.rbPerímetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerímetro.Location = new System.Drawing.Point(86, 114);
            this.rbPerímetro.Name = "rbPerímetro";
            this.rbPerímetro.Size = new System.Drawing.Size(91, 22);
            this.rbPerímetro.TabIndex = 10;
            this.rbPerímetro.TabStop = true;
            this.rbPerímetro.Text = "Perímetro";
            this.rbPerímetro.UseVisualStyleBackColor = true;
            this.rbPerímetro.CheckedChanged += new System.EventHandler(this.rbPerímetro_CheckedChanged);
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArea.Location = new System.Drawing.Point(86, 137);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(56, 22);
            this.rbArea.TabIndex = 11;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Área";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.rbArea_CheckedChanged);
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(264, 190);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(84, 28);
            this.btCalcula.TabIndex = 12;
            this.btCalcula.Text = "Calcular";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCor
            // 
            this.btCor.Location = new System.Drawing.Point(33, 322);
            this.btCor.Name = "btCor";
            this.btCor.Size = new System.Drawing.Size(75, 23);
            this.btCor.TabIndex = 15;
            this.btCor.Text = "Cor";
            this.btCor.UseVisualStyleBackColor = true;
            this.btCor.Click += new System.EventHandler(this.btCor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 349);
            this.Controls.Add(this.btCor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.rbArea);
            this.Controls.Add(this.rbPerímetro);
            this.Controls.Add(this.ValorB);
            this.Controls.Add(this.ValorA);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbTamcor);
            this.Controls.Add(this.lbM2);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbLadoB);
            this.Controls.Add(this.lbLadoA);
            this.Controls.Add(this.lbRetangulo);
            this.Controls.Add(this.lbCALCULADORA);
            this.Name = "Form1";
            this.Text = "calculadora ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCALCULADORA;
        private System.Windows.Forms.Label lbRetangulo;
        private System.Windows.Forms.Label lbLadoA;
        private System.Windows.Forms.Label lbLadoB;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbM2;
        private System.Windows.Forms.Label lbTamcor;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox ValorA;
        private System.Windows.Forms.TextBox ValorB;
        private System.Windows.Forms.RadioButton rbPerímetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btCor;
    }
}

