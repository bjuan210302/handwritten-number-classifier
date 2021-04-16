using System.ComponentModel;

namespace handwritten_number_classifier
{
    partial class ExploreWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploreWindow));
            this.NumberImage = new System.Windows.Forms.PictureBox();
            this.prevBut = new System.Windows.Forms.Button();
            this.nextBut = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.NumberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberImage
            // 
            this.NumberImage.Location = new System.Drawing.Point(36, 31);
            this.NumberImage.Name = "NumberImage";
            this.NumberImage.Size = new System.Drawing.Size(280, 280);
            this.NumberImage.TabIndex = 0;
            this.NumberImage.TabStop = false;
            // 
            // prevBut
            // 
            this.prevBut.Image = ((System.Drawing.Image) (resources.GetObject("prevBut.Image")));
            this.prevBut.Location = new System.Drawing.Point(83, 335);
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(46, 52);
            this.prevBut.TabIndex = 1;
            this.prevBut.UseVisualStyleBackColor = true;
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // nextBut
            // 
            this.nextBut.Image = ((System.Drawing.Image) (resources.GetObject("nextBut.Image")));
            this.nextBut.Location = new System.Drawing.Point(209, 335);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(46, 52);
            this.nextBut.TabIndex = 2;
            this.nextBut.UseVisualStyleBackColor = true;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(342, 44);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(211, 22);
            this.searchField.TabIndex = 3;
            // 
            // searchBut
            // 
            this.searchBut.Image = ((System.Drawing.Image) (resources.GetObject("searchBut.Image")));
            this.searchBut.Location = new System.Drawing.Point(574, 39);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(43, 32);
            this.searchBut.TabIndex = 4;
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // ExploreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.nextBut);
            this.Controls.Add(this.prevBut);
            this.Controls.Add(this.NumberImage);
            this.Name = "ExploreWindow";
            this.Text = "ExploreWindow";
            ((System.ComponentModel.ISupportInitialize) (this.NumberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.TextBox searchField;

        private System.Windows.Forms.Button prevBut;
        private System.Windows.Forms.Button nextBut;

        private System.Windows.Forms.PictureBox NumberImage;

        #endregion
    }
}