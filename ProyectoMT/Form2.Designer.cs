
namespace ProyectoMT
{
    partial class Form2
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
            this.lblcinta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnstep = new System.Windows.Forms.Button();
            this.btnauto = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lbllectura = new System.Windows.Forms.Label();
            this.lblescritura = new System.Windows.Forms.Label();
            this.lblestadoanterior = new System.Windows.Forms.Label();
            this.lblestadoactual = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcinta
            // 
            this.lblcinta.AutoSize = true;
            this.lblcinta.BackColor = System.Drawing.SystemColors.Control;
            this.lblcinta.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcinta.Location = new System.Drawing.Point(108, 109);
            this.lblcinta.Name = "lblcinta";
            this.lblcinta.Size = new System.Drawing.Size(0, 24);
            this.lblcinta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lectura Cabezal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escritura Cabezal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado Anterior";
            // 
            // btnstep
            // 
            this.btnstep.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnstep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstep.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstep.Location = new System.Drawing.Point(64, 400);
            this.btnstep.Name = "btnstep";
            this.btnstep.Size = new System.Drawing.Size(154, 37);
            this.btnstep.TabIndex = 5;
            this.btnstep.Text = "STEP";
            this.btnstep.UseVisualStyleBackColor = false;
            this.btnstep.Click += new System.EventHandler(this.btnstep_Click);
            // 
            // btnauto
            // 
            this.btnauto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnauto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnauto.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauto.Location = new System.Drawing.Point(298, 400);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(154, 37);
            this.btnauto.TabIndex = 6;
            this.btnauto.Text = "AUTO";
            this.btnauto.UseVisualStyleBackColor = false;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstop.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(526, 400);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(154, 37);
            this.btnstop.TabIndex = 7;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lbllectura
            // 
            this.lbllectura.AutoSize = true;
            this.lbllectura.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllectura.Location = new System.Drawing.Point(327, 162);
            this.lbllectura.Name = "lbllectura";
            this.lbllectura.Size = new System.Drawing.Size(0, 18);
            this.lbllectura.TabIndex = 8;
            // 
            // lblescritura
            // 
            this.lblescritura.AutoSize = true;
            this.lblescritura.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescritura.Location = new System.Drawing.Point(327, 202);
            this.lblescritura.Name = "lblescritura";
            this.lblescritura.Size = new System.Drawing.Size(0, 18);
            this.lblescritura.TabIndex = 9;
            // 
            // lblestadoanterior
            // 
            this.lblestadoanterior.AutoSize = true;
            this.lblestadoanterior.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoanterior.Location = new System.Drawing.Point(328, 263);
            this.lblestadoanterior.Name = "lblestadoanterior";
            this.lblestadoanterior.Size = new System.Drawing.Size(0, 18);
            this.lblestadoanterior.TabIndex = 11;
            // 
            // lblestadoactual
            // 
            this.lblestadoactual.AutoSize = true;
            this.lblestadoactual.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoactual.Location = new System.Drawing.Point(328, 228);
            this.lblestadoactual.Name = "lblestadoactual";
            this.lblestadoactual.Size = new System.Drawing.Size(0, 18);
            this.lblestadoactual.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Archivo MT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(556, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 72);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ingresar Entrada";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(374, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 26);
            this.textBox1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(8, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 74);
            this.button3.TabIndex = 15;
            this.button3.Text = "←";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "↓";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 20);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(337, 26);
            this.textBox2.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 468);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblestadoanterior);
            this.Controls.Add(this.lblestadoactual);
            this.Controls.Add(this.lblescritura);
            this.Controls.Add(this.lbllectura);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnauto);
            this.Controls.Add(this.btnstep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcinta);
            this.Name = "Form2";
            this.Text = "MT";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcinta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnstep;
        private System.Windows.Forms.Button btnauto;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lbllectura;
        private System.Windows.Forms.Label lblescritura;
        private System.Windows.Forms.Label lblestadoanterior;
        private System.Windows.Forms.Label lblestadoactual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}