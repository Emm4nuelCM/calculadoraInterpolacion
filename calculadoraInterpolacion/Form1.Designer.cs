﻿namespace calculadoraInterpolacion
{
    partial class Form1
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
            this.valoresBox = new System.Windows.Forms.GroupBox();
            this.buttCalcular = new System.Windows.Forms.Button();
            this.buttLimpiar = new System.Windows.Forms.Button();
            this.FX2Box = new System.Windows.Forms.TextBox();
            this.FX1Box = new System.Windows.Forms.TextBox();
            this.FX0Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.XBox = new System.Windows.Forms.TextBox();
            this.X2Box = new System.Windows.Forms.TextBox();
            this.X1Box = new System.Windows.Forms.TextBox();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opcionesBox = new System.Windows.Forms.GroupBox();
            this.otroBox = new System.Windows.Forms.GroupBox();
            this.errorRelativoCheck = new System.Windows.Forms.CheckBox();
            this.tipoResultadoBox = new System.Windows.Forms.GroupBox();
            this.decimalCheck = new System.Windows.Forms.CheckBox();
            this.redondeadoCheck = new System.Windows.Forms.CheckBox();
            this.naturalCheck = new System.Windows.Forms.CheckBox();
            this.interpolacionBox = new System.Windows.Forms.GroupBox();
            this.linealCheck = new System.Windows.Forms.CheckBox();
            this.cuadraticaCheck = new System.Windows.Forms.CheckBox();
            this.resultadosBox = new System.Windows.Forms.GroupBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.valoresBox.SuspendLayout();
            this.opcionesBox.SuspendLayout();
            this.otroBox.SuspendLayout();
            this.tipoResultadoBox.SuspendLayout();
            this.interpolacionBox.SuspendLayout();
            this.resultadosBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // valoresBox
            // 
            this.valoresBox.Controls.Add(this.buttCalcular);
            this.valoresBox.Controls.Add(this.buttLimpiar);
            this.valoresBox.Controls.Add(this.FX2Box);
            this.valoresBox.Controls.Add(this.FX1Box);
            this.valoresBox.Controls.Add(this.FX0Box);
            this.valoresBox.Controls.Add(this.label12);
            this.valoresBox.Controls.Add(this.label10);
            this.valoresBox.Controls.Add(this.label13);
            this.valoresBox.Controls.Add(this.label11);
            this.valoresBox.Controls.Add(this.label7);
            this.valoresBox.Controls.Add(this.label9);
            this.valoresBox.Controls.Add(this.XBox);
            this.valoresBox.Controls.Add(this.X2Box);
            this.valoresBox.Controls.Add(this.X1Box);
            this.valoresBox.Controls.Add(this.X0Box);
            this.valoresBox.Controls.Add(this.label8);
            this.valoresBox.Controls.Add(this.label5);
            this.valoresBox.Controls.Add(this.label6);
            this.valoresBox.Controls.Add(this.label3);
            this.valoresBox.Controls.Add(this.label4);
            this.valoresBox.Controls.Add(this.label2);
            this.valoresBox.Controls.Add(this.label1);
            this.valoresBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.valoresBox.Location = new System.Drawing.Point(12, 12);
            this.valoresBox.Name = "valoresBox";
            this.valoresBox.Size = new System.Drawing.Size(404, 176);
            this.valoresBox.TabIndex = 0;
            this.valoresBox.TabStop = false;
            this.valoresBox.Text = "VALORES";
            // 
            // buttCalcular
            // 
            this.buttCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttCalcular.Location = new System.Drawing.Point(295, 135);
            this.buttCalcular.Name = "buttCalcular";
            this.buttCalcular.Size = new System.Drawing.Size(88, 31);
            this.buttCalcular.TabIndex = 19;
            this.buttCalcular.Text = "CALCULAR";
            this.buttCalcular.UseVisualStyleBackColor = true;
            this.buttCalcular.Click += new System.EventHandler(this.buttCalcular_Click);
            // 
            // buttLimpiar
            // 
            this.buttLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttLimpiar.Location = new System.Drawing.Point(194, 136);
            this.buttLimpiar.Name = "buttLimpiar";
            this.buttLimpiar.Size = new System.Drawing.Size(88, 31);
            this.buttLimpiar.TabIndex = 18;
            this.buttLimpiar.Text = "LIMPIAR";
            this.buttLimpiar.UseVisualStyleBackColor = true;
            this.buttLimpiar.Click += new System.EventHandler(this.buttLimpiar_Click);
            // 
            // FX2Box
            // 
            this.FX2Box.Location = new System.Drawing.Point(283, 106);
            this.FX2Box.Multiline = true;
            this.FX2Box.Name = "FX2Box";
            this.FX2Box.Size = new System.Drawing.Size(100, 23);
            this.FX2Box.TabIndex = 17;
            // 
            // FX1Box
            // 
            this.FX1Box.Location = new System.Drawing.Point(283, 70);
            this.FX1Box.Multiline = true;
            this.FX1Box.Name = "FX1Box";
            this.FX1Box.Size = new System.Drawing.Size(100, 23);
            this.FX1Box.TabIndex = 16;
            // 
            // FX0Box
            // 
            this.FX0Box.Location = new System.Drawing.Point(283, 32);
            this.FX0Box.Multiline = true;
            this.FX0Box.Name = "FX0Box";
            this.FX0Box.Size = new System.Drawing.Size(100, 23);
            this.FX0Box.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(229, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(229, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(194, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 30);
            this.label13.TabIndex = 13;
            this.label13.Text = "f(X   )=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(194, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "f(X   )=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(229, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(194, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "f(X   )=";
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(78, 137);
            this.XBox.Multiline = true;
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(100, 23);
            this.XBox.TabIndex = 10;
            // 
            // X2Box
            // 
            this.X2Box.Location = new System.Drawing.Point(78, 103);
            this.X2Box.Multiline = true;
            this.X2Box.Name = "X2Box";
            this.X2Box.Size = new System.Drawing.Size(100, 23);
            this.X2Box.TabIndex = 9;
            // 
            // X1Box
            // 
            this.X1Box.Location = new System.Drawing.Point(78, 70);
            this.X1Box.Multiline = true;
            this.X1Box.Name = "X1Box";
            this.X1Box.Size = new System.Drawing.Size(100, 23);
            this.X1Box.TabIndex = 8;
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(78, 32);
            this.X0Box.Multiline = true;
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(100, 23);
            this.X0Box.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "X =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "X   =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "X   =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "X   =";
            // 
            // opcionesBox
            // 
            this.opcionesBox.Controls.Add(this.otroBox);
            this.opcionesBox.Controls.Add(this.tipoResultadoBox);
            this.opcionesBox.Controls.Add(this.interpolacionBox);
            this.opcionesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcionesBox.Location = new System.Drawing.Point(12, 194);
            this.opcionesBox.Name = "opcionesBox";
            this.opcionesBox.Size = new System.Drawing.Size(166, 271);
            this.opcionesBox.TabIndex = 1;
            this.opcionesBox.TabStop = false;
            this.opcionesBox.Text = "OPCIONES";
            // 
            // otroBox
            // 
            this.otroBox.Controls.Add(this.errorRelativoCheck);
            this.otroBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otroBox.Location = new System.Drawing.Point(11, 196);
            this.otroBox.Name = "otroBox";
            this.otroBox.Size = new System.Drawing.Size(144, 66);
            this.otroBox.TabIndex = 3;
            this.otroBox.TabStop = false;
            this.otroBox.Text = "OTRO";
            // 
            // errorRelativoCheck
            // 
            this.errorRelativoCheck.AutoSize = true;
            this.errorRelativoCheck.Location = new System.Drawing.Point(13, 21);
            this.errorRelativoCheck.Name = "errorRelativoCheck";
            this.errorRelativoCheck.Size = new System.Drawing.Size(124, 30);
            this.errorRelativoCheck.TabIndex = 0;
            this.errorRelativoCheck.Text = "Calcular error \r\nrelativo porcentual";
            this.errorRelativoCheck.UseVisualStyleBackColor = true;
            // 
            // tipoResultadoBox
            // 
            this.tipoResultadoBox.Controls.Add(this.decimalCheck);
            this.tipoResultadoBox.Controls.Add(this.redondeadoCheck);
            this.tipoResultadoBox.Controls.Add(this.naturalCheck);
            this.tipoResultadoBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipoResultadoBox.Location = new System.Drawing.Point(11, 100);
            this.tipoResultadoBox.Name = "tipoResultadoBox";
            this.tipoResultadoBox.Size = new System.Drawing.Size(117, 90);
            this.tipoResultadoBox.TabIndex = 3;
            this.tipoResultadoBox.TabStop = false;
            this.tipoResultadoBox.Text = "TIPO RESULTADO";
            // 
            // decimalCheck
            // 
            this.decimalCheck.AutoSize = true;
            this.decimalCheck.Location = new System.Drawing.Point(13, 67);
            this.decimalCheck.Name = "decimalCheck";
            this.decimalCheck.Size = new System.Drawing.Size(87, 17);
            this.decimalCheck.TabIndex = 2;
            this.decimalCheck.Text = "3 Decimales";
            this.decimalCheck.UseVisualStyleBackColor = true;
            // 
            // redondeadoCheck
            // 
            this.redondeadoCheck.AutoSize = true;
            this.redondeadoCheck.Location = new System.Drawing.Point(13, 44);
            this.redondeadoCheck.Name = "redondeadoCheck";
            this.redondeadoCheck.Size = new System.Drawing.Size(93, 17);
            this.redondeadoCheck.TabIndex = 1;
            this.redondeadoCheck.Text = "Redondeado";
            this.redondeadoCheck.UseVisualStyleBackColor = true;
            // 
            // naturalCheck
            // 
            this.naturalCheck.AutoSize = true;
            this.naturalCheck.Location = new System.Drawing.Point(13, 21);
            this.naturalCheck.Name = "naturalCheck";
            this.naturalCheck.Size = new System.Drawing.Size(65, 17);
            this.naturalCheck.TabIndex = 0;
            this.naturalCheck.Text = "Natural";
            this.naturalCheck.UseVisualStyleBackColor = true;
            // 
            // interpolacionBox
            // 
            this.interpolacionBox.Controls.Add(this.linealCheck);
            this.interpolacionBox.Controls.Add(this.cuadraticaCheck);
            this.interpolacionBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.interpolacionBox.Location = new System.Drawing.Point(11, 28);
            this.interpolacionBox.Name = "interpolacionBox";
            this.interpolacionBox.Size = new System.Drawing.Size(108, 66);
            this.interpolacionBox.TabIndex = 2;
            this.interpolacionBox.TabStop = false;
            this.interpolacionBox.Text = "INTERPOLACION";
            // 
            // linealCheck
            // 
            this.linealCheck.AutoSize = true;
            this.linealCheck.Location = new System.Drawing.Point(13, 44);
            this.linealCheck.Name = "linealCheck";
            this.linealCheck.Size = new System.Drawing.Size(57, 17);
            this.linealCheck.TabIndex = 1;
            this.linealCheck.Text = "Lineal";
            this.linealCheck.UseVisualStyleBackColor = true;
            this.linealCheck.CheckedChanged += new System.EventHandler(this.linealCheck_CheckedChanged);
            // 
            // cuadraticaCheck
            // 
            this.cuadraticaCheck.AutoSize = true;
            this.cuadraticaCheck.Location = new System.Drawing.Point(13, 21);
            this.cuadraticaCheck.Name = "cuadraticaCheck";
            this.cuadraticaCheck.Size = new System.Drawing.Size(81, 17);
            this.cuadraticaCheck.TabIndex = 0;
            this.cuadraticaCheck.Text = "Cuadratica";
            this.cuadraticaCheck.UseVisualStyleBackColor = true;
            this.cuadraticaCheck.CheckedChanged += new System.EventHandler(this.cuadraticaCheck_CheckedChanged);
            // 
            // resultadosBox
            // 
            this.resultadosBox.Controls.Add(this.tbDisplay);
            this.resultadosBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadosBox.Location = new System.Drawing.Point(195, 194);
            this.resultadosBox.Name = "resultadosBox";
            this.resultadosBox.Size = new System.Drawing.Size(384, 271);
            this.resultadosBox.TabIndex = 2;
            this.resultadosBox.TabStop = false;
            this.resultadosBox.Text = "RESULTADOS";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(27, 41);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(289, 120);
            this.tbDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 471);
            this.Controls.Add(this.resultadosBox);
            this.Controls.Add(this.opcionesBox);
            this.Controls.Add(this.valoresBox);
            this.Name = "Form1";
            this.Text = "Calculadora Interpolacion Lineal y Cuadratica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.valoresBox.ResumeLayout(false);
            this.valoresBox.PerformLayout();
            this.opcionesBox.ResumeLayout(false);
            this.otroBox.ResumeLayout(false);
            this.otroBox.PerformLayout();
            this.tipoResultadoBox.ResumeLayout(false);
            this.tipoResultadoBox.PerformLayout();
            this.interpolacionBox.ResumeLayout(false);
            this.interpolacionBox.PerformLayout();
            this.resultadosBox.ResumeLayout(false);
            this.resultadosBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox valoresBox;
        private TextBox FX2Box;
        private TextBox FX1Box;
        private TextBox FX0Box;
        private Label label12;
        private Label label10;
        private Label label13;
        private Label label11;
        private Label label7;
        private Label label9;
        private TextBox XBox;
        private TextBox X2Box;
        private TextBox X1Box;
        private TextBox X0Box;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button buttCalcular;
        private Button buttLimpiar;
        private GroupBox opcionesBox;
        private GroupBox otroBox;
        private CheckBox errorRelativoCheck;
        private GroupBox tipoResultadoBox;
        private CheckBox decimalCheck;
        private CheckBox redondeadoCheck;
        private CheckBox naturalCheck;
        private GroupBox interpolacionBox;
        private CheckBox linealCheck;
        private CheckBox cuadraticaCheck;
        private GroupBox resultadosBox;
        private TextBox tbDisplay;
    }
}