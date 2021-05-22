using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HighfieldTechTest
{
    public class AgePlusTwentyDTO
    {
        public string UserId { get; set; }
        public int OriginalAge { get; set; }
        public int AgePlusTwenty { get; set; }

        internal static IEnumerable<AgePlusTwentyDTO> ConvertData(IEnumerable<UserEntity> data)
        {
            List<AgePlusTwentyDTO> processedData = new List<AgePlusTwentyDTO>();

            foreach (UserEntity user in data)
            {
                try
                {
                    int userAge = CalculateAgeFromDateTime(user.Dob);

                    processedData.Add(
                        new AgePlusTwentyDTO { UserId = user.Id, OriginalAge = userAge, AgePlusTwenty = userAge + 20 });
                }
                catch (Exception ex)
                {
                    string.Format("USER ID: {0}\nFirst Name: {1}\nLast Name: {2}\nException: {3}", user.Id, user.FirstName, user.LastName, ex.Message);
                    MessageBox.Show(user.FirstName);
                }
            }

            return processedData;
        }

        private static int CalculateAgeFromDateTime(DateTime dob)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;

            if (dob.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
