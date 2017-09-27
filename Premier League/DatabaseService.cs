using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_League
{
    static public class DatabaseService
    {
        static string fileName = "premier_league.txt";
        static public string path = "C:\\Projects\\Learning-stuff\\Premier League\\premier_league.txt";

        static public void SaveDatabase()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
