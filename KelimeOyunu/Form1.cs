using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cstr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        DataTable dt;
        SqlDataAdapter da;
        string word;
        bool bitti = false;
        byte counter = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select ProductName from Products",cstr);
            dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                string single = getFirstWord(item[0].ToString());
                lbProducts.Items.Add(single);
            }
            lbProducts.DisplayMember = "ProductName";
        }
                    
        
        private void findTheWord(string _word, bool stop)
        {
            int index = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item[0].ToString().StartsWith(_word[0].ToString()) && bitti == false)
                {
                    string single = getFirstWord(item[0].ToString());
                    lbResults.Items.Add(single);            //Önceki kelimenin son harfi, sıradaki
                                                            //kelimenin baş harfiyse sonuçlara ekliyor
                    lbProducts.Items.Remove(single);
                    dt.Rows.RemoveAt(index);
                    word = reverseString(single).ToString();
                    findTheWord(word.ToUpper(),bitti);      //findTheWord önceki kelimenin son harfini
                    counter++;                              //alarak yeniden çalışıyor
                    break;
                }

                index++;
            }
            bitti = true;
         }


        private string getFirstWord(string twoOrMoreWords)
        {
            string[] str = twoOrMoreWords.Split(' ');
            return str[0];
        }


        private char reverseString(string normal) {
            char[] original = normal.ToCharArray();
            return original[original.Length - 1];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            findTheWord(txtGuess.Text,bitti);
            MessageBox.Show("Başka kelime bulunamadı.");
            lblWordsFound.Text = counter + " adet kelime bulundu.";
            lbResults.Items.Add("---------------------");
            bitti = false;
            //MessageBox.Show(""+reverseString(textBox1.Text));

        }
    }
}
