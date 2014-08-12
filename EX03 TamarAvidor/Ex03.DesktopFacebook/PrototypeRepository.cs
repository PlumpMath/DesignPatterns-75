using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.DesktopFacebook
{
    public abstract class PrototypeRepository<T>
    {
        protected readonly Dictionary<Type, T> m_Dictionary = new Dictionary<Type, T>();

        public void AddPrototype(T i_Prototype, Type i_Type)
        {
            m_Dictionary.Add(i_Type, i_Prototype);
        }

        public T GetReference(Type i_Type)
        {
            T toClone = m_Dictionary[i_Type];
            if (toClone == null)
            {
                toClone = createPrototype(i_Type);
            }

            return m_Dictionary[i_Type];
        }

        public void DisposePrototype(Type i_Type)
        {
            m_Dictionary[i_Type] = default(T);
        }

        protected abstract T createPrototype(Type i_Type);

        public IEnumerable<Type> GetTypes()
        {
            return m_Dictionary.Keys;
        }

        public IEnumerable<T> GetValues()
        {
            return m_Dictionary.Values;
        }
    }
}
