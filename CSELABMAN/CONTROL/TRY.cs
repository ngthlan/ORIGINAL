using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace CSELABMAN.CONTROL
{
    public partial class TRY : Form
    {
        Services services = new Services();                     // dich vu ho tro
        public string resFirst = null;

        bool exist;
        public TRY()
        {
            InitializeComponent();
            services.Local.InitializeControlValues(ref settings,ref cmB_COMport, ref cmB_Baud, ref cmB_Parity,
                                                    ref cmbDataBits,ref cmbStopBits,ref serialPortRFID,
                                                    ref errorCOM,ref errorCONN,ref resFirst, ref exist);
            textBox_sttCOM.Text = resFirst;
            textBox_sttCOM.TextAlign = HorizontalAlignment.Center;
            System.Timers.Timer timer1 = new System.Timers.Timer() ;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            label_Realtimestt.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        string mypath = null;                                   // ten path de luu file html response
        
        public bool errReadFile = false;                        // kiem tra loi doc file
        public bool errWriteFile = false;                       // kiem ta loi ghi file
        public string responseReadFile = null;                  // phan hoi sau khi doc file
        public string responseWriteFile = null;                 // phan hoi sau khi ghi file
        public bool ckcadd = false;
        public bool ckchash = false;
        public bool errorCOM = false;      //kiem tra cong COM ngat bat thuong hay khong
        public bool errorCONN = false;     //kiem tra cong COM co bi chiem giu hay khong
        private CSELABMAN.Properties.Settings settings = CSELABMAN.Properties.Settings.Default;

        public static string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create);
        string mypathappWEB = mydocpath + @"\Response.html";

        #region Local Methods
        public const int maxlength = 7;
        private string txt_S;
        public string txt_D = "";
        //private string temp = "";
        public char[] temp = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //private int num_temp;
        public string errorWEB;
        public bool errorW = false;
        public string res2, sttdes;


        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            CONTROL.Services services = new CONTROL.Services();
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.textBox_RFID.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                byte[] buffer = new byte[serialPortRFID.BytesToRead];
                serialPortRFID.Read(buffer, 0, buffer.Length);
                txt_S = services.Local.ByteArrayToHexString(buffer);
                txt_S.CopyTo(3, temp, 0, 10 + 4);
                //Console.WriteLine("temp is : "+temp);
                txt_D = services.Local.CharArrayToString(temp);
                //Console.WriteLine("RFID is : " + txt_D);
                textBox_RFID.Text = txt_D;
                if (txt_S.Length > maxlength)
                {
                    txt_S = "";
                    txt_D = "";
                    buffer = new byte[14];
                }
                string mydocpath = @"C:\USERs\Public\Documents\";
                string mypath = mydocpath + @"CSELAB.txt";
                services.Local.writetofile(textBox_RFID.Text, mypath);
            }
        }
        
        #endregion Local Methods

        #region Events
        private void serialPortRFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPortRFID.BytesToRead >= maxlength)
                SetText("");
        }
        #endregion Events

        #region Button Clicks
        string mypathF = string.Empty;                  // ten path de luu file txt
        private void button_Write_Click(object sender, EventArgs e)
        {
            richTextBox_Status.Text = null;
            if (string.IsNullOrEmpty(textBox_filename.Text))
            {
                MessageBox.Show(this, "The filename is empty!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("The filename is empty!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox_path.Text))
                    mypathF = textBox_filename.Text;
                else
                    mypathF = textBox_path.Text + "/" + textBox_filename.Text;
                services.Local.writetofiletxt(ref errWriteFile, ref responseWriteFile, richTextBox_Send.Text, mypathF);

                if (errWriteFile)
                {
                    errWriteFile = false;
                    richTextBox_Status.Text = "Error while Writing data to file \n" + responseWriteFile;
                }
                else
                {
                    string tmp = services.Local.readfiletxt(ref errReadFile, ref responseReadFile, mypathF);
                    if (string.IsNullOrEmpty(tmp))
                    {
                        richTextBox_Status.Text = mypathF + "\n Input Data is NULL!";
                    }
                    else if (!tmp.Equals(richTextBox_Send.Text))
                    {
                        richTextBox_Status.Text = "Data is not written" + responseReadFile;
                    }
                    else
                    {
                        richTextBox_Status.Text = "Write successfully to" + mypathF + "\n" + responseWriteFile;
                    }
                }
            }
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            richTextBox_Status.Text = null;
            if (string.IsNullOrEmpty(textBox_filename.Text))
            {
                MessageBox.Show(this,"The filename is empty!","ATTENTION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //MessageBox.Show("The filename is empty!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox_path.Text))
                    mypathF = textBox_filename.Text;
                else
                    mypathF = textBox_path.Text + "\\" + textBox_filename.Text;
                
                richTextBox_Receive.Text = services.Local.readfiletxt(ref errReadFile, ref responseWriteFile, mypathF);
                
                if (errReadFile)
                {
                    errReadFile = false;
                    richTextBox_Status.Text = "Error while Reading data from file \n" + responseWriteFile;
                }
                else
                {
                    if (string.IsNullOrEmpty(richTextBox_Receive.Text))
                        richTextBox_Status.Text = mypathF + "\n has no data";
                    else 
                        richTextBox_Status.Text = mypathF + "\nRead data successfully";
                }
            }
        }   
        
        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_path.Text = null;
            textBox_filename.Text = null;
            richTextBox_Send.Text = null;
            richTextBox_Receive.Text = null;
            richTextBox_Status.Text = null;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Send.Text = null;
            richTextBox_Receive.Text = null;
            richTextBox_Status.Text = null;
            
            if (string.IsNullOrEmpty(textBox_path.Text))
                mypath = textBox_filename.Text;
            else
                mypath = textBox_path.Text + "/" + textBox_filename.Text;

            if (string.IsNullOrEmpty(textBox_filename.Text))
            {
                MessageBox.Show(this, "The filename is empty!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("The filename is empty!");
            }
            else if (!File.Exists(mypath))
            {
                richTextBox_Status.Text = mypath+"\nCannot clear!";
                MessageBox.Show(this, "File is not exist!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                services.Local.writetofiletxt(ref errWriteFile, ref responseWriteFile, "", mypath);
                //richTextBox_Status.Text = responseWriteFile;

                if (errWriteFile)
                {
                    errWriteFile = false;
                    richTextBox_Status.Text = "Error while Clearing data of file \n" + responseWriteFile;
                }
                else
                {

                    string tmp = services.Local.readfiletxt(ref errReadFile, ref responseReadFile, mypath);
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        richTextBox_Status.Text = "Cannot clear! \n" + responseReadFile + "\n" + responseWriteFile;
                    }
                    else
                    {
                        richTextBox_Status.Text = "Clear successfully data of " + mypath;
                    }
                }
            }
        }

        //public string errorWEB;
        //public bool errorW = false;
        public string Datares = null;
        public bool ErrRes = false;
        public string MessRes = null;

        private void but_check_Click(object sender, EventArgs e)
        {
            //System.Threading.Timer timer = new System.Threading.Timer(timeoutfunc, this, 0, 18000);
            richTextBox_WEBstt.Text = "";
            CONTROL.Services services = new CONTROL.Services();

            /*if (textBox_port.Text == "")
                richTextBox_WEBstt.Text = "Error : No information!";
            else
            {*/
            string url = null;
            if (string.IsNullOrEmpty(textBox_port.Text))
                url = uri_request.Text;
            else
                url = uri_request.Text + ":" + textBox_port.Text + "/";

            //Console.WriteLine(tmpurl);
            if (url == "")
            {
                richTextBox_WEBstt.Text = "Error connection ";
                MessageBox.Show("The URL is missing!");
                //errorW = true;
            }
            else
            {
                string tmpurl = url.Remove(5, url.Length - 5);
                if (tmpurl == "https")
                    Datares = services.Network.POSTHTTPS(ref errorW, ref errorWEB, url,
                            "Request", "Requesting");
                else
                    Datares = services.Network.POST(ref errorW, ref errorWEB, url,
                            "Request", "Requesting");
            }
            if (!string.IsNullOrEmpty(uri_request.Text))
            {
                if (errorW)
                {
                    richTextBox_WEBstt.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox_WEBstt.Text = "Error connection : " + url;
                    MessageBox.Show(this, errorWEB, "Server : " + url, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    services.Network.showresponse(mypathappWEB, Datares, uri_request.Text, ref ErrRes, ref MessRes, ref Datares);
                    if (ErrRes)
                        MessageBox.Show(MessRes);
                    else
                        richTextBox_WEBstt.Text = Datares;
                }
            }
        }

        private void button_request_Click(object sender, EventArgs e)
        {
            string url = null;
            if (string.IsNullOrEmpty(textBox_port.Text))
                url = uri_request.Text;
            else
                url = uri_request.Text + ":" + textBox_port.Text + "/";
            
            MyWebRequest myreq = new MyWebRequest();
            string refex = null;
            myreq.MyWebRequest1(url, "POST", "Hello");
            richTextBox_WEBstt.Text = myreq.GetResponse(ref refex);
            MessageBox.Show(refex);

        }

        //bool errex = false;
        //string exmess = null;

        private void button_Demo_Click(object sender, EventArgs e)
        {
            richTextBox_WEBstt.Text = "";
 /*           string response = null;
            services.Network.DemocpListener(textBox_IP.Text, Convert.ToInt32(textBox_port.Text),ref response,ref errex, ref exmess);
            if (errex)
            {
                errex = false;
                MessageBox.Show(exmess);
            }
            else 
            {
                richTextBox_WEBstt.Text = response;
            }*/

          
            try
            {
                string url = null;
                if (string.IsNullOrEmpty(textBox_port.Text))
                    url = uri_request.Text;
                else
                    url = uri_request.Text + ":" + textBox_port.Text + "/";

                WebClient client = new WebClient();
                string Datares = client.DownloadString(url);
                services.Network.showresponse(mypathappWEB, Datares, uri_request.Text, ref ErrRes, ref MessRes, ref Datares);
                if (ErrRes)
                    MessageBox.Show(MessRes);
                else
                    richTextBox_WEBstt.Text = Datares;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Error Connection",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button_resetW_Click(object sender, EventArgs e)
        {
            uri_request.Text = "http://localhost";
            textBox_IP.Text = "";
            textBox_port.Text = "8000";
            richTextBox_WEBstt.Text = "";
        }

        private void button_DemoCOM1_Click(object sender, EventArgs e)
        {
            //services.Local.demoCOM();
            MessageBox.Show(this, "Function is under construction!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void checkBox_DEV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DEV.Checked)
                richTextBox_CheckBox.Text = "Choosing DEVICE";
            else
                richTextBox_CheckBox.Text = "Choosing USER";
        }

        private void button_ResetCB_Click(object sender, EventArgs e)
        {
            checkBox_DEV.Checked = false;
            richTextBox_CheckBox.Text = string.Empty;
        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {
            // Change the state of the form's controls
            // If the port is open, send focus to the send data box
            string response = null;
            bool exist = false;
            int sttcode = 0;
            services.Local.openCOMport(ref settings,ref cmB_COMport, ref cmB_Baud, ref cmB_Parity,
                                       ref cmbDataBits, ref cmbStopBits,
                                       ref serialPortRFID, ref textBox_RFID, 
                                       ref errorCOM, ref errorCONN, 
                                       ref response, but_OpenPort,
                                       ref txt_S, ref sttcode, ref exist);
            textBox_sttCOM.Text = response;
            switch (sttcode)
            { 
                case 1 :                // bi loi mat ket noi COM khi khong con port hien co
                    MessageBox.Show(this, "Vui lòng gắn thiết bị!", "LỖI THIẾT BỊ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 2 :                // bi loi trung COM
                    MessageBox.Show(this, "Không thể mở cổng COM đã chọn khi bị chiếm giữ bởi thiết bị khác!", "LỖI KẾT NỐI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3 :                // bi loi chua chon du cac thong tin cai dat cho COM
                    MessageBox.Show(this, "Vui lòng thiết lập các thông số còn thiếu", "THIẾU THÔNG SỐ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 4:                // bi loi mat ket noi COM
                    MessageBox.Show(this, "Không thể mở cổng COM vì mất kết nối với thiết bị", "LỖI KẾT NỐI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 5 :                // bi loi khac
                    MessageBox.Show(this, "Không thể mở cổng COM. \n Có thể cổng COM bị chiếm giữ, hoặc được gỡ bỏ, hoặc chưa sẵn sàng.", "LỖI KHÔNG THỂ XÁC ĐỊNH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                default :
                    break;
            }
        }

        private void button_SaveCONF_Click(object sender, EventArgs e)
        {
            string localpath = "configCOM.txt";                 // ten path de luu file config COM
            string LOGpath = "LOGCOM.txt";                 // ten path de luu file config COM

            if (string.IsNullOrEmpty(cmB_COMport.Text)
              || string.IsNullOrEmpty(cmB_Baud.Text)
              || string.IsNullOrEmpty(cmB_Parity.Text))
            {
                richTextBox_ResCOM.Text = "Cannot save configuration!";
                MessageBox.Show(this, "Input data is missing!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (serialPortRFID.IsOpen)
            {
                string tmpresult = services.Local.readfiletxt(ref errReadFile, ref responseReadFile, localpath);
                string[] tmpresultarray = services.Local.stringtostringarray(tmpresult);
                if (string.IsNullOrEmpty(tmpresult))
                {
                    string datain = label_COMport.Text + ":" + cmB_COMport.Text + "\n" +
                                        label_Baud.Text + ":" + cmB_Baud.Text + "\n" +
                                        label_Parity.Text + ":" + cmB_Parity.Text;
                    services.Local.writeCONF(ref errWriteFile, ref responseWriteFile, datain, localpath, ref responseReadFile);
                    richTextBox_ResCOM.Text = responseWriteFile;
                    richTextBox_Status.Text = responseReadFile;
                    string timelog = "SerialPort new CONFIGURATION : " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "\n";
                    string newlog = timelog + datain + "\n\n";
                    services.Local.writetofiletxt(ref errWriteFile, ref responseWriteFile, newlog, LOGpath);
                    System.Diagnostics.Process.Start(LOGpath);
                }
                else
                {
                    if (string.Equals(tmpresultarray[0], label_COMport.Text + ":" + cmB_COMport.Text)
                     && string.Equals(tmpresultarray[1], label_Baud.Text + ":" + cmB_Baud.Text)
                     && string.Equals(tmpresultarray[2], label_Parity.Text + ":" + cmB_Parity.Text))
                    {
                        richTextBox_ResCOM.Text = "Data is already written!";
                    }
                    else
                    {
                        string datain = label_COMport.Text + ":" + cmB_COMport.Text + "\n" +
                                        label_Baud.Text + ":" + cmB_Baud.Text + "\n" +
                                        label_Parity.Text + ":" + cmB_Parity.Text;
                        services.Local.writeCONF(ref errWriteFile, ref responseWriteFile, datain, localpath, ref responseReadFile);
                        richTextBox_ResCOM.Text = responseWriteFile;
                        richTextBox_Status.Text = responseReadFile;
                        string timelog = "SerialPort CONFIGURATION : " + DateTime.Now + "\n";
                        string oldlog = services.Local.readfiletxt(ref errReadFile, ref  responseReadFile, LOGpath);
                        string newlog = oldlog + timelog + datain + "\n\n";
                        services.Local.writetofiletxt(ref errWriteFile, ref responseWriteFile, newlog, LOGpath);
                        System.Diagnostics.Process.Start(LOGpath);
                        //Console.WriteLine(newlog);
                    }
                }
            }
            else
            {
                richTextBox_ResCOM.Text = "Cannot save configuration!";
                MessageBox.Show(this, "Save configuration when Opening!", "COMport is Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_ScanCOM_Click(object sender, EventArgs e)
        {
            richTextBox_ResCOM.Text = null;
            richTextBox_Status.Text = null;
            serialPortRFID.Close();
            cmB_COMport.Items.Clear();
            cmB_Baud.Items.Clear();
            cmB_Parity.Items.Clear();
            cmB_COMport.Items.AddRange(new Object[] {" "});
            cmB_Baud.Items.AddRange(new Object[] {" "});
            cmB_Parity.Items.AddRange(new Object[] {" "});
            but_OpenPort.Text = "Open port";
            services.Local.InitializeControlValues(ref settings, ref cmB_COMport, ref cmB_Baud, ref cmB_Parity,
                                                    ref cmbDataBits, ref cmbStopBits, ref serialPortRFID,
                                                    ref errorCOM, ref errorCONN, ref resFirst, ref exist);
            textBox_sttCOM.Text = resFirst;
        }

        private void button_LoadCONF_Click(object sender, EventArgs e)
        {
            string localpath = "configCOM.txt";                             // ten path de luu file config COM

            if (errorCOM)                                                   // khi COM bi loi thi khong duoc load
            {
                richTextBox_Status.Text = "Cannot read " + localpath;
                richTextBox_ResCOM.Text = "Cannot load configuration!";
                MessageBox.Show(this, "Load configuration when Availble!", "COMport is not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (serialPortRFID.IsOpen)                                      // khi COMport dang mo thi khong duoc load
            {
                richTextBox_ResCOM.Text = "Cannot load configuration!";
                MessageBox.Show(this, "Load configuration when Closed!", "COMport is opening", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string dataCONF = services.Local.readfiletxt(ref errReadFile, ref responseWriteFile, localpath);    // lay data de config

                if (errReadFile)
                {
                    errReadFile = false;
                    richTextBox_Status.Text = "Error while Reading data from file \n" + responseWriteFile;
                }
                else
                {
                    string split = services.Local.SPLITstring(dataCONF, 0, label_COMport.Text.Length + 5); // tach lay ten cong COM
                    if (!string.Equals(split, label_COMport.Text + ":" + cmB_COMport.Text))
                    {
                        MessageBox.Show("Cannot load CONFIGURATION!");
                    }
                    else
                    {
                        services.Local.readCONF(dataCONF, ref responseReadFile,
                                                ref label_COMport, ref cmB_COMport,
                                                ref label_Baud, ref cmB_Baud,
                                                ref label_Parity, ref cmB_Parity);  // cap nhat cac CONFIG
                        richTextBox_Status.Text = localpath + "\nRead data CONFIGURATION successfully";
                        richTextBox_ResCOM.Text = responseReadFile;
                    }
                }
            }
        }
        #endregion Button Clicks

        #region Events
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Realtimestt.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        #endregion Events
    }
}
