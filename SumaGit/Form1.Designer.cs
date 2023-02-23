
namespace SumaGit
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(75, 25);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(75, 68);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 1;
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(88, 109);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(75, 23);
            this.btnresult.TabIndex = 2;
            this.btnresult.Text = "Sumar";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(75, 153);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 20);
            this.txtresult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 264);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.TextBox txtresult;
    }
}

