using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getpcinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetSystemInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void GetSystemInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    listBoxInfoList.Items.Add("Computer Name: " + queryObj["Name"]);
                    listBoxInfoList.Items.Add("Manufacturer: " + queryObj["Manufacturer"]);
                    listBoxInfoList.Items.Add("Model: " + queryObj["Model"]);
                    listBoxInfoList.Items.Add("System Type: " + queryObj["SystemType"]);
                    listBoxInfoList.Items.Add("Total Physical Memory: " + queryObj["TotalPhysicalMemory"]);
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    listBoxInfoList.Items.Add("Processor: " + queryObj["Name"]);
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    listBoxInfoList.Items.Add("OS Name: " + queryObj["Caption"]);
                    listBoxInfoList.Items.Add("Version: " + queryObj["Version"]);
                    listBoxInfoList.Items.Add("Serial Number: " + queryObj["SerialNumber"]);
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    listBoxInfoList.Items.Add("MAC Address: " + queryObj["MACAddress"]);
                    string[] addresses = (string[])queryObj["IPAddress"];
                    if (addresses != null)
                    {
                        foreach (string address in addresses)
                        {
                            listBoxInfoList.Items.Add("IP Address: " + address);
                        }
                    }
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
        }

        private void buttonTXTexport_Click(object sender, EventArgs e)
        {
            SaveToText();
        }


         string getTime = DateTime.Now.ToLongDateString().ToString();
        private void SaveToText()
        {
           
            string textFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, getTime + ".txt");
            using (StreamWriter writer = new StreamWriter(textFileName))
            {
                writer.WriteLine("All PC Info List \t");
                for (int i = 0; i < listBoxInfoList.Items.Count; i++)
                {
                    string ticari = listBoxInfoList.Items[i].ToString();
                    writer.WriteLine($"{ticari}\t");
                }
            }

            MessageBox.Show("Veriler metin dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Dosya yolunu aç
            string directoryPath = Path.GetDirectoryName(textFileName);
            System.Diagnostics.Process.Start(directoryPath);
        }

    }

}
