.\packages\OpenCover.4.5.3723\OpenCover.Console.exe `
-register:user `
-target:.\packages\NUnit.Runners.2.6.4\tools\nunit-console-x86.exe `
"-targetargs:"".\Tester\bin\Debug\Tester.dll"" /framework:net-4.5 /noshadow" `
"-filter:+[CoverageTest]* -[Tester]*" `
-output:opencover.xml