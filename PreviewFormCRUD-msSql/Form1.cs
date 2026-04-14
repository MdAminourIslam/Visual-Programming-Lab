using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dbConnection
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> divisionDistricts = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
            InitializeDivisionData();
            PopulateDivisions();

            // default gender selection
            try
            {
                if (rbMale != null) rbMale.Checked = true;
            }
            catch { }
        }

        private void InitializeDivisionData()
        {
            divisionDistricts.Clear();
            divisionDistricts["Dhaka"] = new List<string> { "Dhaka", "Tangail", "Gazipur", "Narayanganj", "Manikganj" };
            divisionDistricts["Chattogram"] = new List<string> { "Chattogram", "Cox's Bazar", "Rangamati", "Bandarban" };
            divisionDistricts["Rajshahi"] = new List<string> { "Rajshahi", "Bogra", "Natore", "Pabna" };
            divisionDistricts["Khulna"] = new List<string> { "Khulna", "Jessore", "Satkhira", "Bagerhat" };
            divisionDistricts["Barisal"] = new List<string> { "Barisal", "Bhola", "Patuakhali", "Barguna" };
            divisionDistricts["Sylhet"] = new List<string> { "Sylhet", "Moulvibazar", "Habiganj", "Sunamganj" };
            divisionDistricts["Mymensingh"] = new List<string> { "Mymensingh", "Jamalpur", "Sherpur", "Netrokona" };
            divisionDistricts["Rangpur"] = new List<string> { "Rangpur", "Dinajpur", "Lalmonirhat", "Kurigram" };
        }

        private void PopulateDivisions()
        {
            cbDivision.Items.Clear();
            foreach (var div in divisionDistricts.Keys)
            {
                cbDivision.Items.Add(div);
            }
            if (cbDivision.Items.Count > 0)
                cbDivision.SelectedIndex = 0;
        }

        private void cbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = cbDivision.SelectedItem as string;
            cbDistrict.Items.Clear();
            if (sel != null && divisionDistricts.ContainsKey(sel))
            {
                foreach (var d in divisionDistricts[sel])
                {
                    cbDistrict.Items.Add(d);
                }
                if (cbDistrict.Items.Count > 0)
                    cbDistrict.SelectedIndex = 0;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var gender = string.Empty;
            try
            {
                if (rbMale != null && rbMale.Checked) gender = "Male";
                else if (rbFemale != null && rbFemale.Checked) gender = "Female";
            }
            catch { }

            var hobbyList = new List<string>();
            try
            {
                if (chkReading != null && chkReading.Checked) hobbyList.Add("Reading");
                if (chkTraveling != null && chkTraveling.Checked) hobbyList.Add("Traveling");
            }
            catch { }
            var hobbyCsv = string.Join(", ", hobbyList);

            var data = new CustomerData
            {
                Name = txtName.Text,
                Division = cbDivision.SelectedItem as string,
                District = cbDistrict.SelectedItem as string,
                Gender = gender,
                Phone = txtPhone.Text,
                Hobby = hobbyCsv
            };

            using (var preview = new PreviewForm(data))
            {
                var res = preview.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // insertion handled in preview form
                }
            }
        }
    }

    public class CustomerData
    {
        public string Name { get; set; }
        public string Division { get; set; }
        public string District { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Hobby { get; set; }
    }
}
