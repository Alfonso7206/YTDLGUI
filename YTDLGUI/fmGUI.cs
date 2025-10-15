using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace YTDLGUI
{
    public partial class fmGUI : MaterialForm
    {
        Properties.Settings settings { get; } = Properties.Settings.Default;
        ListViewItem currentItem { get; set; }
        string listCounter { get; set; }
        DateTimeOffset updateTime { get; set; } = DateTimeOffset.Now;
        bool IsAbort { get; set; }
        private readonly MaterialSkinManager materialSkinManager;

        ImageList thumbnails = new ImageList();

        public fmGUI()
        {
            InitializeComponent();
            Text = "YTDLGUI 1.5";
            Icon = Properties.Resources.ICON;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Red900, Accent.DeepOrange700, TextShade.WHITE);
            listView.MouseClick += listView_MouseClick;
            thumbnails.ColorDepth = ColorDepth.Depth32Bit;
            thumbnails.ImageSize = new Size(220, 160);
            listView.LargeImageList = thumbnails;
            listView.View = View.Tile;
            listView.AllowDrop = true;
            listView.DragEnter += ListView_DragEnter;
            listView.DragDrop += ListView_DragDrop;
            //    listView.TileSize = new Size(500, 100);
        }
        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string data = e.Data.GetData(DataFormats.Text).ToString().Trim();
                AddUrlToList(data);
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var f in files)
                {
                    AddUrlToList(f);
                }
            }
        }
        private void AddUrlToList(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return;

            if (listView.Items.Cast<ListViewItem>().Any(x => (x.Tag as string) == url))
                return;
            var parameter = GetDownloadParameter(tabControl.SelectedIndex);
            var item = new ListViewItem(new string[]
            {
        url, "--", "--", "--", "--", "🔍 Reading...", $"{parameter} \"{url}\""
            });

            item.Tag = url; 
            listView.Items.Add(item);
            listView.EnsureVisible(listView.Items.Count - 1);

            _ = Task.Run(async () =>
            {
                var image = await GetThumbnailAsync(url);
                if (image != null)
                {
                    Invoke(new Action(() =>
                    {
                        thumbnails.Images.Add(url, image);
                        item.ImageKey = url;
                        listView.Refresh();
                    }));
                }
            });
        }

        private void fmGUI_Load(object sender, EventArgs e)
        {
            if (!Utils.CheckBinary())
            {
                var frm = new fmBinary();
                var result = frm.ShowDialog();
                if (result != DialogResult.OK)
                    Environment.Exit(0);
            }

            if (string.IsNullOrEmpty(settings.DownloadFolder))
                settings.DownloadFolder = Environment.CurrentDirectory;

            textFolder.Text = settings.DownloadFolder;
            textURL.Text = settings.Link;
            textArguments.Text = settings.ArgText;
            var vformat = settings.VidoeFormat;
            radioVDefault.Checked = vformat == (int)VideoFormat.Default;
            radioVMP4.Checked = vformat == (int)VideoFormat.MP4;
            radioVWebm.Checked = vformat == (int)VideoFormat.Webm;
            radioVOnly.Checked = vformat == (int)VideoFormat.Only;

            comboAFormat.SelectedIndex = settings.AudioFormat;
            comboAQuality.SelectedIndex = settings.AudioQuality;
            checkPlaylist.Checked = settings.IsPlaylist;
            checkMaxRes.Checked = settings.IsMaxResolution;
            comboMaxRes.SelectedIndex = settings.MaxResolution;
            checkLiveFromStart.Checked = settings.IsLiveFromStart;
        }

        private void fmGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.Link = textURL.Text;
            textURL.Text = settings.Link;
            settings.ArgText = textArguments.Text;
            textArguments.Text = settings.ArgText;
            settings.Save();
        }

        private void labelFolder_Click(object sender, EventArgs e)
        {
            Process.Start(textFolder.Text);
        }

        private void textFolder_MouseClick(object sender, MouseEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the folder where to save the downloaded files";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    settings.DownloadFolder = fbd.SelectedPath;
                    textFolder.Text = settings.DownloadFolder;
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                buttonDownload.Visible = false;
                buttonAbort.Visible = false;
                buttonClear.Visible = false;
            }
            else
            {
                buttonDownload.Visible = true;
                buttonAbort.Visible = true;
                buttonClear.Visible = true;
            }
        }

        private void radioVideoFormat_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (MaterialRadioButton)sender;
            settings.VidoeFormat = int.Parse(obj.Tag.ToString());
        }

        private void comboAFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = comboAFormat.SelectedIndex;
            comboAQuality.Enabled = Utils.QualityAdjustable(idx);
            settings.AudioFormat = idx;
        }

        private void comboAQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.AudioQuality = comboAQuality.SelectedIndex;
        }

        private void labelPlaylist_Click(object sender, EventArgs e)
        {
            checkPlaylist.Checked = !checkPlaylist.Checked;
            settings.IsPlaylist = checkPlaylist.Checked;
        }

        private void labelMaxRes_Click(object sender, EventArgs e)
        {
            checkMaxRes.Checked = !checkMaxRes.Checked;
        }

        private void checkMaxRes_CheckedChanged(object sender, EventArgs e)
        {
            comboMaxRes.Enabled = checkMaxRes.Checked;
            settings.IsMaxResolution = checkMaxRes.Checked;
        }

        private void comboMaxRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.MaxResolution = comboMaxRes.SelectedIndex;
        }

        private void labelLiveFromStart_Click(object sender, EventArgs e)
        {
            checkLiveFromStart.Checked = !checkLiveFromStart.Checked;
            settings.IsLiveFromStart = checkLiveFromStart.Checked;
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            File.Delete("yt-dlp.exe");
            File.Delete("ffmpeg.exe");
            File.Delete("ffprobe.exe");
            var GUIFile = Process.GetCurrentProcess().MainModule.FileName;
            try
            {
                var http = new HttpClient();
                var bytes = await http.GetByteArrayAsync(Utils.gui);
                File.Move(GUIFile, GUIFile + ".old");
                File.WriteAllBytes(GUIFile, bytes);
            }
            catch { }
            Process.Start(GUIFile);
            Environment.Exit(0);
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            IsAbort = true;
            var target = new string[] { "ffmpeg.exe", "ffprobe.exe", "yt-dlp.exe" };
            var plist = Process.GetProcesses().Where(p =>
            {
                try
                {
                    return p.MainModule.FileName.Contains(Environment.CurrentDirectory) &&
                           target.Contains(p.MainModule.ModuleName);
                }
                catch { return false; }
            }).ToArray();

            foreach (var p in plist)
            {
                try
                {
                    if (!p.HasExited) 
                        p.Kill();
                }
                catch
                {
  
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            var list = listView.Items.Cast<ListViewItem>().Where(x => string.IsNullOrEmpty(x.SubItems[6].Text)).ToList();
            foreach (var item in list)
            {
                listView.Items.Remove(item);
            }
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            var mode = tabControl.SelectedIndex;

            foreach (string url in textURL.Lines)
            {
                if (string.IsNullOrWhiteSpace(url))
                    continue;
                if (listView.Items.Cast<ListViewItem>().Any(x => x.SubItems[6].Text.Contains(url)))
                    continue;

                var parameter = GetDownloadParameter(mode);
                var item = new ListViewItem(new string[]
                {
    url, "--", "--", "--", "--", "🔍 Reading...", $"{parameter} \"{url}\""
                });
                item.Tag = url;

                _ = Task.Run(async () =>
                {
                    var image = await GetThumbnailAsync(url);
                    if (image != null)
                    {
                        Invoke(new Action(() =>
                        {
                            thumbnails.Images.Add(url, image);
                            item.ImageKey = url;
                            listView.Refresh();
                        }));
                    }
                });

                listView.Items.Add(item);
                listView.EnsureVisible(listView.Items.Count - 1);
            }

            buttonDownload.Enabled = false;

            foreach (ListViewItem item in listView.Items)
            {
                currentItem = item;
                var title = item.SubItems[0];
                var status = item.SubItems[5];
                var parameter = item.SubItems[6];

                if (string.IsNullOrEmpty(parameter.Text))
                    continue;

                buttonAbort.Enabled = true;
                listCounter = string.Empty;

                title.Text = await Task.Run(() => GetTitle(title.Text));

                await Task.Run(() => Download(parameter.Text));

                status.Text = "Done ✅";
                parameter.Text = null;
                currentItem = null;
                buttonAbort.Enabled = false;

                if (IsAbort)
                {
                    status.Text = "🚫 Abort";
                    IsAbort = false;
                    break;
                }
                listView.EnsureVisible(item.Index);
            }

            System.Media.SystemSounds.Asterisk.Play();
            buttonDownload.Enabled = true;
            try
            {
                string filePath = Path.Combine(settings.DownloadFolder, "download_list.txt");
                var completedItems = listView.Items
                    .Cast<ListViewItem>()
                    .Where(x => x.SubItems[5].Text.Contains("Done"))
                    .Select(x => new
                    {
                        Title = x.SubItems[0].Text.Trim(),
                        Url = (x.Tag as string)?.Trim()
                    })
                    .Where(x => !string.IsNullOrWhiteSpace(x.Url))
                    .ToList();

                if (!completedItems.Any())
                    return;
                var existingEntries = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath, Encoding.UTF8);
                    for (int i = 0; i < lines.Length - 1; i++)
                    {
                        string title = lines[i].Trim();
                        string url = lines[i + 1].Trim();
                        if (url.StartsWith("http"))
                            existingEntries.Add($"{title}\n{url}");
                    }
                }
                var newEntries = new List<string>();
                foreach (var item in completedItems)
                {
                    string entry = $"{item.Title}\n{item.Url}";
                    if (!existingEntries.Contains(entry))
                    {
                        existingEntries.Add(entry);
                        newEntries.Add(entry);
                    }
                }

                if (newEntries.Any())
                {
                    File.AppendAllText(filePath, "\n" + string.Join("\n\n", newEntries), Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving list:\n{ex.Message}",
                    "⛔ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDownloadParameter(int mode)
        {
            var sb = new StringBuilder();
            sb.Append("--encoding \"UTF-8\" --ignore-config --ignore-errors --progress-delta 0.5 ");
            sb.Append($"--concurrent-fragments {numUpDown_MT_fragment.Value} --retry-sleep fragment:1 ");
            sb.Append("--embed-metadata --embed-chapters ");

            if (!radioVWebm.Checked)
                sb.Append("--embed-thumbnail ");

            sb.Append(checkPlaylist.Checked ? "--yes-playlist " : "--no-playlist ");
            sb.Append(checkLiveFromStart.Checked ? "--live-from-start " : string.Empty);
            sb.Append($"-P \"{settings.DownloadFolder}\" -P \"temp:%TEMP%\" ");
            sb.Append($"-o \"%(title)s.%(ext)s\" -S \"res,vcodec:h264,hdr,vbr\" ");

            if (mode == 0) // video
            {
                if (radioVOnly.Checked)
                {
                    sb.Append("-f \"bestvideo\"");
                }
                else
                {
                    // Video + audio
                    sb.Append("-f \"bestvideo");

                    if (checkMaxRes.Checked)
                        sb.Append($"[height<={comboMaxRes.Text.Replace("p", "")}]");

                    if (radioVDefault.Checked)
                        sb.Append("+bestaudio");
                    else if (radioVMP4.Checked)
                        sb.Append("[vcodec^=avc]+ba[acodec^=mp4a]");
                    else if (radioVWebm.Checked)
                        sb.Append("[vcodec^=vp]+ba[acodec^=opus]");

                    sb.Append("\"");
                }
            }
            else if (mode == 1) // audio-only
            {
                sb.Append("-f \"bestaudio/best\" --extract-audio");
                sb.Append($" --audio-format {comboAFormat.Text}");
                sb.Append($" --audio-quality {(comboAQuality.Enabled ? comboAQuality.Text : "0")}");
            }

            if (!string.IsNullOrWhiteSpace(textArguments.Text))
            {
                sb.Append(" " + textArguments.Text.Trim());
            }

            return sb.ToString();
        }

        private string GetTitle(string url)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "yt-dlp.exe";
                p.StartInfo.Arguments = $"--encoding \"UTF-8\" --print title \"{url}\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                p.WaitForExit();
                return p.StandardOutput.ReadLine();
            }
        }

        private void Download(string parameter)
        {
            Debug.WriteLine($"yt-dlp.exe {parameter}");
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "yt-dlp.exe";
                p.StartInfo.Arguments = parameter;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.StartInfo.RedirectStandardOutput = true;
                p.OutputDataReceived += OutputDataReceived;
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
            }

            if (currentItem != null)
            {
                var folder = settings.DownloadFolder;
                if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
                {
                    MessageBox.Show("⚠️ Invalid download folder.");
                    return;
                }

                var titleText = currentItem.SubItems[0].Text;
                var filenamePattern = string.Join(" ", titleText.Split(' ').Skip(1));

                var invalidChars = Path.GetInvalidFileNameChars();
                filenamePattern = new string(filenamePattern.Where(c => !invalidChars.Contains(c)).ToArray());

                try
                {
                    var files = Directory.GetFiles(folder, $"*{filenamePattern}*");
                    if (files.Length > 0)
                    {
                        var fileInfo = new FileInfo(files[0]);
                        Invoke(new Action(() =>
                        {
                            currentItem.SubItems[1].Text = $"{fileInfo.Length / 1024.0 / 1024.0:F2} MB";
                        }));
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"❌ Error reading files: {ex.Message}");
                }
            }
        }

        private async void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            var text = e.Data;
            if (string.IsNullOrEmpty(text) || text.ToLower().Contains("unknown")) return;

            var title = currentItem.SubItems[0];
            var size = currentItem.SubItems[1];
            var progress = currentItem.SubItems[2];
            var speed = currentItem.SubItems[3];
            var ETA = currentItem.SubItems[4];
            var status = currentItem.SubItems[5];

            if (text.ToLower().Contains("extract") || text.ToLower().Contains("ffmpeg"))
            {
                Invoke(new Action(() =>
                {
                    status.Text = "👀 loading in progress...";
                    currentItem.EnsureVisible(); 
                }));
                return;
            }

            var _ = await Task.Run(() => Utils.ParseListCounter(text));
            if (_.success) listCounter = _.counter;

            if (!string.IsNullOrEmpty(listCounter))
            {
                var filename = await Task.Run(() => Utils.ParseFilename(text));
                if (!string.IsNullOrEmpty(filename))
                {
                    Invoke(new Action(() =>
                    {
                        title.Text = $"{listCounter} {filename}";
                        currentItem.EnsureVisible();
                    }));
                    return;
                }
            }

            if (Utils.DeltaTime(updateTime) > 200)
            {
                var result = await Task.Run(() => Utils.ParseProgress(text));
                if (!string.IsNullOrEmpty(result.progress))
                {
                    Invoke(new Action(() =>
                    {
                        progress.Text = result.progress;
                        size.Text = result.size;
                        speed.Text = result.speed;
                        ETA.Text = result.ETA;
                        status.Text = "⬇️ Download...";
                        currentItem.EnsureVisible();
                    }));
                }
                updateTime = DateTimeOffset.Now;
            }
        }
        private async Task<Image> GetThumbnailAsync(string urlOrId)
        {
            try
            {
                string id = null;
                if (!string.IsNullOrWhiteSpace(urlOrId) && urlOrId.Length == 11 && urlOrId.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                {
                    id = urlOrId;
                }
                else
                {
                    var uri = new Uri(urlOrId);
                    if (uri.Host.Contains("youtube.com"))
                    {
                        var query = System.Net.WebUtility.UrlDecode(uri.Query);
                        if (query.Contains("v="))
                        {
                            id = query.Split(new string[] { "v=" }, StringSplitOptions.None)[1]
                                      .Split('&')[0];
                        }
                    }
                    else if (uri.Host.Contains("youtu.be"))
                    {
                        id = uri.Segments.Last().Trim('/');
                    }
                }

                if (string.IsNullOrEmpty(id))
                    return null;

                string thumbUrl = $"https://img.youtube.com/vi/{id}/hqdefault.jpg";

                using (var http = new HttpClient())
                {
                    var imgBytes = await http.GetByteArrayAsync(thumbUrl);
                    using (var ms = new MemoryStream(imgBytes))
                        return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        private async void buttonUpdateYTDL_Click(object sender, EventArgs e)
        {
            buttonUpdateYTDL.Enabled = false;
            buttonUpdateYTDL.Text = "🔄 Updating...";

            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = "yt-dlp.exe";
                    p.StartInfo.Arguments = "-U";      
                    p.StartInfo.CreateNoWindow = true;  
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;

                    var output = new StringBuilder();

                    p.OutputDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                            output.AppendLine(ev.Data);
                    };
                    p.ErrorDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                            output.AppendLine(ev.Data);
                    };

                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();

                    await Task.Run(() => p.WaitForExit());

                    MessageBox.Show("yt-dlp update completed!\n\n" + output.ToString(), "🛈 Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during update:\n{ex.Message}", "❌ Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonUpdateYTDL.Enabled = true;
                buttonUpdateYTDL.Text = "🔄 Update yt-dlp";
            }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText().Trim();
            string urlPattern = @"^(https?://)?([\w\-]+\.)+[\w\-]+(/[\w\-./?%&=]*)?$";
            string youtubePattern = @"^[\w\-]{11}$";

            if (Regex.IsMatch(clipboardText, urlPattern) || Regex.IsMatch(clipboardText, youtubePattern))
            {
                textURL.Text = clipboardText;
            }
            else
            {
            }
        }
        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            var info = listView.HitTest(e.Location);
            if (info.Item != null)
            {
                string url = info.Item.Tag as string;

                if (string.IsNullOrWhiteSpace(url))
                {
                    if (info.Item.SubItems.Count > 6)
                    {
                        string param = info.Item.SubItems[6].Text;
                        var match = Regex.Match(param, "\"(https?://[^\"]+)\"");
                        if (match.Success)
                            url = match.Groups[1].Value;
                    }
                }

                if (!string.IsNullOrWhiteSpace(url))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"⚠️ Unable to open link:\n{ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonClearLink_Click(object sender, EventArgs e)
        {
            textURL.Clear();
        }

        private void radioVOnly_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (MaterialRadioButton)sender;
            settings.VidoeFormat = int.Parse(obj.Tag.ToString());
        }

        private void buttonArguments_Click(object sender, EventArgs e)
        {
            textArguments.Clear();
        }

        private void textFolder_TextChanged(object sender, EventArgs e)
        {

        }
    }

}