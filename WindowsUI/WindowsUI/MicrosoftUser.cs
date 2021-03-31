using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUI
{
    public class MicrosoftUser
    {
        public static string GetMicrosoftAccount(SecurityIdentifier sid)
        {
            if (sid == null) return null;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32))
            {
                var path = $"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\Credential Providers\\{{D6886603-9D2F-4EB2-B667-1971041FA96B}}\\{sid.Value}\\UserNames";
                using (var subKey = hklm.OpenSubKey(path))
                {
                    if (subKey == null) return null;
                    return subKey.GetSubKeyNames().FirstOrDefault();
                }
            }
        }

        public static SecurityIdentifier GetSecurityIdentifier(string userName, bool stripDomain = false)
        {
            if (stripDomain)
            {
                var p = userName.IndexOf('\\');
                if (p >= 0) userName = userName.Substring(p + 1);
            }
            try
            {
                return new NTAccount(userName).Translate(typeof(SecurityIdentifier)) as SecurityIdentifier;
            }
            catch (IdentityNotMappedException)
            {
                return null;
            }
        }

        internal enum GetUserPictureFlags : uint
        {
            Directory = 0x1,
            DefaultDirectory = 0x2,
            CreatePicturesDir = 0x80000000
        }

        public static string GetMicrosoftAccount(string userName) => GetMicrosoftAccount(GetSecurityIdentifier(userName ?? Environment.UserName));

        [DllImport("shell32.dll", EntryPoint = "#261", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void SHGetUserPicturePath(string name, GetUserPictureFlags flags, StringBuilder path, int pathLength);

        [DllImport("shell32.dll", EntryPoint = "#810", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void SHGetUserPicturePathEx(string name, GetUserPictureFlags flags, string desiredSrcExt, StringBuilder path, int pathLength, StringBuilder srcPath, int srcLength);

        public static string GetUserPicturePath(string userName = null)
        {
            if (userName == null) userName = Environment.UserName;
            var msAccountName = GetMicrosoftAccount(userName);
            var pathBuffer = new StringBuilder(1024);
            SHGetUserPicturePath(msAccountName ?? userName, GetUserPictureFlags.CreatePicturesDir, pathBuffer, pathBuffer.Capacity);
            return pathBuffer.ToString();
        }
        public static string GetUserPicturePath(string userName, out string srcPath)
        {
            var msAccountName = GetMicrosoftAccount(userName);
            var pathBuffer = new StringBuilder(1024);
            var srcBuffer = new StringBuilder(1024);
            SHGetUserPicturePathEx(msAccountName ?? userName, GetUserPictureFlags.CreatePicturesDir, null, pathBuffer, pathBuffer.Capacity, srcBuffer, srcBuffer.Capacity);
            srcPath = srcBuffer.ToString();
            if (srcPath.StartsWith("\\\\"))
            {
                srcPath = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2) + srcPath.Substring(srcPath.IndexOf("\\", 2));
            }
            return pathBuffer.ToString();
        }
    }
}
