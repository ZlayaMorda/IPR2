using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BasePlug;
using ButtonsPlugins;

[assembly : Name("Change Color")]
namespace Plugin_Color
{
    public class Plugin2 : IPlugin_color
    {
        public void Run(Control.ControlCollection Controls)
        {
            foreach (Control but in Controls)//.OfType<Button>())
            {
                if (but.GetType() != typeof(ComboBox) && but.GetType() != typeof(Button))
                    but.BackColor = FlatColors.Purple;
                if (but.GetType() == typeof(Button))
                {
                    but.BackColor = FlatColors.WetAsphalt;
                    but.ForeColor = FlatColors.GrayLight;
                }
                    
            }
        }

    }
}

