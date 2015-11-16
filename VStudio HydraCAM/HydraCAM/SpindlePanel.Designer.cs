namespace HydraCAM
{
    partial class SpindlePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Speed (RPM):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Maroon;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatAppearance.BorderSize = 3;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(169, 7);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 39);
            this.button14.TabIndex = 67;
            this.button14.Text = "OFF";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(377, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 26);
            this.textBox4.TabIndex = 66;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(13, 52);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(507, 45);
            this.trackBar1.TabIndex = 65;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DarkGreen;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatAppearance.BorderSize = 3;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(98, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 39);
            this.button13.TabIndex = 64;
            this.button13.Text = "ON";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Spindle";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button13);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(540, 106);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label1;
    }
}
