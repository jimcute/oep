//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Exam_Portal.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionPaper
    {
        public int ID { get; set; }
        public string QuestionPaperName { get; set; }
        public Nullable<decimal> TotalObjQues { get; set; }
        public Nullable<decimal> QuesMarkPerQues { get; set; }
        public Nullable<decimal> ObjQuesMark { get; set; }
        public Nullable<decimal> PracticalQuesMark { get; set; }
        public Nullable<decimal> TotalMarks { get; set; }
        public Nullable<decimal> PassingMark { get; set; }
        public string ObjExamTime { get; set; }
    }
}
