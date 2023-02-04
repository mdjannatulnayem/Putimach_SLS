using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Putimach_SLS
{
    public partial class LandingPage : Form
    {
        public static int count, i;

        public static bool connected;

        bool launchState, terminated, count_init;

        string dataFeed;

        //public static string[] dataArray;

        public LandingPage()
        {
            InitializeComponent();
            launchState = false;
            count = 30;
            connected = false;
            flightlog.Text = "// Inflight logs >>>\n";
        }

        private void Clock_Tick(object sender, System.EventArgs e)
        {
            if (count_init && count > 0)
            {
                count = count - 1;
                if (count == 0)
                {
                    launchRocket();
                }
                countLabel.Text = $"00 : 00 : {count}";
            }
        }

        private void flightTimer_Tick(object sender, System.EventArgs e)
        {
            if (UsbSerial.IsOpen)
            {
                connected = true;
                connstatus.Text = "Connected";
                fetchData();
            }
            else
            {
                connected = false;
                connstatus.Text = "Disconnected";
            }
        }

        private void __connect_Click(object sender, System.EventArgs e)
        {
            if (!connected)
            {
                try
                {
                    UsbSerial.PortName = portfield.Text;
                    UsbSerial.Open();
                    if (UsbSerial.IsOpen)
                    {
                        connected = true;
                        writeLog($"Connected to port {portfield.Text}");
                    }
                    else
                    {
                        writeLog("Couldn't connect!");
                    }
                }
                catch (Exception ex)
                {
                    writeLog(ex.Message);
                }
            }
        }

        private void __disconn_Click(object sender, System.EventArgs e)
        {
            if (UsbSerial.IsOpen)
                UsbSerial.Close();
        }

        private void _start_Click(object sender, System.EventArgs e)
        {
            if (!launchState && connected)            
                count_init = true;
        }

        private void _abort_Click(object sender, System.EventArgs e)
        {
            if (!launchState && connected)
            {
                count = 30; //reset count!
                count_init = false;
                countLabel.Text = $"00 : 00 : {count}";
            }
        }

        private void _eject_Click(object sender, System.EventArgs e)
        {

        }

        private void writeLog(string log)
        {
            flightlog.Text += $"//{log}\n";
            flightlog.SelectionStart = flightlog.Text.Length;
            flightlog.ScrollToCaret();
        }

        private void launchRocket()
        {
            if(UsbSerial.IsOpen)
                UsbSerial.Write("L");
        }

        private string serialRead()
        {
            string str = null;
            try
            {
                UsbSerial.Write("*");
                for (i = 0; i < 10000; i++) {
                    // No operation!
                }
                str = UsbSerial.ReadLine();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
            }
            return str;
        }

        private void _termnt_Click(object sender, EventArgs e)
        {
            //if (UsbSerial.IsOpen) UsbSerial.Write("T");
        }

        private async void fetchData()
        {
            Task<string> asyncTask = new Task<string>(serialRead);
            asyncTask.Start();
            dataFeed = await asyncTask;

            // dataArray = dataFeed.Split('*');
            //if (dataArray.Length == 2 && isAppropriate(dataFeed))
            //{
            //    launchState = Convert.ToBoolean(
            //        Convert.ToInt16(dataArray[0])
            //    );
            //    terminated = Convert.ToBoolean(
            //        Convert.ToInt16(dataArray[1])
            //    );
            //    //Task Complete!
            //}

            launchState = Convert.ToBoolean(dataFeed);
        }

        //private bool isAppropriate(string local)
        //{
        //    bool retVal = false;
        //    var array = local.Split('*');
        //    if (array.Length == 2)
        //    {
        //        var elem0 = array[0];
        //        var elem1 = array[1];

        //        if ((elem0.Equals("0") || elem0.Equals("1"))
        //        && (elem1.Equals("0\r")|| elem1.Equals("1\r"))
        //        )
        //        {
        //            retVal = true;
        //        }
        //    }
        //    return retVal;
        //}

    }
}
