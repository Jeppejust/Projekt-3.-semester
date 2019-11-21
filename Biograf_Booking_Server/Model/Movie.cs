using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Client_Project.Model
{
    class Movie
    {
        public string Title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string Resume
        {
            get { return Resume; }
            set { Resume = value; }
        }
        public int PremiereDate
        {
            get { return PremiereDate; }
            set { PremiereDate = value; }
        }
        public string Genre
        {
            get { return Genre; }
            set { Genre = value; }
        }
        public string Instructor
        {
            get { return Instructor; }
            set { Instructor = value; }
        }
        public int MovieId
        {
            get { return MovieId; }
            set { MovieId = value; }
        }
        public int MovieLength
        {
            get { return MovieLength; }
            set { MovieLength = value; }
        }
    }
}
