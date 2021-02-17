using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace ASP.NETCoreMVC2Chapter4.Models
{
    public class AsyncMethods
    {
        public  async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage= await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
