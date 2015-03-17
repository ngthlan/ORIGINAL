using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Ports;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Windows;


namespace CSELABMAN.CONTROL
{
    class Services
    {
        public WebServices Network = new WebServices();
        public AppServices Local = new AppServices();
    }

    class WebServices
    {
        //string sttpostHTTPS;
        //public static string errorHTTPS;

        #region Hashing
        // hash password truoc khi gui len server
        public string hashpass(string refpass, ref bool ckchass)
        {
            string hassstring = null;
            using (MD5 md5Hash = MD5.Create())
            {
                hassstring = GetMd5Hash(md5Hash, refpass);

                //Console.WriteLine("The MD5 hash of " + refpass + " is: " + hash + ".");

                //Console.WriteLine("Verifying the hash...");
                ckchass = VerifyMd5Hash(md5Hash, refpass, hassstring);
                /*if (VerifyMd5Hash(md5Hash, refpass, hash))
                {
                    Console.WriteLine("The hashes are the same.");
                }
                else
                {
                    Console.WriteLine("The hashes are not same.");
                }*/
            }
            return hassstring;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        // Verify a hash against a string. 
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion Hashing

        #region Connect to server HTTP
        //  gui thong tin POST len web http
        public string POST(ref bool errorW, ref string errorWEBS, string Url, params string[] postdata)
        {
            string result = string.Empty;
            string data = string.Empty;
            string tem = null;
            errorW = false;
            System.Text.ASCIIEncoding ascii = new ASCIIEncoding();

            /*if (postdata.Length < 2)
            {
                MessageBox.Show("Parameters must be even , \"user\" , \"value\" , ... etc", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }*/
            //string name = null;
            for (int i = 0; i < postdata.Length; i += 2)
            {
                data += string.Format("&{0}={1} ", postdata[i], postdata[i + 1]);
            }
            //string tem = "json="; 
            data = data.Remove(0, 1);
            //tem += System.Net.WebUtility.HtmlDecode(data);
            //data = tem;
            tem = null;
            //Console.WriteLine(data);
            byte[] bytesarr = ascii.GetBytes(data);

            foreach (byte tmp in bytesarr)
            {
                tem += tmp.ToString();
            }
            Console.WriteLine(tem);
            //MessageBox.Show(tem);
            try
            {
                //string URL = Url+"?"+postdata[0]+"="+postdata[1]+"&"+postdata[2]+"="+postdata[3];
                string URL = Url;
                WebRequest request = WebRequest.Create(URL);

                request.Method = "POST";
                //request.ContentType = "text/xml";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;
                request.Timeout = 36000;

                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                errorWEBS = ex.Message;
                errorW = true;
            }
            return result;
        }

        //  gui thong tin POST len web http security
        public string POSTHTTPS(ref bool errorW, ref string errorWEBS, string url, params string[] postdata)
        {
            string result = string.Empty;
            string data = string.Empty;
            string tem = null;
            errorW = false;
            System.Text.ASCIIEncoding ascii = new ASCIIEncoding();

            /*if (postdata.Length < 2)
            {
                MessageBox.Show("Parameters must be even , \"user\" , \"value\" , ... etc", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }*/
            //string name = null;
            for (int i = 0; i < postdata.Length; i += 2)
            {
                data += string.Format("&{0}={1} ", postdata[i], postdata[i + 1]);
            }
            //string tem = "json="; 
            data = data.Remove(0, 1);
            //tem += System.Net.WebUtility.HtmlDecode(data);
            //data = tem;
            tem = null;
            //Console.WriteLine(data);
            byte[] bytesarr = ascii.GetBytes(data);

            foreach (byte tmp in bytesarr)
            {
                tem += tmp.ToString();
            }
            Console.WriteLine(tem);
            //MessageBox.Show(tem);
            try
            {
                Uri uri = new Uri(url);

                WebRequest http = HttpWebRequest.Create(url);
                http.Timeout = 36000;
                HttpWebResponse response = (HttpWebResponse)http.GetResponse();
                Stream stream = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(stream);
                result = streamread.ReadToEnd();
                streamread.Close();
                //Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                errorWEBS = ex.Message;
                errorW = true;
            }
            return result;
        }

        #endregion Connect to server HTTP

        #region Connect to server TCP
        public void DemocpListener(string ipaddress, Int32 port, ref string response, ref bool errEX, ref string ExMess)
        {
            TcpListener server = null;
            errEX = false;
            try
            {
                // Set the TcpListener on port 13000.
                //Int32 port = 13000;
                //IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                IPAddress localAddr = IPAddress.Parse(ipaddress);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop. 
                while (true)
                {
                    response = "Waiting for a connection... ";
                    Console.Write(response);

                    // Perform a blocking call to accept requests. 
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    response = "Connected!";
                    Console.WriteLine(response);

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client. 
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        response = "Received: {0}" + data;
                        Console.WriteLine(response);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        response = "Sent: {0}" + data;
                        Console.WriteLine(response);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                errEX = true;
                ExMess = "SocketException: {0}" + e.Message;
                Console.WriteLine(response);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            response = "Waiting....";
            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
        #endregion Connect to server TCP

        #region Response from server HTTP
        AppServices appServices = new AppServices();
        //public bool ErrRes = false;
        //public string MessRes = null;
        //public string MessResstt = null;
        public void showresponse(string path, string Data, string url, ref bool ErrRes, ref string MessRes, ref string MessResstt)
        {
            bool cmpres = false;
            string tmp1 = null, tmp2 = null;
            string defaulttmp = "<!doctype html>";
            AppServices appservices = new AppServices() ;
            try
            {
                /*Console.WriteLine("Data[0] is : \"" + Data[0] + "\", Data[1] is : \"" + Data[1] + "\"");
                if (Data[0].Equals('<') || Data[0].Equals('?') || Data[0].Equals('!') || Data[0].Equals(' ') || Data[0].Equals('\r') || Data[0].Equals('\n')
                 || Data[1].Equals('<') || Data[1].Equals('?') || Data[1].Equals('!') || Data[1].Equals(' ') || Data[1].Equals('\r') || Data[1].Equals('\n'))
                    cmpres = true;
                else
                    cmpres = false;*/
                tmp1 = appservices.Split1stline(Data);
                tmp2 = appservices.SPLITstring(tmp1, 0, defaulttmp.Length);
                //Console.WriteLine("\ntmp2 is : " + tmp2);
                if (string.Equals(tmp2, "<!doctype html>")
                 || string.Equals(tmp2, "<!doctype HMTL>")
                 || string.Equals(tmp2, "<!DOCTYPE html>")
                 || string.Equals(tmp2, "<!DOCTYPE HTML>"))
                    cmpres = true;
                else
                    cmpres = false;

            }
            catch (Exception ex)
            {
                ErrRes = true;
                MessRes = ex.Message;
                //MessageBox.Show(ex.Message);
            }

            /*if (ErrRes)
            {
                ErrRes = false;
                MessRes="Connection timed out";
            }
            else */
            if (cmpres)
            {
                System.Diagnostics.Process myproc = new System.Diagnostics.Process();
                //string mydocpath = @"C:\Users\Public\Documents\";
                appservices.writetofile(Data, path);
                //richText_Stt.Text = "Connected successful \n" + url;
                MessResstt = "Connected successfully";
                System.Diagnostics.Process.Start(path);
                cmpres = false;
            }
            else
            {
                MessResstt = "Connected to : " + url + "\n" + Data;
                //Console.WriteLine("Method successful.");
            }
            /*
              IAsyncResult result;
        Action action = () =>
        {
            // Your code here
        };

        result = action.BeginInvoke(null, null);

        if (result.AsyncWaitHandle.WaitOne(10000))
            Console.WriteLine("Method successful.");
        else
            Console.WriteLine("Method timed out.");
        }*/

        #endregion Response from server HTTP
        }
    }
    class AppServices
    {
        #region Write and Read file

        // doc data tu file txt 
        public string readfiletxt(ref bool errread, ref string errres, string path)
        {
            string resultread = null;
            if (!File.Exists(path))
            {
                errread = true;
                errres = " File is not exist!";
                return null;
            }
            else
            {
                try
                {
                    string[] lines = File.ReadAllLines(path);
                    resultread = stringarraytostring(lines);
                }
                catch (Exception e)
                {
                    errread = true;
                    errres = e.Message;
                }
            }
            return resultread;
        }

        // ghi data vao file txt
        public void writetxt(ref bool errwrite, ref string errres, string[] data, string path)
        {
            StreamWriter sw = new StreamWriter(path, false);
            try
            {
                for (int i = 0; i < data.Length ; i++)
                {
                    sw.WriteLine(data[i]);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                errwrite = true;
                errres = e.Message;
            }

        }

        public void writetofiletxt(ref bool errwrite, ref string errres, string data, string path)
        {
            char[] tmparray = new char[data.Length];                // tao new char []
            string[] tmpstrarray = stringtostringarray(data);       // doi string thanh string[]
            errres = null;
            errres = stringarraytostring(tmpstrarray);              // doi string[] thanh string
            //Console.WriteLine("errres is : \n" + errres);
            //Console.WriteLine("tmpstrarray is : "+tmpstrarray);
            
            StreamWriter sw;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.Close();
            }

            if (tmpstrarray== null)
                writetofile(data, path);
            else
                writetxt(ref errwrite, ref errres, tmpstrarray, path);
        }

        // ghi data vao file bat ki
        public void writetofile(string data, string path)
        {
            StreamWriter sw;
            //sw = File.CreateText("c:\\testtext.txt");
            //sw.WriteLine("this is just a test");

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.Close();
            }
            TextWriter tw = new StreamWriter(path);
            tw.WriteLine(data);
            tw.Close();
        }
        #endregion Write and Read file

        #region Convert Type
        // doi char[] sang string
        string resultstring;
        public string chararraytostring(char[] inchart)
        {
            resultstring = null;
            if (inchart.Equals(null))
                resultstring = string.Empty;
            else
            {
                foreach (char tmp in inchart)
                {
                    resultstring += tmp.ToString();
                }
            }
            return resultstring;
        }

        // doi char[] sang string
        public char[] stringtochararray(string data)
        {
            char[] chararray = new char[data.Length];
            data.CopyTo(0, chararray, 0, data.Length);
            return chararray;
        }

        // doi char[] sang char       
        char resultchar;
        public char chararraytochar(char[] inchart)
        {
            resultchar = new char();
            foreach (char tmp in inchart)
            {
                resultchar += tmp;
            }
            return resultchar;
        }

        // doi Byte[] sang HexString
        public string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        // doi char[] sang string bo dau cach
        public string CharArrayToString(char[] data)
        {
            string des = null;
            foreach (char tmp in data)
            {
                if (!tmp.Equals(' '))
                    des += tmp.ToString();
            }
            return des;
        }

        // dem so ki tu xuong dong
        public int countENTER(string data)
        {
            char[] tmpchar = new char[data.Length];
            data.CopyTo(0, tmpchar, 0, data.Length);
            int result = 0, i = 0;
            do {
                result = (tmpchar[i].Equals('\n'))? result+1 : result ;
                i++;
            }
            while (i < data.Length) ;

            return result;
        }

        /*// dem so CHUOI bi giua cac khoi xuong dong 
        public int countMIDENTER(string data)
        {
            int result = 0;
            
            if (data.Length == 0)
                result = data.Length;
            else
            {
                char[] tmp = stringtochararray(data);
                int start = 0, end = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    string tmpdis = (tmp[i].Equals('\n')) ? "[ ]" : tmp[i].ToString() ;
                    Console.WriteLine("Ki tu dang xet : "+tmpdis);
                    
                }
            }
            return result;
        }*/

        /*// dem so ki tu space
        public int countSPACE(string data)
        {
            char[] tmpchar = new char[data.Length];
            data.CopyTo(0, tmpchar, 0, data.Length);
            int result = 0, i = 0;
            do
            {
                result = (tmpchar[i].Equals(' ')) ? result + 1 : result;
                i++;
            }
            while (i < data.Length);

            return result;
        }*/

        /*// chuyen string sang string[]
        public string[] stringtostringarray2(string data)
        {
            string[] resultstringarray = null;
            string tmpstr = null;
            char[] tmpchar = new char[data.Length];
            data.CopyTo(0, tmpchar, 0, data.Length);
            int strarrayindex = 0;
            int countENT = countENTER(data);
            countENT = (!tmpchar[0].Equals('\n')) ? countENT += 1 : countENT;                   // neu dau chuoi khac NULL thi tang size string[]
            countENT = (!tmpchar[data.Length - 1].Equals('\n')) ? countENT += 1 : countENT;       // neu cuoi chuoi khac NULL thi tang size string[]
            resultstringarray = new string[countENT];
            bool ckcF = false;                                                  // kiem tra null cho toi khi doc du lieu khac null
            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                {
                    tmpstr += tmpchar[i].ToString();
                    resultstringarray[strarrayindex] = tmpstr;
                    //tmpstr = null;
                }
                else if (tmpchar[i].Equals('\n'))
                {
                    if (!ckcF)
                        tmpstr = null;
                    //else
                    //    tmpstr = tmpchar[i].ToString();

                    resultstringarray[strarrayindex] = tmpstr;
                    tmpstr = null;
                    strarrayindex += 1;
                }
                else
                {
                    ckcF = true;
                    tmpstr += tmpchar[i].ToString();
                }
            }
            return resultstringarray;
        }*/

        // chuyen string sang string[]
        public string[] stringtostringarray(string data)
        {
            string[] resultstringarray = null;
            if (string.IsNullOrEmpty(data))
                return null;
            else
            {
                char[] tmparray = new char[data.Length];            // tao new char[] tam thoi co kich thuoc = data
                data.CopyTo(0, tmparray, 0, data.Length);           // doi string thanh char[]
                string tmpstr = null;                               // tao string tam thoi
                string[] tmpstrarray = new string[data.Length];     // tao string[] tam thoi co kich thuoc = <kich thuoc data>
                int countstrarray = 0;                              // so dem cua string[] dang xet
                for (int i = 0; i < data.Length; i++)                  // xet moi char tam thoi cua char[]
                {
                    if (i == data.Length - 1)     // neu so dem char[] = <kich thuoc data> -1 thi ngat 
                    {                                               // va ... 
                        /*if (tmparray[i].Equals('\n'))
                        {
                            tmpstrarray[countstrarray] = tmpstr;        // gan string[] tam thoi = string tam thoi
                            tmpstr = null;
                            countstrarray += 1;
                        }
                        else
                            tmpstr += tmparray[i].ToString();               // lay char cuoi cung gan vao string tam thoi*/

                        tmpstr += tmparray[i].ToString();               // lay char cuoi cung gan vao string tam thoi
                        tmpstrarray[countstrarray] = tmpstr;        // gan string[] tam thoi = string tam thoi
                        //Console.WriteLine("tmpstrarray[" + countstrarray + "] is : " + tmpstrarray[countstrarray]);
                        countstrarray += 1;                         // cong so dem string[] len 1
                        tmpstr = null;                              // xoa bo nho string tam thoi
                        break;
                    }
                    else if (tmparray[i].Equals('\n'))                       // neu char tam thoi la \n thi gan string[] tam thoi = string tam thoi
                    {                                               // va gan string tam thoi = null
                        tmpstrarray[countstrarray] = tmpstr;
                        tmpstr = null;
                        //Console.WriteLine("tmpstrarray["+countstrarray+"] is : "+ tmpstrarray[countstrarray]);
                        countstrarray += 1;                         // cong so dem string[] len 1
                        //countchararray += 1;                        // cong so dem char[] len 1
                    }
                    else
                    {
                        tmpstr += tmparray[i].ToString();               // doi tung char[] thanh string
                        //countchararray += 1;                        // cong so dem char[] len 1
                    }
                }

                resultstringarray = new string[countstrarray];            // tao string[] co kich thuoc = <kich thuoc string[] tam thoi>
                for (int i = 0; i <= countstrarray - 1; i++)        // gan cac tring[] tam thoi vao string[] ket qua
                {
                    resultstringarray[i] = tmpstrarray[i];
                }
                tmpstrarray = null;                                 // xoa bo nho string[] tam thoi
                return resultstringarray;
            }
        }

        // tach string theo mong muon
        public string SPLITstring(string input, int start, int count)
        {
            if (count > (input.Length - start))
                return null;
            else
            {
                string des = null;
                char[] temp = new char[count];
                input.CopyTo(start, temp, 0, count);
                des = chararraytostring(temp);
                return des;
            }
        }

        // tach dong dau tien co chu
        public string Split1stline(string data)
        {
            string des = null;
            string[] tmp = null;
            tmp = stringtostringarray(data) ;
            des = tmp[0] ;
            return des;
        }

        // chuyen string[] sang string
        public string stringarraytostring(string[] data)
        {
            string resultstringfromarray = null;               // xoa du lieu cua resultstringfromarray
            if (data == null)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < data.Length; i++)
                {

                    //Console.WriteLine("data["+i+"] is : "+data[i]);
                    if ((i == data.Length - 1))
                        //if ((i == data.Length - 1) || data[i].Equals("\n"))
                        resultstringfromarray += data[i];
                    else
                        resultstringfromarray += data[i] + "\n";
                }

                return resultstringfromarray;
            }
        }

        #endregion Convert Type

        #region Configuration COMport
        // khoi tao cac thong so cong COM
        public void InitializeControlValues(ref Properties.Settings settings, ref ComboBox cmB_COMport, ref ComboBox cmB_Baud, ref ComboBox cmB_Parity,
                                            ref ComboBox cmbDataBits, ref ComboBox cmbStopBits, ref SerialPort serialPortRFID,
                                            ref bool errorCOM, ref bool errorCONN, ref string response)
        {
            response = null;
            cmB_Parity.Items.Clear(); cmB_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbStopBits.Text = settings.StopBits.ToString();
            cmbDataBits.Text = settings.DataBits.ToString();

            // refresh the COM port in the form if it's available 
            try
            {
                 RefreshserialPortRFIDList(ref cmB_COMport, ref errorCOM, ref serialPortRFID);
            }
            catch (UnauthorizedAccessException)
            {
                errorCONN = true;
            }
            // If it is still avalible, select the last com port used
            if (cmB_COMport.Items.Contains(settings.PortName))
            {
                cmB_COMport.Text = settings.PortName;
                errorCOM = false;
            }
            else if (cmB_COMport.Items.Count > 0)
            {
                cmB_COMport.SelectedIndex = cmB_COMport.Items.Count - 1;
                cmB_Baud.Items.Clear();
                cmB_Baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
                cmB_COMport.Enabled = true;
                cmB_Baud.Enabled = true;
                cmB_Parity.Enabled = true;
            }
            else if (!errorCOM)
            {
                //MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorCOM = true;
                cmB_Baud.Items.Clear();
                cmB_Parity.Items.Clear();
                cmB_COMport.Items.AddRange(new Object[] { });
                cmB_Baud.Items.AddRange(new Object[] { });
                cmB_Parity.Items.AddRange(new Object[] { });
                response = "No COMport!";
            }
        }

        // define the function refresh COM port list
        public void RefreshserialPortRFIDList(ref ComboBox cmB_COMport, ref bool errorCOM, ref SerialPort serialPortRFID)
        {
            // Determain if the list of com port names has changed since last checked
            string selected = RefreshserialPortRFIDList(ref errorCOM,cmB_COMport.Items.Cast<string>(), cmB_COMport.SelectedItem as string, serialPortRFID.IsOpen);

            // If there was an update, then update the control showing the user the list of port names
            if (!String.IsNullOrEmpty(selected))
            {
                cmB_COMport.Items.Clear();
                cmB_COMport.Items.AddRange(OrderedPortNames());
                cmB_COMport.SelectedItem = selected;
            }
        }
        private string[] OrderedPortNames()
        {
            // Just a placeholder for a successful parsing of a string to an integer
            int num;

            // Order the serial port names in numberic order (if possible)
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray();
        }

        private string[] ports;
        private string RefreshserialPortRFIDList(ref bool errorCOM, IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
        {
            // Create a new return report to populate
            string selected = null;

            // Retrieve the list of ports currently mounted by the operating system (sorted by name)
            ports = SerialPort.GetPortNames();

            if (ports.Length != 0)
            {
                errorCOM = false;
                // First determain if there was a change (any additions or removals)
                bool updated = PreviousPortNames.Except(ports).Count() > 0 || ports.Except(PreviousPortNames).Count() > 0;

                // If there was a change, then select an appropriate default port
                if (updated)
                {
                    // Use the correctly ordered set of port names
                    ports = OrderedPortNames();

                    // Find newest port if one or more were added
                    string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

                    // If the port was already open... (see logic notes and reasoning in Notes.txt)
                    if (PortOpen)
                    {
                        if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                        else if (!String.IsNullOrEmpty(newest)) selected = newest;
                        else selected = ports.LastOrDefault();
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(newest)) selected = newest;
                        else if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                        else selected = ports.LastOrDefault();
                    }
                }
            }

            // If there was a change to the port list, return the recommended default selection
            return selected;
        }

        // ghi cac thong tin cau hinh vao file txt CONFIG
        public void writeCONF(ref bool errWriteFile, ref string responseWriteFile, string datain, string localpath, ref string response)
        {
            writetofiletxt(ref errWriteFile, ref responseWriteFile, datain, localpath);
            if (errWriteFile)
            {
                errWriteFile = false;
                response = "Error while Writing data to file \n" + responseWriteFile;
            }
            else
            {
                string responseReadFile = string.Empty;
                bool errReadFile = false;
                string tmp = readfiletxt(ref errReadFile, ref responseReadFile, localpath);
                if (string.IsNullOrEmpty(tmp))
                {
                    response = localpath + "\n Input Data is NULL!";
                }
                else if (!tmp.Equals(datain))
                {
                    response = "Data is not written" + responseReadFile;
                }
                else
                {
                    response = "Write successfully to " + localpath + "\n";// +responseWriteFile;
                }
            }
        }

        // doc cac thong tin CONFIG va cap nhat
        public void readCONF(string dataCONF, ref string response,
                             ref Label label_COMport, ref ComboBox cmB_COMport,
                             ref Label label_Baud, ref ComboBox cmB_Baud, 
                             ref Label label_Parity, ref ComboBox cmB_Parity)
        {
            string[] tmp = stringtostringarray(dataCONF);    // tach cac thong tin {COMport,Baudrate,Parity}
            int countnext = 0;
            char[] tmpnext = null;
            ComboBox tmpComboBox = new ComboBox();
            Label tmpLabel = new Label();
            bool en = true;                                        // duoc phep ghi hay khong ?
            response = null;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == 1)                                            // lay Baudrate
                {
                    tmpLabel = label_Baud;
                    tmpComboBox = cmB_Baud;
                }
                else if (i == 2)                                          // lay Parity
                {
                    tmpLabel = label_Parity;
                    tmpComboBox = cmB_Parity;
                }
                else
                {
                    en = false;
                    tmpLabel = label_COMport;
                    tmpComboBox = cmB_COMport;
                }

                if (en)
                {
                    countnext = tmp[i].Length - tmpLabel.Text.Length - 1;     // lay do dai thong tin Baudrate tuong ung
                    tmpnext = new char[countnext];                          // tao char []                     
                    tmp[i].CopyTo(tmpLabel.Text.Length + 1, tmpnext, 0, countnext);
                    tmpComboBox.SelectedItem = chararraytostring(tmpnext);
                    response += tmpLabel.Text + ":" + chararraytostring(tmpnext) + "\n";
                }
                else
                {
                    en = true;
                    response += tmpLabel.Text + ":" + tmpComboBox.SelectedItem + "\n";               
                }
                //Console.WriteLine("tmpnext [" + i + "] is : " + chararraytostring(tmpnext));
            }
        }

