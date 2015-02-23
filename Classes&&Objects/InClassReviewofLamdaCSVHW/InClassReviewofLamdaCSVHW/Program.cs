using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_ListeningHabits
{
    class Program
    {
        // Global List
        public static List<Play> musicDataList = new List<Play>();
        static void Main(string[] args)
        {
            // initalize dataset into list
            InitList();
            // keep console open
            Console.ReadKey();
        }
        /// <summary>
        /// A function to initalize the List from the csv file
        /// needed for testing
        /// </summary>
        public static void InitList()
        {
            // load data
            using (StreamReader reader = new StreamReader("scrobbledata.csv"))
            {
                // Get and don't use the first line
                string firstline = reader.ReadLine();
                // Loop through the rest of the lines
                while (!reader.EndOfStream)
                {
                    musicDataList.Add(new Play(reader.ReadLine()));
                }
            }
        }
        /// <summary>
        /// A function that will return the total ammount of plays in the dataset
        /// </summary>
        /// <returns>total number of plays</returns>
        public static int TotalPlays()
        {
            return musicDataList.Count;
        }
        /// <summary>
        /// A function that returns the number of plays ever by an artist
        /// </summary>
        /// <param name="artistName">artist name</param>
        /// <returns>total number of plays</returns>
        public static int TotalPlaysByArtistName(string artistName)
        {
            return musicDataList.Count(x => x.Artist.ToString().ToLower() == artistName.ToLower());
        }
        /// <summary>
        /// A function that returns the number of plays by a specific artist in a specific year
        /// </summary>
        /// <param name="artistName">artist name</param>
        /// <param name="year">one year</param>
        /// <returns>total plays in year</returns>
        public static int TotalPlaysByArtistNameInYear(string artistName, string year)
        {
            return musicDataList.Where(x => x.Time.Year.ToString() == year).Where(y => y.Artist.ToLower() == artistName.ToLower()).Count();

            //var theAnswer = musicDataList.Where(x => x.Time.DayOfWeek == DayOfWeek.Friday && x.Time.Hour >= 12 && x.Time.Hour <= 17).GroupBy(x => x.Artist).OrderByDescending(x => x.Count()).ToList();
        }
        /// <summary>
        /// A function that returns the number of unique artists in the entire dataset
        /// </summary>
        /// <returns>number of unique artists</returns>
        public static int CountUniqueArtists()
        {
            return musicDataList.Select(x => x.Artist).Distinct().Count();
        }
        /// <summary>
        /// A function that returns the number of unique artists in a given year
        /// </summary>
        /// <param name="year">year to check</param>
        /// <returns>unique artists in year</returns>
        public static int CountUniqueArtists(string year)
        {
            return musicDataList.Where(x => x.Time.Year.ToString() == year).Select(x => x.Artist).Distinct().Count();

            //List<Play> allArtistsandplaysoftheyear = musicDataList.Where(x => x.Time.Year.ToString() == year).ToList();
            //List<string> justartistnames = allArtistsandplaysoftheyear.Select(x => x.Artist).ToList();
            //List<string> justuniquenames = justartistnames.Distinct().ToList();

        }
        /// <summary>
        /// A function that returns a List of unique strings which contains
        /// the Title of each track by a specific artists
        /// </summary>
        /// <param name="artistName">artist</param>
        /// <returns>list of song titles</returns>
        public static List<string> TrackListByArtist(string artistName)
        {
            //1. get all plays by artist
                //List<Play> allplaysbyartist = musicDataList.Where(x => x.Artist.ToLower() == artistName.ToLower()).ToList();
            //2. select all of the tracks
                //List<string> alltracksbytheartist = allplaysbyartist.Select(x => x.Title).ToList();
            //3. return the unique/distinct tracks
               //List<string> alldistincttracksbytheartist = alltracksbytheartist.Distinct().ToList();
            return musicDataList.Where(x => x.Artist.ToLower() == artistName.ToLower()).Select(x => x.Title).ToList();

        }
        /// <summary>
        /// A function that returns the first time an artist was ever played
        /// </summary>
        /// <param name="artistName">artist name</param>
        /// <returns>DateTime of first play</returns>
        public static DateTime FirstPlayByArtist(string artistName)
        {
            //1. filter all plays by artist
                //List<Play> playsbytheartist = musicDataList.Where(x => x.Artist.ToLower() == artistName.ToLower()).ToList();
            //2. order the plays by date
                    //playsbytheartist = playsbytheartist.OrderBy(x => x.Time).ToList();
                //or 
                    //List<Play> playsbytheartistbydate = playsbytheartist.OrderBy(x => x.Time).ToList();
            //3. take the first play, return its datetime
                //Play firstplayever = playsbytheartistbydate.First();
                //return firstplayever.Time;
                
            return musicDataList
                .Where(x => x.Artist.ToLower() == artistName.ToLower())
                .OrderBy(x => x.Time)
                .First()
                .Time;
        }


        /// <summary>
        ///                     ***BONUS***
        /// A function that will determine the most played artist in a specified yearx
        /// </summary>
        /// <param name="year">year to check</param>
        /// <returns>most popular artist in year</returns>
        public static string MostPopularArtistByYear(string year)
        {
            //1. filter plays by the year
                List<Play> playsintheyear = musicDataList.Where(x => x.Time.Year.ToString() == year).ToList();
            //2. group the plays by the artist
                List<IGrouping<string, Play>> playsgroupedbyartist = playsintheyear.GroupBy(x => x.Artist).ToList();
            //3. order them in descending order based on the number of plays
                List<IGrouping<string, Play>> orderbyplaysgroupedbyartist = playsgroupedbyartist.OrderByDescending(x => x.Count()).ToList();
            //4. take the first item out
                IGrouping<string, Play> mostpopular = orderbyplaysgroupedbyartist.First();
            //5. return a string with the artist name
                return mostpopular.Key;

            return musicDataList.Where(x => x.Time.Year.ToString() == year)
                .GroupBy(y => y.Artist)
                .OrderByDescending(z => z.Count())
                .First().First().Artist.ToString();
        }
    }

    public class Play
    {
        // Properties
        public DateTime Time { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }

        public Play(string lineInput)
        {
            // Split using the tab character due to the tab delimited data format
            string[] playData = lineInput.Split('\t');

            // Get the time in milliseconds and convert to C# DateTime
            DateTime posixTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
            this.Time = posixTime.AddMilliseconds(long.Parse(playData[0]));

            // need to populate the rest of the properties
            this.Artist = playData[1];
            this.Title = playData[2];
            this.Album = playData[3];
        }
    }
}
