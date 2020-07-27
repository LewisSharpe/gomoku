using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Minimax_TPL
{
    /* 
    ----------------------------------------------------------------------------------------------------------------
     * GameBoard_TPL.CS -
    --------------------------------------------------------------------------------------------------------------------------
    Struct class controls all constructs of GameBoard including printing.
    --------------------------------------------------------------------------------------------------------------------------
    */
    struct GameBoard_TPL <T> where T: IComparable
    {
        // PUBLIC DECLARATIONS
        public T     s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15,
                     s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30,
                     s31, s32, s33, s34, s35, s36, s37, s38, s39, s40, s41, s42, s43, s44, s45, s46,
                     s47, s48, s49, s50, s51, s52, s53, s54, s55, s56, s57, s58, s59, s60, s61, s62,
                     s63, s64, s65, s66, s67, s68, s69, s70, s71, s72, s73, s74, s75, s76, s77, s78,
                     s79, s80, s81, s82, s83, s84, s85, s86, s87, s88, s89, s90, s91, s92, s93, s94,
                     s95, s96, s97, s98, s99, s100, s101, s102, s103, s104, s105, s106, s107, s108,
                     s109, s110, s111, s112, s113, s114, s115,  s116, s117, s118, s119, s120, s121, 
                     s122, s123, s124, s125, s126, s127, s128, s129, s130,  s131, s132, s133, s134,
                     s135, s136, s137, s138, s139, s140, s141, s142, s143, s144, s145, s146, s147, 
                     s148, s149, s150, s151, s152, s153, s154, s155, s156, s157, s158, s159, s160, 
		             s161, s162, s163, s164, s165, s166, s167, s168, s169, s170, s171, s172, s173, s174, s175, 
		             s176, s177, s178, s179, s180, s181, s182, s183, s184, s185, s186, s187, s188, s189, s190, 
		             s191, s192, s193, s194, s195, s196, s197, s198, s199, s200, s201, s202, s203, s204, s205, 
		             s206, s207, s208, s209, s210, s211, s212, s213, s214, s215, s216, s217, s218, s219, s220, 
                     s221, s222, s223, s224, s225;

        public T filler; // empty filler space for cell
        /* 
----------------------------------------------------------------------------------------------------------------
* GameBoard_TPL constructor -
--------------------------------------------------------------------------------------------------------------------------
Constructs initial blank board.
--------------------------------------------------------------------------------------------------------------------------
*/
        public GameBoard_TPL(T _filler)
        {
            filler = _filler; // blank filler
            s1 = filler; s2 = filler; s3 = filler; s4 = filler; s5 = filler; s6 = filler; s7 = filler; s8 = filler; s9 = filler; s10 = filler; s11 = filler; s12 = filler; s13 = filler; s14 = filler; s15 = filler; // row 1
            s16 = filler; s17 = filler; s18 = filler; s19 = filler; s20 = filler; s21 = filler; s22 = filler; s23 = filler; s24 = filler; s25 = filler; s26 = filler; s27 = filler; s28 = filler; s29 = filler; s30 = filler; // row 2
            s31 = filler; s32 = filler; s33 = filler; s34 = filler; s35 = filler; s36 = filler; s37 = filler; s38 = filler; s39 = filler; s40 = filler; s41 = filler; s42 = filler; s43 = filler; s44 = filler; s45 = filler; // row 3
            s46 = filler; s47 = filler; s48 = filler; s49 = filler; s50 = filler; s51 = filler; s52 = filler; s53 = filler; s54 = filler; s55 = filler; s56 = filler; s57 = filler; s58 = filler; s59 = filler; s60 = filler; // row 4
            s61 = filler; s62 = filler; s63 = filler; s64 = filler; s65 = filler; s66 = filler; s67 = filler; s68 = filler; s69 = filler; s70 = filler; s71 = filler; s72 = filler; s73 = filler; s74 = filler; s75 = filler; // row 5
            s76 = filler; s77 = filler; s78 = filler; s79 = filler; s80 = filler; s81 = filler; s82 = filler; s83 = filler; s84 = filler; s85 = filler; s86 = filler; s87 = filler; s88 = filler; s89 = filler; s90 = filler; // row 6
            s91 = filler; s92 = filler; s93 = filler; s94 = filler; s95 = filler; s96 = filler; s97 = filler; s98 = filler; s99 = filler; s100 = filler; s101 = filler; s102 = filler; s103 = filler; s104 = filler; s105 = filler; // row 7
            s106 = filler; s107 = filler; s108 = filler; s109 = filler; s110 = filler; s111 = filler; s112 = filler; s113 = filler; s114 = filler; s115 = filler; s116 = filler; s117 = filler; s118 = filler; s119 = filler; s120 = filler; // row 8
            s121 = filler; s122 = filler; s123 = filler; s124 = filler; s125 = filler; s126 = filler; s127 = filler; s128 = filler; s129 = filler; s130 = filler; s131 = filler; s132 = filler; s133 = filler; s134 = filler; s135 = filler; // row 9
            s136 = filler; s137 = filler; s138 = filler; s139 = filler; s140 = filler; s141 = filler; s142 = filler; s143 = filler; s144 = filler; s145 = filler; s146 = filler; s147 = filler; s148 = filler; s149 = filler; s150 = filler; // row 10
            s151 = filler; s152 = filler; s153 = filler; s154 = filler; s155 = filler; s156 = filler; s157 = filler; s158 = filler; s159 = filler; s160 = filler; s161 = filler; s162 = filler; s163 = filler; s164 = filler; s165 = filler; // row 11
            s166 = filler; s166 = filler; s167 = filler; s168 = filler; s169 = filler; s170 = filler; s171 = filler; s172 = filler; s173 = filler; s174 = filler; s175 = filler; s176 = filler; s177 = filler; s178 = filler; s179 = filler; // row 12
            s180 = filler; s181 = filler; s182 = filler; s183 = filler; s184 = filler; s185 = filler; s186 = filler; s187 = filler; s188 = filler; s189 = filler; s190 = filler; s191 = filler; s192 = filler; s193 = filler; s194 = filler; s195 = filler; // row 13
            s196 = filler; s197 = filler; s198 = filler; s199 = filler; s200 = filler; s201 = filler; s202 = filler; s203 = filler; s204 = filler; s205 = filler; s206 = filler; s207 = filler; s208 = filler; s209 = filler; s210 = filler; // row 14
            s211 = filler; s212 = filler; s213 = filler; s214 = filler; s215 = filler; s216 = filler; s217 = filler; s218 = filler; s219 = filler; s220 = filler; s221 = filler; s222 = filler; s223 = filler; s224 = filler; s225 = filler; // row 15





        }
        /* 
----------------------------------------------------------------------------------------------------------------
* DisplayBoard -
--------------------------------------------------------------------------------------------------------------------------
This method constructs current board with the counter symbols in string format which will then be printed to the Console window.
--------------------------------------------------------------------------------------------------------------------------
*/
        public void DisplayBoard()
        {
            //  Console.Clear();
            for (int x = 1; x <= 15; x++)
                Console.Write("  " + x + " ");
            Console.WriteLine();
            for (int y = 1; y <= 15; y++)
            {
                Console.Write(y + " ");
                for (int x = 1; x <= 15; x++)
                {
		  Console.Write(this[x, y].CompareTo(counters.e)==0 ? " " : this[x, y].ToString());
                    Console.Write(" | ");
                }
                Console.WriteLine();
                Console.WriteLine("  -   -   -   -   -   -   - ");
            }
            Console.WriteLine();
        }

        /* 
----------------------------------------------------------------------------------------------------------------
* DisplayScoreBoard -
--------------------------------------------------------------------------------------------------------------------------
This method constructs current board with the counter symbols represented in integer format which will then be printed to the Console window.
--------------------------------------------------------------------------------------------------------------------------
*/
        public void DisplayScoreBoard()
        {
            //  Console.Clear();
            for (int x = 1; x <= 15; x++)
                Console.Write("  " + x + " ");
            Console.WriteLine();
            for (int y = 1; y <= 15; y++)
            {
                Console.Write(y + " ");
                for (int x = 1; x <= 15; x++)
                {
                    if (EqualityComparer<T>.Default.Equals(this[x, y], filler))
                        Console.Write(filler);
                    else
                        Console.Write(this[x, y]);
                    Console.Write(" | ");

                }
                Console.WriteLine();
                Console.WriteLine("  -   -   -   -   -   -   - ");
            }
            Console.WriteLine();
        }
        /* 
----------------------------------------------------------------------------------------------------------------
* DisplayFinBoardToFile -
--------------------------------------------------------------------------------------------------------------------------
This method constructs current finished board ending in Win or Draw and then prints it to a file.
--------------------------------------------------------------------------------------------------------------------------
*/
        public void DisplayFinBoardToFile()
        {
	  // string path = @"C:/Users/Lewis/Desktop/files_150819/ttt_csharp_270719/Minimax_TPL/boards/finboards.txt";
            string path = @"data/finboards.txt";
            // This text is added only once to the file.
            // Create a file to write to.
	    // File.WriteAllText(@"C:/Users/Lewis/Desktop/files_150819/ttt_csharp_270719/Minimax_TPL/boards/finboards.txt", string.Empty);
             File.WriteAllText(@"data/finboards.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(Environment.NewLine);
                //     System.IO.File.WriteAllText(@"C:/Users/Lewis/Desktop/files_150819/ttt_csharp_270719/Minimax_TPL/finboards.txt", string.Empty);
                for (int x = 1; x <= 15; x++)
                    sw.Write("  " + x + " ");
                sw.WriteLine();
                for (int y = 1; y <= 15; y++)
                {
                    sw.Write(y + " ");
                    for (int x = 1; x <= 15; x++)
                    {
                        if (EqualityComparer<T>.Default.Equals(this[x, y], filler))
                            sw.Write(filler);
                        else
                            sw.Write(this[x, y]);
                        sw.Write(" | ");
                    }
                    sw.WriteLine();
                    sw.WriteLine("  -   -   -   -   -   -   - ");
                }
                sw.Write("^^ FIN BOARD FOR BOARD " + Program.cntr);
                sw.WriteLine();
            }
        }
        /* 
----------------------------------------------------------------------------------------------------------------
* DisplayScoreBoardToFile -
--------------------------------------------------------------------------------------------------------------------------
This method constructs current finished score board ending in Win or Draw and then prints it to a file.
--------------------------------------------------------------------------------------------------------------------------
*/
        public void DisplayScoreBoardToFile()
        {
            string path = @"data/scoreboards.txt";
            // This text is added only once to the file.
            // Create a file to write to.
            // File.WriteAllText(@"C:/Users/Lewis/Desktop/files_150819/ttt_csharp_270719/Minimax_TPL/boards/scoreboards.txt", string.Empty);
             File.WriteAllText(@"data/scoreboards.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter(path, true))
            {

                sw.Write(Environment.NewLine);
                //      System.IO.File.WriteAllText(@"C:/Users/Lewis/Desktop/files_150819/ttt_csharp_270719/Minimax_TPL/scoreboards.txt", string.Empty);
                for (int x = 1; x <= 15; x++)
                    sw.Write("  " + x + " ");
                sw.WriteLine();
                for (int y = 1; y <= 15; y++)
                {
                    sw.Write(y + " ");
                    for (int x = 1; x <= 15; x++)
                    {
                        if (EqualityComparer<T>.Default.Equals(this[x, y], filler))
                            sw.Write(filler);
                        else
                            sw.Write(this[x, y]);
                        sw.Write(" | ");
                    }
                    sw.WriteLine();
                    sw.WriteLine("  -   -   -   -   -   -   - ");
                }
                sw.Write("^^ SCORE BOARD FOR BOARD " + Program.cntr);
                sw.WriteLine();
            }
        }
        /* 
----------------------------------------------------------------------------------------------------------------
* IsFull -
--------------------------------------------------------------------------------------------------------------------------
This boolean method returns a true or false value confirming if the current board in play is full with no empty cells remaining.
--------------------------------------------------------------------------------------------------------------------------
*/
        // IF GameBoard_TPL IS FULL
        public bool IsFull(int size)
        {
            for (int x = 1; x <= size; x++)
                for (int y = 1; y <= size; y++)
                    if (EqualityComparer<T>.Default.Equals(this[x, y], filler))
                        return false;
            return true;
        }
        /* 
----------------------------------------------------------------------------------------------------------------
* IsEmpty -
--------------------------------------------------------------------------------------------------------------------------
This boolean method returns a true or false value confirming if there any remaining empty cells in play on the current board.
--------------------------------------------------------------------------------------------------------------------------
*/
        public bool IsEmpty(int size)
        {
            for (int x = 1; x <= size; x++)
                for (int y = 1; y <= size; y++)
                    if (!EqualityComparer<T>.Default.Equals(this[x, y], filler))
                        return false;
            return true;
        }

        // CLONE A board OF THE CURRENT GAME BOARD
        /* 
----------------------------------------------------------------------------------------------------------------
* Clone -
--------------------------------------------------------------------------------------------------------------------------
This method makes a clone of the current board, either playing board (string) or score board (int).
--------------------------------------------------------------------------------------------------------------------------
*/
        public GameBoard_TPL<T> Clone()
        {
            GameBoard_TPL<T> g = new GameBoard_TPL<T>();
            for (int x = 1; x <= 15; x++)
                for (int y = 1; y <= 15; y++)
                    g[x, y] = this[x,y];
            return g;
            
        }
        /* 
----------------------------------------------------------------------------------------------------------------
* board[x,y] -> this[x,y] -
--------------------------------------------------------------------------------------------------------------------------
The method returns a coordinate position in an <int,int> format existing in the current board. 
--------------------------------------------------------------------------------------------------------------------------
*/
        public T this[int x, int y]
        {
            get
            {
                // Debug.Assert(1 <= x && x <= 3 && 1 <= y && y <= 3);
                /*
                if (!(1 <= x && x <= 7 && 1 <= y && y <= 7)) {
              Console.WriteLine("ERROR: illegal position on board: {0},{1}", x, y);
              Environment.Exit(98);
              // return counters.BORDER;
                }
                */
                if (x == 1 && y == 1)
                    return s1;
                if (x == 2 && y == 1)
                          return s2;
                      if (x == 3 && y == 1)
                          return s3;
                      if (x == 4 && y == 1)
                          return s4;
                      if (x == 5 && y == 1)
                          return s5;
                      if (x == 6 && y == 1)
                          return s6;
                      if (x == 7 && y == 1)
                          return s7;
                      if (x == 8 && y == 1)
                          return s8;
                      if (x == 9 && y == 1)
                          return s9;
                      if (x == 10 && y == 1)
                          return s10;
                      if (x == 11 && y == 1)
                          return s11;
                      if (x == 12 && y == 1)
                          return s12;
                      if (x == 13 && y == 1)
                          return s13;
                      if (x == 14 && y == 1)
                          return s14;
                      if (x == 15 && y == 1)
                          return s15;
                      if (x == 1 && y == 2)
                          return s16;
                      if (x == 2 && y == 2)
                          return s17;
                      if (x == 3 && y == 2)
                          return s18;
                      if (x == 4 && y == 2)
                          return s19;
                      if (x == 5 && y == 2)
                          return s20;
                      if (x == 6 && y == 2)
                          return s21;
                      if (x == 7 && y == 2)
                          return s22;
                      if (x == 8 && y == 2)
                          return s23;
                      if (x == 9 && y == 2)
                          return s24;
                      if (x == 10 && y == 2)
                          return s25;
                      if (x == 11 && y == 2)
                          return s26;
                      if (x == 12 && y == 2)
                          return s27;
                      if (x == 13 && y == 2)
                          return s28;
                      if (x == 14 && y == 2)
                          return s29;
                      if (x == 15 && y == 2)
                          return s30;
                      if (x == 1 && y == 3)
                          return s31;
                      if (x == 2 && y == 3)
                          return s32;
                      if (x == 3 && y == 3)
                          return s33;
                      if (x == 4 && y == 3)
                          return s34;
                      if (x == 5 && y == 3)
                          return s35;
                      if (x == 6 && y == 3)
                          return s36;
                      if (x == 7 && y == 3)
                          return s37;
                      if (x == 8 && y == 3)
                          return s38;
                      if (x == 9 && y == 3)
                          return s39;
                      if (x == 10 && y == 3)
                          return s40;
                      if (x == 11 && y == 3)
                          return s41;
                      if (x == 12 && y == 3)
                          return s42;
                      if (x == 13 && y == 3)
                          return s43;
                      if (x == 14 && y == 3)
                          return s44;
                      if (x == 15 && y == 3)
                          return s45;
                      if (x == 1 && y == 4)
                          return s46;
                      if (x == 2 && y == 4)
                          return s47;
                      if (x == 3 && y == 4)
                          return s48;
                      if (x == 4 && y == 4)
                          return s49;
                      if (x == 5 && y == 4)
                          return s50;
                      if (x == 6 && y == 4)
                          return s51;
                      if (x == 7 && y == 4)
                          return s52;
                      if (x == 8 && y == 4)
                          return s53;
                      if (x == 9 && y == 4)
                          return s54;
                      if (x == 10 && y == 4)
                          return s55;
                      if (x == 11 && y == 4)
                          return s56;
                      if (x == 12 && y == 4)
                          return s57;
                      if (x == 13 && y == 4)
                          return s58;
                      if (x == 14 && y == 4)
                          return s59;
                      if (x == 15 && y == 4)
                          return s60;
                      if (x == 1 && y == 5)
                          return s61;
                      if (x == 2 && y == 5)
                          return s62;
                      if (x == 3 && y == 5)
                          return s63;
                      if (x == 4 && y == 5)
                          return s64;
                      if (x == 5 && y == 5)
                          return s65;
                      if (x == 6 && y == 5)
                          return s66;
                      if (x == 7 && y == 5)
                          return s67;
                      if (x == 8 && y == 5)
                          return s68;
                      if (x == 9 && y == 5)
                          return s69;
                      if (x == 10 && y == 5)
                          return s70;
                      if (x == 11 && y == 5)
                          return s71;
                      if (x == 12 && y == 5)
                          return s72;
                      if (x == 13 && y == 5)
                          return s73;
                      if (x == 14 && y == 5)
                          return s74;
                      if (x == 15 && y == 5)
                          return s75;
                      if (x == 1 && y == 6)
                          return s76;
                      if (x == 2 && y == 6)
                          return s77;
                      if (x == 3 && y == 6)
                          return s78;
                      if (x == 4 && y == 6)
                          return s79;
                      if (x == 5 && y == 6)
                          return s80;
                      if (x == 6 && y == 6)
                          return s81;
                      if (x == 7 && y == 6)
                          return s82;
                      if (x == 8 && y == 6)
                          return s83;
                      if (x == 9 && y == 6)
                          return s84;
                      if (x == 10 && y == 6)
                          return s85;
                      if (x == 11 && y == 6)
                          return s86;
                      if (x == 12 && y == 6)
                          return s87;
                      if (x == 13 && y == 6)
                          return s88;
                      if (x == 14 && y == 6)
                          return s89;
                      if (x == 15 && y == 6)
                          return s90;
                      if (x == 1 && y == 7)
                          return s91;
                      if (x == 2 && y == 7)
                          return s92;
                      if (x == 3 && y == 7)
                          return s93;
                      if (x == 4 && y == 7)
                          return s94;
                      if (x == 5 && y == 7)
                          return s95;
                      if (x == 6 && y == 7)
                          return s96;
                      if (x == 7 && y == 7)
                          return s97;
                      if (x == 8 && y == 7)
                          return s98;
                      if (x == 9 && y == 7)
                          return s99;
                      if (x == 10 && y == 7)
                          return s100;
                      if (x == 11 && y == 7)
                          return s101;
                      if (x == 12 && y == 7)
                          return s102;
                      if (x == 13 && y == 7)
                          return s103;
                      if (x == 14 && y == 7)
                          return s104;
                      if (x == 15 && y == 7)
                          return s105;
                      if (x == 1 && y == 8)
                          return s106;
                      if (x == 2 && y == 8)
                          return s107;
                      if (x == 3 && y == 8)
                          return s108;
                      if (x == 4 && y == 8)
                          return s109;
                      if (x == 5 && y == 8)
                          return s110;
                      if (x == 6 && y == 8)
                          return s111;
                      if (x == 7 && y == 8)
                          return s112;
                      if (x == 8 && y == 8)
                          return s113;
                      if (x == 9 && y == 8)
                          return s114;
                      if (x == 10 && y == 8)
                          return s115;
                      if (x == 11 && y == 8)
                          return s116;
                      if (x == 12 && y == 8)
                          return s117;
                      if (x == 13 && y == 8)
                          return s118;
                      if (x == 14 && y == 8)
                          return s119;
                      if (x == 15 && y == 8)
                          return s120;
                      if (x == 1 && y == 9)
                          return s121;
                      if (x == 2 && y == 9)
                          return s122;
                      if (x == 3 && y == 9)
                          return s123;
                      if (x == 4 && y == 9)
                          return s124;
                      if (x == 5 && y == 9)
                          return s125;
                      if (x == 6 && y == 9)
                          return s126;
                      if (x == 7 && y == 9)
                          return s127;
                      if (x == 8 && y == 9)
                          return s128;
                      if (x == 9 && y == 9)
                          return s129;
                      if (x == 10 && y == 9)
                          return s130;
                      if (x == 11 && y == 9)
                          return s131;
                      if (x == 12 && y == 9)
                          return s132;
                      if (x == 13 && y == 9)
                          return s133;
                      if (x == 14 && y == 9)
                          return s134;
                      if (x == 15 && y == 9)
                          return s135;
                      if (x == 1 && y == 10)
                          return s136;
                      if (x == 2 && y == 10)
                          return s137;
                      if (x == 3 && y == 10)
                          return s138;
                      if (x == 4 && y == 10)
                          return s139;
                      if (x == 5 && y == 10)
                          return s140;
                      if (x == 6 && y == 10)
                          return s141;
                      if (x == 7 && y == 10)
                          return s142;
                      if (x == 8 && y == 10)
                          return s143;
                      if (x == 9 && y == 10)
                          return s144;
                      if (x == 10 && y == 10)
                          return s145;
                      if (x == 11 && y == 10)
                          return s146;
                      if (x == 12 && y == 10)
                          return s147;
                      if (x == 13 && y == 10)
                          return s148;
                      if (x == 14 && y == 10)
                          return s149;
                      if (x == 15 && y == 10)
                          return s150;
                      if (x == 1 && y == 11)
                          return s151;
                      if (x == 2 && y == 11)
                          return s152;
                      if (x == 3 && y == 11)
                          return s153;
                      if (x == 4 && y == 11)
                          return s154;
                      if (x == 5 && y == 11)
                          return s155;
                      if (x == 6 && y == 11)
                          return s156;
                      if (x == 7 && y == 11)
                          return s157;
                      if (x == 8 && y == 11)
                          return s158;
                      if (x == 9 && y == 11)
                          return s159;
                      if (x == 10 && y == 11)
                          return s160;
                      if (x == 11 && y == 11)
                          return s161;
                      if (x == 12 && y == 11)
                          return s162;
                      if (x == 13 && y == 11)
                          return s163;
                      if (x == 14 && y == 11)
                          return s164;
                      if (x == 15 && y == 11)
                          return s165;
                      if (x == 1 && y == 12)
                          return s166;
                      if (x == 2 && y == 12)
                          return s167;
                      if (x == 3 && y == 12)
                          return s168;
                      if (x == 4 && y == 12)
                          return s169;
                      if (x == 5 && y == 12)
                          return s170;
                      if (x == 6 && y == 12)
                          return s171;
                      if (x == 7 && y == 12)
                          return s172;
                      if (x == 8 && y == 12)
                          return s173;
                      if (x == 9 && y == 12)
                          return s174;
                      if (x == 10 && y == 12)
                          return s175;
                      if (x == 11 && y == 12)
                          return s176;
                      if (x == 12 && y == 12)
                          return s177;
                      if (x == 13 && y == 12)
                          return s178;
                      if (x == 14 && y == 12)
                          return s179;
                      if (x == 15 && y == 12)
                          return s180;
                      if (x == 1 && y == 13)
                          return s181;
                      if (x == 2 && y == 13)
                          return s182;
                      if (x == 3 && y == 13)
                          return s183;
                      if (x == 4 && y == 13)
                          return s184;
                      if (x == 5 && y == 13)
                          return s185;
                      if (x == 6 && y == 13)
                          return s186;
                      if (x == 7 && y == 13)
                          return s187;
                      if (x == 8 && y == 13)
                          return s188;
                      if (x == 9 && y == 13)
                          return s189;
                      if (x == 10 && y == 13)
                          return s190;
                      if (x == 11 && y == 13)
                          return s191;
                      if (x == 12 && y == 13)
                          return s192;
                      if (x == 13 && y == 13)
                          return s193;
                      if (x == 14 && y == 13)
                          return s194;
                      if (x == 15 && y == 13)
                          return s195;
                      if (x == 1 && y == 14)
                          return s196;
                      if (x == 2 && y == 14)
                          return s197;
                      if (x == 3 && y == 14)
                          return s198;
                      if (x == 4 && y == 14)
                          return s199;
                      if (x == 5 && y == 14)
                          return s200;
                      if (x == 6 && y == 14)
                          return s201;
                      if (x == 7 && y == 14)
                          return s202;
                      if (x == 8 && y == 14)
                          return s203;
                      if (x == 9 && y == 14)
                          return s204;
                      if (x == 10 && y == 14)
                          return s205;
                      if (x == 11 && y == 14)
                          return s206;
                      if (x == 12 && y == 14)
                          return s207;
                      if (x == 13 && y == 14)
                          return s208;
                      if (x == 14 && y == 14)
                          return s209;
                      if (x == 15 && y == 13)
                          return s210;
                      if (x == 1 && y == 15)
                          return s211;
                      if (x == 2 && y == 15)
                          return s212;
                      if (x == 3 && y == 15)
                          return s213;
                      if (x == 4 && y == 15)
                          return s214;
                      if (x == 5 && y == 15)
                          return s215;
                      if (x == 6 && y == 15)
                          return s216;
                      if (x == 7 && y == 15)
                          return s217;
                      if (x == 8 && y == 15)
                          return s218;
                      if (x == 9 && y == 15)
                          return s219;
                      if (x == 10 && y == 15)
                          return s220;
                      if (x == 11 && y == 15)
                          return s221;
                      if (x == 12 && y == 15)
                          return s222;
                      if (x == 13 && y == 15)
                          return s223;
                      if (x == 14 && y == 15)
                          return s224;
                      if (x == 15 && y == 15)
                          return s225;
                return filler;
            }
                  set
                  {
                if (x == 1 && y == 1)
                     s1 = value;
                if (x == 2 && y == 1)
                     s2 = value;
                if (x == 3 && y == 1)
                     s3 = value;
                if (x == 4 && y == 1)
                     s4 = value;
                if (x == 5 && y == 1)
                     s5 = value;
                if (x == 6 && y == 1)
                     s6 = value;
                if (x == 7 && y == 1)
                     s7 = value;
                if (x == 8 && y == 1)
                     s8 = value;
                if (x == 9 && y == 1)
                     s9 = value;
                if (x == 10 && y == 1)
                     s10 = value;
                if (x == 11 && y == 1)
                     s11 = value;
                if (x == 12 && y == 1)
                     s12 = value;
                if (x == 13 && y == 1)
                     s13 = value;
                if (x == 14 && y == 1)
                     s14 = value;
                if (x == 15 && y == 1)
                     s15 = value;
                if (x == 1 && y == 2)
                     s16 = value;
                if (x == 2 && y == 2)
                     s17 = value;
                if (x == 3 && y == 2)
                     s18 = value;
                if (x == 4 && y == 2)
                     s19 = value;
                if (x == 5 && y == 2)
                     s20 = value;
                if (x == 6 && y == 2)
                     s21 = value;
                if (x == 7 && y == 2)
                     s22 = value;
                if (x == 8 && y == 2)
                     s23 = value;
                if (x == 9 && y == 2)
                     s24 = value;
                if (x == 10 && y == 2)
                     s25 = value;
                if (x == 11 && y == 2)
                     s26 = value;
                if (x == 12 && y == 2)
                     s27 = value;
                if (x == 13 && y == 2)
                     s28 = value;
                if (x == 14 && y == 2)
                     s29 = value;
                if (x == 15 && y == 2)
                     s30 = value;
                if (x == 1 && y == 3)
                     s31 = value;
                if (x == 2 && y == 3)
                     s32 = value;
                if (x == 3 && y == 3)
                     s33 = value;
                if (x == 4 && y == 3)
                     s34 = value;
                if (x == 5 && y == 3)
                     s35 = value;
                if (x == 6 && y == 3)
                     s36 = value;
                if (x == 7 && y == 3)
                     s37 = value;
                if (x == 8 && y == 3)
                     s38 = value;
                if (x == 9 && y == 3)
                     s39 = value;
                if (x == 10 && y == 3)
                     s40 = value;
                if (x == 11 && y == 3)
                     s41 = value;
                if (x == 12 && y == 3)
                     s42 = value;
                if (x == 13 && y == 3)
                     s43 = value;
                if (x == 14 && y == 3)
                     s44 = value;
                if (x == 15 && y == 3)
                     s45 = value;
                if (x == 1 && y == 4)
                     s46 = value;
                if (x == 2 && y == 4)
                     s47 = value;
                if (x == 3 && y == 4)
                     s48 = value;
                if (x == 4 && y == 4)
                     s49 = value;
                if (x == 5 && y == 4)
                     s50 = value;
                if (x == 6 && y == 4)
                     s51 = value;
                if (x == 7 && y == 4)
                     s52 = value;
                if (x == 8 && y == 4)
                     s53 = value;
                if (x == 9 && y == 4)
                     s54 = value;
                if (x == 10 && y == 4)
                     s55 = value;
                if (x == 11 && y == 4)
                     s56 = value;
                if (x == 12 && y == 4)
                     s57 = value;
                if (x == 13 && y == 4)
                     s58 = value;
                if (x == 14 && y == 4)
                     s59 = value;
                if (x == 15 && y == 4)
                     s60 = value;
                if (x == 1 && y == 5)
                     s61 = value;
                if (x == 2 && y == 5)
                     s62 = value;
                if (x == 3 && y == 5)
                     s63 = value;
                if (x == 4 && y == 5)
                     s64 = value;
                if (x == 5 && y == 5)
                     s65 = value;
                if (x == 6 && y == 5)
                     s66 = value;
                if (x == 7 && y == 5)
                     s67 = value;
                if (x == 8 && y == 5)
                     s68 = value;
                if (x == 9 && y == 5)
                     s69 = value;
                if (x == 10 && y == 5)
                     s70 = value;
                if (x == 11 && y == 5)
                     s71 = value;
                if (x == 12 && y == 5)
                     s72 = value;
                if (x == 13 && y == 5)
                     s73 = value;
                if (x == 14 && y == 5)
                     s74 = value;
                if (x == 15 && y == 5)
                     s75 = value;
                if (x == 1 && y == 6)
                     s76 = value;
                if (x == 2 && y == 6)
                     s77 = value;
                if (x == 3 && y == 6)
                     s78 = value;
                if (x == 4 && y == 6)
                     s79 = value;
                if (x == 5 && y == 6)
                     s80 = value;
                if (x == 6 && y == 6)
                     s81 = value;
                if (x == 7 && y == 6)
                     s82 = value;
                if (x == 8 && y == 6)
                     s83 = value;
                if (x == 9 && y == 6)
                     s84 = value;
                if (x == 10 && y == 6)
                     s85 = value;
                if (x == 11 && y == 6)
                     s86 = value;
                if (x == 12 && y == 6)
                     s87 = value;
                if (x == 13 && y == 6)
                     s88 = value;
                if (x == 14 && y == 6)
                     s89 = value;
                if (x == 15 && y == 6)
                     s90 = value;
                if (x == 1 && y == 7)
                     s91 = value;
                if (x == 2 && y == 7)
                     s92 = value;
                if (x == 3 && y == 7)
                     s93 = value;
                if (x == 4 && y == 7)
                     s94 = value;
                if (x == 5 && y == 7)
                     s95 = value;
                if (x == 6 && y == 7)
                     s96 = value;
                if (x == 7 && y == 7)
                     s97 = value;
                if (x == 8 && y == 7)
                     s98 = value;
                if (x == 9 && y == 7)
                     s99 = value;
                if (x == 10 && y == 7)
                     s100 = value;
                if (x == 11 && y == 7)
                     s101 = value;
                if (x == 12 && y == 7)
                     s102 = value;
                if (x == 13 && y == 7)
                     s103 = value;
                if (x == 14 && y == 7)
                     s104 = value;
                if (x == 15 && y == 7)
                     s105 = value;
                if (x == 1 && y == 8)
                     s106 = value;
                if (x == 2 && y == 8)
                     s107 = value;
                if (x == 3 && y == 8)
                     s108 = value;
                if (x == 4 && y == 8)
                     s109 = value;
                if (x == 5 && y == 8)
                     s110 = value;
                if (x == 6 && y == 8)
                     s111 = value;
                if (x == 7 && y == 8)
                     s112 = value;
                if (x == 8 && y == 8)
                     s113 = value;
                if (x == 9 && y == 8)
                     s114 = value;
                if (x == 10 && y == 8)
                     s115 = value;
                if (x == 11 && y == 8)
                     s116 = value;
                if (x == 12 && y == 8)
                     s117 = value;
                if (x == 13 && y == 8)
                     s118 = value;
                if (x == 14 && y == 8)
                     s119 = value;
                if (x == 15 && y == 8)
                     s120 = value;
                if (x == 1 && y == 9)
                     s121 = value;
                if (x == 2 && y == 9)
                     s122 = value;
                if (x == 3 && y == 9)
                     s123 = value;
                if (x == 4 && y == 9)
                     s124 = value;
                if (x == 5 && y == 9)
                     s125 = value;
                if (x == 6 && y == 9)
                     s126 = value;
                if (x == 7 && y == 9)
                     s127 = value;
                if (x == 8 && y == 9)
                     s128 = value;
                if (x == 9 && y == 9)
                     s129 = value;
                if (x == 10 && y == 9)
                     s130 = value;
                if (x == 11 && y == 9)
                     s131 = value;
                if (x == 12 && y == 9)
                     s132 = value;
                if (x == 13 && y == 9)
                     s133 = value;
                if (x == 14 && y == 9)
                     s134 = value;
                if (x == 15 && y == 9)
                     s135 = value;
                if (x == 1 && y == 10)
                     s136 = value;
                if (x == 2 && y == 10)
                     s137 = value;
                if (x == 3 && y == 10)
                     s138 = value;
                if (x == 4 && y == 10)
                     s139 = value;
                if (x == 5 && y == 10)
                     s140 = value;
                if (x == 6 && y == 10)
                     s141 = value;
                if (x == 7 && y == 10)
                     s142 = value;
                if (x == 8 && y == 10)
                     s143 = value;
                if (x == 9 && y == 10)
                     s144 = value;
                if (x == 10 && y == 10)
                     s145 = value;
                if (x == 11 && y == 10)
                     s146 = value;
                if (x == 12 && y == 10)
                     s147 = value;
                if (x == 13 && y == 10)
                     s148 = value;
                if (x == 14 && y == 10)
                     s149 = value;
                if (x == 15 && y == 10)
                     s150 = value;
                if (x == 1 && y == 11)
                     s151 = value;
                if (x == 2 && y == 11)
                     s152 = value;
                if (x == 3 && y == 11)
                     s153 = value;
                if (x == 4 && y == 11)
                     s154 = value;
                if (x == 5 && y == 11)
                     s155 = value;
                if (x == 6 && y == 11)
                     s156 = value;
                if (x == 7 && y == 11)
                     s157 = value;
                if (x == 8 && y == 11)
                     s158 = value;
                if (x == 9 && y == 11)
                     s159 = value;
                if (x == 10 && y == 11)
                     s160 = value;
                if (x == 11 && y == 11)
                     s161 = value;
                if (x == 12 && y == 11)
                     s162 = value;
                if (x == 13 && y == 11)
                     s163 = value;
                if (x == 14 && y == 11)
                     s164 = value;
                if (x == 15 && y == 11)
                     s165 = value;
                if (x == 1 && y == 12)
                     s166 = value;
                if (x == 2 && y == 12)
                     s167 = value;
                if (x == 3 && y == 12)
                     s168 = value;
                if (x == 4 && y == 12)
                     s169 = value;
                if (x == 5 && y == 12)
                     s170 = value;
                if (x == 6 && y == 12)
                     s171 = value;
                if (x == 7 && y == 12)
                     s172 = value;
                if (x == 8 && y == 12)
                     s173 = value;
                if (x == 9 && y == 12)
                     s174 = value;
                if (x == 10 && y == 12)
                     s175 = value;
                if (x == 11 && y == 12)
                     s176 = value;
                if (x == 12 && y == 12)
                     s177 = value;
                if (x == 13 && y == 12)
                     s178 = value;
                if (x == 14 && y == 12)
                     s179 = value;
                if (x == 15 && y == 12)
                     s180 = value;
                if (x == 1 && y == 13)
                     s181 = value;
                if (x == 2 && y == 13)
                     s182 = value;
                if (x == 3 && y == 13)
                     s183 = value;
                if (x == 4 && y == 13)
                     s184 = value;
                if (x == 5 && y == 13)
                     s185 = value;
                if (x == 6 && y == 13)
                     s186 = value;
                if (x == 7 && y == 13)
                     s187 = value;
                if (x == 8 && y == 13)
                     s188 = value;
                if (x == 9 && y == 13)
                     s189 = value;
                if (x == 10 && y == 13)
                     s190 = value;
                if (x == 11 && y == 13)
                     s191 = value;
                if (x == 12 && y == 13)
                     s192 = value;
                if (x == 13 && y == 13)
                     s193 = value;
                if (x == 14 && y == 13)
                     s194 = value;
                if (x == 15 && y == 13)
                     s195 = value;
                if (x == 1 && y == 14)
                     s196 = value;
                if (x == 2 && y == 14)
                     s197 = value;
                if (x == 3 && y == 14)
                     s198 = value;
                if (x == 4 && y == 14)
                     s199 = value;
                if (x == 5 && y == 14)
                     s200 = value;
                if (x == 6 && y == 14)
                     s201 = value;
                if (x == 7 && y == 14)
                     s202 = value;
                if (x == 8 && y == 14)
                     s203 = value;
                if (x == 9 && y == 14)
                     s204 = value;
                if (x == 10 && y == 14)
                     s205 = value;
                if (x == 11 && y == 14)
                     s206 = value;
                if (x == 12 && y == 14)
                     s207 = value;
                if (x == 13 && y == 14)
                     s208 = value;
                if (x == 14 && y == 14)
                     s209 = value;
                if (x == 15 && y == 13)
                     s210 = value;
                if (x == 1 && y == 15)
                     s211 = value;
                if (x == 2 && y == 15)
                     s212 = value;
                if (x == 3 && y == 15)
                     s213 = value;
                if (x == 4 && y == 15)
                     s214 = value;
                if (x == 5 && y == 15)
                     s215 = value;
                if (x == 6 && y == 15)
                     s216 = value;
                if (x == 7 && y == 15)
                     s217 = value;
                if (x == 8 && y == 15)
                     s218 = value;
                if (x == 9 && y == 15)
                     s219 = value;
                if (x == 10 && y == 15)
                     s220 = value;
                if (x == 11 && y == 15)
                     s221 = value;
                if (x == 12 && y == 15)
                     s222 = value;
                if (x == 13 && y == 15)
                     s223 = value;
                if (x == 14 && y == 15)
                     s224 = value;
                if (x == 15 && y == 15)
                     s225 = value;
            }
              }
              /* 
      ----------------------------------------------------------------------------------------------------------------
      * DisplayIntBoardToFile -
      --------------------------------------------------------------------------------------------------------------------------
      This method constructs the initial state of the board of the current board with the counter symbols
      in string format, which is then printed to a text file. 
      --------------------------------------------------------------------------------------------------------------------------
      */
                public void DisplayIntBoardToFile()
        {
            string path = @"data/intboards.txt";
            int number = Program.cntr;
            // ... Cases may not be duplicated.
            File.WriteAllText(@"data/intboards.txt", string.Empty);

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                switch (number)
                {
                    case 0:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e  | e | e |  O     | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 1:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e  | e | e |  O     | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 2:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | X | X | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 3:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | X | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | X | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 4:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | e | X | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | e | X | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 5:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | X | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | O | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | X | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 6:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e | e |   X | X    | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e | e | e | X | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 7:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | e | O | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 8:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | X | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e | e | O | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 9:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | X | e | X |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e | e | O |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e | e | O |");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e | e | O |");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 10:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | e | X | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | e | X | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | e | O | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e | e | O | O | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write("5  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e | e | X | X  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 11:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | O | e | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | X | e |  e  | e | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 12:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | X | e  | e | e | X | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | X | e | O | e | O | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | e | O | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | O | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e | X | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e | e | X | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 13:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | X | X | O | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e |   X | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e | e | X | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 14:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | e | O | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | X | e | X | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | X | e | X | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 15:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | O | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 16:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | O | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 17:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | X | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | X | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 18:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 19:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | X | O | O | e | O | e | X |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | O | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | X | O | X | O | X | O | X |");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 20:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | X | O | O | e | O | e | X |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | O | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | X | O | X | O | X | O | X |");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 21:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 22:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | O |  O  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 23:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 24:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e | X | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e | e | e | O | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 25:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | X | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | X | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 26:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | O | e | O |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 27:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e | e | O | O | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e | e | e | O | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 28:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | e | X | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 29:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | e | X | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | O | e | e | X | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e | e | X | e | e | O | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 30:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | e | X | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e | O | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 31:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | X | e | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e | e | X | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | O | e |  e  | e | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 32:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | O | e | X | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | e | X | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | X | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e | O | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 33:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | O | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | X | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | O | O | X | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e | O | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 34:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e | e | O | e | e | ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e | e | O | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e | e | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e | e | e | X | X | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | O | e | e | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | e | O | O | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | O | e | O | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 35:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | X | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 36:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | X | O | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 37:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e | e | e | X | e | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 38:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2   | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5  | e |  e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 39:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | X | X  | e | X | e | O |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | X | e  | e |  e  | e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | O | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | X | e |  e  | e |  e  | e | e |  ");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | O | X |O  | X | O | X | O |");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    case 40:
                        sw.Write("see below");
                        sw.Write(Environment.NewLine); sw.Write("  1   2   3   4   5   6   7  ");
                        sw.Write(Environment.NewLine);
                        sw.Write("1 | O | X | X | O | X | O | O  |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("2 | X | e  | e |  e  | e | e | O |");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("3 | O | e |  e  | e | e | e | X |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("4 | X | e |  e  | e | e | e | O |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("5 | O | e |  e  | e | e | e | X |");
                        sw.Write(Environment.NewLine);
                        sw.Write("- - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("6 | X | e |  e  | e | e | e | X |");
                        sw.Write(Environment.NewLine);
                        sw.Write(" - - - - - - -");
                        sw.Write(Environment.NewLine);
                        sw.Write("7 | O | X |O  | X | O | X | O |");
                        sw.Write(Environment.NewLine); sw.Write("^^ INT BOARD FOR BOARD " + Program.cntr);
                        sw.Write(Environment.NewLine);
                        return;
                    default:
                        Environment.Exit(99);
                        break;
                }
            }
        }
    }
}
