
namespace MenuDinamico
{
    partial class MenuDinamico
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
            this.PanelCatalogos = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnCatalagos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.PanelCatalogos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCatalogos
            // 
            this.PanelCatalogos.Controls.Add(this.button4);
            this.PanelCatalogos.Controls.Add(this.button3);
            this.PanelCatalogos.Controls.Add(this.button2);
            this.PanelCatalogos.Controls.Add(this.button1);
            this.PanelCatalogos.Controls.Add(this.btnUbicacion);
            this.PanelCatalogos.Location = new System.Drawing.Point(44, -193);
            this.PanelCatalogos.Name = "PanelCatalogos";
            this.PanelCatalogos.Size = new System.Drawing.Size(142, 187);
            this.PanelCatalogos.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Vehiculos";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mercancias";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Certificados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.BackColor = System.Drawing.Color.LightBlue;
            this.btnUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUbicacion.Location = new System.Drawing.Point(0, 0);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(142, 36);
            this.btnUbicacion.TabIndex = 0;
            this.btnUbicacion.Text = "Llenado";
            this.btnUbicacion.UseVisualStyleBackColor = false;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnCatalagos
            // 
            this.btnCatalagos.AutoSize = true;
            this.btnCatalagos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCatalagos.Location = new System.Drawing.Point(44, 41);
            this.btnCatalagos.Name = "btnCatalagos";
            this.btnCatalagos.Size = new System.Drawing.Size(142, 31);
            this.btnCatalagos.TabIndex = 7;
            this.btnCatalagos.Text = "Catalogos";
            this.btnCatalagos.UseVisualStyleBackColor = false;
            this.btnCatalagos.Click += new System.EventHandler(this.button1_Click);
            this.btnCatalagos.MouseEnter += new System.EventHandler(this.SeleccionarBtnCatalogos);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(231, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Utilerias";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseEnter += new System.EventHandler(this.SeleccionarBtnUtilerias);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(231, -193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 187);
            this.panel1.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightBlue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 36);
            this.button8.TabIndex = 2;
            this.button8.Text = "Configurar empresas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.Location = new System.Drawing.Point(0, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 36);
            this.button9.TabIndex = 1;
            this.button9.Text = "Actualizar metadatos";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightBlue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 36);
            this.button10.TabIndex = 0;
            this.button10.Text = "Configurar parametros";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button11.Location = new System.Drawing.Point(413, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(142, 31);
            this.button11.TabIndex = 9;
            this.button11.Text = "Operacion";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseEnter += new System.EventHandler(this.SeleccionarBtnOperacion);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Location = new System.Drawing.Point(413, -193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 187);
            this.panel2.TabIndex = 8;
            this.panel2.MouseEnter += new System.EventHandler(this.SeleccionarBtnOperacion);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightBlue;
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.Location = new System.Drawing.Point(0, 36);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(142, 36);
            this.button15.TabIndex = 1;
            this.button15.Text = "Timbrar";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightBlue;
            this.button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(142, 36);
            this.button16.TabIndex = 0;
            this.button16.Text = "Facturacion";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // MenuDinamico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(618, 489);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCatalagos);
            this.Controls.Add(this.PanelCatalogos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuDinamico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuDinamico_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelCatalogos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelCatalogos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnCatalagos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

