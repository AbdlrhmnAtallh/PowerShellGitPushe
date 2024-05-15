using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
namespace DotnetGitCommander
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string directory = @"F:\Work_Space\NewFolder"; // directory of the git repository

            using (PowerShell powershell = PowerShell.Create())
            {
                
                var a0 = powershell.AddScript($"cd {directory}");
                Console.WriteLine("a0 "+a0);
                
                var a = powershell.AddScript(@"git add *");
                Console.WriteLine("a " + a);
                
                var b = powershell.AddScript(@"git commit -m 'git commit from PowerShell in C#'");
                Console.WriteLine("b " + b);
                
                var c = powershell.AddScript(@"git push origin master");
                Console.WriteLine("c " + c);

                Collection<PSObject> results = powershell.Invoke();
            }


            // upload changes to a Git repository using Diagnostics
            
            /*
            string GitCommand = "git";
            string GitDirectoryPath = @"cd F:\\Work_Space\\NewFolder";
            string GitAddArgument = "git Add .";
            string GitCommitArgument = @"git commit -m ""init""";
            string GitRemoteArgument = @"git remote add origin https://github.com/AbdlrhmnAtallh/TestProcess.Start-.git";
            string GitPushArgument = "git push origin master";

            //Console.WriteLine(GitCommitArgument);
            Process.Start(GitCommand, GitDirectoryPath);
            Process.Start(GitCommand, GitAddArgument);
            Process.Start(GitCommitArgument, GitCommitArgument);
            Process.Start(GitCommand, GitRemoteArgument);
            Process.Start(GitCommitArgument, GitPushArgument);
            */
        }
    }
}