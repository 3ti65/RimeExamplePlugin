﻿/*
    The MIT License (MIT)

    Copyright (c) 2005-2015 kiwidoggie productions

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.

*/

using System;
using System.Windows.Controls;

namespace Rime.Core.Plugins
{
    public enum MountPoint
    {
        Center,
        Left,
        Right,
        Bottom
    }

    public interface IPlugin
    {
        string Name { get; }
        string Author { get; }
        string Version { get; }
        string Description { get; }
        string Extension { get; }
        bool UIEnabled { get; }
        UserControl MainControl { get; }
        bool Init();
        bool Init(object p_Object);
        bool Init(object[] p_Objects);
        void Close();
    }
}
