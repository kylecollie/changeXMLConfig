using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ChangeXMLConfig
{
    public partial class frmConfigXML : Form
    {
        List<Config> ConfigList = new List<Config>();

        public frmConfigXML()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save the changed xml file
        }

        private void frmConfigXML_Load(object sender, EventArgs e)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(@"c:\users\kyle\documents\visual studio 2013\Projects\ChangeXMLConfig\ChangeXMLConfig\config.xml");
            XmlNodeList XmlDocNodes = XmlDoc.DocumentElement.SelectNodes("/config");

            foreach (XmlNode node in XmlDocNodes)
            {
                Config obj = new Config(
                    Convert.ToBoolean(node["onlineInspection"].InnerText)
                    );
                ConfigList.Add(obj);
            }
            foreach (Config cfig in ConfigList)
            {
                chkOnlineInsp.Checked = cfig.onlineInsp;
            }
        }
    }
}
