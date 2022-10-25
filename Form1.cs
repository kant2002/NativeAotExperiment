namespace winforms_nativeaot;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Activated += (_, __) => Application.Exit();
    }
}
