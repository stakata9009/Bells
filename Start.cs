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
using WMPLib;

namespace Bells
{
    public partial class Start : Form
    {
        //We declare the player and selectedFile here so that we may have access to them from everywhere else in the program
        WindowsMediaPlayer playerStart = new WindowsMediaPlayer();
        WindowsMediaPlayer playerEnd = new WindowsMediaPlayer();

        bool cl1_Start_Flag = true;
        bool cl1_End_Flag = true;

        bool cl2_Start_Flag = true;
        bool cl2_End_Flag = true;

        bool cl3_Start_Flag = true;
        bool cl3_End_Flag = true;

        bool cl4_Start_Flag = true;
        bool cl4_End_Flag = true;

        bool cl5_Start_Flag = true;
        bool cl5_End_Flag = true;

        bool cl6_Start_Flag = true;
        bool cl6_End_Flag = true;

        bool cl7_Start_Flag = true;
        bool cl7_End_Flag = true;

        bool cl8_Start_Flag = true;
        bool cl8_End_Flag = true;

        bool cl9_Start_Flag = true;
        bool cl9_End_Flag = true;

        int cl1_Start_Selected_h;
        int cl1_Start_Selected_m;
        int cl1_End_Selected_h;
        int cl1_End_Selected_m;

        int cl2_Start_Selected_h;
        int cl2_Start_Selected_m;
        int cl2_End_Selected_h;
        int cl2_End_Selected_m;

        int cl3_Start_Selected_h;
        int cl3_Start_Selected_m;
        int cl3_End_Selected_h;
        int cl3_End_Selected_m;

        int cl4_Start_Selected_h;
        int cl4_Start_Selected_m;
        int cl4_End_Selected_h;
        int cl4_End_Selected_m;

        int cl5_Start_Selected_h;
        int cl5_Start_Selected_m;
        int cl5_End_Selected_h;
        int cl5_End_Selected_m;

        int cl6_Start_Selected_h;
        int cl6_Start_Selected_m;
        int cl6_End_Selected_h;
        int cl6_End_Selected_m;

        int cl7_Start_Selected_h;
        int cl7_Start_Selected_m;
        int cl7_End_Selected_h;
        int cl7_End_Selected_m;

        int cl8_Start_Selected_h;
        int cl8_Start_Selected_m;
        int cl8_End_Selected_h;
        int cl8_End_Selected_m;

        int cl9_Start_Selected_h;
        int cl9_Start_Selected_m;
        int cl9_End_Selected_h;
        int cl9_End_Selected_m;

        public Start()
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
            playerStart.controls.stop();
            playerEnd.controls.stop();
            timer1.Enabled = false;

            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                timer1.Enabled = true;
                lblInfo.Text = "Звънецът е пуснат!";
                lblInfo.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                MessageBox.Show("Моля, изберете разписание от списъка.", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            playerStart.controls.stop();
            playerEnd.controls.stop();
            timer1.Enabled = false;
            lblTime.Text = "00:00:00";

            lblInfo.Text = "Звънецът е спрян!";
            lblInfo.ForeColor = Color.FromArgb(192, 0, 0);
        }

