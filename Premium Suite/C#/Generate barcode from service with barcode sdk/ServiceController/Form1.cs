//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Management;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ServiceController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInstallService_Click(object sender, EventArgs e)
        {
            try
            {
                // Install the service
                ServiceInstaller.Install("Service1", "Service1", Path.GetFullPath("WindowsService1.exe"));
            
                // Set the service option "Allow desktop interaction".
                ConnectionOptions co = new ConnectionOptions();
                co.Impersonation = ImpersonationLevel.Impersonate;
                ManagementScope mgmtScope = new ManagementScope(@"root\CIMV2", co);
                mgmtScope.Connect();
                ManagementObject wmiService = new ManagementObject("Win32_Service.Name='Service1'");
                ManagementBaseObject InParam = wmiService.GetMethodParameters("Change");
                InParam["DesktopInteract"] = true;
                ManagementBaseObject OutParam = wmiService.InvokeMethod("Change", InParam, null);

				// Start the service
                ServiceInstaller.StartService("Service1");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUninstallService_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceInstaller.Uninstall("Service1");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
