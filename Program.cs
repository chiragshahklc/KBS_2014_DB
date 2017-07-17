// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 31D05A20-9999-4080-BC44-AE185374873A
// Assembly location: C:\Users\chira\Desktop\New Update\WindowsFormsApplication1.exe

using System;
using System.Windows.Forms;

namespace KBS2014DB
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
