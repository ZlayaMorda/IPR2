using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasePlug;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace WithButton.Tests
{
    [TestClass]
    public class PluginManagerTest
    {
        private PluginManager pm = new PluginManager();

        [TestCleanup]
        public void TestCleanup()
        {
            pm.AddPlugin = null;
            pm.ColorPlugin = null;
            Debug.WriteLine("Test CleanUp");
        }

        [TestMethod]
        public void Loaded_toggleSwitch_is_not_null()
        {
            pm.ScanPlugins(Path.GetFullPath(@"..\..\..\") + "Plugins", "Add ModToggleSwitch");

            Assert.IsNotNull(pm.AddPlugin, "AddPlugin is null");
            Assert.IsNull(pm.ColorPlugin, "ColorPlugin is not null");
        }

        [TestMethod]
        public void Loaded_Button_is_not_null()
        {
            pm.ScanPlugins(Path.GetFullPath(@"..\..\..\") + "Plugins", "Add ModButtons");

            Assert.IsNotNull(pm.AddPlugin, "AddPlugin is null");
            Assert.IsNull(pm.ColorPlugin, "ColorPlugin is not null");
        }

        [TestMethod]
        public void Loaded_ModCard_is_not_null()
        {
            pm.ScanPlugins(Path.GetFullPath(@"..\..\..\") + "Plugins", "Add ModCard");

            Assert.IsNotNull(pm.AddPlugin, "AddPlugin is null");
            Assert.IsNull(pm.ColorPlugin, "ColorPlugin is not null");
        }

        [TestMethod]
        public void Loaded_ChangeColor_is_not_null()
        {
            pm.ScanPlugins(Path.GetFullPath(@"..\..\..\") + "Plugins", "Change Color");

            Assert.IsNotNull(pm.ColorPlugin, "AddPlugin is null");
            Assert.IsNull(pm.AddPlugin, "AddPlugin is not null");
        }

        [TestMethod]
        public void Loaded_AddPlugin_and_ColorPlugin_is_null()
        {
            pm.ScanPlugins(Path.GetFullPath(@"..\..\..\") + "Plugins", "");


            Assert.IsTrue(pm.AddPlugin == null || pm.ColorPlugin == null, "AddPlugin and ColorPlugin are not null");
        }

        [ExpectedException(typeof(NullReferenceException), "Exception was not thrown")]
        [TestMethod]
        public void AddPLugin_NullException()
        {
            pm.AddPlugin.Run((IHost)pm.AddPlugin);
        }

        [ExpectedException(typeof(NullReferenceException), "Exception was not thrown")]
        [TestMethod]
        public void ColorPlugin_NullException()
        {
            Form form = new Form();

            pm.ColorPlugin.Run(form.Controls);
        }
    }
}