        #endregion Configuration COMport
        
        #region Process

        public void demoprocess()
        {
            string tmp = null;
            /*foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                tmp += p.ProcessName + " - " + p.Id+"\n";*/
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcessesByName("firefox"))
                tmp += p.ProcessName + " - " + p.Id + "\n";
                MessageBox.Show(tmp);
        }
     
        #endregion Process

        #region demoCOMport

        /*static bool _continue;
        static SerialPort _serialPort;
        public void demoCOM()
        {
            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            //_serialPort.PortName = SetPortName(_serialPort.PortName);
            //_serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            //_serialPort.Parity = SetPortParity(_serialPort.Parity);
            //_serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            //_serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            //_serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            _serialPort.PortName = SetPortName("COM7");
            _serialPort.BaudRate = SetPortBaudRate(9600);
            _serialPort.Parity = SetPortParity(Parity.None);
            _serialPort.DataBits = SetPortDataBits(8);
            _serialPort.StopBits = SetPortStopBits(StopBits.One);
            _serialPort.Handshake = SetPortHandshake(Handshake.None);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            _continue = true;
            readThread.Start();

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Type QUIT to exit");

            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    _serialPort.WriteLine(
                        String.Format("<{0}>: {1}", name, message));
                }
            }

            readThread.Join();
            _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Time out");
                }
            }
        }

        // Display Port values and prompt user to enter a port. 
        public string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
            portName = Console.ReadLine();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }
        // Display BaudRate values and prompt user to enter a value. 
        public int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;

            Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
            baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        // Display PortParity values and prompt user to enter a value. 
        public Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
            parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value. 
        public int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
            dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }

        // Display StopBits values and prompt user to enter a value. 
        public StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;

            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter StopBits value (None is not supported and \n" +
             "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
            stopBits = Console.ReadLine();

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("End Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }*/
        #endregion demoCOMport

    }
}
