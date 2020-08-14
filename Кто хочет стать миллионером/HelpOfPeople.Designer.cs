namespace WhoWantsToBeMillionare
{
    partial class HelpOfPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpOfPeople));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChoiceOfPeople = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ChoiceOfPeople
            // 
            this.ChoiceOfPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChoiceOfPeople.ForeColor = System.Drawing.Color.Navy;
            this.ChoiceOfPeople.Location = new System.Drawing.Point(120, 334);
            this.ChoiceOfPeople.Margin = new System.Windows.Forms.Padding(4);
            this.ChoiceOfPeople.Multiline = true;
            this.ChoiceOfPeople.Name = "ChoiceOfPeople";
            this.ChoiceOfPeople.ReadOnly = true;
            this.ChoiceOfPeople.Size = new System.Drawing.Size(489, 24);
            this.ChoiceOfPeople.TabIndex = 1;
            this.ChoiceOfPeople.TextChanged += new System.EventHandler(this.ChoiceOfPeople_TextChanged);
            // 
            // HelpOfPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.ChoiceOfPeople);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelpOfPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help of people";
            this.Load += new System.EventHandler(this.HelpOfPeople_Load);
            this.TextChanged += new System.EventHandler(this.HelpOfPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ChoiceOfPeople;
    }
}