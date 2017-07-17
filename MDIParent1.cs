// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.MDIParent1
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 31D05A20-9999-4080-BC44-AE185374873A
// Assembly location: C:\Users\chira\Desktop\New Update\WindowsFormsApplication1.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KBS2014DB
{
  public class MDIParent1 : Form
  {
    private int childFormNumber = 0;
    private IContainer components = (IContainer) null;
    private ToolTip toolTip;

    public MDIParent1()
    {
      this.InitializeComponent();
    }

    private void ShowNewForm(object sender, EventArgs e)
    {
      Form form = new Form();
      form.MdiParent = (Form) this;
      form.Text = "Window " + (object) this.childFormNumber++;
      form.Show();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (openFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string fileName = openFileDialog.FileName;
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (saveFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
    }

    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form mdiChild in this.MdiChildren)
        mdiChild.Close();
    }

    private void MDIParent1_Load(object sender, EventArgs e)
    {
      try
      {
        Form1 form1 = new Form1();
        form1.MdiParent = (Form) this;
        form1.FormBorderStyle = FormBorderStyle.None;
        form1.Dock = DockStyle.Fill;
        form1.Show();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.toolTip = new ToolTip(this.components);
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(632, 453);
      this.FormBorderStyle = FormBorderStyle.None;
      this.IsMdiContainer = true;
      this.Name = "MDIParent1";
      this.Text = "MDIParent1";
      this.Load += new EventHandler(this.MDIParent1_Load);
      this.ResumeLayout(false);
    }
  }
}
