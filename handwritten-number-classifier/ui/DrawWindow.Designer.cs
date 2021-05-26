using System.ComponentModel;

namespace handwritten_number_classifier.ui
{
    partial class DrawWindow
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
            this.panel = new System.Windows.Forms.Panel();
            this.ClearBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(39, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 300);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(471, 82);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(131, 51);
            this.ClearBut.TabIndex = 1;
            this.ClearBut.Text = "Send";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(39, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note: This only works with the own implementation neural net due to tensorflow is" + "sues";
            // 
            // DrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.panel);
            this.Name = "DrawWindow";
            this.Text = "DrawWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button ClearBut;

        private System.Windows.Forms.Panel panel;

        #endregion
    }
}