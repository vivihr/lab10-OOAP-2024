using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeText();
        }

        private void InitializeText()
        {
            //initializing listBox1 with some text paragraphs
            listBox1.Items.Add("This is the first paragraph.");
            listBox1.Items.Add("This is the second paragraph.");
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            //determining the selected paragraph style
            string selectedStyle = radioButtonRaw.Checked ? "Row Style" : "Column Style";

            //apply the selected style to the listBox1 items
            TextProcessorSimulator simulator = new TextProcessorSimulator();
            List<string> formattedItems = new List<string>();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string styledText = simulator.SetParagraphStyle(selectedStyle, listBox1.Items[i].ToString());
                if (selectedStyle == "Column Style")
                {
                    //splitting styled text into separate items for column style
                    string[] lines = styledText.Split(new[] { '\n' }, StringSplitOptions.None);
                    foreach (var line in lines)
                    {
                        formattedItems.Add(line);
                    }
                }
                else
                {
                    formattedItems.Add(styledText);
                }
            }

            //updating listBox1 with formatted items
            listBox1.Items.Clear();
            foreach (var item in formattedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void radioButtonRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRaw.Checked)
            {
                listBox1.Items.Clear();
                InitializeText();
            }
        }

        private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonColumn.Checked)
            {
                listBox1.Items.Clear();
                InitializeText();
            }
        }
    }
    //visitor pattern - interface for paragraph style visitor
    interface IParagraphStyleVisitor
    {
        string Visit(RowStyle rowStyle, string paragraph);
        string Visit(ColumnStyle columnStyle, string paragraph);
    }

    //visitor pattern - text processor simulator class
    class TextProcessorSimulator : IParagraphStyleVisitor
    {
        public string SetParagraphStyle(string style, string paragraph)
        {
            if (style == "Row Style")
            {
                RowStyle rowStyle = new RowStyle();
                return rowStyle.Accept(this, paragraph);
            }
            else if (style == "Column Style")
            {
                ColumnStyle columnStyle = new ColumnStyle();
                return columnStyle.Accept(this, paragraph);
            }
            return paragraph;
        }

        public string Visit(RowStyle rowStyle, string paragraph)
        {
            //row style
            return "Row: " + paragraph;
        }

        public string Visit(ColumnStyle columnStyle, string paragraph)
        {
            //column style
            string[] words = paragraph.Split(' ');
            return string.Join("\n", words);
        }
    }

    //visitor pattern - specific paragraph style classes
    class RowStyle
    {
        public string Accept(IParagraphStyleVisitor visitor, string paragraph)
        {
            return visitor.Visit(this, paragraph);
        }
    }

    class ColumnStyle
    {
        public string Accept(IParagraphStyleVisitor visitor, string paragraph)
        {
            return visitor.Visit(this, paragraph);
        }
    }
}