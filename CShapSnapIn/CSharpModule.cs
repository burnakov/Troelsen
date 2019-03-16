using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSnappableTypes;
using System.Windows.Forms;

namespace CShapSnapIn
{
    [CompanyInfo(CompanyName = "MyCompany", CompanyUrl = "www.mycompany.com")]
    public class CSharpModule : IAppFunctionality
    {
        void IAppFunctionality.DoIt()
        {
            MessageBox.Show("You've just used C# snap-in!");
        }
    }
}
