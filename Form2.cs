// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form2
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 31D05A20-9999-4080-BC44-AE185374873A
// Assembly location: C:\Users\chira\Desktop\New Update\WindowsFormsApplication1.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Media;
using System.Windows.Forms;

namespace KBS2014DB
{
  public class Form2 : Form
  {
    private SoundPlayer player = new SoundPlayer();
    private IContainer components = (IContainer) null;
    private ListBox listBox1;

    public Form2()
    {
      this.InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      this.player.SoundLocation = "c:\\que.wav";
      foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
        this.listBox1.Items.Add((object) managementBaseObject["Model"].ToString());
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia").Get())
      {
        if (managementObject["SerialNumber"] != null)
          this.listBox1.Items.Add((object) managementObject["SerialNumber"].ToString());
      }
    }

    private void Form2_Click(object sender, EventArgs e)
    {
      Form1 form1 = new Form1();
      form1.MdiParent = this.ParentForm;
      form1.Dock = DockStyle.Fill;
      form1.Show();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.listBox1 = new ListBox();
      this.SuspendLayout();
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new Point(68, 157);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(361, 95);
      this.listBox1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(539, 328);
      this.Controls.Add((Control) this.listBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "Form2";
      this.Text = "Form2";
      this.Load += new EventHandler(this.Form2_Load);
      this.Click += new EventHandler(this.Form2_Click);
      this.ResumeLayout(false);
    }
  }
}
