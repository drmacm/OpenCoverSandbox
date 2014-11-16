@ECHO off
SET assemblyName=Bll
SET testProjectName=Bll.Tests
SET openCoverPath=..\packages\OpenCover.4.5.3207\OpenCover.Console.exe
SET reportGeneratorPath=..\packages\ReportGenerator.2.0.1.0\ReportGenerator.exe

SET testRunnerPath=C:\Program Files\Gallio\bin\Gallio.Echo.exe
SET browserPath=C:\Program Files (x86)\Google\Chrome\Application\chrome.exe

rmdir CodeCoverage /s /q
mkdir CodeCoverage
@ECHO on
"%openCoverPath%" -register:user -target:"%testRunnerPath%" -targetargs:"/r:IsolatedProcess "bin\Debug\%testProjectName%.dll"" -mergebyhash -filter:"+[%assemblyName%]*" -output:"CodeCoverage\%testProjectName%CoverageReport.xml"
"%reportGeneratorPath%" -reports:"CodeCoverage\%testProjectName%CoverageReport.xml" -targetdir:"CodeCoverage"
start "%browserPath%" "CodeCoverage\index.htm"