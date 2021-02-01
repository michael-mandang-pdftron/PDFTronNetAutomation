using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace PDFTronNetAutomation
{
    [TestClass]
    public class PDF2Text
    {
        [TestMethod]
        public void simpleCheckTest()
        {


            string testPath = @"C:\AutomationFiles\PDFTron\PDF2Text\";
            string testInput = @"C:\AutomationFiles\PDFTron\Input\";
            string testOutput = @"C:\AutomationFiles\PDFTron\Output\";

            Console.WriteLine(testPath);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = testPath + "pdf2text.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Part 2: set arguments.
            startInfo.Arguments = "--file " + testInput + "basicText3.pdf" + " -a " + 1 + " -o " + testOutput;

            try
            {
                // Part 3: start with the info we specified.
                // ... Call WaitForExit.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }

            Console.WriteLine("DONE");

            System.IO.File.WriteAllText(testOutput + "simpleTest.txt", "test sample attachment 3");

        }

        [TestMethod]
        public void regressionPart1()
        {


            string testPath = @"C:\AutomationFiles\PDFTron\PDF2Text\";
            string testInput = @"C:\AutomationFiles\PDFTron\Input\";
            string testOutput = @"C:\AutomationFiles\PDFTron\Output\";

            Console.WriteLine(testPath);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = testPath + "pdf2text.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Part 2: set arguments.
            startInfo.Arguments = "--file " + testInput + "basicText.pdf" + " -a " + 1 + " -o " + testOutput;

            try
            {
                // Part 3: start with the info we specified.
                // ... Call WaitForExit.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }

            Console.WriteLine("DONE");

            System.IO.File.WriteAllText(testOutput + "regressionPart1.txt","test sample attachment 1");

        }

        [TestMethod]
        public void regressionPart2()
        {


            string testPath = @"C:\AutomationFiles\PDFTron\PDF2Text\";
            string testInput = @"C:\AutomationFiles\PDFTron\Input\";
            string testOutput = @"C:\AutomationFiles\PDFTron\Output\";

            Console.WriteLine(testPath);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = testPath + "pdf2text.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Part 2: set arguments.
            startInfo.Arguments = "--file " + testInput + "basicText2.pdf" + " -a " + 1 + " -o " + testOutput;

            try
            {
                // Part 3: start with the info we specified.
                // ... Call WaitForExit.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }

            Console.WriteLine("DONE");

            System.IO.File.WriteAllText(testOutput + "regressionPart2.txt", "test sample attachment 2");

        }
    }
}
