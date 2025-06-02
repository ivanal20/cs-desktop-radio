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
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 35:
                    break;
                case 36:
                    break;
                case 37:
                    break;
                case 38:
                    break;
                case 39:
                    break;
                case 40:
                    break;
                case 41:
                    break;
                case 42:
                    break;
                case 43:
                    break;
                case 44:
                    break;
                case 45:
                    break;
                case 46:
                    break;
                case 47:
                    break;
                case 48:
                    break;
                case 49:
                    break;
                case 50:
                    break;
                case 51:
                    break;
                case 52:
                    break;
                case 53:
                    break;
                case 54:
                    break;
                case 55:
                    break;
                case 56:
                    break;
                case 57:
                    break;
                case 58:
                    break;
                case 59:
                    break;
                case 60:
                    break;
                case 61:
                    break;
                case 62:
                    break;
                case 63:
                    break;
                case 64:
                    break;
                case 65:
                    break;
                case 66:
                    break;
                case 67:
                    break;
                case 68:
                    break;
                case 69:
                    break;
                case 70:
                    break;
                case 71:
                    break;
                case 72:
                    break;
                case 73:
                    break;
                case 74:
                    break;
                case 75:
                    break;
                case 76:
                    break;
                case 77:
                    break;
                case 78:
                    break;
                case 79:
                    break;
                case 80:
                    break;
                case 81:
                    break;
                case 82:
                    break;
                case 83:
                    break;
                case 84:
                    break;
                case 85:
                    break;
                case 86:
                    break;
                case 87:
                    break;
                case 88:
                    break;
                case 89:
                    break;
                case 90:
                    break;
                case 91:
                    break;
                case 92:
                    break;
                case 93:
                    break;
                case 94:
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
