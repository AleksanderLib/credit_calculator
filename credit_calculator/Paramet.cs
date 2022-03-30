using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace credit_calculator
{

    public partial class Paramet : Form
    {

        public Paramet()
        {
            InitializeComponent();
            edinovrem_kommis.Text = "0";
            cmb_type.SelectedIndex = 0;
            cb_month.SelectedIndex = 0;
            cmb_edinov_kommis.SelectedIndex = 1;
            cmb_proc_stavka.SelectedIndex = 1;
            cmb_srok_kredit.SelectedIndex = 0;
            cmb_vid_platezh.SelectedIndex = 1;
            cmb_srok_kredit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_edinov_kommis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_proc_stavka.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_month.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_year.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_vid_platezh.DropDownStyle = ComboBoxStyle.DropDownList;

            int i = 0;
            for (i = 1990; i <= 2100; i++)
            {
                cb_year.Items.Add(i);  
            }
            cb_year.SelectedIndex = 29;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string[] masT = new string[cmb_type.Items.Count];

            for (int i = 0; i < cmb_type.Items.Count; i++)
            {
                masT[i] = cmb_type.Items[i].ToString();
            }
            int i_T = cmb_type.SelectedIndex;

            string[] masM = new string[cb_year.Items.Count];
            string[] masY = new string[cb_year.Items.Count];
            int i_M = Convert.ToInt32(cb_month.SelectedIndex);
            int i_Y = Convert.ToInt32(cb_year.SelectedItem);
            for (int i_month = 0; i_month < cb_month.Items.Count; i_month++)
            {
                masM[i_month] = cb_month.Items[i_month].ToString();

            }
            
            try
            {
                Result rez = new Result(i_Y, i_M, i_T, masM, masY, masT, this.srok_platezh.Text, sumplatezh.Text, Procent_stavka.Text, cmb_srok_kredit.SelectedIndex, cmb_proc_stavka.SelectedIndex, cmb_vid_platezh.SelectedIndex, cb_month.SelectedIndex, cmb_edinov_kommis.SelectedIndex, edinovrem_kommis.Text);
                rez.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Введите значение во все строки");
            }
             
        }

        private void sumplatezh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' && sumplatezh.SelectionStart == 0)
                e.Handled = true;

            if (Char.IsNumber(e.KeyChar)| e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void Procent_stavka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' && Procent_stavka.SelectionStart == 0)
                e.Handled = true;
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;

        }

        private void edinovrem_kommis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (edinovrem_kommis.Text == "0" && e.KeyChar != 8)
                e.Handled = true;
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void srok_platezh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' && srok_platezh.SelectionStart == 0)
                e.Handled = true;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
