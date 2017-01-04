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
                RegistryKey localMachineKey;
                // Add the registry Key
                // Write to both locations so that it doesn't matter whether the machine is 32bit or 64bit
                localMachineKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\\Canon\\EOS Utility");
                localMachineKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\\WOW6432Node\\Canon\\EOS Utility");

                // check to see if the key exists

            }
            catch (Exception ex)
            {
                // Error occured.
                throw ex;
            }
        }
    }
}
