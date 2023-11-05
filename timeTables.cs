using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bells
{
    public class timeTables
    {
        public string Name {  get; set; }
        public int cl1_Start_h {  get; set; }
        public int cl1_Start_m { get; set; }
        public int cl1_End_h { get; set; }
        public int cl1_End_m { get; set; }
        public int cl2_Start_h { get; set; }
        public int cl2_Start_m { get; set; }
        public int cl2_End_h { get; set; }
        public int cl2_End_m { get; set; }
        public int cl3_Start_h { get; set; }
        public int cl3_Start_m { get; set; }
        public int cl3_End_h { get; set; }
        public int cl3_End_m { get; set; }
        public int cl4_Start_h { get; set; }
        public int cl4_Start_m { get; set; }
        public int cl4_End_h { get; set; }
        public int cl4_End_m { get; set; }
        public int cl5_Start_h { get; set; }
        public int cl5_Start_m { get; set; }
        public int cl5_End_h { get; set; }
        public int cl5_End_m { get; set; }
        public int cl6_Start_h { get; set; }
        public int cl6_Start_m { get; set; }
        public int cl6_End_h { get; set; }
        public int cl6_End_m { get; set; }
        public int cl7_Start_h { get; set; }
        public int cl7_Start_m { get; set; }
        public int cl7_End_h { get; set; }
        public int cl7_End_m { get; set; }
        public int cl8_Start_h { get; set; }
        public int cl8_Start_m { get; set; }
        public int cl8_End_h { get; set; }
        public int cl8_End_m { get; set; }
        public int cl9_Start_h { get; set; }
        public int cl9_Start_m { get; set; }
        public int cl9_End_h { get; set; }
        public int cl9_End_m { get; set; }
    }

    public class CustomNumericUpDown : NumericUpDown
    {
        public CustomNumericUpDown()
        {
        }

        protected override void UpdateEditText()
        {
            if (Value < 10)
            {
                this.Text = "0" + Value;
            }
            else
            {
                base.UpdateEditText();
            }
        }
    }
}
