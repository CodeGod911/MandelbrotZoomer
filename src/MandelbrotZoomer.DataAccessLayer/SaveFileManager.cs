using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandelbrotZoomer.Common;
using Newtonsoft.Json;

namespace MandelbrotZoomer.DataAccessLayer
{
    public class SaveFileManager
    {
        public T Load<T>(string fullFileName)
        {
            var content = File.ReadAllText(fullFileName);
            return JsonConvert.DeserializeObject<T>(content);
        }

        public void Save<T>(string fullFileName, T o)
        {
            var content = JsonConvert.SerializeObject(o);
            File.WriteAllText(fullFileName,content);
        }

        public void Save(string fullFileName, Bitmap bmp)
        {
            bmp.Save(fullFileName, ImageFormat.Jpeg);
        }
    }
}
