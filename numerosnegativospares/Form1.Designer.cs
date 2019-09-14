namespace numerosnegativospares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numeros
            // 
            this.numeros.FormattingEnabled = true;
            this.numeros.Items.AddRange(new object[] {
            "-2",
            "-4",
            "-6",
            "-8",
            "-10",
            "-12",
            "-14",
            "-16",
            "-18",
            "-20",
            "-22",
            "-24",
            "-26",
            "-28",
            "-30",
            "-32",
            "-34",
            "-36",
            "-38",
            "-40"});
            this.numeros.Location = new System.Drawing.Point(307, 12);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(150, 212);
            this.numeros.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 235);
            this.Controls.Add(this.numeros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Primeros 20 números negativos pares.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox numeros;
    }
}

