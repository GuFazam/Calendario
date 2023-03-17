namespace Calendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxDataInicial = new System.Windows.Forms.TextBox();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPegarData = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDataInicial2 = new System.Windows.Forms.TextBox();
            this.textBoxDataFinal2 = new System.Windows.Forms.TextBox();
            this.textBoxDataAtual2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(53, 57);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TabStop = false;
            // 
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataInicial.Location = new System.Drawing.Point(418, 57);
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataInicial.TabIndex = 1;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataFinal.Location = new System.Drawing.Point(418, 95);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataFinal.TabIndex = 2;
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataAtual.Location = new System.Drawing.Point(418, 135);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataAtual.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data inicial: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Atual: ";
            // 
            // btnPegarData
            // 
            this.btnPegarData.BackColor = System.Drawing.Color.Turquoise;
            this.btnPegarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPegarData.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnPegarData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnPegarData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnPegarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegarData.Location = new System.Drawing.Point(312, 161);
            this.btnPegarData.Name = "btnPegarData";
            this.btnPegarData.Size = new System.Drawing.Size(206, 27);
            this.btnPegarData.TabIndex = 7;
            this.btnPegarData.Text = "Pegar Data";
            this.btnPegarData.UseVisualStyleBackColor = false;
            this.btnPegarData.Click += new System.EventHandler(this.btnPegarData_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Turquoise;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(312, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(206, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Inicial: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Final: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Atual: ";
            // 
            // textBoxDataInicial2
            // 
            this.textBoxDataInicial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataInicial2.Location = new System.Drawing.Point(153, 248);
            this.textBoxDataInicial2.Name = "textBoxDataInicial2";
            this.textBoxDataInicial2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataInicial2.TabIndex = 12;
            // 
            // textBoxDataFinal2
            // 
            this.textBoxDataFinal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataFinal2.Location = new System.Drawing.Point(153, 286);
            this.textBoxDataFinal2.Name = "textBoxDataFinal2";
            this.textBoxDataFinal2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataFinal2.TabIndex = 13;
            // 
            // textBoxDataAtual2
            // 
            this.textBoxDataAtual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataAtual2.Location = new System.Drawing.Point(153, 323);
            this.textBoxDataAtual2.Name = "textBoxDataAtual2";
            this.textBoxDataAtual2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataAtual2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 396);
            this.Controls.Add(this.textBoxDataAtual2);
            this.Controls.Add(this.textBoxDataFinal2);
            this.Controls.Add(this.textBoxDataInicial2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPegarData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDataAtual);
            this.Controls.Add(this.textBoxDataFinal);
            this.Controls.Add(this.textBoxDataInicial);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Calendário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxDataInicial;
        private System.Windows.Forms.TextBox textBoxDataFinal;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPegarData;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDataInicial2;
        private System.Windows.Forms.TextBox textBoxDataFinal2;
        private System.Windows.Forms.TextBox textBoxDataAtual2;
    }
}

