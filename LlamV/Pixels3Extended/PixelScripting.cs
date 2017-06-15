using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pixels.Extend
{
    public class PixelScripting
    {
        public string[] Imports = new string[]
        {
            "System",
            "System.Collections.Generic",
            "System.Linq",
            "System.Math",
            "System.IO",
            "Pixels",
            "Pixels.Math",
            "Pixels.Stream",
            "Pixels.Extend",
        };
        ScriptSourceResolver ssr = ScriptSourceResolver.Default.WithBaseDirectory(Environment.CurrentDirectory);
        ScriptMetadataResolver smr = ScriptMetadataResolver.Default.WithBaseDirectory(Environment.CurrentDirectory);

        public async Task<ScriptState<object>> RunAsync(string command, object globals)
        {
            var state = await CSharpScript.RunAsync(
                command,
                ScriptOptions.Default
                .WithSourceResolver(ssr)
                .WithMetadataResolver(smr)
                .WithReferences(Assembly.GetEntryAssembly())
                .WithImports(Imports),
               globals: globals);

            //foreach (var variable in state.Variables)
            //    Output($"  Result : {variable.Name} = {variable.Value} of type {variable.Type}");
            return state;
        }

        public Script Compile(string command, Type type)
        {
            var script = CSharpScript.Create(
                command,
                ScriptOptions.Default
                .WithSourceResolver(ssr)
                .WithMetadataResolver(smr)
                .WithReferences(Assembly.GetEntryAssembly())
                .WithImports(Imports),
                type);
            return script;
        }

    }

    public static class PixelScriptingEx
    {
        public static void ToClip(this object[] src)
        {
            System.Windows.Clipboard.SetData(System.Windows.DataFormats.Text, string.Join("\r\n", src));
        }

        public static void ToClip<T,U>(this Dictionary<T,U> src)
        {
            //System.Windows.Clipboard.SetData(
            //    System.Windows.DataFormats.Text, 
            //    string.Join("\r\n",n.Select(x=>$"{x.Key.ToString()}, {x.Value.ToString()}"))
            //    );
            System.Windows.Clipboard.SetDataObject(
                string.Join("\r\n", src.Select(x => $"{x.Key.ToString()}, {x.Value.ToString()}"))
                , true);
        }

        public static void ToText(this object src, ref string result, Func<dynamic, string> func)
        {
            result += func(src);
        }
    }
}
