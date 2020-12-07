using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyModbus;
using WatsonTcp;
using SimpleTCP;

namespace DeltaLoadCell
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private ModbusServer modbusServer = null;
        SimpleTcpServer tcpServerBut;
        SimpleTcpServer tcpServerCam;
        SimpleTcpClient tcpClientCam;
        
        Queue<string> buts = new Queue<string>();
        Queue<Cam> camdata = new Queue<Cam>();
        Queue<But> butdata = new Queue<But>();
        List<But> buttoRobdata = new List<But>();
        //List<But> butListe1 = new List<But>();
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            tcpServerBut = new SimpleTcpServer().Start(505);
            tcpServerBut.DataReceived += TcpServerBut_DataReceived;
            tcpServerBut.ClientConnected += TcpServerBut_ClientConnected;     


            //tcpServerCam = new SimpleTcpServer().Start(550);
            //tcpServerCam.DataReceived += TcpServerCam_DataReceived;
            //tcpServerCam.ClientConnected += TcpServerCam_ClientConnected;



        }

        private void ModbusServer_HoldingRegistersChanged(int register, int numberOfRegisters)
        {
           
            long org_encoderval = ((UInt16)(modbusServer.holdingRegisters[2])*65536+(UInt16)(modbusServer.holdingRegisters[1]));
            lblEnc1.Text = org_encoderval.ToString();
            label3.Text = modbusServer.holdingRegisters[5].ToString();
            label4.Text = modbusServer.holdingRegisters[6].ToString();
            long fark=0;
            foreach (var item in butdata)
            {
                fark=org_encoderval - (item.encoderValue + item.posX);
            }

            if (fark>=Convert.ToInt64(txtC.Text))
            {
                But b = butdata.Dequeue();
                buttoRobdata.Add(b);
                gridControl4.DataSource = buttoRobdata.ToList();
                gridControl3.DataSource = butdata.ToList();
                modbusServer.coils[10] = true;
            }
            if (buttoRobdata.Count>0)
            {
                modbusServer.holdingRegisters[5] = (Int16)buttoRobdata.OrderByDescending(x => x.Zaman).FirstOrDefault().posY;
                modbusServer.holdingRegisters[6] = (Int16)buttoRobdata.OrderByDescending(x => x.Zaman).FirstOrDefault().rotZ;
            }
            else
            {
                modbusServer.holdingRegisters[5] = 0;
                modbusServer.holdingRegisters[6] = 0;
            }
         


        }

        private void TcpServerCam_ClientConnected(object sender, System.Net.Sockets.TcpClient e)
        {
            label2.Text = e.Client.AddressFamily.ToString();
        }

        //private void TcpServerCam_DataReceived(object sender, SimpleTCP.Message e)
        //{
        //    try
        //    {
        //        string data = Encoding.UTF8.GetString(e.Data);

        //        Cam cm = new Cam();
        //        cm.Data = data;
        //        cm.Alan = 0;
        //        cm.posX = 0;
        //        cm.posY = 0;
        //        cm.rotZ = 0;
        //        camdata.Enqueue(cm);
        //        gridControl2.DataSource = camdata;
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}

        private void TcpServerBut_ClientConnected(object sender, System.Net.Sockets.TcpClient e)
        {
            label1.Text = e.Client.AddressFamily.ToString();
        }

        private void TcpServerBut_DataReceived(object sender, SimpleTCP.Message e)
        {
            //MessageBox.Show(Encoding.UTF8.GetString(e.Data));
            try
            {
                string data = Encoding.UTF8.GetString(e.Data);
                string[] veri = data.Split(';');
                int channel = Convert.ToInt32(veri[0].Trim());
                string gramaj = veri[1].Trim();
                if (channel == 1)
                {
                    buts.Enqueue(gramaj);
                }
                else if (channel == 2)
                {

                }
                else if (channel == 3)
                {

                }
                DataTable dt = new DataTable();                
                dt.Columns.Add("Gramaj");
                foreach (var item in buts)
                {
                    
                    dt.Rows.Add(item.ToString());
                   
                    
                }
                gridControl1.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            modbusServer = new ModbusServer();
            modbusServer.Port = 502;
            modbusServer.Listen();
            modbusServer.CoilsChanged += ModbusServer_CoilsChanged;
            modbusServer.HoldingRegistersChanged += ModbusServer_HoldingRegistersChanged;
            



            tcpClientCam = new SimpleTcpClient().Connect("192.168.1.131", 9876);
            if (tcpClientCam.TcpClient.Connected)
            {
                label2.Text = "Connected";
            }
            else
            {
                label2.Text = "Not Connected";
            }
            tcpClientCam.DataReceived += TcpClientCam_DataReceived;

            //tcpServerBut.Start();

        }

        private void ModbusServer_CoilsChanged(int coil, int numberOfCoils)
        {
            try
            {
                if (modbusServer.coils[11]==true)
                {
                    buttoRobdata.Remove(buttoRobdata.OrderByDescending(x => x.Zaman).FirstOrDefault());
                    modbusServer.coils[11] = false;
                }    
               
               
            }
            catch (Exception)
            {
               
            }
            
            
        }

        private void TcpClientCam_DataReceived(object sender, SimpleTCP.Message e)
        {
            try
            {
                string data = Encoding.UTF8.GetString(e.Data);
                string[] values = data.Split(';');
                Cam cm = new Cam();
                
                cm.Data = data;
                cm.Alan = Convert.ToInt32(values[4]);
                cm.posX = Convert.ToInt32(values[2])*-1;
                cm.posY = Convert.ToInt32(values[1]);
                cm.rotZ = Convert.ToInt32(values[3]);
                cm.GecmeZaman = DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString()+":"+DateTime.Now.Millisecond.ToString();
                camdata.Enqueue(cm);
                gridControl2.DataSource = camdata.ToList();

                if (camdata.Count != 0)
                {
                    string currentGramaj = buts.Dequeue();
                    cm = camdata.Dequeue();
                    But bt = new But();


                    bt.Gramaj = Convert.ToSingle(currentGramaj.Replace('.', ','));
                    bt.posX = cm.posX;
                    bt.posY = cm.posY;
                    bt.rotZ = cm.rotZ;
                    bt.alan = cm.Alan;
                    bt.Zaman = DateTime.Now;
                    bt.encoderValue = Convert.ToInt64((float)(cm.posX) *3.4613935+Convert.ToInt64(lblEnc1.Text));

                    butdata.Enqueue(bt);
                    gridControl3.DataSource = butdata.ToList();
                }
                else
                {
                    buts.Dequeue();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Gramaj");
                if (buts.Count!=0)
                {
                    buts.Dequeue();
                    foreach (var item in buts)
                    {

                        dt.Rows.Add(item.ToString());


                    }

                   
                }
                if (camdata.Count!=0)
                {
                    camdata.Dequeue();
                }
                
                gridControl2.DataSource = camdata.ToList();
                gridControl1.DataSource = dt;
            }
            catch (Exception)
            {

            }
            
        }
    }
}
