using System.Drawing;
using System.Windows.Forms;

namespace WaterTankTool_WFA.Foundation_Properties
{
    partial class AnchorBoltProperties
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label18 = new Label();
            textBox18 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label12 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox14 = new TextBox();
            labelStatus = new Label();
            label15 = new Label();
            textBox15 = new TextBox();
            label16 = new Label();
            textBox16 = new TextBox();
            label17 = new Label();
            textBox17 = new TextBox();
            labelBreakoutStatus = new Label();
            labelEdgeDistanceStatus = new Label();
            labelTbp = new Label();
            textBoxTbp = new TextBox();
            labelMu = new Label();
            textBoxMu = new TextBox();
            labelFcPrime = new Label();
            textBoxFcPrime = new TextBox();
            labelHef = new Label();
            textBoxHef = new TextBox();
            labelDistMethod = new Label();
            textBoxDistMethod = new TextBox();
            groupBoxBoltDetail = new GroupBox();
            labelBoltSelect = new Label();
            comboBoxBoltSelect = new ComboBox();
            labelLocationDetail = new Label();
            textBoxLocationDetail = new TextBox();
            labelAngleDetail = new Label();
            textBoxAngleDetail = new TextBox();
            labelXCoordDetail = new Label();
            textBoxXCoordDetail = new TextBox();
            labelYCoordDetail = new Label();
            textBoxYCoordDetail = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxBoltDetail.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDistMethod);
            groupBox1.Controls.Add(textBoxDistMethod);
            groupBox1.Controls.Add(labelHef);
            groupBox1.Controls.Add(textBoxHef);
            groupBox1.Controls.Add(labelFcPrime);
            groupBox1.Controls.Add(textBoxFcPrime);
            groupBox1.Controls.Add(labelMu);
            groupBox1.Controls.Add(textBoxMu);
            groupBox1.Controls.Add(labelTbp);
            groupBox1.Controls.Add(textBoxTbp);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(labelEdgeDistanceStatus);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(textBox18);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(textBox15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textBox16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(textBox17);
            groupBox1.Controls.Add(labelBreakoutStatus);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anchor Bolt Calculation Results";
            // 
            // labelTbp
            // 
            labelTbp.Location = new Point(20, 240);
            labelTbp.Name = "labelTbp";
            labelTbp.Size = new Size(180, 23);
            labelTbp.Text = "Base Plate Thickness (in):";
            // 
            // textBoxTbp
            // 
            textBoxTbp.Location = new Point(210, 237);
            textBoxTbp.Name = "textBoxTbp";
            textBoxTbp.ReadOnly = true;
            textBoxTbp.Size = new Size(80, 23);
            // 
            // labelMu
            // 
            labelMu.Location = new Point(20, 270);
            labelMu.Name = "labelMu";
            labelMu.Size = new Size(180, 23);
            labelMu.Text = "Governing Moment (kip-ft):";
            // 
            // textBoxMu
            // 
            textBoxMu.Location = new Point(210, 267);
            textBoxMu.Name = "textBoxMu";
            textBoxMu.ReadOnly = true;
            textBoxMu.Size = new Size(80, 23);
            // 
            // labelFcPrime
            // 
            labelFcPrime.Location = new Point(20, 300);
            labelFcPrime.Name = "labelFcPrime";
            labelFcPrime.Size = new Size(180, 23);
            labelFcPrime.Text = "Concrete Strength (psi):";
            // 
            // textBoxFcPrime
            // 
            textBoxFcPrime.Location = new Point(210, 297);
            textBoxFcPrime.Name = "textBoxFcPrime";
            textBoxFcPrime.ReadOnly = true;
            textBoxFcPrime.Size = new Size(80, 23);
            // 
            // labelHef
            // 
            labelHef.Location = new Point(20, 330);
            labelHef.Name = "labelHef";
            labelHef.Size = new Size(180, 23);
            labelHef.Text = "Embedment Depth (in):";
            // 
            // textBoxHef
            // 
            textBoxHef.Location = new Point(210, 327);
            textBoxHef.Name = "textBoxHef";
            textBoxHef.ReadOnly = true;
            textBoxHef.Size = new Size(80, 23);
            // 
            // labelDistMethod
            // 
            labelDistMethod.Location = new Point(20, 360);
            labelDistMethod.Name = "labelDistMethod";
            labelDistMethod.Size = new Size(180, 23);
            labelDistMethod.Text = "Distribution Method:";
            // 
            // textBoxDistMethod
            // 
            textBoxDistMethod.Location = new Point(210, 357);
            textBoxDistMethod.Name = "textBoxDistMethod";
            textBoxDistMethod.ReadOnly = true;
            textBoxDistMethod.Size = new Size(120, 23);
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 23);
            label1.Text = "Bolt Tensile Area (in²):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(80, 23);
            // 
            // label2
            // 
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.Text = "Bolt Hole Area (in²):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 57);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(80, 23);
            // 
            // label3
            // 
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.Text = "Angular Spacing (°):";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 87);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(80, 23);
            // 
            // label6
            // 
            label6.Location = new Point(20, 120);
            label6.Name = "label6";
            label6.Size = new Size(180, 23);
            label6.Text = "Arc Spacing (in):";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(210, 117);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(80, 23);
            // 
            // label7
            // 
            label7.Location = new Point(20, 150);
            label7.Name = "label7";
            label7.Size = new Size(180, 23);
            label7.Text = "Chord Spacing (in):";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(210, 147);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(80, 23);
            // 
            // label8
            // 
            label8.Location = new Point(20, 180);
            label8.Name = "label8";
            label8.Size = new Size(180, 23);
            label8.Text = "Bolts per Segment:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(210, 177);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(80, 23);
            // 
            // label9
            // 
            label9.Location = new Point(20, 210);
            label9.Name = "label9";
            label9.Size = new Size(180, 23);
            label9.Text = "Clear Edge Distance (in):";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(210, 207);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(80, 23);
            // 
            // labelEdgeDistanceStatus
            // 
            labelEdgeDistanceStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEdgeDistanceStatus.Location = new Point(295, 210);
            labelEdgeDistanceStatus.Name = "labelEdgeDistanceStatus";
            labelEdgeDistanceStatus.Size = new Size(40, 23);
            // 
            // label18
            // 
            label18.Location = new Point(340, 30);
            label18.Name = "label18";
            label18.Size = new Size(160, 23);
            label18.Text = "Total Uplift (Tu) (kips):";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(510, 27);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(80, 23);
            // 
            // label10
            // 
            label10.Location = new Point(340, 60);
            label10.Name = "label10";
            label10.Size = new Size(160, 23);
            label10.Text = "Tension per Bolt (kips):";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(510, 57);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(80, 23);
            // 
            // label11
            // 
            label11.Location = new Point(340, 90);
            label11.Name = "label11";
            label11.Size = new Size(160, 23);
            label11.Text = "Shear per Bolt (kips):";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(510, 87);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(80, 23);
            // 
            // label12
            // 
            label12.Location = new Point(340, 120);
            label12.Name = "label12";
            label12.Size = new Size(160, 23);
            label12.Text = "Tensile Capacity (kips):";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(510, 117);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(80, 23);
            // 
            // label13
            // 
            label13.Location = new Point(340, 150);
            label13.Name = "label13";
            label13.Size = new Size(160, 23);
            label13.Text = "Shear Capacity (kips):";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(510, 147);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(80, 23);
            // 
            // label14
            // 
            label14.Location = new Point(340, 180);
            label14.Name = "label14";
            label14.Size = new Size(160, 23);
            label14.Text = "Combined Interaction Ratio:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(510, 177);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(80, 23);
            textBox14.DoubleClick += textBox14_DoubleClick;
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStatus.Location = new Point(600, 180);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(40, 23);
            // 
            // label15
            // 
            label15.Location = new Point(340, 210);
            label15.Name = "label15";
            label15.Size = new Size(160, 23);
            label15.Text = "Min Embedment Check:";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(510, 207);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(80, 23);
            // 
            // label16
            // 
            label16.Location = new Point(340, 240);
            label16.Name = "label16";
            label16.Size = new Size(160, 23);
            label16.Text = "Breakout Capacity (kips):";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(510, 237);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(80, 23);
            // 
            // label17
            // 
            label17.Location = new Point(340, 270);
            label17.Name = "label17";
            label17.Size = new Size(160, 23);
            label17.Text = "Breakout Utilization:";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(510, 267);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(80, 23);
            // 
            // labelBreakoutStatus
            // 
            labelBreakoutStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelBreakoutStatus.Location = new Point(600, 270);
            labelBreakoutStatus.Name = "labelBreakoutStatus";
            labelBreakoutStatus.Size = new Size(40, 23);
            // 
            // groupBoxBoltDetail
            // 
            groupBoxBoltDetail.Controls.Add(labelBoltSelect);
            groupBoxBoltDetail.Controls.Add(comboBoxBoltSelect);
            groupBoxBoltDetail.Controls.Add(labelLocationDetail);
            groupBoxBoltDetail.Controls.Add(textBoxLocationDetail);
            groupBoxBoltDetail.Controls.Add(labelAngleDetail);
            groupBoxBoltDetail.Controls.Add(textBoxAngleDetail);
            groupBoxBoltDetail.Controls.Add(labelXCoordDetail);
            groupBoxBoltDetail.Controls.Add(textBoxXCoordDetail);
            groupBoxBoltDetail.Controls.Add(labelYCoordDetail);
            groupBoxBoltDetail.Controls.Add(textBoxYCoordDetail);
            groupBoxBoltDetail.Location = new Point(12, 420);
            groupBoxBoltDetail.Name = "groupBoxBoltDetail";
            groupBoxBoltDetail.Size = new Size(660, 110);
            groupBoxBoltDetail.TabIndex = 1;
            groupBoxBoltDetail.TabStop = false;
            groupBoxBoltDetail.Text = "Anchor Bolt Angles and Coordinates";
            // 
            // labelBoltSelect
            // 
            labelBoltSelect.Location = new Point(20, 30);
            labelBoltSelect.Name = "labelBoltSelect";
            labelBoltSelect.Size = new Size(80, 23);
            labelBoltSelect.Text = "Select Bolt:";
            // 
            // comboBoxBoltSelect
            // 
            comboBoxBoltSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBoltSelect.Location = new Point(105, 27);
            comboBoxBoltSelect.Name = "comboBoxBoltSelect";
            comboBoxBoltSelect.Size = new Size(100, 23);
            comboBoxBoltSelect.SelectedIndexChanged += comboBoxBoltSelect_SelectedIndexChanged;
            // 
            // labelLocationDetail
            // 
            labelLocationDetail.Location = new Point(230, 30);
            labelLocationDetail.Name = "labelLocationDetail";
            labelLocationDetail.Size = new Size(70, 23);
            labelLocationDetail.Text = "Location:";
            // 
            // textBoxLocationDetail
            // 
            textBoxLocationDetail.Location = new Point(305, 27);
            textBoxLocationDetail.Name = "textBoxLocationDetail";
            textBoxLocationDetail.ReadOnly = true;
            textBoxLocationDetail.Size = new Size(120, 23);
            // 
            // labelAngleDetail
            // 
            labelAngleDetail.Location = new Point(20, 70);
            labelAngleDetail.Name = "labelAngleDetail";
            labelAngleDetail.Size = new Size(70, 23);
            labelAngleDetail.Text = "Angle (°):";
            // 
            // textBoxAngleDetail
            // 
            textBoxAngleDetail.Location = new Point(90, 67);
            textBoxAngleDetail.Name = "textBoxAngleDetail";
            textBoxAngleDetail.ReadOnly = true;
            textBoxAngleDetail.Size = new Size(80, 23);
            // 
            // labelXCoordDetail
            // 
            labelXCoordDetail.Location = new Point(200, 70);
            labelXCoordDetail.Name = "labelXCoordDetail";
            labelXCoordDetail.Size = new Size(110, 23);
            labelXCoordDetail.Text = "X-Coordinate (ft):";
            // 
            // textBoxXCoordDetail
            // 
            textBoxXCoordDetail.Location = new Point(315, 67);
            textBoxXCoordDetail.Name = "textBoxXCoordDetail";
            textBoxXCoordDetail.ReadOnly = true;
            textBoxXCoordDetail.Size = new Size(80, 23);
            // 
            // labelYCoordDetail
            // 
            labelYCoordDetail.Location = new Point(420, 70);
            labelYCoordDetail.Name = "labelYCoordDetail";
            labelYCoordDetail.Size = new Size(110, 23);
            labelYCoordDetail.Text = "Y-Coordinate (ft):";
            // 
            // textBoxYCoordDetail
            // 
            textBoxYCoordDetail.Location = new Point(535, 67);
            textBoxYCoordDetail.Name = "textBoxYCoordDetail";
            textBoxYCoordDetail.ReadOnly = true;
            textBoxYCoordDetail.Size = new Size(80, 23);
            // 
            // AnchorBoltProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 540);
            Controls.Add(groupBoxBoltDetail);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AnchorBoltProperties";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Anchor Bolt Properties";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxBoltDetail.ResumeLayout(false);
            groupBoxBoltDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label labelTbp;
        private Label labelMu;
        private Label labelFcPrime;
        private Label labelHef;
        private Label labelDistMethod;
        private Label labelEdgeDistanceStatus;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBoxTbp;
        private TextBox textBoxMu;
        private TextBox textBoxFcPrime;
        private TextBox textBoxHef;
        private TextBox textBoxDistMethod;
        private Label labelStatus;
        private Label labelBreakoutStatus;
        
        // Section 6 Interactive Controls
        private GroupBox groupBoxBoltDetail;
        private Label labelBoltSelect;
        private ComboBox comboBoxBoltSelect;
        private Label labelLocationDetail;
        private TextBox textBoxLocationDetail;
        private Label labelAngleDetail;
        private TextBox textBoxAngleDetail;
        private Label labelXCoordDetail;
        private TextBox textBoxXCoordDetail;
        private Label labelYCoordDetail;
        private TextBox textBoxYCoordDetail;
    }
}

