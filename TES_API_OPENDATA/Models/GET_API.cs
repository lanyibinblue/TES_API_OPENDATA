using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using static TES_API_OPENDATA.Models.OpenData;

namespace TES_API_OPENDATA.Models
{
    public class TEST_
    {

        public static List<Class1> Sample()
        {
            try
            {
                Uri uri = new Uri("https://datacenter.taichung.gov.tw/Swagger/OpenData/0010b111-2ac0-4528-bfab-5e47e2044839");
                var request = WebRequest.Create(uri);

                var response = request.GetResponse() as HttpWebResponse;
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                var srcString = reader.ReadToEnd();

                List<Class1> jsonData = new List<Class1>();
                jsonData = JsonConvert.DeserializeObject<List<Class1>>(srcString); 


                return jsonData;
            }
            catch (Exception ex)
            {

                throw ex;
             
            }
        }


    }
}
