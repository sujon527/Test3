


using Analytics.DTO;
using System.Reflection.Metadata.Ecma335;

namespace Analytics.Aggregator.Models
{
    public class AnalyticsData
    {
        public int CP_ID { get; set; }
        public string? TmpItemName { get; set; }
        public int TmpItemValue { get; set; }
        public int TmprtNo { get; set; }

        // public AnalyticsDTO ToAnalyticsDTO(AnalyticsDTO analyticsDto)
        public AnalyticsDTO ToAnalyticsDTO(List<AnalyticsData> abc, AnalyticsDTO analyticsDto)

        {
            foreach (var item in abc)
            {
                switch(item.TmprtNo)
                {
                    case 1:
                        string[] arr = new string[2];
                        arr[0] = item.TmpItemName.ToString(); 
                        arr[1] = item.TmpItemValue.ToString();
                        analyticsDto.jobs.Add(arr);
                        break;
                }
            }
            //int cnt = 0;

            //foreach (var data in abc)
            //{
            //    cnt++;
            //    switch (data.TmprtNo)
            //    {
            //        case 1:

            //            if (cnt == 1)
            //            {
            //                analyticsDto.job.TotalJobs = data.TmpItemValue;

            //            }
            //            if (cnt == 2)
            //            {
            //                analyticsDto.job.StandardListingJobs = data.TmpItemValue;

            //            }
            //            if (cnt == 3)
            //            {
            //                analyticsDto.job.PremiumListingJobs = data.TmpItemValue;

            //            }
            //            if (cnt == 4)
            //            {
            //                analyticsDto.job.HotJobs = data.TmpItemValue;


            //            }


            //            break;
            //    }

                

            //    }
            return analyticsDto;

            }
        }
    }

// Use a switch case to categorize the data
//switch (TmprtNo)
//{
//    case 1: //
//            // Jobs

//        switch (TmpItemName)
//        {

//            case "TotalJobs":
//                analyticsDto.job.TotalJobs = TmpItemValue;
//                break;
//            case "Basic":
//                analyticsDto.job.StandardListingJobs = TmpItemValue;
//                break;

//            case "StandOut":
//                analyticsDto.job.PremiumListingJobs = TmpItemValue;
//                break;
//            case "HotJobs":
//                analyticsDto.job.HotJobs = TmpItemValue;
//                break;

//        }


//        break;

//    case 2: // Jobs
//        switch (TmpItemName)
//        {
//            case "AVGSummery":
//                analyticsDto.jobView.AppearedInSearchResultPerJob = TmpItemValue;
//                break;
//            case "AVGDetails":
//                analyticsDto.jobView.DetailViewsPerJob = TmpItemValue;
//                break;
//        }
//        break;
//    case 3: // Jobs
//        switch (TmpItemName)
//        {
//            case "TotalApplicant":
//                analyticsDto.applications.ShortListPerJob = TmpItemValue;
//                break;
//            case "Step-1":
//                analyticsDto.applications.ApplicationsPerJob = TmpItemValue;
//                break;
//        }
//        break;
//        }

//return analyticsDto;


 

//    return analyticsDto;
//private List<string[]> arrJobs = new List<string[]>();
//private List<string[]> arrJobView = new List<string[]>();
//private List<string[]> arrApplications = new List<string[]>();
//private List<string[]> arrConnection = new List<string[]>();
//private List<string[]> arrGender = new List<string[]>();
//private List<string[]> arrLocation = new List<string[]>();
//private List<string[]> arrAge = new List<string[]>();
//private List<string[]> arrUniversity = new List<string[]>();
//private List<string[]> arrDegree = new List<string[]>();

//public AnalyticsDTO FillArraysWithDataAsync(AnalyticsDTO analyticsDTO)
//{
//    // Fetch data from the repository




//        int category = Convert.ToInt32(TmprtNo); // Assuming TmprtNo is available in the record
//        string tmpItemName = TmpItemName; // Assuming TmpItemName is available
//        int tmpItemValue =TmpItemValue; // Assuming TmpItemValue is available

//        switch (category)
//        {
//            case 1:
//                analyticsDTO.jobs.Add(new string[] { tmpItemName, tmpItemValue.ToString()});
//                break;
//            case 2:
//                analyticsDTO.jobViews.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//                break;
//            case 3:
//                analyticsDTO.university.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//                break;
//            case 4:
//                analyticsDTO.applications.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//                break;
//            case 5:
//                analyticsDTO.genders.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//                break;
//            //case 6:
//            //    if (!string.Equals(tmpItemName, "mymensingh", StringComparison.OrdinalIgnoreCase))
//            //    {
//            //        analyticsDTO.university.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//            //    }
//            //    break;
//            //case 7:
//            //    analyticsDTO.university./() });
//            //    break;
//            //case 8:
//            //    arrDegree.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//            //    break;
//            //default:
//            //    if (arrUniversity.Count <= 4)
//            //    {
//            //        arrUniversity.Add(new string[] { tmpItemName, tmpItemValue.ToString() });
//            //    }
//            //    break;
//        }
//    return analyticsDTO;
//    }

//    // Handling JobView Ratio
//    //if (arrJobView.Count > 1)
//    //{
//    //    string[] lastJobView = new string[2];
//    //    lastJobView[0] = "Ratio";

//    //    // Assuming the first two elements are numeric
//    //    if (int.TryParse(arrJobView[1][1], out int firstJobViewValue) && firstJobViewValue != 0)
//    //    {
//    //        lastJobView[1] = (Convert.ToDecimal(arrJobView[0][1]) / firstJobViewValue).ToString("F1");
//    //    }
//    //    else
//    //    {
//    //        lastJobView[1] = "0";
//    //    }

//    //    arrJobView.Add(lastJobView);
//    //}

//   }
//}




