//Copyright (c) Microsoft Corporation.  All rights reserved.

namespace Microsoft.WindowsAPICodePack.Dialogs
{
    /// <summary>
    /// Specifies the icon displayed in a task dialog.
    /// </summary>
    public enum TaskDialogStandardIcon
    {
        /// <summary>
        /// Displays no icons (default).
        /// </summary>
        None = 0,

        /// <summary>
        /// Displays the warning icon.
        /// </summary>
        Warning = ushort.MaxValue,

        /// <summary>
        /// Displays the error icon.
        /// </summary>
        Error = ushort.MaxValue - 1,

        /// <summary>
        /// Displays the Information icon.
        /// </summary>
        Information = ushort.MaxValue - 2,

        /// <summary>
        /// Displays the User Account Control shield.
        /// </summary>
        Shield = ushort.MaxValue - 3,

        /// <summary>
        /// Displays the User Account Control shield and gives the header a blue background.
        /// </summary>
        ShieldBlue = ushort.MaxValue - 4,

        /// <summary>
        /// Displays the a warning shield icon.
        /// </summary>
        ShieldWarning = ushort.MaxValue - 5,

        /// <summary>
        /// Displays the a error shield icon.
        /// </summary>
        ShieldError = ushort.MaxValue - 6,

        /// <summary>
        /// Displays the a success shield icon.
        /// </summary>
        ShieldSuccess = ushort.MaxValue - 7,

        /// <summary>
        /// Displays the User Account Control shield and gives the header a gray background.
        /// </summary>
        ShieldGray = ushort.MaxValue - 8
    }
}
