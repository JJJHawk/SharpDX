﻿// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if DIRECTX11_1
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpDX.Direct2D1
{
    [ShadowAttribute(typeof(DrawTransformShadow))]
    public partial interface DrawTransform
    {
        /// <summary>	
        /// Sets the GPU render information for the transform.
        /// </summary>	
        /// <param name="drawInfo">The interface to specify the GPU-based transform pass..</param>	
        /// <unmanaged>HRESULT ID2D1DrawTransform::SetDrawInfo([In] ID2D1DrawInfo* drawInfo)</unmanaged>	
        void SetDrawInformation(SharpDX.Direct2D1.DrawInformation drawInfo);
    }
}
#endif