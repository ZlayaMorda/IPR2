using System.IO;
using System.Reflection;
using System;
using Plugin_Color;

namespace BasePlug

{
    public class PluginManager
    {
        //public List<IPlugin> Plugins = new List<IPlugin>();
        public IPlugin AddPlugin;
        public IPlugin_color ColorPlugin;

        public void ScanPlugins(string directory, string Name)
        {
            //перебираем все файлы dll
            foreach (var file in Directory.EnumerateFiles(directory, "*.dll", SearchOption.AllDirectories))
                //try
                {
                        var  ass = Assembly.LoadFile(file);



                    foreach (CustomAttributeData attributedata in ass.CustomAttributes)
                    {

                        foreach (CustomAttributeTypedArgument argumentset in attributedata.ConstructorArguments)
                        {
                                if (argumentset.Value.ToString() == Name)
                                {

                                    switch(Name)
                                    { 
                                        case "Add ModToggleSwitch":
                                            if (AddPlugin == null) 
                                            {
                                                //перебираем все типы из ассембли
                                                foreach (Type type in ass.GetTypes())
                                                {
                                                    //создаем экземпляр плагина
                                                    var inter = type.GetInterface("IPlugin");
                                                    if (inter != null)
                                                        AddPlugin = ass.CreateInstance(type.FullName) as IPlugin;

                                                }
                                            }
                                                break;
                                        case "Change Color":
                                            if(ColorPlugin == null)
                                            {
                                                foreach (Type type in ass.GetTypes())
                                                {
                                                    //создаем экземпляр плагина
                                                    ColorPlugin = ass.CreateInstance(type.FullName) as IPlugin_color;

                                                }
                                            }
                                                break;
                                        case "Add ModButtons":
                                            if (AddPlugin == null)
                                            {
                                                //перебираем все типы из ассембли
                                                foreach (Type type in ass.GetTypes())
                                                {
                                                    //создаем экземпляр плагина
                                                    var inter = type.GetInterface("IPlugin");
                                                    if(inter != null)
                                                        AddPlugin = ass.CreateInstance(type.FullName) as IPlugin;

                                                }
                                            }
                                            break;
                                        case "Add ModCard":
                                            if (AddPlugin == null)
                                            {
                                                    //перебираем все типы из ассембли
                                                foreach (Type type in ass.GetTypes())
                                                {
                                                    //создаем экземпляр плагина
                                                    var inter = type.GetInterface("IPlugin");
                                                    if (inter != null)
                                                        AddPlugin = ass.CreateInstance(type.FullName) as IPlugin;

                                                }
                                            }
                                            break;
                            }

                                }
                        }
                    }

                }
                //catch {/*is not .NET assembly*/}
        }
    }
}
