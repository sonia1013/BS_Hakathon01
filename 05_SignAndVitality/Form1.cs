using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _05_SignAndVitality
{
    public partial class Form1 : Form
    {
        static List<StarSign> KnowStarSigns()
        {
            return new List<StarSign>()
            {
                new StarSign() { starname = "Aquarius" ,month1=1,month2=2},
                new StarSign() { starname = "Pisces",month1=2,month2=3 },
                new StarSign() { starname = "Aries",month1=3,month2=4 },
                new StarSign() { starname = "Taurus",month1=4,month2=5},
                new StarSign() { starname = "Gemimi",month1=5,month2=6},
                new StarSign() { starname = "Cancer",month1=6,month2=7},
                new StarSign() { starname = "Leo",month1=7,month2=8},
                new StarSign() { starname = "Virgo",month1=8,month2=9},
                new StarSign() { starname = "Libra",month1=9,month2=10},
                new StarSign() { starname = "Scorpio",month1=10,month2=11},
                new StarSign() { starname = "Sagittarius",month1=11,month2=12},
                new StarSign() { starname = "Capricorn",month1=12,month2=1 }
            };
        }
        static DateTimePicker dtp = new DateTimePicker();
        static int birthday = dtp.Value.Month;
        static int birthmonth = dtp.Value.Day;
        static int birthyear = dtp.Value.Year;

        private string GetVitality()
        {
            string vitality;
            return birthyear.ToString() + birthmonth.ToString() + birthday.ToString();
        }


        static void GetStarSign()
        {
            if (birthmonth >= 3 && birthday >= 20 && birthmonth < 4 && birthday < 21)
            {
                return 
            }
            else if (/* some other sign */)
            {

            }
        }




        public Form1()
        {
            InitializeComponent();
        }



        //dateTimePicker1.Value = new DateTime(2001, 10, 20);
        //選擇日期區間，區分12個星座

        private void ShowResult_Click(object sender, EventArgs e)
        {
            //Result.Text = (dateTimePicker1.Value).ToString;
            Result.Text = GetVitality();
        }

    }
}
