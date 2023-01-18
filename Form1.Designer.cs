namespace Random_szam_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.szam_generated = new System.Windows.Forms.Label();
            this.felso_szam = new System.Windows.Forms.TextBox();
            this.also_szam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generalas = new System.Windows.Forms.Button();
            this.erorr_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szam_generated
            // 
            this.szam_generated.AutoSize = true;
            this.szam_generated.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.szam_generated.Location = new System.Drawing.Point(471, 270);
            this.szam_generated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.szam_generated.Name = "szam_generated";
            this.szam_generated.Size = new System.Drawing.Size(65, 89);
            this.szam_generated.TabIndex = 0;
            this.szam_generated.Text = "-";
            // 
            // felso_szam
            // 
            this.felso_szam.Location = new System.Drawing.Point(406, 152);
            this.felso_szam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.felso_szam.Name = "felso_szam";
            this.felso_szam.Size = new System.Drawing.Size(211, 23);
            this.felso_szam.TabIndex = 1;
            // 
            // also_szam
            // 
            this.also_szam.Location = new System.Drawing.Point(406, 244);
            this.also_szam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.also_szam.Name = "also_szam";
            this.also_szam.Size = new System.Drawing.Size(211, 23);
            this.also_szam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Random szám generátor";
            // 
            // generalas
            // 
            this.generalas.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generalas.Location = new System.Drawing.Point(358, 362);
            this.generalas.Name = "generalas";
            this.generalas.Size = new System.Drawing.Size(303, 73);
            this.generalas.TabIndex = 4;
            this.generalas.Text = "Generálás";
            this.generalas.UseVisualStyleBackColor = true;
            this.generalas.Click += new System.EventHandler(this.generalas_Click);
            // 
            // erorr_text
            // 
            this.erorr_text.AutoSize = true;
            this.erorr_text.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erorr_text.ForeColor = System.Drawing.Color.Red;
            this.erorr_text.Location = new System.Drawing.Point(358, 466);
            this.erorr_text.Name = "erorr_text";
            this.erorr_text.Size = new System.Drawing.Size(0, 35);
            this.erorr_text.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 510);
            this.Controls.Add(this.erorr_text);
            this.Controls.Add(this.generalas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.also_szam);
            this.Controls.Add(this.felso_szam);
            this.Controls.Add(this.szam_generated);
            this.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Random szám generátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label szam_generated;
        private TextBox felso_szam;
        private TextBox also_szam;
        private Label label1;
        private Button generalas;
        private Label erorr_text;
    }
}