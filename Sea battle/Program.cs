using System;
using System.Data.SqlTypes;

class Program
{
    public static void Main(string[] args)
    {
        int[] ships = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
        int[,] area = new int[10,10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                area[i, j] = 0;
            }
        }
        Random rnd = new Random();
        int AxXY = rnd.Next(0, 200);

        area = placeship(area,AxXY, 4);
        AxXY = rnd.Next(0, 200);
        area = placeship(area,AxXY, 4);
        AxXY = rnd.Next(0, 200);
        area = placeship(area,AxXY, 4);
        AxXY = rnd.Next(0, 200);
        area = placeship(area,AxXY, 4);
        AxXY = rnd.Next(0, 200);
        area = placeship(area,AxXY, 4);
    }
    public static int[,] placeship(int[,] area,int AxXY, int longsp)
    {
        
        
        axis axis = AxXY/100 == 1 ? axis.Vert : axis.Horiz;
        // horiz - X right
        // vert - X down
        int y = AxXY % 10;
        int x = (AxXY % 100) / 10;
        if (axis == axis.Horiz && (AxXY % 100) / 10 > 10 - longsp)
        {
            x = 10 - longsp;
        }
        else if (axis == axis.Vert &&  AxXY % 10 > 10 - longsp)
        {
            y = 10 - longsp;
        }
        Console.WriteLine($"{AxXY} = {axis} {x} {y}\n long = {longsp}");
        for(int ind = 1;ind < 3; ind++)
        { 
            for (int j = 0; j < 10; j++)
            {
                for(int i  = 0; i < 10;i++)
                {
                    if(axis == axis.Horiz)
                    {
                        if(j >= y-1 && j <= y+1 && i >= x-1 && i <= x+longsp && ind == 1)//&& x + 1 >= i && y + 1 <= j+longsp+1 && x - 1 <= i)
                        {
                            area[i, j] = ind;
                        }
                        if (j > y - 1 && j < y + 1 && i > x - 1 && i < x + longsp && ind == 2)
                        {
                            area[i, j] = ind;
                        }
                    }
                    else if(axis == axis.Vert)
                    {
                        if (j >= y - 1 && j <= y + longsp  && i >= x - 1 && i <= x + 1 && ind == 1)//&& x + 1 >= i && y + 1 <= j+longsp+1 && x - 1 <= i)
                        {
                            area[i, j] = ind;
                        }
                        if (j > y - 1 && j < y + longsp  && i > x - 1 && i < x + 1 && ind == 2)
                        {
                            area[i, j] = ind;
                        }
                    }
                    
                }
            }
        }
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                if (area[i,j] == 2 || area[i, j] == 1)
                {
                    Console.Write($"{area[i, j]} ");
                    area[i, j] = 0;
                }
                else
                {
                    Console.Write($"* ");
                }
                
            }
            Console.WriteLine();
        }
        return area;
    }

    public static int[] sortarea(int[,] area)
    {


        return new int[1];
    }

    
}
public enum axis
{
    Vert,
    Horiz
}
