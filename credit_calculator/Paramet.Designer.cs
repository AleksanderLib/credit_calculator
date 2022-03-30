namespace credit_calculator
{
    partial class Paramet
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumplatezh = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.srok_platezh = new System.Windows.Forms.TextBox();
            this.cmb_srok_kredit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Procent_stavka = new System.Windows.Forms.TextBox();
            this.cmb_proc_stavka = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edinovrem_kommis = new System.Windows.Forms.TextBox();
            this.cmb_edinov_kommis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_vid_platezh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры кредита ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма платежа:";
            // 
            // sumplatezh
            // 
            this.sumplatezh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumplatezh.Location = new System.Drawing.Point(242, 49);
            this.sumplatezh.Name = "sumplatezh";
            this.sumplatezh.Size = new System.Drawing.Size(180, 22);
            this.sumplatezh.TabIndex = 2;
            this.sumplatezh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sumplatezh_KeyPress);
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_type.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Р",
            "$",
            "€"});
            this.cmb_type.Location = new System.Drawing.Point(437, 49);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(42, 23);
            this.cmb_type.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок кредита:";
            // 
            // srok_platezh
            // 
            this.srok_platezh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srok_platezh.Location = new System.Drawing.Point(242, 82);
            this.srok_platezh.Name = "srok_platezh";
            this.srok_platezh.Size = new System.Drawing.Size(180, 22);
            this.srok_platezh.TabIndex = 5;
            this.srok_platezh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.srok_platezh_KeyPress);
            // 
            // cmb_srok_kredit
            // 
            this.cmb_srok_kredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_srok_kredit.Items.AddRange(new object[] {
            "мec",
            "год"});
            this.cmb_srok_kredit.Location = new System.Drawing.Point(437, 82);
            this.cmb_srok_kredit.Name = "cmb_srok_kredit";
            this.cmb_srok_kredit.Size = new System.Drawing.Size(56, 23);
            this.cmb_srok_kredit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Процентная ставка:";
            // 
            // Procent_stavka
            // 
            this.Procent_stavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Procent_stavka.Location = new System.Drawing.Point(242, 117);
            this.Procent_stavka.Name = "Procent_stavka";
            this.Procent_stavka.Size = new System.Drawing.Size(180, 22);
            this.Procent_stavka.TabIndex = 8;
            this.Procent_stavka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Procent_stavka_KeyPress);
            // 
            // cmb_proc_stavka
            // 
            this.cmb_proc_stavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_proc_stavka.FormattingEnabled = true;
            this.cmb_proc_stavka.Items.AddRange(new object[] {
            "%  на мес",
            "%  на год"});
            this.cmb_proc_stavka.Location = new System.Drawing.Point(437, 117);
            this.cmb_proc_stavka.Name = "cmb_proc_stavka";
            this.cmb_proc_stavka.Size = new System.Drawing.Size(97, 23);
            this.cmb_proc_stavka.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Единовременная комиссии:";
            // 
            // edinovrem_kommis
            // 
            this.edinovrem_kommis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edinovrem_kommis.Location = new System.Drawing.Point(242, 192);
            this.edinovrem_kommis.Name = "edinovrem_kommis";
            this.edinovrem_kommis.Size = new System.Drawing.Size(180, 22);
            this.edinovrem_kommis.TabIndex = 11;
            this.edinovrem_kommis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edinovrem_kommis_KeyPress);
            // 
            // cmb_edinov_kommis
            // 
            this.cmb_edinov_kommis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_edinov_kommis.FormattingEnabled = true;
            this.cmb_edinov_kommis.Items.AddRange(new object[] {
            "Фиксированный ",
            "Процентный"});
            this.cmb_edinov_kommis.Location = new System.Drawing.Point(437, 193);
            this.cmb_edinov_kommis.Name = "cmb_edinov_kommis";
            this.cmb_edinov_kommis.Size = new System.Drawing.Size(120, 23);
            this.cmb_edinov_kommis.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вид платежа:";
            // 
            // cmb_vid_platezh
            // 
            this.cmb_vid_platezh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_vid_platezh.FormattingEnabled = true;
            this.cmb_vid_platezh.Items.AddRange(new object[] {
            "Деференцированный",
            "Аннуитетный"});
            this.cmb_vid_platezh.Location = new System.Drawing.Point(242, 225);
            this.cmb_vid_platezh.Name = "cmb_vid_platezh";
            this.cmb_vid_platezh.Size = new System.Drawing.Size(180, 23);
            this.cmb_vid_platezh.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Начало выплат:";
            // 
            // cb_month
            // 
            this.cb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cb_month.Location = new System.Drawing.Point(242, 261);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(105, 23);
            this.cb_month.TabIndex = 16;
            // 
            // cb_year
            // 
            this.cb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(365, 260);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(57, 23);
            this.cb_year.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(217, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Paramet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_vid_platezh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_edinov_kommis);
            this.Controls.Add(this.edinovrem_kommis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_proc_stavka);
            this.Controls.Add(this.Procent_stavka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_srok_kredit);
            this.Controls.Add(this.srok_platezh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.sumplatezh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Paramet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитный калькулятор ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumplatezh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox srok_platezh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Procent_stavka;
        private System.Windows.Forms.ComboBox cmb_proc_stavka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edinovrem_kommis;
        private System.Windows.Forms.ComboBox cmb_edinov_kommis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_vid_platezh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_srok_kredit;
        private System.Windows.Forms.ComboBox cmb_type;
    }
}

