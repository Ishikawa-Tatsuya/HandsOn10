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
using System.Runtime.InteropServices;
using System.Linq;

namespace Test
{
    [TestClass]
    public class NetNativeWindowTest
    {
        WindowsAppFriend _app;
        WindowControl _form;
        FormsButton _buttonMessageBox;
        FormsButton _buttonFile;
        FormsButton _buttonFolder;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start("FormsTarget.exe"));
            _form = new WindowControl(_app.Type<Application>().OpenForms[0]);
            _buttonMessageBox = new FormsButton(_form.Dynamic()._buttonMessageBox);
            _buttonFile = new FormsButton(_form.Dynamic()._buttonFile);
            _buttonFolder = new FormsButton(_form.Dynamic()._buttonFolder);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).CloseMainWindow();
        }
    }
}
