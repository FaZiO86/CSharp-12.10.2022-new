using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_12._10._2022_new {
    enum DayOfWeek {
        monday,
        tuesday,
        wednesday,
        thursday,
        fridat,
        saturday,
        sunday
    }
    class EmployerTime {
        
        private int[] workTime;
        public EmployerTime() { 
            workTime = new int[7];
           
        }
        
        public int this[int index] {
            
            set { if (value > 0 && value < 8)
                    { workTime[index] = value; } 
                else 
                {  workTime[index] = 0; } 
            }
            get { return workTime[index]; }
        }
         
        public void Print() {
            foreach (var day in Enum.GetValues(typeof(DayOfWeek))) { 
                
                Console.WriteLine($"день {day}, отработано {workTime[(int)day]} часов");
            }
        }
    }
}
