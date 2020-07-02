using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typingGameAssessment
{
    class Words
    {
        private string wordText; //note to myself: simplify this code when finished       
        private int wordPositionX;
        private int wordPositionY;
        private double fallSpeed;
        public Words(string argWordText, int argWordPositionX, int argWordPositionY, double argfallSpeed)
        {
            
            wordText = argWordText;
            wordPositionX = argWordPositionX;
            wordPositionY = argWordPositionY;
            fallSpeed = argfallSpeed;
        }

        public string WordText
        {
            get { return wordText; }
            set { wordText = value; }
        }

        public int WordPositionX
        {
            get { return wordPositionX; }
            set { wordPositionX = value; }
        }
        public int WordPositionY
        {
            get { return wordPositionY; }
            set { wordPositionY = value; }
        }
        public double FallSpeed
        {
            get { return fallSpeed; }
            set { fallSpeed = value; }
        }
    }
}
