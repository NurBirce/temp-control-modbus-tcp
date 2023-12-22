using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using S7.Net;
using modbus_plc_grafik.Forms;
using modbus_plc_grafik.Modbus;
using System.Threading;

namespace modbus_plc_grafik.Chart
{
    public partial class FormManuelCh : Form
    {
        Plc plcObject;
        FormMain fm;
        internal ModbusConn modbusObject;
        GraphPane graphPane;
        int[] Rtemp;
        double time = 0;
        int Ptemp;

        PointPairList myPointPairList = new PointPairList();
        bool bStopTest = false;
        public FormManuelCh(FormMain formMain)
        {
            InitializeComponent();
            fm = formMain;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormManuelCh_Load(object sender, EventArgs e)
        {
            initializeGraph();

            Rtemp = modbusObject.Rdata;
            txt_Input_Data.Text = Rtemp[0].ToString();

            Ptemp = Convert.ToInt32(txt_Input_Data.Text);
            modbusObject.Pdata = Ptemp;
            Ptemp = modbusObject.Rdata[0];
        }

        //public void connect_plc()
        //{
        //    plcObject = new Plc(CpuType.S71200, "127.0.0.1",0,1);
        //    plcObject.Open();

        //    try{
        //        if (plcObject.IsConnected)
        //        {
        //           Console.WriteLine("plc communication is ok");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Connection failed! " + e.ToString());
        //    }

        //}
        //public void disconnect_plc()
        //{
        //    plcObject.Close();
        //}

        private void initializeGraph()
        {
            graphPane = zedGraphObj.GraphPane;

            graphPane.Title.Text = "C-Control";
            graphPane.XAxis.Title.Text = "time(seconds)";
            graphPane.YAxis.Title.Text = "temperature";

            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;

            graphPane.Chart.Fill = new Fill(Color.White, Color.Beige, 45.0f);

            LineItem myCurve = graphPane.AddCurve("", myPointPairList, Color.Blue, SymbolType.Circle);

            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 5;
        }

        private void updateGraph()
        {
            zedGraphObj.AxisChange();
            zedGraphObj.Invalidate();
            zedGraphObj.Update();
            zedGraphObj.Refresh();
        }

        private void calculateandFill()
        {
            float fStartDegree = 0;
            while (true)
            {
                float fScale = Convert.ToSingle(txt_Input_Data.Text);

                myPointPairList.Add(time, fScale * Math.Sin(Math.PI * fStartDegree / 180));
                fStartDegree++;
                time++;
                lbl_Time.Text = time.ToString();

                updateGraph();

                if (bStopTest)
                {
                    break;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bStopTest = false;
            myPointPairList.Clear();
            Thread plotThread = new Thread(new ThreadStart(calculateandFill));
            plotThread.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bStopTest = true;
        }      
    }
}
