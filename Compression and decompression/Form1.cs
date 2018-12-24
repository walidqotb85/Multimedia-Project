using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Compression_and_decompression
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, 
                Primary.Blue500, 
                Primary.Blue500, 
                Accent.LightBlue200, 
                TextShade.WHITE );



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void variableCompression_Click(object sender, EventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();

        //compression btn for Run Length
        private void chooseFile_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                fileNameComp_txtbox.Text = ofd.SafeFileName;
                filePathComp_txtbox.Text = ofd.FileName;
                runLengthCom_txtBox.Text = filePathComp_txtbox.Text;

            }

        }
        //Decompression btn for Run Length
        private void selectDecomp_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameDecomp_txtbox.Text = ofd.SafeFileName;
                filePathDecomp_txtBox.Text = ofd.FileName;
                runLengthDecom_txt.Text = filePathDecomp_txtBox.Text;

            }
        }

        //compression btn for Vaiable Length

        private void selectCompVl_btn_Click(object sender, EventArgs e)
        {

            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameComVl_txtbox.Text = ofd.SafeFileName;
                filePathComVl_txtBox.Text = ofd.FileName;
            }

        }
      
        //Decompression btn for Vaiable Length

        private void selectDecomVL_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameDecomVl_txtBox.Text = ofd.SafeFileName;
                filePathDecomVl_txtBox.Text = ofd.FileName;
            }
        }


        private void selectComHuff_gBox_Enter(object sender, EventArgs e)
        {

        }

        //compression btn for Huffman

        private void selectComHuff_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameComHuff_txtBox.Text = ofd.SafeFileName;
                filePathComHuff_txtBox.Text = ofd.FileName;
                comPathHuff_txtBox.Text = filePathComHuff_txtBox.Text;
            }
        }

        //Decompression btn for Huffman

        private void selectDecomHuff_txt_Click(object sender, EventArgs e)
        {

            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameDecomHuff_txtBox.Text = ofd.SafeFileName;
                filePathDecomHuff_txtBox.Text = ofd.FileName;
                decompFileHuff_txtBox.Text = filePathDecomHuff_txtBox.Text;
            }

        }

        //compression btn for Adaptive Huffman

        private void selectComAH_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameComAH_txtBox.Text = ofd.SafeFileName;
                filePathComAH_txtBox.Text = ofd.FileName;
            }

        }

        //Decompression btn for Adaptive Huffman

        private void selectDecomAH_txtBox_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameDecomAH_txtBox.Text = ofd.SafeFileName;
                filePathDecomAH_txtBox.Text = ofd.FileName;
            }
        }

        //compression btn for Dictionary 
        private void selectComDic_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameComDic_txtBox.Text = ofd.SafeFileName;
                filePathComDic_txtBox.Text = ofd.FileName;
                pathCompDic_txtBox.Text = filePathComDic_txtBox.Text;
            }
        }
        //Decompression btn for Dictionary
        private void selectDecomDic_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameDecomDic_txtBox.Text = ofd.SafeFileName;
                filePathDecomDic_txtBox.Text = ofd.FileName;
            }
        }

        //compression btn for Arithmeric Code
        private void selectComAC_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameComAC_txtBox.Text = ofd.SafeFileName;
                filePathComAC_txtBox.Text = ofd.FileName;
                comPathAc_txtBox.Text = filePathComAC_txtBox.Text;
            }
        }

        //Decompression btn for Arithmetic Code
    
        private void selectDecomAC_btn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameDecomAC_txtBox.Text = ofd.SafeFileName;
                filePathDecomAC_txtBox.Text = ofd.FileName;
                decompPathFile_txtBox.Text = filePathDecomAC_txtBox.Text;
            }
        }

        RunLength runLength = new RunLength();

        private void runLengthCom_btn_Click(object sender, EventArgs e)
        {
            runLength.filePath = runLengthCom_txtBox.Text;
            string codedStr = runLength.Encode(runLength.filePath);
            StreamWriter writeFile = new StreamWriter("G:\\Compressed.txt");
            writeFile.WriteLine(codedStr);
            writeFile.Close();
            fileNameRunLComp_txtBox.Text = "Compressed.txt";
            filePathRunLComp_txt.Text = "G:\\Compressed.txt";
            MessageBox.Show("The Compression Is Done Successefully");
        }

        private void runLengthDecom_btn_Click(object sender, EventArgs e)
        {
            runLength.filePath = runLengthDecom_txt.Text;
            string codeStr = runLength.Decode(runLength.filePath);
            StreamWriter streamWriter = new StreamWriter("G:\\DecopmressRunLength.txt");
            streamWriter.WriteLine(codeStr);
            streamWriter.Close();
            fileNameRunLDecom_txtBox.Text = "DecopmressRunLength.txt";
            filePathRunLDecom_txtBox.Text = "G:\\DecopmressRunLength.txt";
            MessageBox.Show("The Decompression Is Done Successfully");
        }

        HuffmanTree huffmanTree = new HuffmanTree();
        private void huffComp_btn_Click(object sender, EventArgs e)
        {
            DataTable symboles = new DataTable();
            symboles.Columns.Add("Symbol", typeof(string));
            symboles.Columns.Add("code", typeof(bool));


            string filePath = comPathHuff_txtBox.Text;
            StreamReader streamReader = new StreamReader(filePath);
            string fileStr = " ";
            fileStr = streamReader.ReadLine();
            huffmanTree.Build(fileStr);
            BitArray encode = huffmanTree.Encode(fileStr);
            StreamWriter streamWriter = new StreamWriter("G:\\Copmress_Huffman.txt");
            string inputes = fileStr;
            for (int i = 0; i < inputes.Length; i++)
            {
                symboles.Rows.Add(inputes[i]);
                if (symboles.Rows.Equals(inputes[i]))
                    continue;

            }

            DGV_comHuff.DataSource = symboles;
            BitArray codes;
            codes = encode;
            foreach (bool bit in encode)
            {
                streamWriter.Write((bit ? 1 : 0) + "");

            }
            streamWriter.Close();

            //for (int j = 0  ; j < codes.Length; j++)
            //{
            //    symboles.Rows.Add(codes[j]);
            //}
            //DGV_comHuff.DataSource = symboles;

            fileNameCompHuff_txtBox.Text = "Copmress_Huffman.txt";
            filePathCompHuff_txtBox.Text = "G:\\Copmress_Huffman.txt";
            MessageBox.Show("the File Is Compressed Successfully");
        }

        private void decompHuff_btn_Click(object sender, EventArgs e)
        {
           
            string filePath = pathDecomSourceHuff_txtBox.Text;
            StreamReader streamReader = new StreamReader(filePath);
            string fileStr = " ";
            fileStr = streamReader.ReadLine();
            huffmanTree.Build(fileStr);
            BitArray encode = huffmanTree.Encode(fileStr);

           

            string decode = huffmanTree.Decode(encode);
             StreamWriter streamWriter = new StreamWriter("G:\\Decompress_Huffman.txt");
             streamWriter.WriteLine(decode);
             streamWriter.Close();
             nameDecomHuff_txtbox.Text = "Decompress_Huffman.txt";
             pathDecomHuff_txtBox.Text = "G:\\Decompress_Huffman.txt";
             MessageBox.Show("The File Is Decompressed successfully");

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Txt file|* .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathDecomSourceHuff_txtBox.Text = ofd.FileName;
            }
        }

        private void compAc_btn_Click(object sender, EventArgs e)
        {
            string inputFile = filePathComAC_txtBox.Text;
            string outFile = "G:\\Compress Arithmetic.txt";
            ArithmetcCode.Compress(inputFile, outFile);
            nameCompAc_txtBox.Text = "Compress Arithmetic.txt";
            pathCompAc_txtBox.Text = "G:\\Compress Arithmetic.txt";
            MessageBox.Show("THe File Is Compressed Successfully");

        }

        private void deCompAc_btn_Click(object sender, EventArgs e)
        {
            string inputFile = filePathDecomAC_txtBox.Text;
            string outFile = "G:\\Decompress Arithmetic.txt";
            ArithmetcCode.Decompress(inputFile, outFile);
            nameDecomHuff_txtbox.Text = "Decompress Arithmetic.txt";
            pathDecomHuff_txtBox.Text = "G:\\Decompress Arithmetic.txt";
            MessageBox.Show("The File Is Decompressed Successfully");
        }

        private void selectDecmopSource_btn_Click(object sender, EventArgs e)
        {
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void compDic_btn_Click(object sender, EventArgs e)
        {
            string filePath;
            filePath = pathCompDic_txtBox.Text;
            StreamReader streamReader = new StreamReader(filePath);
            string s = streamReader.ReadLine();


            List<string> dic = new List<string>();
            List<int> code = new List<int>();
            dic.Add("a");
            dic.Add("b");
            dic.Add("c");
            code.Add(1);
            code.Add(2);
            code.Add(3);
            int count = 4;
            string c = "";
            string next = "";
            string output="";
            c = s[0].ToString();

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    next = s[i + 1].ToString();
                    if (!dic.Contains(c + next))
                    {
                        dic.Add(c + next);
                        code.Add(count++);
                        output += code.ElementAt(dic.IndexOf(c));
                        c = next;
                    }
                    else
                    {
                        c = c + next;
                    }
                }
                else
                {
                    output += code.ElementAt(dic.IndexOf(c));
                }

            }

            StreamWriter streamWriter = new StreamWriter("G:\\Compress Dic.txt");
            streamWriter.WriteLine(output);
            nameComDic_txtBox.Text = "Compress Dic.txt";
            pathFileComDic_txtBox.Text = "G:\\Compress Dic.txt";
            MessageBox.Show("The File Is Comperessed Successfully");

        }
    }
}
