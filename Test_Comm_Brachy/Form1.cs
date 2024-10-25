using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Reflection.Emit;
using System.Threading;
using System.Xml.Linq;

namespace Test_Comm_Brachy
{
    public partial class Form1 : Form
    {
        MqttClient client;
        static SerialPort _serialPort;
        bool connected = false;
        static string command = "";
        string targetPosition = "";
        string targetSpeed = "";
        //string messageMQTT = "";
        static string feedback = "";

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private string serialize_JSON(string commandIn, string positionIn, string speedIn)
        {
            // Create an object to serialize to JSON
            var data = new
            {
                command = commandIn,
                position = positionIn,
                speed = speedIn
            };

            // Serialize the object to JSON
            var json = JsonConvert.SerializeObject(data);

            return json;
        }

        private void write_data()
        {
            int tempNumPos = 0, tempNumSpeed = 0;
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                {
                    if (int.TryParse(textBoxTargetPos.Text, out tempNumPos))
                    {
                        if (tempNumPos <= 53000 && tempNumPos >= 0)
                        {
                            if (int.TryParse(textBoxTargetSpeed.Text, out tempNumSpeed))
                            {
                                if (tempNumSpeed <= 100 && tempNumSpeed >= 0)
                                {
                                    targetPosition = textBoxTargetPos.Text;
                                    targetSpeed = textBoxTargetSpeed.Text;
                                    _serialPort.WriteLine(command + "/" + targetPosition + "/" + targetSpeed);
                                    //messageMQTT = serialize_JSON(command, targetPosition, targetSpeed);
                                    //client.Publish("pico_commands", Encoding.UTF8.GetBytes(messageMQTT));    
                                    labelErrors.Visible = false;
                                }
                                else
                                {

                                    update_error_label("Error: Value cannot be greater than 100 or less than 0.");
                                }
                            }
                            else
                            {
                                update_error_label("Error: Not a number. Please introduce numerical values only in the textboxes!");
                            }
                        }
                        else
                        {
                            update_error_label("Error: Value cannot be greater than 53000 or less than 0.");
                        }
                    }
                    else
                    {
                        update_error_label("Error: Not a number. Please introduce numerical values only in the textboxes!");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_com_port_list();
            baudRateList.SelectedIndex = 0;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                if (baudRateList.SelectedIndex != null)
                {
                    _serialPort = new SerialPort();
                    _serialPort.PortName = comPortList.SelectedItem.ToString();
                    _serialPort.BaudRate = int.Parse(baudRateList.SelectedItem.ToString());
                    _serialPort.Parity = Parity.None;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.Handshake = Handshake.XOnXOff;
                    _serialPort.DataBits = 8;
                    _serialPort.DtrEnable = true;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    _serialPort.Open();
                    connected = true;
                    buttonConnect.Text = "Disconnect";
                    //Thread myThread = new Thread(new ThreadStart(read_data));
                    //myThread.Start();
                    labelErrors.Visible = false;
                }
                else update_error_label("Select a baudrate before attempting to connect to the device.");
            }
            else
            {
                command = "di";
                write_data();
                _serialPort.Close();
                connected = false;
                buttonConnect.Text = "Connect";
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            feedback = sp.ReadExisting();
            if (feedback == "done") command = "st";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            command = "mp";
            write_data();
        }

        private void buttonHoming_Click(object sender, EventArgs e)
        {
            command = "hi";
            write_data();
        }

        private void buttonHomingRepo_Click(object sender, EventArgs e)
        {
            command = "hr";
            write_data();
        }

        private void buttonOpenFunnel_Click(object sender, EventArgs e)
        {
            command = "of";
            write_data();
        }

        private void buttonCloseFunnel_Click(object sender, EventArgs e)
        {
            command = "cf";
            write_data();
        }

        private void buttonOpenGripper_Click(object sender, EventArgs e)
        {
            command = "og";
            write_data();
        }

        private void buttonCloseGripper_Click(object sender, EventArgs e)
        {
            command = "cg";
            write_data();
        }

        private void buttonNextNeedle_Click(object sender, EventArgs e)
        {
            command = "nn";
            write_data();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            command = "st";
            write_data();
        }

        private void buttonBackstep_Click(object sender, EventArgs e)
        {
            command = "ba";
            write_data();
        }

        private void buttonOpenAll_Click(object sender, EventArgs e)
        {

            command = "oa";
            write_data();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //write_data();
            labelFeedback.Text = feedback;
            labelDebug.Text = command;
        }

        private void read_data()
        {
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                {
                    feedback = _serialPort.ReadLine();
                }
            }
        }

        private void buttonExit_MouseHover(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Red;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Transparent;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Red;
        }

        private void comPortList_MouseDown(object sender, MouseEventArgs e)
        {
            update_com_port_list();
        }

        private void update_com_port_list()
        {
            var ports = SerialPort.GetPortNames();
            comPortList.DataSource = ports;
        }

        public void update_error_label(string error)
        {
            labelErrors.Text = error;
            labelErrors.Visible = true; 
            labelErrors.ForeColor = Color.Red;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (connected)
                {
                    command = "di";
                    write_data();
                }
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                command = "di";
                write_data();
            }
        }

        private void buttonRunCycle_Click(object sender, EventArgs e)
        {
            /*
            // Open funnel
            command = "openFunnel";
            publishMQTTmessage();

            // Move to home position first
            command = "home";
            publishMQTTmessage();

            // Open gripper
            command = "openGripper";
            publishMQTTmessage();
            */

            /////////////CREATE SEPARATE THREAD FOR RUNNING THE COMMAND CYCLE WITH DELAYS SO THAT THE GUI DOESNT FREEZE
        }
    }
}
