// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form1
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 31D05A20-9999-4080-BC44-AE185374873A
// Assembly location: C:\Users\chira\Desktop\New Update\WindowsFormsApplication1.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KBS2014DB
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private ComboBox comboBox1;
    private Label label1;
    private Button button2;
    private Button button3;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DataTable dataTable = new DataTable();
      string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
      string text = directoryName + "\\Ques\\Question" + this.comboBox1.SelectedItem.ToString() + ".xlsx";
      int num1 = (int) MessageBox.Show(text);
      new OleDbDataAdapter("select * from [Question" + this.comboBox1.SelectedItem.ToString() + "$]", new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text + ";Extended Properties=\"Excel 12.0;HDR=YES;\"")).Fill(dataTable);
      int num2 = (int) MessageBox.Show(dataTable.Rows.Count.ToString());
      SqlCeConnection connection = new SqlCeConnection("Data Source=" + directoryName + "\\kbs.sdf");
      SqlCeCommand sqlCeCommand1 = new SqlCeCommand("delete from que" + this.comboBox1.SelectedItem.ToString(), connection);
      connection.Open();
      if (sqlCeCommand1.ExecuteNonQuery() > 0)
      {
        int num3 = (int) MessageBox.Show("Table Data Deleted");
      }
      connection.Close();
      int num4 = int.Parse(dataTable.Rows.Count.ToString());
      for (int index = 0; index < num4; ++index)
      {
        connection.Open();
        SqlCeCommand sqlCeCommand2 = new SqlCeCommand("insert into que" + this.comboBox1.SelectedItem.ToString() + " values(@id,@que,@A,@B,@C,@D,@ans)", connection);
        sqlCeCommand2.Parameters.AddWithValue("@id", int.Parse( dataTable.Rows[index][0].ToString()));
        sqlCeCommand2.Parameters.AddWithValue("@que", (object) dataTable.Rows[index][1].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@A", (object) dataTable.Rows[index][2].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@B", (object) dataTable.Rows[index][3].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@C", (object) dataTable.Rows[index][4].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@D", (object) dataTable.Rows[index][5].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@ans", (object) dataTable.Rows[index][6].ToString());
        sqlCeCommand2.ExecuteNonQuery();
        connection.Close();
      }
      int num5 = (int) MessageBox.Show("Table Data Updated");
    }

    private void Form1_Click(object sender, EventArgs e)
    {
    }

    public void fff()
    {
      DataTable dataTable = new DataTable();
      string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
      string text = directoryName + "\\Ques\\Questionfff.xlsx";
      int num1 = (int) MessageBox.Show(text);
      new OleDbDataAdapter("select * from [Questionfff$]", new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text + ";Extended Properties=\"Excel 12.0;HDR=YES;\"")).Fill(dataTable);
      int num2 = (int) MessageBox.Show(dataTable.Rows.Count.ToString());
      SqlCeConnection connection = new SqlCeConnection("Data Source=" + directoryName + "\\kbs.sdf");
      SqlCeCommand sqlCeCommand1 = new SqlCeCommand("delete from fff", connection);
      connection.Open();
      if (sqlCeCommand1.ExecuteNonQuery() > 0)
      {
        int num3 = (int) MessageBox.Show("Table Data Deleted");
      }
      connection.Close();
      int num4 = int.Parse(dataTable.Rows.Count.ToString());
      for (int index = 0; index < num4; ++index)
      {
        connection.Open();
        SqlCeCommand sqlCeCommand2 = new SqlCeCommand("insert into fff values(@id,@que,@A,@B,@C,@D,@ans1,@ans2,@ans3,@ans4)", connection);
        sqlCeCommand2.Parameters.AddWithValue("@id", (object) dataTable.Rows[index][0].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@que", (object) dataTable.Rows[index][1].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@A", (object) dataTable.Rows[index][2].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@B", (object) dataTable.Rows[index][3].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@C", (object) dataTable.Rows[index][4].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@D", (object) dataTable.Rows[index][5].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@ans1", (object) dataTable.Rows[index][6].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@ans2", (object) dataTable.Rows[index][7].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@ans3", (object) dataTable.Rows[index][8].ToString());
        sqlCeCommand2.Parameters.AddWithValue("@ans4", (object) dataTable.Rows[index][9].ToString());
        sqlCeCommand2.ExecuteNonQuery();
        connection.Close();
      }
      int num5 = (int) MessageBox.Show("Table Data Updated");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.fff();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      SqlCeConnection connection = new SqlCeConnection("Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\kbs.sdf");
      SqlCeCommand sqlCeCommand = new SqlCeCommand("delete from Auth", connection);
      connection.Open();
      if (sqlCeCommand.ExecuteNonQuery() > 0)
      {
        int num = (int) MessageBox.Show("Register PC Deleted");
      }
      connection.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.comboBox1 = new ComboBox();
      this.label1 = new Label();
      this.button2 = new Button();
      this.button3 = new Button();
      this.SuspendLayout();
      this.button1.Location = new Point(342, 65);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Update";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[13]
      {
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10",
        (object) "11",
        (object) "12",
        (object) "13"
      });
      this.comboBox1.Location = new Point(215, 67);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(121, 21);
      this.comboBox1.TabIndex = 1;
      this.label1.AutoSize = true;
      this.label1.Location = new Point((int) sbyte.MaxValue, 70);
      this.label1.Name = "label1";
      this.label1.Size = new Size(82, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Select Question";
      this.button2.Location = new Point(250, 123);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "fff";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(250, 188);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 4;
      this.button3.Text = "Reset PC";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(569, 332);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.button1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.Text = "Form1";
      this.Load += new EventHandler(this.Form1_Load);
      this.Click += new EventHandler(this.Form1_Click);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
