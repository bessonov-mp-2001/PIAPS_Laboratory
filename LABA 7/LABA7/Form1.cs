using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace LABA7
{
    public partial class Form1 : Form
    {
        public static void process(Word.Paragraph objpara1)
        {
            objpara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objpara1.Range.Font.Name = "Times New Roman"; // имя шрифта
            objpara1.Range.Font.Size = 14;
            objpara1.Range.Paragraphs.Space1();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application objword = new Word.Application();
            objword.Visible = true;
            objword.WindowState = Word.WdWindowState.wdWindowStateNormal;

            Word.Document objdoc = objword.Documents.Add();
            Word.Paragraph objpara1;
            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = "МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ" +
                "   РОССИЙСКОЙ ФЕДЕРАЦИИ";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = "ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ" +
                " «ОРЛОВСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = " ИМЕНИ И.С. ТУРГЕНЕВА»";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            string n = textBox1.Text;
            objpara1.Range.Text = $"\nКафедра {n}";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = "\n\n\nОТЧЕТ";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);
            objpara1.Range.Bold = 2;

            objpara1 = objdoc.Paragraphs.Add();
            n = textBox2.Text;
            objpara1.Range.Text = $"По лабораторной работе №{n}";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            n = textBox3.Text;
            objpara1.Range.Text = $"на тему: «{n}»";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            n = textBox4.Text;
            objpara1.Range.Text = $"по дисциплине: «{n}»";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = "\n\n\n\nВыполнил: Бессонов М.П.";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);
            objpara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = "Институт приборостроения, автоматизации и информационных технологий" +
                " Направление: 09.03.04 «Программная инженерия»";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);
            objpara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = "Группа: 92-ПГ";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);
            objpara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            n = textBox5.Text;
            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = $"Проверил: {n}";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);
            objpara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            objpara1 = objdoc.Paragraphs.Add();
            n = textBox6.Text;
            objpara1.Range.Text = $"\nОтметка о зачете:                                    Дата: «____» __________ {n} г.";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);
            objpara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            objpara1 = objdoc.Paragraphs.Add();
            objpara1.Range.Text = $"\n\n\n\n\nОрел, {n}";
            objpara1 = objdoc.Paragraphs.Add();
            process(objpara1);

            objdoc.SaveAs("D:\\MSDOC.docx");
            objdoc.Close();
            objword.Quit();
        }
    }
}
