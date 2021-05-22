using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HighfieldTechTest
{
    internal class UserEntity
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string FavouriteColour { get; set; }

        /// <summary>
        ///  Get Request Method, using Generic method
        /// </summary>
        internal static async Task<IEnumerable<UserEntity>> GetDataAsync(HttpClient httpclient, string endpoint)
        {
            return await Common.MakeGetRequestAsync<UserEntity>(httpclient, endpoint);
        }
    }
}
