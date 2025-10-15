namespace YTDLGUI
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmGUI));
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.radioVOnly = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioVWebm = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioVMP4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioVDefault = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.comboAQuality = new System.Windows.Forms.ComboBox();
            this.comboAFormat = new System.Windows.Forms.ComboBox();
            this.labelAQuality = new System.Windows.Forms.Label();
            this.labelAFormat = new System.Windows.Forms.Label();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.buttonUpdateYTDL = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelLiveFromStart = new System.Windows.Forms.Label();
            this.checkLiveFromStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.numUpDown_MT_fragment = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboMaxRes = new System.Windows.Forms.ComboBox();
            this.labelMaxRes = new System.Windows.Forms.Label();
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.checkMaxRes = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkPlaylist = new MaterialSkin.Controls.MaterialCheckBox();
            this.textURL = new System.Windows.Forms.TextBox();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAbort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonDownload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonPaste = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonClearLink = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textArguments = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonArguments = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.tabAudio.SuspendLayout();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_MT_fragment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(475, 67);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(317, 30);
            this.tabSelector.TabIndex = 2;
            this.tabSelector.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVideo);
            this.tabControl.Controls.Add(this.tabAudio);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(475, 103);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(317, 249);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabVideo
            // 
            this.tabVideo.BackColor = System.Drawing.Color.White;
            this.tabVideo.Controls.Add(this.radioVOnly);
            this.tabVideo.Controls.Add(this.radioVWebm);
            this.tabVideo.Controls.Add(this.radioVMP4);
            this.tabVideo.Controls.Add(this.radioVDefault);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(309, 223);
            this.tabVideo.TabIndex = 0;
            this.tabVideo.Text = "📽 VIDEO";
            // 
            // radioVOnly
            // 
            this.radioVOnly.AutoSize = true;
            this.radioVOnly.Depth = 0;
            this.radioVOnly.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioVOnly.Location = new System.Drawing.Point(11, 118);
            this.radioVOnly.Margin = new System.Windows.Forms.Padding(0);
            this.radioVOnly.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioVOnly.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioVOnly.Name = "radioVOnly";
            this.radioVOnly.Ripple = true;
            this.radioVOnly.Size = new System.Drawing.Size(95, 30);
            this.radioVOnly.TabIndex = 3;
            this.radioVOnly.TabStop = true;
            this.radioVOnly.Tag = "3";
            this.radioVOnly.Text = "Only Video";
            this.radioVOnly.UseVisualStyleBackColor = true;
            this.radioVOnly.CheckedChanged += new System.EventHandler(this.radioVOnly_CheckedChanged);
            // 
            // radioVWebm
            // 
            this.radioVWebm.AutoSize = true;
            this.radioVWebm.Depth = 0;
            this.radioVWebm.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioVWebm.Location = new System.Drawing.Point(11, 79);
            this.radioVWebm.Margin = new System.Windows.Forms.Padding(0);
            this.radioVWebm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioVWebm.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioVWebm.Name = "radioVWebm";
            this.radioVWebm.Ripple = true;
            this.radioVWebm.Size = new System.Drawing.Size(161, 30);
            this.radioVWebm.TabIndex = 2;
            this.radioVWebm.TabStop = true;
            this.radioVWebm.Tag = "2";
            this.radioVWebm.Text = "Webm [webm + opus]";
            this.radioVWebm.UseVisualStyleBackColor = true;
            this.radioVWebm.CheckedChanged += new System.EventHandler(this.radioVideoFormat_CheckedChanged);
            // 
            // radioVMP4
            // 
            this.radioVMP4.AutoSize = true;
            this.radioVMP4.Depth = 0;
            this.radioVMP4.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioVMP4.Location = new System.Drawing.Point(11, 41);
            this.radioVMP4.Margin = new System.Windows.Forms.Padding(0);
            this.radioVMP4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioVMP4.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioVMP4.Name = "radioVMP4";
            this.radioVMP4.Ripple = true;
            this.radioVMP4.Size = new System.Drawing.Size(136, 30);
            this.radioVMP4.TabIndex = 1;
            this.radioVMP4.TabStop = true;
            this.radioVMP4.Tag = "1";
            this.radioVMP4.Text = "MP4 [h264 + aac]";
            this.radioVMP4.UseVisualStyleBackColor = true;
            this.radioVMP4.CheckedChanged += new System.EventHandler(this.radioVideoFormat_CheckedChanged);
            // 
            // radioVDefault
            // 
            this.radioVDefault.AutoSize = true;
            this.radioVDefault.Checked = true;
            this.radioVDefault.Depth = 0;
            this.radioVDefault.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioVDefault.Location = new System.Drawing.Point(11, 3);
            this.radioVDefault.Margin = new System.Windows.Forms.Padding(0);
            this.radioVDefault.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioVDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioVDefault.Name = "radioVDefault";
            this.radioVDefault.Ripple = true;
            this.radioVDefault.Size = new System.Drawing.Size(73, 30);
            this.radioVDefault.TabIndex = 0;
            this.radioVDefault.TabStop = true;
            this.radioVDefault.Tag = "0";
            this.radioVDefault.Text = "Default";
            this.radioVDefault.UseVisualStyleBackColor = true;
            this.radioVDefault.CheckedChanged += new System.EventHandler(this.radioVideoFormat_CheckedChanged);
            // 
            // tabAudio
            // 
            this.tabAudio.BackColor = System.Drawing.Color.White;
            this.tabAudio.Controls.Add(this.comboAQuality);
            this.tabAudio.Controls.Add(this.comboAFormat);
            this.tabAudio.Controls.Add(this.labelAQuality);
            this.tabAudio.Controls.Add(this.labelAFormat);
            this.tabAudio.Location = new System.Drawing.Point(4, 22);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(309, 203);
            this.tabAudio.TabIndex = 1;
            this.tabAudio.Text = "🎵 AUDIO";
            // 
            // comboAQuality
            // 
            this.comboAQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAQuality.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAQuality.FormattingEnabled = true;
            this.comboAQuality.Items.AddRange(new object[] {
            "96K",
            "128K",
            "192K",
            "256K",
            "320K"});
            this.comboAQuality.Location = new System.Drawing.Point(93, 49);
            this.comboAQuality.Name = "comboAQuality";
            this.comboAQuality.Size = new System.Drawing.Size(121, 29);
            this.comboAQuality.TabIndex = 11;
            this.comboAQuality.SelectedIndexChanged += new System.EventHandler(this.comboAQuality_SelectedIndexChanged);
            // 
            // comboAFormat
            // 
            this.comboAFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAFormat.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAFormat.FormattingEnabled = true;
            this.comboAFormat.Items.AddRange(new object[] {
            "best",
            "m4a",
            "mp3",
            "vorbis",
            "flac",
            "wav"});
            this.comboAFormat.Location = new System.Drawing.Point(93, 6);
            this.comboAFormat.Name = "comboAFormat";
            this.comboAFormat.Size = new System.Drawing.Size(121, 29);
            this.comboAFormat.TabIndex = 10;
            this.comboAFormat.SelectedIndexChanged += new System.EventHandler(this.comboAFormat_SelectedIndexChanged);
            // 
            // labelAQuality
            // 
            this.labelAQuality.AutoSize = true;
            this.labelAQuality.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAQuality.Location = new System.Drawing.Point(14, 52);
            this.labelAQuality.Name = "labelAQuality";
            this.labelAQuality.Size = new System.Drawing.Size(59, 21);
            this.labelAQuality.TabIndex = 9;
            this.labelAQuality.Text = "Quality:";
            // 
            // labelAFormat
            // 
            this.labelAFormat.AutoSize = true;
            this.labelAFormat.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAFormat.Location = new System.Drawing.Point(14, 9);
            this.labelAFormat.Name = "labelAFormat";
            this.labelAFormat.Size = new System.Drawing.Size(56, 21);
            this.labelAFormat.TabIndex = 8;
            this.labelAFormat.Text = "Format:";
            // 
            // tabOptions
            // 
            this.tabOptions.BackColor = System.Drawing.Color.White;
            this.tabOptions.Controls.Add(this.buttonUpdateYTDL);
            this.tabOptions.Controls.Add(this.labelLiveFromStart);
            this.tabOptions.Controls.Add(this.checkLiveFromStart);
            this.tabOptions.Controls.Add(this.numUpDown_MT_fragment);
            this.tabOptions.Controls.Add(this.label1);
            this.tabOptions.Controls.Add(this.buttonUpdate);
            this.tabOptions.Controls.Add(this.comboMaxRes);
            this.tabOptions.Controls.Add(this.labelMaxRes);
            this.tabOptions.Controls.Add(this.labelPlaylist);
            this.tabOptions.Controls.Add(this.checkMaxRes);
            this.tabOptions.Controls.Add(this.checkPlaylist);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(309, 203);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "⚙️ OPTION";
            // 
            // buttonUpdateYTDL
            // 
            this.buttonUpdateYTDL.AutoSize = true;
            this.buttonUpdateYTDL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdateYTDL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateYTDL.Depth = 0;
            this.buttonUpdateYTDL.Icon = null;
            this.buttonUpdateYTDL.Location = new System.Drawing.Point(170, 161);
            this.buttonUpdateYTDL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUpdateYTDL.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdateYTDL.Name = "buttonUpdateYTDL";
            this.buttonUpdateYTDL.Primary = true;
            this.buttonUpdateYTDL.Size = new System.Drawing.Size(123, 36);
            this.buttonUpdateYTDL.TabIndex = 11;
            this.buttonUpdateYTDL.Text = "update yt-dlp";
            this.buttonUpdateYTDL.UseVisualStyleBackColor = true;
            this.buttonUpdateYTDL.Click += new System.EventHandler(this.buttonUpdateYTDL_Click);
            // 
            // labelLiveFromStart
            // 
            this.labelLiveFromStart.AutoSize = true;
            this.labelLiveFromStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLiveFromStart.Font = new System.Drawing.Font("Saira SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiveFromStart.Location = new System.Drawing.Point(37, 116);
            this.labelLiveFromStart.Name = "labelLiveFromStart";
            this.labelLiveFromStart.Size = new System.Drawing.Size(260, 19);
            this.labelLiveFromStart.TabIndex = 10;
            this.labelLiveFromStart.Text = "Download the full live stream (YouTube Only)";
            this.labelLiveFromStart.Click += new System.EventHandler(this.labelLiveFromStart_Click);
            // 
            // checkLiveFromStart
            // 
            this.checkLiveFromStart.AutoSize = true;
            this.checkLiveFromStart.Depth = 0;
            this.checkLiveFromStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkLiveFromStart.Location = new System.Drawing.Point(4, 110);
            this.checkLiveFromStart.Margin = new System.Windows.Forms.Padding(0);
            this.checkLiveFromStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkLiveFromStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkLiveFromStart.Name = "checkLiveFromStart";
            this.checkLiveFromStart.Ripple = true;
            this.checkLiveFromStart.Size = new System.Drawing.Size(26, 30);
            this.checkLiveFromStart.TabIndex = 9;
            this.checkLiveFromStart.UseVisualStyleBackColor = true;
            // 
            // numUpDown_MT_fragment
            // 
            this.numUpDown_MT_fragment.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_MT_fragment.Location = new System.Drawing.Point(241, 73);
            this.numUpDown_MT_fragment.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_MT_fragment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_MT_fragment.Name = "numUpDown_MT_fragment";
            this.numUpDown_MT_fragment.Size = new System.Drawing.Size(40, 28);
            this.numUpDown_MT_fragment.TabIndex = 8;
            this.numUpDown_MT_fragment.TabStop = false;
            this.numUpDown_MT_fragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_MT_fragment.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Multi-threaded shard download";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.Icon = null;
            this.buttonUpdate.Location = new System.Drawing.Point(4, 162);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Primary = true;
            this.buttonUpdate.Size = new System.Drawing.Size(125, 36);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "update binary";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboMaxRes
            // 
            this.comboMaxRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaxRes.Enabled = false;
            this.comboMaxRes.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaxRes.FormattingEnabled = true;
            this.comboMaxRes.Items.AddRange(new object[] {
            "360p",
            "480p",
            "720p",
            "1080p",
            "1440p",
            "2160p",
            "4320p"});
            this.comboMaxRes.Location = new System.Drawing.Point(160, 37);
            this.comboMaxRes.Name = "comboMaxRes";
            this.comboMaxRes.Size = new System.Drawing.Size(121, 29);
            this.comboMaxRes.TabIndex = 4;
            this.comboMaxRes.SelectedIndexChanged += new System.EventHandler(this.comboMaxRes_SelectedIndexChanged);
            // 
            // labelMaxRes
            // 
            this.labelMaxRes.AutoSize = true;
            this.labelMaxRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMaxRes.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxRes.Location = new System.Drawing.Point(37, 41);
            this.labelMaxRes.Name = "labelMaxRes";
            this.labelMaxRes.Size = new System.Drawing.Size(70, 21);
            this.labelMaxRes.TabIndex = 3;
            this.labelMaxRes.Text = "Video Res";
            this.labelMaxRes.Click += new System.EventHandler(this.labelMaxRes_Click);
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.AutoSize = true;
            this.labelPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlaylist.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylist.Location = new System.Drawing.Point(37, 7);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(56, 21);
            this.labelPlaylist.TabIndex = 2;
            this.labelPlaylist.Text = "Playlist";
            this.labelPlaylist.Click += new System.EventHandler(this.labelPlaylist_Click);
            // 
            // checkMaxRes
            // 
            this.checkMaxRes.AutoSize = true;
            this.checkMaxRes.Depth = 0;
            this.checkMaxRes.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkMaxRes.Location = new System.Drawing.Point(4, 36);
            this.checkMaxRes.Margin = new System.Windows.Forms.Padding(0);
            this.checkMaxRes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkMaxRes.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkMaxRes.Name = "checkMaxRes";
            this.checkMaxRes.Ripple = true;
            this.checkMaxRes.Size = new System.Drawing.Size(26, 30);
            this.checkMaxRes.TabIndex = 1;
            this.checkMaxRes.UseVisualStyleBackColor = true;
            this.checkMaxRes.CheckedChanged += new System.EventHandler(this.checkMaxRes_CheckedChanged);
            // 
            // checkPlaylist
            // 
            this.checkPlaylist.AutoSize = true;
            this.checkPlaylist.Depth = 0;
            this.checkPlaylist.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkPlaylist.Location = new System.Drawing.Point(4, 3);
            this.checkPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.checkPlaylist.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPlaylist.Name = "checkPlaylist";
            this.checkPlaylist.Ripple = true;
            this.checkPlaylist.Size = new System.Drawing.Size(26, 30);
            this.checkPlaylist.TabIndex = 0;
            this.checkPlaylist.UseVisualStyleBackColor = true;
            // 
            // textURL
            // 
            this.textURL.BackColor = System.Drawing.Color.White;
            this.textURL.Font = new System.Drawing.Font("Saira", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textURL.ForeColor = System.Drawing.Color.Black;
            this.textURL.Location = new System.Drawing.Point(3, 67);
            this.textURL.Multiline = true;
            this.textURL.Name = "textURL";
            this.textURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textURL.Size = new System.Drawing.Size(466, 160);
            this.textURL.TabIndex = 4;
            // 
            // textFolder
            // 
            this.textFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textFolder.Font = new System.Drawing.Font("Saira", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFolder.Location = new System.Drawing.Point(3, 306);
            this.textFolder.Name = "textFolder";
            this.textFolder.ReadOnly = true;
            this.textFolder.Size = new System.Drawing.Size(466, 26);
            this.textFolder.TabIndex = 5;
            this.textFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textFolder_MouseClick);
            this.textFolder.TextChanged += new System.EventHandler(this.textFolder_TextChanged);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.BackColor = System.Drawing.Color.Transparent;
            this.labelFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFolder.Font = new System.Drawing.Font("Saira SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolder.ForeColor = System.Drawing.Color.Firebrick;
            this.labelFolder.Location = new System.Drawing.Point(3, 276);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(153, 21);
            this.labelFolder.TabIndex = 6;
            this.labelFolder.Text = "Download Location (On)";
            this.labelFolder.Click += new System.EventHandler(this.labelFolder_Click);
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colSize,
            this.colProgress,
            this.colSpeed,
            this.colEta,
            this.colStatus});
            this.listView.Font = new System.Drawing.Font("Saira Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 354);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(789, 186);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colTitle
            // 
            this.colTitle.Text = "📝Title";
            this.colTitle.Width = 370;
            // 
            // colSize
            // 
            this.colSize.Text = "⛶ Size";
            this.colSize.Width = 80;
            // 
            // colProgress
            // 
            this.colProgress.Text = "🏃Progress";
            this.colProgress.Width = 90;
            // 
            // colSpeed
            // 
            this.colSpeed.Text = "🚀 Speed";
            this.colSpeed.Width = 75;
            // 
            // colEta
            // 
            this.colEta.Text = "🕑 Eta";
            this.colEta.Width = 70;
            // 
            // colStatus
            // 
            this.colStatus.Text = "🌀 Status";
            this.colStatus.Width = 80;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Depth = 0;
            this.buttonClear.Icon = global::YTDLGUI.Properties.Resources.clear;
            this.buttonClear.Location = new System.Drawing.Point(700, 300);
            this.buttonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Primary = true;
            this.buttonClear.Size = new System.Drawing.Size(91, 36);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.AutoSize = true;
            this.buttonAbort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbort.Depth = 0;
            this.buttonAbort.Enabled = false;
            this.buttonAbort.Icon = global::YTDLGUI.Properties.Resources.abort;
            this.buttonAbort.Location = new System.Drawing.Point(607, 300);
            this.buttonAbort.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Primary = true;
            this.buttonAbort.Size = new System.Drawing.Size(93, 36);
            this.buttonAbort.TabIndex = 9;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.AutoSize = true;
            this.buttonDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownload.Depth = 0;
            this.buttonDownload.Icon = global::YTDLGUI.Properties.Resources.download;
            this.buttonDownload.Location = new System.Drawing.Point(483, 300);
            this.buttonDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Primary = true;
            this.buttonDownload.Size = new System.Drawing.Size(124, 36);
            this.buttonDownload.TabIndex = 8;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.AutoSize = true;
            this.buttonPaste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPaste.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPaste.Depth = 0;
            this.buttonPaste.Icon = null;
            this.buttonPaste.Location = new System.Drawing.Point(406, 263);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPaste.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Primary = false;
            this.buttonPaste.Size = new System.Drawing.Size(63, 36);
            this.buttonPaste.TabIndex = 11;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = false;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonClearLink
            // 
            this.buttonClearLink.AutoSize = true;
            this.buttonClearLink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClearLink.Depth = 0;
            this.buttonClearLink.Icon = null;
            this.buttonClearLink.Location = new System.Drawing.Point(302, 263);
            this.buttonClearLink.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClearLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClearLink.Name = "buttonClearLink";
            this.buttonClearLink.Primary = false;
            this.buttonClearLink.Size = new System.Drawing.Size(96, 36);
            this.buttonClearLink.TabIndex = 12;
            this.buttonClearLink.Text = "clear link";
            this.buttonClearLink.UseVisualStyleBackColor = true;
            this.buttonClearLink.Click += new System.EventHandler(this.buttonClearLink_Click);
            // 
            // textArguments
            // 
            this.textArguments.BackColor = System.Drawing.Color.White;
            this.textArguments.Depth = 0;
            this.textArguments.Font = new System.Drawing.Font("Saira", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArguments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textArguments.Hint = "add argument ex: --extractor-args \"youtube:player-client=default\"";
            this.textArguments.Location = new System.Drawing.Point(3, 233);
            this.textArguments.MaxLength = 32767;
            this.textArguments.MouseState = MaterialSkin.MouseState.HOVER;
            this.textArguments.Name = "textArguments";
            this.textArguments.PasswordChar = '\0';
            this.textArguments.SelectedText = "";
            this.textArguments.SelectionLength = 0;
            this.textArguments.SelectionStart = 0;
            this.textArguments.Size = new System.Drawing.Size(466, 23);
            this.textArguments.TabIndex = 14;
            this.textArguments.TabStop = false;
            this.textArguments.UseSystemPasswordChar = false;
            // 
            // buttonArguments
            // 
            this.buttonArguments.AutoSize = true;
            this.buttonArguments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonArguments.Depth = 0;
            this.buttonArguments.Icon = null;
            this.buttonArguments.Location = new System.Drawing.Point(201, 263);
            this.buttonArguments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonArguments.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonArguments.Name = "buttonArguments";
            this.buttonArguments.Primary = false;
            this.buttonArguments.Size = new System.Drawing.Size(93, 36);
            this.buttonArguments.TabIndex = 15;
            this.buttonArguments.Text = "clear arg";
            this.buttonArguments.UseVisualStyleBackColor = true;
            this.buttonArguments.Click += new System.EventHandler(this.buttonArguments_Click);
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(795, 543);
            this.Controls.Add(this.buttonArguments);
            this.Controls.Add(this.textArguments);
            this.Controls.Add(this.buttonClearLink);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tabSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmGUI";
            this.Opacity = 0.99D;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmGUI_FormClosed);
            this.Load += new System.EventHandler(this.fmGUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            this.tabVideo.PerformLayout();
            this.tabAudio.ResumeLayout(false);
            this.tabAudio.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_MT_fragment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.ListView listView;
        private MaterialSkin.Controls.MaterialRadioButton radioVDefault;
        private MaterialSkin.Controls.MaterialRadioButton radioVWebm;
        private MaterialSkin.Controls.MaterialRadioButton radioVMP4;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colProgress;
        private System.Windows.Forms.ColumnHeader colSpeed;
        private System.Windows.Forms.ColumnHeader colEta;
        private System.Windows.Forms.ColumnHeader colStatus;
        private MaterialSkin.Controls.MaterialCheckBox checkPlaylist;
        private MaterialSkin.Controls.MaterialCheckBox checkMaxRes;
        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.Label labelMaxRes;
        private System.Windows.Forms.ComboBox comboMaxRes;
        private System.Windows.Forms.Label labelAFormat;
        private System.Windows.Forms.Label labelAQuality;
        private System.Windows.Forms.ComboBox comboAFormat;
        private System.Windows.Forms.ComboBox comboAQuality;
        private MaterialSkin.Controls.MaterialRaisedButton buttonDownload;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAbort;
        private MaterialSkin.Controls.MaterialRaisedButton buttonClear;
        private MaterialSkin.Controls.MaterialFlatButton buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDown_MT_fragment;
        private System.Windows.Forms.Label labelLiveFromStart;
        private MaterialSkin.Controls.MaterialCheckBox checkLiveFromStart;
        private MaterialSkin.Controls.MaterialFlatButton buttonUpdateYTDL;
        private MaterialSkin.Controls.MaterialFlatButton buttonPaste;
        private MaterialSkin.Controls.MaterialFlatButton buttonClearLink;
        private MaterialSkin.Controls.MaterialRadioButton radioVOnly;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textArguments;
        private MaterialSkin.Controls.MaterialFlatButton buttonArguments;
    }
}

