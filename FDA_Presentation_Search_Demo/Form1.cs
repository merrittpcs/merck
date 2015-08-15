using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;

namespace FDA_Presentation_Search_Demo
{
    public partial class Form1 : Form
    {
        #region Global Variables

        public static long lrowCount = 1;
        public static OleDbDataReader rr;
        public static AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        public static OleDbDataReader rr2;
        public static AutoCompleteStringCollection namesCollection2 = new AutoCompleteStringCollection();
        public static OleDbDataReader rr3;
        public static DataTable dt = new DataTable();
        public static string sSearchMode = "Word";
        public static string gsSearchTerm = "";
        public static string gsRelevantSearchTerm = "";
        public static string gsSortBy = "SlideNumber";
        public static string gsSortDirection = "ASC";

        #endregion

        #region Search Form

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string sAddress = string.Format(@"{0}\SearchStart.html", Application.StartupPath);
            webBrowser1.Navigate(new Uri(sAddress));

            rlmInitialzieAutoComplete();
            TabPage tp = new TabPage();
            tp = tab1.TabPages["DataGridResults"];
            tab1.TabPages.Remove(tp);
        }

        #endregion

        #region General

        private void rlmLoadAllSideText()
        {

            OleDbConnection con = new OleDbConnection();
            string sDatabaseAddress = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\DemoFDAProposal.accdb" + @"'; Persist Security Info=False;";
            con.ConnectionString = sDatabaseAddress;
            con.Open();

            string sSearchTerm = rlmFormattedSearchTerm();

            String query = "select SlideNumber, AllSlideText, Thumbnail, CountOfSlideNumber from qryAllSlideText where AllSlideText like '%" + sSearchTerm.Trim() + "%'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            dt.Clear();
            rr3 = cmd.ExecuteReader();
            dt.Load(rr3);
            con.Close();
        }
        private void rlmInitialzieAutoComplete()
        {
            

            OleDbConnection con = new OleDbConnection();
            string sDatabaseAddress = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\DemoFDAProposal.accdb" + @"'; Persist Security Info=False;";
            con.ConnectionString = sDatabaseAddress;
            con.Open();

            string query2 = "";
            query2 = "SELECT Left(SearchTerm,InStr(1,SearchTerm,' ',1)) AS WordSearchTerm FROM DataSuggest WHERE (((DataSuggest.SearchTerm) Is Not Null));";

            OleDbCommand cmd2 = new OleDbCommand(query2, con);
            rr2 = cmd2.ExecuteReader();
            
            rr2.Read();
            while (rr2.Read())
                namesCollection2.Add(rr2["WordSearchTerm"].ToString());
            //int icount = namesCollection2.Count();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = namesCollection2;


            string query = "";

            query = "select distinct SearchTerm from DataSuggest order by SearchTerm;";
            OleDbCommand cmd = new OleDbCommand(query, con);

            rr = cmd.ExecuteReader();
            rr.Read();
            while (rr.Read())
                namesCollection.Add(rr["SearchTerm"].ToString());
            //textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //textBox1.AutoCompleteCustomSource = namesCollection;
            con.Close();
        }
        protected string rlmFormattedSearchTerm()
        {
            //string sSearchTerm = textBox1.Text.Trim();
            string sSearchTerm = gsSearchTerm.Trim();
            sSearchTerm = sSearchTerm.ToUpper().Replace("XOR", " XOR ");
            sSearchTerm = sSearchTerm.ToUpper().Replace("XND", " XND ");
            sSearchTerm = sSearchTerm.ToUpper().Replace("XOT", " XOT ");

            sSearchTerm = sSearchTerm.Replace("    ", " ");
            sSearchTerm = sSearchTerm.Replace("   ", " ");
            sSearchTerm = sSearchTerm.Replace("  ", " ");

            sSearchTerm = sSearchTerm.ToUpper().Replace(" XOR ", "XOR");
            sSearchTerm = sSearchTerm.ToUpper().Replace(" XND ", "XND");
            sSearchTerm = sSearchTerm.ToUpper().Replace(" XOT ", "XOT");

            if (sSearchTerm.ToUpper().Contains("XND") || sSearchTerm.ToUpper().Contains("XOR") || sSearchTerm.ToUpper().Contains("XOT"))
            {
                //sSearchTerm = sSearchTerm.Replace("  ", "");
                //sSearchTerm = sSearchTerm.Replace(" ", "");
            }

            sSearchTerm = sSearchTerm.ToUpper().Replace("XOR", "%' OR AllSlideText like '%");
            sSearchTerm = sSearchTerm.ToUpper().Replace("XND", "%' AND AllSlideText like '%");
            sSearchTerm = sSearchTerm.ToUpper().Replace("XOT", "%' AND NOT AllSlideText like '%");
            sSearchTerm = sSearchTerm.ToUpper().Replace("XND XND", "AND");

            return sSearchTerm;

        }
        private void lblSearchMode_Click(object sender, EventArgs e)
        {
            //rlmToggleSearchMode();
        }
        private void rlmToggleSearchMode()
        {
            if (textBox1.AutoCompleteCustomSource == namesCollection2)
            {

                sSearchMode = "Phrase";
                textBox1.AutoCompleteMode = AutoCompleteMode.None;
                textBox1.AutoCompleteSource = AutoCompleteSource.None;
                textBox1.Refresh();
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = namesCollection;
                textBox1.Refresh();

            }
            else if (textBox1.AutoCompleteCustomSource == namesCollection)
            {

                sSearchMode = "Word";
                textBox1.AutoCompleteMode = AutoCompleteMode.None;
                textBox1.AutoCompleteSource = AutoCompleteSource.None;
                textBox1.Refresh();
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = namesCollection2;
                textBox1.Refresh();
            }
            lblSearchMode.Text = "Search Mode:" + sSearchMode;

        }
        private void rlmOutputViews()
        {

            if (gsSearchTerm.Length > 0)
            {
                rlmLoadAllSideText();
                BuildThumbNailView(12);
                BuildThumbNailView(3);
                BuildThumbNailView(6);
                BuildListView();
                rlmSuggestAlternativeTerm();
                rlmRelevantSearchTerms();

                if (lrowCount > 11)
                {
                    string sAddress = string.Format(@"{0}\12By12.html", Application.StartupPath);
                    webBrowser1.Navigate(new Uri(sAddress));

                }
                else if (lrowCount > 5)
                {
                    string sAddress = string.Format(@"{0}\6By6.html", Application.StartupPath);
                    webBrowser1.Navigate(new Uri(sAddress));
                }

                else
                {
                    string sAddress = string.Format(@"{0}\3By3.html", Application.StartupPath);
                    webBrowser1.Navigate(new Uri(sAddress));
                }

                label1.Text = string.Format("{0} results", lrowCount);
            }
        }
        private void tab1_TabIndexChanged(object sender, EventArgs e)
        {
            //string sAddress = webBrowser1.Url;
            //webBrowser1.Navigate(new Uri(sAddress);
            webBrowser1.Refresh();
        }
 
