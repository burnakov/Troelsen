using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace MyAsmBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** The Amazing Dynamic Builder App ****");
            AppDomain currDomain = Thread.GetDomain();
            CreateMyAsm(currDomain);
            Console.WriteLine("-> Finishing creating dynamic assembly MyAssembly.dll");

            Console.WriteLine("-> Loading created MyAssembly.dll");
            Assembly asm = Assembly.Load("MyAssembly");
            Type helloType = asm.GetType("MyAssembly.HelloWorld");
            Console.WriteLine("Enter message to pass HelloWorld class");
            Console.Write("Message: ");
            string userInput = Console.ReadLine();
            object[] ctorArgs = { userInput };
            object obj = Activator.CreateInstance(helloType, ctorArgs);
            Console.WriteLine("-> Calling SayHello via late binding");
            MethodInfo sayHello = helloType.GetMethod("SayHello");
            sayHello.Invoke(obj, null);
            Console.WriteLine("-> Calling GetMsg via late binding");
            MethodInfo getMsg = helloType.GetMethod("GetMsg");
            Console.WriteLine(getMsg.Invoke(obj, null));

            Console.ReadLine();
        }

        private static void CreateMyAsm(AppDomain currDomain)
        {
            AssemblyName asmName = new AssemblyName();
            asmName.Name = "MyAssembly";
            asmName.Version = new Version("1.0.0.0");
            AssemblyBuilder asmBuilder = currDomain.DefineDynamicAssembly(asmName, AssemblyBuilderAccess.Save);
            ModuleBuilder moduleBuilder = asmBuilder.DefineDynamicModule("MyAssembly", "MyAssembly.dll");
            TypeBuilder helloWorldClass = moduleBuilder.DefineType("MyAssembly.HelloWorld", TypeAttributes.Public);
            FieldBuilder msgField = helloWorldClass.DefineField("theMessage", Type.GetType("System.String"), FieldAttributes.Private);
            Type[] ctorArgs = new Type[1];
            ctorArgs[0] = typeof(string);
            ConstructorBuilder constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, ctorArgs);
            ILGenerator constructorIL = constructor.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0);
            Type objectClass = typeof(object);
            ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
            constructorIL.Emit(OpCodes.Call, superConstructor);
            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Stfld, msgField);
            constructorIL.Emit(OpCodes.Ret);
            helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);
            MethodBuilder getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, typeof(string), null);
            ILGenerator methodIL = getMsgMethod.GetILGenerator();
            methodIL.Emit(OpCodes.Ldarg_0);
            methodIL.Emit(OpCodes.Ldfld, msgField);
            methodIL.Emit(OpCodes.Ret);
            MethodBuilder sayHello = helloWorldClass.DefineMethod("SayHello", MethodAttributes.Public, null, null);
            ILGenerator helloIL = sayHello.GetILGenerator();
            helloIL.EmitWriteLine("Hello from the HelloWorld class");
            helloIL.Emit(OpCodes.Ret);

            helloWorldClass.CreateType();
            asmBuilder.Save("MyAssembly.dll");
        }
    }
}
