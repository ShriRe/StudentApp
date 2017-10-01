using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuNewStudentApp
{
   public enum StudentType {
       Masters,
       Undergraduate,
       PHD,
       Doctraite


    }

    /// <summary>
    /// This is Add new student application 
    /// </summary>
   public class AddStudent
    {
        private static int LastStudentId = 0;
  



#region Properties
        /// <summary>
        /// This holds the New Student Application ID
        /// </summary>
        public int StudentId { get;}
        /// <summary>
        /// This holds the New students best reachable Email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// This holds the new students undergraduate GPA
        /// </summary>
        public decimal GradGPA { get; private set; }
        /// <summary>
        /// This holds the new students application for Masters or PHD etc..
        /// </summary>
        public StudentType StudentType { get; set; }
        /// <summary>
        /// This holds the new student application created date
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion

        #region constructor

        public AddStudent ()
        {
            StudentId = ++LastStudentId;
        }

#endregion

        #region Methods
        public decimal GPA (decimal criteria)
        {
            GradGPA += criteria; //take my existing GPA and add 
            return GradGPA;
        }
        /// <summary>
        /// This method holds if the student doesn't  meet minimum GPA criteria 3.0 then reject application
        /// </summary>
        /// <param name="criteria"></param>
        
        public void Reject (decimal criteria)
        {
            GradGPA -= criteria;
        }

#endregion

    }
}