        #endregion

        #region Search Textbox (Textbox1) code

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Space && sSearchMode == "Word")
    {
        e.SuppressKeyPress = false;
        textBox1.AutoCompleteMode = AutoCompleteMode.None;
        textBox1.AutoCompleteSource = AutoCompleteSource.None;
        textBox1.Refresh();
        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBox1.AutoCompleteCustomSource = namesCollection;
        textBox1.Refresh();
        SendKeys.Send(" ");
        sSearchMode = "Phrase";

    }
    else if (e.KeyCode != Keys.Space && sSearchMode == "Phrase" && !textBox1.Text.Contains(' '))
    {
        e.SuppressKeyPress = false;
        textBox1.AutoCompleteMode = AutoCompleteMode.None;
        textBox1.AutoCompleteSource = AutoCompleteSource.None;
        textBox1.Refresh();
        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBox1.AutoCompleteCustomSource = namesCollection2;
        textBox1.Refresh();
        sSearchMode = "Word";
    }

    lblSearchMode.Text = "Search Mode:" + sSearchMode;


}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
{

}

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
{

}

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
                //rlmToggleSearchMode();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gsSearchTerm = textBox1.Text.ToString();
                rlmOutputViews();
                
            } else 
            
            {
                if (e.KeyCode == Keys.Space && sSearchMode == "Word")
                {
                //    sSearchMode = "None";
                //    textBox1.AutoCompleteMode = AutoCompleteMode.None;
                //    textBox1.AutoCompleteSource = AutoCompleteSource.None;
                //    textBox1.Refresh();
                //    textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                //    textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //    textBox1.AutoCompleteCustomSource = namesCollection;
                //    textBox1.Refresh();


                //    string sSearchText = textBox1.Text.ToString().Trim();
                    //SendKeys.Send(" ");

                //sSearchMode = "Phrase";

                }
                else if (e.KeyCode != Keys.Space && sSearchMode == "Phrase" && !textBox1.Text.Contains(' '))
                {
                //    sSearchMode = "None";
                //    textBox1.AutoCompleteMode = AutoCompleteMode.None;
                //    textBox1.AutoCompleteSource = AutoCompleteSource.None;
                //    textBox1.Refresh();
                //    textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                //    textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //    textBox1.AutoCompleteCustomSource = namesCollection2;
                //    textBox1.Refresh();


                    //string sSearchText = textBox1.Text.ToString();
                    //textBox1.Text = sSearchText.ToString() + " ";
                    //textBox1.SelectionStart = textBox1.TextLength;
                    //SendKeys.Send("{BACKSPACE}");

                //sSearchMode = "Word";
                }

                //lblSearchMode.Text = "Search Mode: " + sSearchMode;
               
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region BuildHTML
        protected string BuildThumbNailView(int iCols)
        {

            DataTable dt2 = new DataTable();

            string sSearchTerm = rlmFormattedSearchTerm();

            dt.DefaultView.RowFilter = string.Format("AllSlideText LIKE '%{0}%'", sSearchTerm.Trim());

            string colName = gsSortBy;
            string sDirection = gsSortDirection;
            dt.DefaultView.Sort = string.Format("{0} {1}", colName,sDirection);

            dt2 = dt.DefaultView.ToTable();
            DataColumn colThumbnail = dt2.Columns["Thumbnail"];
            DataColumn colSlideNum = dt2.Columns["SlideNumber"];
            int i = 1;
            int imgHeight = 0;
            int imgWidth = 0;
            string sSlideNum = "0";
            string sSelectedSearchTerm = textBox1.Text.Trim();
            string sDatabaseAddress = @"var connectionstring = ""Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\DemoFDAProposal.accdb" + @"'; Persist Security Info=False"";";
            sDatabaseAddress = sDatabaseAddress.Replace(@"\","\\\\");
            //string sDatabaseAddress = @"var connectionstring = ""Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Use rs\\merrirob\\Desktop\\FDA\\DemoFDAProposal.accdb'; Persist Security Info=False"";";
            
            
            switch (iCols)
            {
                case 3:
                    imgHeight = 300;
                    imgWidth = 328;
                    break;
                case 6:
                    imgHeight = 150;
                    imgWidth = 164;
                    break;

                case 12:
                    imgHeight = 70;
                    imgWidth = 82;
                    break;

            }

            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<html >");
            strHTMLBuilder.Append("<head>");
            strHTMLBuilder.Append("<title>");
            strHTMLBuilder.Append(iCols + " Column View");
            strHTMLBuilder.Append("</title>");
            strHTMLBuilder.Append("<style>");
            strHTMLBuilder.Append(@"td{border:1px gray solid;} img{height:" + imgHeight + "; width: " + imgWidth +"; cursor:pointer;");
            strHTMLBuilder.Append("</style>");
            
            //Build script tag
            strHTMLBuilder.Append("<script src='slideThumbnails.js' />");
            strHTMLBuilder.Append("<script>");
            strHTMLBuilder.Append(@"function InsertSearchTerm2(){ ");
            strHTMLBuilder.Append(@"if (true) {");
            strHTMLBuilder.Append(@"var connection = new ActiveXObject(""ADODB.Connection"");");
            strHTMLBuilder.Append(sDatabaseAddress);
            strHTMLBuilder.Append(@"connection.Open(connectionstring);");
            strHTMLBuilder.Append(@"var rs = new ActiveXObject(""ADODB.Recordset"");");
            strHTMLBuilder.Append(string.Format(@"rs.Open(""INSERT INTO tblSearchTerms ( SearchTerm ) SELECT '{0}'"",connection);",sSelectedSearchTerm));
            strHTMLBuilder.Append(@"alert(""Searchterm Added Successfuly"");");
            strHTMLBuilder.Append(@"connection.close();}");
            strHTMLBuilder.Append(@"else{alert(""Error Adding Searchterm!"");}");
            strHTMLBuilder.Append(@" }");
            strHTMLBuilder.Append("</script>");

            strHTMLBuilder.Append("</head>");
            strHTMLBuilder.Append("<body>");

            strHTMLBuilder.Append("<table >");
            strHTMLBuilder.Append("<tr >");

            lrowCount = 0;
            foreach (DataRow myRow in dt2.Rows)
            {
                string sImagePath = Application.StartupPath + myRow[colThumbnail.ColumnName].ToString();
                sImagePath = sImagePath.Replace("\\","\\\\");
                string sSlideNum2 = myRow[colSlideNum.ColumnName].ToString();
                if (lrowCount == 0)

                { 
                           // strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"');"" >");
                    strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"','" + sImagePath + @"'," + sSlideNum2 + @");"" >");

                }
                
                if (sSlideNum.ToString() != myRow[colSlideNum.ColumnName].ToString())
                {
                    lrowCount = ++lrowCount;
                    sSlideNum = myRow[colSlideNum.ColumnName].ToString();
                    if (i == (iCols +1))
                    {
                        i = 1;
                        strHTMLBuilder.Append("</tr>");
                        strHTMLBuilder.Append("<tr>");
                        //strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"');"" >");
                        strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"','" + sImagePath + @"'," + sSlideNum2 + @");"" >");

                        
                    }

                    if (i > 1)
                    {
                        //strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"');"" >");
                        strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"','" + sImagePath + @"'," + sSlideNum2 + @");"" >");

                    }

                    strHTMLBuilder.Append(@"<img src='" + Application.StartupPath + myRow[colThumbnail.ColumnName].ToString() + "' />");
                    strHTMLBuilder.Append("</td>");
                    i = ++i;
                }
        
            }

            //Close tags.   
            strHTMLBuilder.Append("</td>");
            strHTMLBuilder.Append("</tr>");
            strHTMLBuilder.Append("</table>");
            strHTMLBuilder.Append("</body>");
            strHTMLBuilder.Append("</html>");

            string Htmltext = strHTMLBuilder.ToString();
            File.WriteAllText(iCols + "By" + iCols + ".html", Htmltext);
            return Htmltext;

        }
        protected string BuildListView()
        {
    
            DataTable dt2 = new DataTable();


            string sSearchTerm = rlmFormattedSearchTerm();

            dt.DefaultView.RowFilter = string.Format("AllSlideText LIKE '%{0}%'", sSearchTerm.Trim());

            string colName = gsSortBy;
            string sDirection = gsSortDirection;
            dt.DefaultView.Sort = string.Format("{0} {1}", colName, sDirection);

            dt2 = dt.DefaultView.ToTable();
            DataColumn colThumbnail = dt2.Columns["Thumbnail"];
            DataColumn colSlideNum = dt2.Columns["SlideNumber"];

            int i = 1;
            int imgHeight = 100;
            int imgWidth = 100;
            string sSlideNum = "0";


            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<html >");
            strHTMLBuilder.Append("<head>");
            strHTMLBuilder.Append("<title>");
            strHTMLBuilder.Append("Search Results List View");
            strHTMLBuilder.Append("</title>");
            strHTMLBuilder.Append("<style>");
            strHTMLBuilder.Append(@"td{border:1px gray solid;height:auto;} img{height:" + imgHeight + "; width: " + imgWidth + ";cursor:pointer;} .Sentence{height:25%;} .Paragraph{height:75%;}");
            strHTMLBuilder.Append("</style>");

            strHTMLBuilder.Append("<script src='slideThumbnails.js' />");
            strHTMLBuilder.Append("<script>");
            strHTMLBuilder.Append("</script>");

            strHTMLBuilder.Append("</head>");
            strHTMLBuilder.Append("<body>");

            strHTMLBuilder.Append("<table >");
            strHTMLBuilder.Append("<tr >");
            strHTMLBuilder.Append("<td class='Sentence' >");

            foreach (DataRow myRow in dt2.Rows)
            {

                string sImagePath = Application.StartupPath + myRow[colThumbnail.ColumnName].ToString();
                sImagePath = sImagePath.Replace("\\", "\\\\");
                string sSelectedSearchTerm = textBox1.Text.ToString();

                if (sSlideNum.ToString() != myRow[colSlideNum.ColumnName].ToString())
                {
                    sSlideNum = myRow[colSlideNum.ColumnName].ToString();
            
                    if (i > 1)
                    {
                        strHTMLBuilder.Append("</td>");
                        strHTMLBuilder.Append("</tr>");
                        strHTMLBuilder.Append("<tr>");
                        strHTMLBuilder.Append("<td class='Sentence' >");
                    }

                    strHTMLBuilder.Append(myRow["AllSlideText"].ToString());
                    strHTMLBuilder.Append("</td>");
                    //strHTMLBuilder.Append("<td rowspan='2' >");
                    strHTMLBuilder.Append(@"<td onClick=""InsertSearchTerm('" + sSelectedSearchTerm + @"','" + sImagePath + @"'," + sSlideNum + @");"" >");
                    strHTMLBuilder.Append(@"<img src='" + Application.StartupPath + myRow[colThumbnail.ColumnName].ToString() + "' />");

                    strHTMLBuilder.Append("</td>");
                    strHTMLBuilder.Append("</tr>");
                    strHTMLBuilder.Append("<tr>");
                    strHTMLBuilder.Append("<td class='Paragraph'>");
                    strHTMLBuilder.Append(myRow["AllSlideText"].ToString());
                    i = ++i;
                }

            }

            //Close tags.   
            strHTMLBuilder.Append("</td>");
            strHTMLBuilder.Append("</tr>");
            strHTMLBuilder.Append("</table>");
            strHTMLBuilder.Append("</body>");
            strHTMLBuilder.Append("</html>");

            string Htmltext = strHTMLBuilder.ToString();
            File.WriteAllText("SearchResultsListView.html", Htmltext);
            return Htmltext;

        }

        #endregion

        #region Buttons
        private void btn3_Click(object sender, EventArgs e)
        {
            string sAddress = string.Format(@"{0}\3By3.html", Application.StartupPath);
            webBrowser1.Navigate(new Uri(sAddress));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string sAddress = string.Format(@"{0}\6By6.html", Application.StartupPath);
            webBrowser1.Navigate(new Uri(sAddress));
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string sAddress = string.Format(@"{0}\12By12.html", Application.StartupPath);
            webBrowser1.Navigate(new Uri(sAddress));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            rlmOutputViews();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string sAddress = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\bin\Debug\SearchResultsListView.html";
            string sAddress = string.Format(@"{0}\SearchResultsListView.html", Application.StartupPath);
            webBrowser1.Navigate(new Uri(sAddress));


        }

        #endregion

        #region Common Misspellings

        public static string Compute(string word)
        {
            return Compute(word, 4);
        }
        public static string Compute(string word, int length)
    {
        // Value to return
        string value = "";
        // Size of the word to process
        int size = word.Length;
        // Make sure the word is at least two characters in length
        if (size > 1)
        {
            // Convert the word to all uppercase
            word = word.ToUpper();
            // Convert the word to character array for faster processing
            char[] chars = word.ToCharArray();
            // Buffer to build up with character codes
            StringBuilder buffer = new StringBuilder();
            buffer.Length = 0;
            // The current and previous character codes
            int prevCode = 0;
            int currCode = 0;
            // Append the first character to the buffer
            buffer.Append(chars[0]);
            // Loop through all the characters and convert them to the proper character code
            for (int i = 1; i < size; i++)
            {
                switch (chars[i])
                {
                    case 'A':
                        currCode = 0;
                        break;
                    case 'E':
                        currCode = 0;
                        break;
                    case 'I':
                        currCode = 0;
                        break;
                    case 'O':
                        currCode = 0;
                        break;
                    case 'U':
                        currCode = 0;
                        break;
                    case 'H':
                        currCode = 0;
                        break;
                    case 'W':
                        currCode = 0;
                        break;
                    case 'Y':
                        currCode = 0;
                        break;
                    case 'B':
                        currCode = 1;
                        break;
                    case 'F':
                        currCode = 1;
                        break;
                    case 'P':
                        currCode = 1;
                        break;
                    case 'V':
                        currCode = 1;
                        break;
                    case 'C':
                        currCode = 2;
                        break;
                    case 'G':
                        currCode = 2;
                        break;
                    case 'J':
                        currCode = 2;
                        break;
                    case 'K':
                        currCode = 2;
                        break;
                    case 'Q':
                        currCode = 2;
                        break;
                    case 'S':
                        currCode = 2;
                        break;
                    case 'X':
                        currCode = 2;
                        break;
                    case 'Z':
                        currCode = 2;
                        break;
                    case 'D':
                        currCode = 3;
                        break;
                    case 'T':
                        currCode = 3;
                        break;
                    case 'L':
                        currCode = 4;
                        break;
                    case 'M':
                        currCode = 5;
                        break;
                    case 'N':
                        currCode = 5;
                        break;
                    case 'R':
                        currCode = 6;
                        break;
                 }
// Check to see if the current code is the same as the last one
                if (currCode != prevCode)
                {
                    // Check to see if the current code is 0 (a vowel); do not process vowels
                    if (currCode != 0)
                        buffer.Append(currCode);
                }
                // Set the new previous character code
                prevCode = currCode;
                // If the buffer size meets the length limit, then exit the loop
                if (buffer.Length == length)
                    break;
                }
// Pad the buffer, if required
                size = buffer.Length;
                if (size < length)
                    buffer.Append('0', (length - size));
                // Set the value to return
                value = buffer.ToString();
            }
            // Return the value
            return value;
    }
        protected void rlmSuggestAlternativeTerm()
        {

            OleDbConnection con = new OleDbConnection();
            string sDatabaseAddress = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\DemoFDAProposal.accdb" + @"'; Persist Security Info=False;";
            con.ConnectionString = sDatabaseAddress;
            con.Open();

            string sSearchTermSoundEx = Compute(gsSearchTerm.ToString());
            String query = "select distinct SearchTerm from DataSuggest where SoundEx like '%" + sSearchTermSoundEx.Trim() + "%' order by SearchTerm";
            OleDbCommand cmd = new OleDbCommand(query, con);

            con.Close();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
         
            lbxAltSearchTerms.DisplayMember = "SearchTerm";
            lbxAltSearchTerms.ValueMember = "SearchTerm";
            lbxAltSearchTerms.DataSource = dt;
            
        }

        #endregion
        #region Relevant Search Terms

        private void rlmRelevantSearchTerms()
        {
            OleDbConnection con = new OleDbConnection();
            string sDatabaseAddress = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\DemoFDAProposal.accdb" + @"'; Persist Security Info=False;";
            con.ConnectionString = sDatabaseAddress;
            con.Open();

            String query = "select CountOfSearchTerm, SearchTerm from qryCountSearchTerms where Searchterm like '%" + textBox1.Text.Trim() + "%'";
            OleDbCommand cmd = new OleDbCommand(query, con);

            con.Close();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
         
            lbxRelevant.DisplayMember = "SearchTerm";
            lbxRelevant.ValueMember = "SearchTerm";
            lbxRelevant.DataSource = dt;

        }

        #endregion

        #region Code Archive

        public async void ProcessRead()
        {
            string filePath = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\dataSuggest.csv";

            if (File.Exists(filePath) == false)
            {
                Debug.WriteLine("file not found: " + filePath);
            }
            else
            {
                try
                {
                    string text = await ReadTextAsync(filePath);
                    Debug.WriteLine(text);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        private async Task<string> ReadTextAsync(string filePath)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }
        private void BuildListView2()
        {
           
            StreamWriter html3by3 = new StreamWriter("3By3.html");
            html3by3.WriteLine("<html>");
            html3by3.WriteLine("<title>");
            html3by3.WriteLine("Slides - 3 By 3 View");
            html3by3.WriteLine("</title>");

            //Styles
            html3by3.WriteLine("<style>");
            html3by3.WriteLine(@"img { height:400px; width:400px;}");
            html3by3.WriteLine(@"td { border:1px gray solid;}");

            html3by3.WriteLine("</style>");

            //body
            html3by3.WriteLine("<body>");
            html3by3.WriteLine("<table>");
        }
        private static void ReadCSVFile(DataGridView dgv)
        {
            
            string path = @"C:\Users\merrirob\Documents\Visual Studio 2012\Projects\FDA_Presentation_Search_Demo\FDA_Presentation_Search_Demo\dataSuggest.csv";
            StreamReader oStreamReader = new StreamReader(path);
            DataTable oDataTable = new DataTable();
            int rowCount = 0;

            string[] columnNames = null;
            string[] oStreamDataValues = null;

            while (!oStreamReader.EndOfStream)
            {
                string ostreamRowData = oStreamReader.ReadLine().Trim();

                if (ostreamRowData.Length > 0)
                {
                    oStreamDataValues = ostreamRowData.Split(',');
                    if (rowCount == 0)
                    {
                        rowCount = 1;
                        columnNames = oStreamDataValues;
                        foreach (string csvHeader in columnNames)
                        {
                            DataColumn oDataColumn = new DataColumn(csvHeader, typeof(string));
                            oDataColumn.DefaultValue = string.Empty;
                            oDataTable.Columns.Add(oDataColumn);
                        }
                    }
                    else
                    {
                        DataRow oDataRow = oDataTable.NewRow();
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            oDataRow[columnNames[i]] = oStreamDataValues[i] == null ? string.Empty : oStreamDataValues[i].ToString();
                        }
                        oDataTable.Rows.Add(oDataRow);
                    }
                }
            }
            oStreamReader.Close();
            oStreamReader.Dispose();
            dt = oDataTable;
            dgv.DataSource = dt;

            Console.WriteLine(oDataTable.Rows.Count);
            string rowValues = string.Empty;
            foreach (DataRow dr in oDataTable.Rows)
            {
                foreach (string csvColumns in columnNames)
                {
                    rowValues += csvColumns + "=" + dr[csvColumns].ToString() + "  ";
                }
            }
            //Console.WriteLine(rowValues);
            //Console.ReadLine();
        }
        protected string ExportDatatableToHtml()   
{

    DataTable dt2 = new DataTable();        
    dt.DefaultView.RowFilter = string.Format("SearchTerm LIKE '%{0}%'", textBox1.Text.Trim());
    dt2 = dt.DefaultView.ToTable(); 
            //dt.AcceptChanges();
            
            StringBuilder strHTMLBuilder = new StringBuilder();   
            strHTMLBuilder.Append("<html >");   
            strHTMLBuilder.Append("<head>");   
            strHTMLBuilder.Append("</head>");   
            strHTMLBuilder.Append("<body>");   
            strHTMLBuilder.Append("<table border='1px' cellpadding='1' cellspacing='1' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>");   
   
            strHTMLBuilder.Append("<tr >");   
            foreach (DataColumn myColumn in dt.Columns)   
            {   
            strHTMLBuilder.Append("<td >");   
            strHTMLBuilder.Append(myColumn.ColumnName);   
            strHTMLBuilder.Append("</td>");   
   
            }   
            strHTMLBuilder.Append("</tr>");   
   
   
            foreach (DataRow myRow in dt2.Rows)   
            {   
   
            strHTMLBuilder.Append("<tr >");   
            foreach (DataColumn myColumn in dt2.Columns)   
            {   
            strHTMLBuilder.Append("<td >");   
            strHTMLBuilder.Append(myRow[myColumn.ColumnName].ToString());   
            strHTMLBuilder.Append("</td>");   
   
            }   
            strHTMLBuilder.Append("</tr>");   
            }   
   
            //Close tags.   
            strHTMLBuilder.Append("</table>");   
            strHTMLBuilder.Append("</body>");   
            strHTMLBuilder.Append("</html>");   
   
            string Htmltext = strHTMLBuilder.ToString();
            File.WriteAllText("output.html", Htmltext);
            return Htmltext;

}


        #endregion

        private void lbxAltSearchTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbxAltSearchTerms_Click(object sender, EventArgs e)
        {
            gsSearchTerm = lbxAltSearchTerms.Text.ToString();
            rlmOutputViews();
        }

        private void lblClearSearch_Click(object sender, EventArgs e)
        {
            string sAddress = string.Format(@"{0}\SearchStart.html", Application.StartupPath);
            webBrowser1.Navigate(new Uri(sAddress));

            textBox1.Clear();
            lbxAltSearchTerms.DataSource = null;

        }

        private void lblSortByMostViewed_Click(object sender, EventArgs e)
        {
            gsSortBy = "CountOfSlideNumber";
            gsSortDirection = "DESC";
            rlmOutputViews();
            lblSortBySlideNumber.Font = new Font(lblSortBySlideNumber.Font.FontFamily,lblSortBySlideNumber.Font.Size, FontStyle.Regular);
            lblSortByMostViewed.Font = new Font(lblSortByMostViewed.Font.FontFamily, lblSortByMostViewed.Font.Size, FontStyle.Bold);
        }

        private void lblSortBySlideNumber_Click(object sender, EventArgs e)
        {
            gsSortBy = "SlideNumber";
            gsSortDirection = "ASC";
            rlmOutputViews();
            lblSortBySlideNumber.Font = new Font(lblSortBySlideNumber.Font.FontFamily, lblSortBySlideNumber.Font.Size, FontStyle.Bold);
            lblSortByMostViewed.Font = new Font(lblSortByMostViewed.Font.FontFamily, lblSortByMostViewed.Font.Size, FontStyle.Regular);

        }

        private void lbxRelevant_Click(object sender, EventArgs e)
        {
            gsSearchTerm = lbxRelevant.Text.ToString();
            rlmOutputViews();
        }

    }

}
