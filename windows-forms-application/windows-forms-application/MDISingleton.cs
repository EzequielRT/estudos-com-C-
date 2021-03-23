using System;
using System.Collections.Generic;
using System.Text;

namespace windows_forms_application
{
    public class MDISingleton
    {
        private MDISingleton() { }

        private static MDIParentPrincipal instanceMDIParentPrincipal;

        public static MDIParentPrincipal InstanciaMDI()
        {
            if (instanceMDIParentPrincipal == null)
            {
                instanceMDIParentPrincipal = new MDIParentPrincipal();
                return instanceMDIParentPrincipal;
            }
            return instanceMDIParentPrincipal;
        }
    }
}
