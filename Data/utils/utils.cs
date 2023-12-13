using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formdata.Data.utils
{
    public class utils
    {
        public static string ApplicationDirectoryPath()
        {
            String folderPath = "C:\\Users\\Acer\\Desktop\\appDev";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                return folderPath;
            }
            else
            {
                return folderPath;
            }
        }

        public static String ApplicationFilePath()
        {
            String folderPath = ApplicationDirectoryPath();
            String filePath = Path.Combine(folderPath, "FormData.json");
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                return filePath;
            } else
            {
                return filePath;
            }
        }

    }
   
}
