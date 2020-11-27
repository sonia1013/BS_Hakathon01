using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_NumberGuess
{
    public partial class Form1 : Form
    {
        //static string start = " ";
     
        public Form1()
        {
            InitializeComponent();

        }
        int[] input_array = new int[3];

        List<int> random4DigitNumber = new List<int>();
        //用linq產生隨機不重複的十個數字
           
        private void StartGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            List<int> rndanswer = new List<int>(Enumerable.Range(0, 10));
            random4DigitNumber = rndanswer.OrderBy(num => rnd.Next()).Take(4).ToList<int>();
        }

        private string CheckNumbers()
        {
            int countA = 0;
            int countB = 0;
            var inputans = player_input.Text.Select(x => x.ToString());

            int position = 0;
            foreach (string item in inputans)
            {

                    //input_array[position] = ;
                    Console.WriteLine(item + ":" + position.ToString());
                    if (NumPositionCheck(position, int.Parse(item), random4DigitNumber))
                    {

                        countA++;
                    }
                    else if (IfExistNumMatch(position++, int.Parse(item), random4DigitNumber))
                    {
                        countB++;
                    }

            }
            return $"{countA}A{countB}B";
        }

        private void LookUpAns_Click(object sender, EventArgs e)
        {
            //StringBuilder builder = new StringBuilder();
            //// Loop through all strings.
            //foreach (int item in random4DigitNumber)
            //{
            //    // Append string to StringBuilder.
            //    builder.Append(item);
            //}
            //// Get string from StringBuilder.
            //string result = builder.ToString();
            //Console.WriteLine(result);

            string s1 = string.Join("", random4DigitNumber);

            MessageBox.Show("答案是:" + s1);
        }

        private void GiveUp_Click(object sender, EventArgs e)
        {
            random4DigitNumber.Clear();
        }

        private void CheckAns_Click(object sender, EventArgs e)
        {
 
            History.Items.Add( player_input.Text + ":" + CheckNumbers() );
        }

        //先呼叫function判斷位置
        private bool NumPositionCheck(int position, int input_value, List<int> random_answer)
        {
            return input_value == random_answer[position];
        }
        //如果位置不對，再判斷是否存在
        private bool IfExistNumMatch(int position, int input_value, List<int> random_answer)
        {
            return random_answer.Contains(input_value);
        }

    }
}
