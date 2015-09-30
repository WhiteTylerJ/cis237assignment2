using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably necessary to print the solution.
    /// If you are real ambitious, you could make a separate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level member variable for the maze solver class
        /// </summary>
        char[,] maze;
        int rowStart;
        int colStart;

        /// <summary>
        /// Default Constructor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int rowStart, int colStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constructor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.rowStart = rowStart;
            this.colStart = colStart;

            //Do work needed to use mazeTraversal recursive call and solve the maze.

            //find maze exit
            //initialize variable
            int rowExit = 0;
            int colExit = 0;
            //find size of maze
            int numOfRows = maze.GetLength(0) - 1;
            int numOfCol = maze.GetLength(1) - 1;

            //look in first and last rows for exit
            for (int i = 0; i < numOfCol; i++)
            {
                //look in first row for '.'
                if (maze[0, i] == '.')
                {
                    rowExit = 0;
                    colExit = i;
                }
                //look in last row for '.'
                if (maze[numOfRows, i] == '.')
                {
                    rowExit = numOfRows;
                    colExit = i;
                }
            }
            //look in first and last columns for exit
            for (int i = 0; i < numOfRows; i++)
            {
                //look in first column
                if (maze[i,0] == '.')
                {
                    rowExit = i;
                    colExit = 0;
                }
                //look in last column
                if (maze[i, numOfCol] == '.')
                {
                    rowExit = i;
                    colExit = numOfCol;
                }
            } 
         
            Console.WriteLine("The maze ends at: (" + rowExit + "," + colExit + ")");
            Console.Read();

        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal()
        {
            //Implement maze traversal recursive call
        }
    }
}
