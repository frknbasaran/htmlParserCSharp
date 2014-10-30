using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace htmlParse {
    class HtmlParse {
        public void AddTextToBody(String path, String text) {
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.Load(path);

            HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode("/html/body");
            htmlNode.InnerHtml += text;

            System.IO.File.WriteAllText(path, htmlDocument.DocumentNode.OuterHtml);
        }

        private HtmlParse() {}

        public static HtmlParse Instance;
        public static HtmlParse getInstance() {
            if(Instance == null) {
                Instance = new HtmlParse();
            }
            return Instance;
        }
    }
}
