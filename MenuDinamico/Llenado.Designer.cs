
namespace MenuDinamico
{
    partial class Llenado
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
            this.components = new System.ComponentModel.Container();
            this.btnLlenado = new System.Windows.Forms.Button();
            this.Tanque = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlenado
            // 
            this.btnLlenado.Location = new System.Drawing.Point(22, 12);
            this.btnLlenado.Name = "btnLlenado";
            this.btnLlenado.Size = new System.Drawing.Size(128, 32);
            this.btnLlenado.TabIndex = 0;
            this.btnLlenado.Text = "Llenar";
            this.btnLlenado.UseVisualStyleBackColor = true;
            this.btnLlenado.Click += new System.EventHandler(this.btnLlenado_Click);
            // 
            // Tanque
            // 
            this.Tanque.Location = new System.Drawing.Point(264, 104);
            this.Tanque.Name = "Tanque";
            this.Tanque.Size = new System.Drawing.Size(177, 300);
            this.Tanque.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Llenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Vaciar);
            // 
            // Llenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(776, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tanque);
            this.Controls.Add(this.btnLlenado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Llenado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llenado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Llenado_FormClosing);
            this.Load += new System.EventHandler(this.Llenado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlenado;
        private System.Windows.Forms.ProgressBar Tanque;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}