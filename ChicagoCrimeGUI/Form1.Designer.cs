namespace ChicagoCrimeGUI
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.totalAndPercentagesByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allCrimeCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allChicagoAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.plotTotalCrimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotTotalCrimesByAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotTotalCrimesByMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.lblListboxTitle = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblTotalCrimes = new System.Windows.Forms.Label();
      this.cmdTotalCrimes = new System.Windows.Forms.Button();
      this.txtArea = new System.Windows.Forms.TextBox();
      this.txtIUCR = new System.Windows.Forms.TextBox();
      this.txtYear = new System.Windows.Forms.TextBox();
      this.chkArea = new System.Windows.Forms.CheckBox();
      this.chkIUCR = new System.Windows.Forms.CheckBox();
      this.chkYear = new System.Windows.Forms.CheckBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdTopCrimesGivenAreaAndYears = new System.Windows.Forms.Button();
      this.lblMaxYear = new System.Windows.Forms.Label();
      this.lblMinYear = new System.Windows.Forms.Label();
      this.tbarMaxYear = new System.Windows.Forms.TrackBar();
      this.tbarMinYear = new System.Windows.Forms.TrackBar();
      this.dropAreas = new System.Windows.Forms.ComboBox();
      this.cmdTopAreasForThisCrimeType = new System.Windows.Forms.Button();
      this.txtIUCR2 = new System.Windows.Forms.TextBox();
      this.cmdTopCrimeTypes = new System.Windows.Forms.Button();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.cmdTopAreas = new System.Windows.Forms.Button();
      this.txtTopN = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDBFile = new System.Windows.Forms.TextBox();
      this.allChicagoAreasByNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbarMaxYear)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarMinYear)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(957, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalAndPercentagesByYearToolStripMenuItem,
            this.allCrimeCodesToolStripMenuItem,
            this.allChicagoAreasToolStripMenuItem,
            this.allChicagoAreasByNumberToolStripMenuItem,
            this.toolStripMenuItem1,
            this.plotTotalCrimesToolStripMenuItem,
            this.plotTotalCrimesByAreaToolStripMenuItem,
            this.plotTotalCrimesByMonthToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // totalAndPercentagesByYearToolStripMenuItem
      // 
      this.totalAndPercentagesByYearToolStripMenuItem.Name = "totalAndPercentagesByYearToolStripMenuItem";
      this.totalAndPercentagesByYearToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.totalAndPercentagesByYearToolStripMenuItem.Text = "Total and Percentages by &Year";
      this.totalAndPercentagesByYearToolStripMenuItem.Click += new System.EventHandler(this.totalAndPercentagesByYearToolStripMenuItem_Click);
      // 
      // allCrimeCodesToolStripMenuItem
      // 
      this.allCrimeCodesToolStripMenuItem.Name = "allCrimeCodesToolStripMenuItem";
      this.allCrimeCodesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.allCrimeCodesToolStripMenuItem.Text = "All Crime &Codes";
      this.allCrimeCodesToolStripMenuItem.Click += new System.EventHandler(this.allCrimeCodesToolStripMenuItem_Click);
      // 
      // allChicagoAreasToolStripMenuItem
      // 
      this.allChicagoAreasToolStripMenuItem.Name = "allChicagoAreasToolStripMenuItem";
      this.allChicagoAreasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.allChicagoAreasToolStripMenuItem.Text = "All Chicago &Areas by Name";
      this.allChicagoAreasToolStripMenuItem.Click += new System.EventHandler(this.allChicagoAreasToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
      // 
      // plotTotalCrimesToolStripMenuItem
      // 
      this.plotTotalCrimesToolStripMenuItem.Name = "plotTotalCrimesToolStripMenuItem";
      this.plotTotalCrimesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.plotTotalCrimesToolStripMenuItem.Text = "Plot Total Crimes by Year";
      this.plotTotalCrimesToolStripMenuItem.Click += new System.EventHandler(this.plotTotalCrimesToolStripMenuItem_Click);
      // 
      // plotTotalCrimesByAreaToolStripMenuItem
      // 
      this.plotTotalCrimesByAreaToolStripMenuItem.Name = "plotTotalCrimesByAreaToolStripMenuItem";
      this.plotTotalCrimesByAreaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.plotTotalCrimesByAreaToolStripMenuItem.Text = "Plot Total Crimes by Area";
      this.plotTotalCrimesByAreaToolStripMenuItem.Click += new System.EventHandler(this.plotTotalCrimesByAreaToolStripMenuItem_Click);
      // 
      // plotTotalCrimesByMonthToolStripMenuItem
      // 
      this.plotTotalCrimesByMonthToolStripMenuItem.Name = "plotTotalCrimesByMonthToolStripMenuItem";
      this.plotTotalCrimesByMonthToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.plotTotalCrimesByMonthToolStripMenuItem.Text = "Plot Total Crimes by Month";
      this.plotTotalCrimesByMonthToolStripMenuItem.Click += new System.EventHandler(this.plotTotalCrimesByMonthToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.HorizontalScrollbar = true;
      this.listBox1.ItemHeight = 18;
      this.listBox1.Location = new System.Drawing.Point(22, 87);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(372, 328);
      this.listBox1.TabIndex = 1;
      // 
      // lblListboxTitle
      // 
      this.lblListboxTitle.BackColor = System.Drawing.Color.Aqua;
      this.lblListboxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblListboxTitle.Location = new System.Drawing.Point(22, 46);
      this.lblListboxTitle.Name = "lblListboxTitle";
      this.lblListboxTitle.Size = new System.Drawing.Size(371, 28);
      this.lblListboxTitle.TabIndex = 2;
      this.lblListboxTitle.Text = "<< use menu commands >>";
      this.lblListboxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.lblTotalCrimes);
      this.panel1.Controls.Add(this.cmdTotalCrimes);
      this.panel1.Controls.Add(this.txtArea);
      this.panel1.Controls.Add(this.txtIUCR);
      this.panel1.Controls.Add(this.txtYear);
      this.panel1.Controls.Add(this.chkArea);
      this.panel1.Controls.Add(this.chkIUCR);
      this.panel1.Controls.Add(this.chkYear);
      this.panel1.Location = new System.Drawing.Point(22, 431);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(372, 136);
      this.panel1.TabIndex = 3;
      // 
      // lblTotalCrimes
      // 
      this.lblTotalCrimes.BackColor = System.Drawing.Color.Yellow;
      this.lblTotalCrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalCrimes.Location = new System.Drawing.Point(220, 89);
      this.lblTotalCrimes.Name = "lblTotalCrimes";
      this.lblTotalCrimes.Size = new System.Drawing.Size(123, 26);
      this.lblTotalCrimes.TabIndex = 7;
      this.lblTotalCrimes.Text = "?";
      this.lblTotalCrimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmdTotalCrimes
      // 
      this.cmdTotalCrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdTotalCrimes.Location = new System.Drawing.Point(220, 20);
      this.cmdTotalCrimes.Name = "cmdTotalCrimes";
      this.cmdTotalCrimes.Size = new System.Drawing.Size(123, 56);
      this.cmdTotalCrimes.TabIndex = 6;
      this.cmdTotalCrimes.Text = "Total Crimes";
      this.cmdTotalCrimes.UseVisualStyleBackColor = true;
      this.cmdTotalCrimes.Click += new System.EventHandler(this.cmdTotalCrimes_Click);
      // 
      // txtArea
      // 
      this.txtArea.BackColor = System.Drawing.Color.Aqua;
      this.txtArea.Location = new System.Drawing.Point(101, 94);
      this.txtArea.Name = "txtArea";
      this.txtArea.Size = new System.Drawing.Size(89, 26);
      this.txtArea.TabIndex = 5;
      this.txtArea.Text = "32";
      // 
      // txtIUCR
      // 
      this.txtIUCR.BackColor = System.Drawing.Color.Aqua;
      this.txtIUCR.Location = new System.Drawing.Point(101, 54);
      this.txtIUCR.Name = "txtIUCR";
      this.txtIUCR.Size = new System.Drawing.Size(89, 26);
      this.txtIUCR.TabIndex = 4;
      this.txtIUCR.Text = "0820";
      // 
      // txtYear
      // 
      this.txtYear.BackColor = System.Drawing.Color.Aqua;
      this.txtYear.Location = new System.Drawing.Point(101, 15);
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(89, 26);
      this.txtYear.TabIndex = 3;
      this.txtYear.Text = "2015";
      // 
      // chkArea
      // 
      this.chkArea.AutoSize = true;
      this.chkArea.Location = new System.Drawing.Point(17, 96);
      this.chkArea.Name = "chkArea";
      this.chkArea.Size = new System.Drawing.Size(75, 24);
      this.chkArea.TabIndex = 2;
      this.chkArea.Text = "Area #";
      this.chkArea.UseVisualStyleBackColor = true;
      this.chkArea.CheckedChanged += new System.EventHandler(this.chkArea_CheckedChanged);
      // 
      // chkIUCR
      // 
      this.chkIUCR.AutoSize = true;
      this.chkIUCR.Location = new System.Drawing.Point(17, 57);
      this.chkIUCR.Name = "chkIUCR";
      this.chkIUCR.Size = new System.Drawing.Size(68, 24);
      this.chkIUCR.TabIndex = 1;
      this.chkIUCR.Text = "IUCR";
      this.chkIUCR.UseVisualStyleBackColor = true;
      this.chkIUCR.CheckedChanged += new System.EventHandler(this.chkIUCR_CheckedChanged);
      // 
      // chkYear
      // 
      this.chkYear.AutoSize = true;
      this.chkYear.Location = new System.Drawing.Point(17, 17);
      this.chkYear.Name = "chkYear";
      this.chkYear.Size = new System.Drawing.Size(62, 24);
      this.chkYear.TabIndex = 0;
      this.chkYear.Text = "Year";
      this.chkYear.UseVisualStyleBackColor = true;
      this.chkYear.CheckedChanged += new System.EventHandler(this.chkYear_CheckedChanged);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Controls.Add(this.cmdTopCrimesGivenAreaAndYears);
      this.panel2.Controls.Add(this.lblMaxYear);
      this.panel2.Controls.Add(this.lblMinYear);
      this.panel2.Controls.Add(this.tbarMaxYear);
      this.panel2.Controls.Add(this.tbarMinYear);
      this.panel2.Controls.Add(this.dropAreas);
      this.panel2.Controls.Add(this.cmdTopAreasForThisCrimeType);
      this.panel2.Controls.Add(this.txtIUCR2);
      this.panel2.Controls.Add(this.cmdTopCrimeTypes);
      this.panel2.Controls.Add(this.listBox2);
      this.panel2.Controls.Add(this.cmdTopAreas);
      this.panel2.Controls.Add(this.txtTopN);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(436, 46);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(500, 521);
      this.panel2.TabIndex = 4;
      // 
      // cmdTopCrimesGivenAreaAndYears
      // 
      this.cmdTopCrimesGivenAreaAndYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdTopCrimesGivenAreaAndYears.Location = new System.Drawing.Point(30, 382);
      this.cmdTopCrimesGivenAreaAndYears.Name = "cmdTopCrimesGivenAreaAndYears";
      this.cmdTopCrimesGivenAreaAndYears.Size = new System.Drawing.Size(154, 110);
      this.cmdTopCrimesGivenAreaAndYears.TabIndex = 12;
      this.cmdTopCrimesGivenAreaAndYears.Text = "Top Crimes in this Area across these Years";
      this.cmdTopCrimesGivenAreaAndYears.UseVisualStyleBackColor = true;
      this.cmdTopCrimesGivenAreaAndYears.Click += new System.EventHandler(this.cmdTopCrimesGivenAreaAndYears_Click);
      // 
      // lblMaxYear
      // 
      this.lblMaxYear.AutoSize = true;
      this.lblMaxYear.Location = new System.Drawing.Point(223, 472);
      this.lblMaxYear.Name = "lblMaxYear";
      this.lblMaxYear.Size = new System.Drawing.Size(72, 20);
      this.lblMaxYear.TabIndex = 11;
      this.lblMaxYear.Text = "max year";
      // 
      // lblMinYear
      // 
      this.lblMinYear.AutoSize = true;
      this.lblMinYear.Location = new System.Drawing.Point(223, 428);
      this.lblMinYear.Name = "lblMinYear";
      this.lblMinYear.Size = new System.Drawing.Size(68, 20);
      this.lblMinYear.TabIndex = 10;
      this.lblMinYear.Text = "min year";
      // 
      // tbarMaxYear
      // 
      this.tbarMaxYear.Location = new System.Drawing.Point(297, 473);
      this.tbarMaxYear.Name = "tbarMaxYear";
      this.tbarMaxYear.Size = new System.Drawing.Size(179, 45);
      this.tbarMaxYear.TabIndex = 9;
      this.tbarMaxYear.Scroll += new System.EventHandler(this.tbarMaxYear_Scroll);
      // 
      // tbarMinYear
      // 
      this.tbarMinYear.Location = new System.Drawing.Point(297, 428);
      this.tbarMinYear.Name = "tbarMinYear";
      this.tbarMinYear.Size = new System.Drawing.Size(183, 45);
      this.tbarMinYear.TabIndex = 8;
      this.tbarMinYear.Scroll += new System.EventHandler(this.tbarMinYear_Scroll);
      // 
      // dropAreas
      // 
      this.dropAreas.FormattingEnabled = true;
      this.dropAreas.Location = new System.Drawing.Point(227, 382);
      this.dropAreas.Name = "dropAreas";
      this.dropAreas.Size = new System.Drawing.Size(253, 28);
      this.dropAreas.TabIndex = 7;
      // 
      // cmdTopAreasForThisCrimeType
      // 
      this.cmdTopAreasForThisCrimeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdTopAreasForThisCrimeType.Location = new System.Drawing.Point(30, 256);
      this.cmdTopAreasForThisCrimeType.Name = "cmdTopAreasForThisCrimeType";
      this.cmdTopAreasForThisCrimeType.Size = new System.Drawing.Size(154, 51);
      this.cmdTopAreasForThisCrimeType.TabIndex = 6;
      this.cmdTopAreasForThisCrimeType.Text = "Top Areas for this Crime Type";
      this.cmdTopAreasForThisCrimeType.UseVisualStyleBackColor = true;
      this.cmdTopAreasForThisCrimeType.Click += new System.EventHandler(this.cmdTopAreasForThisCrimeType_Click);
      // 
      // txtIUCR2
      // 
      this.txtIUCR2.BackColor = System.Drawing.Color.Aqua;
      this.txtIUCR2.Location = new System.Drawing.Point(30, 222);
      this.txtIUCR2.Name = "txtIUCR2";
      this.txtIUCR2.Size = new System.Drawing.Size(154, 26);
      this.txtIUCR2.TabIndex = 5;
      this.txtIUCR2.Text = "0820";
      // 
      // cmdTopCrimeTypes
      // 
      this.cmdTopCrimeTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdTopCrimeTypes.Location = new System.Drawing.Point(30, 133);
      this.cmdTopCrimeTypes.Name = "cmdTopCrimeTypes";
      this.cmdTopCrimeTypes.Size = new System.Drawing.Size(154, 36);
      this.cmdTopCrimeTypes.TabIndex = 4;
      this.cmdTopCrimeTypes.Text = "Top Crime Types";
      this.cmdTopCrimeTypes.UseVisualStyleBackColor = true;
      this.cmdTopCrimeTypes.Click += new System.EventHandler(this.cmdTopCrimeTypes_Click);
      // 
      // listBox2
      // 
      this.listBox2.BackColor = System.Drawing.Color.Aqua;
      this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox2.FormattingEnabled = true;
      this.listBox2.HorizontalScrollbar = true;
      this.listBox2.ItemHeight = 18;
      this.listBox2.Location = new System.Drawing.Point(227, 15);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(253, 346);
      this.listBox2.TabIndex = 3;
      // 
      // cmdTopAreas
      // 
      this.cmdTopAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdTopAreas.Location = new System.Drawing.Point(30, 88);
      this.cmdTopAreas.Name = "cmdTopAreas";
      this.cmdTopAreas.Size = new System.Drawing.Size(154, 36);
      this.cmdTopAreas.TabIndex = 2;
      this.cmdTopAreas.Text = "Top Crime Areas";
      this.cmdTopAreas.UseVisualStyleBackColor = true;
      this.cmdTopAreas.Click += new System.EventHandler(this.cmdTopAreas_Click);
      // 
      // txtTopN
      // 
      this.txtTopN.BackColor = System.Drawing.Color.Aqua;
      this.txtTopN.Location = new System.Drawing.Point(95, 35);
      this.txtTopN.Name = "txtTopN";
      this.txtTopN.Size = new System.Drawing.Size(89, 26);
      this.txtTopN.TabIndex = 1;
      this.txtTopN.Text = "5";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(26, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Top";
      // 
      // txtDBFile
      // 
      this.txtDBFile.BackColor = System.Drawing.Color.Aqua;
      this.txtDBFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDBFile.Location = new System.Drawing.Point(22, 582);
      this.txtDBFile.Name = "txtDBFile";
      this.txtDBFile.Size = new System.Drawing.Size(914, 22);
      this.txtDBFile.TabIndex = 5;
      this.txtDBFile.Text = "|DataDirectory|\\CrimeDB.mdf";
      // 
      // allChicagoAreasByNumberToolStripMenuItem
      // 
      this.allChicagoAreasByNumberToolStripMenuItem.Name = "allChicagoAreasByNumberToolStripMenuItem";
      this.allChicagoAreasByNumberToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.allChicagoAreasByNumberToolStripMenuItem.Text = "All Chicago Areas by &Number";
      this.allChicagoAreasByNumberToolStripMenuItem.Click += new System.EventHandler(this.allChicagoAreasByNumberToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Yellow;
      this.ClientSize = new System.Drawing.Size(957, 616);
      this.Controls.Add(this.txtDBFile);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblListboxTitle);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbarMaxYear)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbarMinYear)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem totalAndPercentagesByYearToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label lblListboxTitle;
    private System.Windows.Forms.ToolStripMenuItem allCrimeCodesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem allChicagoAreasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotTotalCrimesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotTotalCrimesByAreaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotTotalCrimesByMonthToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtArea;
    private System.Windows.Forms.TextBox txtIUCR;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.CheckBox chkArea;
    private System.Windows.Forms.CheckBox chkIUCR;
    private System.Windows.Forms.CheckBox chkYear;
    private System.Windows.Forms.Button cmdTotalCrimes;
    private System.Windows.Forms.Label lblTotalCrimes;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtTopN;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cmdTopAreas;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Button cmdTopCrimeTypes;
    private System.Windows.Forms.Button cmdTopAreasForThisCrimeType;
    private System.Windows.Forms.TextBox txtIUCR2;
    private System.Windows.Forms.ComboBox dropAreas;
    private System.Windows.Forms.TrackBar tbarMinYear;
    private System.Windows.Forms.TrackBar tbarMaxYear;
    private System.Windows.Forms.Label lblMinYear;
    private System.Windows.Forms.Label lblMaxYear;
    private System.Windows.Forms.Button cmdTopCrimesGivenAreaAndYears;
    private System.Windows.Forms.TextBox txtDBFile;
    private System.Windows.Forms.ToolStripMenuItem allChicagoAreasByNumberToolStripMenuItem;
  }
}

