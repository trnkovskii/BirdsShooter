using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    [Serializable]
    public class BirdsDoc
    {
        public List<Bird> Birds { get; set; }
        public int points { get; set; }
        private SoundPlayer[] sounds;

        public BirdsDoc()
        {
            Birds = new List<Bird>();
            points = 0;
            sounds = new SoundPlayer[8];
            sounds[0] = new System.Media.SoundPlayer(Resources._1);
            sounds[1] = new System.Media.SoundPlayer(Resources._2);
            sounds[2] = new System.Media.SoundPlayer(Resources._3);
            sounds[3] = new System.Media.SoundPlayer(Resources._4);
            sounds[4] = new System.Media.SoundPlayer(Resources._5);
            sounds[5] = new System.Media.SoundPlayer(Resources._6);
            sounds[6] = new System.Media.SoundPlayer(Resources.Snip_lose_01);
            sounds[7] = new System.Media.SoundPlayer(Resources.ringtone);

        }

        public void Draw(Graphics g)
        {
            foreach (Bird bird in Birds)
            {
                bird.Draw(g);
            }
        }

        public void AddBird(Bird bird)
        {
            Birds.Add(bird);
        }

        public void MoveBirds()
        {
            foreach (Bird bird in Birds)
            {
                bird.Move();
            }
        }

        public bool CheckMissed()
        {
            bool brojac = false;
            foreach (Bird bird in Birds)
            {
                if (bird.Missed())
                {
                    brojac = true;
                }
            }

            return brojac;
        }



        public void CheckForExplosions(float x, float y)
        {
            for (int i = 0; i < Birds.Count; i++)
            {
                for (int j = i + 1; j < Birds.Count; j++)
                {
                    if (Birds[i].IsHit(x, y))
                    {
                        Birds[i].Flag = true;

                    }
                }
            }
            for (int i = Birds.Count - 1; i >= 0; i--)
            {
                if (Birds[i].Flag)
                {
                    if (Birds[i].bomba == true)
                    {

                        sounds[0].Play();
                        points -= 5;
                    }
                    else
                    {
                        Random random = new Random();
                        int ran = random.Next(1, 5);
                        sounds[ran].Play();
                        points += 10;
                    }
                    Birds.RemoveAt(i);

                }
                else
                {
                    sounds[7].Play();
                }
            }

        }

        private BirdsDoc(SerializationInfo info, StreamingContext context)
        {

            if (Birds != null && points != 0 && sounds != null)
            {
                Birds = (List<Bird>)info.GetValue("Birds:", typeof(List<Bird>));
                points = (int)info.GetValue("Points:", typeof(int));
                sounds = (SoundPlayer[])info.GetValue("Sounds:", typeof(SoundPlayer[]));
            }

        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {

            inf.AddValue("Birds", Birds);
            inf.AddValue("Points", points);
            inf.AddValue("Sounds", sounds);


        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Birds: \n ");
            for (int i = 0; i < Birds.Count; i++)
            {

                str.AppendFormat("{0} ", Birds[i]);
                if (i == Birds.Count - 1)
                    str.AppendFormat(", \t\n");
            }
            str.AppendFormat("Points: {0}\r\n", points);
            str.AppendFormat("Sounds: ");
            for (int j = 0; j < sounds.Count(); j++)
            {

                str.AppendFormat("{0} ", sounds[j]);
                if (j == sounds.Count() - 1)
                    str.AppendFormat(", \t\n");
            }
            return str.ToString();
        }

    }
}
