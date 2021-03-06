﻿using Epub;
using ganjoor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace gdb2epub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGDB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.gdb|*.gdb";
                if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    txtGDB.Text = dlg.FileName;
                    txtEpub.Text = Path.Combine(Path.GetDirectoryName(dlg.FileName), Path.GetFileNameWithoutExtension(dlg.FileName) + ".epub");
                }
            }
        }


        private bool GDB2EPub(string gdbFile, string epubFile)
        {
            DbBrowser db = new DbBrowser(txtGDB.Text);
            if (!db.Connected)
                return false;
            string tempPath = Path.Combine(Path.GetDirectoryName(epubFile), "temp");
            if (Directory.Exists(tempPath))
            {
                foreach (String f in Directory.GetFiles(tempPath))
                    File.Delete(f);
            }
            else
                Directory.CreateDirectory(tempPath);
            List<GanjoorPoet> poets = db.Poets;
            progressBar.Maximum = poets.Count;
            progressBar.Value = 0;

            foreach (GanjoorPoet Poet in db.Poets)
            {

                lblPoetName.Text = Poet._Name;
                progressBar.Value++;
                Application.DoEvents();
                foreach (String f in Directory.GetFiles(tempPath))
                    File.Delete(f);



                Document epub = new Document();

                epub.AddTitle(Poet._Name);
                epub.AddLanguage("fa");
                epub.AddAuthor(Poet._Name);


                epub.AddFile(txtMainFontPath.Text, "fonts/irsans.ttf", "application/x-font-ttf");
                string css = Path.Combine(tempPath, "style.css");
                XHTMLBuilder.WriteStyleSheet(css);
                epub.AddStylesheetFile(css, "style.css");


                using (Image coverImg = Image.FromFile(txtCoverImage.Text))
                {
                    using (Graphics g = Graphics.FromImage(coverImg))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        SizeF sz = g.MeasureString(Poet._Name, Properties.Settings.Default.CoverFont);
                        using (SolidBrush brsh = new SolidBrush(Color.FromArgb(51, 0, 0)))
                            g.DrawString(Poet._Name, Properties.Settings.Default.CoverFont, brsh, new PointF(200.0f - sz.Width / 2, 230.0f - sz.Height / 2));
                    }
                    MemoryStream coverData = new MemoryStream();
                    coverImg.Save(coverData, ImageFormat.Png);
                    String coverId = epub.AddImageData("images/cover.png", coverData.GetBuffer());
                    epub.AddMetaItem("cover", coverId);

                }



                int navCounter = 1;


                string titlepage = Path.Combine(tempPath, "titlepage.xhtml");
                XHTMLBuilder.WriteCoverPage(titlepage, Poet._Name);
                epub.AddXhtmlFile(titlepage, "titlepage.xhtml");

                string promoFile = Path.Combine(tempPath, "promo.xhtml");
                string promoXhtml = XHTMLBuilder.StartPart(GPersianTextSync.Sync("معرفی گنجور"));
                promoXhtml += "<h1>";
                promoXhtml += "معرفی گنجور";
                promoXhtml += "</h1>";
                string x = "";
                x += "<p>";
                x += "<a href=\"http://ganjoor.net\">گنجور</a> پروژه‌ای با هدف فراهم کردن دسترسی آزاد و رایگان پارسی‌زبانان به آثار سخنسرایان پارسی‌گوست.";
                x += "</p>";
                x += "<p>";
                x += "شما می‌توانید با دریافت برنامه‌های رایگان <a href=\"http://ganjoor.sourceforge.net\">گنجور رومیزی</a> یا <a href=\"http://pozh.org/saaghar\">ساغر</a> و برخی برنامه‌های رایگان دیگر تهیه شده برای سکوهای دیگر ";
                x += "از امکانات بیشتری جهت مطالعۀ این آثار بهره‌مند شوید.";
                x += "</p>";
                x += "<p>";
                x += "اخبار جدید راجع به پروژۀ گنجور را در این نشانی مطالعه فرمایید:";
                x += "</p>";
                x += "<p>";
                x += "<a href=\"http://blog.ganjoor.net\">http://blog.ganjoor.net</a>";
                x += "</p>";
                x += "<p>";
                x += "نظرات خود را به پست الکترونیکی <a href=\"mailto:ganjoor@ganjoor.net\">ganjoor@ganjoor.net</a> ارسال یا در صفحۀ فیس‌بوک گنجور به نشانی <a href=\"https://www.facebook.com/ganjoor\">http://www.facebook.com/ganjoor</a> مطرح فرمایید.";
                x += "</p>";
                x += "</body>";
                x += "</html>";
                File.WriteAllText(promoFile, promoXhtml + GPersianTextSync.Sync(x));
                epub.AddXhtmlFile(promoFile, "promo.xhtml");
                epub.AddNavPoint(GPersianTextSync.Sync("معرفی گنجور"), "promo.xhtml", navCounter++);


                string bio = Path.Combine(tempPath, "bio.xhtml");
                XHTMLBuilder.Build(bio, GPersianTextSync.Sync("دربارۀ " + Poet._Name), GPersianTextSync.Sync(Poet._Bio));
                epub.AddXhtmlFile(bio, "bio.xhtml");
                epub.AddNavPoint(GPersianTextSync.Sync("دربارۀ " + Poet._Name), Path.GetFileName(bio), navCounter++);


                GanjoorCat PoetCat = db.GetCategory(Poet._CatID);
                int nCat = 1;

                GanjoorCat curCat = PoetCat;

                navCounter = AddCat(db, tempPath, epub, navCounter, ref nCat, curCat, null);




                epub.Generate(Path.Combine(Path.GetDirectoryName(epubFile), GPersianTextSync.Farglisize(Poet._Name) + ".epub"));



            }
            db.CloseDb();
            return true;
        }

        private static int AddCat(DbBrowser db, string tempPath, Document epub, int navCounter, ref int nCat, GanjoorCat curCat, object parentchapterTOCEntry)
        {
            string catFile = Path.Combine(tempPath, String.Format("cat{0}.xhtml", curCat._ID));
            string catXHTML = XHTMLBuilder.StartChapter(curCat._Text, false);
            var chapterTOCEntry =
                   parentchapterTOCEntry == null ? epub.AddNavPoint(curCat._Text, Path.GetFileName(catFile), navCounter++)
                   :
                   (parentchapterTOCEntry as NavPoint).AddNavPoint(curCat._Text, Path.GetFileName(catFile), navCounter++);


            foreach (GanjoorCat subCat in db.GetSubCategories(curCat._ID))
            {
                nCat++;
                catXHTML += String.Format("<p><a href=\"{0}\">{1}</a></p>", String.Format("cat{0}.xhtml", subCat._ID), subCat._Text);
                navCounter += AddCat(db, tempPath, epub, navCounter, ref nCat, subCat, chapterTOCEntry);
            }

            int nLines = 0;
            int nPart = 1;
            string subcatXHTML = XHTMLBuilder.StartPart(curCat._Text + String.Format(" - بخش {0}", GPersianTextSync.Sync(nPart.ToString())));
            string partFile = Path.Combine(tempPath, String.Format("cat{0}sec{1}.xhtml", curCat._ID, nPart));

            List<string> poemNames = new List<string>();
            List<string> poemHRefs = new List<string>();
            List<string> partFiles = new List<string>();
            foreach (GanjoorPoem Poem in db.GetPoems(curCat._ID))
            {
                List<GanjoorVerse> verses = db.GetVerses(Poem._ID);

                string firstVerse = verses.Count > 0 ? verses[0]._Text : "";
                if (firstVerse.Length > 50)
                    firstVerse = firstVerse.Substring(0, 50) + " ...";
                if (!string.IsNullOrWhiteSpace(firstVerse))
                    firstVerse = " : " + firstVerse;

                string PoemName = Poem._Title.Length > 50 ? Poem._Title : Poem._Title + firstVerse;


                poemNames.Add(PoemName);
                poemHRefs.Add(String.Format("{0}#poem-{1}", Path.GetFileName(partFile), Poem._ID));
                subcatXHTML += XHTMLBuilder.StartSection(Poem._Title, Poem._ID, Poem._Url);


                subcatXHTML += XHTMLBuilder.AddToChapter(verses, true);

                catXHTML += String.Format("<p><a href=\"{0}#poem-{1}\">{2}</a></p>", Path.GetFileName(partFile), Poem._ID, PoemName);
                nLines += verses.Count;


                if (nLines >= 1000)
                {
                    subcatXHTML += "\r\n</body></html>";
                    File.WriteAllText(partFile, subcatXHTML);
                    partFiles.Add(partFile);
                    nLines = 0;
                    nPart++;
                    subcatXHTML = XHTMLBuilder.StartPart(curCat._Text + String.Format(" - بخش {0}", GPersianTextSync.Sync(nPart.ToString())));
                    partFile = Path.Combine(tempPath, String.Format("cat{0}sec{1}.xhtml", curCat._ID, nPart));

                }
            }

            if (nLines > 0)
            {
                subcatXHTML += "\r\n</body></html>";
                File.WriteAllText(partFile, subcatXHTML);
                partFiles.Add(partFile);
            }


            catXHTML += "\r\n</body></html>";
            File.WriteAllText(catFile, catXHTML);
            epub.AddXhtmlFile(catFile, Path.GetFileName(catFile));
            for (int i = 0; i < partFiles.Count; i++)
            {
                epub.AddXhtmlFile(partFiles[i], Path.GetFileName(partFiles[i]));
            }
            for (int i = 0; i < poemNames.Count; i++)
            {
                chapterTOCEntry.AddNavPoint(poemNames[i], poemHRefs[i], navCounter++);
            }

            return navCounter;
        }

        private void btnEpub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEpub.Text))
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Filter = "*.epub|*.epub";
                    if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        txtEpub.Text = dlg.FileName;
                        if (GDB2EPub(txtGDB.Text, txtEpub.Text))
                            MessageBox.Show("done!");
                    }
                }
            }
            else
            {
                File.Delete(txtEpub.Text);
                if (GDB2EPub(txtGDB.Text, txtEpub.Text))
                    MessageBox.Show("done!");
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.ttf|*.ttf";
                if(dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.MainFontPath = txtMainFontPath.Text = dlg.FileName;
                    Properties.Settings.Default.Save();
                }

            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.png|*.png";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.CoverImagePath = txtCoverImage.Text = dlg.FileName;
                    Properties.Settings.Default.Save();
                }

            }
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                dlg.Font = Properties.Settings.Default.CoverFont;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.CoverFont = dlg.Font;
                    Properties.Settings.Default.Save();
                    txtCoverFont.Text = Properties.Settings.Default.CoverFont.Name + "(" + Properties.Settings.Default.CoverFont.Style.ToString() + ") " + Properties.Settings.Default.CoverFont.Size.ToString();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtCoverFont.Text = Properties.Settings.Default.CoverFont.Name + "(" + Properties.Settings.Default.CoverFont.Style.ToString() + ") " + Properties.Settings.Default.CoverFont.Size.ToString();
            txtCoverImage.Text = Properties.Settings.Default.CoverImagePath;
            txtMainFontPath.Text = Properties.Settings.Default.MainFontPath;

        }
    }
}
