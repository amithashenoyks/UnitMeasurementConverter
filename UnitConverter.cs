using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitMeasurementConverter
{
    public partial class UnitConverter : Form
    {
        Units unitObj = new Units("");
        public UnitConverter()
        {
            InitializeComponent();
        }

        private void UnitConverter_Load(object sender, EventArgs e)
        {

            LoadUnitComboBox();
        }


        public void LoadUnitComboBox()
        {
            fromUnitList.DataSource = unitObj.unitList;
            fromUnitList.SelectedIndex = 0;
            fromUnitList.DisplayMember = "Unit";

            toUnitList.DataSource = unitObj.unitList;
            toUnitList.SelectedIndex = 0;
            toUnitList.DisplayMember = "Unit";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var numToConvert = Convert.ToDouble(inputTxtBox.Text);
            int rowindex = fromUnitList.SelectedIndex;
            int columnindex = toUnitList.SelectedIndex;

            outputTxtBox.Text = UnitMeasurement.Converter(numToConvert, rowindex, columnindex);

        }
    }
}
