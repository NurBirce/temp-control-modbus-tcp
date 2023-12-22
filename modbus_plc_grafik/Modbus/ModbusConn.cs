using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modbus_plc_grafik.Forms;
using EasyModbus;
using System.Threading;

namespace modbus_plc_grafik.Modbus
{
    internal class ModbusConn
    {
        public ModbusClient modbusClient;
        FormMain fm;
        public int[] Rdata;
        public int Pdata;

        public ModbusConn(FormMain formMain)
        {
            fm = formMain;
        }
        public async Task connect_mClient()
        {
            var modbusClient = new ModbusClient("127.0.0.1", 502);

            try
            {
                modbusClient.Connect();
                Console.WriteLine("Modbus connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Modbus connection failed! " + e.ToString());
            }
        }

        public async Task received_Modbus_Message()
        {
            var task_client = Task.Run(() =>
            {

                try
                {
                    var sleepTime = TimeSpan.FromMilliseconds(100);
                    var startingAddress = 0;

                    Rdata = modbusClient.ReadInputRegisters(startingAddress, 1);
                    Console.WriteLine("Recieved data: " + Rdata);

                    Thread.Sleep(sleepTime);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception in RECIEVE: " + e.ToString());
                }
                return Task.CompletedTask;
            });

            await task_client;
        }

        public async Task published_Modbus_Message()
        {
            var task_client = Task.Run(() =>
            {
                try
                {
                    var sleepTime = TimeSpan.FromMilliseconds(100);
                    var registerAddress = 0;

                    modbusClient.WriteSingleRegister(registerAddress, Pdata);
                    Console.WriteLine("Published data: " + Pdata);

                    Thread.Sleep(sleepTime);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception in PUBLİSH: " + e.ToString());
                }
                return Task.CompletedTask;
            });

            await task_client;
        }

        public async Task initiliaze()
        {
            await connect_mClient();
            await received_Modbus_Message();
        }

        public async Task disconnect_mclient()
        {
            try
            {
                modbusClient.Disconnect();
                Console.WriteLine("Modbus disconnected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Modbus disconnection failed! " + e.ToString());

            }
            
            
        }
    }
}
