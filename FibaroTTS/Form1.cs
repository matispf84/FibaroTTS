using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Collections;

using System.Net;
using System.Net.Sockets;



using System;
using System.Text;
using System.Windows;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading;

namespace FibaroTTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpVoice ss = new SpVoice();

        SocketPermission permission;
        Socket sListener;
        IPEndPoint ipEndPoint;
        Socket handler;

        private void Form1_Load(object sender, EventArgs e)
        {
            var voices = ss.GetVoices();

            ArrayList list = new ArrayList();
            for (int i = 0; i < voices.Count - 1; i++)
            {
                list.Add(voices.Item(i).GetDescription());
            }

            comboBox1.DataSource = list;

            Start_Button.Enabled = true;
            Stop_Button.Enabled = false;

            CheckForIllegalCrossThreadCalls = false;


            IPHostEntry ipHost = Dns.GetHostEntry("");

            // Gets first IP address associated with a localhost 
            comboBox2.DataSource = ipHost.AddressList;

            sliderVolumen.Value = ss.Volume;
            sliderVelocidad.Value = ss.Rate;

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            Hablar();

        }

        private void Hablar()
        {
            try
            {
                ss.Speak(tbAux.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var voices = ss.GetVoices();
                ss.Voice = voices.Item(comboBox1.SelectedIndex);
            }
            catch (Exception)
            {
                comboBox1.SelectedIndex = 0;

            }

        }

        private void sldVolumen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sliderVolumen_ValueChanged(object sender, EventArgs e)
        {
            ss.Volume = Convert.ToInt32(sliderVolumen.Value);
        }

        private void sliderVelocidad_ValueChanged(object sender, EventArgs e)
        {
            ss.Rate = Convert.ToInt32(sliderVelocidad.Value);
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates one SocketPermission object for access restrictions
                permission = new SocketPermission(
                NetworkAccess.Accept,     // Allowed to accept connections 
                TransportType.Tcp,        // Defines transport types 
                "",                       // The IP addresses of local host 
                SocketPermission.AllPorts // Specifies all ports 
                );

                // Listening Socket object 
                sListener = null;

                // Ensures the code to have permission to access a Socket 
                permission.Demand();

                // Resolves a host name to an IPHostEntry instance 
                IPHostEntry ipHost = Dns.GetHostEntry("");

                // Gets first IP address associated with a localhost 
                IPAddress ipAddr = ipHost.AddressList[comboBox2.SelectedIndex];

                // Creates a network endpoint 
                ipEndPoint = new IPEndPoint(ipAddr, Convert.ToInt32(textBox1.Text));

                // Create one Socket object to listen the incoming connection 
                sListener = new Socket(
                    ipAddr.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                // Associates a Socket with a local endpoint 
                sListener.Bind(ipEndPoint);

                tbStatus.Text = "Servicio iniciado.";

                Start_Button.Enabled = false;
                Stop_Button.Enabled = true;
                grupoRed.Enabled = false;
                grupoVoz.Enabled = false;

            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }


            try
            {
                // Places a Socket in a listening state and specifies the maximum 
                // Length of the pending connections queue 
                sListener.Listen(10);

                // Begins an asynchronous operation to accept an attempt 
                AsyncCallback aCallback = new AsyncCallback(AcceptCallback);
                sListener.BeginAccept(aCallback, sListener);

                tbStatus.Text = "Servidor escuchando en " + ipEndPoint.Address + " Puerto: " + ipEndPoint.Port;


            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            Socket listener = null;

            // A new Socket to handle remote host communication 
            Socket handler = null;
            try
            {
                // Receiving byte array 
                byte[] buffer = new byte[1024];
                // Get Listening Socket object 
                listener = (Socket)ar.AsyncState;
                // Create a new socket 
                handler = listener.EndAccept(ar);

                // Using the Nagle algorithm 
                handler.NoDelay = false;

                // Creates one object array for passing data 
                object[] obj = new object[2];
                obj[0] = buffer;
                obj[1] = handler;

                // Begins to asynchronously receive data 
                handler.BeginReceive(
                    buffer,        // An array of type Byt for received data 
                    0,             // The zero-based position in the buffer  
                    buffer.Length, // The number of bytes to receive 
                    SocketFlags.None,// Specifies send and receive behaviors 
                    new AsyncCallback(ReceiveCallback),//An AsyncCallback delegate 
                    obj            // Specifies infomation for receive operation 
                    );

                // Begins an asynchronous operation to accept an attempt 
                AsyncCallback aCallback = new AsyncCallback(AcceptCallback);
                listener.BeginAccept(aCallback, listener);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                tbAux.Text = string.Empty;

                // Fetch a user-defined object that contains information 
                object[] obj = new object[2];
                obj = (object[])ar.AsyncState;

                // Received byte array 
                byte[] buffer = (byte[])obj[0];

                // A Socket to handle remote host communication. 
                handler = (Socket)obj[1];

                // Received message 
                string content = string.Empty;


                // The number of bytes received. 
                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    content += Encoding.Default.GetString(buffer, 0, bytesRead);

                    // If message contains "<Client Quit>", finish receiving
                    if (content.IndexOf("<Client Quit>") > -1)
                    {
                        // Convert byte array to string
                        string str = content.Substring(0, content.LastIndexOf("<Client Quit>"));

                        //this is used because the UI couldn't be accessed from an external Thread

                        tbAux.Text = "Read " + str.Length * 2 + " bytes from client.\n Data: " + str;


                    }
                    else
                    {
                        // Continues to asynchronously receive data
                        byte[] buffernew = new byte[1024];
                        obj[0] = buffernew;
                        obj[1] = handler;
                        handler.BeginReceive(buffernew, 0, buffernew.Length,
                            SocketFlags.None,
                            new AsyncCallback(ReceiveCallback), obj);
                    }


                    tbAux.Text = content;

                    try
                    {
                        if (content.Substring(0, 9) == "*Volumen=")
                        {
                            sliderVolumen.Value = Convert.ToInt32(content.ToLower().Substring(9));
                        }
                        else if (content.Substring(0, 11) == "*Velocidad=")
                        {
                            sliderVelocidad.Value = Convert.ToInt32(content.ToLower().Substring(11));
                        }
                        else
                        {
                            Hablar();
                        }
                    }
                    catch (Exception)
                    {
                        Hablar();
                    }
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (sListener.Connected)
                {
                    sListener.Shutdown(SocketShutdown.Receive);
                    sListener.Close();
                }
                Stop_Button.Enabled = false;
                Start_Button.Enabled = true;
                grupoRed.Enabled = true;
                grupoVoz.Enabled = true;

                tbStatus.Text = String.Empty;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void sliderVol_Scroll(object sender, EventArgs e)
        {

        }
    }
}

