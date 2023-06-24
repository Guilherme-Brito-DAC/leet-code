public class Solution
    {
        public bool IsRobotBounded(string instructions) 
        {
            char[] movimentos = instructions.ToCharArray();
            int x = 0;
            int y = 0;
            string rotacao = "Norte";

            do 
	        {
                foreach (char movimento in movimentos)
	            {
                    if (movimento == 'L')
                    {
                        if (rotacao == "Norte")
                            rotacao = "Oeste";
                        else if (rotacao == "Oeste")
                            rotacao = "Sul";
                        else if (rotacao == "Sul")
                            rotacao = "Leste";
                        else if (rotacao == "Leste")
                            rotacao = "Norte";
                    }

                    if (movimento == 'R')
                    {
                        if (rotacao == "Norte")
                            rotacao = "Leste";
                        else if (rotacao == "Leste")
                            rotacao = "Sul";
                        else if (rotacao == "Sul")
                            rotacao = "Oeste";
                        else if (rotacao == "Oeste")
                            rotacao = "Norte";
                    }

                    if (movimento == 'G')
                    {
                        if (rotacao == "Norte")
                            x++;

                        if (rotacao == "Leste")
                            y++;

                        if (rotacao == "Sul")
                            x--;

                        if (rotacao == "Oeste")
                            y--;
                    }
	            }
	        } while (rotacao != "Norte");

            return x == 0 && y == 0;
        }
    }