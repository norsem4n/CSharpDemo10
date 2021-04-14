/* CIS 605 Homework Set 5 - Program 10
 * Created By:      Christopher Karnas
 * Date Created:    October 2020
 * Last Modified:   10.21.2020
 * Class Name:      Form1
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PropertyTax aPropertyTax;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // check textbox name

            if (txtOwnerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Applicant name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerName.Focus();
                return;
            }

            //declare method level variables

            string ownerName;
            int bldgSqFt, landSqFt, yearBuilt;
            LocationType propType;

            // assign inputs

            ownerName = lblOnwerName.Text;
            bldgSqFt = Convert.ToInt32(nudBldgSF.Value);
            landSqFt = Convert.ToInt32(nudLandSF.Value);
            yearBuilt = Convert.ToInt32(nudYear.Value);

            propType = (radioCity.Checked) ? LocationType.City : (radioSuburb.Checked) ? LocationType.Suburb : LocationType.Rural;

            // instantiate PropertyTax object

            aPropertyTax = new PropertyTax(ownerName, bldgSqFt, landSqFt, yearBuilt, propType);

            // display message 

            string strCharges = $"Building Age: {aPropertyTax.BuildingAge.ToString("n0")} \nBuilding Tax: {aPropertyTax.BldgTax.ToString("C")} \nLand Tax: {aPropertyTax.LandTax.ToString("C")} \nBuilding Tax Deduction: -{aPropertyTax.BldgTaxDeduction.ToString("C")} \nLand Tax Deduction: -{aPropertyTax.LandTaxDeduction.ToString("C")} \nTotal Property Tax: {aPropertyTax.TotalPropTax.ToString("C")}";

            //display result

            lblResult.Text = strCharges;

            //disable controls
            btnCreate.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudYear.Maximum = DateTime.Today.Year;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // reset form functions
            txtOwnerName.Text = null;
            nudBldgSF.Value = nudBldgSF.Minimum;
            nudLandSF.Value = nudLandSF.Minimum;
            radioCity.Checked = true;
            lblResult.Text = null;

            //enable controls
            btnCreate.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
