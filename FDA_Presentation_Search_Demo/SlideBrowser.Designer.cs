namespace FDA_Presentation_Search_Demo
{
    partial class SlideBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnList = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(131, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1023, 444);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\merrirob\\Documents\\Visual Studio 2012\\Projects\\FDA_Presentation_Search_D" +
        "emo\\FDA_Presentation_Search_Demo\\bin\\Debug\\SearchResultsListView.html", System.UriKind.Absolute);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(113, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 41);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(113, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3 By 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(12, 70);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(113, 23);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6 By 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(12, 99);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(113, 23);
            this.btn12.TabIndex = 4;
            this.btn12.Text = "12 By 12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // SlideBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 444);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.webBrowser1);
            this.Name = "SlideBrowser";
            this.Text = "SlideBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn12;
    }
}