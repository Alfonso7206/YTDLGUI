# YTDLGUI 1.4 Demo Image
![cover](https://i.imgur.com/kiIy7Ig.png)

[sabpprook](https://github.com/sabpprook/YTDLGUI)

# YTDLGUI 1.5 Demo Image
<img width="795" height="520" alt="YTDLGUI_sbG8wfns6K" src="https://github.com/user-attachments/assets/26c405d9-400b-4bb5-8efa-d8e50fb047bf" />

# YTDLGUI 1.4

## Video Download
* Download Mode

* Default: Default download mode with no parameters [MKV]
* MP4: Optimal video and audio download mode; Format: [H264] + [AAC]
* Webm: Optimal video and audio download mode; Format: [VP9] + [Opus]

## Audio Download
* Conversion Format

* best: Simply separates the audio file, no secondary conversion
* m4a: Lossy format; bitrate is determined by the converted audio quality
* mp3: Lossy format; bitrate is determined by the converted audio quality
* vorbis : Lossy format; bit rate refers to the converted audio quality.
* flac: Lossless format
* wav: Lossless format

* Converted audio quality

* Fixed Bitrate: 96 ~ 320Kbps

## Available Options
* Download Playlist: Playlist parsing is disabled by default

* On: No playlist
* Off: Download playlist

* Maximum Video Resolution: Limits the video download resolution

* 360P: 640 x 360
* 480P: 848 x 480
* 720P: 1280 x 720
* 1080P: 1920 x 1080
* 1440P: 2160 x 1440
* 2160P: 3840 x 2160
* 4320P: 7680 x 4320

* Multi-part Download: Handles m3u8/MPD Download multiple segments simultaneously
* Download the entire live stream: Supported only for YouTube
## Language
* Chinese

## Updates and changes Version 1.5
<img width="665" height="351" alt="explorer_CkiXUPPnCs" src="https://github.com/user-attachments/assets/04c4f988-06b6-4daa-9faf-42b368b0d533" />


* edit listview and add thumbnail
* added drag n drop (links can be dragged from the browser to the list)
* added click on thumbnail to open link
* added textbox for yt-dlp arguments
* added paste and clear link buttons, arguments
* added automatic saving of downloaded links
* added button that updates yt-dlp
* added radio button to download only videos at max resolution (MP4)
* Changed the ffmpeg binary download link from version 6.1 to version 8
* fixed theme that was previously missing code
* Fixed the issue where the download only showed the ffmpeg size, now it shows the correct final size
* Fixed many form manipulation bugs, now works even if you make closing errors etc.
* removed obsolete code
* various changes such as fonts etc.
* translated into English - Language ENG

  ### extract packages to root program folder
  <img width="600" height="300" alt="explorer_CkiXUPPnCs" src="https://github.com/user-attachments/assets/65ff920d-1091-4a6b-933b-6614dd038b98" />

  ### compiled with Visual Studio Insider 2026

