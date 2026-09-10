using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblReferrals
{
    public int Idnum { get; set; }

    public bool IndividualTherapy { get; set; }

    public bool FamilyTherapy { get; set; }

    public bool DomesticViolenceAssessment { get; set; }

    public bool AngerManagementAssessment { get; set; }

    public bool HighConflictParentingClass { get; set; }

    public bool ParentCoordinator { get; set; }

    public bool JobServices { get; set; }

    public bool Housing { get; set; }

    public bool FamilyResources { get; set; }
}
