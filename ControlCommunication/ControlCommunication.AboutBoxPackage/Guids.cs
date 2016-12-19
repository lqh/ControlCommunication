// Guids.cs
// MUST match guids.h
using System;

namespace ControlCommunication.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "b7a9dd01-d4dd-484b-bdcc-1faef47dfc8c";
        public const string guidAboutBoxPackageCmdSetString = "02c70864-c550-43d4-b2c2-c508352a1c7f";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}