/*
 * N-tier C# and SQL program to analyze Chicago crime data from
 * a Microsoft SQL Server database file.
 * 
 * Joey Nelson
 * U. of Illinois, Chicago
 * CS341, Spring 2016
 * Homework 8
 * 
 * */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CHART = System.Windows.Forms.DataVisualization.Charting;


namespace ChicagoCrimeGUI
{
  public partial class Form1 : Form
  {
    //
    // private data members accessible to all functions:
    //
    private string  ConnectionInfo;


    public Form1()
    {
      InitializeComponent();

      // initialize database connection string:
      string version = "MSSQLLocalDB";
      string filename = this.txtDBFile.Text;

      ConnectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename={1};Integrated Security=True;", 
        version, filename);
    }


    //
    // Called when window is about to appear for the first time:
    //
    private void Form1_Load(object sender, EventArgs e)
    {
      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      BusinessTier.CrimeStats stats;
      stats = biztier.GetOverallCrimeStats();
      int minYear = stats.MinYear;
      int maxYear = stats.MaxYear;
      long total = stats.TotalCrimes;

      string title;
      title = string.Format("Chicago Crime Analysis from {0}-{1}, Total of {2:#,##0} crimes", minYear, maxYear, total);
      this.Text = title;

      List<BusinessTier.Area> areas;
      areas = biztier.GetChicagoAreas(BusinessTier.OrderAreas.ByName);
      foreach (BusinessTier.Area area in areas) this.dropAreas.Items.Add(area.AreaName);
      this.dropAreas.SelectedIndex = 0;

      this.tbarMinYear.Minimum = minYear;
      this.tbarMinYear.Maximum = maxYear;
      this.tbarMinYear.Value = minYear;
      this.lblMinYear.Text = minYear.ToString();

      this.tbarMaxYear.Minimum = minYear;
      this.tbarMaxYear.Maximum = maxYear;
      this.tbarMaxYear.Value = maxYear;
      this.lblMaxYear.Text = maxYear.ToString();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ResetListBox(string newTitle)
    {
      this.lblListboxTitle.Text = newTitle;
      this.lblListboxTitle.Refresh();

      this.listBox1.Items.Clear();
      this.listBox1.Refresh();
    }


    //
    // Display total crimes and arrest percentages by year in the
    // listbox:
    //
    private void totalAndPercentagesByYearToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ResetListBox("Totals and Arrest Percentages by Year");

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      BusinessTier.CrimeStats stats;
      stats = biztier.GetOverallCrimeStats();
      int minYear = stats.MinYear;
      int maxYear = stats.MaxYear;

      Dictionary<int, long> crimes;
      Dictionary<int, double> arrests;
      crimes = biztier.GetTotalsByYear();
      arrests = biztier.GetArrestPercentagesByYear();
      long totalCrimes;
      double totalArrests;
      int i;

      for(i = minYear; i <= maxYear; i++)
      {
        totalCrimes = crimes[i];
        totalArrests = arrests[i];
        string msg = string.Format("{0}:  {1:#,##0} crimes, {2:0.00}% arrested", i, totalCrimes, totalArrests);
        this.listBox1.Items.Add(msg);

      }

    }


    //
    // Display all the crime codes in the listbox:
    //
    private void allCrimeCodesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ResetListBox("All Crime Codes");

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      List<BusinessTier.CrimeCode> crimeCodes;
      crimeCodes = biztier.GetCrimeCodes();
      
