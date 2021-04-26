
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
            this.SuspendLayout();
            // 
            // lblcinta
            // 
            this.lblcinta.AutoSize = true;
            this.lblcinta.BackColor = System.Drawing.SystemColors.Control;
            this.lblcinta.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcinta.Location = new System.Drawing.Point(78, 125);
            this.lblcinta.Name = "lblcinta";
            this.lblcinta.Size = new System.Drawing.Size(0, 24);
            this.lblcinta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lectura Cabezal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escritura Cabezal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado Anterior";
            // 
            // btnstep
            // 
            this.btnstep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstep.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstep.Location = new System.Drawing.Point(65, 400);
            this.btnstep.Name = "btnstep";
            this.btnstep.Size = new System.Drawing.Size(155, 37);
            this.btnstep.TabIndex = 5;
            this.btnstep.Text = "STEP";
            this.btnstep.UseVisualStyleBackColor = true;
            this.btnstep.Click += new System.EventHandler(this.btnstep_Click);
            // 
            // btnauto
            // 
            this.btnauto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnauto.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauto.Location = new System.Drawing.Point(299, 400);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(155, 37);
            this.btnauto.TabIndex = 6;
            this.btnauto.Text = "AUTO";
            this.btnauto.UseVisualStyleBackColor = true;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // btnstop
            // 
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstop.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(526, 400);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(155, 37);
            this.btnstop.TabIndex = 7;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = true;
            // 
            // lbllectura
            // 
            this.lbllectura.AutoSize = true;
            this.lbllectura.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllectura.Location = new System.Drawing.Point(310, 202);
            this.lbllectura.Name = "lbllectura";
            this.lbllectura.Size = new System.Drawing.Size(0, 18);
            this.lbllectura.TabIndex = 8;
            // 
            // lblescritura
            // 
            this.lblescritura.AutoSize = true;
            this.lblescritura.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescritura.Location = new System.Drawing.Point(310, 241);
            this.lblescritura.Name = "lblescritura";
            this.lblescritura.Size = new System.Drawing.Size(0, 18);
            this.lblescritura.TabIndex = 9;
            // 
            // lblestadoanterior
            // 
            this.lblestadoanterior.AutoSize = true;
            this.lblestadoanterior.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoanterior.Location = new System.Drawing.Point(313, 318);
            this.lblestadoanterior.Name = "lblestadoanterior";
            this.lblestadoanterior.Size = new System.Drawing.Size(0, 18);
            this.lblestadoanterior.TabIndex = 11;
            // 
            // lblestadoactual
            // 
            this.lblestadoactual.AutoSize = true;
            this.lblestadoactual.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoactual.Location = new System.Drawing.Point(313, 279);
            this.lblestadoactual.Name = "lblestadoactual";
            this.lblestadoactual.Size = new System.Drawing.Size(0, 18);
            this.lblestadoactual.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Archivo MT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(541, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 73);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ingresar Entrada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(374, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 467);
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
    }
}