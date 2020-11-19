using System;
using System.Collections.Generic;
using System.Text;

namespace XiangQi
{
    class GameBoard
    {
       Piece[,] theboard = new Piece[10, 9];
        public int LetterTonumber_swtich(char horizontal)
        {
            int h = 0;
            switch (horizontal)
            {
                case 'a': h = 0; break;
                case 'b': h = 1; break;
                case 'c': h = 2; break;
                case 'd': h = 3; break;
                case 'e': h = 4; break;
                case 'f': h = 5; break;
                case 'g': h = 6; break;
                case 'h': h = 7; break;
                case 'i': h = 8; break;
                default:
                    break;
            }
            return h;
        }
        public char NumberToletter_switch(int number)
        {
            char letter = 'a';
            switch (number)
            {
                case 0: letter = 'a'; break;
                case 1: letter = 'b'; break;
                case 2: letter = 'c'; break;
                case 3: letter = 'd'; break;
                case 4: letter = 'e'; break;
                case 5: letter = 'f'; break;
                case 6: letter = 'g'; break;
                case 7: letter = 'h'; break;
                case 8: letter = 'i'; break;
                default: break;
            }
            return letter;
        }
        public void GiveThePiece()//给棋盘所有棋子赋值
        {
            for (int i = 0; i < theboard.GetLength(0); i++)
            {
                for (int j = 0; j < theboard.GetLength(1); j++)
                {
                    theboard[i,j] = new Piece(NumberToletter_switch(j), i);
                    theboard[i, j].type = Piece_type.blank;
                    theboard[i, j].side = Player_side.blank;
                }
            }
            
            theboard[9, 0] = new Rook('a', 9, Player_side.red);
            theboard[9, 1] = new Horse('b', 9, Player_side.red);
            theboard[9, 2] = new Elephant('c', 9, Player_side.red);
            theboard[9, 3] = new Advisor('d', 9, Player_side.red);
            theboard[9, 4] = new General('e', 9, Player_side.red);
            theboard[9, 5] = new Advisor('f', 9, Player_side.red);
            theboard[9, 6] = new Elephant('g', 9, Player_side.red);
            theboard[9, 7] = new Horse('h', 9, Player_side.red);
            theboard[9, 8] = new Rook('i', 9, Player_side.red);
            theboard[7, 1] = new Cannon('b', 7, Player_side.red);
            theboard[7, 7] = new Cannon('h', 7, Player_side.red);
            theboard[6, 0] = new Soldier('a', 6, Player_side.red);
            theboard[6, 2] = new Soldier('c', 6, Player_side.red);
            theboard[6, 4] = new Soldier('e', 6, Player_side.red);
            theboard[6, 6] = new Soldier('g', 6, Player_side.red);
            theboard[6, 8] = new Soldier('i', 6, Player_side.red);

            theboard[0, 0] = new Rook('a', 0, Player_side.black);
            theboard[0, 1] = new Horse('b', 0, Player_side.black);
            theboard[0, 2] = new Elephant('c', 0, Player_side.black);
            theboard[0, 3] = new Advisor('d', 0, Player_side.black);
            theboard[0, 4] = new General('e', 0, Player_side.black);
            theboard[0, 5] = new Advisor('f', 0, Player_side.black);
            theboard[0, 6] = new Elephant('g', 0, Player_side.black);
            theboard[0, 7] = new Horse('h', 0, Player_side.black);
            theboard[0, 8] = new Rook('i', 0, Player_side.black);
            theboard[2, 1] = new Cannon('b', 2, Player_side.black) ;
            theboard[2, 7] = new Cannon('h', 2, Player_side.black);
            theboard[3, 0] = new Soldier('a', 3, Player_side.black);
            theboard[3, 2] = new Soldier('c', 3, Player_side.black);
            theboard[3, 4] = new Soldier('e', 3, Player_side.black);
            theboard[3, 6] = new Soldier('g', 3, Player_side.black);
            theboard[3, 8] = new Soldier('i', 3, Player_side.black);
        }
        public void DisplayBorad()
        {
            /*Piece[,] P = new Piece[10, 9];
            GameBoard board = new GameBoard();
            P = board.Return_pieces();*/
            for (int i = 0; i < theboard.GetLength(0); i++)
            {
                for (int j = 0; j < theboard.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write(i);
                        
                    }
                     switch (theboard[i,j].type)
                     {
                         case Piece_type.blank:Console.Write("十");break;
                         case Piece_type.Rook:Console.Write("车");break;
                         case Piece_type.Horse:Console.Write("马");break;
                         case Piece_type.Elephant:Console.Write("象");break;
                         case Piece_type.Advisor: Console.Write("士"); break;
                         case Piece_type.General:Console.Write("帅");break;
                         case Piece_type.Cannon:Console.Write("炮");break;
                         case Piece_type.Soldier:Console.Write("兵");break;
                         default:break;
                     }
                    if (j == 8)
                    {
                        Console.Write('\n');
                    }
                }
            }
        }
        public Piece[,] Return_pieces()
        {
            return theboard;
        }
        public void SwitchPlayer()
        {

        }
        public void SelectPiece()
        {

        }
        public void MovePiece()
        {

        }
        public void CalculateValidMoves()
        {

        }
        
    }
}
