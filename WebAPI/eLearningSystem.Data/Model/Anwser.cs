//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eLearningSystem.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Anwser
    {
        public int id { get; set; }
        public string content { get; set; }
        public string type { get; set; }
        public Nullable<int> question_id { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
