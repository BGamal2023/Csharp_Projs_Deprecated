﻿using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test._2_Deps._3_Snake_Food_Handler
{
    internal class Snake_Food_Handler
    {

    
        //-------------------------------------------------------------------------
        public void add_Snake_Food(Grid gameArea)
        {
            Snake_Food new_Snake_Food= new Snake_Food();
            new_Snake_Food.uiElement = new Rectangle()
            {
                Width = Snake_Parts.snake_Width,
                Height = Snake_Parts.snake_Height,
                Fill = Brushes.Aqua,
                Stroke = Brushes.Black,
                StrokeThickness = 1

            };

           
            var nextCol = new Random();
            var nextRow=new Random();
         
            Grid.SetColumn(new_Snake_Food.uiElement,nextCol.Next(0,Globals.No_Of_gameArea_Cols ));
            Grid.SetRow(new_Snake_Food.uiElement, nextRow.Next(0,Globals.No_Of_gameArea_Rows));
            gameArea.Children.Add(new_Snake_Food.uiElement);
            Globals.list_Snake_Food.Add(new_Snake_Food);
            Globals.isFoodCollisionOccurred = false;
        }
        //-----------------------------------------------------------
        public void eat_Snake_Food(Grid gameArea)
        {

           gameArea.Children.Remove( Globals.list_Snake_Food[0].uiElement);
            Globals.list_Snake_Food.Clear();
        }
    }
}