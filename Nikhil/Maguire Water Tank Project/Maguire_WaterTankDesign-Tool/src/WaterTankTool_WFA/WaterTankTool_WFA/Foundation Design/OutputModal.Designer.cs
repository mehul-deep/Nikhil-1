namespace WaterTankTool_WFA.Foundation_Design
{
    partial class OutputModal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.BackgroundImage = Properties.Resources.SS10;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(25, 38);
            button1.Name = "button1";
            button1.Size = new Size(120, 98);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.SS10_1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(165, 38);
            button2.Name = "button2";
            button2.Size = new Size(120, 98);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.SS11;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(305, 38);
            button3.Name = "button3";
            button3.Size = new Size(120, 98);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.SS11_1;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(445, 38);
            button4.Name = "button4";
            button4.Size = new Size(120, 98);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 141);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Anchor Bolt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 141);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Base Plate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 141);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Ring Wall";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 141);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "Footing";
            // 
            // OutputModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 189);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "OutputModal";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Segment to Analyze";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
