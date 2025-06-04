namespace CSDesktopRadio
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.windowControlButton3 = new iNKORE.UI.WinForms.Styler.Controls.WindowControlButton();
            this.windowControlButton2 = new iNKORE.UI.WinForms.Styler.Controls.WindowControlButton();
            this.windowControlButton1 = new iNKORE.UI.WinForms.Styler.Controls.WindowControlButton();
            this.pbCaptIcon = new System.Windows.Forms.PictureBox();
            this.stylePanel1 = new iNKORE.UI.WinForms.Styler.Controls.StylePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRadioStation = new iNKORE.UI.WinForms.Styler.Controls.AdvComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlayPause = new Andy.UI.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegionIndex = new iNKORE.UI.WinForms.Styler.Controls.AdvComboBox();
            this.cbCity = new iNKORE.UI.WinForms.Styler.Controls.AdvComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptIcon)).BeginInit();
            this.stylePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCaption
            // 
            this.pnlCaption.BackColor = System.Drawing.Color.Transparent;
            this.pnlCaption.Controls.Add(this.label4);
            this.pnlCaption.Controls.Add(this.windowControlButton3);
            this.pnlCaption.Controls.Add(this.windowControlButton2);
            this.pnlCaption.Controls.Add(this.windowControlButton1);
            this.pnlCaption.Controls.Add(this.pbCaptIcon);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(800, 32);
            this.pnlCaption.TabIndex = 6;
            this.pnlCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Радио";
            // 
            // windowControlButton3
            // 
            this.windowControlButton3.Location = new System.Drawing.Point(688, 11);
            this.windowControlButton3.Name = "windowControlButton3";
            this.windowControlButton3.Size = new System.Drawing.Size(32, 16);
            this.windowControlButton3.Style = iNKORE.UI.WinForms.Styler.Controls.WindowControlButton.WindowControlButtonStyle.Minimize;
            this.windowControlButton3.TabIndex = 3;
            this.windowControlButton3.Text = "windowControlButton3";
            this.windowControlButton3.Click += new System.EventHandler(this.button1_Click);
            // 
            // windowControlButton2
            // 
            this.windowControlButton2.Enabled = false;
            this.windowControlButton2.Location = new System.Drawing.Point(722, 11);
            this.windowControlButton2.Name = "windowControlButton2";
            this.windowControlButton2.Size = new System.Drawing.Size(32, 16);
            this.windowControlButton2.Style = iNKORE.UI.WinForms.Styler.Controls.WindowControlButton.WindowControlButtonStyle.Maximize;
            this.windowControlButton2.TabIndex = 2;
            this.windowControlButton2.Text = "windowControlButton2";
            // 
            // windowControlButton1
            // 
            this.windowControlButton1.Location = new System.Drawing.Point(756, 11);
            this.windowControlButton1.Name = "windowControlButton1";
            this.windowControlButton1.Size = new System.Drawing.Size(32, 16);
            this.windowControlButton1.Style = iNKORE.UI.WinForms.Styler.Controls.WindowControlButton.WindowControlButtonStyle.Close;
            this.windowControlButton1.TabIndex = 1;
            this.windowControlButton1.Text = "windowControlButton1";
            this.windowControlButton1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbCaptIcon
            // 
            this.pbCaptIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCaptIcon.Location = new System.Drawing.Point(11, 8);
            this.pbCaptIcon.Name = "pbCaptIcon";
            this.pbCaptIcon.Size = new System.Drawing.Size(16, 16);
            this.pbCaptIcon.TabIndex = 0;
            this.pbCaptIcon.TabStop = false;
            // 
            // stylePanel1
            // 
            this.stylePanel1.BackColor = System.Drawing.Color.Transparent;
            this.stylePanel1.Controls.Add(this.pnlCaption);
            this.stylePanel1.Controls.Add(this.panel1);
            this.stylePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylePanel1.Location = new System.Drawing.Point(0, 0);
            this.stylePanel1.Name = "stylePanel1";
            this.stylePanel1.Size = new System.Drawing.Size(800, 450);
            this.stylePanel1.TabIndex = 12;
            this.stylePanel1.Theme = iNKORE.UI.WinForms.Styler.Controls.StylePanelThemes.MinCaption;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbRadioStation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPlayPause);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbRegionIndex);
            this.panel1.Controls.Add(this.cbCity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 404);
            this.panel1.TabIndex = 9;
            // 
            // cbRadioStation
            // 
            this.cbRadioStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRadioStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRadioStation.FormattingEnabled = true;
            this.cbRadioStation.Location = new System.Drawing.Point(55, 201);
            this.cbRadioStation.Name = "cbRadioStation";
            this.cbRadioStation.Size = new System.Drawing.Size(325, 28);
            this.cbRadioStation.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Радиостанция";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.DisabledImage = global::CSDesktopRadio.Properties.Resources.wmploc_376;
            this.btnPlayPause.HoverImage = global::CSDesktopRadio.Properties.Resources.wmploc_374;
            this.btnPlayPause.Location = new System.Drawing.Point(350, 346);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.NormalImage = global::CSDesktopRadio.Properties.Resources.wmploc_373;
            this.btnPlayPause.PushedImage = global::CSDesktopRadio.Properties.Resources.wmploc_375;
            this.btnPlayPause.Size = new System.Drawing.Size(29, 29);
            this.btnPlayPause.TabIndex = 9;
            this.btnPlayPause.Text = "imageButton1";
            this.btnPlayPause.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радио";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Регион";
            // 
            // cbRegionIndex
            // 
            this.cbRegionIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegionIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRegionIndex.FormattingEnabled = true;
            this.cbRegionIndex.Items.AddRange(new object[] {
            "01. Республика Адыгея",
            "02. Республика Башкортостан",
            "03. Республика Бурятия",
            "04. Республика Алтай (Горный Алтай)",
            "05. Дагестан",
            "06. Республика Ингушетия",
            "07. Кабардино-Балкария",
            "08. Республика Калмыкия",
            "09. Карачаево-Черкессия",
            "10. Республика Карелия",
            "11. Республика Коми",
            "12. Республика Марий Эл",
            "13. Республика Мордовия",
            "14. Республика Саха - Якутия",
            "15. Республика Северная Осетия-Алания",
            "16. Республика Татарстан",
            "17. Республика Тува",
            "18. Республика Удмуртия",
            "19. Республика Хакасия",
            "21. Чувашия",
            "22. Алтайский край",
            "23. Краснодарский край",
            "24. Красноярский край",
            "25. Приморский край",
            "26. Ставропольский край",
            "27. Хабаровский край",
            "28. Амурская область",
            "29. Архангельская область",
            "30. Астраханская область",
            "31. Белгородская область",
            "32. Брянская область",
            "33. Владимирская область",
            "34. Волгоградская область",
            "35. Вологодская область",
            "36. Воронежская область",
            "37. Ивановская область",
            "38. Иркутская область",
            "39. Калининградская область",
            "40. Калужская область",
            "41. Камчатский край",
            "42. Кемеровская область",
            "43. Кировская область",
            "44. Костромская область",
            "45. Курганская область",
            "46. Курская область",
            "47. Ленинградская область",
            "48. Липецкая область",
            "49. Магаданская область",
            "50. Московская область",
            "51. Мурманская область",
            "52. Нижегородская область",
            "53. Новгородская область",
            "54. Новосибирская область",
            "55. Омская область",
            "56. Оренбургская область",
            "57. Орловская область",
            "58. Пензенская область",
            "59. Пермский край",
            "60. Псковская область",
            "61. Ростовская область",
            "62. Рязанская область",
            "63. Самарская область",
            "64. Саратовская область",
            "65. Сахалинская область",
            "66. Свердловская область",
            "67. Смоленская область",
            "68. Тамбовская область",
            "69. Тверская область",
            "70. Томская область",
            "71. Тульская область",
            "72. Тюменская область",
            "73. Ульяновская область",
            "74. Челябинская область",
            "75. Забайкальский край",
            "76. Ярославская область",
            "77. Москва",
            "78. Санкт-Петербург",
            "79. Еврейская автономная область",
            "80. Донецкая народная республика",
            "81. Луганская народная республика",
            "82. Республика Крым",
            "84. Херсонская область",
            "85. Запорожская область",
            "86. Ханты-Мансийский автономный округ",
            "87. Чукотский автономный округ",
            "89. Ямало-Ненецкий автономный округ",
            "95. Чеченская республика"});
            this.cbRegionIndex.Location = new System.Drawing.Point(56, 93);
            this.cbRegionIndex.Name = "cbRegionIndex";
            this.cbRegionIndex.Size = new System.Drawing.Size(324, 28);
            this.cbRegionIndex.Sorted = true;
            this.cbRegionIndex.TabIndex = 1;
            this.cbRegionIndex.SelectedIndexChanged += new System.EventHandler(this.cbRegionIndex_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(56, 147);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(324, 28);
            this.cbCity.Sorted = true;
            this.cbCity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Город";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stylePanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Радио";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlCaption.ResumeLayout(false);
            this.pnlCaption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptIcon)).EndInit();
            this.stylePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private iNKORE.UI.WinForms.Styler.Controls.AdvComboBox cbRegionIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Label label3;
        private iNKORE.UI.WinForms.Styler.Controls.AdvComboBox cbCity;
        private System.Windows.Forms.PictureBox pbCaptIcon;
        private iNKORE.UI.WinForms.Styler.Controls.StylePanel stylePanel1;
        private System.Windows.Forms.Panel panel1;
        private iNKORE.UI.WinForms.Styler.Controls.WindowControlButton windowControlButton1;
        private System.Windows.Forms.Label label4;
        private iNKORE.UI.WinForms.Styler.Controls.WindowControlButton windowControlButton3;
        private iNKORE.UI.WinForms.Styler.Controls.WindowControlButton windowControlButton2;
        private Andy.UI.ImageButton btnPlayPause;
        private System.Windows.Forms.Label label5;
        private iNKORE.UI.WinForms.Styler.Controls.AdvComboBox cbRadioStation;
        //private NineSlicePanel stylePanel1;
    }
}

