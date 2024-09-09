namespace DrawRectangle
{
    partial class FormDrawRectangle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            btnCompute = new Button ();
            label1 = new Label ();
            tbArea = new TextBox ();
            label2 = new Label ();
            tbCircumference = new TextBox ();
            SuspendLayout ();
            // 
            // btnCompute
            // 
            btnCompute.AutoSize = true;
            btnCompute.Location = new Point (1431, 35);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size (260, 35);
            btnCompute.TabIndex = 0;
            btnCompute.Text = "Compute Rectangle Geometry";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += OnClickCompute;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point (1431, 107);
            label1.Name = "label1";
            label1.Size = new Size (52, 25);
            label1.TabIndex = 1;
            label1.Text = "Area:";
            // 
            // tbArea
            // 
            tbArea.Location = new Point (1541, 101);
            tbArea.Name = "tbArea";
            tbArea.ReadOnly = true;
            tbArea.Size = new Size (150, 31);
            tbArea.TabIndex = 2;
            tbArea.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point (1431, 150);
            label2.Name = "label2";
            label2.Size = new Size (128, 25);
            label2.TabIndex = 3;
            label2.Text = "Circumference:";
            // 
            // tbCircumference
            // 
            tbCircumference.Location = new Point (1563, 153);
            tbCircumference.Name = "tbCircumference";
            tbCircumference.ReadOnly = true;
            tbCircumference.Size = new Size (128, 31);
            tbCircumference.TabIndex = 4;
            tbCircumference.TextAlign = HorizontalAlignment.Right;
            // 
            // FormDrawRectangle
            // 
            AutoScaleDimensions = new SizeF (10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (1703, 1744);
            Controls.Add (tbCircumference);
            Controls.Add (label2);
            Controls.Add (tbArea);
            Controls.Add (label1);
            Controls.Add (btnCompute);
            Name = "FormDrawRectangle";
            Text = "Draw Image in Rectangle";
            Paint += OnPaint;
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button btnCompute;
        private Label label1;
        private TextBox tbArea;
        private Label label2;
        private TextBox tbCircumference;
    }
}