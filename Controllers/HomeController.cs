using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yum.GovData.Models;

namespace Yum.GovData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            // Using an XML Config file. 

            List<RecordViewModel> modelList = new List<RecordViewModel>();
            //using (GenericParser parser = new GenericParser())
            //{
                //parser.SetDataSource(Server.MapPath("CSV/Public Bodies in Pakistan.csv"));

                //parser.ColumnDelimiter = ',';
                //parser.FirstRowHasHeader = true;
                //parser.SkipStartingDataRows = 10;
                //parser.MaxBufferSize = 4096;
                //parser.MaxRows = 500;
                //parser.TextQualifier = '\"';
                using (CsvFileReader reader = new CsvFileReader(Server.MapPath("CSV/WriteTest.csv")))
                {
                    CsvRow parser = new CsvRow();
                    while (reader.ReadRow(parser))
                    {
                        //foreach (string s in row)
                        //{
                        //    Console.Write(s);
                        //    Console.Write(" ");
                        //}
                        //Console.WriteLine();
                        RecordViewModel record = new RecordViewModel();

                        int columnCount = parser.Count;

                        record.NameofPublicBody = parser[0];
                        record.TypeofOrganization = parser[1];
                        record.ControllingBody = parser[2];
                        record.Address = parser[3];
                        record.ContactNos = parser[4];
                        record.FaxNos = parser[5];
                        record.Website = parser[6];
                        record.EmailAddress = parser[7];
                        if (columnCount > 8)
                            record.ExtraInfoType = parser[8];
                        if (columnCount > 9)
                            record.ExtraInfoValue = parser[9];
                        if (columnCount > 10)
                            record.ExtraInfoType2 = parser[10];
                        if (columnCount > 11)
                            record.ExtraInfoValue2 = parser[11];
                        if (columnCount > 12)
                            record.ExtraInfoType3 = parser[12];
                        if (columnCount > 13)
                            record.ExtraInfoValue3 = parser[13];

                        modelList.Add(record);

                    }
                }
            //    while (parser.Read())
            //    {
            //        RecordViewModel record = new RecordViewModel();

            //        int columnCount = parser.ColumnCount;

            //        record.NameofPublicBody = parser[0];
            //        record.TypeofOrganization = parser[1];
            //        record.ControllingBody = parser[2];
            //        record.Address = parser[3];
            //        record.ContactNos = parser[4];
            //        record.FaxNos = parser[5];
            //        record.Website = parser[6];
            //        record.EmailAddress = parser[7];
            //        if (columnCount >= 8)
            //            record.ExtraInfoType = parser[8];
            //        if (columnCount >= 9)
            //            record.ExtraInfoValue = parser[9];
            //        if (columnCount >= 10)
            //            record.ExtraInfoType2 = parser[10];
            //        if (columnCount >= 11)
            //            record.ExtraInfoValue2 = parser[11];
            //        if (columnCount >= 12)
            //            record.ExtraInfoType3 = parser[12];
            //        if (columnCount >= 13)
            //            record.ExtraInfoValue3 = parser[13];

            //        modelList.Add(record);
            //    }
            //}

            //using (CsvFileWriter writer = new CsvFileWriter(Server.MapPath("CSV/WriteTest.csv")))
            //{
            //    foreach (Yum.GovData.Models.RecordViewModel obj in modelList)
            //    {
            //        if (!string.IsNullOrEmpty(obj.NameofPublicBody))
            //        {
            //            CsvRow row = new CsvRow();
            //            row.Add(String.Format("{0}", obj.NameofPublicBody));
            //            row.Add(String.Format("{0}", obj.TypeofOrganization));
            //            row.Add(String.Format("{0}", obj.ControllingBody));
            //            row.Add(String.Format("{0}", obj.Address));
            //            row.Add(String.Format("{0}", obj.ContactNos));
            //            row.Add(String.Format("{0}", obj.FaxNos));
            //            row.Add(String.Format("{0}", obj.Website));
            //            row.Add(String.Format("{0}", obj.EmailAddress));
            //            row.Add(String.Format("{0}", obj.ExtraInfoType));
            //            row.Add(String.Format("{0}", obj.ExtraInfoValue));
            //            row.Add(String.Format("{0}", obj.ExtraInfoType2));
            //            row.Add(String.Format("{0}", obj.ExtraInfoValue2));
            //            row.Add(String.Format("{0}", obj.ExtraInfoType3));
            //            row.Add(String.Format("{0}", obj.ExtraInfoValue3));
            //            writer.WriteRow(row);
            //        }
            //    }
            //}

            ViewBag.ModelList = modelList.OrderBy(x=>x.NameofPublicBody);

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
