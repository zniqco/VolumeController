using System;
using System.Windows.Forms;

namespace VolumeController
{
    public partial class MainForm : Form
    {
        private double value = 80.0;
        private double power = 0.0;
        private bool pressed = false;
        private int previousX = 0;

        private float startVolume = 0.0f;
        private IAudioEndpointVolume audioEndpointVolume;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();

                deviceEnumerator.GetDefaultAudioEndpoint(0 /* eRender */, 1 /* eMultimedia */, out var speakers);
                speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out var audioEndpointVolumeObject);

                audioEndpointVolume = (IAudioEndpointVolume)audioEndpointVolumeObject;

                audioEndpointVolume.GetMasterVolumeLevelScalar(ref startVolume);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();

                return;
            }

            UpdateVolume(value);

            MainTimer.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (audioEndpointVolume != null)
                audioEndpointVolume.SetMasterVolumeLevelScalar(startVolume, Guid.Empty);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            value += power;
            power *= 0.96;

            while (true)
            {
                if (value > 100.0)
                {
                    value = 200.0 - value;
                    power = -power;
                }
                else if (value < 0.0)
                {
                    value = -value;
                    power = -power;
                }
                else
                {
                    break;
                }
            }

            UpdateVolume(value);
        }

        private void UpdateVolume(double value)
        {
            var controllerLeft = (int)Math.Round((VolumePanel.Width - ControllerPanel.Width) / 100.0 * value);

            GaugePanel.Width = controllerLeft;
            ControllerPanel.Left = controllerLeft;

            VolumeLabel.Text = $"Volume: {(int)Math.Round(value)}";

            audioEndpointVolume.SetMasterVolumeLevelScalar((float)value * 0.01f * startVolume, Guid.Empty);
        }

        private void ControllerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            power = 0.0;
            pressed = true;
            previousX = e.X;

            DraggingPanel.Visible = true;
            ControllerPanel.Capture = true;
        }

        private void ControllerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
                DraggingPanel.Left = ControllerPanel.Left - (int)(Math.Sign(previousX - e.X) * Math.Pow(Math.Abs(previousX - e.X), 0.6));
        }

        private void ControllerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                power = (previousX - e.X) / 10.0;

                ControllerPanel.Capture = false;
                DraggingPanel.Visible = false;
            }
        }
    }
}
