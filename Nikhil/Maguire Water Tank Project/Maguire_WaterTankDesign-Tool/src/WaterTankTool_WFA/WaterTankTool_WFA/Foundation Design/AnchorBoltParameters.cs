using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WaterTankTool_WFA.Entity;

namespace WaterTankTool_WFA.Foundation_Design
{
    public partial class AnchorBoltParameters : Form
    {
        private readonly WaterTankDbContext _context;

        public AnchorBoltEntity? SavedAnchorBolt { get; private set; }

        // holds existing row from DB if present
        private AnchorBoltEntity? _existingAnchorBolt;

        public AnchorBoltParameters()
        {
            InitializeComponent();

            _context = WaterTankDbContext.GetInstance();

            // Initialize ComboBox
            comboBox1.Items.AddRange(new string[] { "Circular Group", "Equal Distribution", "Effective Bolts" });
            comboBox1.SelectedIndex = 0; // Default

            this.Load += AnchorBoltParameters_Load;
        }

        private void AnchorBoltParameters_Load(object? sender, EventArgs e)
        {
            LoadExistingData();
        }

        private void LoadExistingData()
        {
            try
            {
                // load first record; change this if later you support multiple anchor bolt records
                _existingAnchorBolt = _context.AnchorBoltEntity.FirstOrDefault();

                if (_existingAnchorBolt == null)
                    return;

                textBox1.Text = _existingAnchorBolt.Nb.ToString();
                textBox2.Text = _existingAnchorBolt.Db.ToString(CultureInfo.InvariantCulture);
                textBox3.Text = _existingAnchorBolt.Dh.ToString(CultureInfo.InvariantCulture);
                textBox4.Text = _existingAnchorBolt.Rb.ToString(CultureInfo.InvariantCulture);
                textBox5.Text = _existingAnchorBolt.Ab.ToString(CultureInfo.InvariantCulture);
                textBox6.Text = _existingAnchorBolt.ThetaSeg?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox7.Text = _existingAnchorBolt.Ns?.ToString() ?? "";
                textBox8.Text = _existingAnchorBolt.Tbp.ToString(CultureInfo.InvariantCulture);

                textBox9.Text = _existingAnchorBolt.Fy?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox10.Text = _existingAnchorBolt.Fu?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox11.Text = _existingAnchorBolt.Tu.ToString(CultureInfo.InvariantCulture);
                textBox12.Text = _existingAnchorBolt.Vu.ToString(CultureInfo.InvariantCulture);
                textBox13.Text = _existingAnchorBolt.Phi?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox14.Text = _existingAnchorBolt.E?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox15.Text = _existingAnchorBolt.S?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox16.Text = _existingAnchorBolt.Nbs?.ToString() ?? "";
                textBox17.Text = _existingAnchorBolt.Mu?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox18.Text = _existingAnchorBolt.FcPrime?.ToString(CultureInfo.InvariantCulture) ?? "";
                textBox19.Text = _existingAnchorBolt.Hef?.ToString(CultureInfo.InvariantCulture) ?? "";

                if (!string.IsNullOrEmpty(_existingAnchorBolt.DistributionMethod))
                {
                    int index = comboBox1.FindStringExact(_existingAnchorBolt.DistributionMethod);
                    if (index != -1) comboBox1.SelectedIndex = index;
                }

                SavedAnchorBolt = _existingAnchorBolt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load anchor bolt data.\n{ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // if record exists -> update it
                // else -> create new one
                var entity = _existingAnchorBolt ?? new AnchorBoltEntity();

                entity.Nb = ParseIntRequired(textBox1, "Total Number");
                entity.Db = ParseDoubleRequired(textBox2, "Nominal Diameter");
                entity.Dh = ParseDoubleRequired(textBox3, "Hole Diameter");
                entity.Rb = ParseDoubleRequired(textBox4, "Circle Radius");
                entity.Ab = ParseDoubleRequired(textBox5, "Start Angle of first bolt");
                entity.ThetaSeg = ParseDoubleNullable(textBox6);
                entity.Ns = ParseIntNullable(textBox7);
                entity.Tbp = ParseDoubleRequired(textBox8, "Base Plate Thickness");

                entity.Fy = ParseDoubleNullable(textBox9);
                entity.Fu = ParseDoubleNullable(textBox10);
                entity.Tu = ParseDoubleNullable(textBox11) ?? 0;
                entity.Vu = ParseDoubleRequired(textBox12, "Shear Demand");
                entity.Phi = ParseDoubleNullable(textBox13);
                entity.E = ParseDoubleNullable(textBox14);
                entity.S = ParseDoubleNullable(textBox15);
                entity.Nbs = ParseIntNullable(textBox16);
                entity.Mu = ParseDoubleNullable(textBox17);
                entity.FcPrime = ParseDoubleNullable(textBox18);
                entity.Hef = ParseDoubleNullable(textBox19);

                // Validation: Either Tu or Mu must be provided
                if (entity.Tu <= 0 && (entity.Mu == null || entity.Mu <= 0))
                {
                    throw new Exception("Either Tension Demand or Governing Moment (Mu) must be provided.");
                }

                entity.DistributionMethod = comboBox1.SelectedItem?.ToString();

                if (_existingAnchorBolt == null)
                {
                    _context.AnchorBoltEntity.Add(entity);
                }
                else
                {
                    _context.AnchorBoltEntity.Update(entity);
                }

                _context.SaveChanges();

                _existingAnchorBolt = entity;
                SavedAnchorBolt = entity;

                MessageBox.Show("Anchor bolt data saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int ParseIntRequired(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                throw new Exception($"{fieldName} is required.");

            if (!int.TryParse(textBox.Text.Trim(), out int value))
            {
                textBox.Focus();
                throw new Exception($"{fieldName} must be a valid integer.");
            }

            return value;
        }

        private int? ParseIntNullable(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                return null;

            if (!int.TryParse(textBox.Text.Trim(), out int value))
            {
                textBox.Focus();
                throw new Exception($"Invalid integer value entered in {textBox.Name}.");
            }

            return value;
        }

        private double ParseDoubleRequired(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                throw new Exception($"{fieldName} is required.");

            if (!double.TryParse(textBox.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double value) &&
                !double.TryParse(textBox.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out value))
            {
                textBox.Focus();
                throw new Exception($"{fieldName} must be a valid number.");
            }

            return value;
        }

        private double? ParseDoubleNullable(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                return null;

            if (!double.TryParse(textBox.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double value) &&
                !double.TryParse(textBox.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out value))
            {
                textBox.Focus();
                throw new Exception($"Invalid numeric value entered in {textBox.Name}.");
            }

            return value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}