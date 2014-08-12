using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using GenericSingletons;

namespace Ex01.DesktopFacebook
{
    public class MyControlsRepository : PrototypeRepository<IViewableControl>, IEnumerable
    {
        private Assembly m_Assembly = Assembly.GetExecutingAssembly();

        private MyControlsRepository()
        {
            this.PopulateRepositoryFromExecutingAssembly();
        }

        public static MyControlsRepository Instance 
        { 
            get 
            { 
                return Singleton<MyControlsRepository>.Instance; 
            } 
        }

        private void PopulateRepositoryFromExecutingAssembly()
        {
            foreach (Type type in this.m_Assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(MyControl))
                    && type.IsPublic)
                {
                    this.AddPrototype(null, type);
                }
            }
        }

        protected override IViewableControl createPrototype(Type i_Type)
        {
            IViewableControl myControl = this.m_Assembly.CreateInstance(i_Type.FullName) as IViewableControl;
            this.m_Dictionary[i_Type] = myControl;
            return myControl;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (IViewableControl viewableControl in this.GetValues())
            {
                yield return viewableControl;
            }
        }
    }
}