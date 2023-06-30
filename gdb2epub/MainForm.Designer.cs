
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
            this.txtFTPRootPath = new System.Windows.Forms.TextBox();
            this.lblFTPRootPath = new System.Windows.Forms.Label();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtFTPUsername = new System.Windows.Forms.TextBox();
            this.lblFTPUsername = new System.Windows.Forms.Label();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.lblFTPHost = new System.Windows.Forms.Label();
            this.progressFiles = new System.Windows.Forms.ProgressBar();
            this.btnBatchGenerate = new System.Windows.Forms.Button();
            this.btnIndexHtml = new System.Windows.Forms.Button();
            this.txtIndexHtmlPath = new System.Windows.Forms.TextBox();
            this.btnEpubsOutDir = new System.Windows.Forms.Button();
            this.txtEpubsPath = new System.Windows.Forms.TextBox();
            this.btnSelectXml = new System.Windows.Forms.Button();
            this.txtXmlPath = new System.Windows.Forms.TextBox();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPoetName
            // 
            this.lblPoetName.AutoSize = true;
            this.lblPoetName.Location = new System.Drawing.Point(34, 84);
            this.lblPoetName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoetName.Name = "lblPoetName";
            this.lblPoetName.Size = new System.Drawing.Size(49, 13);
            this.lblPoetName.TabIndex = 10;
            this.lblPoetName.Text = "نام شاعر";
            // 
            // btnEpub
            // 
            this.btnEpub.Location = new System.Drawing.Point(376, 52);
            this.btnEpub.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnEpub.Name = "btnEpub";
            this.btnEpub.Size = new System.Drawing.Size(126, 22);
            this.btnEpub.TabIndex = 9;
            this.btnEpub.Text = "Generate Epub";
            this.btnEpub.UseVisualStyleBackColor = true;
            this.btnEpub.Click += new System.EventHandler(this.btnEpub_Click);
            // 
            // txtEpub
            // 
            this.txtEpub.Location = new System.Drawing.Point(34, 52);
            this.txtEpub.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtEpub.Name = "txtEpub";
            this.txtEpub.Size = new System.Drawing.Size(338, 20);
            this.txtEpub.TabIndex = 8;
            // 
            // btnGDB
            // 
            this.btnGDB.Location = new System.Drawing.Point(376, 26);
            this.btnGDB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnGDB.Name = "btnGDB";
            this.btnGDB.Size = new System.Drawing.Size(126, 22);
            this.btnGDB.TabIndex = 7;
            this.btnGDB.Text = "Select GDB";
            this.btnGDB.UseVisualStyleBackColor = true;
            this.btnGDB.Click += new System.EventHandler(this.btnGDB_Click);
            // 
            // txtGDB
            // 
            this.txtGDB.Location = new System.Drawing.Point(34, 28);
            this.txtGDB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtGDB.Name = "txtGDB";
            this.txtGDB.Size = new System.Drawing.Size(338, 20);
            this.txtGDB.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(34, 108);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(388, 24);
            this.progressBar.TabIndex = 11;
            // 
            // txtMainFontPath
            // 
            this.txtMainFontPath.Location = new System.Drawing.Point(134, 180);
            this.txtMainFontPath.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMainFontPath.Name = "txtMainFontPath";
            this.txtMainFontPath.Size = new System.Drawing.Size(338, 20);
            this.txtMainFontPath.TabIndex = 12;
            this.txtMainFontPath.Text = "C:\\inetpub\\epub\\res\\irsans.ttf";
            // 
            // lblMainFontPath
            // 
            this.lblMainFontPath.AutoSize = true;
            this.lblMainFontPath.Location = new System.Drawing.Point(40, 182);
            this.lblMainFontPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainFontPath.Name = "lblMainFontPath";
            this.lblMainFontPath.Size = new System.Drawing.Size(94, 13);
            this.lblMainFontPath.TabIndex = 13;
            this.lblMainFontPath.Text = "مسیر فونت اصلی:";
            // 
            // lblCoverFont
            // 
            this.lblCoverFont.AutoSize = true;
            this.lblCoverFont.Location = new System.Drawing.Point(40, 214);
            this.lblCoverFont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoverFont.Name = "lblCoverFont";
            this.lblCoverFont.Size = new System.Drawing.Size(54, 13);
            this.lblCoverFont.TabIndex = 14;
            this.lblCoverFont.Text = "فونت جلد:";
            // 
            // txtCoverFont
            // 
            this.txtCoverFont.Location = new System.Drawing.Point(134, 212);
            this.txtCoverFont.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCoverFont.Name = "txtCoverFont";
            this.txtCoverFont.Size = new System.Drawing.Size(338, 20);
            this.txtCoverFont.TabIndex = 15;
            this.txtCoverFont.Text = "IranNastaliq";
            // 
            // lblCoverImage
            // 
            this.lblCoverImage.AutoSize = true;
            this.lblCoverImage.Location = new System.Drawing.Point(40, 248);
            this.lblCoverImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoverImage.Name = "lblCoverImage";
            this.lblCoverImage.Size = new System.Drawing.Size(56, 13);
            this.lblCoverImage.TabIndex = 16;
            this.lblCoverImage.Text = "تصویر جلد:";
            // 
            // txtCoverImage
            // 
            this.txtCoverImage.Location = new System.Drawing.Point(134, 248);
            this.txtCoverImage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCoverImage.Name = "txtCoverImage";
            this.txtCoverImage.Size = new System.Drawing.Size(338, 20);
            this.txtCoverImage.TabIndex = 17;
            this.txtCoverImage.Text = "C:\\inetpub\\epub\\res\\cover-image.png";
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(476, 174);
            this.btnChangeFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(38, 28);
            this.btnChangeFont.TabIndex = 18;
            this.btnChangeFont.Text = "...";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(476, 244);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(38, 28);
            this.btnChangeImage.TabIndex = 19;
            this.btnChangeImage.Text = "...";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(476, 208);
            this.btnSelectFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(38, 28);
            this.btnSelectFont.TabIndex = 20;
            this.btnSelectFont.Text = "...";
            this.btnSelectFont.UseVisualStyleBackColor = true;
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.txtFTPRootPath);
            this.grp.Controls.Add(this.lblFTPRootPath);
            this.grp.Controls.Add(this.txtFTPPassword);
            this.grp.Controls.Add(this.lblPassword);
            this.grp.Controls.Add(this.txtFTPUsername);
            this.grp.Controls.Add(this.lblFTPUsername);
            this.grp.Controls.Add(this.txtFTPHost);
            this.grp.Controls.Add(this.lblFTPHost);
            this.grp.Controls.Add(this.progressFiles);
            this.grp.Controls.Add(this.btnBatchGenerate);
            this.grp.Controls.Add(this.btnIndexHtml);
            this.grp.Controls.Add(this.txtIndexHtmlPath);
            this.grp.Controls.Add(this.btnEpubsOutDir);
            this.grp.Controls.Add(this.txtEpubsPath);
            this.grp.Controls.Add(this.btnSelectXml);
            this.grp.Controls.Add(this.txtXmlPath);
            this.grp.Location = new System.Drawing.Point(36, 282);
            this.grp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp.Size = new System.Drawing.Size(548, 337);
            this.grp.TabIndex = 21;
            this.grp.TabStop = false;
            this.grp.Text = "https://epub.ganjoor.net";
            // 
            // txtFTPRootPath
            // 
            this.txtFTPRootPath.Location = new System.Drawing.Point(77, 196);
            this.txtFTPRootPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFTPRootPath.Name = "txtFTPRootPath";
            this.txtFTPRootPath.Size = new System.Drawing.Size(454, 20);
            this.txtFTPRootPath.TabIndex = 15;
            // 
            // lblFTPRootPath
            // 
            this.lblFTPRootPath.AutoSize = true;
            this.lblFTPRootPath.Location = new System.Drawing.Point(15, 198);
            this.lblFTPRootPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFTPRootPath.Name = "lblFTPRootPath";
            this.lblFTPRootPath.Size = new System.Drawing.Size(33, 13);
            this.lblFTPRootPath.TabIndex = 14;
            this.lblFTPRootPath.Text = "Path:";
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(78, 171);
            this.txtFTPPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.Size = new System.Drawing.Size(454, 20);
            this.txtFTPPassword.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 172);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password:";
            // 
            // txtFTPUsername
            // 
            this.txtFTPUsername.Location = new System.Drawing.Point(78, 144);
            this.txtFTPUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFTPUsername.Name = "txtFTPUsername";
            this.txtFTPUsername.Size = new System.Drawing.Size(454, 20);
            this.txtFTPUsername.TabIndex = 11;
            // 
            // lblFTPUsername
            // 
            this.lblFTPUsername.AutoSize = true;
            this.lblFTPUsername.Location = new System.Drawing.Point(16, 144);
            this.lblFTPUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFTPUsername.Name = "lblFTPUsername";
            this.lblFTPUsername.Size = new System.Drawing.Size(59, 13);
            this.lblFTPUsername.TabIndex = 10;
            this.lblFTPUsername.Text = "Username:";
            // 
            // txtFTPHost
            // 
            this.txtFTPHost.Location = new System.Drawing.Point(78, 117);
            this.txtFTPHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.Size = new System.Drawing.Size(454, 20);
            this.txtFTPHost.TabIndex = 9;
            // 
            // lblFTPHost
            // 
            this.lblFTPHost.AutoSize = true;
            this.lblFTPHost.Location = new System.Drawing.Point(16, 118);
            this.lblFTPHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFTPHost.Name = "lblFTPHost";
            this.lblFTPHost.Size = new System.Drawing.Size(54, 13);
            this.lblFTPHost.TabIndex = 8;
            this.lblFTPHost.Text = "FTP Host:";
            // 
            // progressFiles
            // 
            this.progressFiles.Location = new System.Drawing.Point(18, 299);
            this.progressFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressFiles.Name = "progressFiles";
            this.progressFiles.Size = new System.Drawing.Size(512, 24);
            this.progressFiles.TabIndex = 7;
            // 
            // btnBatchGenerate
            // 
            this.btnBatchGenerate.Location = new System.Drawing.Point(18, 229);
            this.btnBatchGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatchGenerate.Name = "btnBatchGenerate";
            this.btnBatchGenerate.Size = new System.Drawing.Size(512, 58);
            this.btnBatchGenerate.TabIndex = 6;
            this.btnBatchGenerate.Text = "Batch Generate";
            this.btnBatchGenerate.UseVisualStyleBackColor = true;
            this.btnBatchGenerate.Click += new System.EventHandler(this.btnBatchGenerate_Click);
            // 
            // btnIndexHtml
            // 
            this.btnIndexHtml.Location = new System.Drawing.Point(464, 88);
            this.btnIndexHtml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIndexHtml.Name = "btnIndexHtml";
            this.btnIndexHtml.Size = new System.Drawing.Size(66, 20);
            this.btnIndexHtml.TabIndex = 5;
            this.btnIndexHtml.Text = "index.html";
            this.btnIndexHtml.UseVisualStyleBackColor = true;
            this.btnIndexHtml.Click += new System.EventHandler(this.btnIndexHtml_Click);
            // 
            // txtIndexHtmlPath
            // 
            this.txtIndexHtmlPath.Location = new System.Drawing.Point(18, 90);
            this.txtIndexHtmlPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIndexHtmlPath.Name = "txtIndexHtmlPath";
            this.txtIndexHtmlPath.Size = new System.Drawing.Size(444, 20);
            this.txtIndexHtmlPath.TabIndex = 4;
            this.txtIndexHtmlPath.Text = "C:\\inetpub\\epub\\index.html";
            // 
            // btnEpubsOutDir
            // 
            this.btnEpubsOutDir.Location = new System.Drawing.Point(464, 56);
            this.btnEpubsOutDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEpubsOutDir.Name = "btnEpubsOutDir";
            this.btnEpubsOutDir.Size = new System.Drawing.Size(66, 20);
            this.btnEpubsOutDir.TabIndex = 3;
            this.btnEpubsOutDir.Text = "Out. Dir";
            this.btnEpubsOutDir.UseVisualStyleBackColor = true;
            this.btnEpubsOutDir.Click += new System.EventHandler(this.btnEpubsOutDir_Click);
            // 
            // txtEpubsPath
            // 
            this.txtEpubsPath.Location = new System.Drawing.Point(18, 58);
            this.txtEpubsPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEpubsPath.Name = "txtEpubsPath";
            this.txtEpubsPath.Size = new System.Drawing.Size(444, 20);
            this.txtEpubsPath.TabIndex = 2;
            this.txtEpubsPath.Text = "C:\\inetpub\\iganjoor\\epub";
            // 
            // btnSelectXml
            // 
            this.btnSelectXml.Location = new System.Drawing.Point(464, 26);
            this.btnSelectXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectXml.Name = "btnSelectXml";
            this.btnSelectXml.Size = new System.Drawing.Size(66, 20);
            this.btnSelectXml.TabIndex = 1;
            this.btnSelectXml.Text = "XML";
            this.btnSelectXml.UseVisualStyleBackColor = true;
            this.btnSelectXml.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // txtXmlPath
            // 
            this.txtXmlPath.Location = new System.Drawing.Point(18, 28);
            this.txtXmlPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtXmlPath.Name = "txtXmlPath";
            this.txtXmlPath.Size = new System.Drawing.Size(444, 20);
            this.txtXmlPath.TabIndex = 0;
            this.txtXmlPath.Text = "C:\\inetpub\\iganjoor\\android\\androidgdbs.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 647);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblFTPUsername;
        private System.Windows.Forms.TextBox txtFTPHost;
        private System.Windows.Forms.Label lblFTPHost;
        private System.Windows.Forms.TextBox txtFTPRootPath;
        private System.Windows.Forms.Label lblFTPRootPath;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFTPUsername;
    }
}

