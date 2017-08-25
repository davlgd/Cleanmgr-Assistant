using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Cleanmgr_Assistant
{
    public partial class Form1 : Form
    {
        private string selectedDriveLetter = string.Empty;

        public Form1()
        {
            InitializeComponent();
            this.Text = string.Format("{0} v{1}",
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            refreshFixedDisks();
            btActionCheckStatus();
        }

        private void refreshFixedDisks()
        {
            cbDrives.Items.Clear();

            DriveInfo[] di = DriveInfo.GetDrives();
            foreach (var d in di)
            {
                if (d.DriveType == DriveType.Fixed) cbDrives.Items.Add(string.Format("{0} ({1}) : {2} Go libres sur {3} Go{4}",
                    d.Name,
                    d.DriveFormat,
                    d.AvailableFreeSpace / 1024 / 1024 / 1024,
                    d.TotalSize / 1024 / 1024 / 1024,
                    Environment.NewLine));
            }

            if (cbDrives.Items.Count > 0) cbDrives.SelectedIndex = 0;
            else
            {
                MessageBox.Show("Aucun disque détecté, l'application va être fermée", "Erreur - Disque",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        private void btActions_Click(object sender, EventArgs e)
        {
            string args = string.Empty;

            switch (cbActions.SelectedIndex)
            {
                case 0:
                    args = "/D " + selectedDriveLetter;
                    break;

                case 1:
                    args = "/LOWDISK /D " + selectedDriveLetter;
                    break;

                case 2:
                    args = "/VERYLOWDISK /D " + selectedDriveLetter;
                    break;

                case 4:
                    args = "/sageset:42";
                    break;

                case 5:
                    args = "/sagerun:42";
                    break;

                case 7:
                    args = "/autoclean /D " + selectedDriveLetter;
                    break;
            }

            Process p = new Process();
            p.StartInfo.FileName = "cleanmgr.exe";
            p.StartInfo.Arguments = args;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
        }

        private void btActionCheckStatus()
        {
            btActions.Enabled = (cbActions.SelectedIndex != 3 && cbActions.SelectedIndex != 6 && cbActions.SelectedIndex > -1) ? true : false;
        }

        private void btDrives_Click(object sender, EventArgs e)
        {
            refreshFixedDisks();
        }

        private void cbActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btActionCheckStatus();
        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDriveLetter = cbDrives.SelectedItem.ToString().Split('\\')[0];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://www.nextinpact.com/news/104401-assistant-nettoyage-windows-cleanmgr-exe-supprimez-facilement-fichiers-inutiles.htm");
        }
    }
}
