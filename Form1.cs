using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static OSPlatform GetOSPlatform()
        {
            OSPlatform osPlatform = OSPlatform.Create("Other Platform");
            // Check if it's windows 
            bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            osPlatform = isWindows ? OSPlatform.Windows : osPlatform;
            // Check if it's osx 
            bool isOSX = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
            osPlatform = isOSX ? OSPlatform.OSX : osPlatform;
            // Check if it's Linux 
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            osPlatform = isLinux ? OSPlatform.Linux : osPlatform;
            return osPlatform;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.label3.Text = "";
            this.label3.Text += "OS platform:" + GetOSPlatform().ToString() + "\n";
            // OS description, contains os version 
            this.label3.Text += "OS description:" + RuntimeInformation.OSDescription + "\n";
            // OS architecture 
            this.label3.Text += "OS architecture:" + RuntimeInformation.OSArchitecture + "\n";
            // Process architecture 
            this.label3.Text += "Process architecture:" + RuntimeInformation.ProcessArchitecture + "\n";
            //Framework description 
            this.label3.Text += "Framework description:" + RuntimeInformation.FrameworkDescription + "\n";

        }


    }
    }

