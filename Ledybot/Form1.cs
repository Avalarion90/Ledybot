﻿using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ledybot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string szIp = tb_IP.Text;
            string szPort = tb_Port.Text;

            int iPort = Convert.ToInt32(szPort);

            if (!Program.Connected)
            {
                Program.Connected = Program.scriptHelper.connect(szIp, iPort);
                if (Program.Connected)
                {
                    MessageBox.Show("Connection Successful!");
                }
            } else
            {
                MessageBox.Show("You are already connected!");
            }

            
        }

        Thread workerThread = null;
        Worker workerObject = null;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (workerThread == null && workerObject == null)
            {
                workerObject = new Worker();
                workerObject.setValues(tb_PokemonToFind.Text, tb_GiveAway.Text, tb_Default.Text, tb_Folder.Text, tb_Level.Text, tb_PID.Text, cb_Spanish.Checked, (int) nud_Count.Value, cb_EndStart.Checked);
                workerThread = new Thread(workerObject.DoWork);
                workerThread.Start();
            }         
        }

        public void AppendListViewItem(string szTrainerName, string szNickname, string szCountry, string szSubCountry)
        {
            if (InvokeRequired)
            {
                 this.Invoke(new Action<string, string, string, string>(AppendListViewItem), new object[] { szTrainerName, szNickname, szCountry, szSubCountry });
                return;
            }
            string[] row = { DateTime.Now.ToString("h:mm:ss"), szTrainerName, szNickname, szCountry, szSubCountry };
            var listViewItem = new ListViewItem(row);

            lv_log.Items.Add(listViewItem);
            lv_log.Items[lv_log.Items.Count - 1].EnsureVisible();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if(workerThread != null && workerObject != null)
            {
                workerObject.RequestStop();
                workerThread.Join();

                workerObject = null;
                workerThread = null;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ListViewToCSV(lv_log, AppDomain.CurrentDomain.BaseDirectory + "\\export.csv", true);
            MessageBox.Show("Exported!");
        }

        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            //make header string
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append(String.Format("\"{0}\"", columnValue(i)));
            }
            result.AppendLine();
        }
    }
}