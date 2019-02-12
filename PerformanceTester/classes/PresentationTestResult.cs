using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTester.classes
{
    class PresentationTestResult
    {
        public float NameLookupTime { get; set; }
        public float ConnectTime { get; set; }
        public float AppConnectTime { get; set; }
        public float PretransferTime { get; set; }
        public float RedirectTime { get; set; }
        public float StartTransferTime { get; set; }
        public float TotalTime { get; set; }

        private String Execute(String url)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardOutput = true;
            // TODO: change for local directory
            startInfo.WorkingDirectory = "C:\\Users\\Leslie\\Downloads\\curl-7.64.0-win64-mingw\\bin";
            startInfo.Arguments = "/C curltime " + url;
            startInfo.UseShellExecute = false;

            process.StartInfo = startInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            return output;
        }
    }
}
