
#define MyAppName "YTDLPGUI"
#define MyAppVersion "1.5"
#define MyAppPublisher "https://github.com/sabpprook/YTDLGUI"
#define MyAppURL "https://github.com/Alfonso7206/YTDLGUI"
#define MyAppExeName "YTDLGUI.exe"

[Setup]
AppId={{0154CC5E-80D1-4EB9-9174-F8CAE0358E85}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
DisableProgramGroupPage=yes
InfoBeforeFile=readme.txt
OutputDir=.
OutputBaseFilename=setup_{#MyAppName}_v{#MyAppVersion}
SetupIconFile=YTDLGUI\Resources\favicon.ico
SolidCompression=yes
WizardStyle=modern
InternalCompressLevel = ultra64
compression = lzma2/Ultra64

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; 

[Files]
Source: "YTDLGUI\bin\Debug\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\Costura.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\Costura.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\Costura.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\MaterialSkin.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Diagnostics.DiagnosticSource.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\YTDLGUI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "YTDLGUI\bin\Debug\YTDLGUI.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon


