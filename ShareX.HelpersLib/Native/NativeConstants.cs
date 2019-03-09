﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2019 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

namespace ShareX.HelpersLib
{
    public static class NativeConstants
    {
        public const int GCL_HICONSM = -34;
        public const int GCL_HICON = -14;
        public const int ICON_SMALL = 0;
        public const int ICON_BIG = 1;
        public const int ICON_SMALL2 = 2;
        public const int SC_MINIMIZE = 0xF020;
        public const int HT_CAPTION = 2;
        public const int CURSOR_SHOWING = 1;
        public const int GWL_STYLE = -16;
        public const int DWM_TNP_RECTDESTINATION = 0x1;
        public const int DWM_TNP_RECTSOURCE = 0x2;
        public const int DWM_TNP_OPACITY = 0x4;
        public const int DWM_TNP_VISIBLE = 0x8;
        public const int DWM_TNP_SOURCECLIENTAREAONLY = 0x10;
        public const int WH_KEYBOARD_LL = 13;
        public const int WH_MOUSE_LL = 14;
        public const int ULW_ALPHA = 0x02;
        public const byte AC_SRC_OVER = 0x00;
        public const byte AC_SRC_ALPHA = 0x01;

        /// <summary>
        /// Draws the icon or cursor using the mask.
        /// </summary>
        public const int DI_MASK = 0x0001;

        /// <summary>
        /// Draws the icon or cursor using the image.
        /// </summary>
        public const int DI_IMAGE = 0x0002;

        /// <summary>
        /// Combination of DI_IMAGE and DI_MASK.
        /// </summary>
        public const int DI_NORMAL = 0x0003;

        /// <summary>
        /// Draws the icon or cursor using the system default image rather than the user-specified image.
        /// For more information, see About Cursors. Windows NT4.0 and later: This flag is ignored.
        /// </summary>
        public const int DI_COMPAT = 0x0004;

        /// <summary>
        /// Draws the icon or cursor using the width and height specified by the system metric values for cursors or icons,
        /// if the cxWidth and cyWidth parameters are set to zero. If this flag is not specified and cxWidth and cyWidth are set to zero,
        /// the function uses the actual resource size.
        /// </summary>
        public const int DI_DEFAULTSIZE = 0x0008;

        /// <summary>
        /// Windows XP: Draws the icon as an unmirrored icon. By default, the icon is drawn as a mirrored icon if hdc is mirrored.
        /// </summary>
        public const int DI_NOMIRROR = 0x0010;

        public const uint ECM_FIRST = 0x1500;
        public const uint EM_SETCUEBANNER = ECM_FIRST + 1;
        public const int IDC_HAND = 32649;
        public const uint MA_ACTIVATE = 1;
        public const uint MA_ACTIVATEANDEAT = 2;
        public const uint MA_NOACTIVATE = 3;
        public const uint MA_NOACTIVATEANDEAT = 4;
        public const uint MOUSE_MOVE = 0xF012;
    }
}