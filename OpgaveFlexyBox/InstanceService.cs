using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveFlexyBox
{
    public class InstanceService<T>
    {
        public IEnumerable<Type> GetInstances()
        {
            List<Type> types = new List<Type>();
            foreach (var item in Assembly.Load(typeof(T).Assembly.GetName()).GetTypes())
            {
                if (!item.IsInterface && !item.IsAbstract)
                {
                    types.Add(item);
                }
            }
            return types;
            
            //Assembly.Load(typeof(T).Assembly.GetName()).GetTypes().Where(x => !x.IsInterface && !x.IsAbstract);

            /*
            object oNewObject = Activator.CreateInstance(typeof(T), 150, 4);
            Vehicle v = (Vehicle)oNewObject;
            Console.WriteLine("Vehicle class speed:");
            Console.WriteLine(v.MaxSpeed);

            foreach (var item in typeof(T).Assembly.Modules)
            {
                foreach (var type in item.GetTypes())
                {
                    foreach (var member in type.FindMembers(System.Reflection.MemberTypes.All, System.Reflection.BindingFlags.Default, null, null))
                    {
                        Console.WriteLine(member.Name);
                    }
                }
            }
            return null;
            */
        }
    }
}
