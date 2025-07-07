using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

using ProtoBuf;

namespace Workflow.DTO.Models
{
	
	
    public partial class ProgramViolatedUnderwritingRule : Workflow.DTO.Models.IdentityPersistentEntity
	{
		
		
		public Guid ProgramGID { get; set; }

		
		
		public Guid? InsuranceObjectGID { get; set; }

		
		
		public Guid ViolatedUnderwritingRuleGID { get; set; }

		public ViolatedUnderwritingRule ViolatedUnderwritingRule { get; set; }
	}
}