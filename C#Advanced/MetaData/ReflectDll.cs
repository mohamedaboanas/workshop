
using System.IO;
using System.Reflection;

namespace MetaData
{
    public class ReflectDll
    {
        public static void Reflect(string path)
        {
            var assembly = Assembly.LoadFile(path);
            var modules = assembly.GetModules()[0];
            var types = modules.GetTypes();

            foreach (var type in types)
            {
                var streamWriter = File.CreateText(string.Format("{0}.cs", type.Name));

                streamWriter.Write(type.IsPublic ? "public " : "internal ");

                if (type.IsClass)
                {
                    streamWriter.Write("class ");
                }
                else if (type.IsEnum)
                {
                    streamWriter.Write("enum ");
                }
                else
                {
                    streamWriter.Write("struct ");
                }
                streamWriter.WriteLine(type.Name);
                streamWriter.WriteLine("{");

                FieldInfo[] attrebuitInfos = type.GetFields(BindingFlags.Default | BindingFlags.CreateInstance |
                                                            BindingFlags.GetField | BindingFlags.GetProperty |
                                                            BindingFlags.Public |
                                                            BindingFlags.Static);

                foreach (var attrebuitInfo in attrebuitInfos)
                {
                    string accessModifire;
                    if (attrebuitInfo.IsPublic)
                    {
                        accessModifire = "public ";
                    }
                    else if (attrebuitInfo.IsPrivate)
                    {
                        accessModifire = "private ";
                    }
                    else
                    {
                        accessModifire = "protected";
                    }
                    streamWriter.WriteLine("  {0} {1} {2}; ", accessModifire, attrebuitInfo.FieldType.Name,
                        attrebuitInfo.Name);

                }


                MethodInfo[] methodInfos = type.GetMethods();
                foreach (var methodInfo in methodInfos)
                {
                    if (methodInfo.IsPublic)
                    {
                        streamWriter.Write("public ");
                    }
                    else if (methodInfo.IsPrivate)
                    {
                        streamWriter.Write("private ");
                    }
                    else
                    {
                        streamWriter.Write("protected");
                    }

                    streamWriter.Write("{0} {1}(", methodInfo.ReturnType.Name, methodInfo.Name);
                    ParameterInfo[] parameterInfos = methodInfo.GetParameters();


                    for (int i = 0; i < parameterInfos.Length; i++)
                    {
                        streamWriter.Write(i == 0 ? "{0} {1}" : ",{0} {1}", parameterInfos[i].ParameterType.Name,
                            parameterInfos[i].Name);
                    }

                    streamWriter.WriteLine(")");
                    streamWriter.Write("{");
                    streamWriter.Write("}");
                }


                streamWriter.Write("}");
                streamWriter.Close();
            }
        }
    }
}
