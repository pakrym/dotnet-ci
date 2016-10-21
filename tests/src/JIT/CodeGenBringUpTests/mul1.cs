// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//


using System;
using System.Text;
using System.Runtime.CompilerServices;

struct vc
{
    public int x;
    public int y;
    public int z;
    public vc (int xx, int yy, int zz) { x = xx; y = yy; z = zz; }
}

class child
{
    const int Pass = 100;
    const int Fail = -1;

    static int Main()
    {
        int result = mul1(3, 7);
        if (result == 21)
            return Pass;
        else
            return Fail;
    }

    [MethodImplAttribute(MethodImplOptions.NoInlining)] 
    public static int mul1(int a, int b)
    {
        return a*b;
    }
    
}
