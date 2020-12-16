namespace ProyectoFinalForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOperación1 = new System.Windows.Forms.Button();
            this.btnOperación2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.numV1 = new System.Windows.Forms.NumericUpDown();
            this.numV2 = new System.Windows.Forms.NumericUpDown();
            this.numX1 = new System.Windows.Forms.NumericUpDown();
            this.numY1 = new System.Windows.Forms.NumericUpDown();
            this.numY2 = new System.Windows.Forms.NumericUpDown();
            this.numX2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "V1";
            // 
            // btnOperación1
            // 
            this.btnOperación1.Location = new System.Drawing.Point(310, 72);
            this.btnOperación1.Name = "btnOperación1";
            this.btnOperación1.Size = new System.Drawing.Size(75, 34);
            this.btnOperación1.TabIndex = 7;
            this.btnOperación1.Text = "Realizar Operación";
            this.btnOperación1.UseVisualStyleBackColor = true;
            this.btnOperación1.Click += new System.EventHandler(this.btnOperación1_Click);
            // 
            // btnOperación2
            // 
            this.btnOperación2.Location = new System.Drawing.Point(310, 184);
            this.btnOperación2.Name = "btnOperación2";
            this.btnOperación2.Size = new System.Drawing.Size(75, 37);
            this.btnOperación2.TabIndex = 8;
            this.btnOperación2.Text = "Realizar Operación";
            this.btnOperación2.UseVisualStyleBackColor = true;
            this.btnOperación2.Click += new System.EventHandler(this.btnOperación2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "V2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y2";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(391, 196);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(21, 13);
            this.lblResultado2.TabIndex = 14;
            this.lblResultado2.Text = "R=";
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(391, 83);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(21, 13);
            this.lblResultado1.TabIndex = 15;
            this.lblResultado1.Text = "R=";
            // 
            // numV1
            // 
            this.numV1.Location = new System.Drawing.Point(41, 76);
            this.numV1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numV1.Name = "numV1";
            this.numV1.Size = new System.Drawing.Size(80, 20);
            this.numV1.TabIndex = 18;
            // 
            // numV2
            // 
            this.numV2.Location = new System.Drawing.Point(208, 76);
            this.numV2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numV2.Name = "numV2";
            this.numV2.Size = new System.Drawing.Size(80, 20);
            this.numV2.TabIndex = 19;
            // 
            // numX1
            // 
            this.numX1.Location = new System.Drawing.Point(41, 169);
            this.numX1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numX1.Name = "numX1";
            this.numX1.Size = new System.Drawing.Size(80, 20);
            this.numX1.TabIndex = 20;
            // 
            // numY1
            // 
            this.numY1.Location = new System.Drawing.Point(208, 169);
            this.numY1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numY1.Name = "numY1";
            this.numY1.Size = new System.Drawing.Size(80, 20);
            this.numY1.TabIndex = 21;
            // 
            // numY2
            // 
            this.numY2.Location = new System.Drawing.Point(208, 206);
            this.numY2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numY2.Name = "numY2";
            this.numY2.Size = new System.Drawing.Size(80, 20);
            this.numY2.TabIndex = 22;
            // 
            // numX2
            // 
            this.numX2.Location = new System.Drawing.Point(41, 206);
            this.numX2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numX2.Name = "numX2";
            this.numX2.Size = new System.Drawing.Size(80, 20);
            this.numX2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Distancia Entre 2 puntos de una Recta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Distancia Entre 2 puntos del Plano Cartesiano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 277);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numX2);
            this.Controls.Add(this.numY2);
            this.Controls.Add(this.numY1);
            this.Controls.Add(this.numX1);
            this.Controls.Add(this.numV2);
            this.Controls.Add(this.numV1);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOperación2);
            this.Controls.Add(this.btnOperación1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOperación1;
        private System.Windows.Forms.Button btnOperación2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.NumericUpDown numV1;
        private System.Windows.Forms.NumericUpDown numV2;
        private System.Windows.Forms.NumericUpDown numX1;
        private System.Windows.Forms.NumericUpDown numY1;
        private System.Windows.Forms.NumericUpDown numY2;
        private System.Windows.Forms.NumericUpDown numX2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

