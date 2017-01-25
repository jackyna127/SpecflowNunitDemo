echo "Execute test from Nunit.Console"
..\..\packages\NUnit.ConsoleRunner.3.6.0\tools\nunit3-console.exe --labels=On --output=TestResult.txt --result=TestResult.xml;format=nunit2 ..\bin\Debug\SpecFlowNUnitDemo.dll
