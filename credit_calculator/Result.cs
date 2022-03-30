using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace credit_calculator
{

    public partial class Result : Form
    {

        int i_M1,i_Y1;
        
        public Result(int i_Y,int i_M,int i_T,string []masM,string []masY,string []masT,string tx_srok_platezh, string tx_sumplatezh, string tx_Procent_stavka, int cmb_srok_kredit, int cmb_proc_stavka, int cmb_vid_platezh, int cmb_month,int cmb_edinov_kommis,string edinovrem_kommis)
        {

            InitializeComponent();

            this.tx_srok_platezh = tx_srok_platezh;
            this.tx_sumplatezh = tx_sumplatezh;
            this.tx_Procent_stavka = tx_Procent_stavka;
            this.cmb_srok_kredit = cmb_srok_kredit;
            this.cmb_proc_stavka = cmb_proc_stavka;
            this.cmb_vid_platezh = cmb_vid_platezh;
            this.cmb_month = cmb_month;
            this.edinovrem_kommis = edinovrem_kommis;
            this.cmb_edinov_kommis= cmb_edinov_kommis;

            double payment_term = 0, debetBalance = 0, interest_rate = 0, d_precent_rate = 0, payment = 0, repayment = 0, repay_payment = 0,pracentpaym=0;
            double def_payment = 0, sum_interes_proc = 0,d_totalamount=0,d_pcenOverpayment=0,d_commisOverpay=0,d_edinovremkommis =0, d_commisdebt = 0;
            Boolean b_payment_term = true, b_interest_rate = true, b_vid_plt=true,b_commission=true;

            i_M1 = i_M;
            i_Y1 = i_Y;
            
            
                payment_term = Convert.ToDouble(tx_srok_platezh);
                debetBalance = Convert.ToDouble(tx_sumplatezh);
                interest_rate = Convert.ToDouble(tx_Procent_stavka);
                b_payment_term = Convert.ToBoolean(cmb_srok_kredit);
                b_interest_rate = Convert.ToBoolean(cmb_proc_stavka);
                b_vid_plt = Convert.ToBoolean(cmb_vid_platezh);
                b_commission = Convert.ToBoolean(cmb_edinov_kommis);
                d_edinovremkommis = Convert.ToDouble(edinovrem_kommis);
            

            
            d_commisdebt = debetBalance;
            if (b_vid_plt)
            {
                if (b_payment_term)
                {
                    payment_term = payment_term * 12;
                }

                if (b_interest_rate)
                {
                    d_precent_rate = interest_rate / 100 / 12;

                }
                else
                {
                    d_precent_rate = interest_rate / 100;

                }
                payment = debetBalance * (d_precent_rate + (d_precent_rate / (Math.Pow(1 + d_precent_rate, payment_term) - 1)));
                
                for (int i = 0; i < payment_term; i++)
                {
                    repayment = debetBalance * d_precent_rate;
                    repay_payment = payment - repayment;//основной долг
                    debetBalance -= repay_payment;//остаток задолжности
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = masM[i_M]+" "+ i_Y;
                    dataGridView1.Rows[i].Cells[2].Value = payment.ToString("0.0#")+""+masT[i_T];
                    dataGridView1.Rows[i].Cells[3].Value = repay_payment.ToString("0.0#")+ "" + masT[i_T];
                    dataGridView1.Rows[i].Cells[4].Value = repayment.ToString("0.0#")+ "" + masT[i_T];
                    dataGridView1.Rows[i].Cells[5].Value = debetBalance.ToString("0.0#")+ "" + masT[i_T];
                    d_totalamount += repay_payment + repayment;
                    d_pcenOverpayment += repayment;

                    if (i_M >= 11)
                    {
                        i_Y++;
                        i_M = 0;
                    }
                    else
                    { i_M++; }

                    if (b_commission)
                    {
                        d_commisOverpay = ((d_edinovremkommis / 100) * d_commisdebt)+d_pcenOverpayment;   
                    }
                    else
                    {
                        d_commisOverpay = d_edinovremkommis +d_pcenOverpayment;
                    }
                }
                label6.Text = d_totalamount.ToString("0.0#")+""+masT[i_T];
                label5.Text = d_pcenOverpayment.ToString("0.0#") + "" + masT[i_T];
                label4.Text = d_commisOverpay.ToString("0.0#") + "" + masT[i_T];
            }
            else
            {                
                    if (b_payment_term)
                    {
                        payment_term = payment_term * 12;
                    }

                    if (b_interest_rate)
                    {
                        d_precent_rate = interest_rate / 100 / 12;

                    }
                    else
                    {
                        d_precent_rate = interest_rate / 100;
                    }
                
                pracentpaym = debetBalance / payment_term;//основной долг 


                for (int i = 0; i < payment_term; i++)
                {
                    sum_interes_proc = debetBalance * d_precent_rate;//начисленные проценты
                    def_payment = pracentpaym + sum_interes_proc;//сумма платежа
                    debetBalance -= pracentpaym;//остаток задолжности
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = masM[i_M] + " " + i_Y;
                    dataGridView1.Rows[i].Cells[2].Value = def_payment.ToString("0.0#") + "" + masT[i_T];
                    dataGridView1.Rows[i].Cells[3].Value = pracentpaym.ToString("0.0#") + "" + masT[i_T];
                    dataGridView1.Rows[i].Cells[4].Value = sum_interes_proc.ToString("0.0#") + "" + masT[i_T];
                    dataGridView1.Rows[i].Cells[5].Value = debetBalance.ToString("0.0#") + "" + masT[i_T];
                    d_totalamount += pracentpaym + sum_interes_proc;
                    d_pcenOverpayment += sum_interes_proc;

                    if (i_M >= 11)
                    {
                        i_Y++;
                        i_M = 0;
                    }
                    else
                    { i_M++; }

                    if (b_commission)
                    {
                        d_commisOverpay = ((d_edinovremkommis / 100) * d_commisdebt) + d_pcenOverpayment;
                    }
                    else
                    {
                        d_commisOverpay = d_edinovremkommis + d_pcenOverpayment;
                    }
                }
                label6.Text = d_totalamount.ToString("0.0#") + "" + masT[i_T];
                label5.Text = d_pcenOverpayment.ToString("0.0#") + "" + masT[i_T];
                label4.Text = d_commisOverpay.ToString("0.0#") + "" + masT[i_T];

            }

            }

        string tx_srok_platezh, tx_sumplatezh, tx_Procent_stavka, edinovrem_kommis;
        int cmb_srok_kredit, cmb_proc_stavka, cmb_vid_platezh,cmb_month, cmb_edinov_kommis;

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd_save = new SaveFileDialog();
            sfd_save.Filter = String.Format(".csv|*{0}", ".csv");

            if (sfd_save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw_save = new StreamWriter(sfd_save.FileName, false, System.Text.Encoding.Default);
                sw_save.WriteLine("Номер;Дата;Сумма;Долг;Проценты;Остаток");
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        //Разделителем выступает ";" по причине особенности рускоязычной версии Microsoft Excel в котором в отличии от англоязычной версии разделителем является ";"
                        if (j == 1)
                        {
                            if (i_M1 < 9)

                                sw_save.Write("0" + (i_M1 + 1) + "-" + i_Y1 + ";");
                            else
                                sw_save.Write((i_M1 + 1) + "-" + i_Y1 + ";");
                            if (i_M1 >= 11)
                            {
                                i_Y1++;
                                i_M1 = 0;
                            }
                            else
                                i_M1++;
                        }
                        else
                            sw_save.Write(dataGridView1.Rows[i].Cells[j].Value + ";");
                    }
                    sw_save.WriteLine();
                }
                sw_save.Close();
                MessageBox.Show(this, "Успешно сохранено", "Успешно");
            }
            }
        }
    }
