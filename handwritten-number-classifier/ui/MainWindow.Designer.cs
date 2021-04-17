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
            this.exploreBut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("exploreBut.BackgroundImage")));
            this.exploreBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exploreBut.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.exploreBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exploreBut.Location = new System.Drawing.Point(0, 0);
            this.exploreBut.Margin = new System.Windows.Forms.Padding(2);
            this.exploreBut.Name = "exploreBut";
            this.exploreBut.Size = new System.Drawing.Size(344, 409);
            this.exploreBut.TabIndex = 0;
            this.exploreBut.Text = "Explore";
            this.exploreBut.UseVisualStyleBackColor = true;
            this.exploreBut.Click += new System.EventHandler(this.button1_Click);
            this.exploreBut.MouseEnter += new System.EventHandler(this.button_mouseIn);
            this.exploreBut.MouseLeave += new System.EventHandler(this.button_mouseOut);
            // 
            // neuralNBut
            // 
            this.neuralNBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.neuralNBut.Location = new System.Drawing.Point(344, 0);
            this.neuralNBut.Margin = new System.Windows.Forms.Padding(2);
            this.neuralNBut.Name = "neuralNBut";
            this.neuralNBut.Size = new System.Drawing.Size(344, 409);
            this.neuralNBut.TabIndex = 1;
            this.neuralNBut.Text = "Coming soon...";
            this.neuralNBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 409);
            this.Controls.Add(this.neuralNBut);
            this.Controls.Add(this.exploreBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handwritten number classifier";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button neuralNBut;

        private System.Windows.Forms.Button exploreBut;

        #endregion
    }
}