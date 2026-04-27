namespace Library;

public class Board{

    public string line1 = "+---+---+---+---+---+---+---+---+";
    public string line2 = "|   ";
    public string line3 = "| # ";

    public override string ToString()
    {
        string result = "";
        for(int y = 0; y < 8; y++){
            for(int x = 0; x < 8; x++){
                if(y / 2 % == 0){
                    result += line1;
                    result += "\n";
                    
                }
                
            }
        }
        return result;
    }
    
}


