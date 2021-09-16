
namespace Scope
{
    partial class frm_scope
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_methode1 = new System.Windows.Forms.Button();
            this.btn_methode2 = new System.Windows.Forms.Button();
            this.lbl_methode1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_methode1
            // 
            this.btn_methode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_methode1.Location = new System.Drawing.Point(12, 12);
            this.btn_methode1.Name = "btn_methode1";
            this.btn_methode1.Size = new System.Drawing.Size(167, 49);
            this.btn_methode1.TabIndex = 0;
            this.btn_methode1.Text = "Methode 1";
            this.btn_methode1.UseVisualStyleBackColor = true;
            this.btn_methode1.Click += new System.EventHandler(this.btn_methode1_Click);
            // 
            // btn_methode2
            // 
            this.btn_methode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_methode2.Location = new System.Drawing.Point(12, 67);
            this.btn_methode2.Name = "btn_methode2";
            this.btn_methode2.Size = new System.Drawing.Size(167, 49);
            this.btn_methode2.TabIndex = 1;
            this.btn_methode2.Text = "Methode 2";
            this.btn_methode2.UseVisualStyleBackColor = true;
            this.btn_methode2.Click += new System.EventHandler(this.btn_methode2_Click);
            // 
            // lbl_methode1
            // 
            this.lbl_methode1.AutoSize = true;
            this.lbl_methode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_methode1.Location = new System.Drawing.Point(194, 23);
            this.lbl_methode1.Name = "lbl_methode1";
            this.lbl_methode1.Size = new System.Drawing.Size(354, 26);
            this.lbl_methode1.TabIndex = 2;
            this.lbl_methode1.Text = "Hier steht gleich ein anderer Text ...";
            // 
            // frm_scope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_methode1);
            this.Controls.Add(this.btn_methode2);
            this.Controls.Add(this.btn_methode1);
            this.Name = "frm_scope";
            this.Text = "Gültigskeitsbereiche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_methode1;
        private System.Windows.Forms.Button btn_methode2;
        private System.Windows.Forms.Label lbl_methode1;
    }
}

