namespace Clock
{
    partial class FontChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontChooser));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OKb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelExample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox1.ForeColor = System.Drawing.Color.Peru;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(401, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // OKb
            // 
            this.OKb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKb.ForeColor = System.Drawing.Color.Sienna;
            this.OKb.Location = new System.Drawing.Point(251, 153);
            this.OKb.Name = "OKb";
            this.OKb.Size = new System.Drawing.Size(75, 23);
            this.OKb.TabIndex = 1;
            this.OKb.Text = "OK";
            this.OKb.UseVisualStyleBackColor = true;
            this.OKb.Click += new System.EventHandler(this.OKb_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(332, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExample.ForeColor = System.Drawing.Color.SeaShell;
            this.labelExample.Location = new System.Drawing.Point(9, 81);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(279, 69);
            this.labelExample.TabIndex = 3;
            this.labelExample.Text = "Example ";
            // 
            // FontChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(426, 192);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKb);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FontChooser";
            this.Text = "FontChooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button OKb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelExample;
    }
}