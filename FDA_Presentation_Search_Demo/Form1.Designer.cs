namespace FDA_Presentation_Search_Demo
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.pgSlideResults = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.DataGridResults = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClearSearch = new System.Windows.Forms.Label();
            this.lbxAltSearchTerms = new System.Windows.Forms.ListBox();
            this.lblSearchMode = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDidYouMean = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.demoFDAProposalDataSet1 = new FDA_Presentation_Search_Demo.DemoFDAProposalDataSet();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.lblSortBySlideNumber = new System.Windows.Forms.Label();
            this.lblSortByMostViewed = new System.Windows.Forms.Label();
            this.lblSortSeparator = new System.Windows.Forms.Label();
            this.lblRelevant = new System.Windows.Forms.Label();
            this.lbxRelevant = new System.Windows.Forms.ListBox();
            this.tab1.SuspendLayout();
            this.pgSlideResults.SuspendLayout();
            this.DataGridResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoFDAProposalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Allergenic ",
            "Allergenic Products ",
            "Allergenic Products Advisory ",
            "Allergenic Products Advisory Committee ",
            "Allergenic Products Advisory Committee Meeting  ",
            "Allergenic Products Advisory Committee Meeting  December    ",
            "Products ",
            "Products Advisory ",
            "Products Advisory Committee ",
            "Products Advisory Committee Meeting  ",
            "Products Advisory Committee Meeting  December    ",
            "Advisory ",
            "Advisory Committee ",
            "Advisory Committee Meeting  ",
            "Advisory Committee Meeting  December    ",
            "Committee ",
            "Committee Meeting  ",
            "Committee Meeting  December    ",
            "Meeting  ",
            "Meeting  December    ",
            "December    ",
            "MK   ",
            "MK   GRASTEK ",
            "MK   GRASTEK Scott ",
            "MK   GRASTEK Scott Greenfeder ",
            "MK   GRASTEK Scott Greenfeder Ph ",
            "MK   GRASTEK Scott Greenfeder Ph D ",
            "MK   GRASTEK Scott Greenfeder Ph D Merck ",
            "GRASTEK ",
            "GRASTEK Scott ",
            "GRASTEK Scott Greenfeder ",
            "GRASTEK Scott Greenfeder Ph ",
            "GRASTEK Scott Greenfeder Ph D ",
            "GRASTEK Scott Greenfeder Ph D Merck ",
            "GRASTEK Scott Greenfeder Ph D Merck Research ",
            "Scott ",
            "Scott Greenfeder ",
            "Scott Greenfeder Ph ",
            "Scott Greenfeder Ph D ",
            "Scott Greenfeder Ph D Merck ",
            "Scott Greenfeder Ph D Merck Research ",
            "Scott Greenfeder Ph D Merck Research Laboratories",
            "Greenfeder ",
            "Greenfeder Ph ",
            "Greenfeder Ph D ",
            "Greenfeder Ph D Merck ",
            "Greenfeder Ph D Merck Research ",
            "Greenfeder Ph D Merck Research Laboratories",
            "Ph ",
            "Ph D ",
            "Ph D Merck ",
            "Ph D Merck Research ",
            "Ph D Merck Research Laboratories",
            "D ",
            "D Merck ",
            "D Merck Research ",
            "D Merck Research Laboratories",
            "Merck ",
            "Merck Research ",
            "Merck Research Laboratories",
            "Research ",
            "Research Laboratories",
            "Laboratories",
            "Agenda",
            "Consultants ",
            "Consultants Introductions",
            "Introductions",
            "New ",
            "New Allergy ",
            "New Allergy Treatments ",
            "New Allergy Treatments Are ",
            "New Allergy Treatments Are Needed",
            "Allergy ",
            "Allergy Treatments ",
            "Allergy Treatments Are ",
            "Allergy Treatments Are Needed",
            "Treatments ",
            "Treatments Are ",
            "Treatments Are Needed",
            "Are ",
            "Are Needed",
            "Needed",
            "Pharmacotherapies ",
            "Pharmacotherapies do ",
            "Pharmacotherapies do not ",
            "Pharmacotherapies do not serve ",
            "Pharmacotherapies do not serve all ",
            "Pharmacotherapies do not serve all patients ",
            "Pharmacotherapies do not serve all patients well ",
            "do ",
            "do not ",
            "do not serve ",
            "do not serve all ",
            "do not serve all patients ",
            "do not serve all patients well ",
            "do not serve all patients well Allergen ",
            "not ",
            "not serve ",
            "not serve all ",
            "not serve all patients ",
            "not serve all patients well ",
            "not serve all patients well Allergen ",
            "not serve all patients well Allergen immunotherapy ",
            "serve ",
            "serve all ",
            "serve all patients ",
            "serve all patients well ",
            "serve all patients well Allergen ",
            "serve all patients well Allergen immunotherapy ",
            "serve all patients well Allergen immunotherapy has ",
            "all ",
            "all patients ",
            "all patients well ",
            "all patients well Allergen ",
            "all patients well Allergen immunotherapy ",
            "all patients well Allergen immunotherapy has ",
            "all patients well Allergen immunotherapy has the ",
            "patients ",
            "patients well ",
            "patients well Allergen ",
            "patients well Allergen immunotherapy ",
            "patients well Allergen immunotherapy has ",
            "patients well Allergen immunotherapy has the ",
            "patients well Allergen immunotherapy has the potential ",
            "well ",
            "well Allergen ",
            "well Allergen immunotherapy ",
            "well Allergen immunotherapy has ",
            "well Allergen immunotherapy has the ",
            "well Allergen immunotherapy has the potential ",
            "well Allergen immunotherapy has the potential for ",
            "Allergen ",
            "Allergen immunotherapy ",
            "Allergen immunotherapy has ",
            "Allergen immunotherapy has the ",
            "Allergen immunotherapy has the potential ",
            "Allergen immunotherapy has the potential for ",
            "Allergen immunotherapy has the potential for a ",
            "immunotherapy ",
            "immunotherapy has ",
            "immunotherapy has the ",
            "immunotherapy has the potential ",
            "immunotherapy has the potential for ",
            "immunotherapy has the potential for a ",
            "immunotherapy has the potential for a durable ",
            "has ",
            "has the ",
            "has the potential ",
            "has the potential for ",
            "has the potential for a ",
            "has the potential for a durable ",
            "has the potential for a durable treatment ",
            "the ",
            "the potential ",
            "the potential for ",
            "the potential for a ",
            "the potential for a durable ",
            "the potential for a durable treatment ",
            "the potential for a durable treatment effect ",
            "potential ",
            "potential for ",
            "potential for a ",
            "potential for a durable ",
            "potential for a durable treatment ",
            "potential for a durable treatment effect ",
            "potential for a durable treatment effect even ",
            "for ",
            "for a ",
            "for a durable ",
            "for a durable treatment ",
            "for a durable treatment effect ",
            "for a durable treatment effect even ",
            "for a durable treatment effect even after ",
            "a ",
            "a durable ",
            "a durable treatment ",
            "a durable treatment effect ",
            "a durable treatment effect even ",
            "a durable treatment effect even after ",
            "a durable treatment effect even after treatment ",
            "durable ",
            "durable treatment ",
            "durable treatment effect ",
            "durable treatment effect even ",
            "durable treatment effect even after ",
            "durable treatment effect even after treatment ",
            "durable treatment effect even after treatment is ",
            "treatment ",
            "treatment effect ",
            "treatment effect even ",
            "treatment effect even after ",
            "treatment effect even after treatment ",
            "treatment effect even after treatment is ",
            "treatment effect even after treatment is discontinued ",
            "effect ",
            "effect even ",
            "effect even after ",
            "effect even after treatment ",
            "effect even after treatment is ",
            "effect even after treatment is discontinued ",
            "effect even after treatment is discontinued Main ",
            "even ",
            "even after ",
            "even after treatment ",
            "even after treatment is ",
            "even after treatment is discontinued ",
            "even after treatment is discontinued Main ",
            "even after treatment is discontinued Main form ",
            "after ",
            "after treatment ",
            "after treatment is ",
            "after treatment is discontinued ",
            "after treatment is discontinued Main ",
            "after treatment is discontinued Main form ",
            "after treatment is discontinued Main form of ",
            "treatment ",
            "treatment is ",
            "treatment is discontinued ",
            "treatment is discontinued Main ",
            "treatment is discontinued Main form ",
            "treatment is discontinued Main form of ",
            "treatment is discontinued Main form of administration ",
            "is ",
            "is discontinued ",
            "is discontinued Main ",
            "is discontinued Main form ",
            "is discontinued Main form of ",
            "is discontinued Main form of administration ",
            "is discontinued Main form of administration is ",
            "discontinued ",
            "discontinued Main ",
            "discontinued Main form ",
            "discontinued Main form of ",
            "discontinued Main form of administration ",
            "discontinued Main form of administration is ",
            "discontinued Main form of administration is subcutaneous ",
            "Main ",
            "Main form ",
            "Main form of ",
            "Main form of administration ",
            "Main form of administration is ",
            "Main form of administration is subcutaneous ",
            "Main form of administration is subcutaneous Requires ",
            "form ",
            "form of ",
            "form of administration ",
            "form of administration is ",
            "form of administration is subcutaneous ",
            "form of administration is subcutaneous Requires ",
            "form of administration is subcutaneous Requires regular ",
            "of ",
            "of administration ",
            "of administration is ",
            "of administration is subcutaneous ",
            "of administration is subcutaneous Requires ",
            "of administration is subcutaneous Requires regular ",
            "of administration is subcutaneous Requires regular office ",
            "administration ",
            "administration is ",
            "administration is subcutaneous ",
            "administration is subcutaneous Requires ",
            "administration is subcutaneous Requires regular ",
            "administration is subcutaneous Requires regular office ",
            "administration is subcutaneous Requires regular office visits ",
            "is ",
            "is subcutaneous ",
            "is subcutaneous Requires ",
            "is subcutaneous Requires regular ",
            "is subcutaneous Requires regular office ",
            "is subcutaneous Requires regular office visits ",
            "is subcutaneous Requires regular office visits to ",
            "subcutaneous ",
            "subcutaneous Requires ",
            "subcutaneous Requires regular ",
            "subcutaneous Requires regular office ",
            "subcutaneous Requires regular office visits ",
            "subcutaneous Requires regular office visits to ",
            "subcutaneous Requires regular office visits to receive ",
            "Requires ",
            "Requires regular ",
            "Requires regular office ",
            "Requires regular office visits ",
            "Requires regular office visits to ",
            "Requires regular office visits to receive ",
            "Requires regular office visits to receive injections ",
            "regular ",
            "regular office ",
            "regular office visits ",
            "regular office visits to ",
            "regular office visits to receive ",
            "regular office visits to receive injections ",
            "regular office visits to receive injections A ",
            "office ",
            "office visits ",
            "office visits to ",
            "office visits to receive ",
            "office visits to receive injections ",
            "office visits to receive injections A ",
            "office visits to receive injections A simple ",
            "visits ",
            "visits to ",
            "visits to receive ",
            "visits to receive injections ",
            "visits to receive injections A ",
            "visits to receive injections A simple ",
            "visits to receive injections A simple well ",
            "to ",
            "to receive ",
            "to receive injections ",
            "to receive injections A ",
            "to receive injections A simple ",
            "to receive injections A simple well ",
            "to receive injections A simple well tolerated ",
            "receive ",
            "receive injections ",
            "receive injections A ",
            "receive injections A simple ",
            "receive injections A simple well ",
            "receive injections A simple well tolerated ",
            "receive injections A simple well tolerated and ",
            "injections ",
            "injections A ",
            "injections A simple ",
            "injections A simple well ",
            "injections A simple well tolerated ",
            "injections A simple well tolerated and ",
            "injections A simple well tolerated and self ",
            "A ",
            "A simple ",
            "A simple well ",
            "A simple well tolerated ",
            "A simple well tolerated and ",
            "A simple well tolerated and self ",
            "A simple well tolerated and self administered ",
            "simple ",
            "simple well ",
            "simple well tolerated ",
            "simple well tolerated and ",
            "simple well tolerated and self ",
            "simple well tolerated and self administered ",
            "simple well tolerated and self administered tablet ",
            "well ",
            "well tolerated ",
            "well tolerated and ",
            "well tolerated and self ",
            "well tolerated and self administered ",
            "well tolerated and self administered tablet ",
            "well tolerated and self administered tablet immunotherapy ",
            "tolerated ",
            "tolerated and ",
            "tolerated and self ",
            "tolerated and self administered ",
            "tolerated and self administered tablet ",
            "tolerated and self administered tablet immunotherapy ",
            "tolerated and self administered tablet immunotherapy may ",
            "and ",
            "and self ",
            "and self administered ",
            "and self administered tablet ",
            "and self administered tablet immunotherapy ",
            "and self administered tablet immunotherapy may ",
            "and self administered tablet immunotherapy may benefit ",
            "self ",
            "self administered ",
            "self administered tablet ",
            "self administered tablet immunotherapy ",
            "self administered tablet immunotherapy may ",
            "self administered tablet immunotherapy may benefit ",
            "self administered tablet immunotherapy may benefit patients ",
            "administered ",
            "administered tablet ",
            "administered tablet immunotherapy ",
            "administered tablet immunotherapy may ",
            "administered tablet immunotherapy may benefit ",
            "administered tablet immunotherapy may benefit patients ",
            "administered tablet immunotherapy may benefit patients for ",
            "tablet ",
            "tablet immunotherapy ",
            "tablet immunotherapy may ",
            "tablet immunotherapy may benefit ",
            "tablet immunotherapy may benefit patients ",
            "tablet immunotherapy may benefit patients for ",
            "tablet immunotherapy may benefit patients for whom ",
            "immunotherapy ",
            "immunotherapy may ",
            "immunotherapy may benefit ",
            "immunotherapy may benefit patients ",
            "immunotherapy may benefit patients for ",
            "immunotherapy may benefit patients for whom ",
            "immunotherapy may benefit patients for whom immunotherapy ",
            "may ",
            "may benefit ",
            "may benefit patients ",
            "may benefit patients for ",
            "may benefit patients for whom ",
            "may benefit patients for whom immunotherapy ",
            "may benefit patients for whom immunotherapy is ",
            "benefit ",
            "benefit patients ",
            "benefit patients for ",
            "benefit patients for whom ",
            "benefit patients for whom immunotherapy ",
            "benefit patients for whom immunotherapy is ",
            "benefit patients for whom immunotherapy is indicated ",
            "patients ",
            "patients for ",
            "patients for whom ",
            "patients for whom immunotherapy ",
            "patients for whom immunotherapy is ",
            "patients for whom immunotherapy is indicated ",
            "for ",
            "for whom ",
            "for whom immunotherapy ",
            "for whom immunotherapy is ",
            "for whom immunotherapy is indicated ",
            "whom ",
            "whom immunotherapy ",
            "whom immunotherapy is ",
            "whom immunotherapy is indicated ",
            "immunotherapy ",
            "immunotherapy is ",
            "immunotherapy is indicated ",
            "is ",
            "is indicated ",
            "indicated ",
            "    ",
            "    WAO ",
            "    WAO Position ",
            "    WAO Position Paper ",
            "WAO ",
            "WAO Position ",
            "WAO Position Paper ",
            "Position ",
            "Position Paper ",
            "Paper ",
            "Introduction ",
            "Introduction to ",
            "Introduction to MK   ",
            "to ",
            "to MK   ",
            "MK   ",
            "New ",
            "New delivery ",
            "New delivery and ",
            "New delivery and formulation ",
            "New delivery and formulation for ",
            "New delivery and formulation for allergen ",
            "New delivery and formulation for allergen immunotherapy ",
            "delivery ",
            "delivery and ",
            "delivery and formulation ",
            "delivery and formulation for ",
            "delivery and formulation for allergen ",
            "delivery and formulation for allergen immunotherapy ",
            "delivery and formulation for allergen immunotherapy that ",
            "and ",
            "and formulation ",
            "and formulation for ",
            "and formulation for allergen ",
            "and formulation for allergen immunotherapy ",
            "and formulation for allergen immunotherapy that ",
            "and formulation for allergen immunotherapy that addresses ",
            "formulation ",
            "formulation for ",
            "formulation for allergen ",
            "formulation for allergen immunotherapy ",
            "formulation for allergen immunotherapy that ",
            "formulation for allergen immunotherapy that addresses ",
            "formulation for allergen immunotherapy that addresses medical ",
            "for ",
            "for allergen ",
            "for allergen immunotherapy ",
            "for allergen immunotherapy that ",
            "for allergen immunotherapy that addresses ",
            "for allergen immunotherapy that addresses medical ",
            "for allergen immunotherapy that addresses medical needs ",
            "allergen ",
            "allergen immunotherapy ",
            "allergen immunotherapy that ",
            "allergen immunotherapy that addresses ",
            "allergen immunotherapy that addresses medical ",
            "allergen immunotherapy that addresses medical needs ",
            "allergen immunotherapy that addresses medical needs of ",
            "immunotherapy ",
            "immunotherapy that ",
            "immunotherapy that addresses ",
            "immunotherapy that addresses medical ",
            "immunotherapy that addresses medical needs ",
            "immunotherapy that addresses medical needs of ",
            "immunotherapy that addresses medical needs of under ",
            "that ",
            "that addresses ",
            "that addresses medical ",
            "that addresses medical needs ",
            "that addresses medical needs of ",
            "that addresses medical needs of under ",
            "that addresses medical needs of under served ",
            "addresses ",
            "addresses medical ",
            "addresses medical needs ",
            "addresses medical needs of ",
            "addresses medical needs of under ",
            "addresses medical needs of under served ",
            "addresses medical needs of under served grass ",
            "medical ",
            "medical needs ",
            "medical needs of ",
            "medical needs of under ",
            "medical needs of under served ",
            "medical needs of under served grass ",
            "medical needs of under served grass allergic ",
            "needs ",
            "needs of ",
            "needs of under ",
            "needs of under served ",
            "needs of under served grass ",
            "needs of under served grass allergic ",
            "needs of under served grass allergic patients ",
            "of ",
            "of under ",
            "of under served ",
            "of under served grass ",
            "of under served grass allergic ",
            "of under served grass allergic patients ",
            "of under served grass allergic patients Additional ",
            "under ",
            "under served ",
            "under served grass ",
            "under served grass allergic ",
            "under served grass allergic patients ",
            "under served grass allergic patients Additional ",
            "under served grass allergic patients Additional option ",
            "served ",
            "served grass ",
            "served grass allergic ",
            "served grass allergic patients ",
            "served grass allergic patients Additional ",
            "served grass allergic patients Additional option ",
            "served grass allergic patients Additional option for ",
            "grass ",
            "grass allergic ",
            "grass allergic patients ",
            "grass allergic patients Additional ",
            "grass allergic patients Additional option ",
            "grass allergic patients Additional option for ",
            "grass allergic patients Additional option for patients ",
            "allergic ",
            "allergic patients ",
            "allergic patients Additional ",
            "allergic patients Additional option ",
            "allergic patients Additional option for ",
            "allergic patients Additional option for patients ",
            "allergic patients Additional option for patients who ",
            "patients ",
            "patients Additional ",
            "patients Additional option ",
            "patients Additional option for ",
            "patients Additional option for patients ",
            "patients Additional option for patients who ",
            "patients Additional option for patients who are ",
            "Additional ",
            "Additional option ",
            "Additional option for ",
            "Additional option for patients ",
            "Additional option for patients who ",
            "Additional option for patients who are ",
            "Additional option for patients who are candidates ",
            "option ",
            "option for ",
            "option for patients ",
            "option for patients who ",
            "option for patients who are ",
            "option for patients who are candidates ",
            "option for patients who are candidates for ",
            "for ",
            "for patients ",
            "for patients who ",
            "for patients who are ",
            "for patients who are candidates ",
            "for patients who are candidates for ",
            "for patients who are candidates for allergen ",
            "patients ",
            "patients who ",
            "patients who are ",
            "patients who are candidates ",
            "patients who are candidates for ",
            "patients who are candidates for allergen ",
            "patients who are candidates for allergen immunotherapy ",
            "who ",
            "who are ",
            "who are candidates ",
            "who are candidates for ",
            "who are candidates for allergen ",
            "who are candidates for allergen immunotherapy ",
            "who are candidates for allergen immunotherapy Timothy ",
            "are ",
            "are candidates ",
            "are candidates for ",
            "are candidates for allergen ",
            "are candidates for allergen immunotherapy ",
            "are candidates for allergen immunotherapy Timothy ",
            "are candidates for allergen immunotherapy Timothy grass ",
            "candidates ",
            "candidates for ",
            "candidates for allergen ",
            "candidates for allergen immunotherapy ",
            "candidates for allergen immunotherapy Timothy ",
            "candidates for allergen immunotherapy Timothy grass ",
            "candidates for allergen immunotherapy Timothy grass pollen ",
            "for ",
            "for allergen ",
            "for allergen immunotherapy ",
            "for allergen immunotherapy Timothy ",
            "for allergen immunotherapy Timothy grass ",
            "for allergen immunotherapy Timothy grass pollen ",
            "for allergen immunotherapy Timothy grass pollen allergen ",
            "allergen ",
            "allergen immunotherapy ",
            "allergen immunotherapy Timothy ",
            "allergen immunotherapy Timothy grass ",
            "allergen immunotherapy Timothy grass pollen ",
            "allergen immunotherapy Timothy grass pollen allergen ",
            "allergen immunotherapy Timothy grass pollen allergen extract ",
            "immunotherapy ",
            "immunotherapy Timothy ",
            "immunotherapy Timothy grass ",
            "immunotherapy Timothy grass pollen ",
            "immunotherapy Timothy grass pollen allergen ",
            "immunotherapy Timothy grass pollen allergen extract ",
            "immunotherapy Timothy grass pollen allergen extract in ",
            "Timothy ",
            "Timothy grass ",
            "Timothy grass pollen ",
            "Timothy grass pollen allergen ",
            "Timothy grass pollen allergen extract ",
            "Timothy grass pollen allergen extract in ",
            "Timothy grass pollen allergen extract in a ",
            "grass ",
            "grass pollen ",
            "grass pollen allergen ",
            "grass pollen allergen extract ",
            "grass pollen allergen extract in ",
            "grass pollen allergen extract in a ",
            "grass pollen allergen extract in a freeze ",
            "pollen ",
            "pollen allergen ",
            "pollen allergen extract ",
            "pollen allergen extract in ",
            "pollen allergen extract in a ",
            "pollen allergen extract in a freeze ",
            "pollen allergen extract in a freeze dried ",
            "allergen ",
            "allergen extract ",
            "allergen extract in ",
            "allergen extract in a ",
            "allergen extract in a freeze ",
            "allergen extract in a freeze dried ",
            "allergen extract in a freeze dried tablet ",
            "extract ",
            "extract in ",
            "extract in a ",
            "extract in a freeze ",
            "extract in a freeze dried ",
            "extract in a freeze dried tablet ",
            "extract in a freeze dried tablet form ",
            "in ",
            "in a ",
            "in a freeze ",
            "in a freeze dried ",
            "in a freeze dried tablet ",
            "in a freeze dried tablet form ",
            "in a freeze dried tablet form for ",
            "a ",
            "a freeze ",
            "a freeze dried ",
            "a freeze dried tablet ",
            "a freeze dried tablet form ",
            "a freeze dried tablet form for ",
            "a freeze dried tablet form for sublingual ",
            "freeze ",
            "freeze dried ",
            "freeze dried tablet ",
            "freeze dried tablet form ",
            "freeze dried tablet form for ",
            "freeze dried tablet form for sublingual ",
            "freeze dried tablet form for sublingual administration ",
            "dried ",
            "dried tablet ",
            "dried tablet form ",
            "dried tablet form for ",
            "dried tablet form for sublingual ",
            "dried tablet form for sublingual administration ",
            "dried tablet form for sublingual administration Drives ",
            "tablet ",
            "tablet form ",
            "tablet form for ",
            "tablet form for sublingual ",
            "tablet form for sublingual administration ",
            "tablet form for sublingual administration Drives ",
            "tablet form for sublingual administration Drives development ",
            "form ",
            "form for ",
            "form for sublingual ",
            "form for sublingual administration ",
            "form for sublingual administration Drives ",
            "form for sublingual administration Drives development ",
            "form for sublingual administration Drives development of ",
            "for ",
            "for sublingual ",
            "for sublingual administration ",
            "for sublingual administration Drives ",
            "for sublingual administration Drives development ",
            "for sublingual administration Drives development of ",
            "for sublingual administration Drives development of specific ",
            "sublingual ",
            "sublingual administration ",
            "sublingual administration Drives ",
            "sublingual administration Drives development ",
            "sublingual administration Drives development of ",
            "sublingual administration Drives development of specific ",
            "sublingual administration Drives development of specific allergen ",
            "administration ",
            "administration Drives ",
            "administration Drives development ",
            "administration Drives development of ",
            "administration Drives development of specific ",
            "administration Drives development of specific allergen ",
            "administration Drives development of specific allergen immune ",
            "Drives ",
            "Drives development ",
            "Drives development of ",
            "Drives development of specific ",
            "Drives development of specific allergen ",
            "Drives development of specific allergen immune ",
            "Drives development of specific allergen immune tolerance ",
            "development ",
            "development of ",
            "development of specific ",
            "development of specific allergen ",
            "development of specific allergen immune ",
            "development of specific allergen immune tolerance ",
            "development of specific allergen immune tolerance via ",
            "of ",
            "of specific ",
            "of specific allergen ",
            "of specific allergen immune ",
            "of specific allergen immune tolerance ",
            "of specific allergen immune tolerance via ",
            "of specific allergen immune tolerance via repeated ",
            "specific ",
            "specific allergen ",
            "specific allergen immune ",
            "specific allergen immune tolerance ",
            "specific allergen immune tolerance via ",
            "specific allergen immune tolerance via repeated ",
            "specific allergen immune tolerance via repeated exposure",
            "allergen ",
            "allergen immune ",
            "allergen immune tolerance ",
            "allergen immune tolerance via ",
            "allergen immune tolerance via repeated ",
            "allergen immune tolerance via repeated exposure",
            "immune ",
            "immune tolerance ",
            "immune tolerance via ",
            "immune tolerance via repeated ",
            "immune tolerance via repeated exposure",
            "tolerance ",
            "tolerance via ",
            "tolerance via repeated ",
            "tolerance via repeated exposure",
            "via ",
            "via repeated ",
            "via repeated exposure",
            "repeated ",
            "repeated exposure",
            "exposure",
            "MK   ",
            "MK   Development",
            "Development",
            "Clinical ",
            "Clinical trials ",
            "Clinical trials designed ",
            "Clinical trials designed to ",
            "Clinical trials designed to demonstrate  ",
            "Clinical trials designed to demonstrate  Treatment ",
            "Clinical trials designed to demonstrate  Treatment of ",
            "trials ",
            "trials designed ",
            "trials designed to ",
            "trials designed to demonstrate  ",
            "trials designed to demonstrate  Treatment ",
            "trials designed to demonstrate  Treatment of ",
            "trials designed to demonstrate  Treatment of allergic ",
            "designed ",
            "designed to ",
            "designed to demonstrate  ",
            "designed to demonstrate  Treatment ",
            "designed to demonstrate  Treatment of ",
            "designed to demonstrate  Treatment of allergic ",
            "designed to demonstrate  Treatment of allergic symptoms ",
            "to ",
            "to demonstrate  ",
            "to demonstrate  Treatment ",
            "to demonstrate  Treatment of ",
            "to demonstrate  Treatment of allergic ",
            "to demonstrate  Treatment of allergic symptoms ",
            "to demonstrate  Treatment of allergic symptoms Sustained ",
            "demonstrate  ",
            "demonstrate  Treatment ",
            "demonstrate  Treatment of ",
            "demonstrate  Treatment of allergic ",
            "demonstrate  Treatment of allergic symptoms ",
            "demonstrate  Treatment of allergic symptoms Sustained ",
            "demonstrate  Treatment of allergic symptoms Sustained clinical ",
            "Treatment ",
            "Treatment of ",
            "Treatment of allergic ",
            "Treatment of allergic symptoms ",
            "Treatment of allergic symptoms Sustained ",
            "Treatment of allergic symptoms Sustained clinical ",
            "Treatment of allergic symptoms Sustained clinical effect ",
            "of ",
            "of allergic ",
            "of allergic symptoms ",
            "of allergic symptoms Sustained ",
            "of allergic symptoms Sustained clinical ",
            "of allergic symptoms Sustained clinical effect ",
            "of allergic symptoms Sustained clinical effect Persistent ",
            "allergic ",
            "allergic symptoms ",
            "allergic symptoms Sustained ",
            "allergic symptoms Sustained clinical ",
            "allergic symptoms Sustained clinical effect ",
            "allergic symptoms Sustained clinical effect Persistent ",
            "allergic symptoms Sustained clinical effect Persistent clinically ",
            "symptoms ",
            "symptoms Sustained ",
            "symptoms Sustained clinical ",
            "symptoms Sustained clinical effect ",
            "symptoms Sustained clinical effect Persistent ",
            "symptoms Sustained clinical effect Persistent clinically ",
            "symptoms Sustained clinical effect Persistent clinically relevant ",
            "Sustained ",
            "Sustained clinical ",
            "Sustained clinical effect ",
            "Sustained clinical effect Persistent ",
            "Sustained clinical effect Persistent clinically ",
            "Sustained clinical effect Persistent clinically relevant ",
            "Sustained clinical effect Persistent clinically relevant effect ",
            "clinical ",
            "clinical effect ",
            "clinical effect Persistent ",
            "clinical effect Persistent clinically ",
            "clinical effect Persistent clinically relevant ",
            "clinical effect Persistent clinically relevant effect ",
            "clinical effect Persistent clinically relevant effect in ",
            "effect ",
            "effect Persistent ",
            "effect Persistent clinically ",
            "effect Persistent clinically relevant ",
            "effect Persistent clinically relevant effect ",
            "effect Persistent clinically relevant effect in ",
            "effect Persistent clinically relevant effect in post ",
            "Persistent ",
            "Persistent clinically ",
            "Persistent clinically relevant ",
            "Persistent clinically relevant effect ",
            "Persistent clinically relevant effect in ",
            "Persistent clinically relevant effect in post ",
            "Persistent clinically relevant effect in post treatment ",
            "clinically ",
            "clinically relevant ",
            "clinically relevant effect ",
            "clinically relevant effect in ",
            "clinically relevant effect in post ",
            "clinically relevant effect in post treatment ",
            "clinically relevant effect in post treatment years ",
            "relevant ",
            "relevant effect ",
            "relevant effect in ",
            "relevant effect in post ",
            "relevant effect in post treatment ",
            "relevant effect in post treatment years ",
            "relevant effect in post treatment years Disease ",
            "effect ",
            "effect in ",
            "effect in post ",
            "effect in post treatment ",
            "effect in post treatment years ",
            "effect in post treatment years Disease ",
            "effect in post treatment years Disease Modifying ",
            "in ",
            "in post ",
            "in post treatment ",
            "in post treatment years ",
            "in post treatment years Disease ",
            "in post treatment years Disease Modifying ",
            "in post treatment years Disease Modifying Treatment ",
            "post ",
            "post treatment ",
            "post treatment years ",
            "post treatment years Disease ",
            "post treatment years Disease Modifying ",
            "post treatment years Disease Modifying Treatment ",
            "post treatment years Disease Modifying Treatment designed ",
            "treatment ",
            "treatment years ",
            "treatment years Disease ",
            "treatment years Disease Modifying ",
            "treatment years Disease Modifying Treatment ",
            "treatment years Disease Modifying Treatment designed ",
            "treatment years Disease Modifying Treatment designed with ",
            "years ",
            "years Disease ",
            "years Disease Modifying ",
            "years Disease Modifying Treatment ",
            "years Disease Modifying Treatment designed ",
            "years Disease Modifying Treatment designed with ",
            "years Disease Modifying Treatment designed with no ",
            "Disease ",
            "Disease Modifying ",
            "Disease Modifying Treatment ",
            "Disease Modifying Treatment designed ",
            "Disease Modifying Treatment designed with ",
            "Disease Modifying Treatment designed with no ",
            "Disease Modifying Treatment designed with no up ",
            "Modifying ",
            "Modifying Treatment ",
            "Modifying Treatment designed ",
            "Modifying Treatment designed with ",
            "Modifying Treatment designed with no ",
            "Modifying Treatment designed with no up ",
            "Modifying Treatment designed with no up or ",
            "Treatment ",
            "Treatment designed ",
            "Treatment designed with ",
            "Treatment designed with no ",
            "Treatment designed with no up ",
            "Treatment designed with no up or ",
            "Treatment designed with no up or down ",
            "designed ",
            "designed with ",
            "designed with no ",
            "designed with no up ",
            "designed with no up or ",
            "designed with no up or down ",
            "designed with no up or down titration ",
            "with ",
            "with no ",
            "with no up ",
            "with no up or ",
            "with no up or down ",
            "with no up or down titration ",
            "with no up or down titration Treat ",
            "no ",
            "no up ",
            "no up or ",
            "no up or down ",
            "no up or down titration ",
            "no up or down titration Treat ",
            "no up or down titration Treat grass ",
            "up ",
            "up or ",
            "up or down ",
            "up or down titration ",
            "up or down titration Treat ",
            "up or down titration Treat grass ",
            "up or down titration Treat grass allergies ",
            "or ",
            "or down ",
            "or down titration ",
            "or down titration Treat ",
            "or down titration Treat grass ",
            "or down titration Treat grass allergies ",
            "or down titration Treat grass allergies by ",
            "down ",
            "down titration ",
            "down titration Treat ",
            "down titration Treat grass ",
            "down titration Treat grass allergies ",
            "down titration Treat grass allergies by ",
            "down titration Treat grass allergies by dosing ",
            "titration ",
            "titration Treat ",
            "titration Treat grass ",
            "titration Treat grass allergies ",
            "titration Treat grass allergies by ",
            "titration Treat grass allergies by dosing ",
            "titration Treat grass allergies by dosing with ",
            "Treat ",
            "Treat grass ",
            "Treat grass allergies ",
            "Treat grass allergies by ",
            "Treat grass allergies by dosing ",
            "Treat grass allergies by dosing with ",
            "Treat grass allergies by dosing with Timothy ",
            "grass ",
            "grass allergies ",
            "grass allergies by ",
            "grass allergies by dosing ",
            "grass allergies by dosing with ",
            "grass allergies by dosing with Timothy ",
            "grass allergies by dosing with Timothy grass ",
            "allergies ",
            "allergies by ",
            "allergies by dosing ",
            "allergies by dosing with ",
            "allergies by dosing with Timothy ",
            "allergies by dosing with Timothy grass ",
            "allergies by dosing with Timothy grass allergen",
            "by ",
            "by dosing ",
            "by dosing with ",
            "by dosing with Timothy ",
            "by dosing with Timothy grass ",
            "by dosing with Timothy grass allergen",
            "dosing ",
            "dosing with ",
            "dosing with Timothy ",
            "dosing with Timothy grass ",
            "dosing with Timothy grass allergen",
            "with ",
            "with Timothy ",
            "with Timothy grass ",
            "with Timothy grass allergen",
            "Timothy ",
            "Timothy grass ",
            "Timothy grass allergen",
            "grass ",
            "grass allergen",
            "allergen",
            "Based ",
            "Based on ",
            "Based on Guideline ",
            "Based on Guideline on ",
            "Based on Guideline on the ",
            "Based on Guideline on the Clinical ",
            "Based on Guideline on the Clinical Development ",
            "on ",
            "on Guideline ",
            "on Guideline on ",
            "on Guideline on the ",
            "on Guideline on the Clinical ",
            "on Guideline on the Clinical Development ",
            "on Guideline on the Clinical Development of ",
            "Guideline ",
            "Guideline on ",
            "Guideline on the ",
            "Guideline on the Clinical ",
            "Guideline on the Clinical Development ",
            "Guideline on the Clinical Development of ",
            "Guideline on the Clinical Development of Products ",
            "on ",
            "on the ",
            "on the Clinical ",
            "on the Clinical Development ",
            "on the Clinical Development of ",
            "on the Clinical Development of Products ",
            "on the Clinical Development of Products for ",
            "the ",
            "the Clinical ",
            "the Clinical Development ",
            "the Clinical Development of ",
            "the Clinical Development of Products ",
            "the Clinical Development of Products for ",
            "the Clinical Development of Products for Specific ",
            "Clinical ",
            "Clinical Development ",
            "Clinical Development of ",
            "Clinical Development of Products ",
            "Clinical Development of Products for ",
            "Clinical Development of Products for Specific ",
            "Clinical Development of Products for Specific Immunotherapy ",
            "Development ",
            "Development of ",
            "Development of Products ",
            "Development of Products for ",
            "Development of Products for Specific ",
            "Development of Products for Specific Immunotherapy ",
            "Development of Products for Specific Immunotherapy for ",
            "of ",
            "of Products ",
            "of Products for ",
            "of Products for Specific ",
            "of Products for Specific Immunotherapy ",
            "of Products for Specific Immunotherapy for ",
            "of Products for Specific Immunotherapy for the ",
            "Products ",
            "Products for ",
            "Products for Specific ",
            "Products for Specific Immunotherapy ",
            "Products for Specific Immunotherapy for ",
            "Products for Specific Immunotherapy for the ",
            "Products for Specific Immunotherapy for the Treatment ",
            "for ",
            "for Specific ",
            "for Specific Immunotherapy ",
            "for Specific Immunotherapy for ",
            "for Specific Immunotherapy for the ",
            "for Specific Immunotherapy for the Treatment ",
            "for Specific Immunotherapy for the Treatment of ",
            "Specific ",
            "Specific Immunotherapy ",
            "Specific Immunotherapy for ",
            "Specific"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(21, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab1
            // 
            this.tab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1.Controls.Add(this.pgSlideResults);
            this.tab1.Controls.Add(this.DataGridResults);
            this.tab1.ItemSize = new System.Drawing.Size(110, 18);
            this.tab1.Location = new System.Drawing.Point(8, 109);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1104, 621);
            this.tab1.TabIndex = 3;
            this.tab1.TabIndexChanged += new System.EventHandler(this.tab1_TabIndexChanged);
            // 
            // pgSlideResults
            // 
            this.pgSlideResults.Controls.Add(this.webBrowser1);
            this.pgSlideResults.Location = new System.Drawing.Point(4, 4);
            this.pgSlideResults.Name = "pgSlideResults";
            this.pgSlideResults.Padding = new System.Windows.Forms.Padding(3);
            this.pgSlideResults.Size = new System.Drawing.Size(1096, 595);
            this.pgSlideResults.TabIndex = 1;
            this.pgSlideResults.Text = "Slide Search Results";
            this.pgSlideResults.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1090, 589);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // DataGridResults
            // 
            this.DataGridResults.Controls.Add(this.dataGridView1);
            this.DataGridResults.Location = new System.Drawing.Point(4, 4);
            this.DataGridResults.Name = "DataGridResults";
            this.DataGridResults.Padding = new System.Windows.Forms.Padding(3);
            this.DataGridResults.Size = new System.Drawing.Size(1096, 595);
            this.DataGridResults.TabIndex = 0;
            this.DataGridResults.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(991, 70);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(113, 23);
            this.btn12.TabIndex = 7;
            this.btn12.Text = "12 By 12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(872, 70);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(113, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6 By 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(753, 70);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(113, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3 By 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0 results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Format results:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClearSearch);
            this.panel1.Controls.Add(this.lbxRelevant);
            this.panel1.Controls.Add(this.lbxAltSearchTerms);
            this.panel1.Controls.Add(this.lblSearchMode);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblRelevant);
            this.panel1.Controls.Add(this.lblDidYouMean);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1146, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 387);
            this.panel1.TabIndex = 11;
            // 
            // lblClearSearch
            // 
            this.lblClearSearch.AutoSize = true;
            this.lblClearSearch.BackColor = System.Drawing.Color.White;
            this.lblClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearSearch.ForeColor = System.Drawing.Color.Red;
            this.lblClearSearch.Location = new System.Drawing.Point(246, 38);
            this.lblClearSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblClearSearch.Name = "lblClearSearch";
            this.lblClearSearch.Size = new System.Drawing.Size(13, 13);
            this.lblClearSearch.TabIndex = 7;
            this.lblClearSearch.Text = "x";
            this.lblClearSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblClearSearch.Click += new System.EventHandler(this.lblClearSearch_Click);
            // 
            // lbxAltSearchTerms
            // 
            this.lbxAltSearchTerms.FormattingEnabled = true;
            this.lbxAltSearchTerms.Location = new System.Drawing.Point(25, 109);
            this.lbxAltSearchTerms.Name = "lbxAltSearchTerms";
            this.lbxAltSearchTerms.Size = new System.Drawing.Size(273, 108);
            this.lbxAltSearchTerms.TabIndex = 6;
            this.lbxAltSearchTerms.Click += new System.EventHandler(this.lbxAltSearchTerms_Click);
            this.lbxAltSearchTerms.SelectedIndexChanged += new System.EventHandler(this.lbxAltSearchTerms_SelectedIndexChanged);
            // 
            // lblSearchMode
            // 
            this.lblSearchMode.AutoSize = true;
            this.lblSearchMode.Location = new System.Drawing.Point(21, 62);
            this.lblSearchMode.Name = "lblSearchMode";
            this.lblSearchMode.Size = new System.Drawing.Size(103, 13);
            this.lblSearchMode.TabIndex = 5;
            this.lblSearchMode.Text = "Search Mode: Word";
            this.lblSearchMode.Click += new System.EventHandler(this.lblSearchMode_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(263, 31);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(38, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 368);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 16);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // lblDidYouMean
            // 
            this.lblDidYouMean.AutoSize = true;
            this.lblDidYouMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDidYouMean.Location = new System.Drawing.Point(24, 86);
            this.lblDidYouMean.Margin = new System.Windows.Forms.Padding(0);
            this.lblDidYouMean.Name = "lblDidYouMean";
            this.lblDidYouMean.Size = new System.Drawing.Size(133, 20);
            this.lblDidYouMean.TabIndex = 2;
            this.lblDidYouMean.Text = "Did you mean...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current Search";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Keyword(s)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1146, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 218);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Number Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tags";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Filter by:";
            // 
            // demoFDAProposalDataSet1
            // 
            this.demoFDAProposalDataSet1.DataSetName = "DemoFDAProposalDataSet";
            this.demoFDAProposalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(435, 42);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(68, 20);
            this.lblSortBy.TabIndex = 13;
            this.lblSortBy.Text = "Sort By";
            // 
            // lblSortBySlideNumber
            // 
            this.lblSortBySlideNumber.AutoSize = true;
            this.lblSortBySlideNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBySlideNumber.Location = new System.Drawing.Point(436, 70);
            this.lblSortBySlideNumber.Name = "lblSortBySlideNumber";
            this.lblSortBySlideNumber.Size = new System.Drawing.Size(82, 13);
            this.lblSortBySlideNumber.TabIndex = 14;
            this.lblSortBySlideNumber.Text = "Slide Number";
            this.lblSortBySlideNumber.Click += new System.EventHandler(this.lblSortBySlideNumber_Click);
            // 
            // lblSortByMostViewed
            // 
            this.lblSortByMostViewed.AutoSize = true;
            this.lblSortByMostViewed.Location = new System.Drawing.Point(519, 70);
            this.lblSortByMostViewed.Name = "lblSortByMostViewed";
            this.lblSortByMostViewed.Size = new System.Drawing.Size(68, 13);
            this.lblSortByMostViewed.TabIndex = 15;
            this.lblSortByMostViewed.Text = "Most Viewed";
            this.lblSortByMostViewed.Click += new System.EventHandler(this.lblSortByMostViewed_Click);
            // 
            // lblSortSeparator
            // 
            this.lblSortSeparator.AutoSize = true;
            this.lblSortSeparator.Location = new System.Drawing.Point(514, 70);
            this.lblSortSeparator.Name = "lblSortSeparator";
            this.lblSortSeparator.Size = new System.Drawing.Size(9, 13);
            this.lblSortSeparator.TabIndex = 16;
            this.lblSortSeparator.Text = "|";
            this.lblSortSeparator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRelevant
            // 
            this.lblRelevant.AutoSize = true;
            this.lblRelevant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelevant.Location = new System.Drawing.Point(24, 231);
            this.lblRelevant.Margin = new System.Windows.Forms.Padding(0);
            this.lblRelevant.Name = "lblRelevant";
            this.lblRelevant.Size = new System.Drawing.Size(224, 20);
            this.lblRelevant.TabIndex = 2;
            this.lblRelevant.Text = "Recent Relevant Searches";
            // 
            // lbxRelevant
            // 
            this.lbxRelevant.FormattingEnabled = true;
            this.lbxRelevant.Location = new System.Drawing.Point(25, 254);
            this.lbxRelevant.Name = "lbxRelevant";
            this.lbxRelevant.Size = new System.Drawing.Size(273, 108);
            this.lbxRelevant.TabIndex = 6;
            this.lbxRelevant.Click += new System.EventHandler(this.lbxRelevant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 730);
            this.Controls.Add(this.lblSortSeparator);
            this.Controls.Add(this.lblSortByMostViewed);
            this.Controls.Add(this.lblSortBySlideNumber);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FDA Slide Search POC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab1.ResumeLayout(false);
            this.pgSlideResults.ResumeLayout(false);
            this.DataGridResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoFDAProposalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage DataGridResults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage pgSlideResults;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private DemoFDAProposalDataSet demoFDAProposalDataSet1;
        private System.Windows.Forms.Label lblSearchMode;
        private System.Windows.Forms.ListBox lbxAltSearchTerms;
        private System.Windows.Forms.Label lblDidYouMean;
        private System.Windows.Forms.Label lblClearSearch;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Label lblSortBySlideNumber;
        private System.Windows.Forms.Label lblSortByMostViewed;
        private System.Windows.Forms.Label lblSortSeparator;
        private System.Windows.Forms.ListBox lbxRelevant;
        private System.Windows.Forms.Label lblRelevant;
    }
}

