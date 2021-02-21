namespace _2012_Bio
{
    class Junction
    {
        public char current;
        public char straight;
        public char nextL;
        public char nextR;
        public Junction(char current, char straight, char nextL, char nextR)
        {
            this.current = current;
            this.straight = straight;
            this.nextL = nextL;
            this.nextR = nextR;
        }
        //This is whether the Junction is flip-flop or lazy where lazy is represented by True
        public bool state = true;
        // where left is True and right is repreented by False
        public bool direction = true;
        public bool arrival { set; get; }
        public void FlipDirection()
        {
            direction = !direction;
        }
        public void FlipState()
        {
            state = !state;
        }
        //when the train enters from a straight
        public char PassStraight()
        {
            if (direction)
            {
                if (!state)
                {
                    direction = !direction;
                }
                return nextL;
            }
            else
            {
                return nextR;
            }
        }
        //when the train enters from a bend
        public char PassBend()
        {
            direction = this.arrival;
            return straight;
        }
    }
}
