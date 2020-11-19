using System;

namespace XiangQi
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard board = new GameBoard();
            board.GiveThePiece();
            board.DisplayBorad();
            Advisor AL = new Advisor('d', 9, Player_side.red);//红色方左仕
            Advisor AR = new Advisor('f', 9, Player_side.red);//红色方右仕
            Advisor DL = new Advisor('d', 0, Player_side.black);//黑色方左仕
            Advisor C = new Advisor('e', 1, Player_side.black);//黑色方仕在中间
            Cannon CL = new Cannon('b', 7, Player_side.red);
            Cannon CR = new Cannon('h', 7, Player_side.red);
            Input();
            C.ValidMovement(C.CanMoveTo(C.number_horizontal, C.vertical, C.side));
            C.Give(C.PlaceCango());

            static void Input()
            {
                Console.WriteLine("Please input the location of the chess you want to move（e.g. d9)");

                string inputa = Console.ReadLine();
                char h;
                int v = 0;
                foreach (char a in inputa)
                {
                    if (a >= 'a' && a <= 'i')
                    {
                        h = a;
                    }

                    else if (a >= '0' && a <= '9')
                    {
                        v = v + a;
                    }

                    else
                    {
                        Console.WriteLine("ERROR!Please input an existing location");
                    }
               
                }


                Console.WriteLine("Please input the location you want to arrive");
                string inputb = Console.ReadLine();
                foreach (char b in inputb)
                {
                    if (b >= 'a' && b <= 'i')
                    {
                        h = b;
                    }

                    else if (b >= '0' && b <= '9')
                    {
                        v = v + b;
                    }

                    else
                    {
                        Console.WriteLine("ERROR!Please input an existing location");
                    }

                }
            }
        }
    }
}

