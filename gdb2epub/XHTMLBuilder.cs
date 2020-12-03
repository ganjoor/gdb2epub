using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ganjoor;

namespace gdb2epub
{
    class XHTMLBuilder
    {

        public static void WriteStyleSheet(string filename)
        {
            string css = "*{    margin:0;     padding:0}" +
                         "@font-face" +
                         "{" +
                         "font-family: 'Iranian Sans';" +
                         "src: url('fonts/irsans.ttf')" +
                         "} " +
                         "body{direction:rtl; text-align:justify; font:1em 'Iranian Sans';}" +
                         "h1{text-align:center;margin:auto;font-weight:bold;font-size: 2em;display:block;page-break-before: always;}" +
                         "h2{text-align:center;margin-top:20px;margin-bottom:20px;margin-left:auto;margin-right:auto;font-weight:bold;font-size: 1.5em;}" +
                         "p{text-align:justify;text-indent:20px;margin-bottom:10px;}" +
                         "img{display:block; clear:both; margin:auto; text-align:center;}" +
                         "a:link{text-decoration:none;}" +
                         "a img{border:none;}";
            File.WriteAllText(filename, css);

        }

        public static void WriteCoverPage(string filename, string Title)
        {
            string xhtml = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>\n" +
                "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.1//EN\"  \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\">"+
                "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\" lang=\"fa\">\n"+
                "<head>\n<title>" + Title +"</title>\n"+
                "<style type=\"text/css\">\n"+
                "@page {padding: 0pt; margin:0pt}\n"+
                "body { text-align: center; padding:0pt; margin: 0pt; }\n"+
                "div { margin: 0pt; padding: 0pt; }\n"+
                "img.sgc-1 {height: 100%}\n"+
                "</style>\n"+
                "</head>\n"+
                "<body>\n"+
                "<div class=\"sgc-1\"><img alt=\"" + Title + "\" class=\"sgc-1\" src=\"images/cover.png\" /></div>\n" +
                "</body></html>";
            File.WriteAllText(filename, xhtml);

        }
        
        public static void Build(string filename, string Title, string Content)
        {
            string xhtml = String.Format(
                            "<?xml version=\"1.0\" encoding=\"utf-8\"?> \n"+
                            "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\" lang=\"fa\"> \n<head>\n"+
                            "<meta name=\"generator\" content=\"ganjoor.net\" />\n<title>{0}</title>\n<link rel=\"stylesheet\" href=\"style.css\" type=\"text/css\" />\n" +
                            "<meta http-equiv=\"Content-Type\" content=\"application/xhtml+xml; charset=utf-8\" />\n</head>"+
                            "<body>\n<h1>{0}</h1>\n"+
                            "<p>{1}</p>\n</body></html>", Title, Content);
            File.WriteAllText(filename, xhtml);
        }

        public static string StartChapter(string Title, bool sub)
        {
            string xhtml = String.Format(
                            "<?xml version=\"1.0\" encoding=\"utf-8\"?> \n" +
                            "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\" lang=\"fa\"> \n<head>\n" +
                            "<meta name=\"generator\" content=\"ganjoor.net\" />\n<title>{0}</title>\n<link rel=\"stylesheet\" href=\"style.css\" type=\"text/css\" />\n" +
                            "<meta http-equiv=\"Content-Type\" content=\"application/xhtml+xml; charset=utf-8\" />\n</head>" +
                            "<body>\n<{1}>{0}</{1}>\n", Title, sub ? "h2" : "h1");
            return xhtml;
        }

        public static string StartPart(string Title)
        {
            string xhtml = String.Format(
                            "<?xml version=\"1.0\" encoding=\"utf-8\"?> \n" +
                            "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\" lang=\"fa\"> \n<head>\n" +
                            "<meta name=\"generator\" content=\"ganjoor.net\" />\n<title>{0}</title>\n<link rel=\"stylesheet\" href=\"style.css\" type=\"text/css\" />\n" +
                            "<meta http-equiv=\"Content-Type\" content=\"application/xhtml+xml; charset=utf-8\" />\n</head>" +
                            "<body>\n", Title);
            return xhtml;
        }

        public static string StartSection(string Title, int iId, string url)
        {
            string xhtml =
                string.IsNullOrEmpty(url) ? String.Format(
                            "<h2><a id=\"poem-{0}\">{1}</a></h2>\n", iId, Title)
                            :
                            String.Format(
                            "<h2><a id=\"poem-{0}\" href=\"{2}\">{1}</a></h2>\n", iId, Title, url);

            return xhtml;
        }




        public static string AddToChapter(List<GanjoorVerse> Verses, bool simple)
        {
            
            string xhtml;
            if (simple)
            {
                xhtml = "";
                foreach (GanjoorVerse Verse in Verses)
                {
                    xhtml += "<p>";
                    xhtml += Verse._Text;
                    xhtml += "</p>";
                }
            }
            else
            {
                xhtml = "<div class = \"ganjoor-poem-block\">";
                int iVerse = 0;
                while (iVerse < Verses.Count)
                {
                    GanjoorVerse Verse = Verses[iVerse];
                    switch (Verse._Position)
                    {
                        case VersePosition.Single:
                        case VersePosition.Paragraph:
                            xhtml += "<p>";
                            xhtml += Verse._Text;
                            xhtml += "</p>";
                            break;
                        case VersePosition.Right:
                            xhtml += "<div class = \"ganjoor-poem-block\">";
                            xhtml += "<div class = \"ganjoor-m1\">";
                            xhtml += "<p>";
                            xhtml += Verse._Text;
                            xhtml += "</p>";
                            xhtml += "</div>";
                            break;
                        case VersePosition.Left:
                            xhtml += "<div class = \"ganjoor-m2\">";
                            xhtml += "<p>";
                            xhtml += Verse._Text;
                            xhtml += "</p>";
                            xhtml += "</div>";
                            xhtml += "</div>";
                            break;
                        case VersePosition.CenteredVerse1:
                            xhtml += "<div class = \"ganjoor-poem-block\">";
                            xhtml += "<div class = \"ganjoor-m\">";
                            xhtml += "<p>";
                            xhtml += Verse._Text;
                            xhtml += "</p>";
                            if (iVerse != (Verses.Count - 1) && Verses[iVerse + 1]._Position == VersePosition.CenteredVerse2)
                                xhtml += "";
                            else
                            {
                                xhtml += "</div>";
                                xhtml += "</div>";
                            }
                            break;
                        case VersePosition.CenteredVerse2:
                            xhtml += "<p>";
                            xhtml += Verse._Text;
                            xhtml += "</p>";
                            xhtml += "</div>";
                            xhtml += "</div>";

                            break;
                    }
                    iVerse++;
                }
                xhtml += "</div>";
            }
                
            return xhtml;
        }
    }
}
