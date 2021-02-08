using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SnakeGame
{
    public class Params
    {
        private string resourcesFolder;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString().IndexOf("bin", StringComparison.Ordinal);//получить индекс папки bin

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();//путь до указанной папки

            resourcesFolder = binFolder + "resources//";
        }
        public string GetResourceFolder()
        {
            return resourcesFolder;
        }
    }
}
