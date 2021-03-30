using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace dgCube.Common
{
    public class JsonTextHelper
    {
        public string Read(string path)
        {
            var result = string.Empty;
            try
            {
                StreamReader file = File.OpenText("config.json");
                JsonTextReader reader = new JsonTextReader(file);
                JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                //CAN_Communication = (bool)jsonObject["CAN"];
                //AccCode = (uint)jsonObject["AccCode"];
                //Id = (uint)jsonObject["Id"];

                //// Configure Json
                //BPointMove = (bool)jsonObject["BPointMove"];
                //_classLeft.DelayBPointMove = (int)jsonObject["L_BPointMoveDelay"];
                //_classRight.DelayBPointMove = (int)jsonObject["R_BPointMoveDelay"];
                file.Close();

            }
            catch
            {
                //MessageBox.Show("CAN卡配置有误！");



            }
            return result;
        }



        public string Read2(string path)
        {
            var result = string.Empty;
            try
            {
                //StreamReader file = File.OpenText("config.json");
                //JsonTextReader reader = new JsonTextReader(file);
                //JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                //CAN_Communication = (bool)jsonObject["CAN"];
                //AccCode = (uint)jsonObject["AccCode"];
                //Id = (uint)jsonObject["Id"];
                //// Configure Json
                //BPointMove = (bool)jsonObject["BPointMove"];
                //_classLeft.DelayBPointMove = (int)jsonObject["L_BPointMoveDelay"];
                //_classRight.DelayBPointMove = (int)jsonObject["R_BPointMoveDelay"];

                // read file into a string and deserialize JSON to a type
                var movie1 = JsonConvert.DeserializeObject<object>(File.ReadAllText(@"c:\movie.json"));

                // deserialize JSON directly from a file
                using (StreamReader file = File.OpenText(@"c:\movie.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var movie2 = (object)serializer.Deserialize(file, typeof(object));
                }

                //file.Close();
            }
            catch
            {
                //MessageBox.Show("CAN卡配置有误！");
            }
            return result;
        }

    }
}
