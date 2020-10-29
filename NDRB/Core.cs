using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace cykabot
{
    class Core
    {
        public string xo;
        public string yo;
        public string xw;
        public string yw;
        public string to;
        public string tw;

        List<string> LC = new List<string>();
        public string c2 = @"s += w[r.Next(0, w.Count)]; s += "" "";";
        public string c1 = @"return ""hello"";";
        public const string t2 = @"using System.Collections.Generic; using System; class Program { public static string Main(List<string> w) { var r = new Random(); var c = r.Next(0, 100); var s = @""""; for (var i = 0; i < w/10; i++) { core } return s; } }";
        public const string t1 = @"using System; class Program {  public static string Main(string s) { core } }";
        public Core()
        {
            string s1 = null;
            string s2 = null;
            try
            {
                s1 = File.ReadAllText("co.txt");
            }
            catch { }
            if (s1 != null && s1 != "")
            {
                c1 = s1;
            }
            try
            {
                s2 = File.ReadAllText("cw.txt");
            }
            catch { }
            if (s2 != null && s2 != "")
            {
                c2 = s2;
            }
            xo = code(t1, c1);
            yo = code(t1, c1);
            xw = code(t2, c2);
            yw = code(t2, c2);
            to = xo;
            tw = xw;
        }
        private string code(string template, string core)
        {
            return template.Replace("core", core);
        }
        private void Tree(string c)
        {
            try
            {
                var c1 = C1(xo, c);
                var c2 = C2(xw, LC);
                var c3 = C1(code(c2, t2), c);
                var c4 = C2(code(c2, t1), LC);
                if (c3 != null)
                {
                    tw = code(c2, t2);
                    to = xo;
                    yw = xw;
                    yo = xo;
                    Console.WriteLine("upd");
                    File.WriteAllText("co.txt", c3);
                    File.WriteAllText("cw.txt", xw);
                }
                else if (c4 != null)
                {
                    to = code(c2, t1);
                    tw = xw;
                    yw = xw;
                    yo = xo;
                    Console.WriteLine("upd");
                    File.WriteAllText("co.txt", xo);
                    File.WriteAllText("cw.txt", c4);
                }

            }
            catch
            {

            }
            try
            {
                var c1 = C1(yo, c);
                var c2 = C2(yw, LC);
                var c3 = C1(code(c2, t2), c);
                var c4 = C2(code(c2, t1), LC);
                if (c3 != null)
                {
                    tw = code(c2, t2);
                    to = yo;
                    xw = yw;
                    xo = yo;
                    Console.WriteLine("upd");
                    File.WriteAllText("co.txt", c3);
                    File.WriteAllText("cw.txt", xw);
                }
                else if (c4 != null)
                {
                    to = code(c2, t1);
                    tw = yw;
                    xw = yw;
                    xo = yo;
                    Console.WriteLine("upd");
                    File.WriteAllText("co.txt", xo);
                    File.WriteAllText("cw.txt", c4);
                }

            }
            catch
            {

            }

        }
        private string C1(string m, string c)
        {
            string i;
            try
            {
                i = (string)Rtc(m, c);
            }
            catch
            {
                i = null;
            }
            return i;
        }
        private string C2(string m, List<string> w)
        {
            string i;
            try
            {
                i = (string)Rtc(m, null, w);
            }
            catch
            {
                i = null;
            }
            return i;
        }
        private object Rtc(string m, string c, List<string> lc=null)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            string[] m_References = new string[] { "System.dll", "System.Core.dll", "System.Data.dll", "System.Net.dll", "System.Net.Http.dll", "System.Runtime.Serialization.dll", "System.ServiceModel.dll", "System.Xml.dll" };
            CompilerParameters compilerParameters = new CompilerParameters(m_References);
            CompilerResults results = codeProvider.CompileAssemblyFromSource(compilerParameters, m);
            var LOL = results.Errors;
            Assembly assembly = results.CompiledAssembly;
            Type program = assembly.GetType("Program");
            MethodInfo main = program.GetMethod("Main");
            if (c != null)
            {
                return main.Invoke(null, new object[] { c });
            }
            return main.Invoke(null, new object[] { lc });
        }

        public string O(string a)
        {
            Ccl(a);
            var c = C1(xo, a);
            Tree(a);
            WO(a);
            return c;
        }
        public void Ccl(string a)
        {
            var aa = a.Split(' ');
            foreach (var f in aa)
            {
                LC.Add(f);
            }

        }
        public void WO(string a)
        {
            var time = DateTime.Now.Second;
            Task.Run(() =>
            {
                while (true)
                {
                    Task.Run(() =>
                    {
                        while (true)
                        {
                            Tree(a);
                        }
                    }).Wait(DateTime.Now.Second - time);
                }
            });
          }
    }
}
