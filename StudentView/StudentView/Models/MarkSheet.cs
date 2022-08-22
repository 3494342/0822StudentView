using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentView.Models
{
    public class MarkSheet
    {
        public Student MyStudent { get; set; }
        public Assessment Assessment { get; set; }

        public int Total
        {
            
            get
            {
                return Assessment.MVCMarks + Assessment.BootstrapMarks + Assessment.CsharpMarks;
            }
        }
    }
}