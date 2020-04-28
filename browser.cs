using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
public class MyBrowser : Form
{
public WebBrowser browse;
public TextBox url;
public Button goButton;
public MyBrowser()
{
this.Text = "BTP Browser";
browse = new WebBrowser();
browse.Location = new Point(15, 100);
browse.Width = 700;
browse.Height = 2000;
browse.TabIndex = 2;
url = new TextBox();
url.Location = new Point(15, 0);
url.AccessibleName = "Address Bar";
url.TabIndex = 0;
url.Width = 100;
this.Controls.Add(url);
goButton = new Button();
goButton.TabIndex = 1;
goButton.Location = new Point(130, 0);
goButton.Text = "&Go";
goButton.Click += new EventHandler(NavigateToSite);
this.Controls.Add(goButton);
}
private void NavigateToSite (object sender, EventArgs E)
{
browse.Navigate(url.Text);
this.Controls.Remove(browse);
this.Controls.Add(browse);
browse.Focus();
this.Text = browse.DocumentTitle + " - BTP Browser";
}
[STAThread]
static void Main()
{
Application.Run(new MyBrowser());
}
}
