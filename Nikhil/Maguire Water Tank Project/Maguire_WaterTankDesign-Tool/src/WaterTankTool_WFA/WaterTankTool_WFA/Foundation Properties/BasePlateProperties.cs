using System;
using System.Linq;
using System.Windows.Forms;
using WaterTankTool_WFA.Entity;
using WaterTankTool_WFA.Solver_Equation;

namespace WaterTankTool_WFA.Foundation_Properties
{
    public partial class BasePlateProperties : Form
    {
        private readonly WaterTankDbContext _context;
        private BasePlateEntity? _entity;

        public BasePlateProperties()
        {
            InitializeComponent();
            _context = WaterTankDbContext.GetInstance();
            this.Load += BasePlateProperties_Load;
        }

        private void BasePlateProperties_Load(object? sender, EventArgs e)
        {
            _entity = _context.BasePlateEntity.FirstOrDefault();

            if (_entity != null)
            {
                DisplayCalculatedData();
                PopulateBoltDropdown();
            }
        }

        private void DisplayCalculatedData()
        {
            if (_entity == null) return;

            var eq = new FoundationEquations.BasePlateEquations();

            // Geometric results
            double grossArea = eq.GrossArea(_entity.Ro, _entity.Ri, _entity.Theta);
            double netArea = eq.NetArea(_entity.Ro, _entity.Ri, _entity.Theta, _entity.Nh, _entity.Dh);
            double volume = eq.Volume(_entity.Ro, _entity.Ri, _entity.Theta, _entity.T);
            double weightPerSegment = eq.WeightPerSegment(_entity.Ro, _entity.Ri, _entity.Theta, _entity.T, _entity.Rs);
            double totalWeight = eq.TotalWeight(weightPerSegment, _entity.N);

            double outerArcLength = eq.OuterArcLength(_entity.Ro, _entity.Theta);
            double innerArcLength = eq.InnerArcLength(_entity.Ri, _entity.Theta);
            double radialWidth = eq.RadialWidth(_entity.Ro, _entity.Ri);
            double centroidRadius = eq.CentroidRadius(_entity.Ro, _entity.Ri, _entity.Theta);
            double centroidAngle = eq.CentroidAngle(_entity.A ?? 0, _entity.Theta);

            textBox1.Text = grossArea.ToString("F4");
            textBox2.Text = netArea.ToString("F4");
            textBox3.Text = volume.ToString("F4");
            textBox4.Text = weightPerSegment.ToString("F4");
            textBox5.Text = totalWeight.ToString("F4");

            textBox6.Text = outerArcLength.ToString("F4");
            textBox7.Text = innerArcLength.ToString("F4");
            textBox8.Text = radialWidth.ToString("F4");
            textBox9.Text = centroidRadius.ToString("F4");
            textBox10.Text = centroidAngle.ToString("F4");

            // Structural results
            double areaA1 = grossArea * 144.0; 
            double areaA2 = _entity.A2 ?? areaA1; 
            double pu = _entity.Pu ?? 0;

            double fp = eq.BearingStress(pu, areaA1);
            double phiPp = eq.DesignBearingStrength(_entity.Fc_prime, areaA1, areaA2);
            
            double capacityStress = phiPp / areaA1;
            // 3. Utilization (fp / capacityStress)
            double bearingUtil = eq.Utilization(fp, capacityStress);

            // 4. Required Thickness (Refined logic)
            double shellRadiusIn = (_entity.ShellRadius ?? (_entity.Ro + _entity.Ri) / 2.0) * 12.0;
            double roIn = _entity.Ro * 12.0;
            double riIn = _entity.Ri * 12.0;

            double l_refined = eq.CantileverLength(roIn, riIn, shellRadiusIn);
            double treq = eq.RequiredThickness(l_refined, fp, _entity.Fy);
            double thicknessUtil = eq.Utilization(treq, _entity.T);

            textBox11.Text = fp.ToString("F4");
            textBox12.Text = phiPp.ToString("F4");
            textBox13.Text = treq.ToString("F4");
            textBox14.Text = (bearingUtil * 100).ToString("F2") + " %";

            textBox21.Text = l_refined.ToString("F4");
            textBox22.Text = (thicknessUtil * 100).ToString("F2") + " %";

            // Centroid
            double xc = eq.CentroidX(_entity.Ro, _entity.Ri, _entity.Theta, _entity.A ?? 0);
            double yc = eq.CentroidY(_entity.Ro, _entity.Ri, _entity.Theta, _entity.A ?? 0);
            textBox15.Text = xc.ToString("F4");
            textBox16.Text = yc.ToString("F4");

            // Save results back to entity
            _entity.Fp = fp;
            _entity.Phi_Pp = phiPp;
            _entity.BearingUtilization = bearingUtil;
            _entity.L = l_refined;
            _entity.T_req = treq;
            _entity.ThicknessUtilization = eq.Utilization(treq, _entity.T);

            _context.SaveChanges();
        }

        private void PopulateBoltDropdown()
        {
            if (_entity == null) return;

            comboBoxBoltSelect.Items.Clear();
            for (int i = 1; i <= _entity.Nh; i++)
            {
                comboBoxBoltSelect.Items.Add($"Bolt {i}");
            }

            if (comboBoxBoltSelect.Items.Count > 0)
            {
                comboBoxBoltSelect.SelectedIndex = 0;
            }
        }

        private void comboBoxBoltSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_entity == null) return;

            int boltIndexInSegment = comboBoxBoltSelect.SelectedIndex;
            var boltEq = new FoundationEquations.AnchorBoltEquations();
            
            double rb = _entity.Rb ?? (_entity.Ro + _entity.Ri) / 2.0;
            double startAngle = _entity.A ?? 0;
            
            // If there's only 1 bolt, it's at startAngle. 
            // If multiple, they are spaced across Theta.
            double step = _entity.Nh > 1 ? _entity.Theta / (_entity.Nh - 1) : 0;
            double angle = startAngle + (boltIndexInSegment * step);

            double x = boltEq.BoltXCoordinate(rb, angle);
            double y = boltEq.BoltYCoordinate(rb, angle);

            textBoxAngleDetail.Text = angle.ToString("F2");
            textBoxXCoordDetail.Text = x.ToString("F2");
            textBoxYCoordDetail.Text = y.ToString("F2");
            textBoxLocationDetail.Text = GetBoltLocationDescription(angle);
        }

        private string GetBoltLocationDescription(double angle)
        {
            double normAngle = angle % 360;
            if (normAngle < 0) normAngle += 360;

            if (normAngle == 0 || normAngle == 360) return "Right";
            if (normAngle > 0 && normAngle < 90) return "Upper-right";
            if (normAngle == 90) return "Top";
            if (normAngle > 90 && normAngle < 180) return "Upper-left";
            if (normAngle == 180) return "Left";
            if (normAngle > 180 && normAngle < 270) return "Lower-left";
            if (normAngle == 270) return "Bottom";
            if (normAngle > 270 && normAngle < 360) return "Lower-right";

            return "Unknown";
        }
    }
}