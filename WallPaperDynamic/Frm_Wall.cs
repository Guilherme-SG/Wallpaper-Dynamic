using System;
using System.Windows.Forms;
using WallPaperDynamic.Weather;
using WallPaperDynamic.Background;

namespace WallPaperDynamic
{
    public partial class Frm_Wall : Form
    {
        BackgroundController background;
        WeatherApi weather;

        public Frm_Wall()
        {
            InitializeComponent();
            weather = new WeatherApi();
            background = new BackgroundController();

            // Start with the right weather
            background.DefineBackgroundWeather(weather);
            tmr_atualizador.Enabled = true;
        }    

        private void tmr_atualizador_Tick(object sender, EventArgs e)
        {
            background.ChooseBackgroundImage();
        }

        private void ntf_application_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /* Show program */
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            ntf_application.Visible = false;
        }

        private void Frm_Wall_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                ntf_application.Visible = true;
            }
        }

        private void Frm_Wall_Load(object sender, EventArgs e)
        {
            /* Put application in the window tray */
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            ntf_application.Visible = true;
        }

        private void pausarTrocaDinamicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            tmr_atualizador.Enabled = !tmr_atualizador.Enabled;

            if (tmr_atualizador.Enabled)
            {
                ((ToolStripMenuItem)sender).Text = "Pause dynamic change";
            }
            else
            {
                ((ToolStripMenuItem)sender).Text = "Continue dynamic change";
            }
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmr_weather_Tick(object sender, EventArgs e)
        {
            // Each 20 minutes update the weather
            // This way, it does not exceed the limit request
            background.DefineBackgroundWeather(weather);
        }

        private void mostrarClimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           background.ShowBackgroundWeatherMessage();
        }
    }
}
