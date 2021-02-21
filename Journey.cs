using System;
namespace _2012_Bio
{
    class Journey
    {
        string Position;
        int Passing;
        Junction[] layout;
        public Journey(string Flipped, string Start, int pass, Junction[] layout)
        {
            char[] Flip_Flop = Flipped.ToCharArray();
            Position = Start;
            Passing = pass;
            this.layout = layout;
            Junction From = layout[FindIndex(Position[0])];
            Junction To = layout[FindIndex(Position[1])];
            foreach (char i in Flip_Flop)
            {
                layout[FindIndex(i)].state = !layout[FindIndex(i)].state;
            }
            while (Passing != 0)
            {
                if (((To.current == From.nextL || To.current == From.nextR) && (From.current == To.nextL || From.current == To.nextR)) || ((From.straight == To.current) && (To.straight != From.current)))
                {
                    if (To.nextL == From.current)
                    {
                        To.arrival = true;
                    }
                    else if (To.nextR == From.current)
                    {
                        To.arrival = false;
                    }
                    From = To;
                    To = layout[FindIndex(To.PassBend())];
                }
                else
                {
                    From = To;
                    To = layout[FindIndex(To.PassStraight())];
                }
                Passing -= 1;
                Console.WriteLine(char.ToString(From.current) + char.ToString(To.current));
            }
            Console.WriteLine(char.ToString(From.current) + char.ToString(To.current));
        }
        public int FindIndex(Junction J)
        {
            int count = 0;
            foreach (Junction i in layout)
            {
                if (i == J)
                {
                    return count;
                }
                count += 1;
            }
            return default;
        }
        public int FindIndex(char J)
        {
            int count = 0;
            foreach (Junction i in layout)
            {
                if (i.current == J)
                {
                    return count;
                }
                count += 1;
            }
            return default;
        }
    }
}
