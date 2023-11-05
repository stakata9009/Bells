using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bells
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();

            LoadNames();
        }

        private void LoadNames()
        {
            string json = File.ReadAllText("tables.json");
            List<timeTables> tables = JsonSerializer.Deserialize<List<timeTables>>(json);

            foreach (timeTables table in tables)
            {
                comboBox1.Items.Add(table.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string json = File.ReadAllText("tables.json");
            List<timeTables> tables = JsonSerializer.Deserialize<List<timeTables>>(json);

            string selectedTable = comboBox1.SelectedItem.ToString();

            timeTables selected = tables.Find(obj => obj.Name == selectedTable);

            cl1_Start_h.Value = selected.cl1_Start_h;
            cl1_Start_m.Value = selected.cl1_Start_m;
            cl1_End_h.Value = selected.cl1_End_h;
            cl1_End_m.Value = selected.cl1_End_m;

            cl2_Start_h.Value = selected.cl2_Start_h;
            cl2_Start_m.Value = selected.cl2_Start_m;
            cl2_End_h.Value = selected.cl2_End_h;
            cl2_End_m.Value = selected.cl2_End_m;

            cl3_Start_h.Value = selected.cl3_Start_h;
            cl3_Start_m.Value = selected.cl3_Start_m;
            cl3_End_h.Value = selected.cl3_End_h;
            cl3_End_m.Value = selected.cl3_End_m;

            cl4_Start_h.Value = selected.cl4_Start_h;
            cl4_Start_m.Value = selected.cl4_Start_m;
            cl4_End_h.Value = selected.cl4_End_h;
            cl4_End_m.Value = selected.cl4_End_m;

            cl5_Start_h.Value = selected.cl5_Start_h;
            cl5_Start_m.Value = selected.cl5_Start_m;
            cl5_End_h.Value = selected.cl5_End_h;
            cl5_End_m.Value = selected.cl5_End_m;

            cl6_Start_h.Value = selected.cl6_Start_h;
            cl6_Start_m.Value = selected.cl6_Start_m;
            cl6_End_h.Value = selected.cl6_End_h;
            cl6_End_m.Value = selected.cl6_End_m;

            cl7_Start_h.Value = selected.cl7_Start_h;
            cl7_Start_m.Value = selected.cl7_Start_m;
            cl7_End_h.Value = selected.cl7_End_h;
            cl7_End_m.Value = selected.cl7_End_m;

            cl8_Start_h.Value = selected.cl8_Start_h;
            cl8_Start_m.Value = selected.cl8_Start_m;
            cl8_End_h.Value = selected.cl8_End_h;
            cl8_End_m.Value = selected.cl8_End_m;

            cl9_Start_h.Value = selected.cl9_Start_h;
            cl9_Start_m.Value = selected.cl9_Start_m;
            cl9_End_h.Value = selected.cl9_End_h;
            cl9_End_m.Value = selected.cl9_End_m;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this == ActiveForm)
            {
                DialogResult delete = MessageBox.Show("Сигурни ли сте, че искате да изтриете това рразписание", "Изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes && comboBox1.SelectedItem != null)
                {
                    string json = File.ReadAllText("tables.json");
                    List<timeTables> tables = JsonSerializer.Deserialize<List<timeTables>>(json);

                    string selectedTable = comboBox1.SelectedItem.ToString();

                    timeTables selected = tables.Find(obj => obj.Name == selectedTable);

                    if (selected != null)
                    {
                        comboBox1.Items.Remove(selectedTable);

                        tables.Remove(selected);

                        string updateJson = JsonSerializer.Serialize(tables);

                        File.WriteAllText("tables.json", updateJson);

                        MessageBox.Show("Разписанието е изтррито успешно", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Моля, изберете разписание от списъка.", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this == ActiveForm)
            {
                DialogResult edit = MessageBox.Show("Сигурни ли сте, че искате да промените това рразписание", "Промяна", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (edit == DialogResult.Yes && comboBox1.SelectedItem != null)
                {
                    string json = File.ReadAllText("tables.json");
                    List<timeTables> tables = JsonSerializer.Deserialize<List<timeTables>>(json);

                    string selectedTable = comboBox1.SelectedItem.ToString();

                    timeTables selected = tables.Find(obj => obj.Name == selectedTable);

                    selected.cl1_Start_h = (int)cl1_Start_h.Value;
                    selected.cl1_Start_m = (int)cl1_Start_m.Value;
                    selected.cl1_End_h = (int)cl1_End_h.Value;
                    selected.cl1_End_m = (int)cl1_End_m.Value;

                    selected.cl2_Start_h = (int)cl2_Start_h.Value;
                    selected.cl2_Start_m = (int)cl2_Start_m.Value;
                    selected.cl2_End_h = (int)cl2_End_h.Value;
                    selected.cl2_End_m = (int)cl2_End_m.Value;

                    selected.cl3_Start_h = (int)cl3_Start_h.Value;
                    selected.cl3_Start_m = (int)cl3_Start_m.Value;
                    selected.cl3_End_h = (int)cl3_End_h.Value;
                    selected.cl3_End_m = (int)cl3_End_m.Value;

                    selected.cl4_Start_h = (int)cl4_Start_h.Value;
                    selected.cl4_Start_m = (int)cl4_Start_m.Value;
                    selected.cl4_End_h = (int)cl4_End_h.Value;
                    selected.cl4_End_m = (int)cl4_End_m.Value;

                    selected.cl5_Start_h = (int)cl5_Start_h.Value;
                    selected.cl5_Start_m = (int)cl5_Start_m.Value;
                    selected.cl5_End_h = (int)cl5_End_h.Value;
                    selected.cl5_End_m = (int)cl5_End_m.Value;

                    selected.cl6_Start_h = (int)cl6_Start_h.Value;
                    selected.cl6_Start_m = (int)cl6_Start_m.Value;
                    selected.cl6_End_h = (int)cl6_End_h.Value;
                    selected.cl6_End_m = (int)cl6_End_m.Value;

                    selected.cl7_Start_h = (int)cl7_Start_h.Value;
                    selected.cl7_Start_m = (int)cl7_Start_m.Value;
                    selected.cl7_End_h = (int)cl7_End_h.Value;
                    selected.cl7_End_m = (int)cl7_End_m.Value;

                    selected.cl8_Start_h = (int)cl8_Start_h.Value;
                    selected.cl8_Start_m = (int)cl8_Start_m.Value;
                    selected.cl8_End_h = (int)cl8_End_h.Value;
                    selected.cl8_End_m = (int)cl8_End_m.Value;

                    selected.cl9_Start_h = (int)cl9_Start_h.Value;
                    selected.cl9_Start_m = (int)cl9_Start_m.Value;
                    selected.cl9_End_h = (int)cl9_End_h.Value;
                    selected.cl9_End_m = (int)cl9_End_m.Value;

                    string updateJson = JsonSerializer.Serialize(tables);

                    File.WriteAllText("tables.json", updateJson);

                    MessageBox.Show("Разписанието е записано успешно!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Моля, изберете разписание от списъка.", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
