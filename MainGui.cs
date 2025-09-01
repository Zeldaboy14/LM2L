using System;
using System.Windows.Forms;
using static LM2L.Program;


namespace LM2L
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Check if user left these paths empty
            if (textBox3.Text == null) { Console.WriteLine("No .dict file path"); return; }
            if (textBox4.Text == null) { Console.WriteLine("No .dict file path!"); return; }
            DealWithDataDict(textBox3.Text, textBox4.Text, checkBox4.Checked, checkBox8.Checked, checkBox6.Checked, checkBox5.Checked);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ModelThingy.ParseFiles(textBox6.Text, textBox7.Text, textBox8.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LM2L.Help().Show();
        }

        private void MainGui_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                textBox6.Text = files[0];
            }
        }

        private void textBox6_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox7_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                textBox7.Text = files[0];
            }
        }

        private void textBox7_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox8_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                textBox8.Text = files[0];
            }
        }

        private void textBox8_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                textBox3.Text = files[0];
            }
        }

        private void textBox3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox4_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                textBox4.Text = files[0];
            }
        }

        private void textBox4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
