using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bells
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Моля въведете име на разписаанието", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string json = File.ReadAllText("tables.json");

                List<timeTables> tables = JsonSerializer.Deserialize<List<timeTables>>(json);

                string checkName = tbName.Text;
                bool nameExists = false;

                foreach (timeTables table in tables)
                {
                    if (table.Name == checkName)
                    {
                        nameExists = true;
                        MessageBox.Show("Разписание с това име вече съществува", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (nameExists == false)
                {
                    timeTables newTable = new timeTables
                    {
                        Name = tbName.Text,
                        cl1_Start_h = (int)cl1_Start_h.Value,
                        cl1_Start_m = (int)cl1_Start_m.Value,
                        cl1_End_h = (int)cl1_End_h.Value,
                        cl1_End_m = (int)cl1_End_m.Value,

                        cl2_Start_h = (int)cl2_Start_h.Value,
                        cl2_Start_m = (int)cl2_Start_m.Value,
                        cl2_End_h = (int)cl2_End_h.Value,
                        cl2_End_m = (int)cl2_End_m.Value,

                        cl3_Start_h = (int)cl3_Start_h.Value,
                        cl3_Start_m = (int)cl3_Start_m.Value,
                        cl3_End_h = (int)cl3_End_h.Value,
                        cl3_End_m = (int)cl3_End_m.Value,

                        cl4_Start_h = (int)cl4_Start_h.Value,
                        cl4_Start_m = (int)cl4_Start_m.Value,
                        cl4_End_h = (int)cl4_End_h.Value,
                        cl4_End_m = (int)cl4_End_m.Value,

                        cl5_Start_h = (int)cl5_Start_h.Value,
                        cl5_Start_m = (int)cl5_Start_m.Value,
                        cl5_End_h = (int)cl5_End_h.Value,
                        cl5_End_m = (int)cl5_End_m.Value,

                        cl6_Start_h = (int)cl6_Start_h.Value,
                        cl6_Start_m = (int)cl6_Start_m.Value,
                        cl6_End_h = (int)cl6_End_h.Value,
                        cl6_End_m = (int)cl6_End_m.Value,

                        cl7_Start_h = (int)cl7_Start_h.Value,
                        cl7_Start_m = (int)cl7_Start_m.Value,
                        cl7_End_h = (int)cl7_End_h.Value,
                        cl7_End_m = (int)cl7_End_m.Value,

                        cl8_Start_h = (int)cl8_Start_h.Value,
                        cl8_Start_m = (int)cl8_Start_m.Value,
                        cl8_End_h = (int)cl8_End_h.Value,
                        cl8_End_m = (int)cl8_End_m.Value,

                        cl9_Start_h = (int)cl9_Start_h.Value,
                        cl9_Start_m = (int)cl9_Start_m.Value,
                        cl9_End_h = (int)cl9_End_h.Value,
                        cl9_End_m = (int)cl9_End_m.Value
                    };

                    tables.Add(newTable);

                    string updateJson = JsonSerializer.Serialize(tables);

                    File.WriteAllText("tables.json", updateJson);

                    MessageBox.Show("Разписанието е записано успешно!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
