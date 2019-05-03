using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_with_RestApi
{
    public enum httpverb
    {
        GET,
        POST
    }

    class RestClient
    {
        public  string endpoint { get; set; }
        public httpverb httpmethod { get; set; }

        public RestClient()
        {
            endpoint = string.Empty;
            httpmethod = httpverb.GET;
        }

        public string MakeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = httpmethod.ToString();
            HttpWebResponse response = null;


            try
            {


                 response = (HttpWebResponse) request.GetResponse();
                
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }

                    }


                


                
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessage\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }

            return strResponseValue;

        }
        



    }
}