      foreach(BusinessTier.CrimeCode cc in crimeCodes)
        {
        string msg = string.Format("{0}: {1}:{2}", cc.IUCR, cc.PrimaryDescription, cc.SecondaryDescription);
        this.listBox1.Items.Add(msg);
      }
    }


    //
    // Display all the Chicago areas by name in the listbox:
    //
    private void allChicagoAreasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ResetListBox("All Chicago Areas by Name");

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      List<BusinessTier.Area> areas;
      areas = biztier.GetChicagoAreas(BusinessTier.OrderAreas.ByName);

      foreach(BusinessTier.Area area in areas)
      {
        string msg = string.Format("{0}: #{1}", area.AreaName, area.AreaNumber);
        this.listBox1.Items.Add(msg);
      }
    }

    //
    // Display all the Chicago areas by number in the listbox:
    //
    private void allChicagoAreasByNumberToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ResetListBox("All Chicago Areas by Name");

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      List<BusinessTier.Area> areas;
      areas = biztier.GetChicagoAreas(BusinessTier.OrderAreas.ByNumber);

      foreach (BusinessTier.Area area in areas)
      {
        string msg = string.Format("#{0}: {1}", area.AreaNumber, area.AreaName);
        this.listBox1.Items.Add(msg);
      }
    }


    //
    // Plot total crimes by year:
    //
    private void plotTotalCrimesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
      FormPlot plot = new FormPlot();
      plot.chart1.Series.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      BusinessTier.CrimeStats stats;
      stats = biztier.GetOverallCrimeStats();
      int minYear = stats.MinYear;
      int maxYear = stats.MaxYear;

      Dictionary<int, long> crimes;
      crimes = biztier.GetTotalsByYear();
      int i;

      // configure chart: 
      var series1 = new CHART.Series
      {
        Name = "Total Crimes",
        Color = System.Drawing.Color.Blue,
        IsVisibleInLegend = true,
        ChartType = CHART.SeriesChartType.Line
      };

      plot.chart1.Series.Add(series1);

      // now plot (x, y) coordinates: 
      for(i = minYear; i <= maxYear; i++)
      {
        int x = i;
        long y = crimes[i];

        series1.Points.AddXY(x, y);
      }

      //
      // All set, show the window to the user --- note that if user
      // does not close window, it will be closed automatically when
      // this main window exits.
      //
      plot.Text = "** Total Crimes by Year **";
      plot.Location = new System.Drawing.Point(0, 0);  // top-left:

      plot.Show();
    }


    //
    // Plot total crimes by area:
    //
    private void plotTotalCrimesByAreaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormPlot plot = new FormPlot();
      plot.chart1.Series.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      List<BusinessTier.Area> number;
      Dictionary<int, long> areas;
      number = biztier.GetChicagoAreas(BusinessTier.OrderAreas.ByNumber);
      areas = biztier.GetTotalsByArea();

      // configure chart: 
      var series1 = new CHART.Series
      {
        Name = "Total Crimes",
        Color = System.Drawing.Color.Blue,
        IsVisibleInLegend = true,
        ChartType = CHART.SeriesChartType.Line
      };

      plot.chart1.Series.Add(series1);

      // now plot (x, y) coordinates: 
      foreach (BusinessTier.Area area in number)
      {
        int x = area.AreaNumber;
        long y = areas[area.AreaNumber];

        series1.Points.AddXY(x, y);
      }

      //
      // All set, show the window to the user --- note that if user
      // does not close window, it will be closed automatically when
      // this main window exits.
      //
      plot.Text = "** Total Crimes by Area **";
      plot.Location = new System.Drawing.Point(20, 20);  // top-left:

      plot.Show();
    }


    //
    // Plot total crimes by month:
    //
    private void plotTotalCrimesByMonthToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormPlot plot = new FormPlot();
      plot.chart1.Series.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      Dictionary<int, long> month;
      month = biztier.GetTotalsByMonth();

      string[] months = { "Jan", "Feb", "Mar", "Apr", "May",
      "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

      // configure chart: 
      var series1 = new CHART.Series
      {
        Name = "Total Crimes",
        Color = System.Drawing.Color.Blue,
        IsVisibleInLegend = true,
        ChartType = CHART.SeriesChartType.Line
      };

      plot.chart1.Series.Add(series1);

      // now plot (x, y) coordinates: 
      int i;
      for (i = 0; i < months.Length; i++)
      {
        string x = months[i];
        long y = month[i + 1];

        series1.Points.AddXY(x, y);
      }

      //
      // All set, show the window to the user --- note that if user
      // does not close window, it will be closed automatically when
      // this main window exits.
      //
      plot.Text = "** Total Crimes by Month **";
      plot.Location = new System.Drawing.Point(40, 40);  // top-left:

      plot.Show();
    }


    //
    // This is the button that searches based on 3 checkboxes:
    //
    private void cmdTotalCrimes_Click(object sender, EventArgs e)
    {
      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      //
      // make sure at least 1 check box is checked:
      //

      if (chkYear.Checked == false &&
        chkIUCR.Checked == false &&
        chkArea.Checked == false)
      {
        MessageBox.Show("Please check at least one search criteria...");
        return;
      }

      string year = "";

      if (chkYear.Checked)
      {
        int check1;

        if (Int32.TryParse(this.txtYear.Text, out check1) == false)
        {
          MessageBox.Show("Year must be numeric...");
          return;
        }

        year = this.txtYear.Text;
      }

      string iucr = "";

      if (chkIUCR.Checked)
      {
        iucr = this.txtIUCR.Text.Replace("'", "''");
      }

      string area = "";

      if (chkArea.Checked)
      {
        int check2;

        if (Int32.TryParse(this.txtArea.Text, out check2) == false)
        {
          MessageBox.Show("Area must be numeric...");
          return;
        }
        area = this.txtArea.Text;
      }


      // NOTE: we always get a result back, worst-case it's 0.

      long total = biztier.GetCrimesByParameters(year, iucr, area);
      this.lblTotalCrimes.Text = total.ToString("#,##0");
    }

    private void chkYear_CheckedChanged(object sender, EventArgs e)
    {
      this.lblTotalCrimes.Text = "?";
    }

    private void chkIUCR_CheckedChanged(object sender, EventArgs e)
    {
      this.lblTotalCrimes.Text = "?";
    }

    private void chkArea_CheckedChanged(object sender, EventArgs e)
    {
      this.lblTotalCrimes.Text = "?";
    }


    //
    // Top N Areas in the city for crime:
    //
    private int GetN()
    {

      int N;

      if (Int32.TryParse(this.txtTopN.Text, out N) == false)
      {
        MessageBox.Show("N must be numeric...");
        return -1;
      }

      if (N < 1)
      {
        MessageBox.Show("N must be > 0...");
        return -1;
      }

      return N;
    }

    private void cmdTopAreas_Click(object sender, EventArgs e)
    {
      this.listBox2.Items.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      //
      // First, get the N value for our top N:
      //
      int N = GetN();

      if (N < 1)
        return;

      List<BusinessTier.Area2> areas;
      areas = biztier.GetTopAreas(N);

      int i = 1;

      foreach (BusinessTier.Area2 area in areas)
      {
        string msg = string.Format("{0}. {1}: {2:#,##0}",
          i, area.AreaName, area.Crimes);

        this.listBox2.Items.Add(msg);

        i++;
      }
    }


    //
    // Top N types of crime:
    //
    private void cmdTopCrimeTypes_Click(object sender, EventArgs e)
    {
      this.listBox2.Items.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      //
      // First, get the N value for our top N:
      //
      int N = GetN();

      if (N < 1)
        return;

      List<BusinessTier.CrimeCode2> codes;
      codes = biztier.GetTopCodes(N);

      int i = 1;

      foreach (BusinessTier.CrimeCode2 code in codes)
      {
        string msg = string.Format("{0}. {1}",
          i, code.PrimaryDescription);

        this.listBox2.Items.Add(msg);

        msg = string.Format("    {0}", code.SecondaryDescription);

        this.listBox2.Items.Add(msg);

        msg = string.Format("    {0:#,##0}", code.Total);

        this.listBox2.Items.Add(msg);

        i++;
      }
    }


    //
    // Top N areas for a particular type of crime:
    //
    private void cmdTopAreasForThisCrimeType_Click(object sender, EventArgs e)
    {
      this.listBox2.Items.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      //
      // First, get the N value for our top N:
      //
      int N = GetN();

      if (N < 1)
        return;

      //
      // Now retrieve the crime code the user is interested in:
      //
      string iucr = this.txtIUCR2.Text.Replace("'", "''");

      List<BusinessTier.Area2> areas;
      areas = biztier.GetTopCrimeType(N, iucr);

      int i = 1;

      foreach (BusinessTier.Area2 area in areas)
      {
        string msg = string.Format("{0}. {1}: {2:#,##0}",
          i, area.AreaName, area.Crimes);

        this.listBox2.Items.Add(msg);

        i++;
      }
    }

    private void tbarMinYear_Scroll(object sender, EventArgs e)
    {
      this.lblMinYear.Text = tbarMinYear.Value.ToString();
    }

    private void tbarMaxYear_Scroll(object sender, EventArgs e)
    {
      this.lblMaxYear.Text = tbarMaxYear.Value.ToString();
    }


    //
    // Top N crimes in a given area across a range of years:
    //
    private void cmdTopCrimesGivenAreaAndYears_Click(object sender, EventArgs e)
    {
      this.listBox2.Items.Clear();

      string filename = this.txtDBFile.Text;
      BusinessTier.Business biztier;
      biztier = new BusinessTier.Business(filename);

      if (biztier.OpenCloseConnection() == false)
      {
        MessageBox.Show("Error, unable to connect to database?!");
        return;
      }

      //
      // First, get the N value for our top N:
      //
      int N = GetN();

      if (N < 1)
        return;

      //
      // Second, what area did the user select?
      //

      if (this.dropAreas.SelectedIndex < 0)
      {
        MessageBox.Show("Please select an area...");
        return;
      }

      string areaname = this.dropAreas.SelectedItem.ToString();
      areaname = areaname.Replace("'", "''");

      //
      // Third, what year range?
      //
      int minyear = this.tbarMinYear.Value;
      int maxyear = this.tbarMaxYear.Value;

      if (minyear > maxyear)
      {
        MessageBox.Show("Please select a non-empty range of years...");
        return;
      }

      List<BusinessTier.CrimeCode2> codes;
      codes = biztier.GetByAreaAndYear(N, minyear, maxyear, areaname);

      int i = 1;

      foreach (BusinessTier.CrimeCode2 code in codes)
      {
        string msg = string.Format("{0}. {1}",
          i, code.PrimaryDescription);

        this.listBox2.Items.Add(msg);

        msg = string.Format("    {0}", code.SecondaryDescription);

        this.listBox2.Items.Add(msg);

        msg = string.Format("    {0:#,##0}", code.Total);

        this.listBox2.Items.Add(msg);

        i++;
      }
    }

  }//class
}//namespace
