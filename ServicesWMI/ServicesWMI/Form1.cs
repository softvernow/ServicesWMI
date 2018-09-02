using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesWMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public String Get_Service_Status()
        {

            String result = String.Empty;

            ManagementScope scope = null;
            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                //options.Username = "username"
                //options.Password = "password"
                //options.Authority = "NTLMDOMAIN:MY_DOMAIN";

                scope = new ManagementScope("\\\\" +"PCNAME"+ "\\root\\cimv2", options);
                scope.Connect();

                //Query system for Operating System information
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Service");
                //ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Service WHERE Name = 'Tomcat6'");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    result = result + "Service: " + m["Name"].ToString() + " Status: " + m["State"].ToString() + "\r";
                }


            }
            catch 
            {
                result = "Unable to Retrieve Service Status";
            }

            scope = null;

            return result;


        }

        private void btnGetServices_Click(object sender, EventArgs e)
        {
            txtServices.Text= Get_Service_Status();
        }
    }
}

