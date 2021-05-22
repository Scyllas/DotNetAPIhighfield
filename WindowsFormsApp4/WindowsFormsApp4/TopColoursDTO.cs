using System.Collections.Generic;
using System.Linq;

namespace HighfieldTechTest
{
    public class TopColoursDTO
    {

        public string Colour { get; set; }
        public int Count { get; set; }

        internal static IEnumerable<TopColoursDTO> ConvertData(IEnumerable<UserEntity> data)
        {
            Dictionary<string, int> colourSort = new Dictionary<string, int>();

            foreach (UserEntity user in data)
            {
                if (colourSort.ContainsKey(user.FavouriteColour))
                {
                    colourSort[user.FavouriteColour]++;
                }
                else
                {
                    colourSort[user.FavouriteColour] = 1;
                }
            }

            return SortDataByCountThenAlphabetically(colourSort);
        }

        private static List<TopColoursDTO> SortDataByCountThenAlphabetically(Dictionary<string, int> colourSort)
        {
            List<KeyValuePair<string, int>> orderedList = colourSort.ToList().OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

            List<TopColoursDTO> output = new List<TopColoursDTO>();

            foreach (KeyValuePair<string, int> entry in orderedList)
            {
                output.Add(
                    new TopColoursDTO { Colour = entry.Key, Count = entry.Value});
            }

            return output;
        }
    }
}
