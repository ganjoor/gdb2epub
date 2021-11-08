
namespace gdb2epub
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPoetName = new System.Windows.Forms.Label();
            this.btnEpub = new System.Windows.Forms.Button();
            this.txtEpub = new System.Windows.Forms.TextBox();
            this.btnGDB = new System.Windows.Forms.Button();
            this.txtGDB = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtMainFontPath = new System.Windows.Forms.TextBox();
            this.lblMainFontPath = new System.Windows.Forms.Label();
            this.lblCoverFont = new System.Windows.Forms.Label();
            this.txtCoverFont = new System.Windows.Forms.TextBox();
            this.lblCoverImage = new System.Windows.Forms.Label();
            this.txtCoverImage = new System.Windows.Forms.TextBox();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnBatchGenerate = new System.Windows.Forms.Button();
            this.btnIndexHtml = new System.Windows.Forms.Button();
            this.txtIndexHtmlPath = new System.Windows.Forms.TextBox();
            this.btnEpubsOutDir = new System.Windows.Forms.Button();
            this.txtEpubsPath = new System.Windows.Forms.TextBox();
            this.btnSelectXml = new System.Windows.Forms.Button();
            this.txtXmlPath = new System.Windows.Forms.TextBox();
            this.progressFiles = new System.Windows.Forms.ProgressBar();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPoetName
            // 
            this.lblPoetName.AutoSize = true;
            this.lblPoetName.Location = new System.Drawing.Point(51, 126);
            this.lblPoetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoetName.Name = "lblPoetName";
            this.lblPoetName.Size = new System.Drawing.Size(69, 19);
            this.lblPoetName.TabIndex = 10;
            this.lblPoetName.Text = "نام شاعر";
            // 
            // btnEpub
            // 
            this.btnEpub.Location = new System.Drawing.Point(565, 77);
            this.btnEpub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEpub.Name = "btnEpub";
            this.btnEpub.Size = new System.Drawing.Size(189, 33);
            this.btnEpub.TabIndex = 9;
            this.btnEpub.Text = "Generate Epub";
            this.btnEpub.UseVisualStyleBackColor = true;
            this.btnEpub.Click += new System.EventHandler(this.btnEpub_Click);
            // 
            // txtEpub
            // 
            this.txtEpub.Location = new System.Drawing.Point(51, 79);
            this.txtEpub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEpub.Name = "txtEpub";
            this.txtEpub.Size = new System.Drawing.Size(504, 27);
            this.txtEpub.TabIndex = 8;
            // 
            // btnGDB
            // 
            this.btnGDB.Location = new System.Drawing.Point(565, 39);
            this.btnGDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGDB.Name = "btnGDB";
            this.btnGDB.Size = new System.Drawing.Size(189, 33);
            this.btnGDB.TabIndex = 7;
            this.btnGDB.Text = "Select GDB";
            this.btnGDB.UseVisualStyleBackColor = true;
            this.btnGDB.Click += new System.EventHandler(this.btnGDB_Click);
            // 
            // txtGDB
            // 
            this.txtGDB.Location = new System.Drawing.Point(51, 41);
            this.txtGDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGDB.Name = "txtGDB";
            this.txtGDB.Size = new System.Drawing.Size(504, 27);
            this.txtGDB.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(51, 162);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(582, 35);
            this.progressBar.TabIndex = 11;
            // 
            // txtMainFontPath
            // 
            this.txtMainFontPath.Location = new System.Drawing.Point(202, 269);
            this.txtMainFontPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMainFontPath.Name = "txtMainFontPath";
            this.txtMainFontPath.Size = new System.Drawing.Size(504, 27);
            this.txtMainFontPath.TabIndex = 12;
            this.txtMainFontPath.Text = "D:\\My Documents\\My Downloads\\font\\irsans.ttf";
            // 
            // lblMainFontPath
            // 
            this.lblMainFontPath.AutoSize = true;
            this.lblMainFontPath.Location = new System.Drawing.Point(60, 272);
            this.lblMainFontPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainFontPath.Name = "lblMainFontPath";
            this.lblMainFontPath.Size = new System.Drawing.Size(134, 19);
            this.lblMainFontPath.TabIndex = 13;
            this.lblMainFontPath.Text = "مسیر فونت اصلی:";
            // 
            // lblCoverFont
            // 
            this.lblCoverFont.AutoSize = true;
            this.lblCoverFont.Location = new System.Drawing.Point(60, 320);
            this.lblCoverFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoverFont.Name = "lblCoverFont";
            this.lblCoverFont.Size = new System.Drawing.Size(79, 19);
            this.lblCoverFont.TabIndex = 14;
            this.lblCoverFont.Text = "فونت جلد:";
            // 
            // txtCoverFont
            // 
            this.txtCoverFont.Location = new System.Drawing.Point(202, 317);
            this.txtCoverFont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoverFont.Name = "txtCoverFont";
            this.txtCoverFont.Size = new System.Drawing.Size(504, 27);
            this.txtCoverFont.TabIndex = 15;
            this.txtCoverFont.Text = "IranNastaliq";
            // 
            // lblCoverImage
            // 
            this.lblCoverImage.AutoSize = true;
            this.lblCoverImage.Location = new System.Drawing.Point(60, 372);
            this.lblCoverImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoverImage.Name = "lblCoverImage";
            this.lblCoverImage.Size = new System.Drawing.Size(80, 19);
            this.lblCoverImage.TabIndex = 16;
            this.lblCoverImage.Text = "تصویر جلد:";
            // 
            // txtCoverImage
            // 
            this.txtCoverImage.Location = new System.Drawing.Point(202, 372);
            this.txtCoverImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoverImage.Name = "txtCoverImage";
            this.txtCoverImage.Size = new System.Drawing.Size(504, 27);
            this.txtCoverImage.TabIndex = 17;
            this.txtCoverImage.Text = "D:\\My Documents\\My Trash\\epub\\cover-image.png";
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(713, 260);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(58, 43);
            this.btnChangeFont.TabIndex = 18;
            this.btnChangeFont.Text = "...";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(713, 365);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(58, 43);
            this.btnChangeImage.TabIndex = 19;
            this.btnChangeImage.Text = "...";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(713, 311);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(58, 43);
            this.btnSelectFont.TabIndex = 20;
            this.btnSelectFont.Text = "...";
            this.btnSelectFont.UseVisualStyleBackColor = true;
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.progressFiles);
            this.grp.Controls.Add(this.btnBatchGenerate);
            this.grp.Controls.Add(this.btnIndexHtml);
            this.grp.Controls.Add(this.txtIndexHtmlPath);
            this.grp.Controls.Add(this.btnEpubsOutDir);
            this.grp.Controls.Add(this.txtEpubsPath);
            this.grp.Controls.Add(this.btnSelectXml);
            this.grp.Controls.Add(this.txtXmlPath);
            this.grp.Location = new System.Drawing.Point(55, 423);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(823, 348);
            this.grp.TabIndex = 21;
            this.grp.TabStop = false;
            this.grp.Text = "http://epub.ganjoor.net";
            // 
            // btnBatchGenerate
            // 
            this.btnBatchGenerate.Location = new System.Drawing.Point(27, 178);
            this.btnBatchGenerate.Name = "btnBatchGenerate";
            this.btnBatchGenerate.Size = new System.Drawing.Size(768, 88);
            this.btnBatchGenerate.TabIndex = 6;
            this.btnBatchGenerate.Text = "Batch Generate";
            this.btnBatchGenerate.UseVisualStyleBackColor = true;
            this.btnBatchGenerate.Click += new System.EventHandler(this.btnBatchGenerate_Click);
            // 
            // btnIndexHtml
            // 
            this.btnIndexHtml.Location = new System.Drawing.Point(697, 131);
            this.btnIndexHtml.Name = "btnIndexHtml";
            this.btnIndexHtml.Size = new System.Drawing.Size(98, 31);
            this.btnIndexHtml.TabIndex = 5;
            this.btnIndexHtml.Text = "index.html";
            this.btnIndexHtml.UseVisualStyleBackColor = true;
            this.btnIndexHtml.Click += new System.EventHandler(this.btnIndexHtml_Click);
            // 
            // txtIndexHtmlPath
            // 
            this.txtIndexHtmlPath.Location = new System.Drawing.Point(27, 134);
            this.txtIndexHtmlPath.Name = "txtIndexHtmlPath";
            this.txtIndexHtmlPath.Size = new System.Drawing.Size(664, 27);
            this.txtIndexHtmlPath.TabIndex = 4;
            this.txtIndexHtmlPath.Text = "C:\\inetpub\\epub\\index.html";
            // 
            // btnEpubsOutDir
            // 
            this.btnEpubsOutDir.Location = new System.Drawing.Point(696, 85);
            this.btnEpubsOutDir.Name = "btnEpubsOutDir";
            this.btnEpubsOutDir.Size = new System.Drawing.Size(99, 31);
            this.btnEpubsOutDir.TabIndex = 3;
            this.btnEpubsOutDir.Text = "Out. Dir";
            this.btnEpubsOutDir.UseVisualStyleBackColor = true;
            this.btnEpubsOutDir.Click += new System.EventHandler(this.btnEpubsOutDir_Click);
            // 
            // txtEpubsPath
            // 
            this.txtEpubsPath.Location = new System.Drawing.Point(26, 88);
            this.txtEpubsPath.Name = "txtEpubsPath";
            this.txtEpubsPath.Size = new System.Drawing.Size(664, 27);
            this.txtEpubsPath.TabIndex = 2;
            this.txtEpubsPath.Text = "C:\\inetpub\\iganjoor\\epub";
            // 
            // btnSelectXml
            // 
            this.btnSelectXml.Location = new System.Drawing.Point(696, 39);
            this.btnSelectXml.Name = "btnSelectXml";
            this.btnSelectXml.Size = new System.Drawing.Size(99, 31);
            this.btnSelectXml.TabIndex = 1;
            this.btnSelectXml.Text = "XML";
            this.btnSelectXml.UseVisualStyleBackColor = true;
            this.btnSelectXml.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // txtXmlPath
            // 
            this.txtXmlPath.Location = new System.Drawing.Point(26, 42);
            this.txtXmlPath.Name = "txtXmlPath";
            this.txtXmlPath.Size = new System.Drawing.Size(664, 27);
            this.txtXmlPath.TabIndex = 0;
            this.txtXmlPath.Text = "C:\\inetpub\\iganjoor\\android\\androidgdbs.xml";
            // 
            // progressFiles
            // 
            this.progressFiles.Location = new System.Drawing.Point(26, 283);
            this.progressFiles.Name = "progressFiles";
            this.progressFiles.Size = new System.Drawing.Size(769, 35);
            this.progressFiles.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(905, 806);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.btnSelectFont);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.txtCoverImage);
            this.Controls.Add(this.lblCoverImage);
            this.Controls.Add(this.txtCoverFont);
            this.Controls.Add(this.lblCoverFont);
            this.Controls.Add(this.lblMainFontPath);
            this.Controls.Add(this.txtMainFontPath);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblPoetName);
            this.Controls.Add(this.btnEpub);
            this.Controls.Add(this.txtEpub);
            this.Controls.Add(this.btnGDB);
            this.Controls.Add(this.txtGDB);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MainForm";
            this.Text = "GDB ==> Epub";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoetName;
        private System.Windows.Forms.Button btnEpub;
        private System.Windows.Forms.TextBox txtEpub;
        private System.Windows.Forms.Button btnGDB;
        private System.Windows.Forms.TextBox txtGDB;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtMainFontPath;
        private System.Windows.Forms.Label lblMainFontPath;
        private System.Windows.Forms.Label lblCoverFont;
        private System.Windows.Forms.TextBox txtCoverFont;
        private System.Windows.Forms.Label lblCoverImage;
        private System.Windows.Forms.TextBox txtCoverImage;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnSelectFont;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnSelectXml;
        private System.Windows.Forms.TextBox txtXmlPath;
        private System.Windows.Forms.Button btnIndexHtml;
        private System.Windows.Forms.TextBox txtIndexHtmlPath;
        private System.Windows.Forms.Button btnEpubsOutDir;
        private System.Windows.Forms.TextBox txtEpubsPath;
        private System.Windows.Forms.Button btnBatchGenerate;
        private System.Windows.Forms.ProgressBar progressFiles;
    }
}

