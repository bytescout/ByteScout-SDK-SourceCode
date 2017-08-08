** How to setup the registration free deployment in your project **

1. Right-click your project in the solution tree, select 'Add'->'Existing Items...' menu item and add "app.manifest" file.

2. Open the project properties. On the Application tab select "app.manifest" in "Manifest" combo-box. 
   Now when you build the project the manifest will embedded into the assembly resources.

   * Alternative way *
   Rename the added "app.manifest" into "YourAssemblyName.exe.manifest".
   In the file's properties set "Copy to Output Directory" to "Copy always".
   Now the file will be copied to the output folder automatically and the manifest will be loaded from 
   the file instead of resources.

3. Right-click your project in the solution tree, select 'Add'->'Existing Items...' menu item and add 
   "ByteScoutScreenCapturing.dll", "ByteScoutScreenCapturingFilter.dll" and "ByteScoutVideoMixerFilter.dll" files.
   Set "Copy to Output Directory" property to "Copy always" for the each file.
   * You can find these files in "Redistributable" folder of the SDK installation directory.
   (Default location: "c:\Program Files\ByteScout Screen Capturing SDK\Redistributable").

4. Clean and rebuild your project.
