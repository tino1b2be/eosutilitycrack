using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src
{
    class RegistryEdit
    {
        public static void crack()
        {
            try
            {
                RegistryKey localMachineKey, softwareKey, canonKey, eos;
                localMachineKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\\Canon\\EOS Utility");
            }
            catch (Exception ex)
            {
                // Error occured.
                throw ex;
            }
        }
    }
}
