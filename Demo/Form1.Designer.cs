namespace Demo
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
            this.bConnect = new System.Windows.Forms.Button();
            this.lIp = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bEnable = new System.Windows.Forms.Button();
            this.tbCode2 = new System.Windows.Forms.TextBox();
            this.bDisable = new System.Windows.Forms.Button();
            this.bCount = new System.Windows.Forms.Button();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(168, 4);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 0;
            this.bConnect.Text = "Conectar";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // lIp
            // 
            this.lIp.AutoSize = true;
            this.lIp.Location = new System.Drawing.Point(30, 9);
            this.lIp.Name = "lIp";
            this.lIp.Size = new System.Drawing.Size(17, 13);
            this.lIp.TabIndex = 1;
            this.lIp.Text = "IP";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(53, 6);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 20);
            this.tbIp.TabIndex = 2;
            this.tbIp.Text = "192.168.1.201";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(20, 32);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // bEnable
            // 
            this.bEnable.Location = new System.Drawing.Point(250, 30);
            this.bEnable.Name = "bEnable";
            this.bEnable.Size = new System.Drawing.Size(75, 23);
            this.bEnable.TabIndex = 3;
            this.bEnable.Text = "Activar";
            this.bEnable.UseVisualStyleBackColor = true;
            this.bEnable.Click += new System.EventHandler(this.bEnable_Click);
            // 
            // tbCode2
            // 
            this.tbCode2.Location = new System.Drawing.Point(20, 80);
            this.tbCode2.Name = "tbCode2";
            this.tbCode2.Size = new System.Drawing.Size(100, 20);
            this.tbCode2.TabIndex = 8;
            // 
            // bDisable
            // 
            this.bDisable.Location = new System.Drawing.Point(135, 78);
            this.bDisable.Name = "bDisable";
            this.bDisable.Size = new System.Drawing.Size(75, 23);
            this.bDisable.TabIndex = 6;
            this.bDisable.Text = "Inhabilitar";
            this.bDisable.UseVisualStyleBackColor = true;
            this.bDisable.Click += new System.EventHandler(this.bDisable_Click);
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(20, 122);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(135, 23);
            this.bCount.TabIndex = 9;
            this.bCount.Text = "Contar empleados";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(135, 32);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(100, 20);
            this.tbCardNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nro Tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bEnable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbCode);
            this.panel1.Controls.Add(this.tbCardNumber);
            this.panel1.Controls.Add(this.bDisable);
            this.panel1.Controls.Add(this.bCount);
            this.panel1.Controls.Add(this.tbCode2);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 166);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 213);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.lIp);
            this.Controls.Add(this.bConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label lIp;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEnable;
        private System.Windows.Forms.TextBox tbCode2;
        private System.Windows.Forms.Button bDisable;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

