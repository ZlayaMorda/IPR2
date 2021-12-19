using System.Windows.Forms;
using BasePlug;

[assembly : Name("Add ModToggleSwitch")]

namespace ButtonsPlugins
{
    public class Plugin1 : IPlugin
    {
        public void Run(IHost host)
        {
            ModToggleSwitch TogSw1 = new ModToggleSwitch {Top = 100, Left = 50};
            Animator.Start();
            host.AddControlToMainForm(TogSw1);
            
        }

    }
}
