param($installPath, $toolsPath, $package, $project)

$annotationFile = Get-Item (Join-Path (Join-Path $installPath -ChildPath "content") -ChildPath "Common.Logging.Core.ExternalAnnotations.xml")
$packagesDirectory = (Get-Item $installPath).parent
$installPaths = Get-ChildItem $packagesDirectory.FullName -Directory | Where-Object { $_.Name -ilike "Common.Logging.Core.[3456789].*.*" }

foreach($installPath in $installPaths)
{
    $libPath = Get-Item (Join-Path $installPath.FullName -ChildPath "lib")

    if($libPath.Exists -eq $true) 
	{
		foreach($libFolderPath in (Get-ChildItem $libPath.FullName))
		{
            Copy-Item $annotationFile.FullName -Destination $libFolderPath.FullName -Force
		}
	}
}