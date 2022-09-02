//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefLearnerActivityTypeEntity.g.cs
//* Name:       Learner Activity Type
//* Definition: The type of work assigned to the learner.
//***************************************************************************

/// <summary>
/// Learner Activity Type <see cref="RefLearnerActivityType"/>
/// <para>
/// The type of work assigned to the learner.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19943">Learner Activity Type</a>
/// </para>
/// </summary>
[Table("RefLearnerActivityType", Schema = "Assessments")]
[Comment("The type of work assigned to the learner.")]
public partial class RefLearnerActivityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
