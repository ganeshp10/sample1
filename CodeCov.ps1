param(
    [string]$openCoverExe,
    [string]$codeCovExe,
    [string]$testDir,
    [string]$token
)

#Run code coverage tests to generate report
$vstest = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe"
$calcTests = "{0}\{1}" -f $testDir, "CalculatorTests.dll"
& $openCoverExe -register:path32 -target:"$vstest" -targetargs:"$calcTests /TestCaseFilter:FullyQualifiedName~UnitTest /logger:trx" -filter:"+[Calculator*]* -[*Tests]* -[*TestFramework*]*" -hideskipped:All -output:.\coverage.xml

#On the Agent box repo is in a detached state. So get branchName by commit hash
$lastCommit = $(git rev-parse HEAD)
Write-Host "Last commit: " $lastCommit

$branchNames = $(git branch --all --contains $lastCommit) 
Write-Host "All branches that have this commit: " $branchNames

$i = 0
Foreach ($branchName in $branchNames) {
    $i++
    # First element in the array is trash because repo is detached
    if ($i -gt 1) {
        $branchName = $branchName.Trim()
        # Check for what branches current commit (for which we have coverage) is the last commit
        $lastCommitOnBranch = $(git rev-parse $branchName)
        if ($lastCommitOnBranch -eq $lastCommit) {
            #Cut the prefix that CodeCov does not handle well
            if ($branchName.StartsWith("remotes/origin/")) {
                $branchName = $branchName.Substring("remotes/origin/".Length)
            }
            Write-Host "We will upload report to:"  $branchName
      
            #Upload report
            & $codeCovExe -f coverage.xml -t $token --branch $branchName
        }
    }
}
