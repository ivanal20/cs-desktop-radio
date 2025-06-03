using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDesktopRadio.Properties;
using Microsoft.Win32;

namespace CSDesktopRadio
{
    public partial class FrmMain : Form
    {
        public bool isPlaying = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public FrmMain()
        {
            InitializeComponent();
            //(new CSDesktopRadio.DropShadow()).ApplyShadows(this);
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 4, 4));
        }
        //[DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        //public static extern bool ShouldSystemUseDarkMode();
        /*private void AddFontFromMemory()
        {
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("yourfont.ttf");

            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();

            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
        }*/
private void Form1_Load(object sender, EventArgs e)
        {
            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("Resources.Segoe_Fluent_Icons");
            //btnPlayPause.Font = new Font(pfc.Families[0], 16);
            //cbRegionIndex.BackColor = Settings.Default.bgColor;
            //cbCity.BackColor = Settings.Default.bgColor;
            pbCaptIcon.BackgroundImage = this.Icon.ToBitmap();
            //bunifuDropdown1.BackgroundColor = Settings.Default.bgColor;
            //bool darkMode = ShouldSystemUseDarkMode();
            /*if (!darkMode)
            {
                this.BackColor = SystemColors.Window;
                this.ForeColor = SystemColors.WindowText;
                cbCity.ForeColor = SystemColors.WindowText;
                cbRegionIndex.ForeColor = SystemColors.WindowText;
                Settings.Default.bgColor = SystemColors.Window;
                Settings.Default.fgColor = SystemColors.WindowText;
                Settings.Default.Save();
                //btnPlayPause.BackgroundImage = Properties.Resources.Play_dark.ToBitmap();
                //btnClose.BackgroundImage = Properties.Resources.Close_dark.ToBitmap();
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 0x1D, 0x1D, 0x1D);
                this.ForeColor = Color.WhiteSmoke;
                cbCity.ForeColor = Color.WhiteSmoke;
                cbRegionIndex.ForeColor = Color.WhiteSmoke;
                Settings.Default.bgColor = Color.FromArgb(255, 0x1D, 0x1D, 0x1D);
                Settings.Default.fgColor = Color.WhiteSmoke;
                Settings.Default.Save();
                //btnPlayPause.BackgroundImage = Properties.Resources.Play_light.ToBitmap();
                //btnClose.BackgroundImage = Properties.Resources.Close_light.ToBitmap();
            }*/
            cbRegionIndex.SelectedIndex = Int32.Parse(Settings.Default.regionIndex);
            //btnPlayPause.Text = "\uF5B0";
            //btnClose.Text = "\uE8BB";
            switch (cbRegionIndex.SelectedIndex)
            {
                case 0:
                    cbCity.Items.Clear();
                    cbCity.Items.Add("Майкоп");
                        break;
                case 1:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Уфа", "Бакалы", "Белебей", "Белорецк", "Бирск", "Бураево", "Верхнеяркеево", "Дюртюли", "Киргиз-Мияки", "Кумертау", "Мишкино", "Нефтекамск", "Октябрьский", "Старогусево", "Стерлитамак", "Туймазы", "Учалы"]);
                        break;
                case 2:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Улан-Удэ", "Северобайкальск"]);
                        break;
                case 3:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Горно-Алтайск", "Артыбаш", "Турочак", "Чемал"]);
                        break;
                case 4:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Хасавюрт", "Дербент", "Кизляр", "Махачкала"]);
                        break;
                case 5:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([ "Назрань","Магас" ]);
                        break;
                case 6:
                    cbCity.Items.Clear();
                    cbCity.Items.Add("Нальчик");
                        break;

            }
            cbCity.SelectedIndex = Int32.Parse(Settings.Default.cityIndex);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.regionIndex = cbRegionIndex.SelectedIndex.ToString();
            Settings.Default.cityIndex = cbCity.SelectedIndex.ToString();
            Settings.Default.Save();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(/*Settings.Default.bgColor*/accColor(), 1);
            //Graphics g = e.Graphics;
            //g.DrawRectangle(pen, new Rectangle(cbRegionIndex.Location.X - 1, cbRegionIndex.Location.Y - 1, cbRegionIndex.Width + 1, cbRegionIndex.Height + 1));
            //roundrect.DrawRoundedRectangle(g, pen, new Rectangle(0, 0, Width - 2, Height - 2) ,4);
            //Graphics btng = btnClose.CreateGraphics();
            //btng.DrawString("\uE8BB", new Font("Segoe Fluent Icons", 11), new SolidBrush(Settings.Default.fgColor), new PointF(20, 12));
        }

        Color accColor()
        {
            Color a = Color.FromArgb(0, 0, 0, 0);
            try
            {
                var accentColorValue = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "AccentColor", null);

                if (accentColorValue != null)
                {
                    int colorValue = (int)accentColorValue;
                    // Color value is in BGR format, so we need to convert it to RGB
                    Color accentColor = Color.FromArgb(
                        (colorValue >> 24) & 0xff, // Alpha
                        (colorValue >> 0) & 0xff,  // Blue
                        (colorValue >> 8) & 0xff,  // Green
                        (colorValue >> 16) & 0xff  // Red
                    );

                    a = accentColor;
                }
            }
            catch (Exception _)
            {
                //MessageBox.Show($"Error getting accent color: {ex.Message}");
                a = Color.FromArgb(255, 255, 255, 255);
            }
            return a;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbRegionIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbRegionIndex.SelectedIndex)
            {
                case 0:
                    cbCity.Items.Clear();
                    cbCity.Items.Add("Майкоп");
                        break;
                case 1:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Уфа", "Бакалы", "Белебей", "Белорецк", "Бирск", "Бураево", "Верхнеяркеево", "Дюртюли", "Киргиз-Мияки", "Кумертау", "Мишкино", "Нефтекамск", "Октябрьский", "Старогусево", "Стерлитамак", "Туймазы", "Учалы"]);
                        break;
                case 2:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Улан-Удэ", "Северобайкальск"]);
                        break;
                case 3:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Горно-Алтайск", "Артыбаш", "Турочак", "Чемал"]);
                        break;
                case 4:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Хасавюрт", "Дербент", "Кизляр", "Махачкала"]);
                        break;
                case 5:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Назрань", "Магас"]);
                        break;
                case 6:
                    cbCity.Items.Clear();
                    cbCity.Items.Add("Нальчик");
                        break;
                case 7:
                    cbCity.Items.Clear();
                    cbCity.Items.Add("Элиста");
                    break;
                case 8:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Черкесск", "Карачаевск"]);
                    break;
                case 9:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Петрозаводск", "Костомукша"]);
                    break;
                case 10:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Сыктывкар", "Ухта"]);
                    break;
                case 11:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Йошкар-Ола", "Волжск", "Козьмодемьянск"]);
                    break;
                case 12:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Саранск", "Зубова Поляна", "Рузаевка"]);
                    break;
                case 13:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Якутск", "Алдан", "Вилюйск", "Кюбеме", "Мирный", "Нерюнгри", "Томтор"]);
                    break;
                case 14:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Владикавказ", "Архонская"]);
                    break;
                case 15:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Казань", "Актаныш", "Альметьевск", "Арск", "Бугульма", "Буинск", "Высокая гора", "Заинск", "Зеленодольск", "Кукмор", "Мамадыш", "Мензелинск", "Набережные Челны", "Нижнекамск", "Нурлат", "Черемшан", "Шемордан"]);
                    break;
                case 16:
                    cbCity.Items.Clear();
                    cbCity.Items.Add("Кызыл");
                    break;
                case 17:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange(["Ижевск", "Воткинск", "Глазов", "Можга", "Сарапул", "Ува"]);
                    break;
                case 18:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 19:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 20:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 21:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 22:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 23:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 24:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 25:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 26:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 27:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 28:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 29:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 30:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 31:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 32:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 33:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 34:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 35:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 36:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 37:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 38:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 39:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 40:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 41:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 42:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 43:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 44:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 45:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 46:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 47:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 48:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 49:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 50:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 51:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 52:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 53:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 54:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 55:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 56:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 57:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 58:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 59:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 60:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 61:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 62:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 63:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 64:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 65:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 66:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 67:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 68:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 69:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 70:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 71:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 72:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 73:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 74:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 75:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 76:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 77:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 78:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 79:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 80:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 81:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 82:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 83:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 84:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 85:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 86:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 87:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 88:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 89:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 90:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 91:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 92:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 93:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
                case 94:
                    cbCity.Items.Clear();
                    cbCity.Items.AddRange([]);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if (isPlaying)
            {
                btnPlayPause.NormalImage = Resources.wmploc_427;
                btnPlayPause.PushedImage = Resources.wmploc_424;
                btnPlayPause.HoverImage = Resources.wmploc_423;

            } else
            {
                btnPlayPause.NormalImage = Resources.wmploc_373;
                btnPlayPause.PushedImage = Resources.wmploc_375;
                btnPlayPause.HoverImage = Resources.wmploc_374;
            }
        }
    }

    public static class roundrect
    {
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException(nameof(graphics));
            if (pen == null)
                throw new ArgumentNullException(nameof(pen));

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                graphics.DrawPath(pen, path);
            }
        }
    }
}
