namespace IO.Swagger.UI
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
            this.txtJsonBody = new System.Windows.Forms.TextBox();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JsonContent = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJsonBody
            // 
            this.txtJsonBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJsonBody.Location = new System.Drawing.Point(12, 56);
            this.txtJsonBody.Multiline = true;
            this.txtJsonBody.Name = "txtJsonBody";
            this.txtJsonBody.Size = new System.Drawing.Size(478, 244);
            this.txtJsonBody.TabIndex = 0;
            // 
            // cbLanguages
            // 
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Location = new System.Drawing.Point(128, 6);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(124, 21);
            this.cbLanguages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Lenguaje";
            // 
            // JsonContent
            // 
            this.JsonContent.AutoSize = true;
            this.JsonContent.Location = new System.Drawing.Point(12, 40);
            this.JsonContent.Name = "JsonContent";
            this.JsonContent.Size = new System.Drawing.Size(97, 13);
            this.JsonContent.TabIndex = 3;
            this.JsonContent.Text = "Contenido del Json";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(415, 306);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(384, 9);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(106, 20);
            this.txtProjectName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 335);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.JsonContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLanguages);
            this.Controls.Add(this.txtJsonBody);
            this.Name = "Form1";
            this.Text = "Swagger Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJsonBody;
        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JsonContent;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
    }
}

