This is a project template for making plugin-powered ContentPackages for LuaCsForBarotrauma. For more details,
visit the Wiki.


Quick Start Steps:

1. Download the Libraries and place them in /Refs as shown below.


You need to edit the Build.props file: 

<ModDeployDir>..\LUATRAMA_DEBUG_LOCALMODS_MYMODDIR\</ModDeployDir>

Replace "..\LUATRAMA_DEBUG_LOCALMODS_MYMODDIR\" with the directory of your mod in "Barotrauma/LocalMods/" 

<AssemblyName>MyModName</AssemblyName>

Replace "MyModName" with a valid assembly name, this should be similar to your mod name but does not need to match. This name should:
- Not include spaces.
- Not include special characters, periods are allowed.
- Use english characters.


2. Set the executable directory for the Launch Configurations (Client, Server).


3. Set your details (modname, files, etc) in Assets/filelist.xml
- Note: All files should be placed under "/Content" and will be copied automatically to "LocalMods/<YourMod>/Content/...".
your "filelist.xml" should list your mods' content files in the format of "%ModDir%/Content/..."
