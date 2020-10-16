using System;
using System.Collections.Generic;
namespace DrSillyStringzFactory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.EngineerMachine = new HashSet<EngineerMachine>();
            this.EngineerLicense = new HashSet<EngineerMachine>();
        }
        public int EngineerId { get; set; } 
        public string Name { get; set; }
       
        public virtual ICollection<EngineerMachine> EngineerMachine {get;set;}
        public virtual ICollection<EngineerMachine> EngineerLicense {get;set;}

    }
}