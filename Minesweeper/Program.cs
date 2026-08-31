namespace Minesweeper {
    internal class Program {
        static void Main(string[] args) {

            int rowCount = 5;
            int colCount = 5;
            Cell[,] minefield = new Cell[rowCount,colCount];
            for (int i = 0; i < minefield.GetLength(0); i++) {
                for (int k = 0; k < minefield.GetLength(1); k++) {
                    bool hasMine = false;
                    if (i == 3 && k == 2) {
                        hasMine = true;
                    }
                    minefield[i, k] = new Cell(hasMine);
                }
            }

            //minefield[3, 2].HasMine = true;

            while (true) {
                Console.Clear();
                PrintBoard(minefield);

                Console.WriteLine("Bitte Feld eingeben: ");
                var field = Console.ReadLine();

                if (field == "q") {
                    break;
                }
                RevealField(minefield, field);
            }
        }

        static void PrintBoard(Cell[,] board) {
            Console.Write("  ");
            for (int i = 0; i < board.GetLength(1); i++) {
                Console.Write($"{i+1} ");
            }
            Console.WriteLine();

            for (int i = 0; i < board.GetLength(0); i++) {
                Console.Write($"{(char)(65+i)} ");
                for (int k = 0; k < board.GetLength(1); k++) {
                    if (!board[i, k].IsRevealed) {
                        Console.Write("x ");
                    } else if(board[i, k].HasMine) {
                        Console.Write("b ");
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void RevealField(Cell[,] board, string field) {
            // C2

            var rowChar = field.Substring(0, 1);
            var row = (int)char.Parse(rowChar);
            row -= 65;

            var colChar = field.Substring(1);
            var col = int.Parse(colChar)-1;

            board[row, col].IsRevealed = true;
        }
    }

    public class Cell {

        public Cell(bool hasMine) {
            HasMine = hasMine;
        }

        public bool IsRevealed { get; set; }
        public bool HasMine { get; }
        public bool IsFlagged { get; set; }
    }
}
