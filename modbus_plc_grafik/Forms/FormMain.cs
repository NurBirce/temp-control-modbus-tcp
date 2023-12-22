using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modbus_plc_grafik.Modbus;
using modbus_plc_grafik.Chart;
using EasyModbus;

namespace modbus_plc_grafik.Forms
{
    public partial class FormMain : Form
    {
        internal ModbusConn modbusObject;
        internal FormCh plcObject;
        public FormMain()
        {
            InitializeComponent();
            modbusObject = new ModbusConn(this);
        }

        private async Task initialization()
        {
            await modbusObject.initiliaze();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await initialization();
            //plcObject.connect_plc();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modbusObject.initiliaze();
        }


        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modbusObject.disconnect_mclient();
        }

        public FormCh formCh;
        private void chartCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCh == null)
            {
                formCh = new FormCh(this);
                formCh.MdiParent = this;
                formCh.FormClosed += FrmCh_FormClosed;
                formCh.Show();
            }
            else
            {
                formCh.Activate();
            }
        }

        private void FrmCh_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCh?.Dispose();
            formCh = null;
        }

        public FormManuelCh formManuelCh;
        private void manuelChartCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formManuelCh == null)
            {
                formManuelCh = new FormManuelCh(this);
                formManuelCh.MdiParent = this;
                formManuelCh.FormClosed += FrmManuelCh_FormClosed;
                formManuelCh.Show();
            }
            else
            {
                formManuelCh.Activate();
            }
        }

        private void FrmManuelCh_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManuelCh?.Dispose();
            formManuelCh = null;
        }

        private void printRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
