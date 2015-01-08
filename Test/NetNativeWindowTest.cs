using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using System.Diagnostics;
using System.Windows.Forms;
using Ong.Friendly.FormsStandardControls;
using Codeer.Friendly.Windows.Grasp;
using Codeer.Friendly.Windows.NativeStandardControls;

namespace Test
{
    [TestClass]
    public class NetNativeWindowTest
    {
        WindowsAppFriend _app;
        dynamic _form;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start("FormsTarget.exe"));
            _form = _app.Type<Application>().OpenForms[0];
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).CloseMainWindow();
        }
    }
}
