using System.Windows.Forms;
using System;


namespace BasePlug

{
    public interface IPlugin
    {
        void Run(IHost host);
    }
    public class NameAttribute : System.Attribute
    {
        public string Name { get; set; }

        public NameAttribute() {}

        public NameAttribute(string Name)
        {
            this.Name = Name;
        }
    }

}
