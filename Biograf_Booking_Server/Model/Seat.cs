using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Client_Project.Model
{
    class Seat
    {
        public int number
        {
            get { return number; }
            set { number = value; }
        }
        public int row
        {
            get { return row; }
            set { row = value; }
        }
        public int hall
        {
            get { return hall; }
            set { hall = value; }
        }
        public int seatId
        {
            get { return seatId; }
            set { seatId = value; }
        }
    }
}
