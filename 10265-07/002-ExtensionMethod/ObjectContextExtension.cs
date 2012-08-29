using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace _002_ExtensionMethod
{
    public static class ObjectContextExtension
    {
        public static bool FoiAlterado(this ObjectContext oc, EntityObject eo)
        {
            return eo.EntityState == EntityState.Added 
                || eo.EntityState == EntityState.Deleted 
                || eo.EntityState == EntityState.Modified;
        }
    }
}
