using System;
using System.Configuration;
using System.Windows.Forms;
using BasePlug;
using System.Reflection;
using System.IO;

namespace WithButton
{
    public partial class Form1 : Form,IHost
    {
        private PluginManager pm = new PluginManager();


        public Form1()
        {
            InitializeComponent();            
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                pm.ScanPlugins(Path.GetFullPath(@"..\..\..\") + ConfigurationManager.AppSettings.Get("Plugins"), cxPlug.SelectedItem.ToString());
                if (pm.AddPlugin != null)
                {
                    pm.AddPlugin.Run(this);
                    pm.AddPlugin = null;
                }
                else if (pm.ColorPlugin != null)
                {
                    pm.ColorPlugin.Run(Controls);
                    pm.ColorPlugin = null;
                }
                else
                    MessageBox.Show("no plugins");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите нужный плагин");
            }
            catch { }

        }

        public void AddControlToMainForm(Control ctrl)
        {
            this.Controls.Add(ctrl);
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            foreach (var file in Directory.EnumerateFiles
            (Path.GetFullPath(@"..\..\..\") + ConfigurationManager.AppSettings.Get("Plugins"), "*.dll", SearchOption.AllDirectories))
            {
                var ass = Assembly.LoadFile(file);

                foreach (NameAttribute attributedata in ass.GetCustomAttributes(typeof(NameAttribute), false))
                {
                    if(cxPlug.FindString(attributedata.Name) == -1)
                        cxPlug.Items.Add(attributedata.Name);
                }
            }

        }
    }
}
