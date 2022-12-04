namespace Week_1_1_DZ_2_meet_2_save_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string? richline = "";
            StreamWriter sw = new StreamWriter("Test.txt");
            sw.WriteLine(name_tbox.Text);
            sw.WriteLine(lastname_tbox.Text);
            sw.WriteLine(patronymic_tbox.Text);
            sw.WriteLine(GenderChios());
            sw.WriteLine(date_tbox.Text);
            sw.WriteLine(Family_status_cbox.Text);
            for(int i = 0; i < dopinfo_rtbox.Lines.Length; i++)
            {
                richline = dopinfo_rtbox.Lines[i].ToString();
                sw.WriteLine(richline);
            }
            sw.Close();
            

        }
        private string GenderChios()
        {
            if (other_gender_tbox.TextLength == 0)
            {
                if (male_chbox.Checked == true)
                {
                    return "Муж.";
                }
                else if (female_chbox.Checked == true)
                {
                    return "Жен.";
                }
                else
                {
                    return "Не выбран пол!";
                }
            }
            else
            {
                return other_gender_tbox.Text;
            }
        }

        private void male_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (other_gender_tbox.TextLength > 0)
            {
                male_chbox.Checked = false;
            }
                female_chbox.Checked = false;
        }

        private void female_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (other_gender_tbox.TextLength > 0)
            {
                female_chbox.Checked = false;
            }
            male_chbox.Checked = false;
        }
    }
}