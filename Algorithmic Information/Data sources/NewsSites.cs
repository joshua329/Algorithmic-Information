using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithmic_Information.Data_sources
{
    class NewsSites
    {
        public const String NewsDirectory = "C:\\Users\\joshuab\\source\\repos\\Algorithmic Information\\Algorithmic Information\\Data sources\\Sites Segmentations\\";
        List<String> Countries = new List<String>();
        Dictionary<String, String> Sites = new Dictionary<String, String>();
        public void Start() {

        }
        private void getNewsSites() {
            String[] dir = Directory.GetDirectories(NewsDirectory);
            for (int i = 0; i < dir.Length; i++) {
                Countries.Add(dir[i]);
                getFileInfo(NewsDirectory + dir[i]);
            }
        }
        private Dictionary<string, string> getFileInfo(String fn) {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            using (StreamReader r = new StreamReader(fn)) {
                while (!r.EndOfStream) {
                    String line = r.ReadLine();
                    String [] arr = line.Split((" - ").ToCharArray());
                    temp.Add(arr[0], arr[1]);
                }
            }
            return temp;
        }
    }
}
