using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace ChangeXMLConfig
{
    public partial class frmConfigXML : Form
    {
        List<Config> ConfigList = new List<Config>();
        XmlDocument XmlDoc = new XmlDocument();

        public frmConfigXML()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save the changed xml file
            XmlNodeList XmlDocNodes = XmlDoc.DocumentElement.SelectNodes("/config");
            Boolean save = false;
            foreach (XmlNode node in XmlDocNodes)
            {
                if (node["onlineInspection"].InnerText != ConfigList[0].onlineInsp.ToString())
                {
                    node["onlineInspection"].InnerText = ConfigList[0].onlineInsp.ToString();
                    save = true;
                }
            }
            if (save)
            {
                XmlDoc.Save(@"config.xml");
            }
        }

        private void frmConfigXML_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDoc.Load(@"config.xml");
                //XmlDoc.Load(@"C:\Users\KTCollie\Source\Repos\changeXMLConfig\ChangeXMLConfig\config.xml");
                XmlNodeList XmlDocNodes = XmlDoc.DocumentElement.SelectNodes("/config");

                foreach (XmlNode node in XmlDocNodes)
                {
                    //if (node.e)
                    //{
                        Config config = new Config(
                                        Convert.ToBoolean(node["onlineInspection"].InnerText)
                                        ); 
                    //}
                    ConfigList.Add(config);
                }
                foreach (Config cfig in ConfigList)
                {
                    chkOnlineInsp.Checked = cfig.onlineInsp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void chkOnlineInsp_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Config cfg in ConfigList)
            {
                cfg.onlineInsp = chkOnlineInsp.Checked;
            }
        }
    }
}
