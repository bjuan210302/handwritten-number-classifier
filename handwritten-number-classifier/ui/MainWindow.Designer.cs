namespace handwritten_number_classifier.ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exploreBut = new System.Windows.Forms.Button();
            this.neuralNBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exploreBut
            // 
            this.exploreBut.Image = ((System.Drawing.Image) (resources.GetObject("exploreBut.Image")));
            this.exploreBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exploreBut.Location = new System.Drawing.Point(98, 149);
            this.exploreBut.Name = "exploreBut";
            this.exploreBut.Size = new System.Drawing.Size(146, 60);
            this.exploreBut.TabIndex = 0;
            this.exploreBut.Text = "Explore";
            this.exploreBut.UseVisualStyleBackColor = true;
            this.exploreBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // neuralNBut
            // 
            this.neuralNBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.neuralNBut.Location = new System.Drawing.Point(374, 149);
            this.neuralNBut.Name = "neuralNBut";
            this.neuralNBut.Size = new System.Drawing.Size(146, 60);
            this.neuralNBut.TabIndex = 1;
            this.neuralNBut.Text = "Coming soon...";
            this.neuralNBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 331);
            this.Controls.Add(this.neuralNBut);
            this.Controls.Add(this.exploreBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Handwritten number classifier";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button neuralNBut;

        private System.Windows.Forms.Button exploreBut;

        #endregion
    }
}