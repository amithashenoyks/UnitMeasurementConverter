using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitMeasurementConverter
{
    //calss holds list of unit type.
    class Units
    {
        private string _unit;

        public Units(string unit)
        {
            _unit = unit;
        }
        public string Unit
        {
            get
            {
                return _unit;
            }
        }


        private List<Units> _unitList;

        public List<Units> unitList
        {

            get
            {
                _unitList = new List<Units>();

                _unitList.Add(new Units("Inch"));
                _unitList.Add(new Units("Foot"));
                _unitList.Add(new Units("Centimetre"));
                _unitList.Add(new Units("Metre"));


                return _unitList;
            }
        }




    }

    //class,to do unit conversion
    public static class UnitMeasurement
    {

        public static string Converter(double numbertoconvert, int rowinedx, int columnindex)
        {
            var result = numbertoconvert * LengthMatrix[rowinedx, columnindex];
            return result.ToString();
        }

        private static double[,] LengthMatrix = {
            {1.0, 1.0/12, 1.0*2.54,1.0/39.37}, //inches
            { 1.0*12,1.0,1.0*30.48,1.0/3.281 },//foot
            {1.0/2.54,1.0/30.48,1.0,1.0/100 },//centimetre
            {1.0*39.37,1.0* 3.281,1.0*100,1.0}//metre
            };
    }
}
