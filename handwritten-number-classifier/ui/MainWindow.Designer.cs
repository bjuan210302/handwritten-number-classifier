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
            this.exploreBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exploreBut.Name = "exploreBut";
            this.exploreBut.Size = new System.Drawing.Size(459, 503);
            this.exploreBut.TabIndex = 0;
            this.exploreBut.Text = "Explore";
            this.exploreBut.UseVisualStyleBackColor = true;
            this.exploreBut.Click += new System.EventHandler(this.button1_Click);
            this.exploreBut.MouseEnter += new System.EventHandler(this.button_mouseIn);
            this.exploreBut.MouseLeave += new System.EventHandler(this.button_mouseOut);
            // 
            // neuralNBut
            // 
            this.neuralNBut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("neuralNBut.BackgroundImage")));
            this.neuralNBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.neuralNBut.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.neuralNBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.neuralNBut.Location = new System.Drawing.Point(459, 0);
            this.neuralNBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.neuralNBut.Name = "neuralNBut";
            this.neuralNBut.Size = new System.Drawing.Size(459, 503);
            this.neuralNBut.TabIndex = 1;
            this.neuralNBut.Text = "Neural Network";
            this.neuralNBut.UseVisualStyleBackColor = true;
            this.neuralNBut.Click += new System.EventHandler(this.neuralNBut_Click);
            this.neuralNBut.MouseEnter += new System.EventHandler(this.neuralNBut_mouseIn);
            this.neuralNBut.MouseLeave += new System.EventHandler(this.neuralNbut_mouseOut);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 503);
            this.Controls.Add(this.neuralNBut);
            this.Controls.Add(this.exploreBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button neuralNBut;

        private System.Windows.Forms.Button exploreBut;

        #endregion
    }
}