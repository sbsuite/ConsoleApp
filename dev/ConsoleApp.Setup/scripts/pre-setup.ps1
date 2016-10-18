$fragments = Get-ChildItem $env:APPVEYOR_BUILD_FOLDER\packages -Filter *.wxs -Recurse | %{$_.FullName}
foreach($fragment in $fragments)
{
    Copy-Item $fragment  $env:APPVEYOR_BUILD_FOLDER\dev\ConsoleApp.Setup\fragments
}