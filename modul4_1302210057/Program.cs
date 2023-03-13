public class PosisiKarakterGame
{
    enum State { Tengkurap, Jongkok, Berdiri, Terbang };
    public static void Main()
    {
        State state = State.Tengkurap;
        //String[] output = { "Pintu terkunci", "Pintu tidak terkunci" };
        while (true)
        {
            Console.WriteLine(state);
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();
            if (command == "TombolS")
            {
                Console.WriteLine("tombol arah bawah ditekan");
            }else if (command== "TombolW") {
                Console.WriteLine("tombol arah atas ditekan");

            }
            switch (state)
            {
                case State.Tengkurap:
                    if (command == "TombolW")
                        state = State.Jongkok;

                    break;
                case State.Jongkok:

                    if (command == "TombolS")
                        state = State.Tengkurap;
                    else if (command == "TombolW")
                    {
                        state = State.Berdiri;
                    }
                    break;
                case State.Berdiri:
                    if (command == "TombolS")
                        state = State.Jongkok;
                    else if (command == "TombolW")
                        state = State.Terbang;

                    break;
                case State.Terbang:
                    if(command == "TombolX")
                    {
                        state = State.Jongkok;

                    }else if (command == "TombolS")
                    {
                        state = State.Berdiri;
                    }
                    break;

            }
        }
    }
}