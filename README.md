clone the develop branch in ur following directory
C:\Users\{User Name}\Documents\ResearchWebStack
Make a folder in c drive named "UnitTestFile" and put the UnitTests.xml file over there


Task - 1
	I have created the service contract...but somehow gives error when i try to invoke it's method from browser.
	So i created some webmethod in WebService1.asmx...It's under ResearchWebStack/ResearchWebStack

	to test the service contract start Hello first and then 
	1. create a test project (Console or Web app) outside of that solution file 
	and the service reference and in the url box type "http://localhost:8080/" and name it "HelloService"
	
	3.Then paste the bellow code in the main method or desired event

	    HelloService.TestServiceClient client = new 
        	HelloService.TestServiceClient("BasicHttpBinding_ITestService");
            Console.WriteLine(client.UnitTestResults());

Task - 2
	change {User Name} in the below arguments by ur pc's user name and rebuild ur project	

	Go to ResearchWebStack/ResearchWebStack.CommandLine/bin/debug...Then open cmd...then
	run the following command ---
	ResearchWebStack.CommandLine.exe runNodeJs 
	-n kkk -p C:\Users\{User Name}\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe 
	-r C:\Users\{User Name}\Documents\Output.txt 
	
	ResearchWebStack.CommandLine.exe runPythonJs 
	-n kkk -p C:\Users\{User Name}\Documents\ResearchWebStack\Hello\bin\Debug\Hello.exe 
	-r C:\Users\{User Name}\Documents\Output.txt 

	and so on...
Task - 3
	start the server WebService.asmx file resides.Then Open Visual Studio 
	Code...Then open C:\Users\{User Name}\Documents\ResearchWebStack\NodeJs
	on the vs code terminal write node bin/www
	It's run on port 3000
	To see it in the browser go 
	
	localhost:3000/Node/View/UnitTets/ew/cmd/aNonPassing
	localhost:3000/Node/View/UnitTest	