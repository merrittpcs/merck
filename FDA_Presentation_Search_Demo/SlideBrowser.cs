using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDA_Presentation_Search_Demo
{
    public partial class SlideBrowser : Form
    {
        public SlideBrowser()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string sAddress = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\bin\Debug\SearchResultsListView.html";
            webBrowser1.Navigate(new Uri(sAddress));

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string sAddress = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\bin\Debug\3By3.html";
            webBrowser1.Navigate(new Uri(sAddress));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string sAddress = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\bin\Debug\6By6.html";
            webBrowser1.Navigate(new Uri(sAddress));
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string sAddress = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\bin\Debug\12By12.html";
            webBrowser1.Navigate(new Uri(sAddress));
        }
    }
}
