namespace Library;

public class Board
{

    public string line1 = "+---+---+---+---+---+---+---+---+";
    public string field_black = "|   ";
    public string field_white = "| # ";

    public override string ToString()
    {
        string result = "";
        result += line1;
        result += $"{Environment.NewLine}";
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                if ((x % 2 == 0 && y % 2 == 0) || (x % 2 == 1 && y % 2 == 1))
                {
                    result += field_black;
                }
                else
                {
                    result += field_white;
                }
            }
            result += "|";
            result += $"{Environment.NewLine}";
            result += line1;
            result += $"{Environment.NewLine}";

        }
        return result;
    }

}

public class Figure
{
    
}


