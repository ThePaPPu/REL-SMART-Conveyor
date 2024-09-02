using Nest;
using S7.Net;
using System.Media;


namespace REL_SMART_Conveyor
{
    public partial class Form1 : Form
    {
        const string plc_ip = "192.168.104.48";
        Plc plc = new Plc(CpuType.S71200, plc_ip, 0, 1);
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plc_input_timer.Start();
            plc_input_timer.Interval = 50000;

            plcConnection();    
        }


        private void plcConnection()
        {
            try
            {
                plc.Open();

                if (plc.IsConnected)
                {
                    label1.Text = "Connection Status: Succeed";
                    label1.BackColor = Color.Green;
                    string data = Convert.ToString(plc.Read("DB14.DBW0"));
                    //string data = (string)plc.Read(DataType.DataBlock, 14, 2, VarType.String, 20);


                    if (data == "1")
                    {
                        label2.Text = "Running Event: Good Morning";
                        label3.Text = "Upcoming Event: Good Night";
                        SoundPlayer player = new SoundPlayer(@"D:\Audio\good_morning.wav");
                        player.Play();
                    }

                    if (data == "2")
                    {
                        label2.Text = "Running Event: Good Night";
                        label3.Text = "Upcoming Event: Good Morning";
                        SoundPlayer player = new SoundPlayer(@"D:\Audio\good_night.wav");
                        player.Play();
                    }
                }
                else
                {
                    label1.Text = "Connection Status: Failed";
                    label1.BackColor = Color.Red;
                }

                plc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //input from plc timer
        {
            plc.Open();
            string data = Convert.ToString(plc.Read("DB14.DBW0"));
            //string data = (string)plc.Read(DataType.DataBlock, 14, 2, VarType.String, 20);

            if (data == "1")
            {
                label2.Text = "Running Event: Good Morning";
                label3.Text = "Upcoming Event: Good Night";
                SoundPlayer player = new SoundPlayer(@"D:\Audio\good_morning.wav");
                player.Play();
            }

            if (data == "2")
            {
                label2.Text = "Running Event: Good Night";
                label3.Text = "Upcoming Event: Good Morning";
                SoundPlayer player = new SoundPlayer(@"D:\Audio\good_night.wav");
                player.Play();
            }
        }
    }
}
