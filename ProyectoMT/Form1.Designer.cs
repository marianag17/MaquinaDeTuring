
namespace ProyectoMT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnaceptacion = new System.Windows.Forms.Button();
            this.btnfunciones = new System.Windows.Forms.Button();
            this.btcdecision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máquinas de Turing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnaceptacion
            // 
            this.btnaceptacion.BackColor = System.Drawing.Color.SlateGray;
            this.btnaceptacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaceptacion.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptacion.Location = new System.Drawing.Point(179, 189);
            this.btnaceptacion.Name = "btnaceptacion";
            this.btnaceptacion.Size = new System.Drawing.Size(172, 39);
            this.btnaceptacion.TabIndex = 1;
            this.btnaceptacion.Text = "ACEPTACIÓN";
            this.btnaceptacion.UseVisualStyleBackColor = false;
            this.btnaceptacion.Click += new System.EventHandler(this.btnaceptacion_Click);
            // 
            // btnfunciones
            // 
            this.btnfunciones.BackColor = System.Drawing.Color.SlateGray;
            this.btnfunciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfunciones.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfunciones.Location = new System.Drawing.Point(179, 250);
            this.btnfunciones.Name = "btnfunciones";
            this.btnfunciones.Size = new System.Drawing.Size(172, 40);
            this.btnfunciones.TabIndex = 2;
            this.btnfunciones.Text = "FUNCIONES";
            this.btnfunciones.UseVisualStyleBackColor = false;
            this.btnfunciones.Click += new System.EventHandler(this.btnfunciones_Click);
            // 
            // btcdecision
            // 
            this.btcdecision.BackColor = System.Drawing.Color.SlateGray;
            this.btcdecision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcdecision.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcdecision.Location = new System.Drawing.Point(179, 311);
            this.btcdecision.Name = "btcdecision";
            this.btcdecision.Size = new System.Drawing.Size(172, 40);
            this.btcdecision.TabIndex = 3;
            this.btcdecision.Text = "DECISIÓN";
            this.btcdecision.UseVisualStyleBackColor = false;
            this.btcdecision.Click += new System.EventHandler(this.btcdecision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(520, 431);
            this.Controls.Add(this.btcdecision);
            this.Controls.Add(this.btnfunciones);
            this.Controls.Add(this.btnaceptacion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaceptacion;
        private System.Windows.Forms.Button btnfunciones;
        private System.Windows.Forms.Button btcdecision;
    }
}

