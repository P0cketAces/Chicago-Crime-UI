//
// BusinessTier:  business logic, acting as interface between UI and data store.
//

using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{
  ///
  /// <summary>
  /// Ways to sort the Areas in Chicago.
  /// </summary>
  /// 
  public enum OrderAreas
  {
    ByNumber,
    ByName
  };


  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data dataTier;


    ///
    /// <summary>
    /// Constructs a new instance of the business tier.  The format
    /// of the filename should be either |DataDirectory|\filename.mdf,
    /// or a complete Windows pathname.
    /// </summary>
    /// <param name="DatabaseFilename">Name of database file</param>
    /// 
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;

      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }


    ///
    /// <summary>
    ///  Opens and closes a connection to the database, e.g. to
    ///  startup the server and make sure all is well.
    /// </summary>
    /// <returns>true if successful, false if not</returns>
    /// 
    public bool OpenCloseConnection()
    {
      return dataTier.OpenCloseConnection();
    }


    ///
    /// <summary>
    /// Returns overall stats about crimes in Chicago.
    /// </summary>
    /// <returns>CrimeStats object</returns>
    ///
    public CrimeStats GetOverallCrimeStats()
    {
      CrimeStats cs;

      string sql = string.Format(@"
        SELECT Count(CID) as Crime, Year FROM Crimes
        GROUP BY Year
        ");

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      int crimes = 0;
      int minYear = 99999;
      int maxYear = 0;
      int year;

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        crimes += Convert.ToInt32(row["Crime"]);
        year = Convert.ToInt32(row["Year"]);

        if (year < minYear)
          minYear = year;

        if (year > maxYear)
          maxYear = year;
      }

      cs = new CrimeStats(crimes, minYear, maxYear);

      return cs;
    }


    ///
    /// <summary>
    /// Returns all the areas in Chicago, ordered by area # or name.
    /// </summary>
    /// <param name="ordering"></param>
    /// <returns>List of Area objects</returns>
    /// 
    public List<Area> GetChicagoAreas(OrderAreas ordering)
    {
      List<Area> areas = new List<Area>();

      string sql = "";

      if (ordering == OrderAreas.ByName)
      {
        sql = string.Format(@"
        SELECT Area, AreaName
        FROM Areas
        WHERE Area > 0
        ORDER BY AreaName ASC
        ");
      }

      if (ordering == OrderAreas.ByNumber)
      {
        sql = string.Format(@"
        SELECT Area, AreaName
        FROM Areas
        WHERE Area > 0
        ORDER BY Area ASC
        ");
      }

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        Area ar;
        ar = new Area(Convert.ToInt32(row["Area"]), Convert.ToString(row["AreaName"]));
        areas.Add(ar);
      }

      Area a;
      a = new Area(0, "Unknown");
      areas.Add(a);

      return areas;
    }


    ///
    /// <summary>
    /// Returns all the crime codes and their descriptions.
    /// </summary>
    /// <returns>List of CrimeCode objects</returns>
    ///
    public List<CrimeCode> GetCrimeCodes()
    {
      List<CrimeCode> codes = new List<CrimeCode>();

      string sql = string.Format(@"
      SELECT IUCR, PrimaryDesc, SecondaryDesc
      FROM Codes
      "); 

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        CrimeCode cr;
        cr = new CrimeCode(Convert.ToString(row["IUCR"]), Convert.ToString(row["PrimaryDesc"]), Convert.ToString(row["SecondaryDesc"]));
        codes.Add(cr);
      }

      CrimeCode c;
      c = new CrimeCode("0000", "unknown", "unknown");
      codes.Add(c);

      return codes;
    }


    ///
    /// <summary>
    /// Returns a hash table of years, and total crimes each year.
    /// </summary>
    /// <returns>Dictionary where year is the key, and total crimes is the value</returns>
    ///
    public Dictionary<int, long> GetTotalsByYear()
    {
      Dictionary<int, long> totalsByYear = new Dictionary<int, long>();

      string sql = string.Format(@"
      SELECT COUNT(CID) as Crime, Year
      FROM Crimes
      GROUP BY Year
      ");

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        int year = Convert.ToInt32(row["Year"]);
        long crimes = Convert.ToInt64(row["Crime"]);

        totalsByYear.Add(year, crimes);
      }

      return totalsByYear;
    }


    ///
    /// <summary>
    /// Returns a hash table of months, and total crimes each month.
    /// </summary>
    /// <returns>Dictionary where month is the key, and total crimes is the value</returns>
    /// 
    public Dictionary<int, long> GetTotalsByMonth()
    {
      Dictionary<int, long> totalsByMonth = new Dictionary<int, long>();

      string sql = @"
      SELECT MONTH(convert(datetime, CrimeDate, 101)) as Month, Count(CID) as Crime
      FROM Crimes
      GROUP BY MONTH(convert(datetime, CrimeDate, 101))";

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        int finalMonth = Convert.ToInt32(row["Month"]);
        long crimes = Convert.ToInt64(row["Crime"]);

        totalsByMonth.Add(finalMonth, crimes);
      }

      return totalsByMonth;
    }


    ///
    /// <summary>
    /// Returns a hash table of areas, and total crimes each area.
    /// </summary>
    /// <returns>Dictionary where area # is the key, and total crimes is the value</returns>
    ///
    public Dictionary<int, long> GetTotalsByArea()
    {
      Dictionary<int, long> totalsByArea = new Dictionary<int, long>();

      string sql = @"
      SELECT COUNT(CID) as Crime, Area
      FROM Crimes
      GROUP BY Area";

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        int area = Convert.ToInt32(row["Area"]);
        long crimes = Convert.ToInt64(row["Crime"]);

        totalsByArea.Add(area, crimes);
      }

      return totalsByArea;
    }


    ///
    /// <summary>
    /// Returns a hash table of years, and arrest percentages each year.
    /// </summary>
    /// <returns>Dictionary where the year is the key, and the arrest percentage is the value</returns>
    /// 
    public Dictionary<int, double> GetArrestPercentagesByYear()
    {
      Dictionary<int, double> percentagesByYear = new Dictionary<int, double>();

      string sql = string.Format(@"
      SELECT 100 * (SUM(Convert(float, Arrested))/COUNT(CID)) as Arrests, Year
      FROM Crimes
      GROUP BY Year
      ");
      
      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        int year = Convert.ToInt32(row["Year"]);
        double arrests = Convert.ToDouble(row["Arrests"]);

        percentagesByYear.Add(year, arrests);
      }

      return percentagesByYear;
    }

    public long GetCrimesByParameters(string year, string iucr, string area)
    {
      string where = "";

      if(year.Length > 0)
        where = string.Format("Year = {0}", year);

      if(iucr.Length > 0)
      {
        if(where.Length > 0)
          where += " AND ";

        where += string.Format("IUCR = '{0}'", iucr);
      }

      if (area.Length > 0)
      {
        if(where.Length > 0)
          where += " AND ";

        where += string.Format("Area = '{0}'", area);
      }

      string sql = string.Format(@"
      SELECT Count(*) As Total 
      FROM Crimes 
      WHERE {0};
      ", where);

      object answer = dataTier.ExecuteScalarQuery(sql);
      long result = Convert.ToInt64(answer.ToString());

      return result;
    }

    public List<Area2> GetTopAreas(int N)
    {
      List<Area2> areas = new List<Area2>();

      string sql = string.Format(@"
      SELECT TOP {0} AreaName, Count(*) AS Total
      FROM Crimes
      INNER JOIN
        (SELECT * FROM AREAS WHERE Area > 0) AS T
      ON T.Area = Crimes.Area
      GROUP BY T.AreaName
      ORDER BY Total DESC", N);

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        Area2 ar;
        ar = new Area2(Convert.ToString(row["AreaName"]), Convert.ToInt64(row["Total"]));
        areas.Add(ar);
      }

      return areas;
    }

    public List<CrimeCode2> GetTopCodes(int N)
    {
      List<CrimeCode2> codes = new List<CrimeCode2>();

      string sql = string.Format(@"
      SELECT TOP {0} T.PrimaryDesc, T.SecondaryDesc, Count(*) AS Total
      FROM Crimes
      INNER JOIN
       (SELECT * FROM Codes) AS T
      ON T.IUCR = Crimes.IUCR
      GROUP BY T.PrimaryDesc, T.SecondaryDesc
      ORDER BY Total DESC", N);

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        CrimeCode2 cc;
        cc = new CrimeCode2(Convert.ToString(row["PrimaryDesc"]), Convert.ToString(row["SecondaryDesc"]), Convert.ToInt64(row["Total"]));
        codes.Add(cc);
      }

      return codes;
    }

    public List<Area2> GetTopCrimeType(int N, string iucr)
    {
      List<Area2> areas = new List<Area2>();

      string sql = string.Format(@"
      SELECT TOP {0} AreaName, Count(*) AS Total
      FROM Crimes
      INNER JOIN
       (SELECT * FROM AREAS WHERE Area > 0) AS T
      ON T.Area = Crimes.Area
      WHERE Crimes.IUCR = '{1}'
      GROUP BY T.AreaName
      ORDER BY Total DESC", N, iucr);

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        Area2 ar;
        ar = new Area2(Convert.ToString(row["AreaName"]), Convert.ToInt64(row["Total"]));
        areas.Add(ar);
      }

      return areas;
    }

    public List<CrimeCode2> GetByAreaAndYear(int N, int minyear, int maxyear, string areaname)
    {
      List<CrimeCode2> codes = new List<CrimeCode2>();

      string sql = string.Format(@"
      SELECT TOP {0} T.PrimaryDesc, T.SecondaryDesc, Count(*) AS Total
      FROM Crimes
      INNER JOIN
        (SELECT * FROM Codes) AS T
      ON T.IUCR = Crimes.IUCR
      WHERE Crimes.Year >= {1} AND 
            Crimes.Year <= {2} AND
            Crimes.Area = (SELECT Area FROM AREAS WHERE AreaName = '{3}')
      GROUP BY T.PrimaryDesc, T.SecondaryDesc
      ORDER BY Total DESC", N, minyear, maxyear, areaname);

      DataSet ds = new DataSet();
      ds = dataTier.ExecuteNonScalarQuery(sql);

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
        CrimeCode2 cc;
        cc = new CrimeCode2(Convert.ToString(row["PrimaryDesc"]), Convert.ToString(row["SecondaryDesc"]), Convert.ToInt64(row["Total"]));
        codes.Add(cc);
      }

      return codes;
    }

  }//class
}//namespace