        private void btnStartSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog StartSong = new OpenFileDialog())
            {
                StartSong.Filter = "Sound Files|*.wav;*.mp3;*.ogg;*.wma|All Files|*.*";
                StartSong.Title = "Изберете мелодия за начало на часа.";

                if (StartSong.ShowDialog() == DialogResult.OK)
                {
                    playerStart.URL = StartSong.FileName;
                    playerStart.controls.stop();
                    lblStart.Text = StartSong.FileName;
                }
            }
        }

        private void btnEndSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog EndSong = new OpenFileDialog())
            {
                EndSong.Filter = "Sound Files|*.wav;*.mp3;*.ogg;*.wma|All Files|*.*";
                EndSong.Title = "Изберете мелодия за край на часа";

                if (EndSong.ShowDialog() == DialogResult.OK)
                {
                    playerEnd.URL = EndSong.FileName;
                    playerEnd.controls.stop();
                    lblEnd.Text = EndSong.FileName;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                cl1_Start_Selected_h = (int)cl1_Start_h.Value;
                cl1_Start_Selected_m = (int)cl1_Start_m.Value;
                cl1_End_Selected_h = (int)cl1_End_h.Value;
                cl1_End_Selected_m = (int)cl1_End_m.Value;

                cl2_Start_Selected_h = (int)cl2_Start_h.Value;
                cl2_Start_Selected_m = (int)cl2_Start_m.Value;
                cl2_End_Selected_h = (int)cl2_End_h.Value;
                cl2_End_Selected_m = (int)cl2_End_m.Value;

                cl3_Start_Selected_h = (int)cl3_Start_h.Value;
                cl3_Start_Selected_m = (int)cl3_Start_m.Value;
                cl3_End_Selected_h = (int)cl3_End_h.Value;
                cl3_End_Selected_m = (int)cl3_End_m.Value;

                cl4_Start_Selected_h = (int)cl4_Start_h.Value;
                cl4_Start_Selected_m = (int)cl4_Start_m.Value;
                cl4_End_Selected_h = (int)cl4_End_h.Value;
                cl4_End_Selected_m = (int)cl4_End_m.Value;

                cl5_Start_Selected_h = (int)cl5_Start_h.Value;
                cl5_Start_Selected_m = (int)cl5_Start_m.Value;
                cl5_End_Selected_h = (int)cl5_End_h.Value;
                cl5_End_Selected_m = (int)cl5_End_m.Value;

                cl6_Start_Selected_h = (int)cl6_Start_h.Value;
                cl6_Start_Selected_m = (int)cl6_Start_m.Value;
                cl6_End_Selected_h = (int)cl6_End_h.Value;
                cl6_End_Selected_m = (int)cl6_End_m.Value;

                cl7_Start_Selected_h = (int)cl7_Start_h.Value;
                cl7_Start_Selected_m = (int)cl7_Start_m.Value;
                cl7_End_Selected_h = (int)cl7_End_h.Value;
                cl7_End_Selected_m = (int)cl7_End_m.Value;

                cl8_Start_Selected_h = (int)cl8_Start_h.Value;
                cl8_Start_Selected_m = (int)cl8_Start_m.Value;
                cl8_End_Selected_h = (int)cl8_End_h.Value;
                cl8_End_Selected_m = (int)cl8_End_m.Value;

                cl9_Start_Selected_h = (int)cl9_Start_h.Value;
                cl9_Start_Selected_m = (int)cl9_Start_m.Value;
                cl9_End_Selected_h = (int)cl9_End_h.Value;
                cl9_End_Selected_m = (int)cl9_End_m.Value;

                MessageBox.Show("Разписанието е заредено успешно!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Моля, изберете разписание от списъка", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            lblTime.Text = currentTime.ToString(@"hh\:mm\:ss");

            // Class 1
            if (currentTime.Hours == cl1_Start_Selected_h && currentTime.Minutes == cl1_Start_Selected_m)
            {
                if (cl1_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl1_Start_Flag = false;
                }
            }
            else { cl1_Start_Flag = true; }
            if (currentTime.Hours == cl1_End_Selected_h && currentTime.Minutes == cl1_End_Selected_m)
            {
                if (cl1_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl1_End_Flag = false;
                }
            }
            else { cl1_End_Flag = true; }

            // Class 2
            if (currentTime.Hours == cl2_Start_Selected_h && currentTime.Minutes == cl2_Start_Selected_m)
            {
                if (cl2_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl2_Start_Flag = false;
                }
            }
            else { cl2_Start_Flag = true; }
            if (currentTime.Hours == cl2_End_Selected_h && currentTime.Minutes == cl2_End_Selected_m)
            {
                if (cl2_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl2_End_Flag = false;
                }
            }
            else { cl2_End_Flag = true; }

            // Class 3
            if (currentTime.Hours == cl3_Start_Selected_h && currentTime.Minutes == cl3_Start_Selected_m)
            {
                if (cl3_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl3_Start_Flag = false;
                }
            }
            else { cl3_Start_Flag = true; }
            if (currentTime.Hours == cl3_End_Selected_h && currentTime.Minutes == cl3_End_Selected_m)
            {
                if (cl3_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl3_End_Flag = false;
                }
            }
            else { cl3_End_Flag = true; }

            // Class 4
            if (currentTime.Hours == cl4_Start_Selected_h && currentTime.Minutes == cl4_Start_Selected_m)
            {
                if (cl4_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl4_Start_Flag = false;
                }
            }
            else { cl4_Start_Flag = true; }
            if (currentTime.Hours == cl4_End_Selected_h && currentTime.Minutes == cl4_End_Selected_m)
            {
                if (cl4_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl4_End_Flag = false;
                }
            }
            else { cl4_End_Flag = true; }

            // Class 5
            if (currentTime.Hours == cl5_Start_Selected_h && currentTime.Minutes == cl5_Start_Selected_m)
            {
                if (cl5_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl5_Start_Flag = false;
                }
            }
            else { cl5_Start_Flag = true; }
            if (currentTime.Hours == cl5_End_Selected_h && currentTime.Minutes == cl5_End_Selected_m)
            {
                if (cl5_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl5_End_Flag = false;
                }
            }
            else { cl5_End_Flag = true; }

            // Class 6
            if (currentTime.Hours == cl6_Start_Selected_h && currentTime.Minutes == cl6_Start_Selected_m)
            {
                if (cl6_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl6_Start_Flag = false;
                }
            }
            else { cl6_Start_Flag = true; }
            if (currentTime.Hours == cl6_End_Selected_h && currentTime.Minutes == cl6_End_Selected_m)
            {
                if (cl6_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl6_End_Flag = false;
                }
            }
            else { cl6_End_Flag = true; }

            // Class 7
            if (currentTime.Hours == cl7_Start_Selected_h && currentTime.Minutes == cl7_Start_Selected_m)
            {
                if (cl7_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl7_Start_Flag = false;
                }
            }
            else { cl7_Start_Flag = true; }
            if (currentTime.Hours == cl7_End_Selected_h && currentTime.Minutes == cl7_End_Selected_m)
            {
                if (cl7_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl7_End_Flag = false;
                }
            }
            else { cl7_End_Flag = true; }

            // Class 8
            if (currentTime.Hours == cl8_Start_Selected_h && currentTime.Minutes == cl8_Start_Selected_m)
            {
                if (cl8_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl8_Start_Flag = false;
                }
            }
            else { cl8_Start_Flag = true; }
            if (currentTime.Hours == cl8_End_Selected_h && currentTime.Minutes == cl8_End_Selected_m)
            {
                if (cl8_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl8_End_Flag = false;
                }
            }
            else { cl8_End_Flag = true; }

            // Class 9
            if (currentTime.Hours == cl9_Start_Selected_h && currentTime.Minutes == cl9_Start_Selected_m)
            {
                if (cl9_Start_Flag == true)
                {
                    playerStart.controls.play();
                    cl9_Start_Flag = false;
                }
            }
            else { cl9_Start_Flag = true; }
            if (currentTime.Hours == cl9_End_Selected_h && currentTime.Minutes == cl9_End_Selected_m)
            {
                if (cl9_End_Flag == true)
                {
                    playerEnd.controls.play();
                    cl9_End_Flag = false;
                }
            }
            else { cl9_End_Flag = true; }
        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {
            if (this == ActiveForm)
            {
                DialogResult StartNow = MessageBox.Show("Сигурни ли сте, че искате да пуснете звънеца за начало на часа сега?", "Начало на часа?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (StartNow == DialogResult.Yes)
                {
                    playerStart.controls.play();
                }
            }
        }

        private void btnEndNow_Click(object sender, EventArgs e)
        {
            if (this == ActiveForm)
            {
                DialogResult EndNow = MessageBox.Show("Сигурни ли сте, че искате да пуснете звънеца за край на часа сега?", "Край на часа?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (EndNow == DialogResult.Yes)
                {
                    playerEnd.controls.play();
                }
            }
        }
    }
}
