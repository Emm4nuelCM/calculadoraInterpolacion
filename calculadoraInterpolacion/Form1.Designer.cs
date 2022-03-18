namespace calculadoraInterpolacion
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
            this.label14 = new System.Windows.Forms.Label();
            this.errorRelativoBox = new System.Windows.Forms.TextBox();
            this.errorRelativoCheck = new System.Windows.Forms.CheckBox();
            this.tipoResultadoBox = new System.Windows.Forms.GroupBox();
            this.tresDecimalButton = new System.Windows.Forms.RadioButton();
            this.naturalButton = new System.Windows.Forms.RadioButton();
            this.decimalesButton = new System.Windows.Forms.RadioButton();
            this.interpolacionBox = new System.Windows.Forms.GroupBox();
            this.cuadraticaButton = new System.Windows.Forms.RadioButton();
            this.linealButton = new System.Windows.Forms.RadioButton();
            this.resultadosBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDisplay2 = new System.Windows.Forms.TextBox();
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
            this.valoresBox.ForeColor = System.Drawing.Color.White;
            this.valoresBox.Location = new System.Drawing.Point(13, 12);
            this.valoresBox.Name = "valoresBox";
            this.valoresBox.Size = new System.Drawing.Size(405, 176);
            this.valoresBox.TabIndex = 0;
            this.valoresBox.TabStop = false;
            this.valoresBox.Text = "VALORES";
            // 
            // buttCalcular
            // 
            this.buttCalcular.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttCalcular.ForeColor = System.Drawing.Color.White;
            this.buttCalcular.Location = new System.Drawing.Point(295, 135);
            this.buttCalcular.Name = "buttCalcular";
            this.buttCalcular.Size = new System.Drawing.Size(88, 31);
            this.buttCalcular.TabIndex = 19;
            this.buttCalcular.Text = "CALCULAR";
            this.buttCalcular.UseVisualStyleBackColor = false;
            this.buttCalcular.Click += new System.EventHandler(this.buttCalcular_Click);
            // 
            // buttLimpiar
            // 
            this.buttLimpiar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttLimpiar.Location = new System.Drawing.Point(195, 136);
            this.buttLimpiar.Name = "buttLimpiar";
            this.buttLimpiar.Size = new System.Drawing.Size(88, 31);
            this.buttLimpiar.TabIndex = 18;
            this.buttLimpiar.Text = "LIMPIAR";
            this.buttLimpiar.UseVisualStyleBackColor = false;
            this.buttLimpiar.Click += new System.EventHandler(this.buttLimpiar_Click);
            // 
            // FX2Box
            // 
            this.FX2Box.Location = new System.Drawing.Point(283, 106);
            this.FX2Box.Multiline = true;
            this.FX2Box.Name = "FX2Box";
            this.FX2Box.Size = new System.Drawing.Size(101, 23);
            this.FX2Box.TabIndex = 17;
            this.FX2Box.Text = "0";
            this.FX2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FX1Box
            // 
            this.FX1Box.Location = new System.Drawing.Point(283, 70);
            this.FX1Box.Multiline = true;
            this.FX1Box.Name = "FX1Box";
            this.FX1Box.Size = new System.Drawing.Size(101, 23);
            this.FX1Box.TabIndex = 16;
            this.FX1Box.Text = "0";
            this.FX1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FX0Box
            // 
            this.FX0Box.Location = new System.Drawing.Point(283, 31);
            this.FX0Box.Multiline = true;
            this.FX0Box.Name = "FX0Box";
            this.FX0Box.Size = new System.Drawing.Size(101, 23);
            this.FX0Box.TabIndex = 15;
            this.FX0Box.Text = "0";
            this.FX0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(230, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(230, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(195, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 30);
            this.label13.TabIndex = 13;
            this.label13.Text = "f(X   )=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(195, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "f(X   )=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(230, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(195, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "f(X   )=";
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(78, 136);
            this.XBox.Multiline = true;
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(101, 23);
            this.XBox.TabIndex = 10;
            this.XBox.Text = "0";
            this.XBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X2Box
            // 
            this.X2Box.Location = new System.Drawing.Point(78, 104);
            this.X2Box.Multiline = true;
            this.X2Box.Name = "X2Box";
            this.X2Box.Size = new System.Drawing.Size(101, 23);
            this.X2Box.TabIndex = 9;
            this.X2Box.Text = "0";
            this.X2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X1Box
            // 
            this.X1Box.Location = new System.Drawing.Point(78, 70);
            this.X1Box.Multiline = true;
            this.X1Box.Name = "X1Box";
            this.X1Box.Size = new System.Drawing.Size(101, 23);
            this.X1Box.TabIndex = 8;
            this.X1Box.Text = "0";
            this.X1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(78, 31);
            this.X0Box.Multiline = true;
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(101, 23);
            this.X0Box.TabIndex = 7;
            this.X0Box.Text = "0";
            this.X0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "X =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 104);
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
            this.label3.Location = new System.Drawing.Point(29, 70);
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
            this.label2.Location = new System.Drawing.Point(29, 31);
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
            this.opcionesBox.ForeColor = System.Drawing.Color.White;
            this.opcionesBox.Location = new System.Drawing.Point(424, 12);
            this.opcionesBox.Name = "opcionesBox";
            this.opcionesBox.Size = new System.Drawing.Size(167, 299);
            this.opcionesBox.TabIndex = 1;
            this.opcionesBox.TabStop = false;
            this.opcionesBox.Text = "OPCIONES";
            // 
            // otroBox
            // 
            this.otroBox.Controls.Add(this.label14);
            this.otroBox.Controls.Add(this.errorRelativoBox);
            this.otroBox.Controls.Add(this.errorRelativoCheck);
            this.otroBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otroBox.ForeColor = System.Drawing.Color.White;
            this.otroBox.Location = new System.Drawing.Point(6, 203);
            this.otroBox.Name = "otroBox";
            this.otroBox.Size = new System.Drawing.Size(144, 89);
            this.otroBox.TabIndex = 3;
            this.otroBox.TabStop = false;
            this.otroBox.Text = "OTRO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(5, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ev = ";
            // 
            // errorRelativoBox
            // 
            this.errorRelativoBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorRelativoBox.Location = new System.Drawing.Point(50, 57);
            this.errorRelativoBox.Multiline = true;
            this.errorRelativoBox.Name = "errorRelativoBox";
            this.errorRelativoBox.Size = new System.Drawing.Size(87, 23);
            this.errorRelativoBox.TabIndex = 20;
            this.errorRelativoBox.Text = "0";
            this.errorRelativoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorRelativoCheck
            // 
            this.errorRelativoCheck.AutoSize = true;
            this.errorRelativoCheck.Location = new System.Drawing.Point(13, 20);
            this.errorRelativoCheck.Name = "errorRelativoCheck";
            this.errorRelativoCheck.Size = new System.Drawing.Size(124, 30);
            this.errorRelativoCheck.TabIndex = 0;
            this.errorRelativoCheck.Text = "Calcular error \r\nrelativo porcentual";
            this.errorRelativoCheck.UseVisualStyleBackColor = true;
            this.errorRelativoCheck.CheckedChanged += new System.EventHandler(this.errorRelativoCheck_CheckedChanged);
            // 
            // tipoResultadoBox
            // 
            this.tipoResultadoBox.Controls.Add(this.tresDecimalButton);
            this.tipoResultadoBox.Controls.Add(this.naturalButton);
            this.tipoResultadoBox.Controls.Add(this.decimalesButton);
            this.tipoResultadoBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipoResultadoBox.ForeColor = System.Drawing.Color.White;
            this.tipoResultadoBox.Location = new System.Drawing.Point(11, 100);
            this.tipoResultadoBox.Name = "tipoResultadoBox";
            this.tipoResultadoBox.Size = new System.Drawing.Size(118, 97);
            this.tipoResultadoBox.TabIndex = 3;
            this.tipoResultadoBox.TabStop = false;
            this.tipoResultadoBox.Text = "TIPO RESULTADO";
            // 
            // tresDecimalButton
            // 
            this.tresDecimalButton.AutoSize = true;
            this.tresDecimalButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tresDecimalButton.Location = new System.Drawing.Point(13, 71);
            this.tresDecimalButton.Name = "tresDecimalButton";
            this.tresDecimalButton.Size = new System.Drawing.Size(80, 19);
            this.tresDecimalButton.TabIndex = 5;
            this.tresDecimalButton.Text = "3 Decimal";
            this.tresDecimalButton.UseVisualStyleBackColor = true;
            this.tresDecimalButton.CheckedChanged += new System.EventHandler(this.tresDecimalButton_CheckedChanged);
            // 
            // naturalButton
            // 
            this.naturalButton.AutoSize = true;
            this.naturalButton.Checked = true;
            this.naturalButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.naturalButton.ForeColor = System.Drawing.Color.White;
            this.naturalButton.Location = new System.Drawing.Point(13, 20);
            this.naturalButton.Name = "naturalButton";
            this.naturalButton.Size = new System.Drawing.Size(78, 19);
            this.naturalButton.TabIndex = 3;
            this.naturalButton.TabStop = true;
            this.naturalButton.Text = "Naturales";
            this.naturalButton.UseVisualStyleBackColor = true;
            this.naturalButton.CheckedChanged += new System.EventHandler(this.naturalButton_CheckedChanged);
            // 
            // decimalesButton
            // 
            this.decimalesButton.AutoSize = true;
            this.decimalesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decimalesButton.Location = new System.Drawing.Point(13, 46);
            this.decimalesButton.Name = "decimalesButton";
            this.decimalesButton.Size = new System.Drawing.Size(95, 19);
            this.decimalesButton.TabIndex = 4;
            this.decimalesButton.Text = "Redondeado";
            this.decimalesButton.UseVisualStyleBackColor = true;
            this.decimalesButton.CheckedChanged += new System.EventHandler(this.decimalesButton_CheckedChanged);
            // 
            // interpolacionBox
            // 
            this.interpolacionBox.Controls.Add(this.cuadraticaButton);
            this.interpolacionBox.Controls.Add(this.linealButton);
            this.interpolacionBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.interpolacionBox.ForeColor = System.Drawing.Color.White;
            this.interpolacionBox.Location = new System.Drawing.Point(11, 29);
            this.interpolacionBox.Name = "interpolacionBox";
            this.interpolacionBox.Size = new System.Drawing.Size(108, 65);
            this.interpolacionBox.TabIndex = 2;
            this.interpolacionBox.TabStop = false;
            this.interpolacionBox.Text = "INTERPOLACION";
            // 
            // cuadraticaButton
            // 
            this.cuadraticaButton.AutoSize = true;
            this.cuadraticaButton.Location = new System.Drawing.Point(13, 20);
            this.cuadraticaButton.Name = "cuadraticaButton";
            this.cuadraticaButton.Size = new System.Drawing.Size(80, 17);
            this.cuadraticaButton.TabIndex = 3;
            this.cuadraticaButton.Text = "Cuadratica";
            this.cuadraticaButton.UseVisualStyleBackColor = true;
            this.cuadraticaButton.CheckedChanged += new System.EventHandler(this.cuadraticaButton_CheckedChanged);
            // 
            // linealButton
            // 
            this.linealButton.AutoSize = true;
            this.linealButton.Location = new System.Drawing.Point(13, 44);
            this.linealButton.Name = "linealButton";
            this.linealButton.Size = new System.Drawing.Size(56, 17);
            this.linealButton.TabIndex = 4;
            this.linealButton.Text = "Lineal";
            this.linealButton.UseVisualStyleBackColor = true;
            this.linealButton.CheckedChanged += new System.EventHandler(this.linealButton_CheckedChanged);
            // 
            // resultadosBox
            // 
            this.resultadosBox.Controls.Add(this.label15);
            this.resultadosBox.Controls.Add(this.tbDisplay2);
            this.resultadosBox.Controls.Add(this.tbDisplay);
            this.resultadosBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadosBox.ForeColor = System.Drawing.Color.White;
            this.resultadosBox.Location = new System.Drawing.Point(13, 194);
            this.resultadosBox.Name = "resultadosBox";
            this.resultadosBox.Size = new System.Drawing.Size(405, 117);
            this.resultadosBox.TabIndex = 2;
            this.resultadosBox.TabStop = false;
            this.resultadosBox.Text = "RESULTADOS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(11, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 21);
            this.label15.TabIndex = 21;
            this.label15.Text = "Er(%) = ";
            // 
            // tbDisplay2
            // 
            this.tbDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDisplay2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDisplay2.Location = new System.Drawing.Point(6, 78);
            this.tbDisplay2.Multiline = true;
            this.tbDisplay2.Name = "tbDisplay2";
            this.tbDisplay2.ReadOnly = true;
            this.tbDisplay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDisplay2.Size = new System.Drawing.Size(388, 30);
            this.tbDisplay2.TabIndex = 1;
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDisplay.Location = new System.Drawing.Point(6, 29);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(388, 79);
            this.tbDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(612, 324);
            this.Controls.Add(this.resultadosBox);
            this.Controls.Add(this.opcionesBox);
            this.Controls.Add(this.valoresBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.HelpButton = true;
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
        private GroupBox interpolacionBox;
        private GroupBox resultadosBox;
        private TextBox tbDisplay;
        private RadioButton cuadraticaButton;
        private RadioButton linealButton;
        private RadioButton tresDecimalButton;
        private RadioButton naturalButton;
        private RadioButton decimalesButton;
        private TextBox errorRelativoBox;
        private Label label14;
        private Label label15;
        private TextBox tbDisplay2;
    }
}