1. Copy app.manifest into the project folder 

2. Then in Visual Studio click on the project name
- select Application tab
- Find "Resources" section
- click on "Manifest" combobox and select "app.manifest"
- Save project

Now when you are building the project the Visual Studio will embed app.manifest into the EXE file's resources.

2. (Alternative)
- copy "app.manifest" into "YourProjectName.exe.manfest" file
- copy this "YourProjectName.exe.manfest" into bin\debug and bin\release folders

This way YourProjectName.exe will load manifest from YourProjectName.exe.manifest file instead of resources

3. Build you project in Visual Studio
4. Now you need to put DLL files into the same folder with your EXE and manifest so DLLs will be loaded from files directly
- Copy ByteScoutScreenCapturing.dll into \bin\Debug and \bin\Release folders
- Copy ByteScoutScreenCapturingFilter.dll into \bin\Debug and \bin\Release folders
- Copy ByteScoutVideoMixerFilter.dll into \bin\Debug and \bin\Release folders

You may find these files in \Redistributable\ folder of the SDK installed (c:\program files\ByteScout Screen Capturing SDK\Redistributable
)