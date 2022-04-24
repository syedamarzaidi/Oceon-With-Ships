using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sea.BL;
namespace Sea.BL{
    class Angle
    {
        public Angle()
        {

        }
        public Angle(int degree, int minutes, char direction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;
        }
        private int degree;
        private int minutes;
        private char direction;
        public int getDegree()
        {
            return degree;
        }
        public int getMinutes()
        {
            return minutes;
        }
        public char getDirection()
        {
            return direction;
        }
        public void setDegree(int degree)
        {
            if(degree <= 180)
            {
                this.degree = degree;
            }
        }
        public void setMinutes(int minutes)
        {
            this.minutes = minutes;
        }
        public void setDirection(char direction)
        {
            this.direction = direction;
        }
        public void changeCompleteAngle(Angle direc)
        {
            this.degree = direc.degree;
            this.minutes = direc.minutes;
            this.direction = direc.direction;
        }
        public static Angle getAngle(string direc) //same will be for latitiude
        {
            string degree = "";
            string minutes = "";
            string direction = "";
            int count = 1;
            for (int i = 0; i < direc.Length; i++)
            {
                if (count == 1)
                {
                    if (direc[i] != '\u00b0')
                    {
                        degree = degree + direc[i];
                    }
                    else
                    {
                        count++;
                    }
                }
                else if (count == 2)
                {
                    if (direc[i] != '\'')
                    {
                        minutes = minutes + direc[i];
                    }
                    else
                    {
                        count++;
                    }
                }
                else if (count == 3)
                {
                    direction = direc[i] + direction;
                }
            }
            int d = int.Parse(degree);
            int m = int.Parse(minutes);
            char dir = char.Parse(direction);
            Angle temp = new Angle(d, m, dir);
            return temp;
        }
        public static bool isObjectsEqual(Angle s, Angle t)
        {
            if (s.degree == t.degree && s.minutes == t.minutes && s.direction == t.direction)
            {
                return true;
            }
            return false;
        }

    }
}
