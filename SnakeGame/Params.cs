using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SnakeGame
{
    public class Params
    {
        private string ResourceFolder;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString().IndexOf("bin", StringComparison.Ordinal);//получить индекс папки bin

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();//путь до указанной папки

            ResourceFolder = binFolder + "resources\\";
        }
        public string GetResourceFolder()
        {
            return ResourceFolder;
        }
    }
}
