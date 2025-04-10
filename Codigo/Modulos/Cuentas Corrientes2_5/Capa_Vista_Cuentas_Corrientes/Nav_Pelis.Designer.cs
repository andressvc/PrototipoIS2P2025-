
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Nav_Pelis
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
            this.NavPelis = new Capa_Vista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // NavPelis
            // 
            this.NavPelis.BackColor = System.Drawing.Color.White;
            this.NavPelis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavPelis.Location = new System.Drawing.Point(0, 0);
            this.NavPelis.Margin = new System.Windows.Forms.Padding(4);
            this.NavPelis.Name = "NavPelis";
            this.NavPelis.Size = new System.Drawing.Size(1055, 558);
            this.NavPelis.TabIndex = 0;
            this.NavPelis.Load += new System.EventHandler(this.NavPelis_Load);
            // 
            // Nav_Pelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 558);
            this.Controls.Add(this.NavPelis);
            this.Name = "Nav_Pelis";
            this.Text = "Nav_Pelis";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.Navegador NavPelis;
    }
}