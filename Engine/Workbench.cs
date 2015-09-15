using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Workbench
    {
        //Class-level variables
        public int classVariable1 = 3; // Visible to other classes
        private int classVariable2 = 7; // Only visible to this class
        private int classVariable3; // Declaring the variable, without setting a value


        public void Function1()
        {
            int functionVariable1;

            if (classVariable1 < 5)
            {
                functionVariable1 = 1;

                int innerVariable1;
            }

            if (classVariable1 >= 5)
            {
                functionVariable1 = 2;

                int innerVariables1;

            }
        }
        public void Fuction2()
        {
            int functionVariable1;

            if (classVariable2 < 5)
            {
                functionVariable1 = 3;

                int innerVariable1;
            }

            if (classVariable2 >= 5)
            {
                functionVariable1 = 4;

                int innerVariable1;
            }
        }


        public bool IsPlayerStillAlive(int currentHitPoints)
        {
            if (currentHitPoints > 0)
            {
                return true;
            }

            return false;
        }

        public bool IsPlayStillAlive2(int currentHitPoints)
        {
            if (currentHitPoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPlayStillAlive3(int currentHitPoints, bool hasResurrectionRing)
        {
            if ((currentHitPoints > 0) || ((currentHitPoints == 0) && hasResurrectionRing))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ComputerPlayerLevel(int experiencePoints)
        {
            if (experiencePoints < 100)
            {
                return 1; // Player is level 1
            }
            else if (experiencePoints < 250)
            {
                return 2; // Player is level 2
            }
            else if (experiencePoints < 500)
            {
                return 3; // Player is level 3
            }
            else if (experiencePoints < 1000)
            {
                return 4; // Player is level 4
            }
            return 5; // The maximum level is 5, in this sample
        }


     
   

    }
}
