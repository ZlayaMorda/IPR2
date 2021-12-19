using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePlug;

[assembly: Name("Add ModCard")]

namespace ButtonsPlugins
{
    class PluginForCard : IPlugin
    {
        public void Run(IHost host)
        {
            ModCard TogSw1 = new ModCard { Top = 10, Left = 150, Width = 250, Height = 200};
            Animator.Start();
            host.AddControlToMainForm(TogSw1);

        }
    }
}
