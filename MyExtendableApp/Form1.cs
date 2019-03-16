using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CommonSnappableTypes;

namespace MyExtendableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void snapInModuleToolStipMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                if (openDlg.FileName.Contains("CommonSnappableTypes"))
                    MessageBox.Show("CommonSnappableTypes has no snap-ins");
                else if(!LoadExternalModule(openDlg.FileName))
                    MessageBox.Show("Nothing implements IAppFunctionality");
            }
        }

        private bool LoadExternalModule(string path)
        {
            bool foundSnapIn = false;
            Assembly snapInAsm = null;
            try
            {
                snapInAsm = Assembly.LoadFrom(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return foundSnapIn;
            }
            var classTypes = from t in snapInAsm.GetTypes()
                             where t.IsClass && (t.GetInterface("IAppFunctionality") != null)
                             select t;
            foreach(var type in classTypes)
            {
                foundSnapIn = true;
                IAppFunctionality itfApp = (IAppFunctionality)snapInAsm.CreateInstance(type.FullName, true);
                itfApp.DoIt();
                lstLoadedSnappIns.Items.Add(type.FullName);
                DisplayCompanyData(type);
            }
            return foundSnapIn;
        }

        private void DisplayCompanyData(Type classType)
        {
            var customAttr = from attr in classType.GetCustomAttributes(false)
                             where attr.GetType() == typeof(CompanyInfoAttribute)
                             select attr;
            foreach(CompanyInfoAttribute attr in customAttr)
                MessageBox.Show(attr.CompanyUrl, string.Format("More info about {0} you can find at", attr.CompanyName));
        }
    }
}
