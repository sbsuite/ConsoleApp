$fragments = Get-ChildItem $env:APPVEYOR_BUILD_FOLDER\packages -Filter *.wxs -Recurse | %{$_.FullName}
foreach($fragment in $fragments)
{
    Copy-Item $fragment  C:\dev\Bayer\ConsoleApp\dev\ConsoleApp.Setup\fragments
}