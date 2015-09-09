param($installPath, $toolsPath, $package, $project)

$packagesDirectory = (Get-Item $installPath).parent
$installPaths = Get-ChildItem $packagesDirectory.FullName -Recurse -File | Where-Object { $_.Name -ieq "Common.Logging.Core.ExternalAnnotations.xml" -and $_.FullName -notlike "*Platypus.Common.Logging*" }

foreach($installPath in $installPaths)
{
    Remove-Item -Path $installPath.FullName -Force
}