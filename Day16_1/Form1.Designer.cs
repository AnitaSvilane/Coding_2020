namespace Day16_1
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
            this.vards = new System.Windows.Forms.Label();
            this.poga = new System.Windows.Forms.Button();
            this.vards_ievade = new System.Windows.Forms.TextBox();
            this.vecums = new System.Windows.Forms.Label();
            this.vecums_ievade = new System.Windows.Forms.TextBox();
            this.izvade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vards
            // 
            this.vards.AutoSize = true;
            this.vards.Location = new System.Drawing.Point(187, 61);
            this.vards.Name = "vards";
            this.vards.Size = new System.Drawing.Size(51, 20);
            this.vards.TabIndex = 0;
            this.vards.Text = "Vārds";
            this.vards.Click += new System.EventHandler(this.label1_Click);
            // 
            // poga
            // 
            this.poga.Location = new System.Drawing.Point(430, 58);
            this.poga.Name = "poga";
            this.poga.Size = new System.Drawing.Size(105, 45);
            this.poga.TabIndex = 1;
            this.poga.Text = "Ievadīt";
            this.poga.UseVisualStyleBackColor = true;
            this.poga.Click += new System.EventHandler(this.buttDemo_Click);
            // 
            // vards_ievade
            // 
            this.vards_ievade.Location = new System.Drawing.Point(254, 58);
            this.vards_ievade.Name = "vards_ievade";
            this.vards_ievade.Size = new System.Drawing.Size(100, 26);
            this.vards_ievade.TabIndex = 2;
            this.vards_ievade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vecums
            // 
            this.vecums.AutoSize = true;
            this.vecums.Location = new System.Drawing.Point(171, 81);
            this.vecums.Name = "vecums";
            this.vecums.Size = new System.Drawing.Size(67, 20);
            this.vecums.TabIndex = 3;
            this.vecums.Text = "Vecums";
            // 
            // vecums_ievade
            // 
            this.vecums_ievade.Location = new System.Drawing.Point(254, 81);
            this.vecums_ievade.Name = "vecums_ievade";
            this.vecums_ievade.Size = new System.Drawing.Size(100, 26);
            this.vecums_ievade.TabIndex = 4;
            // 
            // izvade
            // 
            this.izvade.AutoSize = true;
            this.izvade.Location = new System.Drawing.Point(187, 19);
            this.izvade.Name = "izvade";
            this.izvade.Size = new System.Drawing.Size(175, 20);
            this.izvade.TabIndex = 5;
            this.izvade.Text = "Ievadi vārdu un vecumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izvade);
            this.Controls.Add(this.vecums_ievade);
            this.Controls.Add(this.vecums);
            this.Controls.Add(this.vards_ievade);
            this.Controls.Add(this.poga);
            this.Controls.Add(this.vards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vards;
        private System.Windows.Forms.Button poga;
        private System.Windows.Forms.TextBox vards_ievade;
        private System.Windows.Forms.Label vecums;
        private System.Windows.Forms.TextBox vecums_ievade;
        private System.Windows.Forms.Label izvade;
    }
}

