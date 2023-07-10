using System.Runtime.InteropServices;

namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayMessageBoxes();
        }
        private void DisplayMessageBoxes()
        {
            string name = "����";
            int age = 18;
            string occupation = "����������� ������������ �����������";

            // Display name in MessageBox
            MessageBox(IntPtr.Zero, "���: " + name, "Information", 0);

            // Display age in MessageBox
            MessageBox(IntPtr.Zero, "�������: " + age.ToString(), "Information", 0);

            // Display occupation in MessageBox
            MessageBox(IntPtr.Zero, "��� ������������: " + occupation, "Information", 0);
        }

    }
}