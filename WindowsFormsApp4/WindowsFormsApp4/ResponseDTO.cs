using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HighfieldTechTest
{
    internal class ResponseDTO
    {
        public IEnumerable<UserEntity> Users { get; set; }
        public IEnumerable<AgePlusTwentyDTO> Ages { get; set; }
        public IEnumerable<TopColoursDTO> TopColours { get; set; }

        /// <summary>
        ///  Post Request Method, using Generic method
        /// </summary>
        internal static async Task<HttpResponseMessage> PostDataAsync(HttpClient httpclient, string endpoint, ResponseDTO data)
        {
            return await Common.MakePostRequestAsync(httpclient, endpoint, data);
        }
    }
}
