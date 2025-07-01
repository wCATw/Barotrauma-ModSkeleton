# ModSkeleton

This is a project template for creating assembly-based Barotrauma mods using Luatrauma (LuaCsForBarotrauma).

## Quick Start

### Download LuaCsForBarotrauma Refs

Download the reference libraries from: https://github.com/evilfactory/LuaCsForBarotrauma/releases/download/latest/luacsforbarotrauma_refs.zip

Extract the contents into the "Refs" folder in this project.

### Configure Build.props

Make a copy of `Build.props.example` and rename it to `Build.props`.

Then edit `Build.props` to set the deployment path and assembly name.

ModDeployDir:
- Must point to your mod's folder under Barotrauma/LocalMods
- Must end with a backslash "\"

AssemblyName:
- Should not contain spaces or special characters (periods "." are allowed)
- Use only English letters and numbers
- Must match the name of the solution (.sln) file

## Documentation

See the LuaCsForBarotrauma wiki for scripting reference and advanced usage:

https://github.com/evilfactory/LuaCsForBarotrauma/wiki
https://luatrauma.github.io/Luatrauma.Docs/cs/introduction/

## Troubleshooting

If the mod does not appear in Barotrauma:
- Check that ModDeployDir in Build.props is correct
- Make sure all content files are listed in filelist.xml
- Verify the build completes without errors
- Make sure all your refs are properly included in your .csproj file

After some LuaCsForBarotrauma updates, DLL files may be replaced or renamed.  
For example, your mod might reference `MonoMod.Common`, while the game and refs now use `MonoMod.Utils`.  
Always double-check that your references match the latest files from the luacsforbarotrauma_refs.zip archive.
