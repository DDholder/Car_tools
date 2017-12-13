using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace CarFormsTools
{
    public partial class UsartControl : UserControl
    {
        public UsartControl()
        {
            // _dataClass = new DataClass(Datapath);
            UsartControlMain = this;
            InitializeComponent();
        }
        public static UsartControl UsartControlMain;
        private readonly UsartSettingForm _usartSettingForm = new UsartSettingForm();

        public delegate void DataFinishedHandle(object sender, EventArgs e);
        public event DataFinishedHandle DataFinished;
        public byte[] Head { get; set; }

        public byte[] End { get; set; }

        public string Datapath { get; set; }
        public DataClass DataClass { get => _dataClass; set => _dataClass = value; }
        public string CurrentData { get => _currentData; set => _currentData = value; }

        #region Field Defined
        private static DataClass _dataClass;
        private List<byte> dataCache = new List<byte>();
        private bool enSaveStr = false;
        #endregion


        private void comSwitch_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScanSerial();
        }

        private string _currentData;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var n = serialPort1.BytesToRead;
            var portbyte = new byte[n];
            serialPort1.Read(portbyte, 0, n);
            var portstring = Encoding.Default.GetString(portbyte);
            if (dataHandleCheckBox.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i < n - 2)
                    {
                        if (portbyte[i] == Head[0] && portbyte[i + 1] == Head[1])
                        {
                            enSaveStr = true;
                            i += 2;
                        }
                    }
                    if (enSaveStr)
                        dataCache.Add(portbyte[i]);
                    if (dataCache.Count > 2)
                    {
                        if (dataCache[dataCache.Count - 1] == End[1] && dataCache[dataCache.Count - 2] == End[0])
                        {
                            enSaveStr = false;
                            var value = Encoding.Default.GetString(dataCache.ToArray()).Substring(0, dataCache.Count - 2);
                            CurrentData = value;
                            AcceptData(_dataClass, value);
                            dataCache.Clear();
                        }
                    }
                }
            }
            else
                _currentData = portstring;
            DataFinished?.Invoke(sender, e);
        }

        public void AcceptData(DataClass dataClass, string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            for (int i = 0; i < str.Length / 5; i++)
            {
                dataClass.Table[str[i * 5]].AddData(BitConverter.ToSingle(bytes, i * 5 + 1));
            }
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            _usartSettingForm.ShowDialog();
        }

        private void UsartControl_Load(object sender, EventArgs e)
        {
            _dataClass = new DataClass(Datapath);
            BaudList.SelectedIndex = 1;
        }

        private void comSwitch_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                else
                {
                    serialPort1.PortName = comList.Text;
                    serialPort1.BaudRate = int.Parse(BaudList.Text);
                    serialPort1.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        private int _portNamesLength;
        private void ScanSerial()
        {
            try
            {
                var portNames = SerialPort.GetPortNames();
                if (portNames.Length == _portNamesLength) return;
                _portNamesLength = portNames.Length;
                comList.Items.Clear();
                for (var i = 0; i < _portNamesLength; i++)
                {
                    comList.Items.Add(portNames[i]);
                }
                comList.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
